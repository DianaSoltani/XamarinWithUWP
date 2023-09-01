using XamarinWithUWP.Services;

namespace XamarinWithUWP.UWP.Services;

public class WinUIService : IPlatformSpecificService
{
	public WinUIService()
	{
	}

	public string GetPlatformDescription()
	{
		return "WinUI";
	}
}
