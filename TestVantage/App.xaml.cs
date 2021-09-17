using System;
using TestVantage.Services;
using TestVantage.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestVantage
	{
	public partial class App : Application
		{
		public static long TimeoutLength { get; private set; }
		public static long LastActive;
		public static Boolean LoggedIn;

		public App()
			{
			InitializeComponent();

			TimeoutLength = 2000000000;

			DependencyService.Register<MockDataStore>();
			MainPage = new AppShell();
			}

		protected override void OnStart()
			{
			}

		protected override void OnSleep()
			{
			if (LoggedIn)
				LastActive = DateTime.UtcNow.Ticks;
			}

		protected async override void OnResume()
			{
			var Ticks = DateTime.UtcNow.Ticks - LastActive;
			if ( Ticks > 0 && Ticks < TimeoutLength)
				{
				LoggedIn = true;
				await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
				}
			else
				{
				LoggedIn = false;
				await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
				}

			}
		}
	}
