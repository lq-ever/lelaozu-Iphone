

using System;

using UIKit;
using CoreGraphics;

namespace lelaozuIphone
{
	public partial class Main_HealthController : UIViewController
	{
		private MyHealthViewController _myHealthViewController;
		private OtherHealthViewController _otherHealthViewController;
		public UIViewController _currentViewController;
		public Main_HealthController () : base ("Main_HealthController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "体检信息";
			this.NavigationController.NavigationBar.BarTintColor = Color.Blue;
			this.NavigationController.NavigationBar.Translucent = false;
			this.NavigationController.NavigationBar.TintColor = UIColor.White;
			var titleAttributs = new UIStringAttributes ();
			titleAttributs.ForegroundColor = UIColor.White;
			titleAttributs.Font = UIFont.SystemFontOfSize(20f);
			this.NavigationController.NavigationBar.TitleTextAttributes = titleAttributs;

	

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

			health_Segment.ControlStyle = UISegmentedControlStyle.Bordered;
			//health_Segment.Frame = new CoreGraphics.CGRect (5, 5, Constants.Screen_Frame.Width - 10, 60);
			health_Segment.SelectedSegment = 0;
			health_Segment.TintColor = Color.Blue;
			var textselectAttributes = new UITextAttributes ();
			textselectAttributes.TextColor = UIColor.White;
			var textNomarlAttributes = new UITextAttributes ();
			textNomarlAttributes.TextColor = Color.EditGray;
			health_Segment.SetTitleTextAttributes (textselectAttributes, UIControlState.Selected);
			health_Segment.SetTitleTextAttributes (textNomarlAttributes, UIControlState.Normal);
		
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




	}
}


