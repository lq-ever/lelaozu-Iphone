using System;

using Foundation;
using UIKit;

namespace lelaozuIphone
{
	public partial class SettingTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("SettingTableViewCell");
		public static readonly UINib Nib;

		static SettingTableViewCell ()
		{
			Nib = UINib.FromName ("SettingTableViewCell", NSBundle.MainBundle);
		}

		public SettingTableViewCell (IntPtr handle) : base (handle)
		{
			
		}

		public static SettingTableViewCell CreateCell()
		{
			return (SettingTableViewCell)Nib.Instantiate(null,null)[0];
		}

		public UIImageView Img_Sign
		{
			get{
				return img_sign;
			}
		}
		public UILabel Lbl_Title
		{
			get{
				return lbl_title;
			}
		}
		public UILabel Lbl_TitleVaule
		{
			get {
				return lbl_titleValue;
			}
		}
	}
}
