using System;

using UIKit;

namespace lelaozuIphone
{
	/// <summary>
	/// Alarm location view controller.警报百度地图查看
	/// </summary>
	public partial class AlarmLocationViewController : UIViewController
	{
		public string AlarmPosition;
		public AlarmLocationViewController () : base ("AlarmLocationViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


