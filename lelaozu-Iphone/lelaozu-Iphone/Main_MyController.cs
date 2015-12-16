using System;

using UIKit;
using System.Collections.Generic;
using CoreGraphics;

namespace lelaozuIphone
{
	public partial class Main_MyController : UIViewController
	{
		public List<MainMyItem> sectionOneList = new List<MainMyItem>();
		public List<MainMyItem> sectionTwoList = new List<MainMyItem>() ;
		public Main_MyController () : base ("Main_MyController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.NavigationItem.Title = "我的";
			// Perform any additional setup after loading the view, typically from a nib.
			sectionOneList.Add (new MainMyItem(){  ImagPath="ic_myInfomation_personalData",Title="个人资料",FuncType = FuncType.PersonInfo});
			sectionOneList.Add (new MainMyItem (){ ImagPath="ic_myInfomation_accountSecurity",Title ="账户安全",FuncType = FuncType.AccountSecurity});
			sectionTwoList.Add (new MainMyItem (){ ImagPath ="ic_myInfomation_advice",Title="投诉建议",FuncType = FuncType.Advice});

			tableView.Source = new mainMySource (this);
			scrollview.ContentSize = new CGSize (Constants.Screen_Width,scrollview.Frame.Height+20);
			scrollview.SetContentOffset(new CGPoint(0,0),true);

		}
	
		private void InitView()
		{
			
		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
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


