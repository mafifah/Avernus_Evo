using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Reflection;
using Pantheon.Client.Utility;
using static Pantheon.Shared.Utility.modBaseExtensions;
using static Pantheon.Client.Utility.AppBuilderExtensions;
using bwaAvernus.Client._0._Utilitas;
using bwaAvernus._1._Master;
using bwaAvernus.Client;
using bwaCrixalis.Client._1._Master;
using bwaCrixalis.Client._0._Utilitas;
using bwaAvernus.Client._2._Transaksi;
using Blazored.Modal;
using bwaCrixalis.Client._2._Transaksi;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
NotifikasiSimpan_SignalR = true;
URL_SignalR = "https://assignalr.azurewebsites.net/chathub";
NamaDatabase = "dbAvernus";
AssemblyProject = Assembly.GetExecutingAssembly();
IdCompany = "GMA";
Aplikasi_NamaProduk = "Avernus";
appLanguage = "Bahasa";

builder.UseBlazorPantheon();
builder.Services.AddBlazoredModal();
builder.Services.AddSerialization();
//GetCrixalisServices(builder.Services);

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


builder.Services.AddScoped<svcHutangUsaha>();
builder.Services.AddScoped<svcPelunasanHutangUsaha>();
builder.Services.AddScoped<svcPiutangUsaha>();
builder.Services.AddScoped<svcPelunasanPiutangUsaha>();
builder.Services.AddScoped<svcHutangGiro>();
builder.Services.AddScoped<svcPencairanHutangGiro>();
builder.Services.AddScoped<svcPiutangGiro>();
builder.Services.AddScoped<svcPencairanPiutangGiro>();

builder.Services.AddScoped<svcKasBankMasuk>();
builder.Services.AddScoped<svcKasBankKeluar>();
builder.Services.AddScoped<svcPiutangKaryawan>();
builder.Services.AddScoped<svcPelunasanPiutangKaryawan>();

builder.Services.AddScoped<svcOrderPembelian>();
builder.Services.AddScoped<svcPembelianAset>();

builder.Services.AddScoped<svcOrderPenjualan>();

//svc Avernus
builder.Services.AddSingleton<clsAvernusHandler>();
builder.Services.AddSingleton<clsCrixalisHandler>();
builder.Services.AddSingleton<svcBBM>();
builder.Services.AddSingleton<svcRute>();
builder.Services.AddSingleton<svcBiayaRute>();

builder.Services.AddSingleton<svcPenugasanArmada>();
builder.Services.AddSingleton<svcPendataanMuatan>();


await builder.Build().RunAsync();
