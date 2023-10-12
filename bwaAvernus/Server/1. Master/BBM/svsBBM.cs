global using Grpc.Core;
global using Mapster;
global using bwaCrixalis.Shared._1._Master;
using bwaAvernus.Shared._1._Master;

namespace bwaAvernus.Server._1._Master
{
    public class svsBBM : svpMasterBBM.svpMasterBBMBase
    {
        private readonly ILogger<svsBBM> _logger;
        private readonly pthISvdMaster _svd;
        private readonly pthIServiceDraft _sdr;
        public svsBBM(ILogger<svsBBM> logger, pthISvdMaster svd, pthIServiceDraft sdr)
        {
            _logger = logger;
            _svd = svd;
            _sdr = sdr;
        }
        #region 'View'
        public override async Task<RplBBMById> GetBBMById(RqsBBMById request, ServerCallContext context)
        {
            var BBM = await _svd.GetEntityById<T0BBM>(request.IdBBM);
            if (BBM is null) BBM = new();
            return BBM.Adapt<RplBBMById>();
        }
        public override async Task<Shared._1._Master.RplBBM> GetBBM(Shared._1._Master.RqsDataBBM request, ServerCallContext context)
        {
            var listBBM = await _svd.GetEntities<T0BBM>();
            var reply = new Shared._1._Master.RplBBM();
            reply.RpfBBM.AddRange(listBBM.Adapt<IEnumerable<RplBBMById>>());
            return reply;
        }

        public override async Task<RplHargaBBM> GetHargaBBM(RqsBBMById request, ServerCallContext context)
        {
            var listHargaBBM = await _svd.GetEntitiesDenganSpec<T4HargaBBM>(x => x.IdBBM == Guid.Parse(request.IdBBM), $"{nameof(T0BBM)}");
            //var listHargaBBM = await _svd.GetEntities<T4HargaBBM>();
            var reply = new RplHargaBBM();
            reply.RpfHargaBBM.AddRange(listHargaBBM.Adapt<IEnumerable<PtmHargaBBM>>());
            //reply.RpfHargaBBM.AddRange(listHargaBBM.Where(x => x.IdBBM == Guid.Parse(request.IdBBM)).ToList().Adapt<IEnumerable<RplHargaBBMById>>());
            return reply;
        }
        #endregion

        #region 'Procedure'
        public override async Task<RplWriteBBM> InsertBBM(RqsInsertBBM request, ServerCallContext context)
        {
            var hasil = await _svd.InsertMasterHeader<T0BBM, T4HargaBBM, string, string, string, string>(request.Adapt<T0BBM>(), "IdBBM");
            return new RplWriteBBM { IsOK = true, Result = hasil };
        }

        public override async Task<RplWriteBBM> UpdateBBM(RqsUpdateBBM request, ServerCallContext context)
        {
            var hasil = await _svd.UpdateMasterHeader<T0BBM, T4HargaBBM, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil>(request.Adapt<T0BBM>(), "IdBBM");
            return new RplWriteBBM { IsOK = true, Result = hasil };
        }

        public override async Task<RplWriteBBM> DeleteBBM(RqsDeleteBBM request, ServerCallContext context)
        {
            var hasil = await _svd.DeleteMasterHeaderIncludeDetil<T0BBM, T4HargaBBM, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil>(request.Adapt<T0BBM>());
            //var hasil = await _svd.DeleteHeaderIncludeDetil<T1Mesin>(div => div.IdValidator == Guid.Parse(request.IdMesin), nameof(T1Mesin.ListT2SettingMesin));
            return new RplWriteBBM { IsOK = true, Result = hasil };
        }

        public override async Task<RplGetDraftBBM> GetDraftBBM(RqsGetDraftBBM request, ServerCallContext context)
        {
            var dtBBM = await _sdr.GetDraftRedisByIdPrimaryKey<T0BBM>(request.IdUser, request.IdBBM);

            // Tambah 2 baris ini jika ada Detil Grid lebih dari 1
            var dtHargaBBM = await _sdr.GetDraftRedisDetilByIdPrimaryKey<T0BBM, T4HargaBBM>(request.IdUser, request.IdBBM);
            _svd.SetPropertyValue(dtBBM, $"List{nameof(T4HargaBBM)}", dtHargaBBM);

            
            return dtBBM.Adapt<RplGetDraftBBM>();
        }

        public override async Task<RplSetDraftBBM> SetDraftBBM(RqsSetDraftBBM request, ServerCallContext context)
        {
            var hasil = await _sdr.GetDraftRedisByIdPrimaryKey<T0BBM>(request.IdCreator, request.IdBBM);
            var redisKey = await _sdr.SetDraftRedis<T0BBM>(request.Adapt<T0BBM>());
            return new RplSetDraftBBM { IsOK = true, Result = redisKey };
        }
        #endregion
    }
}
