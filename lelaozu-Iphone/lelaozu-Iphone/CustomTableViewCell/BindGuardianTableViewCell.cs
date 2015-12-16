using System;

using Foundation;
using UIKit;

namespace lelaozuIphone
{
	public partial class BindGuardianTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("BindGuardianTableViewCell");
		public static readonly UINib Nib;

		static BindGuardianTableViewCell ()
		{
			Nib = UINib.FromName ("BindGuardianTableViewCell", NSBundle.MainBundle);
		}

		public BindGuardianTableViewCell (IntPtr handle) : base (handle)
		{
			
		}
		public static BindGuardianTableViewCell CreateCell()
		{
			return (BindGuardianTableViewCell)Nib.Instantiate(null,null)[0];
		}
		public UIImageView Img_Head
		{
			get{
				return img_head;
			}
		}
		public UILabel Lbl_Name
		{
			get{
				return lbl_name;
			}
		}
		public UILabel Lbl_BindStatus
		{
			get{
				return lbl_bindStatus;
			}
		}
		public UIImageView Img_Sex
		{
			get{
				return img_sex;
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
