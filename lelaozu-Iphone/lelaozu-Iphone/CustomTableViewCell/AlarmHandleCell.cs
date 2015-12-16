using System;

using Foundation;
using UIKit;

namespace lelaozuIphone
{
	public partial class AlarmHandleCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("AlarmHandleCell");
		public static readonly UINib Nib;

		static AlarmHandleCell ()
		{
			Nib = UINib.FromName ("AlarmHandleCell", NSBundle.MainBundle);
		}

		public AlarmHandleCell (IntPtr handle) : base (handle)
		{
		}

		public static AlarmHandleCell CreateCell()
		{
			return (AlarmHandleCell)Nib.Instantiate(null,null)[0];
		}

		public UILabel Lbl_HandleContent
		{
			get{
				return lbl_handleContent;
			}
		}
		public UILabel Lbl_HandleTime
		{
			get{
				return lbl_handleTime;
			}
		}
		public UILabel Lbl_HandleRemark
		{
			get{
				return lbl_handleRemark;
			}
		}
	}
}
