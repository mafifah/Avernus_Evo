using bwaAvernus.Shared._2._Transaksi;
using Grpc.Net.Client.Web;
using Grpc.Net.Client;
using static bwaAvernus.Shared._2._Transaksi.svpTransaksiPenugasanArmada;
using System.ComponentModel;

namespace bwaAvernus.Client._4._Dokumen
{
    public partial class rptPenugasanArmada : DevExpress.XtraReports.UI.XtraReport
    {
        IList<T6PenugasanArmada> ListT6PenugasanArmada { get; set; }

        private svpTransaksiPenugasanArmadaClient _client { get; set; }
        IList<T7PenugasanArmada> ListT7PenugasanArmada { get; set; }
        public rptPenugasanArmada()
        {
            AlamatAPI = "https://localhost:7243/";
            var handler = new GrpcWebHandler(GrpcWebMode.GrpcWebText, new HttpClientHandler());
            ClientChannel = GrpcChannel.ForAddress(AlamatAPI, new GrpcChannelOptions
            {
                HttpClient = new HttpClient(handler)
            });
            _client = new(ClientChannel);
            InitializeComponent();
        }

        private void PenugasanArmada_BeforePrint(object sender, CancelEventArgs e)
        {

            var data = _client.GetPenugasanArmada(new RqsPenugasanArmada(), Headers);
            ListT6PenugasanArmada = data.ListT6PenugasanArmada.Adapt<IList<T6PenugasanArmada>>();
            DataSource = ListT6PenugasanArmada;
        }
    }
}
