using System;
using UIKit;
using System.Collections.Generic;

namespace lelaozuIphone
{
	public class PersonInfoTableSource:UITableViewSource
	{
		public PersonInfoViewController personInfoController;


		public PersonInfoTableSource (PersonInfoViewController _personInfoController)
		{
			personInfoController = _personInfoController;
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return 3;
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

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			if (section == 0)
				return personInfoController.sectionOneInfoLists.Count;
			else if (section == 1)
				return personInfoController.sectionTwoInfoLists.Count;
			else 
				return personInfoController.secitonThreeInfoLists.Count;
		}

		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			InfoItem item;
			if (indexPath.Section == 0) {
				item = personInfoController.sectionOneInfoLists[indexPath.Row];
			} else if(indexPath.Section ==1) {
				item = personInfoController.sectionTwoInfoLists [indexPath.Row];	
			}
			else 
				item = personInfoController.secitonThreeInfoLists[indexPath.Row];
			if (item.IsSkip) {
				var controller = FuncTypeControllerFactory.CreateFuncViewController(item.FuncType);
				personInfoController.NavigationController.PushViewController (controller, true);
			}
			tableView.DeselectRow (indexPath, true);
			
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			InfoItem item;
			if (indexPath.Section == 0) {
				item = personInfoController.sectionOneInfoLists[indexPath.Row];
			} else if(indexPath.Section ==1) {
				item = personInfoController.sectionTwoInfoLists [indexPath.Row];	
			}
			else 
				item = personInfoController.secitonThreeInfoLists[indexPath.Row];
			var  cell = tableView.DequeueReusableCell (PersonInfoTableViewCell.Key) as PersonInfoTableViewCell ;
			if (cell == null)
				cell = PersonInfoTableViewCell.CreateCell();
		
			cell.Lbl_Title.Text = item.Title;	
			cell.Lbl_TitleValue.Text = item.TitleValue;
			if (item.IsSkip)
				cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
			else
				cell.Accessory = UITableViewCellAccessory.None;
			return cell;
		}
	}
}

