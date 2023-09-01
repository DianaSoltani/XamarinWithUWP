using XamarinWithUWP.UWP.Services;
using XamarinWithUWP.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;

namespace XamarinWithUWP;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

		builder
			.UseSharedMauiApp();

		builder.Services.AddTransient<IPlatformSpecificService, WinUIService>();

		return builder.Build();
	}
}
