using bwaAvernus.Server.Data;
using bwaCrixalis.Server.Data;
using Pantheon.Server.RedisCache;
using Pantheon.Shared.Redis;

namespace bwaCrixalis.Server._1._Master;
internal sealed record cmdBulkUpdateJenisCustomer_Customer(
	T0JenisCustomer JenisCustomerUpdate,
	int? Termin,
	decimal? BatasPiutangUsaha,
	decimal? BatasPiutangGiro,
	string JenisHarga,
	string JenisDiskon,
	string JenisPenjualan,
	string JenisReturPenjualan,
	string JenisPPN
	) : IRequest<string>;

internal class cmhBulkUpdateJenisCustomer_Customer : IRequestHandler<cmdBulkUpdateJenisCustomer_Customer, string>
{
	private readonly AvernusDbContext _db;
	private readonly CrixalisDbContext_Log _db_Log;
	private readonly pthIRedisCacheService _redisCache;
	private readonly IStreamPublisher _streamPublisher;
	private static string _namaDatabase = "dbAvernus_Evo";

	public cmhBulkUpdateJenisCustomer_Customer(AvernusDbContext db, CrixalisDbContext_Log db_Log, pthIRedisCacheService redisCache, IStreamPublisher streamPublisher)
	{
		_db = db;
		_db_Log = db_Log;
		_redisCache = redisCache;
		_streamPublisher = streamPublisher;
	}

	public async Task<string> Handle(cmdBulkUpdateJenisCustomer_Customer request, CancellationToken cancellationToken)
	{
		var timestamp = DateTimeOffset.UtcNow;
		T0JenisCustomer t0JenisCustomerBaru = await UpdateT0JenisCustomer(request);
		await _redisCache.InsertAtauUpdateItemListRedisById(t0JenisCustomerBaru, request.JenisCustomerUpdate.IdJenisCustomer.ToString());
		bool t0JenisCustomerBerubah = false;

		using var transaction = await _db.Database.BeginTransactionAsync();
		try
		{
			await SetT9LogUpdateT1Customer(request, timestamp);
			await BulkUpdateJenisCustomer_Customers(request);
			await UpdateDataRedisT1Customer(request);

			if (await _db.SaveChangesAsync() > 0)
			{
				t0JenisCustomerBerubah = true;
			}
			//var listLogUpdateT0JenisCustomer = await _db.SaveChangesAsync();

			//if (listLogUpdateT0JenisCustomer is not null && listLogUpdateT0JenisCustomer.Any() is true)
			//{
			//	_db_Log.AddRange(listLogUpdateT0JenisCustomer);
			//	t0JenisCustomerBerubah = true;
			//}
			await _db_Log.SaveChangesAsync();
			await transaction.CommitAsync();
		}
		catch (Exception ex)
		{
			if (t0JenisCustomerBerubah)
			{
				t0JenisCustomerBaru.State = $"Gagal~{t0JenisCustomerBaru.IdJenisCustomer}";
				await _redisCache.InsertAtauUpdateItemListRedisById(
								t0JenisCustomerBaru,
								t0JenisCustomerBaru.IdJenisCustomer.ToString());
				await _streamPublisher.PublishAsync($"{_namaDatabase}~{typeof(T0JenisCustomer).Name}", t0JenisCustomerBaru);
			}

			//List<T1Customer> t1Customers = await GetT1Customers(t0JenisCustomerBaru.IdJenisCustomer);
			//foreach (var t1Customer in t1Customers)
			//{
			//	request.Adapt(t1Customer);
			//	t1Customer.State = $"Gagal~{t1Customer.IdCustomer}";
			//}
			//TODO: draft redis
			try
			{
				await transaction.RollbackAsync();
			}
			catch (Exception)
			{
				return t0JenisCustomerBaru.State;
			}
			return t0JenisCustomerBaru.State;
		}
		return $"Berhasil~{request.JenisCustomerUpdate.IdJenisCustomer}";
	}

	private async Task UpdateDataRedisT1Customer(cmdBulkUpdateJenisCustomer_Customer request)
	{
		var idRedis = $"{_namaDatabase}~{typeof(T1Customer).Name}";
		var dataRedisCustomer = await _redisCache.GetDataRedis<List<T1Customer>>(idRedis);
		foreach (var customer in dataRedisCustomer)
		{
			customer.Termin = request.Termin;
			customer.BatasPiutangGiro = request.BatasPiutangGiro;
			customer.BatasPiutangUsaha = request.BatasPiutangUsaha;
		}
		await _redisCache.SetDataRedis<List<T1Customer>>(idRedis, dataRedisCustomer);
	}

	private async Task<List<T1Customer>> GetT1Customers(Guid idJenisCustomer) =>
		await _db.Set<T1Customer>()
					.AsNoTracking()
					.Where(x => x.IdJenisCustomer == idJenisCustomer)
					.ToListAsync();

	private async Task<T0JenisCustomer> UpdateT0JenisCustomer(cmdBulkUpdateJenisCustomer_Customer request)
	{
		var t0JenisCustomerLama = await _db.Set<T0JenisCustomer>().FindAsync(request.JenisCustomerUpdate.IdJenisCustomer);
		if (t0JenisCustomerLama is null)
		{
			throw new RpcException(new Status(StatusCode.NotFound, "Data yang ingin diubah tidak ditemukan. Silahkan memuat data kembali"));
		}
		var t0JenisCustomerBaru = request.JenisCustomerUpdate.Adapt(t0JenisCustomerLama);
		t0JenisCustomerBaru.State = "";
		return t0JenisCustomerBaru;
	}

