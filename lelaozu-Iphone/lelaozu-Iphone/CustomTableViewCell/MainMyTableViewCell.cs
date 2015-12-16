using System;

using Foundation;
using UIKit;

namespace lelaozuIphone
{
	public partial class MainMyTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("MainMyTableViewCell");
		public static readonly UINib Nib;

		static MainMyTableViewCell ()
		{
			Nib = UINib.FromName ("MainMyTableViewCell", NSBundle.MainBundle);
		}

		public MainMyTableViewCell (IntPtr handle) : base (handle)
		{
		}

		public static MainMyTableViewCell CreateCell()
		{
			return (MainMyTableViewCell)Nib.Instantiate(null,null)[0];
		}
		public UIImageView Img_Sign
		{
			get{
				return  img_sign;
			}
		}
		public UILabel Lbl_Title
		{
			get{
				return lbl_title;
			}
		}
	}
}
