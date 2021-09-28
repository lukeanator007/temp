using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TestVantage.Views
	{
	public abstract class LoggedInContentPage : ContentPage
		{

		protected async override void OnAppearing()
			{
			if (!App.LoggedIn) 
				{
				await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
				}

			base.OnAppearing();
			}
		}
	}
