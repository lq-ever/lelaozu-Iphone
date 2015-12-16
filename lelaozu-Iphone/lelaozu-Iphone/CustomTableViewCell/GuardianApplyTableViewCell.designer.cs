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
	[Register ("GuardianApplyTableViewCell")]
	partial class GuardianApplyTableViewCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_agree { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_disagree { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView img_head { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView img_sex { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_applyContent { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_bindStatus { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_name { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_phoneNumber { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btn_agree != null) {
				btn_agree.Dispose ();
				btn_agree = null;
			}
			if (btn_disagree != null) {
				btn_disagree.Dispose ();
				btn_disagree = null;
			}
			if (img_head != null) {
				img_head.Dispose ();
				img_head = null;
			}
			if (img_sex != null) {
				img_sex.Dispose ();
				img_sex = null;
			}
			if (lbl_applyContent != null) {
				lbl_applyContent.Dispose ();
				lbl_applyContent = null;
			}
			if (lbl_bindStatus != null) {
				lbl_bindStatus.Dispose ();
				lbl_bindStatus = null;
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
