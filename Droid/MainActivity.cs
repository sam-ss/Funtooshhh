﻿using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial
{
	[Activity (
		Label = "TOMTRA",
		Theme = "@style/AppTheme",
		Icon="@drawable/icon",
        ScreenOrientation = ScreenOrientation.Portrait,
        MainLauncher = false)
	]
	public class MainActivity : FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			FormsAppCompatActivity.ToolbarResource = Resource.Layout.Toolbar;
			FormsAppCompatActivity.TabLayoutResource = Resource.Layout.Tabs;
            new Syncfusion.SfChart.XForms.Droid.SfChartRenderer();            
            LoadApplication (new App ());
		}

	}
}

