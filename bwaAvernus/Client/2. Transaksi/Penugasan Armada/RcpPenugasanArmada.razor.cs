using bwaAvernus.Client._0._Utilitas;
using bwaCrixalis.Client._1._Master;
using bwaAvernus._1._Master;
using bwaCrixalis.Client._0._Utilitas;
using bwaAvernus.Shared._2._Transaksi;
using System.Reflection;
using System.Collections.ObjectModel;
using Pantheon.Shared.UIModels;
using Pantheon.Client.Services.LogUser;
using Microsoft.AspNetCore.Components;
using Radzen;
using Microsoft.JSInterop;
using Microsoft.Ajax.Utilities;

namespace bwaAvernus.Client._2._Transaksi;
public partial class RcpPenugasanArmada : ConTransaksi_1<uimT6PenugasanArmada, svcPenugasanArmada>
{
    #region Inject
    [Inject]
    public svcCompany _svcCompany { get; set; }

    [Inject]
    public svcArmada _svcArmada { get; set; }

    [Inject]
    public svcRute _svcRute{ get; set; }

    [Inject]

    DialogService DialogService { get; set; }

    [Inject]
    IJSRuntime _js { get; set; }

    [Inject]
    protected pthSvcLog _svc { get; set; }
    #endregion

    #region Fli
    public DxFormLayoutItem FliCompany { get; set; }
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
    public DxComboBox<uimT0Company, uimT0Company> CmbCompany { get; set; }
    public DxTextBox TxbIdTransaksi { get; set; }
    public DxDateEdit<DateTimeOffset?> DteWaktuProses { get; set; }

    public DxComboBox<uimT1CustomerInstansi, uimT1CustomerInstansi> CmbCustomer;
    public DxComboBox<uimT2AlamatCustomer, uimT2AlamatCustomer> CmbAlamatCustomer;
    public DxComboBox<uimT3Rute, uimT3Rute> CmbRute;
    public DxSpinEdit<decimal?> SpeSanguRitase { get; set; }
    public DxSpinEdit<decimal?> SpeTotalSangu { get; set; }
    public DxSpinEdit<decimal?> SpeBBMVolume { get; set; }
    public DxSpinEdit<decimal?> SpeBBMHarga { get; set; }
    public DxSpinEdit<decimal?> SpeBBMSangu { get; set; }
    public DxSpinEdit<decimal?> SpeDeposit { get; set; }
    public DxSpinEdit<decimal?> SpePotongan { get; set; }
    public DxSpinEdit<decimal?> SpeTotalAkhir { get; set; }
    public DxSpinEdit<decimal?> SpeSanguSementara { get; set; }
    
    public DxComboBox<uimT1Armada, uimT1Armada> CmbArmada;
    public DxComboBox<uimT5ArmadaSopir, uimT5ArmadaSopir> CmbSopir;

    public DxComboBox<pthT9DataOption, pthT9DataOption> CmbBBMMetode;
    public DxComboBox<pthT0Rekening, pthT0Rekening> CmbRekening;

    public IGrid GrdT7PenugasanArmada_SPBU { get; set; }
    #endregion

    #region Data List
    public IList<uimT0Company> DtCmbCompany { get; set; }
    public ObservableCollection<uimT1CustomerInstansi> DtCmbCustomer { get; set; }
    public ObservableCollection<uimT2AlamatCustomer> DtCmbAlamatCustomer { get; set; }
    public ObservableCollection<uimT3Rute> DtCmbRute { get; set; }
    public ObservableCollection<uimT1Armada> DtCmbArmada { get; set; }
    public ObservableCollection<uimT5ArmadaSopir> DtCmbSopir { get; set; }
    public ObservableCollection<pthT9DataOption> DtCmbBBMMetode { get; set; }
    public ObservableCollection<pthT0Rekening> DtCmbRekening { get; set; }
    public IList<dynamic> DtGrdT7PenugasanArmada_SPBU { get; set; }
    public ObservableCollection<uimT3Rute> DtRute { get; set; }
    public ObservableCollection<uimT4BiayaRute> DtBiayaRute { get; set; }
    public IList<uimT2Kota> DtKota { get; set; }
    public IList<uimT0JenisArmada> DtJenisArmada { get; set; }
    #endregion

