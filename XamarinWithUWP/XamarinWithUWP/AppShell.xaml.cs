using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinWithUWP.ViewModels;
using XamarinWithUWP.Views;

namespace XamarinWithUWP
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
		}

	}
}
