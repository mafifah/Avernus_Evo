using bwaAvernus.Server.Data;
using bwaAvernus.Shared._1._Master;
using bwaAvernus.Shared._2._Transaksi;

namespace bwaAvernus.Server._2._Transaksi
{
    public class svsPenugasanArmada : svpTransaksiPenugasanArmada.svpTransaksiPenugasanArmadaBase
    {
        private readonly ILogger<svsPenugasanArmada> _logger;
        private readonly pthISvdTransaksi _svd;
        private readonly pthIServiceDraft _sdr;
        private readonly AvernusDbContext _dbContext;
        public svsPenugasanArmada(ILogger<svsPenugasanArmada> logger, pthISvdTransaksi svd, pthIServiceDraft sdr, AvernusDbContext dbContext)
        {
            _logger = logger;
            _svd = svd;
            _sdr = sdr;
            _dbContext = dbContext;
        }

        #region Views
        public async override Task<RplPenugasanArmada> GetPenugasanArmada(RqsPenugasanArmada request, ServerCallContext context)
        {
            IEnumerable<T6PenugasanArmada>? listPenugasanArmada;
            if (string.IsNullOrEmpty(request.TanggalFilterAwal))
            {
                listPenugasanArmada = await _svd.GetEntities<T6PenugasanArmada>();
            }
            else
            {
                listPenugasanArmada = await _svd.GetEntitiesDenganSpec<T6PenugasanArmada>(x => x.WaktuProses >= request.TanggalFilterAwal.ToDateTimeOffset() && x.WaktuProses <= request.TanggalFilterAkhir.ToDateTimeOffset());
            }
            //await _svdPenugasanArmada.GetPenugasanArmada();
            var rplPenugasanArmada = new RplPenugasanArmada();
            rplPenugasanArmada.ListT6PenugasanArmada.AddRange(listPenugasanArmada.Adapt<IEnumerable<RplPenugasanArmadaById>>());
            return rplPenugasanArmada;
        }
        public async override Task<RplPenugasanArmadaById> GetPenugasanArmadaById(RqsPenugasanArmadaById request, ServerCallContext context)
        {
            var PenugasanArmada = await _svd.GetEntityById<T6PenugasanArmada>(request.IdPenugasanArmada);
            return PenugasanArmada.Adapt<RplPenugasanArmadaById>();
        }

        public async override Task<RplT7PenugasanArmadaById> GetT7PenugasanArmadaById(RqsT7PenugasanArmadaById request, ServerCallContext context)
        {
            var rplDetilPenugasanArmada = new RplT7PenugasanArmadaById();
            var listDetilPenugasanArmada = await _svd.GetEntitiesDenganSpec<T7PenugasanArmada>(x => x.IdPenugasanArmada.ToString() == request.IdPenugasanArmada);
            if (listDetilPenugasanArmada is null) return rplDetilPenugasanArmada;
            rplDetilPenugasanArmada.ListT7PenugasanArmada.AddRange(listDetilPenugasanArmada.Adapt<IEnumerable<PtmT7PenugasanArmada>>());
            return rplDetilPenugasanArmada;
        }

        public override async Task<RplT7PenugasanArmada_SPBUById> GetT7PenugasanArmada_SPBUById(RqsT7PenugasanArmadaById request, ServerCallContext context)
        {
            var rplDetilPenugasanArmada = new RplT7PenugasanArmada_SPBUById();
            var listDetilPenugasanArmada = await _svd.GetEntitiesDenganSpec<T7PenugasanArmada_SPBU>(x => x.IdPenugasanArmada == Guid.Parse(request.IdPenugasanArmada));
            if(listDetilPenugasanArmada is null) return rplDetilPenugasanArmada;

            rplDetilPenugasanArmada.ListT7PenugasanArmadaSPBU.AddRange(listDetilPenugasanArmada.Adapt<IEnumerable<PtmT7PenugasanArmada_SPBU>>());
            return rplDetilPenugasanArmada;
        }

