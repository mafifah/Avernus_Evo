global using MediatR;
using bwaAvernus.Server.Data;
using bwaCrixalis.Server.Data;
using Pantheon.Server.RedisCache;
using Pantheon.Shared.Redis;

namespace bwaCrixalis.Server._1._Master;

public class cmhBulkUpdateJenisSupplier_Supplier : IRequestHandler<cmdBulkUpdateJenisSupplier_Supplier, string>
{
	private readonly AvernusDbContext _db;
	private readonly CrixalisDbContext_Log _db_Log;
	private readonly pthIRedisCacheService _redisCache;
	private readonly IStreamPublisher _streamPublisher;
	private static string _namaDatabase = "dbAvernus_Evo";

	public cmhBulkUpdateJenisSupplier_Supplier(AvernusDbContext db, CrixalisDbContext_Log db_Log, pthIRedisCacheService redisCache, IStreamPublisher streamPublisher)
	{
		_db = db;
		_db_Log = db_Log;
		_redisCache = redisCache;
		_streamPublisher = streamPublisher;
	}

	public async Task<string> Handle(cmdBulkUpdateJenisSupplier_Supplier request, CancellationToken cancellationToken)
	{
		var timestamp = DateTimeOffset.UtcNow;
		T0JenisSupplier t0JenisSupplierBaru = await UpdateT0JenisSupplier(request);
		await _redisCache.InsertAtauUpdateItemListRedisById(t0JenisSupplierBaru, request.JenisSupplierUpdate.IdJenisSupplier.ToString());
		bool t0JenisSuplierBerubah = false;

		using var transaction = await _db.Database.BeginTransactionAsync();
		try
		{
			await SetT9LogUpdateT1Supplier(request, timestamp);
			await BulkUpdateJenisSupplier_Suppliers(request);
			await UpdateDataRedisT1Supplier(request);

			//var listLogUpdateT0JenisSupplier = await _db.SaveChangesAsync(nameof(T0JenisSupplier.Jenis));

			//if (listLogUpdateT0JenisSupplier is not null && listLogUpdateT0JenisSupplier.Any() is true)
			//{
			//	_db_Log.AddRange(listLogUpdateT0JenisSupplier);
			//	t0JenisSuplierBerubah = true;
			//}
			if (await _db.SaveChangesAsync() > 0)
			{
				t0JenisSuplierBerubah = true;
			}
			await _db_Log.SaveChangesAsync();
			await transaction.CommitAsync();
		}
		catch (Exception ex)
		{
			if (t0JenisSuplierBerubah)
			{
				t0JenisSupplierBaru.State = $"Gagal~{t0JenisSupplierBaru.IdJenisSupplier}";
				await _redisCache.InsertAtauUpdateItemListRedisById(
								t0JenisSupplierBaru,
								t0JenisSupplierBaru.IdJenisSupplier.ToString());
				await _streamPublisher.PublishAsync($"{_namaDatabase}~{typeof(T0JenisSupplier).Name}", t0JenisSupplierBaru);
			}

			//List<T1Supplier> t1Suppliers = await GetT1Suppliers(t0JenisSupplierBaru.IdJenisSupplier);
			//foreach (var t1Supplier in t1Suppliers)
			//{
			//	request.Adapt(t1Supplier);
			//	t1Supplier.State = $"Gagal~{t1Supplier.IdSupplier}";
			//}
			//TODO: draft redis
			try
			{
				await transaction.RollbackAsync();
			}
			catch (Exception)
			{
				return t0JenisSupplierBaru.State;
			}
			return t0JenisSupplierBaru.State;
		}
		return $"Berhasil~{request.JenisSupplierUpdate.IdJenisSupplier}";
	}

	private async Task UpdateDataRedisT1Supplier(cmdBulkUpdateJenisSupplier_Supplier request)
	{
		var idRedis = $"{_namaDatabase}~{typeof(T1Supplier).Name}";
		var dataRedisSupplier = await _redisCache.GetDataRedis<List<T1Supplier>>(idRedis);
		foreach (var supplier in dataRedisSupplier)
		{
			supplier.Termin = request.Termin;
			supplier.BatasHutangGiro = request.BatasHutangGiro;
			supplier.BatasHutangUsaha = request.BatasHutangUsaha;
		}
		await _redisCache.SetDataRedis<List<T1Supplier>>(idRedis, dataRedisSupplier);
	}

	private async Task<List<T1Supplier>> GetT1Suppliers(Guid idJenisSupplier) =>
		await _db.Set<T1Supplier>()
					.AsNoTracking()
					.Where(x => x.IdJenisSupplier == idJenisSupplier)
					.ToListAsync();

	private async Task<T0JenisSupplier> UpdateT0JenisSupplier(cmdBulkUpdateJenisSupplier_Supplier request)
	{
		var t0JenisSupplierLama = await _db.Set<T0JenisSupplier>().FindAsync(request.JenisSupplierUpdate.IdJenisSupplier);
		if (t0JenisSupplierLama is null)
		{
			throw new RpcException(new Status(StatusCode.NotFound, "Data yang ingin diubah tidak ditemukan. Silahkan memuat data kembali"));
		}
		var t0JenisSupplierBaru = request.JenisSupplierUpdate.Adapt(t0JenisSupplierLama);
		t0JenisSupplierBaru.State = "";
		return t0JenisSupplierBaru;
	}

