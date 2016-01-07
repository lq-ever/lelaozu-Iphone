using System;

using UIKit;
using System.Collections.Generic;

namespace lelaozuIphone
{
	public partial class SettingViewController : UIViewController
	{
		public List<SettingItem> sectionOneList = new List<SettingItem>();
		public List<SettingItem> sectionTwoList = new List<SettingItem>() ;
		public SettingViewController () : base ("SettingViewController", null)
		{
		}
		public UITableView TableView
		{
			get {
				return tableView;
			}
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title ="设置";
			tableView.Frame = new CoreGraphics.CGRect(tableView.Frame.X, tableView.Frame.Y, tableView.Frame.Width, 160);
			tableView.Source = new SettingSource (this);

			LoadData ();
			//退出进入登录界面
			btn_exit.TouchUpInside += (sender, e) => 
			{
				var exitAlertController =  UIAlertController.Create("提示","确定要退出当前账号吗？",UIAlertControllerStyle.Alert);
				exitAlertController.AddAction(UIAlertAction.Create("确定",UIAlertActionStyle.Default,(UIAlertAction obj) =>
					{
						var loginViewController = new UINavigationController(new LoginViewController());
						this.View.Window.RootViewController = loginViewController;
						Constants.HasLogin = false;
					}));
				exitAlertController.AddAction(UIAlertAction.Create("取消",UIAlertActionStyle.Cancel,null));
				PresentViewController(exitAlertController,true,null);
			};

			btn_exit.Frame = new CoreGraphics.CGRect (btn_exit.Frame.X, btn_exit.Frame.Y, btn_exit.Frame.Width, tableView.Frame.Y + tableView.Frame.Height + 120);
			scrollView.ContentSize = new CoreGraphics.CGSize (scrollView.Frame.Width, scrollView.Frame.Height + 20);
		}
		/// <summary>
		/// Loads the data.
		/// </summary>
		private void LoadData()
		{
			//todo获取缓存大小值
			sectionOneList.Add(new SettingItem{Title="关于我们",TitleValue=string.Empty,ImagPath ="ic_myInfomation_aboutUs.png"});
			sectionOneList.Add (new SettingItem{ Title="版本检测",TitleValue = string.Empty,ImagPath="ic_myInfomation_versionDetection.png"});

			//sectionTwo
			sectionTwoList.Add(new SettingItem{Title="清除缓存",TitleValue="15MB",ImagPath="ic_myInfomation_cacheRemover.png"});
			tableView.ReloadData ();
		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
	public class  SettingSource :UITableViewSource
	{
		private SettingViewController controller;
		public SettingSource(SettingViewController _controller)
		{
			controller = _controller;
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
				return controller.sectionOneList.Count;
			else
				return controller.sectionTwoList.Count;
		}
		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			
			if (indexPath.Section == 0) {
				if (indexPath.Row ==0) {
					//关于我们
					controller.NavigationController.PushViewController(new AboutUsViewController(),true);
				} else if (indexPath.Row == 1) {
					//todo:版本检测
				}
			}

			else if(indexPath.Section ==1)
			{
				// todo:清除缓存
				controller.sectionTwoList[0].TitleValue ="0MB";
				controller.TableView.ReloadData ();
				var clearAlertController = UIAlertController.Create("提示","清除缓存成功",UIAlertControllerStyle.Alert);
				clearAlertController.AddAction (UIAlertAction.Create ("确定", UIAlertActionStyle.Default, null));
				controller.PresentViewController (clearAlertController, true, null);
					
			}
			tableView.DeselectRow (indexPath, true);

		}
		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			SettingItem item;
			if (indexPath.Section == 0) {
				item = controller.sectionOneList[indexPath.Row];
			} else {
				item = controller.sectionTwoList [indexPath.Row];	
			}
			var  cell = tableView.DequeueReusableCell (SettingTableViewCell.Key) as SettingTableViewCell ;
			if (cell == null)
				cell = SettingTableViewCell.CreateCell();
			cell.Img_Sign.Image = UIImage.FromFile (item.ImagPath);
			cell.Lbl_Title.Text = item.Title;	
			cell.Lbl_TitleVaule.Text = item.TitleValue;
			cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
			return cell;
		}
	}
	public class SettingItem
	{
		public string ImagPath {
			get;
			set;
		}
		public string Title {
			get;
			set;
		}
		public string TitleValue {
			get;
			set;
		}

	}
}


