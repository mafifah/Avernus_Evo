using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using static bwaCrixalis.Shared._1._Master.svpMasterDivisiBarang;
using static Pantheon.Client.Utility.modVariabel;
namespace bwaCrixalis.Client._4._Dokumen;
public partial class rptDivisiBarang
{
    private svpMasterDivisiBarangClient _client { get; set; }
    IList<T0DivisiBarang> t0DivisiBarangs { get; set; } = new List<T0DivisiBarang>();
    public rptDivisiBarang()
    {
        InitializeComponent();
        this.DataSource = Get_DivisiBarang().Result;
    }

    public async Task<IList<T0DivisiBarang>> Get_DivisiBarang(bool perbaruiMeskipunAda = false)
    {
        var handler = new GrpcWebHandler(GrpcWebMode.GrpcWebText, new HttpClientHandler());
        ClientChannel = GrpcChannel.ForAddress(Pantheon.Client.Utility.modVariabel.AlamatAPI, new GrpcChannelOptions
        {
            HttpClient = new HttpClient(handler)
        });
        _client = new svpMasterDivisiBarangClient(ClientChannel);
        var data = await _client.GetDivisiBarangAsync(new RqsDivisiBarang(), Headers);
        t0DivisiBarangs = data.DivisiBarang.Adapt<IList<T0DivisiBarang>>();
        return t0DivisiBarangs;
    }
}
