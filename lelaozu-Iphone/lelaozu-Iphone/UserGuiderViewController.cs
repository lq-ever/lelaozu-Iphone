using System;
using CoreGraphics;
using UIKit;
using Foundation;

namespace lelaozuIphone
{
	public partial class UserGuiderViewController : UIViewController
	{
		
		private UIScrollView scrollView;
		private UIPageControl pageControl;
		public UserGuiderViewController () : base ("UserGuiderViewController", null)
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			//初始化控件
			scrollView = new UIScrollView(Constants.Screen_Frame);
			scrollView.PagingEnabled = true;
			scrollView.Bounces = false;
			scrollView.ScrollEnabled = true;
			scrollView.ShowsVerticalScrollIndicator = false;
			scrollView.ShowsHorizontalScrollIndicator = false;
			this.View.AddSubview (scrollView);
			//pagecontrol
			pageControl = new UIPageControl (new CGRect (0,Constants.Screen_Height-30,Constants.Screen_Width,10));
			pageControl.PageIndicatorTintColor = Color.InGray;

			pageControl.CurrentPageIndicatorTintColor = Color.Blue;
			pageControl.Pages = 4;//4-pages
			this.View.AddSubview (pageControl);
			// 创建imageview
			CreateImageView ();

			//scrollview scroll
			scrollView.Scrolled += (sender, e) => 
			{
				var page = scrollView.ContentOffset.X/scrollView.Frame.Size.Width;
				pageControl.CurrentPage = (int)page;
			};


		}
		/// <summary>
		/// Creates the image view.
		/// </summary>
		private void CreateImageView()
		{
			for (var i = 0; i < 4; i++) {
				var imageview = new UIImageView (new CGRect (Constants.Screen_Width*i,0,Constants.Screen_Width,Constants.Screen_Height));
				imageview.ContentMode = UIViewContentMode.ScaleAspectFit;
				imageview.Image = UIImage.FromFile ("guider" + (i+1) + ".png");
				imageview.UserInteractionEnabled = true;
//				imageview.AddGestureRecognizer(new UIGestureRecognizer(()=>
//					{
//						var cgPoint = new CGPoint(this.View.Bounds.Size.Width*(i+1),0);
//						scrollView.SetContentOffset(cgPoint,true);
//						pageControl.CurrentPage = i+1;
//
//					}));
				//last page add btn_start
				if (i == 3) {
					var btn_Start = new UIButton (UIButtonType.Custom);
					btn_Start.SetTitle ("立即使用", UIControlState.Normal);
					btn_Start.SetTitleColor (UIColor.White,UIControlState.Normal);
					btn_Start.BackgroundColor = Color.Blue;
					btn_Start.Frame = new CGRect ((Constants.Screen_Width-250)/2,Constants.Screen_Height-100,250,40);
					btn_Start.TouchUpInside += (sender, e) => 
					{
						//write currentversioncode 
						NSUserDefaults.StandardUserDefaults.SetString(Constants.CurrentVersionCode,Constants.LastVersionStr);
						PresentViewController(new UINavigationController(new LoginViewController()),true,null);
						//this.NavigationController.PushViewController(new UINavigationController(new LoginViewController()),true);
					};
					imageview.AddSubview(btn_Start);
				}
				scrollView.AddSubview (imageview);

			}
			scrollView.ContentSize = new CGSize (Constants.Screen_Width * 4,0); //height =0 代表禁止垂直方向滚动

		}
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			this.NavigationController.SetNavigationBarHidden (true, true);
			UIApplication.SharedApplication.SetStatusBarHidden (true, false);//hide statusbar

		}
		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			this.NavigationController.SetNavigationBarHidden (false, true);
			UIApplication.SharedApplication.SetStatusBarHidden (false, false);//show statusbar
		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}
	}
}


