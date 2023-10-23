using Microsoft.AspNetCore.Components;
using bwaAvernus.Client._0._Utilitas;
using bwaCrixalis.Client._1._Master;
using bwaAvernus._1._Master;
using bwaCrixalis.Client._0._Utilitas;
using bwaAvernus.Shared._2._Transaksi;
using Radzen;
using System.Reflection;
using bwaCrixalis.Shared._1._Master;
using Microsoft.Ajax.Utilities;
using Microsoft.JSInterop;

namespace bwaAvernus.Client._2._Transaksi;
public partial class RcpPenugasanArmada : ConTransaksi_1<uimT6PenugasanArmada, svcPenugasanArmada>
{
    #region Inject
    [Inject]
    public svcCompany _svcCompany { get; set; }

    [Inject]
    public svcRute _svcRute{ get; set; }

    [Inject]

    DialogService DialogService { get; set; }

    [Inject]
    IJSRuntime _js { get; set; }
    #endregion

    #region Fli
    public DxFormLayoutItem FliIdCompany { get; set; }
    public DxFormLayoutItem FliIdTransaksi { get; set; }
    public DxFormLayoutItem FliWaktuProses { get; set; }
    public DxFormLayoutItem FliCustomer { get; set; }
    public DxFormLayoutItem FliAlamatCustomer { get; set; }
    public DxFormLayoutItem FliRute { get; set; }
    public DxFormLayoutItem FliArmada { get; set; }
    public DxFormLayoutItem FliSopir { get; set; }
    public DxFormLayoutItem FliSanguRitase { get; set; }
    public DxFormLayoutItem FliTotalSangu { get; set; }
    public DxFormLayoutItem FliBBMVolume { get; set; }
    public DxFormLayoutItem FliBBMHarga { get; set; }
    public DxFormLayoutItem FliBBMSangu { get; set; }
    public DxFormLayoutItem FliDeposit { get; set; }
    public DxFormLayoutItem FliPotongan{ get; set; }
    public DxFormLayoutItem FliTotalAkhir{ get; set; }
    public DxFormLayoutItem FliSanguSementara{ get; set; }
    public DxFormLayoutItem FliBBMMetode{ get; set; }
    public DxFormLayoutItem FliRekening{ get; set; }
    #endregion

    #region Control
    public DxComboBox<dynamic, object> CmbIdCompany { get; set; }
    public DxTextBox TxbIdTransaksi { get; set; }
    public DxDateEdit<DateTimeOffset?> DteWaktuProses { get; set; }

    public DxComboBox<dynamic, object> CmbCustomer;
    public DxComboBox<dynamic, object> CmbAlamatCustomer;
    public DxComboBox<dynamic, object> CmbRute;
    public DxSpinEdit<decimal?> SpeSanguRitase { get; set; }
    public DxSpinEdit<decimal?> SpeTotalSangu { get; set; }
    public DxSpinEdit<decimal?> SpeBBMVolume { get; set; }
    public DxSpinEdit<decimal?> SpeBBMHarga { get; set; }
    public DxSpinEdit<decimal?> SpeBBMSangu { get; set; }
    public DxSpinEdit<decimal?> SpeDeposit { get; set; }
    public DxSpinEdit<decimal?> SpePotongan { get; set; }
    public DxSpinEdit<decimal?> SpeTotalAkhir { get; set; }
    public DxSpinEdit<decimal?> SpeSanguSementara { get; set; }
    
    public DxComboBox<dynamic, object> CmbArmada;
    public DxComboBox<dynamic, object> CmbSopir;

    public DxComboBox<dynamic, object> CmbBBMMetode;
    public DxComboBox<dynamic, object> CmbRekening;

    public IGrid GrdT7PenugasanArmada_SPBU { get; set; }
    #endregion

    #region Data List
    public IList<dynamic> DtCmbIdCompany { get; set; }
    public IList<dynamic> DtCmbCustomer { get; set; }
    public IList<dynamic> DtCmbAlamatCustomer { get; set; }
    public IList<dynamic> DtCmbRute { get; set; }
    public IList<dynamic> DtCmbArmada { get; set; }
    public IList<dynamic> DtCmbSopir { get; set; }
    public IList<dynamic> DtCmbBBMMetode { get; set; }
    public IList<dynamic> DtCmbRekening { get; set; }
    public IList<dynamic> DtGrdT7PenugasanArmada_SPBU { get; set; }
    public IList<uimT3Rute> DtRute { get; set; }
    public IList<uimT4BiayaRute> DtBiayaRute { get; set; }
    public IList<uimT2Kota> DtKota { get; set; }
    #endregion

