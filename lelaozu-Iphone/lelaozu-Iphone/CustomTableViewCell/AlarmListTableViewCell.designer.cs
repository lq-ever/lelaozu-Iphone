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
	[Register ("AlarmListTableViewCell")]
	partial class AlarmListTableViewCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_alarmContent { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_alarmStatus { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_alarmTime { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_alarmTrueName { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lbl_alarmContent != null) {
				lbl_alarmContent.Dispose ();
				lbl_alarmContent = null;
			}
			if (lbl_alarmStatus != null) {
				lbl_alarmStatus.Dispose ();
				lbl_alarmStatus = null;
			}
			if (lbl_alarmTime != null) {
				lbl_alarmTime.Dispose ();
				lbl_alarmTime = null;
			}
			if (lbl_alarmTrueName != null) {
				lbl_alarmTrueName.Dispose ();
				lbl_alarmTrueName = null;
			}
		}
	}
}
