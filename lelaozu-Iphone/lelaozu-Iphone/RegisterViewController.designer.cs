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
	[Register ("RegisterViewController")]
	partial class RegisterViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_next { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_linkAgree { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIScrollView scrollView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_phoneNum { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_registerConfirmPwd { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_registerPwd { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_registerUserName { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btn_next != null) {
				btn_next.Dispose ();
				btn_next = null;
			}
			if (lbl_linkAgree != null) {
				lbl_linkAgree.Dispose ();
				lbl_linkAgree = null;
			}
			if (scrollView != null) {
				scrollView.Dispose ();
				scrollView = null;
			}
			if (txt_phoneNum != null) {
				txt_phoneNum.Dispose ();
				txt_phoneNum = null;
			}
			if (txt_registerConfirmPwd != null) {
				txt_registerConfirmPwd.Dispose ();
				txt_registerConfirmPwd = null;
			}
			if (txt_registerPwd != null) {
				txt_registerPwd.Dispose ();
				txt_registerPwd = null;
			}
			if (txt_registerUserName != null) {
				txt_registerUserName.Dispose ();
				txt_registerUserName = null;
			}
		}
	}
}
