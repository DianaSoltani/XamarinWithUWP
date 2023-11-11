using System;
using System.Collections.Generic;
using XamarinWithUWP.ViewModels;
using XamarinWithUWP.Views;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace XamarinWithUWP
{
	public partial class AppShell : Microsoft.Maui.Controls.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
		}

	}
}