    #region Properties
    public uimT0Company? DrCmbCompany { get; set; }
    public uimT1CustomerInstansi? DrCmbCustomer { get; set; }
    public uimT2AlamatCustomer? DrCmbAlamatCustomer { get; set; }
    public uimT3Rute? DrCmbRute { get; set; }
    public uimT1Armada? DrCmbArmada { get; set; }
    public uimT5ArmadaSopir? DrCmbSopir { get; set; }
    public pthT9DataOption? DrCmbBBMMetode { get; set; }
    public pthT0Rekening? DrCmbRekening { get; set; }
    public decimal? Potongan { get; set; } = 0;

    public string? UrlGambarArmada { get; set; } = "";
    public string? UrlGambarSopir { get; set; } = "";

    public bool TampilkanGambarArmada = false;

    public bool TampilkanGambarSopir = true;
    public uimValidasiRute? ValidasiRute { get; set; } = new();
    #endregion


    private readonly clsCrixalisHandler ch = new();
    private readonly clsAvernusHandler ah = new();
    PropertyInfo[]? dtPropertiesT7;
    PropertyInfo[]? dtPropertiesT6;

    private string outerHeight = "";
    private string outerHeightTopHeaderCaption = "";

    public IEnumerable<uimLog>? DtGrdInformasi { get; set; }
    protected override async void OnInitialized()
    {
        SedangProsesRefreshDetil = true;
        PrimaryText = "IdTransaksi";
        base.OnInitialized();
        DtKota = await ch.Get_Kota();
        DtJenisArmada = (await _svcArmada.GetDataJenisArmada()).ToList();
        if (DtCmbArmada is null) DtCmbArmada = await ah.Get_Armada();
        if (DtCmbCustomer is null) DtCmbCustomer = await ah.Get_Customer();
        if (DtCmbRekening is null) DtCmbRekening = await ah.Get_Rekening();
        if (DtCmbBBMMetode is null) DtCmbBBMMetode = (await ah.Get_DataOption("Metode BBM")).Adapt<ObservableCollection<pthT9DataOption>>();
        if (DtCmbCompany is null) DtCmbCompany = (await _svcCompany.GetDataCompany()).Adapt<ObservableCollection<uimT0Company>>();
        //if (DtCmbSopir is null) DtCmbSopir = (await ah.Get_ArmadaSopir()).Adapt<IList<dynamic>>();
        //if (DtCmbRute is null) DtCmbRute = (await ah.Get_RuteByIdAlamatCustomer()).Adapt<IList<dynamic>>();
        //if (DtBiayaRute.Count() < 1) DtBiayaRute = (await ah.Get_BiayaRute()).Adapt<IList<uimT4BiayaRute>>();
        DtRute = (await ah.Get_RuteByIdAlamatCustomer()).Adapt<ObservableCollection<uimT3Rute>>();
        if (DtCmbRute is null) DtCmbRute = DtRute;

        var updatedCustomer = DtCmbCustomer;
        updatedCustomer.ForEach(x => x.T2Kota = DtKota.FirstOrDefault(y => y.IdKota == x.IdKota));
        DtCmbCustomer = updatedCustomer;


        dtPropertiesT6 = DtRekapitulasi_Terseleksi.GetType().GetProperties();
        dtPropertiesT7 = DtRekapitulasi_Terseleksi?.T7PenugasanArmada?.GetType().GetProperties();

        DrCmbCompany = DtCmbCompany?.FirstOrDefault(x => x.IdCompany == IdCompany);
        DrCmbBBMMetode = DtCmbBBMMetode?.FirstOrDefault(x => x.DataOption == "Voucher");
        DrCmbRekening = DtCmbRekening?.FirstOrDefault(x => x.Rekening == "Kas Pak Antok");

        SedangProsesRefreshDetil = false;
        StateHasChanged();
    }
    protected override async void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);
        var outer = await _js.InvokeAsync<int>("getLength");
        var outerHeader = await _js.InvokeAsync<int>("getLengthTopHeaderCaption");
        outerHeight = $"{outer + 89}px !important";
        outerHeightTopHeaderCaption = $"{outerHeader}px !important";
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
        if (data != null)
        {
			SedangProsesRefreshDetil = true;
			DrCmbArmada = DtCmbArmada.Adapt<IList<uimT1Armada>>().FirstOrDefault(x => x.IdArmada == DtRekapitulasi_Terseleksi.IdArmada);
			var baseUrl = "https://sdatafile.blob.core.windows.net/gajahmasantarniaga/Gambar/Armada/";
			var baseUrlKaryawan = "https://sdatafile.blob.core.windows.net/gajahmasantarniaga/Gambar/Karyawan/";
			var armada = DrCmbArmada?.Adapt<uimT1Armada>();
			var nopol = armada.Nopol.Replace(" ", "%20");
            var namaSopir = DtRekapitulasi_Terseleksi.Karyawan_Sopir_NamaPanggilan.Replace(" ", "%20");
            UrlGambarArmada = $"{baseUrl}{nopol}.jpg";
			UrlGambarSopir = $"{baseUrlKaryawan}{namaSopir}.JPG";

			DtCmbSopir = (await ah.Get_ArmadaSopir(DrCmbArmada?.IdArmada)).Adapt<ObservableCollection<uimT5ArmadaSopir>>();
			DrCmbSopir = DtCmbSopir.FirstOrDefault(x => x.IdKaryawan_Sopir == DtRekapitulasi_Terseleksi.IdKaryawan_Sopir);
			DtRekapitulasi_Terseleksi.T7PenugasanArmada = (await Svc.GetDataT7PenugasanArmadaById(DtRekapitulasi_Terseleksi.IdPenugasanArmada)).Adapt<IList<uimT7PenugasanArmada>>().FirstOrDefault(x => x.Urutan == 1);

			DrCmbCustomer = DtCmbCustomer.FirstOrDefault(x => x.IdCustomer == DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdCustomer);
			DtCmbAlamatCustomer = (await ah.Get_AlamatCustomer((Guid)DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdCustomer)).Adapt<ObservableCollection<uimT2AlamatCustomer>>();
			DrCmbAlamatCustomer = DtCmbAlamatCustomer.FirstOrDefault(x => x.IdAlamatCustomer == DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdAlamatCustomer);
			DrCmbRute = DtCmbRute.FirstOrDefault(x => x.IdRute == DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdRute);
			var dtBBM = DtCmbBBMMetode;
			DrCmbBBMMetode = dtBBM.FirstOrDefault(x => x.DataOption == DtRekapitulasi_Terseleksi.T7PenugasanArmada.BBMMetode);
			DrCmbRekening = DtCmbRekening.FirstOrDefault(x => x.IdRekening == DtRekapitulasi_Terseleksi.IdRekening);
			SedangProsesRefreshDetil = false;
			DtGrdInformasi = await _svc.GetDataLog(DtRekapitulasi_Terseleksi.IdPenugasanArmada.ToString() ?? "");
		}

       
        StateHasChanged();
    }
    #endregion

    #region Detil
    public override async Task ProsesMuat_Detil()
    {
        /*ListCmb.AddRange(new BaseCmb[] {
            new BaseCmb
            {
                Cmb = CmbCompany,
                Wajib = true
            }
        });*/
        await base.ProsesMuat_Detil();

    }
    public override async void ProsesPerbarui_Control(string namaControl, object dtCmb, bool perbaruiMeskipunAda = false)
    {
        if (namaControl == nameof(CmbCompany))
        {
            dtCmb = await _svcCompany.GetDataCompany();
        }
        if (namaControl == nameof(CmbCustomer))
        {
            dtCmb = (await ah.Get_Customer());
        }
        if (namaControl == nameof(CmbArmada))
        {
            dtCmb = (await ah.Get_Armada());
        }
        if (namaControl == nameof(CmbBBMMetode))
        {
            dtCmb = await ch.Get_DataOption("Metode BBM");
        }
        if (namaControl == nameof(CmbRekening))
        {
            dtCmb = (await ah.Get_Rekening());
        }
        base.ProsesPerbarui_Control(namaControl, dtCmb, perbaruiMeskipunAda);

        DrCmbCompany = DtCmbCompany?.FirstOrDefault(x => x.IdCompany == IdCompany);
        await InvokeAsync(StateHasChanged);
    }
    public async void CmbCompany_Dipilih(uimT0Company company)
    {
        DrCmbCompany = company;
        DtRekapitulasi_Terseleksi.IdCompany = company.IdCompany;
        StateHasChanged();

    }
    
    public async void CmbCustomer_Dipilih(uimT1CustomerInstansi customer)
    {
        DrCmbCustomer = customer;

        DtCmbAlamatCustomer = (await ah.Get_AlamatCustomer(customer.IdCustomer)).Adapt<ObservableCollection<uimT2AlamatCustomer>>();
        var updatedAlamatCustomer = DtCmbAlamatCustomer;
        updatedAlamatCustomer.ForEach(x => x.T2Kota = DtKota.FirstOrDefault(y => y.IdKota == x.IdKota));
        DtCmbAlamatCustomer = updatedAlamatCustomer;


        DrCmbAlamatCustomer = DtCmbAlamatCustomer?.FirstOrDefault();
        var alamatCustomer = DrCmbAlamatCustomer;

        DtCmbRute = (DtRute.Where(x => x.IdAlamatCustomer == alamatCustomer.IdAlamatCustomer).ToList()).Adapt<ObservableCollection<uimT3Rute>>();
        DrCmbRute = DtCmbRute.FirstOrDefault();

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
        DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdRute = DrCmbRute?.IdRute;
        DtRekapitulasi_Terseleksi.BBM_BBM = "Solar";
        DtRekapitulasi_Terseleksi.T7PenugasanArmada.BBMHarga = 6800;
        DtRekapitulasi_Terseleksi.IdBBM = Guid.Parse("22357F57-9ECC-405F-8481-F9DC5E2FE3E2");
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

        PropertyInfo[] ruteProperties = DrCmbRute?.GetType().GetProperties();
        foreach (var property in ruteProperties)
        {
            var propertyValue = property.GetValue(DrCmbRute);
            var propertyToUpdate = dtPropertiesT7.FirstOrDefault(x => x.Name == $"Rute_{property.Name}");
            if (propertyToUpdate is not null)
            {
                dtPropertiesT7.FirstOrDefault(x => x.Name == $"Rute_{property.Name}").SetValue(DtRekapitulasi_Terseleksi.T7PenugasanArmada, propertyValue);
            }

        }

        DtBiayaRute = (await ah.Get_BiayaRute(DrCmbRute.IdRute)).Adapt<ObservableCollection<uimT4BiayaRute>>();
        if (DrCmbArmada is not null) ProsesHitungBiayaRute();
        await InvokeAsync(StateHasChanged);
    }
    public async void CmbAlamatCustomer_Dipilih(uimT2AlamatCustomer alamatCustomer)
    {
        DrCmbAlamatCustomer = alamatCustomer;
        DtCmbRute = DtRute.Where(x => x.IdAlamatCustomer == alamatCustomer.IdAlamatCustomer).Adapt<ObservableCollection<uimT3Rute>>();
        DrCmbRute = DtCmbRute?.FirstOrDefault();
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

        PropertyInfo[] ruteProperties = DrCmbRute?.GetType().GetProperties();
        foreach (var property in ruteProperties)
        {
            var propertyValue = property.GetValue(DrCmbRute);
            var propertyToUpdate = dtPropertiesT7.FirstOrDefault(x => x.Name == $"Rute_{property.Name}");
            if (propertyToUpdate is not null)
            {
                dtPropertiesT7.FirstOrDefault(x => x.Name == $"Rute_{property.Name}").SetValue(DtRekapitulasi_Terseleksi.T7PenugasanArmada, propertyValue);
            }

        }

        DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdRute = DrCmbRute?.IdRute;
        DtRekapitulasi_Terseleksi.BBM_BBM = "Solar";
        DtRekapitulasi_Terseleksi.T7PenugasanArmada.BBMHarga = 6800;
        DtRekapitulasi_Terseleksi.IdBBM = Guid.Parse("22357F57-9ECC-405F-8481-F9DC5E2FE3E2");
        DtBiayaRute = (await ah.Get_BiayaRute(DrCmbRute.IdRute)).Adapt<ObservableCollection<uimT4BiayaRute>>();
        if (DrCmbArmada is not null) ProsesHitungBiayaRute();
        await InvokeAsync(StateHasChanged);
    }

    public async void CmbRute_Dipilih(uimT3Rute rute)
    {
        DrCmbRute = rute;
        DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdRute = rute.IdRute;
        DtRekapitulasi_Terseleksi.T7PenugasanArmada.Urutan = 1;
        DtBiayaRute = (await ah.Get_BiayaRute(rute.IdRute)).Adapt<ObservableCollection<uimT4BiayaRute>>();
        if (DrCmbArmada is not null)
        {
            var armada = DrCmbArmada?.Adapt<uimT1Armada>();
            DtRekapitulasi_Terseleksi.BBM_BBM = "Solar";
            DtRekapitulasi_Terseleksi.T7PenugasanArmada.BBMHarga = 6800;
            DtRekapitulasi_Terseleksi.IdBBM = Guid.Parse("22357F57-9ECC-405F-8481-F9DC5E2FE3E2");
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
    public async void CmbArmada_Dipilih(uimT1Armada armada)
    {
            var baseUrl = "https://sdatafile.blob.core.windows.net/gajahmasantarniaga/Gambar/Armada/";
            var baseUrlKaryawan = "https://sdatafile.blob.core.windows.net/gajahmasantarniaga/Gambar/Karyawan/";
            DrCmbArmada = armada;
            //var armada = DrCmbArmada?.Adapt<uimT1Armada>();
            DtRekapitulasi_Terseleksi.JenisArmada_Jenis = DtJenisArmada.FirstOrDefault(x => x.IdJenisArmada == armada.IdJenisArmada).Jenis;
            DtRekapitulasi_Terseleksi.JenisArmada_Alias = DtJenisArmada.FirstOrDefault(x => x.IdJenisArmada == armada.IdJenisArmada).Alias;
            var nopol = armada?.Nopol?.Replace(" ", "%20");
            UrlGambarArmada = $"{baseUrl}{nopol}.jpg";
            
        PropertyInfo[] customerProperties = armada?.GetType().GetProperties();
            foreach (var property in customerProperties)
            {
                var propertyValue = property.GetValue(armada);
                var propertyToUpdate = dtPropertiesT6.FirstOrDefault(x => x.Name == $"Armada_{property.Name}");
                if (propertyToUpdate is not null)
                {
                    dtPropertiesT6?.FirstOrDefault(x => x.Name == $"Armada_{property.Name}").SetValue(DtRekapitulasi_Terseleksi, propertyValue);
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
            DtCmbSopir = (await ah.Get_ArmadaSopir(armada.IdArmada)).Adapt<ObservableCollection<uimT5ArmadaSopir>>();
            DrCmbSopir = DtCmbSopir?.FirstOrDefault(x => x.IdArmada == armada.IdArmada);
            var sopir = DrCmbSopir;
            UrlGambarSopir = $"{baseUrlKaryawan}{sopir?.NamaSopir.Replace(" ","%20")}.JPG";
            DtRekapitulasi_Terseleksi.IdKaryawan_Sopir = sopir.IdKaryawan_Sopir;
            DtRekapitulasi_Terseleksi.Karyawan_Sopir_NamaPanggilan = sopir.NamaSopir;
            DtRekapitulasi_Terseleksi.Karyawan_Sopir_Seluler1 = sopir.Seluler1;

            if (DtBiayaRute is not null) ProsesHitungBiayaRute();
            
            //await ProsesSimpan_Draft("IdArmada", armada.IdArmada);
           // await ProsesSimpan_Draft("IdJenisArmada", armada.IdJenisArmada);
            await InvokeAsync(StateHasChanged);
        
        
    }

    public async void CmbSopir_Dipilih(uimT5ArmadaSopir sopir)
    {
        DrCmbSopir = sopir;
        //var sopir = DrCmbSopir;
        DtRekapitulasi_Terseleksi.IdKaryawan_Sopir = sopir?.IdKaryawan_Sopir;
        DtRekapitulasi_Terseleksi.Karyawan_Sopir_NamaPanggilan = sopir?.NamaSopir;
        DtRekapitulasi_Terseleksi.Karyawan_Sopir_Seluler1 = sopir?.Seluler1;
        await ProsesSimpan_Draft("IdKaryawan_Sopir", sopir?.IdKaryawan_Sopir);
        await ProsesSimpan_Draft("Karyawan_Sopir_NamaPanggilan", sopir?.NamaSopir);
        await ProsesSimpan_Draft("Karyawan_Sopir_Seluler1", sopir?.Seluler1);
        await InvokeAsync(StateHasChanged);
    }

    public async void CmbBBMMetode_Dipilih(pthT9DataOption metodeBBM)
    {
        DrCmbBBMMetode = metodeBBM;
        DtRekapitulasi_Terseleksi.T7PenugasanArmada.BBMMetode = metodeBBM.DataOption;
        await InvokeAsync(StateHasChanged);
    }

    public async void CmbRekening_Dipilih(pthT0Rekening rekening)
    {
        DrCmbRekening = rekening;
        DtRekapitulasi_Terseleksi.IdRekening = rekening.IdRekening;
        DtRekapitulasi_Terseleksi.Rekening_Rekening = rekening.Rekening;
        //await ProsesSimpan_Draft("IdRekening", rekening.IdRekening);
        //await ProsesSimpan_Draft("Rekening_Rekening", rekening.Rekening);
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
        if (DrCmbCompany is not null) DtRekapitulasi_Terseleksi.T7PenugasanArmada.IdCompany = DrCmbCompany.IdCompany;

        DtRekapitulasi_Terseleksi.IdRekening = DrCmbRekening?.IdRekening;
        DtRekapitulasi_Terseleksi.Rekening_Rekening = DrCmbRekening?.Rekening;
        DtRekapitulasi_Terseleksi.T7PenugasanArmada.BBMMetode = DrCmbBBMMetode?.DataOption;
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
        DrCmbArmada = null;
        DrCmbSopir = null;
        DrCmbCustomer = null;
        DrCmbAlamatCustomer = null;
        DrCmbRute = null;
        DrCmbBBMMetode = null;
        DrCmbRekening = null;
        UrlGambarArmada = "";
        UrlGambarSopir = "";
        DtGrdInformasi = null;
        DrCmbCompany = DtCmbCompany?.FirstOrDefault(x => x.IdCompany == IdCompany);
        DrCmbBBMMetode = DtCmbBBMMetode?.FirstOrDefault(x => x.DataOption == "Voucher");
        DrCmbRekening = DtCmbRekening?.FirstOrDefault(x => x.Rekening == "Kas Pak Antok");
        StateHasChanged();
    }
    public override void ProsesUpdateDatabase()
    {
        DtRekapitulasi_Terseleksi.IdCompany = IdCompany;
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
