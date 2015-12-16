using System;
using UIKit;
using System.Collections.Generic;

namespace lelaozuIphone
{
	public class AlarmTypePickerModel:UIPickerViewModel
	{
		public List<AlarmTypeItem> AlarmTypeLists;
		public event EventHandler<AlamTypePickerChangedEventArgs> PickerChanged;

		public AlarmTypePickerModel (List<AlarmTypeItem> _alarmTypeLists) 
		{
			AlarmTypeLists = _alarmTypeLists;
		}
		public override nint GetComponentCount (UIPickerView pickerView)
		{
			return 1;
		}
		public override nint GetRowsInComponent (UIPickerView pickerView, nint component)
		{
			return AlarmTypeLists.Count;
		}
		public override string GetTitle (UIPickerView pickerView, nint row, nint component)
		{
			return AlarmTypeLists[(int)row].ToString();
		}
		public override nfloat GetRowHeight (UIPickerView pickerView, nint component)
		{
			return 40f;
		}
		public override void Selected (UIPickerView pickerView, nint row, nint component)
		{
			if (PickerChanged != null) {
				PickerChanged (this, new AlamTypePickerChangedEventArgs (){ Item = AlarmTypeLists[(int)row]});
			}
		}
	}

	public class AlamTypePickerChangedEventArgs:EventArgs
	{
		public AlarmTypeItem Item {
			get;
			set;
		}
	}
}

