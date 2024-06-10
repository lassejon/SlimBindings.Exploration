using System;
using Foundation;

namespace OriginalNative
{
	// @interface Original : NSObject
	[BaseType(typeof(NSObject))]
	interface Original
	{
		// +(NSString * _Nonnull)mulityply __attribute__((warn_unused_result("")));
		[Static]
		[Export("mulityply")]
		// [Verify(MethodToProperty)]h
		string Mulityply();
	}
}
