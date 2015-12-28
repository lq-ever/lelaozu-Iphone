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
	[Register ("SendSecurityCodeController")]
	partial class SendSecurityCodeController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_next { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_sendCode { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_customPhone { get; set; }

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
			if (btn_next != null) {
				btn_next.Dispose ();
				btn_next = null;
			}
			if (btn_sendCode != null) {
				btn_sendCode.Dispose ();
				btn_sendCode = null;
			}
			if (lbl_customPhone != null) {
				lbl_customPhone.Dispose ();
				lbl_customPhone = null;
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
