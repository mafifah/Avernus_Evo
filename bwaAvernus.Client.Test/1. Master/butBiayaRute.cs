using bwaAvernus.Shared._1._Master;

namespace bwaAvernus.Test
{
    public class butBiayaRute : pthBaseTest2<RcpUtama, RcpBiayaRute, uimT3Rute, svcBiayaRute, T4BiayaRute>
    {
        public override void Inisialisasi_1()
        {
            AssemblyProject = typeof(bwaAvernus.Client._Imports).Assembly;
            //AlamatAPI = "https://ascrixalis-evo.azurewebsites.net/";
            AlamatAPI = "https://localhost:7243";
            base.Inisialisasi_1();
        }
    }
}
