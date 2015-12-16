using System;

using Foundation;
using UIKit;

namespace lelaozuIphone
{
	public partial class GuardianApplyTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("GuardianApplyTableViewCell");
		public static readonly UINib Nib;

		static GuardianApplyTableViewCell ()
		{
			Nib = UINib.FromName ("GuardianApplyTableViewCell", NSBundle.MainBundle);
		}

		public GuardianApplyTableViewCell (IntPtr handle) : base (handle)
		{
		}
		public static GuardianApplyTableViewCell CreateCell()
		{
			return (GuardianApplyTableViewCell)Nib.Instantiate(null,null)[0];
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
		public UIButton Btn_Agree
		{
			get{
				return btn_agree;
			}
		}
		public UIButton Btn_Disagree
		{
			get{
				return btn_disagree;
			}
		}
		public UILabel Lbl_ApplyContent
		{
			get{
				return lbl_applyContent;
			}
		}
	}
}
