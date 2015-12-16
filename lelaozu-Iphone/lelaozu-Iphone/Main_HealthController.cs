

using System;

using UIKit;
using CoreGraphics;

namespace lelaozuIphone
{
	public partial class Main_HealthController : UIViewController
	{
		private MyHealthViewController _myHealthViewController;
		private OtherHealthViewController _otherHealthViewController;
		private UIViewController _currentViewController;
		public Main_HealthController () : base ("Main_HealthController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "体检信息";
			_myHealthViewController = new MyHealthViewController ();
			_otherHealthViewController = new OtherHealthViewController ();
			AddChildViewController (_myHealthViewController);
			AddChildViewController (_otherHealthViewController);
			_myHealthViewController.DidMoveToParentViewController (this);
			healthView.Layer.MasksToBounds = true;
			healthView.AddSubview (_myHealthViewController.View);
			_currentViewController = _myHealthViewController;
			InitView ();

		 
			 
		}

		private void InitView()
		{
			health_Segment.SelectedSegment = 0;
			health_Segment.ControlStyle = UISegmentedControlStyle.Bordered;
		    
		
			health_Segment.ValueChanged += (object sender, EventArgs e) => 
			{
				_currentViewController.View.RemoveFromSuperview();
				switch(health_Segment.SelectedSegment)
				{
				case 0:
					_currentViewController = _myHealthViewController;
					break;
				case 1:
					_currentViewController = _otherHealthViewController;
					break;
				}
				healthView.AddSubview(_currentViewController.View);

//				switch(health_Segment.SelectedSegment)
//				{
//				case 0:
//					ReplaceController(_currentViewController,_myHealthViewController);
//					break;
//				case 1:
//					ReplaceController(_currentViewController,_otherHealthViewController);
//					break;
//				}


			};

		}

		private void ReplaceController(UIViewController oldViewController,UIViewController newViewController)
		{
			AddChildViewController(newViewController);

			Transition (oldViewController, newViewController, 1000, UIViewAnimationOptions.CurveEaseIn, ()=>
				{
					
				}, (finished) => {
				if(finished)
				{
				    _currentViewController.View.RemoveFromSuperview();
					healthView.AddSubview(newViewController.View);
					newViewController.DidMoveToParentViewController(this);
					oldViewController.WillMoveToParentViewController(null);
					oldViewController.RemoveFromParentViewController();
					_currentViewController = newViewController;
				}
				else
					_currentViewController = oldViewController;
			});


		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.

		}

//		partial void Btn_go_TouchUpInside (UIButton sender)
//		{
////			var _healthDetailViewController = new HealthDetailViewController();
////			_healthDetailViewController.HidesBottomBarWhenPushed = true;
////			this.NavigationController.PushViewController(_healthDetailViewController,true);
//
//			var showlbl = new UILabel(new CGRect((Constants.Screen_Width-160)/2,Constants.Screen_Height-120,160,50));
//			showlbl.Text ="login sucess";
//			showlbl.TextAlignment = UITextAlignment.Center;
//			showlbl.BackgroundColor = UIColor.LightGray;
//			showlbl.Alpha = 0;
//			this.View.AddSubview(showlbl);
//			UIView.Animate(2,()=>
//				{
//					showlbl.Alpha =1;
//				},()=>
//				{
//					showlbl.RemoveFromSuperview();
//				});
//
//		}

//		partial void Btn_add_TouchUpInside (UIButton sender)
//		{
//			var tesc = new test();
//			tesc.HidesBottomBarWhenPushed = true;
//			this.NavigationController.PushViewController(tesc,true);
//		}
	}
}


