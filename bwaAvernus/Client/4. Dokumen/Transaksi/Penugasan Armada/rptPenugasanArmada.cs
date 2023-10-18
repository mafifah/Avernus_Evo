using bwaAvernus.Shared._2._Transaksi;
using Grpc.Net.Client.Web;
using Grpc.Net.Client;
using static bwaAvernus.Shared._2._Transaksi.svpTransaksiPenugasanArmada;
using System.ComponentModel;
using bwaAvernus.Client._2._Transaksi;

namespace bwaAvernus.Client._4._Dokumen
{
    public partial class rptPenugasanArmada : DevExpress.XtraReports.UI.XtraReport
    {
        List<PenugasanArmada_Cetak> DtPenugasanArmada { get; set; } = new();

        private svpTransaksiPenugasanArmadaClient _client { get; set; }

        string _idPK { get; set; }
        public rptPenugasanArmada(string idPK)
        {
            AlamatAPI = "https://localhost:7243/";
            _idPK = idPK;
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
            var rqs = _client.GetPenugasanArmada_Cetak(new RqsPenugasanArmadaById { IdPenugasanArmada = _idPK }, Headers);
            var dtT6 = rqs.Adapt<PenugasanArmada_Cetak>();
            if (rqs.AlamatCustomerKota == "")
            {
                dtT6.AlamatCustomer_Kota = dtT6.Customer_Kota;
            }
            DtPenugasanArmada.Add(dtT6);
            DataSource = DtPenugasanArmada;
            
        }

        public class PenugasanArmada_Cetak
        {
            public Guid? IdPenugasanArmada { get; set; }
            public string? IdTransaksi { get; set; }
            public string? Company_Pemilik { get; set; }
            public string? Nopol { get; set; }
            public string? Armada_Inisial { get; set; }
            public string? Armada_Nopol { get; set; }
            public string? Armada_Merk { get; set; }
            public string? JenisArmada_Jenis { get; set; }
            public string? Karyawan_Sopir_NamaPanggilan { get; set; }
            public string? Karyawan_Sopir_Seluler1 { get; set; }
            public string? WaktuProses { get; set; }
            public string? Rute_Rute { get; set; }
            public string? Customer_Nama { get; set; }
            public string? Customer_Alamat { get; set; }
            public string? Customer_Kota { get; set; }
            public string? Customer_Phone1 { get; set; }
            public string? Operator { get; set; }
            public string? Operator_Jabatan { get; set; }

            public string? AlamatCustomer_Alamat { get; set; }
            public string? AlamatCustomer_KodePos {  get; set; }
            public string? AlamatCustomer_Kota { get; set; }
            public DateTime WaktuCetak { get; set; } = DateTime.Now;
        }
    }
}
