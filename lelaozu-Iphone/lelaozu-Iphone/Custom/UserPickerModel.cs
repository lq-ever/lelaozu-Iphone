using System;
using UIKit;
using System.Collections.Generic;

namespace lelaozuIphone
{
	public class UserPickerModel:UIPickerViewModel
	{
		public List<AllMyUserListItem> MyUserLists;
		public event EventHandler<PickerChangedEventArgs> PickerChanged;
		public UserPickerModel (List<AllMyUserListItem> _myUserList)
		{
			MyUserLists = _myUserList;
		}
		public override nint GetComponentCount (UIPickerView pickerView)
		{
			return 1;
		}
		public override nint GetRowsInComponent (UIPickerView pickerView, nint component)
		{
			return MyUserLists.Count;
		}
		public override string GetTitle (UIPickerView pickerView, nint row, nint component)
		{
			return MyUserLists[(int)row].ToString();
		}
		public override nfloat GetRowHeight (UIPickerView pickerView, nint component)
		{
			return 40f;
		}
		public override void Selected (UIPickerView pickerView, nint row, nint component)
		{
			if (PickerChanged != null) {
				PickerChanged (this, new PickerChangedEventArgs (){ UserItem = MyUserLists[(int)row]});
			}
		}
	}
	public class PickerChangedEventArgs:EventArgs
	{
		public AllMyUserListItem UserItem {
			get;
			set;
		}
	}
}

