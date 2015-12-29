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
	[Register ("SettingTableViewCell")]
	partial class SettingTableViewCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView img_sign { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_title { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_titleValue { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (img_sign != null) {
				img_sign.Dispose ();
				img_sign = null;
			}
			if (lbl_title != null) {
				lbl_title.Dispose ();
				lbl_title = null;
			}
			if (lbl_titleValue != null) {
				lbl_titleValue.Dispose ();
				lbl_titleValue = null;
			}
		}
	}
}
