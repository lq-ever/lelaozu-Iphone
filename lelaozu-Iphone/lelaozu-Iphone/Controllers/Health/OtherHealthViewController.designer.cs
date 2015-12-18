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
	[Register ("OtherHealthViewController")]
	partial class OtherHealthViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_Search { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tableView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_healthTime { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_MyUser { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btn_Search != null) {
				btn_Search.Dispose ();
				btn_Search = null;
			}
			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}
			if (txt_healthTime != null) {
				txt_healthTime.Dispose ();
				txt_healthTime = null;
			}
			if (txt_MyUser != null) {
				txt_MyUser.Dispose ();
				txt_MyUser = null;
			}
		}
	}
}
