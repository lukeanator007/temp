using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestVantage.Models;
using TestVantage.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestVantage.Views
	{
	public partial class NewItemPage : ContentPage
		{
		public Item Item { get; set; }

		public NewItemPage()
			{
			InitializeComponent();
			BindingContext = new NewItemViewModel();
			}
		}
	}