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
	[Register ("AdviceRecordViewController")]
	partial class AdviceRecordViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_recordNum { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tableView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_adviceType { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lbl_recordNum != null) {
				lbl_recordNum.Dispose ();
				lbl_recordNum = null;
			}
			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}
			if (txt_adviceType != null) {
				txt_adviceType.Dispose ();
				txt_adviceType = null;
			}
		}
	}
}
