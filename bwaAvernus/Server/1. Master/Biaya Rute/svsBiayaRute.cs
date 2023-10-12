using bwaAvernus.Shared._1._Master;

namespace bwaAvernus.Server._1._Master
{
    public class svsBiayaRute : svpMasterBiayaRute.svpMasterBiayaRuteBase
    {
        private readonly ILogger<svsBiayaRute> _logger;
        private readonly pthISvdMaster _svd;
        private readonly pthIServiceDraft _sdr;
        public svsBiayaRute(ILogger<svsBiayaRute> logger, pthISvdMaster svd, pthIServiceDraft sdr)
        {
            _logger = logger;
            _svd = svd;
            _sdr = sdr;
        }


        #region 'Views'
        public override async Task<RplPtmRute> GetRute(RqsPtmRute request, ServerCallContext context)
        {
            var listRute = await _svd.GetEntitiesDenganSpec<T3Rute>(x => x.IdRute != null, $"{nameof(T3Rute.T2AlamatCustomer)}");
            if (listRute is not null)
            {
                foreach (var item in listRute)
                {
                    item.ListT4TujuanBongkar = (await _svd.GetEntitiesDenganSpec<T4TujuanBongkar>(x => x.IdRute == item.IdRute, $"{nameof(T4TujuanBongkar.T2Kota)}")).ToList();
                }
            }
            var reply = new RplPtmRute();
            reply.RpfRute.AddRange(listRute.Adapt<IEnumerable<PtmRute>>());
            return reply;
        }

        public override async Task<RplBiayaRute> GetRute_BiayaRute(RqsBiayaRute request, ServerCallContext context)
        {
            var listBiayaRute = await _svd.GetEntitiesDenganSpec<T4BiayaRute>(x => x.IdRute == Guid.Parse(request.IdRute), $"{nameof(T4BiayaRute.T0JenisArmada)}");
            if (listBiayaRute is not null)
            {
                foreach (var item in listBiayaRute)
                {
                    item.ListT4BiayaRuteTonase = (await _svd.GetEntitiesDenganSpec<T4BiayaRuteTonase>(x => x.IdBiayaRute == item.IdBiayaRute)).ToList();
                    item.ListT4HargaRuteTonase = (await _svd.GetEntitiesDenganSpec<T4HargaRuteTonase>(x => x.IdBiayaRute == item.IdBiayaRute)).ToList();
                }
            }
            var reply = new RplBiayaRute();
            reply.RpfBiayaRute.AddRange(listBiayaRute.Adapt<IEnumerable<PtmBiayaRute>>());
            return reply;
        }

        public override async Task<RplBiayaRuteTonase> GetRute_BiayaRuteTonase(RqsBiayaRute request, ServerCallContext context)
        {
            var listBiayaRuteTonase = await _svd.GetEntitiesDenganSpec<T4BiayaRuteTonase>(x => x.IdRute == Guid.Parse(request.IdRute));
            var reply = new RplBiayaRuteTonase();
            reply.RpfBiayaRuteTonase.AddRange(listBiayaRuteTonase.Adapt<IEnumerable<PtmBiayaRuteTonase>>());
            return reply;
        }

        public override async Task<RplHargaRuteTonase> GetRute_HargaRuteTonase(RqsBiayaRute request, ServerCallContext context)
        {
            var listHargaRuteTonase = await _svd.GetEntitiesDenganSpec<T4HargaRuteTonase>(x => x.IdRute == Guid.Parse(request.IdRute));
            var reply = new RplHargaRuteTonase();
            reply.RpfHargaRuteTonase.AddRange(listHargaRuteTonase.Adapt<IEnumerable<PtmHargaRuteTonase>>());
            return reply;
        }
        #endregion

        #region 'Procedure'
        public override async Task<RplWriteBiayaRute> UpdateBiayaRute(RqsUpdateBiayaRute request, ServerCallContext context)
        {
            var hasil = await _svd.UpdateMasterHeader<T3Rute, T4BiayaRute, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil>(request.Adapt<T3Rute>(), "IdRute");
            return new RplWriteBiayaRute { IsOK = true, Result = hasil };
        }

        public override async Task<RplGetDraftBiayaRute> GetDraftBiayaRute(RqsGetDraftBiayaRute request, ServerCallContext context)
        {
            var dtRute = await _sdr.GetDraftRedisByIdPrimaryKey<T3Rute>(request.IdUser, request.IdRute);

            var dtBiaya = await _sdr.GetDraftRedisDetilByIdPrimaryKey<T3Rute, T4BiayaRute>(request.IdUser, request.IdRute);
            _svd.SetPropertyValue(dtRute, $"List{nameof(T4BiayaRute)}", dtBiaya);

            return dtRute.Adapt<RplGetDraftBiayaRute>();
        }

        public override async Task<RplSetDraftBiayaRute> SetDraftBiayaRute(RqsSetDraftBiayaRute request, ServerCallContext context)
        {
            var hasil = await _sdr.GetDraftRedisByIdPrimaryKey<T3Rute>(request.IdCreator, request.IdRute);
            var redisKey = await _sdr.SetDraftRedis<T3Rute>(request.Adapt<T3Rute>());
            return new RplSetDraftBiayaRute { IsOK = true, Result = redisKey };
        }
        #endregion
    }
}
