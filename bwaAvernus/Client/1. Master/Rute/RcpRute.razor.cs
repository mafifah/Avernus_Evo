using bwaAvernus.Client._0._Utilitas;
using bwaCrixalis.Client._0._Utilitas;
using bwaCrixalis.Client._1._Master;
using bwaCrixalis.Shared._1._Master;
using DevExpress.Data.Filtering.Helpers;
using Mapster;
using System.Linq.Dynamic.Core;

namespace bwaAvernus._1._Master
{
    public partial class RcpRute : ConMaster_1<uimT3Rute, svcRute>
    {
        #region Fli
        public DxFormLayoutItem FliRute { get; set; }
        public DxFormLayoutItem FliAlias { get; set; }
        public DxFormLayoutItem FliJenisRute { get; set; }
        public DxFormLayoutItem FliEstimasiWaktu { get; set; }
        public DxFormLayoutItem FliEstimasiJarak { get; set; }
        public DxFormLayoutItem FliJenisMuatan { get; set; }
        public DxFormLayoutItem FliStatusRutePaket { get; set; }
        public DxFormLayoutItem FliStatus { get; set; }
        public DxFormLayoutItem FliCustomer { get; set; }
        public DxFormLayoutItem FliAlamatCustomer { get; set; }
        #endregion

        #region Control
        public DxTextBox TxbRute { get; set; }
        public DxTextBox TxbAlias { get; set; }

        public DxComboBox<dynamic, string> CmbJenisRute;
        public DxSpinEdit<decimal?> SpeEstimasiWaktu { get; set; }
        public DxSpinEdit<decimal?> SpeEstimasiJarak { get; set; }

        public DxComboBox<dynamic, string> CmbJenisMuatan;

        public DxComboBox<dynamic, object> CmbCustomer;
        public DxComboBox<dynamic, object> CmbAlamatCustomer;
        public DxCheckBox<bool?> ChbStatusRutePaket { get; set; }
        public DxCheckBox<bool?> ChbStatus { get; set; }
        public DxComboBox<uimT2Kota, uimT2Kota> CmbKota { get; set; }

        public IGrid GrdTujuanBongkar { get; set; }
        public IGrid GrdDokumenRute { get; set; }
        #endregion

        #region Data  List
        public IList<dynamic> DtCmbJenisRute { get; set; }
        public IList<dynamic> DtCmbJenisMuatan { get; set; }
        public IList<dynamic> DtCmbCustomer { get; set; }
        public IList<dynamic> DtCmbAlamatCustomer { get; set; }
        public IList<dynamic> DtGrdTujuanBongkar { get; set; }
        public IList<dynamic> DtGrdDokumenRute { get; set; }
        public IList<uimT2Kota> DtT2Kota { get; set; }
        public IList<T0JenisArmada> DtT0JenisArmada { get; set; }
        #endregion

        #region Properties
        public string DrCmbJenisRute { get; set; }
        public string DrCmbJenisMuatan { get; set; }
        public object DrCmbCustomer { get; set; }
        public object DrCmbAlamatCustomer { get; set; }
        public string Lfc_Detil_TujuanBongkar { get; set; } //Last focused column
        public string Lfc_Detil_DokumenRute { get; set; } //Last focused column
        #endregion

        private readonly clsCrixalisHandler ch = new clsCrixalisHandler();
        private readonly clsAvernusHandler ah = new clsAvernusHandler();

        protected override async void OnInitialized()
        {
            base.OnInitialized();
            DtGrdTujuanBongkar = new List<dynamic>();
            DtGrdDokumenRute = new List<dynamic>();
            PrimaryText = nameof(uimT3Rute.Rute);
        }
        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
        }

        #region Rekapitulasi

