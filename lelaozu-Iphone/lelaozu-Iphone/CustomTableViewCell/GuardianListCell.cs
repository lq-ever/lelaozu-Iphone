using System;

using Foundation;
using UIKit;

namespace lelaozuIphone
{
	public partial class GuardianListCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("GuardianListCell");
		public static readonly UINib Nib;

		static GuardianListCell ()
		{
			Nib = UINib.FromName ("GuardianListCell", NSBundle.MainBundle);
		}

		public GuardianListCell (IntPtr handle) : base (handle)
		{
		}

		public static GuardianListCell CreateCell()
		{
			return (GuardianListCell)Nib.Instantiate(null,null)[0];
		}
		public UIImageView Img_Head
		{
			get{
				return img_head;
			}
		}
		public UIImageView Img_Sex
		{
			get{
				return img_sex;
			}
		}
		public UILabel Lbl_Name
		{
			get{
				return lbl_name;
			}
		}
		public UILabel Lbl_PhoneNumber
		{
			get{
				return lbl_phoneNumber;
			}
		}
		public UILabel Lbl_Location
		{
			get{
				return lbl_location;
			}
		}
		public UIButton Btn_Action
		{
			get{
				return btn_action;
			}
		}
	}
}
