using System;
using Microsoft.Maui.Controls.Xaml;
using XamarinWithUWP.Services;
using XamarinWithUWP.Views;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace XamarinWithUWP
{
	public partial class App : Application
	{

		public App()
		{
			InitializeComponent();

			DependencyService.Register<MockDataStore>();
			MainPage = new AppShell();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
