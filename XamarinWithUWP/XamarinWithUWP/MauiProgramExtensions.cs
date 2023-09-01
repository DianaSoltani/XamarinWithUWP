using XamarinWithUWP.Views;
using Microsoft.Extensions.Logging;

namespace XamarinWithUWP;

public static class MauiProgramExtensions
{
	public static MauiAppBuilder UseSharedMauiApp(this MauiAppBuilder builder)
	{
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// app
		builder.Services.AddTransient<AppWindow, AppWindow>();
		builder.Services.AddTransient<AppShell, AppShell>();

		// pages
		builder.Services.AddTransient<AboutPage, AboutPage>();
		builder.Services.AddTransient<ItemDetailPage, ItemDetailPage>();

#if DEBUG
		//builder.Logging.AddDebug();
#endif

		return builder;
	}
}
