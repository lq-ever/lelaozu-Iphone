using System;

using UIKit;

namespace lelaozuIphone
{
	public partial class AdviceViewController : UIViewController
	{
		private WriteAdviceViewController writeAdviceController;
		private AdviceRecordViewController adviceRecordController;
		private UIViewController _currentController;
		public AdviceViewController () : base ("AdviceViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "投诉建议";

			writeAdviceController = new WriteAdviceViewController ();
			adviceRecordController = new AdviceRecordViewController ();

			AddChildViewController (writeAdviceController);
			AddChildViewController (adviceRecordController);
			writeAdviceController.DidMoveToParentViewController (this);
			adviceView.Layer.MasksToBounds = true;
			adviceView.AddSubview (writeAdviceController.View);
			_currentController = writeAdviceController;
			InitView ();
		}

		private void InitView()
		{

			adviceSegment.ControlStyle = UISegmentedControlStyle.Bordered;
			adviceSegment.Frame = new CoreGraphics.CGRect (5, 5, Constants.Screen_Frame.Width - 10, 60);
			adviceSegment.SelectedSegment = 0;
			adviceSegment.TintColor = Color.Blue;

			var textselectAttributes = new UITextAttributes ();
			textselectAttributes.TextColor = UIColor.White;
			var textNomarlAttributes = new UITextAttributes ();
			textNomarlAttributes.TextColor = Color.EditGray;
			adviceSegment.SetTitleTextAttributes (textselectAttributes, UIControlState.Selected);
			adviceSegment.SetTitleTextAttributes (textNomarlAttributes, UIControlState.Normal);

			adviceSegment.ValueChanged += (object sender, EventArgs e) => 
			{
				_currentController.View.RemoveFromSuperview();
				switch(adviceSegment.SelectedSegment)
				{
				case 0:
					_currentController = writeAdviceController;
					break;
				case 1:
					_currentController = adviceRecordController;
					break;
				}
				adviceView.AddSubview(_currentController.View);

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
						_currentController.View.RemoveFromSuperview();
						//adviceView.AddSubview(newViewController.View);
						newViewController.DidMoveToParentViewController(this);
						oldViewController.WillMoveToParentViewController(null);
						oldViewController.RemoveFromParentViewController();
						_currentController = newViewController;
					}
					else
						_currentController = oldViewController;
				});


		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


