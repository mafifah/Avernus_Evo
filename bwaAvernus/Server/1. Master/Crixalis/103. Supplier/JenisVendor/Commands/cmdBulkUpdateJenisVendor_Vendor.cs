using bwaAvernus.Server.Data;
using bwaCrixalis.Server.Data;
using Pantheon.Server.RedisCache;
using Pantheon.Shared.Redis;

namespace bwaCrixalis.Server._1._Master;

public class cmhBulkUpdateJenisVendor_Vendor : IRequestHandler<cmdBulkUpdateJenisVendor_Vendor, string>
{
	private readonly AvernusDbContext _db;
	private readonly CrixalisDbContext_Log _db_Log;
	private readonly pthIRedisCacheService _redisCache;
	private readonly IStreamPublisher _streamPublisher;
	private static string _namaDatabase = "dbAvernus_Evo";

	public cmhBulkUpdateJenisVendor_Vendor(AvernusDbContext db, CrixalisDbContext_Log db_Log, pthIRedisCacheService redisCache, IStreamPublisher streamPublisher)
	{
		_db = db;
		_db_Log = db_Log;
		_redisCache = redisCache;
		_streamPublisher = streamPublisher;
	}

	public async Task<string> Handle(cmdBulkUpdateJenisVendor_Vendor request, CancellationToken cancellationToken)
	{
		var timestamp = DateTimeOffset.UtcNow;
		T0JenisVendor t0JenisVendorBaru = await UpdateT0JenisVendor(request);
		await _redisCache.InsertAtauUpdateItemListRedisById(t0JenisVendorBaru, request.JenisVendorUpdate.IdJenisVendor.ToString());
		bool t0JenisVendorBerubah = false;

		using var transaction = await _db.Database.BeginTransactionAsync();
		try
		{
			await SetT9LogUpdateT1Vendor(request, timestamp);
			await BulkUpdateJenisVendor_Vendors(request);
			await UpdateDataRedisT1Vendor(request);

			//var listLogUpdateT0JenisVendor = await _db.SaveChangesAsync(nameof(T0JenisVendor.Jenis));

			//if (listLogUpdateT0JenisVendor is not null && listLogUpdateT0JenisVendor.Any() is true)
			//{
			//	_db_Log.AddRange(listLogUpdateT0JenisVendor);
			//	t0JenisVendorBerubah = true;
			//}

			if (await _db.SaveChangesAsync() > 0)
			{
				t0JenisVendorBerubah = true;
			}
			await _db_Log.SaveChangesAsync();
			await transaction.CommitAsync();
		}
		catch (Exception ex)
		{
			if (t0JenisVendorBerubah)
			{
				t0JenisVendorBaru.State = $"Gagal~{t0JenisVendorBaru.IdJenisVendor}";
				await _redisCache.InsertAtauUpdateItemListRedisById(
								t0JenisVendorBaru,
								t0JenisVendorBaru.IdJenisVendor.ToString());
				await _streamPublisher.PublishAsync($"{_namaDatabase}~{typeof(T0JenisVendor).Name}", t0JenisVendorBaru);
			}

			//List<T1Vendor> t1Vendors = await GetT1Vendors(t0JenisVendorBaru.IdJenisVendor);
			//foreach (var t1Vendor in t1Vendors)
			//{
			//	request.Adapt(t1Vendor);
			//	t1Vendor.State = $"Gagal~{t1Vendor.IdVendor}";
			//}
			//TODO: draft redis
			try
			{
				await transaction.RollbackAsync();
			}
			catch (Exception)
			{
				return t0JenisVendorBaru.State;
			}
			return t0JenisVendorBaru.State;
		}
		return $"Berhasil~{request.JenisVendorUpdate.IdJenisVendor}";
	}

	private async Task UpdateDataRedisT1Vendor(cmdBulkUpdateJenisVendor_Vendor request)
	{
		var idRedis = $"{_namaDatabase}~{typeof(T1Vendor).Name}";
		var dataRedisVendor = await _redisCache.GetDataRedis<List<T1Vendor>>(idRedis);
		foreach (var Vendor in dataRedisVendor)
		{
			Vendor.Termin = request.Termin;
			Vendor.BatasHutangGiro = request.BatasHutangGiro;
			Vendor.BatasHutangUsaha = request.BatasHutangUsaha;
		}
		await _redisCache.SetDataRedis<List<T1Vendor>>(idRedis, dataRedisVendor);
	}

	private async Task<List<T1Vendor>> GetT1Vendors(Guid idJenisVendor) =>
		await _db.Set<T1Vendor>()
					.AsNoTracking()
					.Where(x => x.IdJenisVendor == idJenisVendor)
					.ToListAsync();

	private async Task<T0JenisVendor> UpdateT0JenisVendor(cmdBulkUpdateJenisVendor_Vendor request)
	{
		var t0JenisVendorLama = await _db.Set<T0JenisVendor>().FindAsync(request.JenisVendorUpdate.IdJenisVendor);
		if (t0JenisVendorLama is null)
		{
			throw new RpcException(new Status(StatusCode.NotFound, "Data yang ingin diubah tidak ditemukan. Silahkan memuat data kembali"));
		}
		var t0JenisVendorBaru = request.JenisVendorUpdate.Adapt(t0JenisVendorLama);
		t0JenisVendorBaru.State = "";
		return t0JenisVendorBaru;
	}

