using System;

using UIKit;
using System.Collections.Generic;
using CoreGraphics;
using Foundation;

namespace lelaozuIphone
{
	public partial class Main_MyController : UIViewController
	{
		public List<MainMyItem> sectionOneList = new List<MainMyItem>();
		public List<MainMyItem> sectionTwoList = new List<MainMyItem>() ;
		UIImagePickerController imagePickerController;
		public Main_MyController () : base ("Main_MyController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "我的";
			this.NavigationController.NavigationBar.BarTintColor = Color.Blue;
			this.NavigationController.NavigationBar.Translucent = false;
			this.NavigationController.NavigationBar.TintColor = UIColor.White;
			var titleAttributs = new UIStringAttributes ();
			titleAttributs.ForegroundColor = UIColor.White;
			titleAttributs.Font = UIFont.SystemFontOfSize(20f);
			this.NavigationController.NavigationBar.TitleTextAttributes = titleAttributs;

			//setting 设置
			img_setting.UserInteractionEnabled = true;
			var settingRecognizer = new UITapGestureRecognizer ((UITapGestureRecognizer obj) => {
				var settingController = new SettingViewController(){HidesBottomBarWhenPushed = true};
				this.NavigationController.PushViewController(settingController,true);
			});
			img_setting.AddGestureRecognizer (settingRecognizer);

			//点击头像 --圆角图片
			img_head.UserInteractionEnabled = true;
			var img = UIImage.FromFile ("myInfomation_headImage.png");
			img_head.Layer.Contents = img.CGImage;
			img_head.Layer.MasksToBounds = true;
			img_head.Layer.CornerRadius = img_head.Frame.Size.Width/2;
			img_head.Layer.BorderWidth = 1.0f;
			img_head.Layer.BorderColor = UIColor.White.CGColor;
			img_head.ClipsToBounds = true;

			var headRecongnizer = new UITapGestureRecognizer ((UITapGestureRecognizer recoginizer) => {
				var alertImageController = UIAlertController.Create("选择图片","",UIAlertControllerStyle.ActionSheet);
				alertImageController.AddAction(UIAlertAction.Create("从相片库",UIAlertActionStyle.Default,(UIAlertAction obj) => 
					{
						CallPhoto(UIImagePickerControllerSourceType.PhotoLibrary);
					}));
				alertImageController.AddAction(UIAlertAction.Create("拍照",UIAlertActionStyle.Default,(UIAlertAction obj) =>
					{
						CallPhoto(UIImagePickerControllerSourceType.Camera);
					}));
				alertImageController.AddAction(UIAlertAction.Create(" 取消",UIAlertActionStyle.Cancel,(UIAlertAction obj)=>
					{
						
					}));
				PresentViewController(alertImageController,true,null);
			});
			img_head.AddGestureRecognizer (headRecongnizer);

			// call the custom phone 
			img_call.UserInteractionEnabled = true;
			var callRecongnizer = new UITapGestureRecognizer((UITapGestureRecognizer obj)=>
				{
					var callUrl = new NSUrl("tel:"+lbl_customPhone.Text);
					if(!UIApplication.SharedApplication.OpenUrl(callUrl))
					{
						var callFailController = UIAlertController.Create("不支持","当前设备不支持",UIAlertControllerStyle.Alert);
						callFailController.AddAction(UIAlertAction.Create("确定",UIAlertActionStyle.Default,null));
						PresentViewController(callFailController,true,null);
					};
				});
			img_call.AddGestureRecognizer (callRecongnizer);
			//底部tableview
			sectionOneList.Add (new MainMyItem(){  ImagPath="ic_myInfomation_personalData",Title="个人资料",FuncType = FuncType.PersonInfo});
			sectionOneList.Add (new MainMyItem (){ ImagPath="ic_myInfomation_accountSecurity",Title ="账户安全",FuncType = FuncType.AccountSecurity});
			sectionTwoList.Add (new MainMyItem (){ ImagPath ="ic_myInfomation_advice",Title="投诉建议",FuncType = FuncType.Advice});

			tableView.Source = new mainMySource (this);
			scrollview.ContentSize = new CGSize (Constants.Screen_Width,scrollview.Frame.Height+20);
			scrollview.SetContentOffset(new CGPoint(0,0),true);
			//赋值
			SetShowInfo ();

		}