        public override async void ProsesSeleksiData(object data)
        {
            base.ProsesSeleksiData(data);
            DtCmbJenisRute = await ch.Get_DataOption("Jenis Rute");
            DtCmbJenisMuatan = await ch.Get_DataOption("Jenis Muatan");
            DtCmbCustomer = (await ah.Get_Customer()).Adapt<IList<dynamic>>();
            DrCmbCustomer = DtCmbCustomer.Adapt<IList<uimT1CustomerInstansi>>().FirstOrDefault(x => x.IdCustomer == DtRekapitulasi_Terseleksi.IdCustomer);
            DtRekapitulasi_Terseleksi.T1CustomerInstansi = DrCmbCustomer.Adapt<uimT1CustomerInstansi>();
            DtRekapitulasi_Terseleksi.T1CustomerInstansi.T2Kota = DtT2Kota.FirstOrDefault(x => x.IdKota == DtRekapitulasi_Terseleksi.T1CustomerInstansi.IdKota);
            DtCmbAlamatCustomer = (await ah.Get_AlamatCustomer(DrCmbCustomer.Adapt<uimT1CustomerInstansi>().IdCustomer)).Adapt<IList<dynamic>>();
            DrCmbAlamatCustomer = DtRekapitulasi_Terseleksi.T2AlamatCustomer;
            DrCmbJenisRute = DtRekapitulasi_Terseleksi.Jenis;
            DrCmbJenisMuatan = DtRekapitulasi_Terseleksi.Muatan;
            StateHasChanged();
        }
        #endregion
        #region Detil
        public override async Task ProsesMuat_Detil()
        {
            ListTxb.AddRange(new BaseTxb[] {
            new BaseTxb() { Txb = TxbRute, Wajib = true},
            //new BaseTxb() { Txb = TxbAlias, Wajib = true },
            });

            /*ListCmb.AddRange(new BaseCmb[]
            {
                new BaseCmb(){ Cmb = CmbCustomer, Wajib = true},
                new BaseCmb(){ Cmb = CmbAlamatCustomer, Wajib = true},
            });*/

            ListSpe.AddRange(new BaseSpe[] {
            new BaseSpe() { Spe = SpeEstimasiJarak, Wajib = true }
            });

            ListChb.AddRange(new BaseChb[] {
            new BaseChb() { Chb = ChbStatusRutePaket },
            new BaseChb() { Chb = ChbStatus },
            });

            await base.ProsesMuat_Detil();
            DtT2Kota = await ch.Get_Kota();
            DtT0JenisArmada = (await Svc.GetDataJenisArmada()).ToList();
            //DtCmbJenisMuatan = await ch.Get_DataOption("Jenis Muatan");
            //DtCmbJenisRute = await ch.Get_DataOption("Jenis Rute");
            //DtCmbCustomer = (await ah.Get_Customer()).Adapt<IList<uimuimT1CustomerInstansi>>();
        }

        public override async void ProsesPerbarui_Control(string namaControl, IList<dynamic> dtCmb, bool perbaruiMeskipunAda = false)
        {
            if (namaControl == nameof(CmbJenisRute)) dtCmb = await ch.Get_DataOption("Jenis Rute");
            else if (namaControl == nameof(CmbJenisMuatan)) dtCmb = await ch.Get_DataOption("Jenis Muatan");
            else if (namaControl == nameof(CmbCustomer)) dtCmb = await ah.Get_Customer();
            base.ProsesPerbarui_Control(namaControl, dtCmb, perbaruiMeskipunAda);
        }

        public void OnItemUpdating(string fieldName, object newValue)
        {
            if (fieldName == nameof(DtRekapitulasi_Terseleksi.Rute))
            {

            }
        }

        public async void CmbJenisRute_DropDownVisibleChanged(bool val)
        {
            if (val == true)
            {
                DtCmbJenisRute = await ch.Get_DataOption("Jenis Rute");
                await InvokeAsync(StateHasChanged);
            }
            //else
            //{
            //    await ProsesSimpan_Draft(nameof(uimT3Rute.Jenis), DrCmbJenisRute?.Adapt<uimT3Rute>().Jenis);
            //}
        }

