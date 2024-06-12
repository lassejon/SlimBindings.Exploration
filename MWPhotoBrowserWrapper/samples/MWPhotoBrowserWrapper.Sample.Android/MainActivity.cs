using System.Reflection;
using Android.App;
using Android.OS;
using MWPhotoBrowserWrapper.Library.Android;

namespace MWPhotoBrowserWrapper.Sample.Android;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        var lib = new MWPhotoLib();

        var x = lib.ItemCount();
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
    }
}