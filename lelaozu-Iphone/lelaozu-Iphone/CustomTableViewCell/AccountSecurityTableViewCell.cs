using System;

using Foundation;
using UIKit;

namespace lelaozuIphone
{
	public partial class AccountSecurityTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("AccountSecurityTableViewCell");
		public static readonly UINib Nib;

		static AccountSecurityTableViewCell ()
		{
			Nib = UINib.FromName ("AccountSecurityTableViewCell", NSBundle.MainBundle);
		}

		public AccountSecurityTableViewCell (IntPtr handle) : base (handle)
		{
		}
		public static AccountSecurityTableViewCell CreateCell()
		{
			return (AccountSecurityTableViewCell)Nib.Instantiate(null,null)[0];
		}

		public UILabel Lbl_Title
		{
			get{
				return lbl_title;
			}
		}

		public UILabel Lbl_Desc
		{
			get{
				return lbl_desc;
			}
		}

		public UILabel Lbl_TitleValue
		{
			get{
				return lbl_titleValue;
			}
		}
	}
}
