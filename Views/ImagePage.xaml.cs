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
	public partial class ImagePage : ContentPage
		{
		public ImagePage()
			{
			InitializeComponent();
			BindingContext = new ImageView();
			}
		}
	}