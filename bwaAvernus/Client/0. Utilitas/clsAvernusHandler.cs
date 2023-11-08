using bwaAvernus._1._Master;
using bwaAvernus.Client._2._Transaksi;
using bwaAvernus.Shared._2._Transaksi;
using bwaCrixalis.Client._1._Master;
using bwaCrixalis.Shared._1._Master;
using Pantheon.Client.Utility;
using System.Collections.ObjectModel;
using Wisej.Core;

namespace bwaAvernus.Client._0._Utilitas
{
    public class clsAvernusHandler : clsPantheonHandler<uimT0DivisiPerusahaan, uimT1Provinsi, uimT2Kota, uimT3Kecamatan, uimT4Kelurahan, uimT0DivisiPerusahaan>
    {
        private readonly svcCustomerInstansi _svcCustomerInstansi = new svcCustomerInstansi();
        private readonly svcRute _svcRute = new svcRute();
        private readonly svcBiayaRute _svcBiayaRute = new svcBiayaRute();
        private readonly svcArmada _svcArmada = new svcArmada();
        private readonly pthSvcRekening _svcRekening = new pthSvcRekening();
        private readonly svcPenugasanArmada _svcPenugasanArmada = new svcPenugasanArmada();
        public clsAvernusHandler()
        {
            
        }

        public async Task<ObservableCollection<uimT1CustomerInstansi>> Get_Customer(bool perbaruiMeskipunAda = false)
        {
            var data = await _svcCustomerInstansi.GetDataCustomerInstansi();
            return data.Adapt<ObservableCollection<uimT1CustomerInstansi>>();
        }

        public async Task<ObservableCollection<uimT2AlamatCustomer>> Get_AlamatCustomer(Guid idCustomer, bool perbaruiMeskipunAda = false)
        {
            var data = await _svcCustomerInstansi.GetDataAlamatCustomerById(idCustomer);
            return data.Adapt<ObservableCollection<uimT2AlamatCustomer>>();
        }

        public async Task<IList<dynamic>> Get_RuteByIdAlamatCustomer(Guid? idAlamatCustomer= null, bool perbaruiMeskipunAda = false)
        {
            var data = new List<dynamic>();
            if(idAlamatCustomer is not null) data = (await _svcRute.GetDataRuteByIdAlamatCustomer((Guid)idAlamatCustomer)).Adapt<List<dynamic>>();
            else data = (await _svcRute.GetDataRute()).Adapt<List<dynamic>>();
            return data;
        }

        public async Task<ObservableCollection<uimT1Armada>> Get_Armada(bool perbaruiMeskipunAda = false)
        {
            var data = await _svcArmada.GetDataArmada();
            return data.Adapt<ObservableCollection<uimT1Armada>>();
        }

        public async Task<ObservableCollection<uimT5ArmadaSopir>> Get_ArmadaSopir(Guid? idArmada = null, bool perbaruiMeskipunAda = false)
        {
            var data = new ObservableCollection<uimT5ArmadaSopir>();
            if (idArmada is not null) data = (await _svcArmada.GetDataArmadaSopirById((Guid)idArmada)).Adapt<ObservableCollection<uimT5ArmadaSopir>>();
            else data = (await _svcArmada.GetDataArmada()).Adapt<ObservableCollection<uimT5ArmadaSopir>>();
            return data;
        }

        public async Task<IList<dynamic>> Get_BiayaRute(Guid? idRute = null, bool perbaruiMeskipunAda = false)
        {
            var data = new List<dynamic>();
            if (idRute is not null) data = (await _svcBiayaRute.GetDataBiayaRuteById((Guid)idRute)).Adapt<List<dynamic>>();
            else data = (await _svcBiayaRute.GetDataBiayaRute()).Adapt<List<dynamic>>();
            return data;
            //var data = await _svcBiayaRute.GetDataBiayaRuteById(idRute);
            //return data.Adapt<List<dynamic>>();
        }

        public async Task<ObservableCollection<pthT0Rekening>> Get_Rekening(bool perbaruiMeskipunAda = false)
        {
            var data = await _svcRekening.GetDataRekening();
            return data.Adapt<ObservableCollection<pthT0Rekening>>();
        }

        public async Task<object> GetValidasiRute(string nopol)
        {
            var validasiRute = await _svcPenugasanArmada.GetValidasiRute(nopol);
            return validasiRute.Adapt<object>();
        }
    }
}
