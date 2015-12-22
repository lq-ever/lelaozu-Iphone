using System;
using UIKit;
using System.Collections.Generic;
using Foundation;

namespace lelaozuIphone
{
	public class AdviceRecordTableSource:UITableViewSource
	{
		public List<AdviceRecordInfoItem> AdviceRecordList;
		UITableView tableView;
		UIViewController viewController;

		public AdviceRecordTableSource (List<AdviceRecordInfoItem> _adviceRecordList,UIViewController _controller,UITableView _tableView)
		{
			AdviceRecordList = _adviceRecordList;
			viewController = _controller;
			tableView = _tableView;
		}

		public void Add(AdviceRecordInfoItem _recordInfoItem)
		{
			AdviceRecordList.Add(_recordInfoItem);
			tableView.InsertRows(new NSIndexPath[]{ NSIndexPath.FromRowSection(AdviceRecordList.Count - 1, 0) }, UITableViewRowAnimation.Left);

		}

		public void AddRows(List<AdviceRecordInfoItem> _recordInfoList)
		{
			foreach (var item in _recordInfoList) {
				AdviceRecordList.Add (item);
				tableView.InsertRows(new NSIndexPath[]{ NSIndexPath.FromRowSection(AdviceRecordList.Count - 1, 0) }, UITableViewRowAnimation.Left);
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
			return 80;
		}
		/// <summary>
		/// Rowses the in section.
		/// </summary>
		/// <returns>The in section.</returns>
		/// <param name="tableview">Tableview.</param>
		/// <param name="section">Section.</param>
		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return	AdviceRecordList.Count;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
//			var item = alarmList [indexPath.Row];
//			var alarmDetailController = new AlarmDetailViewController (){AlarmOrigin ="alarmList",AlarmId=item.AId};
//			alarmDetailController.HidesBottomBarWhenPushed = true;
//			controller.NavigationController.PushViewController (alarmDetailController,true);
			tableView.DeselectRow (indexPath, true);

		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var item = AdviceRecordList [indexPath.Row];
			var  cell = tableView.DequeueReusableCell (AdviceRecordTableViewCell.Key) as AdviceRecordTableViewCell;

			if (cell == null) {
				cell = AdviceRecordTableViewCell.CreateCell ();
			}
			cell.Img_AdviceType.Image = UIImage.FromFile (GetAdviceTypeImgName(item.MessageType));
			cell.Lbl_AdviceTtile.Text = FormatUtil.StrVaueFormat (item.MessageTitle);
			cell.Lbl_AdviceTime.Text = FormatUtil.StrToTimeFormat (item.MessageTime);
			cell.Lbl_AdviceContent.Text = FormatUtil.StrVaueFormat (item.MessageContent);
			cell.Accessory = UITableViewCellAccessory.None;
			return cell;

		}

		/// <summary>
		/// 获取建议类型Id
		/// </summary>
		/// <returns>The advice type identifier.</returns>
		/// <param name="adviceType">Advice type.</param>
		private string GetAdviceTypeImgName(string adviceType)
		{
			string adviceTypeImgName;
			switch ((AdviceType)Convert.ToInt16(adviceType)) {
			case AdviceType.Consult:
				adviceTypeImgName = "ic_myInfo_advision_zixun.png";
				break;
			case AdviceType.Suggest:
				adviceTypeImgName = "ic_myInfo_advision_jianyi.png";
				break;
			case AdviceType.Complain:
				adviceTypeImgName = "ic_myInfo_advision_tousu.png";
				break;
			case AdviceType.Other:
				adviceTypeImgName = "ic_myInfo_advision_qita.png";
				break;
			default:
				adviceTypeImgName = "ic_myInfo_advision_zixun.png";
				break;

			}
			return adviceTypeImgName;
		}
	}
}

