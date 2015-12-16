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
	[Register ("Main_GuardianController")]
	partial class Main_GuardianController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISegmentedControl guardian_Segment { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView guardianView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (guardian_Segment != null) {
				guardian_Segment.Dispose ();
				guardian_Segment = null;
			}
			if (guardianView != null) {
				guardianView.Dispose ();
				guardianView = null;
			}
		}
	}
}