	private async Task SetT9LogUpdateT1Supplier(cmdBulkUpdateJenisSupplier_Supplier request, DateTimeOffset timestamp)
	{
		var dataT0Form = await _db.Set<pthT0Form>()
							.Select(t => new { t.IdForm, t.NamaPK, t.NamaTabel, t.Kategori, t.Inisial })
							.Where(f => f.Kategori == "2. Master" || f.Kategori == "3. Transaksi")
							.ToListAsync();
		var t1Suppliers = await GetT1Suppliers(request.JenisSupplierUpdate.IdJenisSupplier);

		var logT1Supplier = new pthT9LogRecord
		{
			IdUser = request.JenisSupplierUpdate.IdOperator,
			WaktuInsert = timestamp,
			JenisAktivitas = "Update",
			Tabel = nameof(T1Supplier),
			IdApplication = null,
			KodeInstruksi = null,
			IPv4 = null,
			IPv6 = null
		};

		foreach (var t1Supplier in t1Suppliers)
		{
			var idPrimaryKey = t1Supplier.IdSupplier.ToString();
			var idForm = dataT0Form?.FirstOrDefault(t0 => t0.NamaTabel == nameof(T1Supplier))?.IdForm;

			//set data T9Log untuk kolom Termin
			var logUpdateTermin = pthT9Log.LogBuilder(logT1Supplier);
			logUpdateTermin.IdPrimaryKey = idPrimaryKey;
			logUpdateTermin.Kolom = nameof(t1Supplier.Termin);
			logUpdateTermin.Aktivitas = $"Mengubah Supplier: {t1Supplier.Nama}, kolom {logUpdateTermin.Kolom}, dari {t1Supplier.Termin} menjadi {request.Termin}";
			_db_Log.Add(logUpdateTermin);

			//set data T9Log untuk kolom BatasHutangUsaha
			var logUpdateBatasHutangUsaha = pthT9Log.LogBuilder(logT1Supplier);
			logUpdateBatasHutangUsaha.IdPrimaryKey = idPrimaryKey;
			logUpdateBatasHutangUsaha.Kolom = nameof(t1Supplier.BatasHutangUsaha);
			logUpdateBatasHutangUsaha.Aktivitas = $"Mengubah Supplier: {t1Supplier.Nama}, kolom {logUpdateBatasHutangUsaha.Kolom}, dari {t1Supplier.BatasHutangUsaha} menjadi {request.BatasHutangUsaha}";
			_db_Log.Add(logUpdateBatasHutangUsaha);

			//set data T9Log untuk kolom BatasHutangGiro
			var logUpdateBatasHutangGiro = pthT9Log.LogBuilder(logT1Supplier);
			logUpdateBatasHutangGiro.IdPrimaryKey = idPrimaryKey;
			logUpdateBatasHutangGiro.Kolom = nameof(t1Supplier.BatasHutangGiro);
			logUpdateBatasHutangGiro.Aktivitas = $"Mengubah Supplier: {t1Supplier.Nama}, kolom {logUpdateBatasHutangGiro.Kolom}, dari {t1Supplier.BatasHutangGiro} menjadi {request.BatasHutangGiro}";
			_db_Log.Add(logUpdateBatasHutangGiro);
		}
	}

	private async Task<int> BulkUpdateJenisSupplier_Suppliers(cmdBulkUpdateJenisSupplier_Supplier request) =>
		await _db.Set<T1Supplier>().Where(t1 => t1.IdJenisSupplier == request.JenisSupplierUpdate.IdJenisSupplier)
									   .ExecuteUpdateAsync(s =>
										  s.SetProperty(t => t.Termin, t => request.Termin)
										   .SetProperty(t => t.BatasHutangUsaha, t => request.BatasHutangUsaha)
										   .SetProperty(t => t.BatasHutangGiro, t => request.BatasHutangGiro)
										   .SetProperty(t => t.IdOperator, t => request.JenisSupplierUpdate.IdOperator)
										   .SetProperty(t => t.IdValidator, t => request.JenisSupplierUpdate.IdValidator ?? null)
										   .SetProperty(t => t.WaktuUpdate, t => DateTimeOffset.UtcNow)
										   .SetProperty(t => t.Synchronise, t => "updated"));


	private async Task UpdateRedisT0JenisSuplier(T0JenisSupplier t0JenisSupplierUpdate, string? valueUpdateState = null)
	{
		var dataRedisSemuaT0JenisSupplier = await _redisCache.GetDataRedis<List<T0JenisSupplier>>($"{_namaDatabase}~{nameof(T0JenisSupplier)}");
		if (dataRedisSemuaT0JenisSupplier is not null)
		{
			var dataRedisT0JenisSupplier = dataRedisSemuaT0JenisSupplier
										  .FirstOrDefault(t0 => t0.IdJenisSupplier == t0JenisSupplierUpdate.IdJenisSupplier);
			if (dataRedisT0JenisSupplier is null)
			{
				dataRedisSemuaT0JenisSupplier.Add(t0JenisSupplierUpdate);
				await _redisCache.SetDataRedis($"{_namaDatabase}~{nameof(T0JenisSupplier)}", dataRedisSemuaT0JenisSupplier);
				return;
			}

			if (valueUpdateState is null)
				t0JenisSupplierUpdate.Adapt(dataRedisT0JenisSupplier);
			else
				dataRedisT0JenisSupplier.State = valueUpdateState;
			await _redisCache.SetDataRedis($"{_namaDatabase}~{nameof(T0JenisSupplier)}", dataRedisSemuaT0JenisSupplier);
		}
	}
}

public sealed record cmdBulkUpdateJenisSupplier_Supplier(
	T0JenisSupplier JenisSupplierUpdate,
	int? Termin,
	decimal? BatasHutangUsaha,
	decimal? BatasHutangGiro) : IRequest<string>;