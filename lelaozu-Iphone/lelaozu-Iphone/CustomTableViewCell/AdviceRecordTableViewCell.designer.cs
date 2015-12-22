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
	[Register ("AdviceRecordTableViewCell")]
	partial class AdviceRecordTableViewCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView img_adviceType { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_adviceContent { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_adviceTime { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_adviceTitle { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (img_adviceType != null) {
				img_adviceType.Dispose ();
				img_adviceType = null;
			}
			if (lbl_adviceContent != null) {
				lbl_adviceContent.Dispose ();
				lbl_adviceContent = null;
			}
			if (lbl_adviceTime != null) {
				lbl_adviceTime.Dispose ();
				lbl_adviceTime = null;
			}
			if (lbl_adviceTitle != null) {
				lbl_adviceTitle.Dispose ();
				lbl_adviceTitle = null;
			}
		}
	}
}
