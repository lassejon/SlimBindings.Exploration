using System;
using Foundation;

namespace MWPhotoBrowserBinding
{
	// @interface MWPhotoBrowser : NSObject
	[BaseType(typeof(NSObject))]
	interface MWPhotoBrowser
	{
		[Static]
		[Export("itemCount")]
		nint ItemCount();
	}
}
