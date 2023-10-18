using DevExpress.XtraReports.UI;
using Grpc.Net.Client.Web;
using Grpc.Net.Client;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using static bwaAvernus.Client._4._Dokumen.rptPenugasanArmada;
using static bwaAvernus.Shared._2._Transaksi.svpTransaksiPenugasanArmada;
using bwaAvernus.Shared._2._Transaksi;

namespace bwaAvernus.Client._4._Dokumen
{
    public partial class rptPenugasanArmada_1 : DevExpress.XtraReports.UI.XtraReport
    {
        List<PenugasanArmada_Cetak> DtPenugasanArmada { get; set; } = new();

        private svpTransaksiPenugasanArmadaClient _client { get; set; }

        string _idPK { get; set; }
        public rptPenugasanArmada_1(string idPK)
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
            var dtT6 = _client.GetPenugasanArmada_Cetak(new RqsPenugasanArmadaById { IdPenugasanArmada = _idPK }, Headers).Adapt<PenugasanArmada_Cetak>();
            DtPenugasanArmada.Add(dtT6);
            DataSource = DtPenugasanArmada;
        }
    }
}
