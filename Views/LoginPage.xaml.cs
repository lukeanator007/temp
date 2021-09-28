using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestVantage.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestVantage.Views
	{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
		{
		public LoginPage()
			{
			InitializeComponent();
			this.BindingContext = new LoginViewModel();
			}

		protected override void OnAppearing()
			{
			var thing = (LoginViewModel)this.BindingContext;
			thing.Logout();

			base.OnAppearing();
			}
		}
	}