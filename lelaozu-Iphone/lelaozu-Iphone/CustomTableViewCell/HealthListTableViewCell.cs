using System;

using Foundation;
using UIKit;

namespace lelaozuIphone
{
	public partial class HealthListTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("HealthListTableViewCell");
		public static readonly UINib Nib;

		static HealthListTableViewCell ()
		{
			Nib = UINib.FromName ("HealthListTableViewCell", NSBundle.MainBundle);
		}

		public HealthListTableViewCell (IntPtr handle) : base (handle)
		{
			
		}
		public static HealthListTableViewCell CreateCell()
		{
			return (HealthListTableViewCell)Nib.Instantiate(null,null)[0];
		}
		public UILabel Lbl_TestTime
		{
			get{
				return lbl_testTime;
			}
		}
		public UILabel Lbl_Weight
		{
			get{
				return lbl_weight;
			}
		}
		public UILabel Lbl_BloodGlucose
		{
			get{
				return lbl_bloodGlucose;
			}
		}
	}
}
