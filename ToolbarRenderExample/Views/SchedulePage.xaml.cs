using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ToolbarRenderExample
{
	public partial class SchedulePage : ContentPage
	{
		public SchedulePage ()
		{
			InitializeComponent ();

		}

		private void OnButtonClick (object sender, EventArgs args)
		{
			Navigation.PushAsync(new FoodPage());
		}
	}
}

