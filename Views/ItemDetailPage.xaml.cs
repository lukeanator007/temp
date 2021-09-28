using System.ComponentModel;
using TestVantage.ViewModels;
using Xamarin.Forms;

namespace TestVantage.Views
	{
	public partial class ItemDetailPage : ContentPage
		{
		public ItemDetailPage()
			{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
			}
		}
	}