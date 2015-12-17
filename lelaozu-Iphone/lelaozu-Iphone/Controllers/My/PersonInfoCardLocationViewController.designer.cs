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
	[Register ("PersonInfoCardLocationViewController")]
	partial class PersonInfoCardLocationViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_save { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_idCardLocation { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btn_save != null) {
				btn_save.Dispose ();
				btn_save = null;
			}
			if (txt_idCardLocation != null) {
				txt_idCardLocation.Dispose ();
				txt_idCardLocation = null;
			}
		}
	}
}
