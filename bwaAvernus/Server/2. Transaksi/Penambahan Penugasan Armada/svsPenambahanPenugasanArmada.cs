using bwaAvernus.Server.Data;
using bwaAvernus.Shared._1._Master;
using bwaAvernus.Shared._2._Transaksi;

namespace bwaAvernus.Server._2._Transaksi;
public class svsPenambahanPenugasanArmada : svpTransaksiPenambahanPenugasanArmada.svpTransaksiPenambahanPenugasanArmadaBase
{
	private readonly ILogger<svsPenambahanPenugasanArmada> _logger;
	private readonly pthISvdTransaksi _svd;
	private readonly pthIServiceDraft _sdr;
	private readonly AvernusDbContext _dbContext;
	public svsPenambahanPenugasanArmada(ILogger<svsPenambahanPenugasanArmada> logger, pthISvdTransaksi svd, pthIServiceDraft sdr, AvernusDbContext dbContext)
	{
		_logger = logger;
		_svd = svd;
		_sdr = sdr;
		_dbContext = dbContext;
	}

	#region Views
	public async override Task<RplPenambahanPenugasanArmada> GetPenambahanPenugasanArmada(RqsPenambahanPenugasanArmada request, ServerCallContext context)
	{
		IEnumerable<T6PenugasanArmada>? listPenambahanPenugasanArmada;
		if (string.IsNullOrEmpty(request.TanggalFilterAwal))
		{
			listPenambahanPenugasanArmada = await _svd.GetEntities<T6PenugasanArmada>();
		}
		else
		{
			listPenambahanPenugasanArmada = await _svd.GetEntitiesDenganSpec<T6PenugasanArmada>(x => x.WaktuProses >= request.TanggalFilterAwal.ToDateTimeOffset() && x.WaktuProses <= request.TanggalFilterAkhir.ToDateTimeOffset());
		}
		//await _svdPenambahanPenugasanArmada.GetPenambahanPenugasanArmada();
		var rplPenambahanPenugasanArmada = new RplPenambahanPenugasanArmada();
		rplPenambahanPenugasanArmada.ListT6PenugasanArmada.AddRange(listPenambahanPenugasanArmada.Adapt<IEnumerable<RplPenambahanPenugasanArmadaById>>());
		return rplPenambahanPenugasanArmada;
	}
	public async override Task<RplPenambahanPenugasanArmadaById> GetPenambahanPenugasanArmadaById(RqsPenambahanPenugasanArmadaById request, ServerCallContext context)
	{
		var PenambahanPenugasanArmada = await _svd.GetEntityById<T6PenugasanArmada>(request.IdPenugasanArmada);
		return PenambahanPenugasanArmada.Adapt<RplPenambahanPenugasanArmadaById>();
	}

	public async override Task<RplT7PenambahanPenugasanArmadaById> GetT7PenambahanPenugasanArmadaById(RqsT7PenambahanPenugasanArmadaById request, ServerCallContext context)
	{
		var rplDetilPenambahanPenugasanArmada = new RplT7PenambahanPenugasanArmadaById();
		var listDetilPenambahanPenugasanArmada = await _svd.GetEntitiesDenganSpec<T7PenugasanArmada>(x => x.IdPenugasanArmada.ToString() == request.IdPenugasanArmada);
		if (listDetilPenambahanPenugasanArmada is null) return rplDetilPenambahanPenugasanArmada;
		rplDetilPenambahanPenugasanArmada.ListT7PenugasanArmada.AddRange(listDetilPenambahanPenugasanArmada.Adapt<IEnumerable<PtmT7PenambahanPenugasanArmada>>());
        return rplDetilPenambahanPenugasanArmada;
	}

	public override async Task<RplT7PenambahanPenugasanArmada_SPBUById> GetT7PenambahanPenugasanArmada_SPBUById(RqsT7PenambahanPenugasanArmadaById request, ServerCallContext context)
	{
		var rplDetilPenambahanPenugasanArmada = new RplT7PenambahanPenugasanArmada_SPBUById();
		var listDetilPenambahanPenugasanArmada = await _svd.GetEntitiesDenganSpec<T7PenugasanArmada_SPBU>(x => x.IdPenugasanArmada == Guid.Parse(request.IdPenugasanArmada));
		if (listDetilPenambahanPenugasanArmada is null) return rplDetilPenambahanPenugasanArmada;

		rplDetilPenambahanPenugasanArmada.ListT7PenugasanArmadaSPBU.AddRange(listDetilPenambahanPenugasanArmada.Adapt<IEnumerable<PtmT7PenambahanPenugasanArmada_SPBU>>());
		return rplDetilPenambahanPenugasanArmada;
	}

	

