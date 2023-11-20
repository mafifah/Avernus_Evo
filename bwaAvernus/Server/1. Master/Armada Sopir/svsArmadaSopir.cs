using bwaAvernus.Shared._1._Master;

namespace bwaAvernus.Server._1._Master
{
    public class svsArmadaSopir : svpArmadaSopir.svpArmadaSopirBase
    {
        private readonly ILogger<svsArmadaSopir> _logger;
        private readonly pthISvdMaster _svd;
        private readonly pthIServiceDraft _sdr;
        public svsArmadaSopir(ILogger<svsArmadaSopir> logger, pthISvdMaster svd, pthIServiceDraft sdr)
        {
            _logger = logger;
            _svd = svd;
            _sdr = sdr;
        }

        public override async Task<RplArmadaSopir> GetDataArmadaSopir(RqsArmadaSopir request, ServerCallContext context)
        {
            var listArmadaSopir = await _svd.GetEntitiesDenganSpec<T5ArmadaSopir>(x => x.IdArmada == request.IdArmada.ToGuid(), $"{nameof(T5ArmadaSopir.T1Karyawan_Sopir)}");
            var dtSopir =listArmadaSopir.OrderByDescending(x => x.IsDefault).ToList();
            var reply = new RplArmadaSopir();
            reply.ListT5ArmadaSopir.AddRange(dtSopir.Adapt<IEnumerable<Ptm_ArmadaSopir>>());
            return reply;
        }
    }
}
