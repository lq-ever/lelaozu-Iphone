using System;
using UIKit;
using System.Collections.Generic;
using Foundation;

namespace lelaozuIphone
{
	/// <summary>
	/// Alarm table source.报警列表处理数据源
	/// </summary>
	public class AlarmTableSource:UITableViewSource
	{
		public List<AlarmInfoListItem> alarmList;
		protected UIViewController controller;
		UITableView View;

		public AlarmTableSource (List<AlarmInfoListItem> _alarmList,UIViewController _controller,UITableView view)
		{
			alarmList = _alarmList;
			controller = _controller;
			View = view;
		}
		public void Add(AlarmInfoListItem _alarmInfoItem)
		{
			alarmList.Add(_alarmInfoItem);
			View.InsertRows(new NSIndexPath[]{ NSIndexPath.FromRowSection(alarmList.Count - 1, 0) }, UITableViewRowAnimation.Left);

		}

		public void AddRows(List<AlarmInfoListItem> _alarmList)
		{
			foreach (var item in _alarmList) {
				alarmList.Add (item);
				View.InsertRows(new NSIndexPath[]{ NSIndexPath.FromRowSection(alarmList.Count - 1, 0) }, UITableViewRowAnimation.Left);
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
			return 70;
		}
		/// <summary>
		/// Rowses the in section.
		/// </summary>
		/// <returns>The in section.</returns>
		/// <param name="tableview">Tableview.</param>
		/// <param name="section">Section.</param>
		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return	alarmList.Count;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			var item = alarmList [indexPath.Row];
			var alarmDetailController = new AlarmDetailViewController (){AlarmOrigin ="alarmList",AlarmId=item.AId};
			alarmDetailController.HidesBottomBarWhenPushed = true;
			controller.NavigationController.PushViewController (alarmDetailController,true);
			tableView.DeselectRow (indexPath, true);

		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var item = alarmList [indexPath.Row];
			var  cell = tableView.DequeueReusableCell (AlarmListTableViewCell.Key) as AlarmListTableViewCell;

			if (cell == null) {
				cell = AlarmListTableViewCell.CreateCell ();
			}
			cell.Lbl_AlarmTrueName.Text = FormatUtil.StrVaueFormat (item.TrueName);
			cell.Lbl_AlarmTime.Text = FormatUtil.StrToTimeFormat (item.AlarmTime);
			cell.Lbl_AlarmStatus.Text = FormatUtil.StrVaueFormat (item.Status);
			cell.Lbl_AlarmContent.Text = FormatUtil.StrVaueFormat (item.AlarmContent);
			cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
			return cell;

		}


	}
}

