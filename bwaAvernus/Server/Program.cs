global using Microsoft.EntityFrameworkCore;
using bwaAvernus.Server.Data;
using bwaCrixalis.Server.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json.Serialization;
using bwaCrixalis.Server._1._Master;
using bwaAvernus.Server._1._Master;
using Pantheon.Server.Utility;
using DevExpress.AspNetCore;
using static Pantheon.Shared.Utility.modBaseExtensions;
using Pantheon.Server.BackgroundServices;
using bwaCrixalis.Server.Controllers;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using DevExpress.AspNetCore.Reporting;
using bwaAvernus.Server._2._Transaksi;
using bwaCrixalis.Server._2._Transaksi;
using bwaCrixalis.Shared._2._Transaksi;
using bwaAvernus.Client._2._Transaksi;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

NotifikasiSimpan_SignalR = true;
URL_SignalR = "https://asSignalRServer.azurewebsites.net/chathub";
AlamatAPI = "https://localhost:7243/";
// Add services to the container.
services.AddGrpc(options =>
{
	options.Interceptors.Add<pthServerLoggerInterceptor>();
});

var allow = "AllowAll";
services.AddCors(o => o.AddPolicy(allow, builder =>
{
	builder.WithOrigins("https://localhost:7272",
						"http://localhost:5004")
						.AllowAnyHeader()
						.AllowAnyMethod();
}));

services.AddControllersWithViews();
services.AddRazorPages();
services.AddDevExpressControls();

var conn = builder.Configuration.GetConnectionString("DefaultConnection");
NamaDatabase = (conn?.Split(';').FirstOrDefault(x => x.Contains("Database")) ?? conn?.Split(';').FirstOrDefault(x => x.Contains("Initial Catalog")))?.ToString().Split('=')[1].Replace(" ", "");
//Config Database
services.AddDbContext<AvernusDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
services.AddDbContext<CrixalisDbContext_Log>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection_Log")));

ConfigurationManager configuration = builder.Configuration;
var appSettingSection = configuration.GetSection("AppSettings");
services.Configure<AppSettings>(appSettingSection);

var appSettings = appSettingSection.Get<AppSettings>();
var key = Encoding.UTF8.GetBytes(appSettings.Secret);


//Add JWT Bearer
services.AddAuthentication(x =>
{
	x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
	.AddJwtBearer(x =>
	{
		x.RequireHttpsMetadata = false;
		x.SaveToken = true;
		x.TokenValidationParameters = new TokenValidationParameters
		{
			ValidateIssuerSigningKey = true,
			IssuerSigningKey = new SymmetricSecurityKey(key),
			ValidateIssuer = false,
			ValidateAudience = false
		};
	});
services.AddAuthorization();

// Configure the HTTP request pipeline.
var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
if (!(!string.IsNullOrWhiteSpace(environment) && environment.Contains("Development")))
{
	builder.WebHost.ConfigureKestrel(options =>
	{
		// Setup a HTTP/2 endpoint without TLS.
		options.ListenAnyIP(5021, o =>
		{
			o.Protocols = HttpProtocols.Http1AndHttp2;
			o.UseHttps();
		});
	});
}
services.AddGrpc().AddJsonTranscoding();
services.AddGrpcReflection();
services.AddGrpcSwagger();

services.AddSwaggerGen(c =>
{
	c.SwaggerDoc("v1",
	new Microsoft.OpenApi.Models.OpenApiInfo { Title = "gRPC for Avernus", Version = "v1" });
});

services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
services.AddSingleton(ConfigMapster());

services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));

//Svd Pantheon
services.AddScoped<pthIUnitOfWork, pthUnitOfWork<AvernusDbContext>>();
services.AddPantheonDefaultService<AvernusDbContext, CrixalisDbContext_Log>();

//Log
services.AddScoped<pthIUnitOfWork_Log, pthUnitOfWork_Log<CrixalisDbContext_Log>>();

//Svd Crixalis
services.AddScoped<ISvdKategoriBarang, svdKategoriBarang>();
services.AddScoped<ISvdCompany, svdCompany>();
services.AddScoped<ISvdJadwalKerjaKaryawan, svdJadwalKerjaKaryawan>();

