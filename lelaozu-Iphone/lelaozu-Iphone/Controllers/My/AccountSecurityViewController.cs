using System;

using UIKit;
using System.Collections.Generic;

namespace lelaozuIphone
{
	public partial class AccountSecurityViewController : UIViewController
	{
		public List<AccountSecurityItem> sectionOneList = new List<AccountSecurityItem>();
		public List<AccountSecurityItem> sectionTwoList = new List<AccountSecurityItem>() ;

		public AccountSecurityViewController () : base ("AccountSecurityViewController", null)
		{
			 
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "账户安全";

			tableView.Source = new AccountSecuritySource (this);

		}
		/// <summary>
		/// Loads the data.
		/// </summary>
		private void LoadData()
		{
			sectionOneList.Clear ();
			sectionTwoList.Clear ();

			sectionOneList.Add (new AccountSecurityItem{Title="登录密码",Desc="登录账户时需要输入的密码",TitleValue="修改", IsSkip = true, FuncType=FuncType.SendSecurity });
			var payValue = string.IsNullOrEmpty (Constants.MyInfo.PayPassword) ? "设置" : "修改";
			sectionOneList.Add (new AccountSecurityItem {Title="支付密码",Desc="支付时需要输入的密码",TitleValue=payValue, IsSkip = true, FuncType=FuncType.SendSecurity });

			//sectiontwo
			var phoneValue = string.IsNullOrEmpty (Constants.MyInfo.PhoneNumberOne) ? "绑定" : "解绑";
			sectionTwoList.Add (new AccountSecurityItem{Title="手机绑定",Desc="手机绑定可享受更多的服务",TitleValue=phoneValue, IsSkip = false });
			var identityValue = string.IsNullOrEmpty (Constants.MyInfo.IDNumber) ? "未认证" : "已认证";
			sectionTwoList.Add (new AccountSecurityItem{Title="身份认证",Desc="用于提升账号的安全和信任",TitleValue=identityValue, IsSkip = false  });
			tableView.ReloadData ();
		}
		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			LoadData();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}

	public class AccountSecuritySource:UITableViewSource
	{
		private AccountSecurityViewController vc;
		public AccountSecuritySource(AccountSecurityViewController _vc)
		{
			vc= _vc;
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
				return 15;
		}
		public override nfloat GetHeightForRow (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			return 48;
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
			AccountSecurityItem item;
			var sendType = string.Empty;
			var phoneNum = Constants.MyInfo.PhoneNumberOne;
			if (indexPath.Section == 0) {
				item = vc.sectionOneList [indexPath.Row];
				if (indexPath.Row == 0)
					sendType = "ModifyPwd";//修改密码
				else
					sendType = "ModifyPayPwd";//设置支付密码
			}
			else 
				item = vc.sectionTwoList[indexPath.Row];
			if (item.IsSkip) {
				//create targetcontroller
				var controller = FuncTypeControllerFactory.CreateFuncViewController (item.FuncType) as SendSecurityCodeController;
				controller.HidesBottomBarWhenPushed = true;
				controller.SendType = sendType;
				controller.PhoneNumber = phoneNum;
				vc.NavigationController.PushViewController (controller, true);
			}
			tableView.DeselectRow (indexPath, true);

		}
		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{

			AccountSecurityItem item;
			if (indexPath.Section == 0) {
				item = vc.sectionOneList[indexPath.Row];
			} else {
				item = vc.sectionTwoList [indexPath.Row];	
			}
			var  cell = tableView.DequeueReusableCell (AccountSecurityTableViewCell.Key) as AccountSecurityTableViewCell ;
			if (cell == null)
				cell = AccountSecurityTableViewCell.CreateCell();
			cell.Lbl_Title.Text = item.Title;
			cell.Lbl_Desc.Text = item.Desc;
			cell.Lbl_TitleValue.Text = item.TitleValue;
			if (item.IsSkip)
				cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
			else
				cell.Accessory = UITableViewCellAccessory.None;
			return cell;
		}
	}

	public class AccountSecurityItem
	{
		public string  Title {
			get;
			set;
		}
		public string Desc {
			get;
			set;
		}
		public string TitleValue {
			get;
			set;
		}
		public FuncType FuncType {
			get;
			set;
		}
		public bool IsSkip {
			get;
			set;
		}
	}
}


