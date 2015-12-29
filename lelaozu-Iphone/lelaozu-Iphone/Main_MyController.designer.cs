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
	[Register ("Main_MyController")]
	partial class Main_MyController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView img_call { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView img_head { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView img_setting { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_customPhone { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_nickName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_phoneNumber { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIScrollView scrollview { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tableView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (img_call != null) {
				img_call.Dispose ();
				img_call = null;
			}
			if (img_head != null) {
				img_head.Dispose ();
				img_head = null;
			}
			if (img_setting != null) {
				img_setting.Dispose ();
				img_setting = null;
			}
			if (lbl_customPhone != null) {
				lbl_customPhone.Dispose ();
				lbl_customPhone = null;
			}
			if (lbl_nickName != null) {
				lbl_nickName.Dispose ();
				lbl_nickName = null;
			}
			if (lbl_phoneNumber != null) {
				lbl_phoneNumber.Dispose ();
				lbl_phoneNumber = null;
			}
			if (scrollview != null) {
				scrollview.Dispose ();
				scrollview = null;
			}
			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}
		}
	}
}