	private async Task SetT9LogUpdateT1Customer(cmdBulkUpdateJenisCustomer_Customer request, DateTimeOffset timestamp)
	{
		var dataT0Form = await _db.Set<pthT0Form>()
							.Select(t => new { t.IdForm, t.NamaPK, t.NamaTabel, t.Kategori, t.Inisial })
							.Where(f => f.Kategori == "2. Master" || f.Kategori == "3. Transaksi")
							.ToListAsync();
		var t1Customers = await GetT1Customers(request.JenisCustomerUpdate.IdJenisCustomer);

		var logT1Customer = new pthT9LogRecord
		{
			IdUser = request.JenisCustomerUpdate.IdOperator,
			WaktuInsert = timestamp,
			JenisAktivitas = "Update",
			Tabel = nameof(T1Customer),
			IdApplication = null,
			KodeInstruksi = null,
			IPv4 = null,
			IPv6 = null
		};

		foreach (var t1Customer in t1Customers)
		{
			var idPrimaryKey = t1Customer.IdCustomer.ToString();
			var idForm = dataT0Form?.FirstOrDefault(t0 => t0.NamaTabel == nameof(T1Customer))?.IdForm;

			//set data T9Log untuk kolom Termin
			var logUpdateTermin = pthT9Log.LogBuilder(logT1Customer);
			logUpdateTermin.IdPrimaryKey = idPrimaryKey;
			logUpdateTermin.Kolom = nameof(t1Customer.Termin);
			logUpdateTermin.Aktivitas = $"Mengubah Customer: {t1Customer.Nama}, kolom {logUpdateTermin.Kolom}, dari {t1Customer.Termin} menjadi {request.Termin}";
			_db_Log.Add(logUpdateTermin);

			//set data T9Log untuk kolom BatasPiutangUsaha
			var logUpdateBatasPiutangUsaha = pthT9Log.LogBuilder(logT1Customer);
			logUpdateBatasPiutangUsaha.IdPrimaryKey = idPrimaryKey;
			logUpdateBatasPiutangUsaha.Kolom = nameof(t1Customer.BatasPiutangUsaha);
			logUpdateBatasPiutangUsaha.Aktivitas = $"Mengubah Customer: {t1Customer.Nama}, kolom {logUpdateBatasPiutangUsaha.Kolom}, dari {t1Customer.BatasPiutangUsaha} menjadi {request.BatasPiutangUsaha}";
			_db_Log.Add(logUpdateBatasPiutangUsaha);

			//set data T9Log untuk kolom BatasPiutangGiro
			var logUpdateBatasPiutangGiro = pthT9Log.LogBuilder(logT1Customer);
			logUpdateBatasPiutangGiro.IdPrimaryKey = idPrimaryKey;
			logUpdateBatasPiutangGiro.Kolom = nameof(t1Customer.BatasPiutangGiro);
			logUpdateBatasPiutangGiro.Aktivitas = $"Mengubah Customer: {t1Customer.Nama}, kolom {logUpdateBatasPiutangGiro.Kolom}, dari {t1Customer.BatasPiutangGiro} menjadi {request.BatasPiutangGiro}";
			_db_Log.Add(logUpdateBatasPiutangGiro);
		}
	}

	private async Task<int> BulkUpdateJenisCustomer_Customers(cmdBulkUpdateJenisCustomer_Customer request) =>
		await _db.Set<T1Customer>().Where(t1 => t1.IdJenisCustomer == request.JenisCustomerUpdate.IdJenisCustomer)
									   .ExecuteUpdateAsync(s =>
										  s.SetProperty(t => t.Termin, t => request.Termin)
										   .SetProperty(t => t.BatasPiutangUsaha, t => request.BatasPiutangUsaha)
										   .SetProperty(t => t.BatasPiutangGiro, t => request.BatasPiutangGiro)
										   .SetProperty(t => t.IdOperator, t => request.JenisCustomerUpdate.IdOperator)
										   .SetProperty(t => t.IdValidator, t => request.JenisCustomerUpdate.IdValidator ?? null)
										   .SetProperty(t => t.WaktuUpdate, t => DateTimeOffset.UtcNow)
										   .SetProperty(t => t.Synchronise, t => "updated"));


	private async Task UpdateRedisT0JenisCustomer(T0JenisCustomer t0JenisCustomerUpdate, string? valueUpdateState = null)
	{
		var dataRedisSemuaT0JenisCustomer = await _redisCache.GetDataRedis<List<T0JenisCustomer>>($"{_namaDatabase}~{nameof(T0JenisCustomer)}");
		if (dataRedisSemuaT0JenisCustomer is not null)
		{
			var dataRedisT0JenisCustomer = dataRedisSemuaT0JenisCustomer
										  .FirstOrDefault(t0 => t0.IdJenisCustomer == t0JenisCustomerUpdate.IdJenisCustomer);
			if (dataRedisT0JenisCustomer is null)
			{
				dataRedisSemuaT0JenisCustomer.Add(t0JenisCustomerUpdate);
				await _redisCache.SetDataRedis($"{_namaDatabase}~{nameof(T0JenisCustomer)}", dataRedisSemuaT0JenisCustomer);
				return;
			}

			if (valueUpdateState is null)
				t0JenisCustomerUpdate.Adapt(dataRedisT0JenisCustomer);
			else
				dataRedisT0JenisCustomer.State = valueUpdateState;
			await _redisCache.SetDataRedis($"{_namaDatabase}~{nameof(T0JenisCustomer)}", dataRedisSemuaT0JenisCustomer);
		}
	}
}