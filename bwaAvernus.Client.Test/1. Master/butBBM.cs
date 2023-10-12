global using bwaAvernus._1._Master;
global using bwaAvernus.Client._0__Utilitas;
global using Pantheon.Client.Test.Container;
global using bwaCrixalis.Shared._1._Master;

namespace bwaAvernus.Test
{
    public class butBBM : pthBaseTest<RcpUtama, RcpBBM, uimT0BBM, svcBBM, T4HargaBBM, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil>
	{
		public override void Inisialisasi_1()
		{
			AssemblyProject = typeof(bwaAvernus.Client._Imports).Assembly;
			//AlamatAPI = "https://ascrixalis-evo.azurewebsites.net/";
			AlamatAPI = "https://localhost:5021";
			base.Inisialisasi_1();
		}

        public butBBM()
        {
			URL_SignalR = "https://assignalr.azurewebsites.net/chathub";
			NamaDatabase = "dbAvernus";
        }
    }

}
