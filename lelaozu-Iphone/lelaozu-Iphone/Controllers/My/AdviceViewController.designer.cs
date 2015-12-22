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
	[Register ("AdviceViewController")]
	partial class AdviceViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISegmentedControl adviceSegment { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView adviceView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (adviceSegment != null) {
				adviceSegment.Dispose ();
				adviceSegment = null;
			}
			if (adviceView != null) {
				adviceView.Dispose ();
				adviceView = null;
			}
		}
	}
}
