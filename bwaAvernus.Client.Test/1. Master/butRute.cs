
global using Pantheon.Shared.BaseEntityModels;
using bwaAvernus.Shared._1._Master;

namespace bwaAvernus.Test
{
    public class butRute : pthBaseTest<RcpUtama, RcpRute, uimT3Rute, svcRute, T4TujuanBongkar, T5DokumenRute, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil>
    {
        public override void Inisialisasi_1()
        {
            AssemblyProject = typeof(bwaAvernus.Client._Imports).Assembly;
            //AlamatAPI = "https://ascrixalis-evo.azurewebsites.net/";
            AlamatAPI = "https://localhost:5021";
            base.Inisialisasi_1();
        }

        public butRute()
        {
            URL_SignalR = "https://assignalr.azurewebsites.net/chathub";
            NamaDatabase = "dbAvernus";
        }
    }
}
