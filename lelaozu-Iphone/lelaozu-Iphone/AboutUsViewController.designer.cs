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
	[Register ("AboutUsViewController")]
	partial class AboutUsViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_appVersion { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIScrollView scrollView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lbl_appVersion != null) {
				lbl_appVersion.Dispose ();
				lbl_appVersion = null;
			}
			if (scrollView != null) {
				scrollView.Dispose ();
				scrollView = null;
			}
		}
	}
}
