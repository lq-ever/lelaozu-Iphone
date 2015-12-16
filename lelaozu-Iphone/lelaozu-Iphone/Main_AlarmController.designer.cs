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
	[Register ("Main_AlarmController")]
	partial class Main_AlarmController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISegmentedControl alarm_Segment { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView alarmView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (alarm_Segment != null) {
				alarm_Segment.Dispose ();
				alarm_Segment = null;
			}
			if (alarmView != null) {
				alarmView.Dispose ();
				alarmView = null;
			}
		}
	}
}