	private async Task SetT9LogUpdateT1Vendor(cmdBulkUpdateJenisVendor_Vendor request, DateTimeOffset timestamp)
	{
		var dataT0Form = await _db.Set<pthT0Form>()
							.Select(t => new { t.IdForm, t.NamaPK, t.NamaTabel, t.Kategori, t.Inisial })
							.Where(f => f.Kategori == "2. Master" || f.Kategori == "3. Transaksi")
							.ToListAsync();
		var t1Vendors = await GetT1Vendors(request.JenisVendorUpdate.IdJenisVendor);

		var logT1Vendor = new pthT9LogRecord
		{
			IdUser = request.JenisVendorUpdate.IdOperator,
			WaktuInsert = timestamp,
			JenisAktivitas = "Update",
			Tabel = nameof(T1Vendor),
			IdApplication = null,
			KodeInstruksi = null,
			IPv4 = null,
			IPv6 = null
		};

		foreach (var t1Vendor in t1Vendors)
		{
			var idPrimaryKey = t1Vendor.IdVendor.ToString();
			var idForm = dataT0Form?.FirstOrDefault(t0 => t0.NamaTabel == nameof(T1Vendor))?.IdForm;

			//set data T9Log untuk kolom Termin
			var logUpdateTermin = pthT9Log.LogBuilder(logT1Vendor);
			logUpdateTermin.IdPrimaryKey = idPrimaryKey;
			logUpdateTermin.Kolom = nameof(t1Vendor.Termin);
			logUpdateTermin.Aktivitas = $"Mengubah Vendor: {t1Vendor.Nama}, kolom {logUpdateTermin.Kolom}, dari {t1Vendor.Termin} menjadi {request.Termin}";
			_db_Log.Add(logUpdateTermin);

			//set data T9Log untuk kolom BatasHutangUsaha
			var logUpdateBatasHutangUsaha = pthT9Log.LogBuilder(logT1Vendor);
			logUpdateBatasHutangUsaha.IdPrimaryKey = idPrimaryKey;
			logUpdateBatasHutangUsaha.Kolom = nameof(t1Vendor.BatasHutangUsaha);
			logUpdateBatasHutangUsaha.Aktivitas = $"Mengubah Vendor: {t1Vendor.Nama}, kolom {logUpdateBatasHutangUsaha.Kolom}, dari {t1Vendor.BatasHutangUsaha} menjadi {request.BatasHutangUsaha}";
			_db_Log.Add(logUpdateBatasHutangUsaha);

			//set data T9Log untuk kolom BatasHutangGiro
			var logUpdateBatasHutangGiro = pthT9Log.LogBuilder(logT1Vendor);
			logUpdateBatasHutangGiro.IdPrimaryKey = idPrimaryKey;
			logUpdateBatasHutangGiro.Kolom = nameof(t1Vendor.BatasHutangGiro);
			logUpdateBatasHutangGiro.Aktivitas = $"Mengubah Vendor: {t1Vendor.Nama}, kolom {logUpdateBatasHutangGiro.Kolom}, dari {t1Vendor.BatasHutangGiro} menjadi {request.BatasHutangGiro}";
			_db_Log.Add(logUpdateBatasHutangGiro);
		}
	}

	private async Task<int> BulkUpdateJenisVendor_Vendors(cmdBulkUpdateJenisVendor_Vendor request) =>
		await _db.Set<T1Vendor>().Where(t1 => t1.IdJenisVendor == request.JenisVendorUpdate.IdJenisVendor)
									   .ExecuteUpdateAsync(s =>
										  s.SetProperty(t => t.Termin, t => request.Termin)
										   .SetProperty(t => t.BatasHutangUsaha, t => request.BatasHutangUsaha)
										   .SetProperty(t => t.BatasHutangGiro, t => request.BatasHutangGiro)
										   .SetProperty(t => t.IdOperator, t => request.JenisVendorUpdate.IdOperator)
										   .SetProperty(t => t.IdValidator, t => request.JenisVendorUpdate.IdValidator ?? null)
										   .SetProperty(t => t.WaktuUpdate, t => DateTimeOffset.UtcNow)
										   .SetProperty(t => t.Synchronise, t => "updated"));


	private async Task UpdateRedisT0JenisVendor(T0JenisVendor t0JenisVendorUpdate, string? valueUpdateState = null)
	{
		var dataRedisSemuaT0JenisVendor = await _redisCache.GetDataRedis<List<T0JenisVendor>>($"{_namaDatabase}~{nameof(T0JenisVendor)}");
		if (dataRedisSemuaT0JenisVendor is not null)
		{
			var dataRedisT0JenisVendor = dataRedisSemuaT0JenisVendor
										  .FirstOrDefault(t0 => t0.IdJenisVendor == t0JenisVendorUpdate.IdJenisVendor);
			if (dataRedisT0JenisVendor is null)
			{
				dataRedisSemuaT0JenisVendor.Add(t0JenisVendorUpdate);
				await _redisCache.SetDataRedis($"{_namaDatabase}~{nameof(T0JenisVendor)}", dataRedisSemuaT0JenisVendor);
				return;
			}

			if (valueUpdateState is null)
				t0JenisVendorUpdate.Adapt(dataRedisT0JenisVendor);
			else
				dataRedisT0JenisVendor.State = valueUpdateState;
			await _redisCache.SetDataRedis($"{_namaDatabase}~{nameof(T0JenisVendor)}", dataRedisSemuaT0JenisVendor);
		}
	}
}

public sealed record cmdBulkUpdateJenisVendor_Vendor(
	T0JenisVendor JenisVendorUpdate,
	int? Termin,
	decimal? BatasHutangUsaha,
	decimal? BatasHutangGiro) : IRequest<string>;