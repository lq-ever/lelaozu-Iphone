using System;

using UIKit;

namespace lelaozuIphone
{
	public partial class SendSecurityCodeController : UIViewController
	{
		private string sendType;
		public string SendType {
			get {
				return sendType;
			}
			set
			{
				sendType = value;
			}
		}
		private string phoneNumber;
		public string PhoneNumber
		{
			get{
				return phoneNumber;
			}
			set{
				phoneNumber = value;
			}
		}
		public SendSecurityCodeController () : base ("SendSecurityCodeController", null)
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