        public async void CmbJenisMuatan_DropDownVisibleChanged(bool val)
        {
            if (val == true)
            {
                DtCmbJenisMuatan = await ch.Get_DataOption("Jenis Muatan");
                await InvokeAsync(StateHasChanged);
            }
            //else
            //{
            //    await ProsesSimpan_Draft(nameof(uimT3Rute.Muatan), DrCmbJenisMuatan?.Adapt<uimT3Rute>().Muatan);
            //}
        }

        public async void CmbCustomer_DropDownVisibleChanged(bool val)
        {
            if (val == true)
            {
                DtCmbCustomer = (await ah.Get_Customer()).Adapt<IList<dynamic>>();
                await InvokeAsync(StateHasChanged);
            }
            else
            {
                var customer = DrCmbCustomer?.Adapt<uimT1CustomerInstansi>();
                DtRekapitulasi_Terseleksi.T1CustomerInstansi = customer;
                DtRekapitulasi_Terseleksi.T1CustomerInstansi.T2Kota = DtT2Kota.FirstOrDefault(x => x.IdKota == DtRekapitulasi_Terseleksi.T1CustomerInstansi.IdKota);
                DtCmbAlamatCustomer = (await ah.Get_AlamatCustomer(customer.IdCustomer)).Adapt<IList<dynamic>>();
                DrCmbAlamatCustomer = DtCmbAlamatCustomer?.Adapt<IList<T2AlamatCustomer>>().FirstOrDefault();
                DtRekapitulasi_Terseleksi.T2AlamatCustomer = DrCmbAlamatCustomer?.Adapt<T2AlamatCustomer>();
                DtRekapitulasi_Terseleksi.IdAlamatCustomer = DrCmbAlamatCustomer?.Adapt<T2AlamatCustomer>().IdAlamatCustomer;
                await ProsesSimpan_Draft("IdAlamatCustomer", DrCmbAlamatCustomer?.Adapt<T2AlamatCustomer>().IdAlamatCustomer);
                await ProsesSimpan_Draft("T2AlamatCustomer", DrCmbAlamatCustomer?.Adapt<T2AlamatCustomer>());
                await InvokeAsync(StateHasChanged);
            }
        }

        protected async void CmbAlamatCustomer_DropDownVisibleChanged(bool val)
        {
            if (!val)
            {
                var alamatCustomer = DrCmbAlamatCustomer?.Adapt<T2AlamatCustomer>();
                DtRekapitulasi_Terseleksi.IdAlamatCustomer = alamatCustomer.IdAlamatCustomer;
                DtRekapitulasi_Terseleksi.T2AlamatCustomer = DtCmbAlamatCustomer.Adapt<IList<T2AlamatCustomer>>().FirstOrDefault(x => x.IdAlamatCustomer == alamatCustomer.IdAlamatCustomer);
                await ProsesSimpan_Draft("IdAlamatCustomer", alamatCustomer.IdAlamatCustomer);
                await ProsesSimpan_Draft("T2AlamatCustomer", alamatCustomer);
                await InvokeAsync(StateHasChanged);
            }

        }

        #endregion

        #region Navigasi
        public override async Task ProsesDataBaru()
        {
            DtGrdTujuanBongkar.Clear();
            DtGrdDokumenRute.Clear();
            DtGrdTujuanBongkar = new List<dynamic>();
            DtGrdDokumenRute = new List<dynamic>();
            await base.ProsesDataBaru();
        }
        public override async void ProsesUpdateDatabase()
        {
            List<uimT4BiayaRute> listBiaya = new();
            foreach(var item in DtT0JenisArmada)
            {
                listBiaya.Add(new uimT4BiayaRute { IdJenisArmada = item.IdJenisArmada, Synchronise = "inserted" }) ;
            }
            DtRekapitulasi_Terseleksi.ListT4BiayaRute = listBiaya.Adapt<ICollection<T4BiayaRute>>();
            base.ProsesUpdateDatabase();
        }
        #endregion

        #region GrdTujuanBongkar
        private void OnKotaDipilih(uimT2Kota selectedItem, uimT4TujuanBongkar editModel)
        {
            editModel.IdKota = selectedItem.IdKota;
            editModel.T2Kota = selectedItem;
        }
        #endregion
    }
}

