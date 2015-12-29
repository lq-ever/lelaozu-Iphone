using System;

using UIKit;

namespace lelaozuIphone
{
	public partial class AboutUsViewController : UIViewController
	{
		public AboutUsViewController () : base ("AboutUsViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "关于我们";
			lbl_appVersion.Text = "乐老族Iphone版 V"+ Constants.CurrentVersionCode;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


