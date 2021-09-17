using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TestVantage.Models
	{
	public class PictureItem
		{
		public ImageSource Source { get; set; }

		public PictureItem(String uri) 
			{
			Source = ImageSource.FromUri(new Uri(uri));
			}
		}
	}
