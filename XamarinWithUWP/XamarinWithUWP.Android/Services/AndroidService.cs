using XamarinWithUWP.Services;

namespace MauiMultiHeadApp.Android.Services;

public class AndroidService : IPlatformSpecificService
{
	public AndroidService()
	{
	}

	public string GetPlatformDescription()
	{
		return "Android";
	}
}
