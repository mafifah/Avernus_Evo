using bwaAvernus.Shared._1._Master;

namespace bwaAvernus.Server._1._Master
{
    public class svsRute : svpMasterRute.svpMasterRuteBase
    {
        private readonly ILogger<svsRute> _logger;
        private readonly pthISvdMaster _svd;
        private readonly pthIServiceDraft _sdr;
        public svsRute(ILogger<svsRute> logger, pthISvdMaster svd, pthIServiceDraft sdr)
        {
            _logger = logger;
            _svd = svd;
            _sdr = sdr;
        }
        #region 'Views'
        public override async Task<RplRuteById> GetRuteById(RqsRuteById request, ServerCallContext context)
        {
            var Rute = await _svd.GetEntityById<T3Rute>(request.IdRute);
            if (Rute is null) Rute = new();
            return Rute.Adapt<RplRuteById>();
        }

        public async override Task<RplRute> GetRuteByIdAlamatCustomer(RqsRuteByIdAlamatCustomer request, ServerCallContext context)
        {
            var listRute = await _svd.GetEntitiesDenganSpec<T3Rute>(x => x.IdAlamatCustomer == Guid.Parse(request.IdAlamatCustomer));
            var reply = new RplRute();
            reply.RpfRute.AddRange(listRute.Adapt<IEnumerable<RplRuteById>>());
            return reply;
        }
        public override async Task<RplRute_TujuanBongkar> GetRute_TujuanBongkar(RqsRuteById request, ServerCallContext context)
        {
            var listRute_TujuanBongkar = await _svd.GetEntitiesDenganSpec<T4TujuanBongkar>(x => x.IdRute == Guid.Parse(request.IdRute), $"{nameof(T4TujuanBongkar.T2Kota)}");
            var reply = new RplRute_TujuanBongkar();
            reply.RpfRuteTujuanBongkar.AddRange(listRute_TujuanBongkar.Adapt<IEnumerable<PtmRute_TujuanBongkar>>());
            return reply;
        }

        public override async Task<RplRute_DokumenRute> GetRute_DokumenRute(RqsRuteById request, ServerCallContext context)
        {
            var reply = new RplRute_DokumenRute();
            var listRute_DokumenRute = await _svd.GetEntitiesDenganSpec<T5DokumenRute>(x => x.IdRute == Guid.Parse(request.IdRute), "T3Rute");
            if (listRute_DokumenRute is null)
                return reply;
            reply.RpfRuteDokumenRute.AddRange(listRute_DokumenRute.Adapt<IEnumerable<PtmRute_Dokumen>>());
            return reply;
        }
        public override async Task<RplRute> GetRute(RqsRute request, ServerCallContext context)
        {
            var listRute = await _svd.GetEntitiesDenganSpec<T3Rute>(x => x.IdRute != null, $"{nameof(T3Rute.T2AlamatCustomer)}");
            var reply = new RplRute();
            reply.RpfRute.AddRange(listRute.Adapt<IEnumerable<RplRuteById>>());
            return reply;
        }
        #endregion
        #region 'Procedure'
        public override async Task<RplWriteRute> InsertRute(RqsInsertRute request, ServerCallContext context)
        {
            var hasil = await _svd.InsertMasterHeader<T3Rute, T4TujuanBongkar, T5DokumenRute, string, string, string>(request.Adapt<T3Rute>(), "IdRute");
            return new RplWriteRute { IsOK = true, Result = hasil };
        }
        public override async Task<RplWriteRute> UpdateRute(RqsUpdateRute request, ServerCallContext context)
        {
            var hasil = await _svd.UpdateMasterHeader<T3Rute, T4TujuanBongkar, T5DokumenRute, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil>(request.Adapt<T3Rute>(), "IdRute");
            return new RplWriteRute { IsOK = true, Result = hasil };
        }
        public override async Task<RplWriteRute> DeleteRute(RqsDeleteRute request, ServerCallContext context)
        {
            //var hasil = await _svd.DeleteHeaderIncludeDetil<T3Rute>(request.Adapt<T3Rute>(), "IdRute");
            var hasil = await _svd.DeleteMasterHeaderIncludeDetil<T3Rute, T4TujuanBongkar, T5DokumenRute, T4BiayaRute, BaseModelMasterDetil, BaseModelMasterDetil>(request.Adapt<T3Rute>());
            return new RplWriteRute { IsOK = true, Result = hasil };
        }

        public override async Task<RplGetDraftRute> GetDraftRute(RqsGetDraftRute request, ServerCallContext context)
        {
            var dtRute = await _sdr.GetDraftRedisByIdPrimaryKey<T3Rute>(request.IdUser, request.IdRute);

            // Tambah 2 baris ini jika ada Detil Grid lebih dari 1
            var dtTujuanBongkar = await _sdr.GetDraftRedisDetilByIdPrimaryKey<T3Rute, T4TujuanBongkar>(request.IdUser, request.IdRute);
            _svd.SetPropertyValue(dtRute, $"List{nameof(T4TujuanBongkar)}", dtTujuanBongkar);

            var dtDokumen = await _sdr.GetDraftRedisDetilByIdPrimaryKey<T3Rute, T5DokumenRute>(request.IdUser, request.IdRute);
            _svd.SetPropertyValue(dtRute, $"List{nameof(T5DokumenRute)}", dtDokumen);

            return dtRute.Adapt<RplGetDraftRute>();
        }

        public override async Task<RplSetDraftRute> SetDraftRute(RqsSetDraftRute request, ServerCallContext context)
        {
            var hasil = await _sdr.GetDraftRedisByIdPrimaryKey<T3Rute>(request.IdCreator, request.IdRute);
            var redisKey = await _sdr.SetDraftRedis<T3Rute>(request.Adapt<T3Rute>());
            return new RplSetDraftRute { IsOK = true, Result = redisKey };
        }
        #endregion
    }
}
