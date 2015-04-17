using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.App;
using System.ComponentModel;
using Android.Graphics.Drawables;
using Android.Views;
using Android.Widget;


[assembly: ExportRenderer(typeof(ToolbarRenderExample.Controls.MyTabbedPage), typeof(ToolbarRenderExample.Droid.CustomTabRenderer))]
namespace ToolbarRenderExample.Droid
{
	public class CustomTabRenderer: TabbedRenderer
	{

			private Activity activity;
			private const string COLOR = "#FFFFFF";
			private const string TEXTCOLOR = "#000000";
			//This flag is used in the case when the app is not completely closed, and the user return back.


			protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
			{
				base.OnElementPropertyChanged(sender, e);
				activity = this.Context as Activity;

				ActionBar actionBar = activity.ActionBar;

				ColorDrawable colorDrawable = new ColorDrawable(global::Android.Graphics.Color.ParseColor(COLOR));
				actionBar.SetStackedBackgroundDrawable(colorDrawable);
				if (actionBar.TabCount > 0) {
					ActionBarTabsSetup (actionBar);
				}


			}

			protected override void OnVisibilityChanged (Android.Views.View changedView, ViewStates visibility)
			{
				base.OnVisibilityChanged (changedView, visibility);
				ActionBar actionBar = activity.ActionBar;
				ActionBarTabsSetup (actionBar);
			}
			private void ActionBarTabsSetup(ActionBar actionBar)
			{
				Android.App.ActionBar.Tab avatar = actionBar.GetTabAt(0);
				if (TabIsEmpty (avatar)) {
					//avatar.SetIcon (Resource.Drawable.nav_statss);

				     TabSetup(avatar, Resource.Drawable.icon);
				}

				Android.App.ActionBar.Tab contacts = actionBar.GetTabAt(1);
				if (TabIsEmpty (contacts)) {
					//contacts.SetIcon (Resource.Drawable.nav_notification);
					//contacts.SetText ("Notifications");
				      TabSetup(contacts, Resource.Drawable.icon);
					//actionBar.SelectTab (contacts);

				}
			/*
				Android.App.ActionBar.Tab favorites = actionBar.GetTabAt(2);
				if (TabIsEmpty(favorites))
					favorites.SetIcon (Resource.Drawable.nav_images);


				Android.App.ActionBar.Tab callsLog = actionBar.GetTabAt(3);
				if (TabIsEmpty(callsLog))
					callsLog.SetIcon (Resource.Drawable.search_default);
				//TabSetup(callsLog, Resource.Drawable.avatar);
				//	callsLog.SetText ("Upload");

				Android.App.ActionBar.Tab test = actionBar.GetTabAt(4);
				if (TabIsEmpty(test))
					test.SetIcon (Resource.Drawable.nav_account);
				//TabSetup(callsLog, Resource.Drawable.avatar);
				//    test.SetText ("Account");*/

			}

			private bool TabIsEmpty(ActionBar.Tab tab)
			{
				if (tab != null)
				if (tab.CustomView == null)
					return true;
				return false;
			}

			private void TabSetup(ActionBar.Tab tab, int resourceID)
			{
				ImageView iv = new ImageView(activity);
				iv.SetImageResource(resourceID);
				//iv.SetPadding(-50, 10, -50, 20);
				iv.SetPadding(-35, 8, -35, 16);
				iv.SetMinimumWidth (20);
				tab.SetCustomView(iv);
			}

	}
}

