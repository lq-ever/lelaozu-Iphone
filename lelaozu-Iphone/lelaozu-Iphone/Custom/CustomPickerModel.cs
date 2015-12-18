using System;
using UIKit;
using System.Collections.Generic;

namespace lelaozuIphone
{
	/// <summary>
	/// 自定义pickview的model 泛型类
	/// </summary>
	public class CustomPickerModel<T>:UIPickerViewModel
	{
		//public event EventHandler<T> PickerChanged;
	
		List<T> modellists;
		public Action<T> PickerAction;
		public CustomPickerModel (List<T> _modelLists)
		{
			modellists = _modelLists;

		}
		public override nint GetComponentCount (UIPickerView pickerView)
		{
			return 1;
		}
		public override nint GetRowsInComponent (UIPickerView pickerView, nint component)
		{
			return modellists.Count;
		}
		public override string GetTitle (UIPickerView pickerView, nint row, nint component)
		{
			return modellists[(int)row].ToString();
		}
		public override nfloat GetRowHeight (UIPickerView pickerView, nint component)
		{
			return 35f;
		}
		public override void Selected (UIPickerView pickerView, nint row, nint component)
		{
			if(PickerAction!=null)
				PickerAction(modellists[(int)row]);
			
		}

	}

}

