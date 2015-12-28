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
			this.NavigationController.NavigationBarHidden = true;
			//初始化控件
			scrollView = new UIScrollView(Constants.Screen_Frame);
			scrollView.PagingEnabled = true;
			scrollView.Bounces = true;
			scrollView.ScrollEnabled = true;
			scrollView.ShowsVerticalScrollIndicator = false;
			scrollView.ShowsHorizontalScrollIndicator = false;
			this.View.AddSubview (scrollView);
			//pagecontrol
			pageControl = new UIPageControl (new CGRect (0,Constants.Screen_Height-30,Constants.Screen_Width,10));
			pageControl.CurrentPageIndicatorTintColor = new UIColor (new nfloat(0.153), new nfloat(0.533),new nfloat(0.976), new nfloat(1.0));

			pageControl.Pages = 4;//4-pages
			this.View.AddSubview (pageControl);
			// 创建imageview
			CreateImageView ();

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
				imageview.AddGestureRecognizer(new UIGestureRecognizer(()=>
					{
						var cgPoint = new CGPoint(this.View.Bounds.Size.Width*(i+1),0);
						scrollView.SetContentOffset(cgPoint,true);
						pageControl.CurrentPage = i+1;

					}));
				//last page add btn_start
				if (i == 3) {
					var btn_Start = new UIButton (UIButtonType.Custom);
					btn_Start.SetTitle ("立即使用", UIControlState.Normal);
					btn_Start.SetTitleColor (UIColor.DarkGray,UIControlState.Normal);
					btn_Start.Frame = new CGRect ((Constants.Screen_Width-250)/2,Constants.Screen_Height-100,250,50);
					btn_Start.TouchUpInside += (sender, e) => 
					{
						//write currentversioncode 
						NSUserDefaults.StandardUserDefaults.SetString(Constants.CurrentVersionCode,Constants.LastVersionStr);
						//this.NavigationController.PushViewController(new LoginViewController(),true);
						PresentViewController(new UINavigationController(new LoginViewController()),true,null);
					};
					imageview.AddSubview(btn_Start);
				}
				scrollView.AddSubview (imageview);

			}
			scrollView.ContentSize = new CGSize (Constants.Screen_Width * 4, Constants.Screen_Height); 

		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}
	}
}


