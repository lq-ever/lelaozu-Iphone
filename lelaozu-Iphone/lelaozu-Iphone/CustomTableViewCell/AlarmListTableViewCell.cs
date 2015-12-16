using System;

using Foundation;
using UIKit;

namespace lelaozuIphone
{
	public partial class AlarmListTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("AlarmListTableViewCell");
		public static readonly UINib Nib;

		static AlarmListTableViewCell ()
		{
			Nib = UINib.FromName ("AlarmListTableViewCell", NSBundle.MainBundle);
		}

		public AlarmListTableViewCell (IntPtr handle) : base (handle)
		{
		}
		public static AlarmListTableViewCell CreateCell()
		{
			return (AlarmListTableViewCell)Nib.Instantiate(null,null)[0];
		}
		public UILabel Lbl_AlarmTrueName
		{
			get{
				return lbl_alarmTrueName;
			}
		}
		public UILabel Lbl_AlarmContent
		{
			get{
				return lbl_alarmContent;
			}
		}
		public UILabel Lbl_AlarmStatus
		{
			get{
				return lbl_alarmStatus;
			}
		}
		public UILabel Lbl_AlarmTime
		{
			get{
				return lbl_alarmTime;
			}
		}
	}
}
