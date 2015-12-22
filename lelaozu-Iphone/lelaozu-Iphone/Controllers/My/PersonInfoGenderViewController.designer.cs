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
	[Register ("PersonInfoGenderViewController")]
	partial class PersonInfoGenderViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_save { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_gender { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btn_save != null) {
				btn_save.Dispose ();
				btn_save = null;
			}
			if (txt_gender != null) {
				txt_gender.Dispose ();
				txt_gender = null;
			}
		}
	}
}
