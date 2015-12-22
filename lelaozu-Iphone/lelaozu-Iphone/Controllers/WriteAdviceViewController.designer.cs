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
	[Register ("WriteAdviceViewController")]
	partial class WriteAdviceViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_publish { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIScrollView scrollView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView txt_adviceContent { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_adviceTitle { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txt_adviceType { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btn_publish != null) {
				btn_publish.Dispose ();
				btn_publish = null;
			}
			if (scrollView != null) {
				scrollView.Dispose ();
				scrollView = null;
			}
			if (txt_adviceContent != null) {
				txt_adviceContent.Dispose ();
				txt_adviceContent = null;
			}
			if (txt_adviceTitle != null) {
				txt_adviceTitle.Dispose ();
				txt_adviceTitle = null;
			}
			if (txt_adviceType != null) {
				txt_adviceType.Dispose ();
				txt_adviceType = null;
			}
		}
	}
}
