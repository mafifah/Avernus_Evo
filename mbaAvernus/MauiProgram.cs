using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Pantheon;
using System.Reflection;
using System.Net.NetworkInformation;
using System.Net;
using Pantheon.Client.Utility;
using Pantheon.Client.Container;
using static Pantheon.Shared.Utility.modBaseExtensions;
using static Pantheon.Client.Utility.modVariabel;
using static Pantheon.Client.Utility.AppBuilderExtensions;
using Pantheon.Services;
using mbaCrixalis._0._Utilitas;
using bwaCrixalis.Client._1._Master;
using bwaAvernus.Client._0._Utilitas;
using bwaCrixalis.Client._0._Utilitas;
using bwaAvernus._1._Master;
using bwaAvernus.Client._2._Transaksi;

namespace mbaAvernus
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            NotifikasiSimpan_SignalR = true;
            //AlamatAPI = "https://localhost:5021";
            //AlamatAPI = "https://grpcevo.azurewebsites.net/";
            URL_SignalR = "https://asSignalR.azurewebsites.net/chathub";
            NamaDatabase = "dbAvernus_Evo";
            AssemblyProject = Assembly.GetExecutingAssembly();
            IdCompany = "ABC";
            Aplikasi_NamaProduk = "Avernus";
            appLanguage = "Bahasa";

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseCrixalisBuilder()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });
            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();

#endif
            builder.Services.AddSerialization();
            builder.Services.AddSingleton<svcJabatan>();
            builder.Services.AddSingleton<svcCompany>();
            builder.Services.AddSingleton<svcKaryawan>();
            builder.Services.AddSingleton<svcArmada>();
            builder.Services.AddSingleton<svcDivisiBarang>();
            builder.Services.AddSingleton<svcKategoriBarang>();
            builder.Services.AddSingleton<svcJadwalKerjaKaryawan>();
            builder.Services.AddSingleton<svcJenisSupplier>();
            builder.Services.AddSingleton<svcSupplierInstansi>();
            builder.Services.AddSingleton<svcJenisVendor>();
            builder.Services.AddSingleton<svcVendor>();
            builder.Services.AddSingleton<svcGudang>();
            builder.Services.AddSingleton<svcJenisCustomer>();
            builder.Services.AddSingleton<svcCustomerInstansi>();
            builder.Services.AddSingleton<svcBarang>();
            builder.Services.AddSingleton<svcSetJurnal>();



            //svc Avernus
            builder.Services.AddSingleton<clsAvernusHandler>();
            builder.Services.AddSingleton<clsCrixalisHandler>();
            builder.Services.AddSingleton<svcBBM>();
            builder.Services.AddSingleton<svcRute>();
            builder.Services.AddSingleton<svcBiayaRute>();

            builder.Services.AddSingleton<svcPenugasanArmada>();
            builder.Services.AddSingleton<svcPenambahanPenugasan>();

            return builder.Build();
        }
    }
}