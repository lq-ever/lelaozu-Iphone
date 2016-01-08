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
	[Register ("OtherAlarmViewController")]
	partial class OtherAlarmViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_search { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tableView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_alarmType { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_endTime { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_MyUser { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_startTime { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btn_search != null) {
				btn_search.Dispose ();
				btn_search = null;
			}
			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}
			if (txt_alarmType != null) {
				txt_alarmType.Dispose ();
				txt_alarmType = null;
			}
			if (txt_endTime != null) {
				txt_endTime.Dispose ();
				txt_endTime = null;
			}
			if (txt_MyUser != null) {
				txt_MyUser.Dispose ();
				txt_MyUser = null;
			}
			if (txt_startTime != null) {
				txt_startTime.Dispose ();
				txt_startTime = null;
			}
		}
	}
}
