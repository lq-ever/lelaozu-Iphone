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
	[Register ("AlarmHandleCell")]
	partial class AlarmHandleCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_handleContent { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_handleRemark { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_handleTime { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lbl_handleContent != null) {
				lbl_handleContent.Dispose ();
				lbl_handleContent = null;
			}
			if (lbl_handleRemark != null) {
				lbl_handleRemark.Dispose ();
				lbl_handleRemark = null;
			}
			if (lbl_handleTime != null) {
				lbl_handleTime.Dispose ();
				lbl_handleTime = null;
			}
		}
	}
}
