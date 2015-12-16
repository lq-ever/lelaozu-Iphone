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
	[Register ("PersonInfoTableViewCell")]
	partial class PersonInfoTableViewCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_title { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_titleValue { get; set; }

		void ReleaseDesignerOutlets ()
		{
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
