using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace XamarinWithUWP.Droid
{
    [Activity(Label = "XamarinWithUWP", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : Microsoft.Maui.MauiAppCompatActivity
    {

    }
}