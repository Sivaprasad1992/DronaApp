﻿using System;

using Xamarin.Forms;

namespace DronaApp
{
	public class CustomProperties : ContentPage
	{
		private double _appScreenHeight;
		private double _appScreenWidth;


		public double AppScreenHeight
		{
			get { return _appScreenHeight; }
			set { _appScreenHeight = value; }
		}

		public dynamic AppScreenWidth
		{
			get { return _appScreenWidth; }
			set { _appScreenWidth = value; }
		}


		public CustomProperties()
		{
			_appScreenHeight = App.ScreenHeight;
			_appScreenWidth = App.ScreenWidth;
		}
	}
}


