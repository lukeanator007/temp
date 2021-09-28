using System;
using System.Collections.Generic;
using System.Text;
using TestVantage.Views;
using Xamarin.Forms;

namespace TestVantage.ViewModels
	{
	public class LoginViewModel : BaseViewModel
		{
		public Command LoginCommand { get; }
		public LoginViewModel()
			{
			LoginCommand = new Command(OnLoginClicked);
			}

		private async void OnLoginClicked(object obj)
			{
			// Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
			App.LoggedIn = true;
			App.LastActive = DateTime.UtcNow.Ticks;
			await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
			}

		public async void Logout() 
			{
			App.LoggedIn = false;
			App.LastActive = 0;
			await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
			}
		}
	}
