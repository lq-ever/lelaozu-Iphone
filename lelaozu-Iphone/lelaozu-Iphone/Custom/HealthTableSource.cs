using System;
using UIKit;
using System.Collections.Generic;
using Foundation;

namespace lelaozuIphone
{
	public class HealthTableSource:UITableViewSource
	{
		public List<HealthInfoItem> healthList;
		protected UIViewController controller;
		UITableView View;
		public HealthTableSource (List<HealthInfoItem> _healthList,UIViewController _controller,UITableView view)
		{
			healthList = _healthList;
			controller = _controller;
			View = view;
		}

		public void Add(HealthInfoItem _healthInfoItem)
		{
			healthList.Add(_healthInfoItem);
			View.InsertRows(new NSIndexPath[]{ NSIndexPath.FromRowSection(healthList.Count - 1, 0) }, UITableViewRowAnimation.Left);

		}

		public void AddRows(List<HealthInfoItem> _healthList)
		{
			foreach (var item in _healthList) {
				healthList.Add (item);
				View.InsertRows(new NSIndexPath[]{ NSIndexPath.FromRowSection(healthList.Count - 1, 0) }, UITableViewRowAnimation.Left);
			}
		}

		/// <summary>
		/// Numbers the of sections.
		/// </summary>
		/// <returns>The of sections.</returns>
		/// <param name="tableView">Table view.</param>
		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;

		}
		/// <summary>
		/// Gets the height for row.行高
		/// </summary>
		/// <returns>The height for row.</returns>
		/// <param name="tableView">Table view.</param>
		/// <param name="indexPath">Index path.</param>
		public override nfloat GetHeightForRow (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			return 65;
		}
		/// <summary>
		/// Rowses the in section.
		/// </summary>
		/// <returns>The in section.</returns>
		/// <param name="tableview">Tableview.</param>
		/// <param name="section">Section.</param>
		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return	healthList.Count;
		}
		/// <summary>
		/// Rows the selected.
		/// </summary>
		/// <param name="tableView">Table view.</param>
		/// <param name="indexPath">Index path.</param>
		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var item = healthList [indexPath.Row];
			var healthDetailController = new HealthDetailViewController (item);
			healthDetailController.HidesBottomBarWhenPushed = true;
			controller.NavigationController.PushViewController(healthDetailController,true);
			tableView.DeselectRow (indexPath, true);
		}
		/// <summary>
		/// Gets the cell.
		/// </summary>
		/// <returns>The cell.</returns>
		/// <param name="tableView">Table view.</param>
		/// <param name="indexPath">Index path.</param>
		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var item = healthList [indexPath.Row];
			var  cell = tableView.DequeueReusableCell (HealthListTableViewCell.Key) as HealthListTableViewCell;

			if (cell == null) {
				cell = HealthListTableViewCell.CreateCell ();
			}
			cell.Lbl_TestTime.Text =  FormatUtil.StrToTimeFormat(item.TestTime);
			cell.Lbl_BloodGlucose.Text = FormatUtil.StrVaueFormat(item.BloodGlucose);
			cell.Lbl_Weight.Text = FormatUtil.StrVaueFormat(item.Weight);
			cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
			cell.SelectionStyle = UITableViewCellSelectionStyle.Gray;
			return cell;
		}
	}
}

