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
	[Register ("HealthListTableViewCell")]
	partial class HealthListTableViewCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_bloodGlucose { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_testTime { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_weight { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lbl_bloodGlucose != null) {
				lbl_bloodGlucose.Dispose ();
				lbl_bloodGlucose = null;
			}
			if (lbl_testTime != null) {
				lbl_testTime.Dispose ();
				lbl_testTime = null;
			}
			if (lbl_weight != null) {
				lbl_weight.Dispose ();
				lbl_weight = null;
			}
		}
	}
}
