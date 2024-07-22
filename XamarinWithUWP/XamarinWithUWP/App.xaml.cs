using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinWithUWP.Services;
using XamarinWithUWP.Views;

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