		/// <summary>
		/// Calls the photo.
		/// </summary>
		/// <param name="type">Type.</param>
		private void CallPhoto(UIImagePickerControllerSourceType type)
		{
			if (UIImagePickerController.IsSourceTypeAvailable (type)) {
				imagePickerController = new UIImagePickerController ();
				imagePickerController.SourceType = type;
				imagePickerController.AllowsEditing = true;
				if (PresentedViewController == null)
					PresentViewController (imagePickerController, true, null);
				imagePickerController.Delegate = new AvatarPickerDelegate (img_head);
				
			} else {
				var alertController = UIAlertController.Create("不支持","该设备不支持此操作",UIAlertControllerStyle.Alert);
				alertController.AddAction(UIAlertAction.Create("确定",UIAlertActionStyle.Default,null));
				PresentViewController(alertController,true,null);
			}
		}

		/// <summary>
		/// Sets the show info.
		/// </summary>
		private void SetShowInfo()
		{
			//设置用户昵称和手机号
			lbl_nickName.Text = string.IsNullOrEmpty(Constants.MyInfo.UserName)?"未设置昵称":Constants.MyInfo.UserName;
			var iphoneNumber = Constants.MyInfo.PhoneNumberOne;
			if (!string.IsNullOrEmpty (iphoneNumber)) {
				var midleStr = iphoneNumber.Substring (3, 4);
				var resultStr = iphoneNumber.Replace (midleStr, "****");
				lbl_phoneNumber.Text = resultStr;
			} else
				lbl_phoneNumber.Text = "未绑定手机号";

			//从Sd中找头像，转换成Bitmap
			//
			//			Bitmap bt = BitmapFactory.DecodeFile(path + "myHead.jpg");
			//			if(bt!=null){
			//
			//				img_head.SetImageBitmap (bt);
			//			}
			//			else
			//			{
			//				//调用web服务获取
			//				Global.imageLoader.DisplayImage(Global.MyInfo.HeadImgReleaseUrl,img_head,Global.Options);
			//			}
			//			//调用web服务获取
			//Global.imageLoader.DisplayImage(Global.MyInfo.HeadImgReleaseUrl,img_head,Global.Options);
		}

//		public override void ViewWillAppear (bool animated)
//		{
//			base.ViewWillAppear (animated);
//			this.NavigationController.SetNavigationBarHidden( true,true);
//
//		}
//		public override void ViewWillDisappear (bool animated)
//		{
//			base.ViewWillDisappear (animated);
//			this.NavigationController.SetNavigationBarHidden(false,true);
//		}


		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
			
	}
	class AvatarPickerDelegate:UIImagePickerControllerDelegate 
	{
		UIImageView _avatar;
		public AvatarPickerDelegate(UIImageView _imgView)
		{
			_avatar = _imgView;
		}
		public override void FinishedPickingImage (UIImagePickerController picker, UIImage image, NSDictionary editingInfo)
		{
			if (image == null)
				return;
			//更新显示图片
			_avatar.Layer.Contents = image.CGImage;
			//关闭UIImagePicker
			picker.DismissViewController(true,null);
			//todo:post the server

		}
    }

	public class  mainMySource :UITableViewSource
	{
		private Main_MyController vc;
		const string CUSTOMER_CELL ="customer_cell";
		public mainMySource(Main_MyController _vc)
		{
			vc = _vc;
		}
		public override nint NumberOfSections (UITableView tableView)
		{
			return 2;
		}
		public override nfloat GetHeightForHeader (UITableView tableView, nint section)
		{
			if (section == 0)
				return 0;
			else
				return 10;
		}
		public override nfloat GetHeightForRow (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			return 50;
		}
		public override nint RowsInSection (UITableView tableView, nint section)
		{
			if (section == 0)
				return vc.sectionOneList.Count;
			else
				return vc.sectionTwoList.Count;
		}
		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			MainMyItem item;
			if (indexPath.Section == 0)
				item = vc.sectionOneList [indexPath.Row];
			else 
				item = vc.sectionTwoList[indexPath.Row];
			//create targetcontroller
			var controller = FuncTypeControllerFactory.CreateFuncViewController(item.FuncType);
			controller.HidesBottomBarWhenPushed = true;
			vc.NavigationController.PushViewController (controller, true);
			tableView.DeselectRow (indexPath, true);

		}
		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			
			MainMyItem item;
			if (indexPath.Section == 0) {
				item = vc.sectionOneList[indexPath.Row];
			} else {
				item = vc.sectionTwoList [indexPath.Row];	
			}
			var  cell = tableView.DequeueReusableCell (MainMyTableViewCell.Key) as MainMyTableViewCell ;
			if (cell == null)
				cell = MainMyTableViewCell.CreateCell();
			cell.Img_Sign.Image = UIImage.FromFile (item.ImagPath);
			cell.Lbl_Title.Text = item.Title;	
			cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
			return cell;
		}
	}
	public class MainMyItem
	{
		public string ImagPath {
			get;
			set;
		}
		public string Title {
			get;
			set;
		}
		public FuncType FuncType {
			get;
			set;
		}
	}
}


