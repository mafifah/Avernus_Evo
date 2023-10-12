using bwaAvernus.Shared._2._Transaksi;
using static bwaAvernus.Shared._2._Transaksi.svpTransaksiPendataanMuatan;

namespace bwaAvernus.Client._2._Transaksi
{
    public class svcPendataanMuatan : svpTransaksiPendataanMuatan.svpTransaksiPendataanMuatanClient
    {
        private svpTransaksiPendataanMuatanClient _client { get; set; }
        public svcPendataanMuatan()
        {
            _client = new svpTransaksiPendataanMuatanClient(ClientChannel);
        }
    }
}
