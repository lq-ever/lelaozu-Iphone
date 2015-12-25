// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace lelaozuIphone
{
	[Register ("ServiceAgreeViewController")]
	partial class ServiceAgreeViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView tv_agreeService { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (tv_agreeService != null) {
				tv_agreeService.Dispose ();
				tv_agreeService = null;
			}
		}
	}
}
