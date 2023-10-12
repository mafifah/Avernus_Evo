using bwaCrixalis.Client._0._Utilitas;
using bwaCrixalis.Client._1._Master;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNetCore.Components;

namespace bwaAvernus._1._Master
{
    public partial class RcpBiayaRute : ConMaster_1<uimT3Rute, svcBiayaRute>
    {
        #region Inject
        [Inject]
        public svcCompany _svcCompany { get; set; }

        [Inject]
        public svcCustomerInstansi _svcCustomerInstansi { get; set; }
        #endregion

        #region Fli
        public DxFormLayoutItem FliRute { get; set; }
        public DxFormLayoutItem FliAlias { get; set; }
        public DxFormLayoutItem FliJenis { get; set; }
        public DxFormLayoutItem FliEstimasiWaktu { get; set; }
        public DxFormLayoutItem FliEstimasiJarak { get; set; }
        public DxFormLayoutItem FliMuatan { get; set; }
        public DxFormLayoutItem FliCabang { get; set; }
        #endregion

        #region Control
        public DxTextBox TxbRute { get; set; }
        public DxTextBox TxbAlias { get; set; }
        public DxTextBox TxbJenis { get; set; }
        public DxSpinEdit<decimal?> SpeEstimasiWaktu { get; set; }
        public DxSpinEdit<decimal?> SpeEstimasiJarak { get; set; }
        public DxTextBox TxbMuatan { get; set; }
        public DxComboBox<dynamic, object> CmbIdCompany { get; set; }
        public IGrid GrdBiayaRute { get; set; }
        #endregion

        #region Data List 
        public IList<dynamic> DtCmbIdCompany { get; set; }
        public IList<T0JenisArmada> DtT0JenisArmada { get; set; }
        public IList<dynamic> DtGrdBiayaRute { get; set; }
        public IList<uimT2Kota> DtT2Kota { get; set; }
        #endregion

        #region Properties
        public object DrCmbIdCompany { get; set; }
        #endregion

        private readonly clsCrixalisHandler ch = new clsCrixalisHandler();

        protected override async void OnInitialized()
        {
            base.OnInitialized();
            DtGrdBiayaRute = new List<dynamic>();
            //DtT0JenisArmada = (await _svcRute.GetDataJenisArmada()).ToList();
            DtT2Kota = await ch.Get_Kota();
        }
        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
        }

        #region Rekapitulasi


        public override async void ProsesSeleksiData(object data)
        {
            base.ProsesSeleksiData(data);
            DtRekapitulasi_Terseleksi.T1CustomerInstansi = await _svcCustomerInstansi.GetDataCustomerInstansiById((Guid)DtRekapitulasi_Terseleksi.IdCustomer);
            DtRekapitulasi_Terseleksi.T1CustomerInstansi.T2Kota = DtT2Kota.FirstOrDefault(x => x.IdKota == DtRekapitulasi_Terseleksi.T1CustomerInstansi.IdKota);
            StateHasChanged();
        }
        #endregion

        #region Detil
        public override async Task ProsesMuat_Detil()
        {

            /*ListSpe.AddRange(new BaseSpe[] {
            new BaseSpe() { Spe = SpeHarga, Wajib = true } });*/
            await base.ProsesMuat_Detil();
        }

        public override async void ProsesPerbarui_Control(string namaControl, IList<dynamic> dtCmb, bool perbaruiMeskipunAda = false)
        {
            if (namaControl == nameof(CmbIdCompany))
            {
                dtCmb = (await _svcCompany.GetDataCompany()).Adapt<IList<dynamic>>();
            }

            DrCmbIdCompany = DtCmbIdCompany?.Adapt<IList<uimT0Company>>().FirstOrDefault(x => x.IdCompany == IdCompany);
            base.ProsesPerbarui_Control(namaControl, dtCmb, perbaruiMeskipunAda);
        }
        public void OnItemUpdating(string fieldName, object newValue)
        {
            if (fieldName == nameof(DtRekapitulasi_Terseleksi.Rute))
            {

            }
        }

        private async void OnHargaValueChanged(decimal? harga)
        {

        }

        public async void CmbIdCompany_DropDownVisibleChanged(bool val)
        {
            if (!val)
            {
                DtGrdBiayaRute.Adapt<IList<uimT4BiayaRute>>().ForEach(x => x.IdCompany = DrCmbIdCompany?.Adapt<uimT0Company>().IdCompany);
            }
        }
        #endregion

        #region Navigasi
        public override async void ProsesUpdateDatabase()
        {
            var data = DtGrdBiayaRute;
            base.ProsesUpdateDatabase();
        }
        #endregion
    }
}
