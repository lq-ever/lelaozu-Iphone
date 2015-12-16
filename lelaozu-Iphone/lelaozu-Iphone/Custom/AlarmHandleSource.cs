using System;
using UIKit;
using System.Collections.Generic;
using Foundation;

namespace lelaozuIphone
{
	/// <summary>
	/// Alarm handle source.报警详情处理数据源
	/// </summary>
	public class AlarmHandleSource:UITableViewSource
	{
		public List<AlarmInfoHandDetailItem> handleDetailList;
		public AlarmHandleSource (List<AlarmInfoHandDetailItem> _handleDetailList)
		{
			handleDetailList = _handleDetailList;
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
			return	handleDetailList.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var item = handleDetailList [indexPath.Row];
			var  cell = tableView.DequeueReusableCell (AlarmHandleCell.Key) as AlarmHandleCell;

			if (cell == null) {
				cell = AlarmHandleCell.CreateCell ();
			}
			cell.Lbl_HandleTime.Text = FormatUtil.StrToTimeFormat (item.HandleTime);
			cell.Lbl_HandleContent.Text = FormatUtil.StrVaueFormat (item.HandleContent);
			cell.Lbl_HandleRemark.Text = FormatUtil.StrVaueFormat (item.Remark);
			return cell;

		}
	}
}

