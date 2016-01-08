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
			this.NavigationController.NavigationBar.BarTintColor = Color.Blue;
			this.NavigationController.NavigationBar.Translucent = false;
			this.NavigationController.NavigationBar.TintColor = UIColor.White;
			var titleAttributs = new UIStringAttributes ();
			titleAttributs.ForegroundColor = UIColor.White;
			titleAttributs.Font = UIFont.SystemFontOfSize(20f);
			this.NavigationController.NavigationBar.TitleTextAttributes = titleAttributs;

			var rightBarButtonItem = new UIBarButtonItem ("绑定", UIBarButtonItemStyle.Done, (sender,e) => {
				var bindGuardianController = new BindGuardianViewController(){HidesBottomBarWhenPushed = true};	
				this.NavigationController.PushViewController(bindGuardianController,true);
			});

			var leftBarButtonItem = new UIBarButtonItem ("申请处理", UIBarButtonItemStyle.Bordered, (sender, e) => {
				var guardianApplyController = new GuardianApplyViewController();
				this.NavigationController.PushViewController(guardianApplyController,true);
			});
		
			this.NavigationItem.RightBarButtonItem = rightBarButtonItem;
			this.NavigationItem.LeftBarButtonItem = leftBarButtonItem;

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
			
			guardian_Segment.ControlStyle = UISegmentedControlStyle.Bordered;

			guardian_Segment.Frame = new CoreGraphics.CGRect (5, 5, Constants.Screen_Frame.Width - 10, 60);
			guardian_Segment.SelectedSegment = 0;
			guardian_Segment.TintColor = Color.Blue;

			var textselectAttributes = new UITextAttributes ();
			textselectAttributes.TextColor = UIColor.White;
			var textNomarlAttributes = new UITextAttributes ();
			textNomarlAttributes.TextColor = Color.EditGray;
			guardian_Segment.SetTitleTextAttributes (textselectAttributes, UIControlState.Selected);
			guardian_Segment.SetTitleTextAttributes (textNomarlAttributes, UIControlState.Normal);
		
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


