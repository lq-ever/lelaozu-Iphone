using System;

using UIKit;

namespace lelaozuIphone
{
	public partial class Main_GuardianController : UIViewController
	{
		private MyGuardianViewController _myGuardianViewController;
		private OtherGuardianViewController _otherGuardianViewController;
		private UIViewController _currentViewController;
		public Main_GuardianController () : base ("Main_GuardianController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title="监护人";
			var rightBarButtonItem = new UIBarButtonItem ("add", UIBarButtonItemStyle.Done, (sender,e) => {
				
			});
			this.NavigationItem.RightBarButtonItem = rightBarButtonItem;
			_myGuardianViewController = new MyGuardianViewController ();
			_otherGuardianViewController = new OtherGuardianViewController ();

			AddChildViewController (_myGuardianViewController);
			AddChildViewController (_otherGuardianViewController);

			_myGuardianViewController.DidMoveToParentViewController (this);
			guardianView.Layer.MasksToBounds = true;
			guardianView.AddSubview (_myGuardianViewController.View);
			_currentViewController = _myGuardianViewController;
			InitView ();
		}
		private void InitView()
		{
			guardian_Segment.SelectedSegment = 0;
			guardian_Segment.ControlStyle = UISegmentedControlStyle.Bordered;


			guardian_Segment.ValueChanged += (object sender, EventArgs e) => 
			{
				_currentViewController.View.RemoveFromSuperview();
				switch(guardian_Segment.SelectedSegment)
				{
				case 0:
					_currentViewController = _myGuardianViewController;
					break;
				case 1:
					_currentViewController = _otherGuardianViewController;
					break;
				}
				guardianView.AddSubview(_currentViewController.View);

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
						guardianView.AddSubview(newViewController.View);
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


