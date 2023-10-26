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

            return builder.Build();
        }
    }
}