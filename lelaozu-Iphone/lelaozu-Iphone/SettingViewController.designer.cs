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
	[Register ("SettingViewController")]
	partial class SettingViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_exit { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIScrollView scrollView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tableView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btn_exit != null) {
				btn_exit.Dispose ();
				btn_exit = null;
			}
			if (scrollView != null) {
				scrollView.Dispose ();
				scrollView = null;
			}
			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}
		}
	}
}
