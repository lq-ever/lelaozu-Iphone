using System;
using UIKit;
using CoreGraphics;

namespace lelaozuIphone
{
	public partial class Main_AlarmController : UIViewController
	{
		private MyAlarmViewController _myAlarmViewController;
		private OtherAlarmViewController _otherAlarmViewController;
		private UIViewController _currentViewController;
		public Main_AlarmController () : base ("Main_AlarmController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "报警信息";
			this.NavigationController.NavigationBar.BarTintColor = Color.Blue;
			this.NavigationController.NavigationBar.Translucent = false;
			this.NavigationController.NavigationBar.TintColor = UIColor.White;
			var titleAttributs = new UIStringAttributes ();
			titleAttributs.ForegroundColor = UIColor.White;
			titleAttributs.Font = UIFont.SystemFontOfSize(20f);
			this.NavigationController.NavigationBar.TitleTextAttributes = titleAttributs;

			_myAlarmViewController = new MyAlarmViewController ();
			_otherAlarmViewController = new OtherAlarmViewController ();

			AddChildViewController (_myAlarmViewController);
			AddChildViewController (_otherAlarmViewController);
			_myAlarmViewController.DidMoveToParentViewController (this);
			alarmView.Layer.MasksToBounds = true;
			alarmView.AddSubview (_myAlarmViewController.View);
			_currentViewController = _myAlarmViewController;
			InitView ();


		}

		private void InitView()
		{

			alarm_Segment.SelectedSegment = 0;
			alarm_Segment.ControlStyle = UISegmentedControlStyle.Bordered;
			alarm_Segment.ValueChanged += (object sender, EventArgs e) => 
			{
				_currentViewController.View.RemoveFromSuperview();
				switch(alarm_Segment.SelectedSegment)
				{
				case 0:
					_currentViewController = _myAlarmViewController;
					break;
				case 1:
					_currentViewController = _otherAlarmViewController;
					break;
				}
				alarmView.AddSubview(_currentViewController.View);

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
						alarmView.AddSubview(newViewController.View);
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
	}
}


