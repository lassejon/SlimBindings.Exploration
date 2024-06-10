using MWPhotoBrowserWrapper.Library.iOS;

namespace MWPhotoBrowserWrapper.Sample.iOS;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
	public override UIWindow? Window
	{
		get;
		set;
	}

	public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
	{
		// create a new window instance based on the screen size
		Window = new UIWindow(UIScreen.MainScreen.Bounds);

		var exposer = new Exposer();
		var itemCount = exposer.ExposeItemCount();

		// create a UIViewController with a single UILabel
		var vc = new UIViewController();
		vc.View!.AddSubview(new UILabel(Window!.Frame)
		{
			BackgroundColor = UIColor.SystemBackground,
			TextAlignment = UITextAlignment.Center,
			Text = $"Hello, iOS! itemCount from Exposer: {itemCount}",
			AutoresizingMask = UIViewAutoresizing.All,
		});
		Window.RootViewController = vc;

		// make the window visible
		Window.MakeKeyAndVisible();

		return true;
	}
}
