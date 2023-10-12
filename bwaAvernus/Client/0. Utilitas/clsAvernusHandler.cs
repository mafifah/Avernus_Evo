using bwaAvernus._1._Master;
using bwaCrixalis.Client._1._Master;
using Pantheon.Client.Utility;

namespace bwaAvernus.Client._0._Utilitas
{
    public class clsAvernusHandler : clsPantheonHandler<uimT0DivisiPerusahaan, uimT1Provinsi, uimT2Kota, uimT3Kecamatan, uimT4Kelurahan, uimT0DivisiPerusahaan>
    {
        private readonly svcCustomerInstansi _svcCustomerInstansi = new svcCustomerInstansi();
        private readonly svcRute _svcRute = new svcRute();
        private readonly svcBiayaRute _svcBiayaRute = new svcBiayaRute();
        private readonly svcArmada _svcArmada = new svcArmada();
        private readonly pthSvcRekening _svcRekening = new pthSvcRekening();
        public clsAvernusHandler()
        {
            
        }

        public async Task<IList<dynamic>> Get_Customer(bool perbaruiMeskipunAda = false)
        {
            var data = await _svcCustomerInstansi.GetDataCustomerInstansi();
            return data.Adapt<List<dynamic>>();
        }

        public async Task<IList<dynamic>> Get_AlamatCustomer(Guid idCustomer, bool perbaruiMeskipunAda = false)
        {
            var data = await _svcCustomerInstansi.GetDataAlamatCustomerById(idCustomer);
            return data.Adapt<List<dynamic>>();
        }

        public async Task<IList<dynamic>> Get_RuteByIdAlamatCustomer(Guid idAlamatCustomer, bool perbaruiMeskipunAda = false)
        {
            var data = await _svcRute.GetDataRuteByIdAlamatCustomer(idAlamatCustomer);
            return data.Adapt<List<dynamic>>();
        }

        public async Task<IList<dynamic>> Get_Armada(bool perbaruiMeskipunAda = false)
        {
            var data = await _svcArmada.GetDataArmada();
            return data.Adapt<List<dynamic>>();
        }

        public async Task<IList<dynamic>> Get_ArmadaSopir(Guid idArmada, bool perbaruiMeskipunAda = false)
        {
            var data = await _svcArmada.GetDataArmadaSopirById(idArmada);
            return data.Adapt<List<dynamic>>();
        }

        public async Task<IList<dynamic>> Get_BiayaRute(Guid idRute, bool perbaruiMeskipunAda = false)
        {
            var data = await _svcBiayaRute.GetDataBiayaRuteById(idRute);
            return data.Adapt<List<dynamic>>();
        }

        public async Task<IList<dynamic>> Get_Rekening(bool perbaruiMeskipunAda = false)
        {
            var data = await _svcRekening.GetDataRekening();
            return data.Adapt<List<dynamic>>();
        }
    }
}
