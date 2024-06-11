using System.Reflection;
using Android.App;
using Android.OS;
using MWPhotoBrowserWrapperAndroidBinding;

namespace MWPhotoBrowserWrapper.Sample.Android;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        var x = MWPhotoBrowserSdk.GetPhotoPath(12);
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
    }
}