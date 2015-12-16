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
	[Register ("GuardianListCell")]
	partial class GuardianListCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_action { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView img_head { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView img_sex { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_location { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_name { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_phoneNumber { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btn_action != null) {
				btn_action.Dispose ();
				btn_action = null;
			}
			if (img_head != null) {
				img_head.Dispose ();
				img_head = null;
			}
			if (img_sex != null) {
				img_sex.Dispose ();
				img_sex = null;
			}
			if (lbl_location != null) {
				lbl_location.Dispose ();
				lbl_location = null;
			}
			if (lbl_name != null) {
				lbl_name.Dispose ();
				lbl_name = null;
			}
			if (lbl_phoneNumber != null) {
				lbl_phoneNumber.Dispose ();
				lbl_phoneNumber = null;
			}
		}
	}
}
