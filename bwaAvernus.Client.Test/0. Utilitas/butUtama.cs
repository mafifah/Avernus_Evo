using Blazored.Toast;
using bwaCrixalis.Client._1._Master;
using FluentAssertions;
using Pantheon.Client.Services;
using Pantheon.Client.Services.Filter;
using Pantheon.Client.Services.Tag;
using Pantheon.Client.Test.Utility;
using Pantheon.Services;
using Radzen;

namespace bwaAvernus.Test
{
    public class butUtama : IDisposable
	{
		public TestContext _contex { get; }
		TimeSpan _timeout = TimeSpan.FromSeconds(30);
		public butUtama()
		{
			_contex = new TestContext();
			_contex.AddDevExpressBlazorTesting();
			_contex.Services.AddOptions();
			_contex.AddDevExpressBlazorTesting();
			_contex.Services.AddBlazoredLocalStorage();
			_contex.Services.AddDevExpressBlazor(configure => configure.BootstrapVersion = BootstrapVersion.v5);
			_contex.Services.AddBlazoredToast();

			_contex.Services.AddScoped<DialogService>();
			_contex.Services.AddScoped<pthSvcForm>();
			_contex.Services.AddScoped<pthSvcLogin>();
			_contex.Services.AddScoped<DialogService>();
			_contex.Services.AddScoped<pthSvcTag>();
			_contex.Services.AddScoped<pthSvcSettingUser>();
			_contex.Services.AddScoped<pthCalendarService>();
			_contex.Services.AddScoped<pthSvcKonfigurasiHakAkses>();
			_contex.Services.AddScoped<pthSvcFilter>();
			_contex.Services.AddSingleton<svcJabatan>();
			_contex.Services.AddSingleton<svcCompany>();
			_contex.Services.AddSingleton<svcKaryawan>();
			//_contex.Services.AddSingleton<svcInfoKaryawan>();
			_contex.Services.AddSingleton<svcArmada>();
			_contex.Services.AddSingleton<svcDivisiBarang>();
			_contex.Services.AddSingleton<svcKategoriBarang>();
			_contex.Services.AddSingleton<svcJadwalKerjaKaryawan>();
			_contex.Services.AddSingleton<svcJenisSupplier>();
			_contex.Services.AddSingleton<svcSupplierInstansi>();
			_contex.Services.AddSingleton<svcJenisVendor>();
			_contex.Services.AddSingleton<svcVendor>();
			_contex.Services.AddSingleton<svcGudang>();
			_contex.Services.AddSingleton<svcJenisCustomer>();
			_contex.Services.AddSingleton<svcCustomerInstansi>();
			_contex.Services.AddSingleton<svcArmada>();
			_contex.Services.AddSingleton<svcBarang>();
			_contex.Services.AddSingleton<svcRute>();
			_contex.Services.AddSingleton<svcBiayaRute>();
			_contex.Services.AddSingleton<svcBBM>();
			_contex.Services.AddSingleton(ConfigMapster());

			//_contex.Services.AddSingleton<svcOrderPenjualan>();

			AlamatAPI = "https://localhost:5021/";
			if (!string.IsNullOrEmpty(AlamatAPI))
			{
				var handler = new GrpcWebHandler(GrpcWebMode.GrpcWebText, new HttpClientHandler());
				ClientChannel = GrpcChannel.ForAddress(AlamatAPI, new GrpcChannelOptions
				{
					HttpClient = new HttpClient(handler)
				});
			}
		}

		[Fact]
		public void RcpUtama_1_Load()
		{
			// Act
			var cut = _contex.RenderComponent<RcpUtama>();
			cut.WaitForState(() => cut.Markup.Contains("RlRcpUtama"), _timeout);

			// Assert
			cut.Instance.Should().NotBeNull();
		}

		[Fact]
		public void RcpUtama_2_CekJumlahMenu()
		{
			T0Company = new pthT0Company() { IdCompany = "GMA", Nama = "GMA" };
			AssemblyProject = typeof(bwaAvernus.Client._Imports).Assembly;
			URL_SignalR = "https://assignalr.azurewebsites.net/chathub";
			IdUser = Guid.Parse("15270000-B188-AC74-76A2-08DB73920A8B");
			//IdUser = Auto;

			// Act
			var cut = _contex.RenderComponent<RcpUtama>();
			cut.WaitForState(() =>
			{
				try
				{
					var jumlahMenu = DtForm.Where(f => f.IdParent == 0)
										.Join(DtForm.Where(f => f.Form != ""),
											m => m.IdForm.ToString()[..1],
											sm => sm.IdForm.ToString()[..1],
											(m, sm) => new { Menu = m })
										.Select(x => x.Menu)
										.Distinct().Count();
					var jumlahSubMenu = DtForm.Where(x => x.Kategori != "").Count();
					return cut.FindAll("li[class=rz-navigation-item]").Count == jumlahMenu + jumlahSubMenu;
				}
				catch
				{
					return false;
				}
			}, _timeout);

			// Assert
			cut.Instance.Should().NotBeNull();
		}

		[Fact]
		public void RcpUtama_3_PilihMenu()
		{
			NamaDatabase = "dbAvernus";
			T0Company = new pthT0Company() { IdCompany = "GMA", Nama = "GMA" };
			AssemblyProject = typeof(bwaAvernus.Client._Imports).Assembly;
			URL_SignalR = "https://assignalr.azurewebsites.net/chathub";
			//IdUser = Guid.Parse("576023B3-4F55-4B79-BB6D-0B47E8C387B7");
			IdUser = Auto;
			// Act
			var cut = _contex.RenderComponent<RcpUtama>();
			cut.WaitForState(() => cut.FindAll("li[class=rz-navigation-item]").Count > 0, _timeout);
			var jumlahMenu = DtForm.Where(f => f.IdParent == 0)
						  .Join(DtForm.Where(f => f.Form != ""),
								m => m.IdForm.ToString()[0].ToString(),
								sm => sm.IdForm.ToString()[0].ToString(),
								(m, sm) => new { Menu = m })
						  .Select(x => x.Menu)
						  .Distinct();
			var jumlahSubMenu = DtForm.Where(x => x.Kategori != "");
			var unionMenu = jumlahMenu.Concat(jumlahSubMenu).OrderBy(x => x.IdForm);
			int i = 0;
			int indexTab = 0;
			foreach (var dr in unionMenu)
			{

				var ctrlMenu = cut.FindAll("div[class=rz-navigation-item-link]")[i];
				ctrlMenu?.Click();
				cut.WaitForAssertion(() => cut.FindAll("p"), _timeout);//mencari semua tab menu yg sudah di klik
				if (dr.Kategori != "")
				{
					var text = cut.FindAll("p")[indexTab]; //mecari tab terakhir
					Assert.Equal(dr.Inisial, text.TextContent);
					++indexTab;
				}
				++i;
			}
		}
		public void Dispose()
		{
			_contex.Dispose();
		}
	}
}
