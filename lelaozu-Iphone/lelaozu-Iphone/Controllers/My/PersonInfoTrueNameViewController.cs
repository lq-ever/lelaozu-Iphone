using System;

using UIKit;

namespace lelaozuIphone
{
	public partial class PersonInfoTrueNameViewController : UIViewController
	{
		public PersonInfoTrueNameViewController () : base ("PersonInfoTrueNameViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title ="真实姓名";
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


