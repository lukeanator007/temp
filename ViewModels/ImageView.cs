using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using TestVantage.Models;
using Xamarin.Forms;

namespace TestVantage.ViewModels
	{
	public class ImageView : BaseViewModel
		{
		public List<PictureItem> Pictures { get; private set; }

		private ImageSource imageUri;

		public ImageSource ImageUri
			{
			get { return imageUri; }
			set { SetProperty(ref imageUri, value); }
			}

		int index = 0;
		

		public int Index
			{
			get { return index; }
			set { SetProperty(ref index, value); }
			}

		public ICommand NextBacon { get; }

		public ImageView()
			{
			Title = "some bacon";

			NextBacon = new Command(InvokeNextBacon);

			Pictures = new List<PictureItem>();
			Pictures.Add(new PictureItem("https://solidstarts.com/wp-content/uploads/Bacon-for-Babies-480x320.webp"));
			Pictures.Add(new PictureItem("https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/delish-190621-air-fryer-bacon-0035-landscape-pf-1567632709.jpg?crop=0.645xw:0.967xh;0.170xw,0.0204xh&resize=480:*"));
			Pictures.Add(new PictureItem("https://sugarspunrun.com/wp-content/uploads/2021/07/BACON-IN-THE-OVEN-8-of-8.jpg"));
			ImageUri = Pictures[0].Source;
			}

		private void InvokeNextBacon(object obj)
			{
			index++;

			if (index == Pictures.Count)
				index = 0;

			ImageUri = Pictures[index].Source;
			}
		}
	}