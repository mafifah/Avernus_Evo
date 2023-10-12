using bwaAvernus.Shared._2._Transaksi;

namespace bwaAvernus.Server._2._Transaksi
{
    public class svsPendataanMuatan : svpTransaksiPendataanMuatan.svpTransaksiPendataanMuatanBase
    {
        private readonly ILogger<svsPendataanMuatan> _logger;
        private readonly pthISvdTransaksi _svd;
        private readonly pthIServiceDraft _sdr;
        public svsPendataanMuatan(ILogger<svsPendataanMuatan> logger, pthISvdTransaksi svd, pthIServiceDraft sdr)
        {
            _logger = logger;
            _svd = svd;
            _sdr = sdr;
        }

        public override async Task<RplT7PenugasanArmada> GetT7PenugasanArmada(RqsT7PenugasanArmada request, ServerCallContext context)
        {
            List<T7PenugasanArmada>? listT7PenugasanArmada = new();
            var t6PenugasanArmada = await _svd.GetEntitiesDenganSpec<T6PenugasanArmada>(x =>  x.StatusPerjalanan != "Kembali" && x.Batal == false);
            foreach (var item in t6PenugasanArmada)
            {
                listT7PenugasanArmada.AddRange(await _svd.GetEntitiesDenganSpec<T7PenugasanArmada>(x => x.IdPenugasanArmada == item.IdPenugasanArmada, $"{nameof(T7PenugasanArmada.T6PenugasanArmada)}"));
            }
            //await _svdPenugasanArmada.GetPenugasanArmada();
            var rplPenugasanArmada = new RplT7PenugasanArmada();
            rplPenugasanArmada.ListT7PenugasanArmada.AddRange(listT7PenugasanArmada.Adapt<IEnumerable<RplPendataanMuatan_T7PenugasanArmadaById>>());
            return rplPenugasanArmada;
        }
    }
}
