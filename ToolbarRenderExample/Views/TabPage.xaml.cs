using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ToolbarRenderExample.Controls;

namespace ToolbarRenderExample
{
	public partial class TabPage : MyTabbedPage
	{
		public TabPage ()
		{
			this.Children.Add (
				new SchedulePage () {
					Title = "Schedule", 
					Icon = "icon.png" 
				});
			this.Children.Add (
				new SchedulePage () {
					Title = "Schedule2", 
					Icon = "icon.png" 
				});
			
		}
	}
}

