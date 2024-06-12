using System.Reflection;
using Android.App;
using Android.OS;
using MWPhotoBrowserWrapper.Android.Binding;

namespace MWPhotoBrowserWrapper.Sample.Android;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        var thread = new Thread(ThreadWork);
        thread.Start();
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
    }

    public static void ThreadWork()
    {
        var x = MWPhotoBrowserSdk.ItemCount;
        Console.WriteLine(x);
    }
}