using System;

using Foundation;
using UIKit;

namespace lelaozuIphone
{
	public partial class AdviceRecordTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("AdviceRecordTableViewCell");
		public static readonly UINib Nib;

		static AdviceRecordTableViewCell ()
		{
			Nib = UINib.FromName ("AdviceRecordTableViewCell", NSBundle.MainBundle);
		}

		public AdviceRecordTableViewCell (IntPtr handle) : base (handle)
		{
		}

		public static AdviceRecordTableViewCell CreateCell()
		{
			return (AdviceRecordTableViewCell)Nib.Instantiate(null,null)[0];
		}
		public UIImageView Img_AdviceType
		{
			get{
				return img_adviceType;
			}
		}

		public UILabel Lbl_AdviceTtile {
			get {
				return lbl_adviceTitle;
			}
		}

		public UILabel Lbl_AdviceTime
		{
			get{
				return lbl_adviceTime;
			}
		}
		public UILabel Lbl_AdviceContent
		{
			get{
				return lbl_adviceContent;
			}
		}
	}
}
