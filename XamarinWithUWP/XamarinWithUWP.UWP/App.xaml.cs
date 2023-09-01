using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace XamarinWithUWP.UWP;

public partial class App : MauiWinUIApplication
{
	public App()
	{
		InitializeComponent();
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
