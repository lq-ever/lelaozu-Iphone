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
	[Register ("RegisterResultViewController")]
	partial class RegisterResultViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_send { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_submit { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_sendCodeStatusShow { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIScrollView scrollView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_phoneNumber { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_securityCode { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btn_send != null) {
				btn_send.Dispose ();
				btn_send = null;
			}
			if (btn_submit != null) {
				btn_submit.Dispose ();
				btn_submit = null;
			}
			if (lbl_sendCodeStatusShow != null) {
				lbl_sendCodeStatusShow.Dispose ();
				lbl_sendCodeStatusShow = null;
			}
			if (scrollView != null) {
				scrollView.Dispose ();
				scrollView = null;
			}
			if (txt_phoneNumber != null) {
				txt_phoneNumber.Dispose ();
				txt_phoneNumber = null;
			}
			if (txt_securityCode != null) {
				txt_securityCode.Dispose ();
				txt_securityCode = null;
			}
		}
	}
}