	public override async Task<RplPenambahanPenugasanArmada_Cetak> GetPenambahanPenugasanArmada_Cetak(RqsPenambahanPenugasanArmadaById request, ServerCallContext context)
	{
		var dtT6PenambahanPenugasanArmada = (await _svd.GetEntitiesDenganSpec<T7PenugasanArmada>(x => x.IdPenugasanArmada.ToString() == request.IdPenugasanArmada, $"{nameof(T6PenugasanArmada)}.{nameof(T1Armada)}.{nameof(T0JenisArmada)}")).FirstOrDefault();
		var dtCompany = (await _svd.GetEntities<pthT0Company>()).FirstOrDefault(x => x.IdCompany == dtT6PenambahanPenugasanArmada.T6PenugasanArmada.T1Armada.IdCompany_Pemilik);
		var reply = dtT6PenambahanPenugasanArmada.T6PenugasanArmada.Adapt<RplPenambahanPenugasanArmada_Cetak>();
		reply.CompanyPemilik = $"{dtCompany.Prefix} {dtCompany.Nama}";
		reply.JenisArmadaJenis = dtT6PenambahanPenugasanArmada.T6PenugasanArmada.T1Armada.T0JenisArmada.Jenis;
		reply.RuteRute = dtT6PenambahanPenugasanArmada.Rute_Rute;
		reply.CustomerNama = dtT6PenambahanPenugasanArmada.Customer_Nama;
		reply.CustomerAlamat = dtT6PenambahanPenugasanArmada.Customer_Alamat;
		reply.CustomerKota = dtT6PenambahanPenugasanArmada.Customer_Kota;
		reply.CustomerPhone1 = dtT6PenambahanPenugasanArmada.Customer_Phone1;
		reply.AlamatCustomerAlamat = dtT6PenambahanPenugasanArmada.AlamatCustomer_Alamat;
		reply.AlamatCustomerKota = dtT6PenambahanPenugasanArmada.AlamatCustomer_Kota;
		return reply;

	}
	#endregion

	#region Procedure
	protected async Task<string> GenerateIdTransaksi(string idCompany, string kodeForm)
	{
		var kodeTahunBulan = DateTime.Now.ToString("yyMM");
		string sequenceGenerated = await GetSequenceTerbaruIdTransaksi(kodeTahunBulan, idCompany);

		var idTransaksiGenerated = $"{kodeForm}-{kodeTahunBulan}-{idCompany}-{sequenceGenerated}";
		return idTransaksiGenerated;
	}

	private async Task<string> GetSequenceTerbaruIdTransaksi(string kodeTahunBulan, string idCompany)
	{
		var idTransaksiTerakhir = await _dbContext.Set<T7PenugasanArmada>()
									.Where(dbSet => dbSet.NoPenugasan.Substring(3, 8) == $"{kodeTahunBulan}-{idCompany}")
									.Select(d => d.NoPenugasan)
									.OrderByDescending(t => t)
									.FirstOrDefaultAsync();

		if (idTransaksiTerakhir is null)
		{
			return "0001";
		}
		var stringSequenceTerakhir = idTransaksiTerakhir.Substring(12);
		var intSequence = int.Parse(stringSequenceTerakhir);
		return (intSequence + 1).ToString().PadLeft(4, '0');
	}

	private async Task GenerateJurnal(string idCompany, long idForm, string referensi, string noBukti, string keterangan, string deskripsi, decimal? grandtotal, string idRekening)
	{
		var dtT6Jurnal = new pthT6Jurnal();
		dtT6Jurnal.IdCompany = idCompany;
		dtT6Jurnal.IdForm = idForm;
		dtT6Jurnal.Referensi_IdTransaksi = referensi;
		dtT6Jurnal.Keterangan = keterangan;
		dtT6Jurnal.GrandTotal = (decimal)grandtotal;
		dtT6Jurnal.NoBukti = noBukti;

		var dtT7Jurnal = new List<pthT7Jurnal>();

		dtT7Jurnal.Add(new pthT7Jurnal
		{
			IdAkun = idRekening,
			IdJurnal = dtT6Jurnal.IdJurnal,
			NominalTransaksi = grandtotal,
			Pos = "K",
			Pasangan = 1,
			Deskripsi = deskripsi,
		});

		dtT7Jurnal.Add(new pthT7Jurnal
		{
			IdAkun = "0701001001",
			IdJurnal = dtT6Jurnal.IdJurnal,
			NominalTransaksi = grandtotal,
			Pos = "D",
			Pasangan = 1,
			Deskripsi = deskripsi,
		});

		dtT6Jurnal.ListT7Jurnal = dtT7Jurnal.Adapt<ICollection<pthT7Jurnal>>();

		await _svd.InsertTransaksiHeader<pthT6Jurnal, pthT7Jurnal, BaseModelTransaksiDetil, BaseModelTransaksiDetil, BaseModelTransaksiDetil, BaseModelTransaksiDetil>(dtT6Jurnal, 30200030);

	}

