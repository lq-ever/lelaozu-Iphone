using System;

using UIKit;

namespace lelaozuIphone
{
	public partial class PersonInfoCardLocationViewController : UIViewController
	{
		public PersonInfoCardLocationViewController () : base ("PersonInfoCardLocationViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "身份证所在地";
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


