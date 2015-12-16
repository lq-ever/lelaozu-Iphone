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
	[Register ("Main_HealthController")]
	partial class Main_HealthController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISegmentedControl health_Segment { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView healthView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (health_Segment != null) {
				health_Segment.Dispose ();
				health_Segment = null;
			}
			if (healthView != null) {
				healthView.Dispose ();
				healthView = null;
			}
		}
	}
}
