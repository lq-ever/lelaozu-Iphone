using System;

using UIKit;

namespace lelaozuIphone
{
	/// <summary>
	/// Alarm location view controller.警报百度地图查看
	/// </summary>
	public partial class AlarmLocationViewController : UIViewController
	{
		private string alarmPosition;
		public string AlarmPosition {
			get {
				return alarmPosition;
			}
			set {
				alarmPosition = value;
			}
		}
		public AlarmLocationViewController () : base ("AlarmLocationViewController", null)
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "报警位置显示";
		}


		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