services
    .AddHostedService<pthBaseStreamBackgroundService<pthT0Jabatan, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil>>()
    .AddHostedService<pthBaseStreamBackgroundService<T0DivisiBarang, T1SubDivisiBarang, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil>>()
    .AddHostedService<pthBaseStreamBackgroundService<T1Supplier, T2AlamatSupplier, T2PenyeliaSupplier, BaseModelMasterDetil, BaseModelMasterDetil, BaseModelMasterDetil>>()
    .AddHostedService<pthBaseStreamBackgroundService<T1Armada, T4NopolArmada, T5ArmadaCustomer, T5ArmadaSopir, BaseModelMasterDetil, BaseModelMasterDetil>>()
    .AddRedis(builder.Configuration.GetConnectionString("RedisCacheConnection"))
    .AddRedisStreaming()
    .AddSerialization()
    .AddStreaming()
    .AddMessaging();

//service report
builder.Services.AddSingleton<IWebDocumentViewerReportResolver, CustomWebDocumentViewerReportResolver>();


var app = builder.Build();

if(app.Environment.IsDevelopment())
{
	app.UseWebAssemblyDebugging();
}
else
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

//Perlu ini spy maui client bisa controller dari server ini saat buka report
app.UseCors(x => x
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .SetIsOriginAllowed(origin => true) // allow any origin
                    .AllowCredentials()); // allow credentials

app.UseHttpsRedirection();
app.UseReporting(builder => {
    builder.UserDesignerOptions.DataBindingMode =
        DevExpress.XtraReports.UI.DataBindingMode.ExpressionsAdvanced;
});
app.UseDevExpressControls();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseGrpcWeb();
app.UseCors(allow);
app.MapGrpcReflectionService();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "gRPC for Avernus");
});

app.UsePantheonDefaultService();


//Svs Crixalis
app.MapGrpcService<svsJabatan>().EnableGrpcWeb();
app.MapGrpcService<svsAkun>().EnableGrpcWeb();
app.MapGrpcService<svsCompany>().EnableGrpcWeb();
app.MapGrpcService<svsKaryawan>().EnableGrpcWeb();
app.MapGrpcService<svsDivisiBarang>().EnableGrpcWeb();
app.MapGrpcService<svsKategoriBarang>().EnableGrpcWeb();
app.MapGrpcService<svsJadwalKerjaKaryawan>().EnableGrpcWeb();
app.MapGrpcService<svsJenisSupplier>().EnableGrpcWeb();
app.MapGrpcService<svsSupplier>().EnableGrpcWeb();
app.MapGrpcService<svsJenisVendor>().EnableGrpcWeb();
app.MapGrpcService<svsVendor>().EnableGrpcWeb();
app.MapGrpcService<svsGudang>().EnableGrpcWeb();
app.MapGrpcService<svsJenisCustomer>().EnableGrpcWeb();
app.MapGrpcService<svsCustomer>().EnableGrpcWeb();
app.MapGrpcService<svsArmada>().EnableGrpcWeb();
app.MapGrpcService<svsBarang>().EnableGrpcWeb();
app.MapGrpcService<svsSetJurnal>().EnableGrpcWeb();
app.MapGrpcService<svsAset>().EnableGrpcWeb();

app.MapGrpcService<svsOrderPenjualan>().EnableGrpcWeb();
app.MapGrpcService<svsOrderPembelian>().EnableGrpcWeb();
app.MapGrpcService<svsHutangUsaha>().EnableGrpcWeb();
app.MapGrpcService<svsPelunasanHutangUsaha>().EnableGrpcWeb();
app.MapGrpcService<svsPiutangUsaha>().EnableGrpcWeb();
app.MapGrpcService<svsPelunasanPiutangUsaha>().EnableGrpcWeb();
app.MapGrpcService<svsHutangGiro>().EnableGrpcWeb();
app.MapGrpcService<svsPencairanHutangGiro>().EnableGrpcWeb();
app.MapGrpcService<svsPiutangGiro>().EnableGrpcWeb();
app.MapGrpcService<svsPencairanPiutangGiro>().EnableGrpcWeb();
app.MapGrpcService<svsPembelianAset>().EnableGrpcWeb();
app.MapGrpcService<svsKasBankMasuk>().EnableGrpcWeb();
app.MapGrpcService<svsKasBankKeluar>().EnableGrpcWeb();
app.MapGrpcService<svsPiutangKaryawan>().EnableGrpcWeb();
app.MapGrpcService<svsPelunasanPiutangKaryawan>().EnableGrpcWeb();

//Svs Avernus
app.MapGrpcService<svsBBM>().EnableGrpcWeb();
app.MapGrpcService<svsRute>().EnableGrpcWeb();
app.MapGrpcService<svsBiayaRute>().EnableGrpcWeb();
app.MapGrpcService<svsPenugasanArmada>().EnableGrpcWeb();
app.MapGrpcService<svsPendataanMuatan>().EnableGrpcWeb();
app.MapGrpcService<svsPenambahanPenugasanArmada>().EnableGrpcWeb();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
