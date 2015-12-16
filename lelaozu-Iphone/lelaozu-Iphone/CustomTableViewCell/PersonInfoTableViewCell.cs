using System;

using Foundation;
using UIKit;

namespace lelaozuIphone
{
	public partial class PersonInfoTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("PersonInfoTableViewCell");
		public static readonly UINib Nib;

		static PersonInfoTableViewCell ()
		{
			Nib = UINib.FromName ("PersonInfoTableViewCell", NSBundle.MainBundle);
		}

		public PersonInfoTableViewCell (IntPtr handle) : base (handle)
		{
		}

		public static PersonInfoTableViewCell CreateCell()
		{
			return (PersonInfoTableViewCell)Nib.Instantiate(null,null)[0];
		}

		public UILabel Lbl_Title
		{
			get{
				return lbl_title;
			}
		}
		public UILabel Lbl_TitleValue
		{
			get {
				return lbl_titleValue;
			}
		}
	}
}
