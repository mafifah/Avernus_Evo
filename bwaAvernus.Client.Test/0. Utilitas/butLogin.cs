global using static Pantheon.Client.Utility.modVariabel;
global using static Pantheon.Shared.Utility.modBaseExtensions;
global using Microsoft.Extensions.DependencyInjection;
global using DevExpress.Blazor;
global using Pantheon.Shared.UIModels;
global using Bunit;
global using bwaCrixalis.Client._0._Utilitas;
global using Xunit;
global using Grpc.Net.Client.Web;
global using Grpc.Net.Client;
global using Blazored.LocalStorage;
using Pantheon.Client.Test.Utility;

namespace bwaAvernus.Test
{
    public class butLogin : IDisposable
	{
		public TestContext _contex { get; }
		public butLogin()
		{
			_contex = new TestContext();
			_contex.AddDevExpressBlazorTesting();
			_contex.Services.AddOptions();
			_contex.AddDevExpressBlazorTesting();
			_contex.Services.AddBlazoredLocalStorage();
			_contex.Services.AddDevExpressBlazor(configure => configure.BootstrapVersion = BootstrapVersion.v5);

			AlamatAPI = "https://ascrixalis-evo.azurewebsites.net/";
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
		public void RcpLogin_1_UsernameKosong_ValidationMessageTampil()
		{
			var cut = _contex.RenderComponent<RcpLogin>(par => par.Add(p => p.uimLogin, new uimLogin() { UserName = "", Password = "" }));
			var timeOut = TimeSpan.FromSeconds(30);
			cut.WaitForState(() => cut.Markup.Contains("dxbl-form-layout-item"), timeOut);
			//var txbUsername = cut.Find("input[name=TxbUsername]");
			//var txbPassword = cut.Find("input[name=TxbPassword]");
			var editForm = cut.Find("form");

			// Act
			editForm.Submit();
			cut.WaitForState(() => cut.Markup.Contains("User Name tidak boleh kosong"), timeOut);

			var validasiUserNameKosong = cut.Find("div[class=validation-message]");

			//// Assert
			Assert.Equal("User Name tidak boleh kosong", validasiUserNameKosong.TextContent);
		}

		[Fact]
		public void RcpLogin_2_PasswordKosong_ValidationMessageTampil()
		{
			var cut = _contex.RenderComponent<RcpLogin>(par => par.Add(p => p.uimLogin, new uimLogin() { UserName = "AUTO", Password = "" }));
			var timeOut = TimeSpan.FromSeconds(30);
			cut.WaitForState(() => cut.Markup.Contains("form"), timeOut);
			//var txbUsername = cut.Find("input[name=TxbUsername]");
			//var txbPassword = cut.Find("input[name=TxbPassword]");
			var editForm = cut.Find("form");

			// Act
			editForm.Submit();
			cut.WaitForState(() => cut.Markup.Contains("Password tidak boleh kosong"), TimeSpan.FromSeconds(30));

			var validasiPasswordKosong = cut.Find("div[class=validation-message]");

			//// Assert
			Assert.Equal("Password tidak boleh kosong", validasiPasswordKosong.TextContent);
		}

		[Fact]
		public void RcpLogin_3_PasswordSalah_PasswordSalahTampil()
		{
			var cut = _contex.RenderComponent<RcpLogin>(par => par.Add(p => p.uimLogin, new uimLogin() { UserName = "AUTO", Password = "p" }));
			var timeOut = TimeSpan.FromSeconds(30);
			cut.WaitForState(() => cut.Markup.Contains("form"), timeOut);
			//var txbUsername = cut.Find("input[name=TxbUsername]");
			//var txbPassword = cut.Find("input[name=TxbPassword]");
			var btnLogin = cut.FindAll("button")[2];

			// Act
			btnLogin.Click();
			cut.WaitForState(() => cut.Instance.TextValidasiPassword == "Password yang anda masukkan salah", timeOut);

			//// Assert
			Assert.Equal("Password yang anda masukkan salah", cut.Instance.TextValidasiPassword);
		}
		[Fact]
		public void RcpLogin_4_LoginSukses()
		{
			var timer = TimeSpan.FromSeconds(30);
			// Act
			var cut = _contex.RenderComponent<RcpLogin>(par => par.Add(p => p.uimLogin, new uimLogin() { UserName = "AUTO", Password = "Partnersh1p" }));
			cut.Instance.IsUITest = true;
			var timeOut = TimeSpan.FromSeconds(30);
			cut.WaitForState(() => cut.Markup.Contains("dxbl-form-layout-item"), timeOut);
			var txbUsername = cut.FindAll("input")[0];
			var txbPassword = cut.FindAll("input")[1];
			var btnLogin = cut.FindAll("button")[2];

			// Act
			//txbUsername.Input("AUTO");
			//txbPassword.Input("Partnersh1p");
			btnLogin.Click();
			//await Task.Delay(3000);
			cut.WaitForState(() => cut.Instance.TextValidasiPassword == "Login Sukses", timeOut);

			//// Assert
			Assert.Equal("Login Sukses", cut.Instance.TextValidasiPassword);
		}
		public void Dispose()
		{
			_contex.Dispose();
		}
	}
}
