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
	[Register ("LoginViewController")]
	partial class LoginViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_Login { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_Password { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_Username { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btn_Login != null) {
				btn_Login.Dispose ();
				btn_Login = null;
			}
			if (txt_Password != null) {
				txt_Password.Dispose ();
				txt_Password = null;
			}
			if (txt_Username != null) {
				txt_Username.Dispose ();
				txt_Username = null;
			}
		}
	}
}