	public override async Task<RplWritePenambahanPenugasanArmada> UpdatePenambahanPenugasanArmada(RqsUpdatePenambahanPenugasanArmada request, ServerCallContext context)
	{
		var dtT6PenambahanPenugasanArmada = request.Adapt<T6PenugasanArmada>();
		dtT6PenambahanPenugasanArmada.StatusPerjalanan = $"Rute {dtT6PenambahanPenugasanArmada.ListT7PenugasanArmada.Count}";
		var dtT7PenambahanPenugasanArmada = dtT6PenambahanPenugasanArmada.ListT7PenugasanArmada.FirstOrDefault(x => x.Urutan == dtT6PenambahanPenugasanArmada.ListT7PenugasanArmada.Count);
		var dtT6Jurnal = (await _svd.GetEntitiesDenganSpec<pthT6Jurnal>(x => x.NoBukti == dtT7PenambahanPenugasanArmada.NoPenugasan))?.FirstOrDefault();
		var dtT7Jurnal = new List<pthT7Jurnal>();
		if (dtT6Jurnal != null)
		{
			dtT7Jurnal = (_svd.GetEntitiesDenganSpec<pthT7Jurnal>(x => x.IdJurnal == dtT6Jurnal.IdJurnal)).Adapt<List<pthT7Jurnal>>();
			dtT6Jurnal.GrandTotal = (decimal)dtT7PenambahanPenugasanArmada.SanguSementara;
			dtT7Jurnal.ForEach(x => x.NominalAkuntansi = dtT6Jurnal.GrandTotal);
			dtT7Jurnal.ForEach(x => x.NominalTransaksi = dtT6Jurnal.GrandTotal);

			dtT6Jurnal.ListT7Jurnal = dtT7Jurnal.Adapt<ICollection<pthT7Jurnal>>();

			//await _svd.UpdateTransaksiHeader<pthT6Jurnal, pthT7Jurnal, BaseModelTransaksiDetil, BaseModelTransaksiDetil, BaseModelTransaksiDetil, BaseModelTransaksiDetil>(dtT6Jurnal, 30200030);
		}
		else if (dtT7PenambahanPenugasanArmada.SanguSementara > 0)
		{
			//await GenerateJurnal(dtT7PenambahanPenugasanArmada.IdCompany, 30701020, dtT6PenambahanPenugasanArmada.IdTransaksi, dtT7PenambahanPenugasanArmada.NoPenugasan, $"{dtT6PenambahanPenugasanArmada.Nopol} ({dtT6PenambahanPenugasanArmada.Karyawan_Sopir_NamaPanggilan}): ({dtT7PenambahanPenugasanArmada.Customer_Inisial}) {dtT7PenambahanPenugasanArmada.Rute_Rute} [{dtT7PenambahanPenugasanArmada.Rute_Jenis}]", $"Sangu Sopir = {dtT7PenambahanPenugasanArmada.SanguSementara}", dtT7PenambahanPenugasanArmada.SanguSementara, dtT6PenambahanPenugasanArmada.IdRekening);

		}

		var hasil = await _svd.UpdateTransaksiHeader<T6PenugasanArmada, T7PenugasanArmada, T7PenugasanArmada_SPBU, BaseModelTransaksiDetil, BaseModelTransaksiDetil, BaseModelTransaksiDetil>(request.Adapt<T6PenugasanArmada>(), request.IdForm);
		return new RplWritePenambahanPenugasanArmada { IsOK = true, Result = hasil };
	}
	public override async Task<RplGetDraftPenambahanPenugasanArmada> GetDraftPenambahanPenugasanArmada(RqsGetDraftPenambahanPenugasanArmada request, ServerCallContext context)
	{
		var dtT6PenambahanPenugasanArmada = await _sdr.GetDraftRedisByIdPrimaryKey<T6PenugasanArmada>(request.IdUser, request.IdPenugasanArmada);

		// Tambah 2 baris ini jika ada Detil Grid lebih dari 1
		var dtT7PenambahanPenugasanArmada = await _sdr.GetDraftRedisDetilByIdPrimaryKey<T6PenugasanArmada, T7PenugasanArmada>(request.IdUser, request.IdPenugasanArmada);
		_svd.SetPropertyValue(dtT6PenambahanPenugasanArmada, $"List{nameof(T7PenugasanArmada)}", dtT7PenambahanPenugasanArmada);

		return dtT6PenambahanPenugasanArmada.Adapt<RplGetDraftPenambahanPenugasanArmada>();
	}

	public override async Task<RplSetDraftPenambahanPenugasanArmada> SetDraftPenambahanPenugasanArmada(RqsSetDraftPenambahanPenugasanArmada request, ServerCallContext context)
	{
		var redisKey = await _sdr.SetDraftRedis<T6PenugasanArmada>(request.Adapt<T6PenugasanArmada>());
		return new RplSetDraftPenambahanPenugasanArmada { IsOK = true, Result = redisKey };
	}

	#endregion
}

