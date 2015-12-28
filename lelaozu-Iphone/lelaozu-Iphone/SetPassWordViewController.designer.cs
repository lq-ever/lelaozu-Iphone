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
	[Register ("SetPassWordViewController")]
	partial class SetPassWordViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_submit { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIScrollView scrollView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_confirmPwd { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_pwd { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btn_submit != null) {
				btn_submit.Dispose ();
				btn_submit = null;
			}
			if (scrollView != null) {
				scrollView.Dispose ();
				scrollView = null;
			}
			if (txt_confirmPwd != null) {
				txt_confirmPwd.Dispose ();
				txt_confirmPwd = null;
			}
			if (txt_pwd != null) {
				txt_pwd.Dispose ();
				txt_pwd = null;
			}
		}
	}
}