        public override async Task<Ptm_ValidasiRute> GetValidasiRute(RqsValidasiRute request, ServerCallContext context)
        {
            var rplValidasiRute = new Ptm_ValidasiRute();
            var dtPenugasanArmada = await _svd.GetEntitiesDenganSpec<T6PenugasanArmada>(x => x.Nopol == request.Nopol);
            if(dtPenugasanArmada.Count() > 0)
            {
                var t6PenugasanArmada = dtPenugasanArmada.OrderByDescending(x => x.WaktuProses).FirstOrDefault();
                var dtT7PenugasanArmada = await _svd.GetEntitiesDenganSpec<T7PenugasanArmada>(x => x.IdPenugasanArmada == t6PenugasanArmada.IdPenugasanArmada, $"{nameof(T3Rute)}");
                var t7PenugasanArmada = dtT7PenugasanArmada.OrderByDescending(x => x.WaktuPenugasan).FirstOrDefault();
                if(t6PenugasanArmada.StatusPerjalanan != "Kembali" || (DateTime.Now - t7PenugasanArmada.WaktuPenugasan).Value.TotalMinutes < t7PenugasanArmada.T3Rute.EstimasiWaktu)
                {
                    rplValidasiRute = t6PenugasanArmada.Adapt<Ptm_ValidasiRute>();
                    rplValidasiRute.Rute = t7PenugasanArmada.T3Rute.Rute;
                    rplValidasiRute.EstimasiJarak = (int)t7PenugasanArmada.T3Rute.EstimasiJarak;
                    rplValidasiRute.EstimasiWaktu = (int)t7PenugasanArmada.T3Rute.EstimasiWaktu;
                    rplValidasiRute.SanguSementara = t7PenugasanArmada.SanguSementara.ToString();
                    rplValidasiRute.LamaPenugasanSekarang = (DateTime.Now - t7PenugasanArmada.WaktuPenugasan).Value.TotalMinutes;
                }
            }
            return rplValidasiRute;
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
        public override async Task<RplWritePenugasanArmada> InsertPenugasanArmada(RqsInsertPenugasanArmada request, ServerCallContext context)
        {
            var dtT6PenugasanArmada = request.Adapt<T6PenugasanArmada>();
            var dtT7PenugasanArmada = dtT6PenugasanArmada.ListT7PenugasanArmada.FirstOrDefault();
            dtT7PenugasanArmada.NoPenugasan = await GenerateIdTransaksi(dtT7PenugasanArmada.IdCompany, "DO");
            dtT6PenugasanArmada.ListT7PenugasanArmada.Clear();
            dtT6PenugasanArmada.ListT7PenugasanArmada.Add(dtT7PenugasanArmada);
            var hasil = await _svd.InsertTransaksiHeader<T6PenugasanArmada, T7PenugasanArmada, BaseModelTransaksiDetil, BaseModelTransaksiDetil, BaseModelTransaksiDetil, BaseModelTransaksiDetil>(dtT6PenugasanArmada, request.IdForm);
            if (dtT7PenugasanArmada.SanguSementara > 0)
            {
                await GenerateJurnal(dtT7PenugasanArmada.IdCompany, 30701020, dtT6PenugasanArmada.IdTransaksi, dtT7PenugasanArmada.NoPenugasan, $"{dtT6PenugasanArmada.Nopol} ({dtT6PenugasanArmada.Karyawan_Sopir_NamaPanggilan}): ({dtT7PenugasanArmada.Customer_Inisial}) {dtT7PenugasanArmada.Rute_Rute} [{dtT7PenugasanArmada.Rute_Jenis}]", $"Sangu Sopir = {dtT7PenugasanArmada.SanguSementara}", dtT7PenugasanArmada.SanguSementara, dtT6PenugasanArmada.IdRekening);
            }
            return new RplWritePenugasanArmada { IsOK = true, Result = hasil };
        }

        public override async Task<RplWritePenugasanArmada> UpdatePenugasanArmada(RqsUpdatePenugasanArmada request, ServerCallContext context)
        {
            var dtT6PenugasanArmada = request.Adapt<T6PenugasanArmada>();
            var dtT7PenugasanArmada = dtT6PenugasanArmada.ListT7PenugasanArmada.FirstOrDefault();
            var dtT6Jurnal = (await _svd.GetEntitiesDenganSpec<pthT6Jurnal>(x => x.NoBukti == dtT7PenugasanArmada.NoPenugasan)).FirstOrDefault();
            var dtT7Jurnal = new List<pthT7Jurnal>();
            if (dtT6Jurnal != null) { 
                dtT7Jurnal = (_svd.GetEntitiesDenganSpec<pthT7Jurnal>(x => x.IdJurnal == dtT6Jurnal.IdJurnal)).Adapt<List<pthT7Jurnal>>();
                dtT6Jurnal.GrandTotal = (decimal)dtT7PenugasanArmada.SanguSementara;
                dtT7Jurnal.ForEach(x => x.NominalAkuntansi = dtT6Jurnal.GrandTotal);
                dtT7Jurnal.ForEach(x => x.NominalTransaksi = dtT6Jurnal.GrandTotal);

                dtT6Jurnal.ListT7Jurnal = dtT7Jurnal.Adapt<ICollection<pthT7Jurnal>>();

                await _svd.UpdateTransaksiHeader<pthT6Jurnal, pthT7Jurnal, BaseModelTransaksiDetil, BaseModelTransaksiDetil, BaseModelTransaksiDetil, BaseModelTransaksiDetil>(dtT6Jurnal, 30200030);
            }
            else if (dtT7PenugasanArmada.SanguSementara > 0)
            {
                await GenerateJurnal(dtT7PenugasanArmada.IdCompany, 30701020, dtT6PenugasanArmada.IdTransaksi, dtT7PenugasanArmada.NoPenugasan, $"{dtT6PenugasanArmada.Nopol} ({dtT6PenugasanArmada.Karyawan_Sopir_NamaPanggilan}): ({dtT7PenugasanArmada.Customer_Inisial}) {dtT7PenugasanArmada.Rute_Rute} [{dtT7PenugasanArmada.Rute_Jenis}]", $"Sangu Sopir = {dtT7PenugasanArmada.SanguSementara}", dtT7PenugasanArmada.SanguSementara, dtT6PenugasanArmada.IdRekening);

            }

            var hasil = await _svd.UpdateTransaksiHeader<T6PenugasanArmada, T7PenugasanArmada, BaseModelTransaksiDetil, BaseModelTransaksiDetil, BaseModelTransaksiDetil, BaseModelTransaksiDetil>(request.Adapt<T6PenugasanArmada>(), request.IdForm);
            return new RplWritePenugasanArmada { IsOK = true, Result = hasil };
        }
        public override async Task<RplWritePenugasanArmada> BatalPenugasanArmada(RqsBatalPenugasanArmada request, ServerCallContext context)
        {
            var hasil = await _svd.BatalTransaksiHeader<T6PenugasanArmada>(Guid.Parse(request.IdPenugasanArmada), Guid.Parse(request.IdOperator));
            return new RplWritePenugasanArmada { IsOK = true, Result = hasil };
        }
        public override async Task<RplGetDraftPenugasanArmada> GetDraftPenugasanArmada(RqsGetDraftPenugasanArmada request, ServerCallContext context)
        {
            var dtT6PenugasanArmada = await _sdr.GetDraftRedisByIdPrimaryKey<T6PenugasanArmada>(request.IdUser, request.IdPenugasanArmada);

            // Tambah 2 baris ini jika ada Detil Grid lebih dari 1
            var dtT7PenugasanArmada = await _sdr.GetDraftRedisDetilByIdPrimaryKey<T6PenugasanArmada, T7PenugasanArmada>(request.IdUser, request.IdPenugasanArmada);
            _svd.SetPropertyValue(dtT6PenugasanArmada, $"List{nameof(T7PenugasanArmada)}", dtT7PenugasanArmada);

            return dtT6PenugasanArmada.Adapt<RplGetDraftPenugasanArmada>();
        }

        public override async Task<RplSetDraftPenugasanArmada> SetDraftPenugasanArmada(RqsSetDraftPenugasanArmada request, ServerCallContext context)
        {
            var redisKey = await _sdr.SetDraftRedis<T6PenugasanArmada>(request.Adapt<T6PenugasanArmada>());
            return new RplSetDraftPenugasanArmada { IsOK = true, Result = redisKey };
        }

        #endregion
    }
}
