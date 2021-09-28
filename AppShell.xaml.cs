using System;
using System.Collections.Generic;
using TestVantage.ViewModels;
using TestVantage.Views;
using Xamarin.Forms;

namespace TestVantage
	{
	public partial class AppShell : Xamarin.Forms.Shell
		{
		public AppShell()
			{
			InitializeComponent();
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
			}

		private async void OnLogoutClicked(object sender, EventArgs e)
			{
			await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
			}

		private async void OnBaconItemClicked(object sender, EventArgs e)
			{
			await Shell.Current.GoToAsync($"//{nameof(ImagePage)}");
			}
		}
	}
