using MauiMultiHeadApp.Android.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;
using XamarinWithUWP.Services;

namespace XamarinWithUWP;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

		builder
			.UseSharedMauiApp();

		builder.Services.AddTransient<IPlatformSpecificService, AndroidService>();

		return builder.Build();
	}
}
