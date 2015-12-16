using System;

using UIKit;

namespace lelaozuIphone
{
	public partial class PersonInfoGenderViewController : UIViewController
	{
		public PersonInfoGenderViewController () : base ("PersonInfoGenderViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "性别";
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