    #region Properties
    public object DrCmbIdCompany { get; set; }
    public object DrCmbCustomer { get; set; }
    public object DrCmbAlamatCustomer { get; set; }
    public object DrCmbRute { get; set; }
    public object DrCmbArmada { get; set; }
    public object DrCmbSopir { get; set; }
    public object DrCmbBBMMetode { get; set; }
    public object DrCmbRekening { get; set; }
    public decimal? Potongan { get; set; } = 0;
    public uimValidasiRute? ValidasiRute { get; set; } = new();
    #endregion


    private readonly clsCrixalisHandler ch = new();
    private readonly clsAvernusHandler ah = new();
    PropertyInfo[]? dtPropertiesT7;
    PropertyInfo[]? dtPropertiesT6;

    private string outerHeight = "";


    protected override async void OnInitialized()
    {
        
        PrimaryText = "IdTransaksi";
        base.OnInitialized();
        DtKota = (await ch.Get_Kota()).ToList();
        if (DtCmbArmada is null) DtCmbArmada = (await ah.Get_Armada()).Adapt<IList<dynamic>>();
        if (DtCmbCustomer is null) DtCmbCustomer = (await ah.Get_Customer()).Adapt<IList<dynamic>>();
        if (DtCmbRekening is null) DtCmbRekening = (await ah.Get_Rekening()).Adapt<IList<dynamic>>();
        if (DtCmbBBMMetode is null) DtCmbBBMMetode = await ah.Get_DataOption("Metode BBM");
        //if (DtCmbSopir is null) DtCmbSopir = (await ah.Get_ArmadaSopir()).Adapt<IList<dynamic>>();
        //if (DtCmbRute is null) DtCmbRute = (await ah.Get_RuteByIdAlamatCustomer()).Adapt<IList<dynamic>>();
        //if (DtBiayaRute.Count() < 1) DtBiayaRute = (await ah.Get_BiayaRute()).Adapt<IList<uimT4BiayaRute>>();
        DtRute = (await ah.Get_RuteByIdAlamatCustomer()).Adapt<IList<uimT3Rute>>();
        if (DtCmbRute is null) DtCmbRute = DtRute.Adapt<IList<dynamic>>();

        var updatedCustomer = DtCmbCustomer.Adapt<IList<uimT1CustomerInstansi>>();
        updatedCustomer.ForEach(x => x.T2Kota = DtKota.FirstOrDefault(y => y.IdKota == x.IdKota));
        DtCmbCustomer = updatedCustomer.Adapt<IList<dynamic>>();

        dtPropertiesT6 = DtRekapitulasi_Terseleksi.GetType().GetProperties();
        dtPropertiesT7 = DtRekapitulasi_Terseleksi.T7PenugasanArmada.GetType().GetProperties();
    }
    protected override async void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);
        var outer = await _js.InvokeAsync<int>("getLength");
        outerHeight = $"{outer + 40}px !important";
    }
    /*public override void Inisialisasi_Filter()
    {
        DtFilter = new() {
            new mdlFilter() { NamaTabel = nameof(T6PenugasanArmada), NamaPK = "IdCustomer", Caption = "Customer", JenisControl = "DxComboBox", Data = DtCmbCustomer, FieldDitampilkan = new[] { "Customer", "Kode" }, Value = (Guid?)DrCmbCustomer },
            new mdlFilter() { NamaTabel = nameof(T7PenugasanArmada), NamaPK = "IdBarang", Caption = "Barang", JenisControl = "DxComboBox", Data = DtCmbBarang_GrdT7PenugasanArmada, FieldDitampilkan = new[] { "Barang", "Kode1" }, Value = (Guid?)DrCmbBarang_GrdT7PenugasanArmada }
        };

        base.Inisialisasi_Filter();
    }*/
    #region Rekapitulasi
    public override void ProsesPerbarui_Rekapitulasi(string namaMethod = null, object[] parameters = null)
    {
        base.ProsesPerbarui_Rekapitulasi(namaMethod, parameters);
        
    }

    public override async void ProsesSeleksiData(object data)
    {
        base.ProsesSeleksiData(data);        
            DrCmbArmada = DtCmbArmada.Adapt<IList<uimT1Armada>>().FirstOrDefault(x => x.IdArmada == DtRekapitulasi_Terseleksi.IdArmada);
            DtCmbSopir = await ah.Get_ArmadaSopir(DrCmbArmada?.Adapt<uimT1Armada>().IdArmada);
            DrCmbSopir = (await ah.Get_ArmadaSopir(DrCmbArmada?.Adapt<uimT1Armada>().IdArmada)).Adapt<IList<uimT5ArmadaSopir>>().FirstOrDefault(x => x.IdKaryawan_Sopir == DtRekapitulasi_Terseleksi.IdKaryawan_Sopir);
            DtRekapitulasi_Terseleksi.T7PenugasanArmada = (await Svc.GetDataT7PenugasanArmadaById(DtRekapitulasi_Terseleksi.IdPenugasanArmada)).Adapt<IList<uimT7PenugasanArmada>>().FirstOrDefault(x => x.Urutan == 1);

            DrCmbCustomer = DtCmbCustomer.Adapt<IList<uimT1CustomerInstansi>>().FirstOrDefault(x => x.IdCustomer == DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdCustomer);
            DtCmbAlamatCustomer = (await ah.Get_AlamatCustomer((Guid)DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdCustomer)).Adapt<IList<dynamic>>();
            DrCmbAlamatCustomer = DtCmbAlamatCustomer.Adapt<IList<uimT2AlamatCustomer>>().FirstOrDefault(x => x.IdAlamatCustomer == DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdAlamatCustomer);
            DrCmbRute = DtCmbRute.Adapt<IList<uimT3Rute>>().FirstOrDefault(x => x.IdRute == DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdRute);
            var dtBBM = DtCmbBBMMetode.Adapt<IList<pthT9DataOption>>();
            DrCmbBBMMetode = dtBBM.FirstOrDefault(x => x.DataOption == DtRekapitulasi_Terseleksi.T7PenugasanArmada.BBMMetode);
            DrCmbRekening = DtCmbRekening.Adapt<IList<pthT0Rekening>>().FirstOrDefault(x => x.IdRekening == DtRekapitulasi_Terseleksi.IdRekening);
        StateHasChanged();
    }
    #endregion

    #region Detil
    public override async Task ProsesMuat_Detil()
    {
        base.ProsesMuat_Detil();
    }
    public override async void ProsesPerbarui_Control(string namaControl, IList<dynamic> dtCmb, bool perbaruiMeskipunAda = false)
    {
        if (namaControl == nameof(CmbIdCompany))
        {
            dtCmb = (await _svcCompany.GetDataCompany()).Adapt<IList<dynamic>>();
        }
        if (namaControl == nameof(CmbCustomer))
        {
            dtCmb = (await ah.Get_Customer()).Adapt<IList<dynamic>>();
        }
        if (namaControl == nameof(CmbArmada))
        {
            dtCmb = (await ah.Get_Armada()).Adapt<IList<dynamic>>();
        }
        if (namaControl == nameof(CmbBBMMetode))
        {
            dtCmb = await ch.Get_DataOption("Metode BBM");
        }
        if (namaControl == nameof(CmbRekening))
        {
            dtCmb = (await ah.Get_Rekening()).Adapt<IList<dynamic>>();
        }
        base.ProsesPerbarui_Control(namaControl, dtCmb, perbaruiMeskipunAda);

        DtRekapitulasi_Terseleksi.IdCompany = IdCompany;
        DrCmbIdCompany = DtCmbIdCompany?.Adapt<IList<uimT0Company>>().FirstOrDefault(x => x.IdCompany == IdCompany);
        //DrCmbRekening = DtCmbRekening.Adapt<IList<pthT0Rekening>>().FirstOrDefault(x => x.Rekening == "Kas Pak Antok");
        //DrCmbBBMMetode = DtCmbBBMMetode.Adapt<IList<string>>().FirstOrDefault();
        await InvokeAsync(StateHasChanged);
    }
    public async void CmbIdCompany_DropDownVisibleChanged(bool val)
    {
        if (!val)
        {
            await ProsesSimpan_Draft("IdCompany", DrCmbIdCompany?.Adapt<uimT0Company>().IdCompany);
        }

    }
    
    public async void CmbCustomer_DropDownVisibleChanged(bool val)
    {
        if (val)
        {
            //DtCmbCustomer = (await ah.Get_Customer()).Adapt<IList<dynamic>>();
            //await InvokeAsync(StateHasChanged);
        }
        else
        {
            var customer = DrCmbCustomer?.Adapt<uimT1CustomerInstansi>();
            //await ProsesSimpan_Draft("IdCustomer", customer?.IdCustomer);
            //DtRekapitulasi_Terseleksi.IdCustomer = customer?.IdCustomer;
            DtCmbAlamatCustomer = (await ah.Get_AlamatCustomer(customer.IdCustomer)).Adapt<IList<dynamic>>();
            var updatedAlamatCustomer = DtCmbAlamatCustomer.Adapt<IList<uimT2AlamatCustomer>>();
            updatedAlamatCustomer.ForEach(x => x.T2Kota = DtKota.FirstOrDefault(y => y.IdKota == x.IdKota));
            DtCmbAlamatCustomer = updatedAlamatCustomer.Adapt<IList<dynamic>>();


            DrCmbAlamatCustomer = DtCmbAlamatCustomer?.Adapt<IList<T2AlamatCustomer>>().FirstOrDefault();
            var alamatCustomer = DrCmbAlamatCustomer?.Adapt<uimT2AlamatCustomer>();

            DtCmbRute = DtRute.Where(x => x.IdAlamatCustomer == alamatCustomer.IdAlamatCustomer).ToList().Adapt<IList<dynamic>>();
            DrCmbRute = DtCmbRute?.Adapt<IList<uimT3Rute>>().FirstOrDefault();

            DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdCustomer = customer.IdCustomer;
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdJenisCustomer = customer.IdJenisCustomer;
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.Customer_Kota = customer.Kota;
            PropertyInfo[] customerProperties = customer.GetType().GetProperties();
            foreach ( var property in customerProperties)
            {
                var propertyValue = property.GetValue(customer);
                var propertyToUpdate = dtPropertiesT7.FirstOrDefault(x => x.Name == $"Customer_{property.Name}");
                if (propertyToUpdate is not null)
                {
                    dtPropertiesT7.FirstOrDefault(x => x.Name == $"Customer_{property.Name}").SetValue(DtRekapitulasi_Terseleksi.T7PenugasanArmada, propertyValue);
                }

            }
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdAlamatCustomer = alamatCustomer.IdAlamatCustomer;
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.WaktuPenugasan = DtRekapitulasi_Terseleksi.WaktuProses;
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdRute = DrCmbRute.Adapt<uimT3Rute>().IdRute;
            PropertyInfo[] alamatCustomerProperties = alamatCustomer.GetType().GetProperties();
            foreach (var property in alamatCustomerProperties)
            {
                var propertyValue = property.GetValue(alamatCustomer);
                var propertyToUpdate = dtPropertiesT7.FirstOrDefault(x => x.Name == $"AlamatCustomer_{property.Name}");
                if (propertyToUpdate is not null)
                {
                    dtPropertiesT7.FirstOrDefault(x => x.Name == $"AlamatCustomer_{property.Name}").SetValue(DtRekapitulasi_Terseleksi.T7PenugasanArmada, propertyValue);
                }

            }
            DtBiayaRute = (await ah.Get_BiayaRute(DrCmbRute.Adapt<uimT3Rute>().IdRute)).Adapt<IList<uimT4BiayaRute>>();
            if (DrCmbArmada is not null) ProsesHitungBiayaRute();
            await InvokeAsync(StateHasChanged);
        }
    }
    public async void CmbAlamatCustomer_DropDownVisibleChanged(bool val)
    {
        if (val == true)
        {
            DtCmbAlamatCustomer = (await ah.Get_AlamatCustomer(DrCmbCustomer.Adapt<uimT1CustomerInstansi>().IdCustomer)).Adapt<IList<dynamic>>();
            var updatedAlamatCustomer = DtCmbAlamatCustomer.Adapt<IList<uimT2AlamatCustomer>>();
            updatedAlamatCustomer.ForEach(x => x.T2Kota = DtKota.FirstOrDefault(y => y.IdKota == x.IdKota));
            DtCmbAlamatCustomer = updatedAlamatCustomer.Adapt<IList<dynamic>>();
            await InvokeAsync(StateHasChanged);
        }
        else
        {
            var alamatCustomer = DrCmbAlamatCustomer?.Adapt<uimT2AlamatCustomer>();
            DtCmbRute = DtRute.Where(x => x.IdAlamatCustomer == alamatCustomer.IdAlamatCustomer).Adapt<IList<dynamic>>();
            DrCmbRute = DtCmbRute?.Adapt<IList<uimT3Rute>>().FirstOrDefault();
            PropertyInfo[] alamatCustomerProperties = alamatCustomer.GetType().GetProperties();
            foreach (var property in alamatCustomerProperties)
            {
                var propertyValue = property.GetValue(alamatCustomer);
                var propertyToUpdate = dtPropertiesT7.FirstOrDefault(x => x.Name == $"AlamatCustomer_{property.Name}");
                if (propertyToUpdate is not null)
                {
                    dtPropertiesT7.FirstOrDefault(x => x.Name == $"AlamatCustomer_{property.Name}").SetValue(DtRekapitulasi_Terseleksi.T7PenugasanArmada, propertyValue);
                }

            }
            
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdRute = DrCmbRute.Adapt<uimT3Rute>().IdRute;
            DtBiayaRute = (await ah.Get_BiayaRute(DrCmbCustomer.Adapt<uimT3Rute>().IdRute)).Adapt<IList<uimT4BiayaRute>>();
            if (DrCmbArmada is not null) ProsesHitungBiayaRute();
            await InvokeAsync(StateHasChanged);
        }
    }

    public async void CmbRute_DropDownVisibleChanged(bool val)
    {
        if (!val)
        {
            var rute = DrCmbRute?.Adapt<uimT3Rute>();
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdRute = rute.IdRute;
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.Urutan = 1;
            DtBiayaRute = (await ah.Get_BiayaRute(rute.IdRute)).Adapt<IList<uimT4BiayaRute>>();
            if (DrCmbArmada is not null) {
                var armada = DrCmbArmada?.Adapt<uimT1Armada>();
                DtRekapitulasi_Terseleksi.BBM_BBM = "Solar";
                DtRekapitulasi_Terseleksi.T7PenugasanArmada.BBMHarga = 6800;
                DtRekapitulasi_Terseleksi.IdBBM = Guid.Parse("22357F57-9ECC-405F-8481-F9DC5E2FE3E2");
                /*if (ValidasiRute is not null)
                {
                    if (!string.IsNullOrWhiteSpace(ValidasiRute.IdPenugasanArmada))
                    {
                        if (ValidasiRute.StatusPerjalanan != "Kembali") DialogService.Alert($"Armada dengan Nopol {armada.Nopol} belum kembali dengan no {ValidasiRute.IdTransaksi}", "Perhatian!");
                        else DialogService.Alert($"Armada dengan Nopol {armada.Nopol} tidak dapat diinput karena sedang berada pada rute {ValidasiRute.Rute} di transaksi {ValidasiRute.IdTransaksi}", "Perhatian!");
                        DrCmbArmada = null;
                        await InvokeAsync(StateHasChanged);
                        return;
                    }
                }*/
                ProsesHitungBiayaRute();
            }
            PropertyInfo[] ruteProperties = rute.GetType().GetProperties();
            foreach (var property in ruteProperties)
            {
                var propertyValue = property.GetValue(rute);
                var propertyToUpdate = dtPropertiesT7.FirstOrDefault(x => x.Name == $"Rute_{property.Name}");
                if (propertyToUpdate is not null)
                {
                    dtPropertiesT7.FirstOrDefault(x => x.Name == $"Rute_{property.Name}").SetValue(DtRekapitulasi_Terseleksi.T7PenugasanArmada, propertyValue);
                }

            }
            await InvokeAsync(StateHasChanged);
        }
    }
    public async void CmbArmada_DropDownVisibleChanged(bool val)
    {
        if (val)
        {
            
        }
        else
        {
            var armada = DrCmbArmada?.Adapt<uimT1Armada>();
            PropertyInfo[] customerProperties = armada.GetType().GetProperties();
            foreach (var property in customerProperties)
            {
                var propertyValue = property.GetValue(armada);
                var propertyToUpdate = dtPropertiesT6.FirstOrDefault(x => x.Name == $"Armada_{property.Name}");
                if (propertyToUpdate is not null)
                {
                    dtPropertiesT6.FirstOrDefault(x => x.Name == $"Armada_{property.Name}").SetValue(DtRekapitulasi_Terseleksi, propertyValue);
                }

            }


            /*ValidasiRute = (await Svc.GetValidasiRute(armada.Nopol)).Adapt<uimValidasiRute>();
            if (!string.IsNullOrWhiteSpace(ValidasiRute.IdPenugasanArmada))
            {
                if (ValidasiRute.StatusPerjalanan != "Kembali") DialogService.Alert($"Armada dengan Nopol {armada.Nopol} belum kembali dengan no {ValidasiRute.IdTransaksi}", "Perhatian!");
                else DialogService.Alert($"Armada dengan Nopol {armada.Nopol} tidak dapat diinput karena sedang berada pada rute {ValidasiRute.Rute} di transaksi {ValidasiRute.IdTransaksi}", "Perhatian!");
                DrCmbArmada = null;
                await InvokeAsync(StateHasChanged);
                return;
            }*/
            DtRekapitulasi_Terseleksi.IdArmada = armada.IdArmada;
            DtRekapitulasi_Terseleksi.IdJenisArmada = armada.IdJenisArmada;
            DtRekapitulasi_Terseleksi.Nopol = armada.Nopol;
            DtRekapitulasi_Terseleksi.Armada_Nopol = armada.Nopol;


            //Setup Sopir
            DtCmbSopir = (await ah.Get_ArmadaSopir(armada.IdArmada)).Adapt<IList<dynamic>>();
            DrCmbSopir = DtCmbSopir?.Adapt<IList<uimT5ArmadaSopir>>().FirstOrDefault(x => x.IdArmada == armada.IdArmada);
            var sopir = DrCmbSopir.Adapt<uimT5ArmadaSopir>();
            DtRekapitulasi_Terseleksi.IdKaryawan_Sopir = sopir.IdKaryawan_Sopir;
            DtRekapitulasi_Terseleksi.Karyawan_Sopir_NamaPanggilan = sopir.NamaSopir;
            DtRekapitulasi_Terseleksi.Karyawan_Sopir_Seluler1 = sopir.Seluler1;

            if (DtBiayaRute is not null) ProsesHitungBiayaRute();
            
            await ProsesSimpan_Draft("IdArmada", armada.IdArmada);
            await ProsesSimpan_Draft("IdJenisArmada", armada.IdJenisArmada);
            await InvokeAsync(StateHasChanged);
        }
        
    }

    public async void CmbSopir_DropDownVisibleChanged(bool val)
    {
        if (!val)
        {
            var sopir = DrCmbSopir?.Adapt<uimT5ArmadaSopir>();
            DtRekapitulasi_Terseleksi.IdKaryawan_Sopir = sopir.IdKaryawan_Sopir;
            DtRekapitulasi_Terseleksi.Karyawan_Sopir_NamaPanggilan = sopir.NamaSopir;
            DtRekapitulasi_Terseleksi.Karyawan_Sopir_Seluler1 = sopir.Seluler1;
            await ProsesSimpan_Draft("IdKaryawan_Sopir", sopir.IdKaryawan_Sopir);
            await ProsesSimpan_Draft("Karyawan_Sopir_NamaPanggilan", sopir.NamaSopir);
            await ProsesSimpan_Draft("Karyawan_Sopir_Seluler1", sopir.Seluler1);
            await InvokeAsync(StateHasChanged);
        }
    }

    public async void CmbBBMMetode_DropDownVisibleChanged(bool val)
    {
        if (!val)
        {
            var metodeBBM = DrCmbBBMMetode.Adapt<pthT9DataOption>();
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.BBMMetode = metodeBBM.DataOption;
        }
        else
        {
             
        }
        await InvokeAsync(StateHasChanged);
    }

    public async void CmbRekening_DropDownVisibleChanged(bool val)
    {
        if (val)
        {
            //DtCmbRekening = (await ah.Get_Rekening()).Adapt<IList<dynamic>>();
            //DrCmbRekening = DtCmbRekening.Adapt<IList<pthT0Rekening>>().FirstOrDefault(x => x.Rekening == "Kas Pak Antok");
        }
        else
        {
            var rekening = DrCmbRekening?.Adapt<pthT0Rekening>();
            DtRekapitulasi_Terseleksi.IdRekening = rekening.IdRekening;
            DtRekapitulasi_Terseleksi.Rekening_Rekening = rekening.Rekening;
            await ProsesSimpan_Draft("IdRekening", rekening.IdRekening);
            await ProsesSimpan_Draft("Rekening_Rekening", rekening.Rekening);
        }
        await InvokeAsync(StateHasChanged);
    }

    protected override void GrdDetil_CustomizeEditModel<TDetil>(GridCustomizeEditModelEventArgs e)
    {
        base.GrdDetil_CustomizeEditModel<TDetil>(e);

        if (e.IsNew)
        {
            var drBaru = (uimT7PenugasanArmada_SPBU)e.EditModel;
            //DrCmbBarang_GrdT7OrderPembelian = null;
            drBaru.BBMVolume = 0;
            drBaru.Kode1 = "";
            //drBaru.BBMVolumeSisa = 0;
        }
    }

    protected override void GrdDetil_EditModelSaving<TDetil, TEntity>(GridEditModelSavingEventArgs e)
    {
        base.GrdDetil_EditModelSaving<TDetil, TEntity>(e);
    }
    private void ProsesHitungBiayaRute()
    {
        var armada = DrCmbArmada?.Adapt<uimT1Armada>();
        var biayaRute = DtBiayaRute.FirstOrDefault(x => x.IdJenisArmada == armada.IdJenisArmada);
        if (biayaRute is not null)
        {
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.Urutan = 1;
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.SanguRitase = biayaRute.SanguRitase;
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.Deposit = biayaRute.Deposit;
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.ProsentaseDeposit = biayaRute.ProsentaseDeposit;
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.SanguSementara = (biayaRute.SanguRitase - biayaRute.Deposit - Potongan);
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.TotalAkhir = (biayaRute.SanguRitase - biayaRute.Deposit - Potongan);
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.BBMVolume = biayaRute.BBMVolume;
        }
        else
        {
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.SanguRitase = 0;
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.Deposit = 0;
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.SanguSementara = 0;
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.BBMVolume = 0;
        }
        if (DrCmbIdCompany is not null) DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdCompany = DrCmbIdCompany.Adapt<uimT0Company>().IdCompany;
        StateHasChanged();
    }

    public async void ProsesPilihTab_Detil(string idControl)
    {
        try
        {
            await _js.InvokeVoidAsync("autoScrollKetikaPindahTab", idControl);
            
        }
        catch(Exception e) {
            var msg = e.Message;
        }

    }
    #endregion

    #region Navigasi
    public override async Task ProsesDataBaru()
    {
        await base.ProsesDataBaru();
    }
    public override void ProsesUpdateDatabase()
    {
        SetDetil_SebelumUpdateDatabase<T7PenugasanArmada_SPBU>();
        base.ProsesUpdateDatabase();
    }

    /*protected override async void CtmNavigasi_Click(ContextMenuItemClickEventArgs args)
    {
        if (args.ItemInfo.Text == "Cetak")
        {
            await TampilkanReport("rptPenugasanArmada_1", DtRekapitulasi_Terseleksi.IdPenugasanArmada.ToString());
        }
        
    }*/

    public override async Task ProsesCetak()
    {
        base.ProsesCetak();
        await TampilkanReport("rptPenugasanArmada_1", DtRekapitulasi_Terseleksi.IdPenugasanArmada.ToString());

    }

    #endregion

    public class uimValidasiRute
    {
        public string? IdPenugasanArmada { get; set; }
        public string? IdRute { get; set; }
        public string? IdArmada { get; set; }
        public string? Nopol { get; set; }
        public string? Rute { get; set; }
        public string? SanguSementara { get; set; }
        public int? EstimasiJarak { get; set; }
        public int? EstimasiWaktu { get; set; }
        public double? LamaPenugasanSekarang { get; set; }
        public string? StatusPerjalanan { get; set; }
        public string? IdTransaksi { get; set; }
    }
}
