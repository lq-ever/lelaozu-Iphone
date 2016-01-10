using System;

using UIKit;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace lelaozuIphone
{
	public partial class PersonInfoGenderViewController : UIViewController
	{
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private UIAlertController alertGenderController;//性别controller
		private UIPickerView pickerView;//性别 pickerView
		private string genderId;//性别标识
		public PersonInfoGenderViewController () : base ("PersonInfoGenderViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "性别";
			scrollView.Frame = Constants.Screen_Frame;
			var genderValue = FormatUtil.StrVaueFormat (Constants.MyInfo.Gender);
			genderId = !string.IsNullOrEmpty (genderValue) ? genderValue : "1";
			txt_gender.Text = genderValue.Equals ("0") ? "男" : "女";
			InitGenderPicker ();
			btn_save.BackgroundColor = Color.Blue;
			btn_save.TouchUpInside += (sender, e) => 
			{
				Save();
			};
			scrollView.ContentSize = new CoreGraphics.CGSize (scrollView.Frame.Width, scrollView.Frame.Height + 10);
		}

		private void InitGenderPicker()
		{
			var genderList = new List<GenderItem>{ new GenderItem{GenderId="0",GenderDesc="男"},new GenderItem{GenderId="1",GenderDesc="女"}};

			txt_gender.ShouldBeginEditing = (textField) => {

				GenderItem selectItem = null;
				if(alertGenderController == null && pickerView == null)
				{
					alertGenderController = UIAlertController.Create("请选择性别","\n\n\n\n\n\n\n\n",UIAlertControllerStyle.ActionSheet);
					pickerView = new UIPickerView();
					var genderModel = new CustomPickerModel<GenderItem>(genderList);
					genderModel.PickerAction = (item)=>
					{
						selectItem = item;
					};
					pickerView.Model = genderModel;

					alertGenderController.View.AddSubview(pickerView);
					alertGenderController.AddAction(UIAlertAction.Create("确定",UIAlertActionStyle.Default,(Action)=>
						{
							if(selectItem!=null)
							{
								genderId = selectItem.GenderId;
								textField.Text = selectItem.GenderDesc;
							}
						}));
					alertGenderController.AddAction(UIAlertAction.Create("取消",UIAlertActionStyle.Cancel,(Action)=>
						{
						}));
				}

				PresentViewController(alertGenderController,true,null);
				return txt_gender.ResignFirstResponder();
			};
		}

		/// <summary>
		/// 保存
		/// </summary>
		private void Save()
		{
			BTProgressHUD.Show("正在保存...",-1,ProgressHUD.MaskType.Black);
			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;
			//调用restapi注册,将用户名、密码信息写
			var updateMyInfoParam = new UpdateMyInfoParam () {
				Uid = Constants.MyInfo.UId,ParamType = "Gender",ParamValue = genderId
			};
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", updateMyInfoParam.Key);
			else
				requestParams ["key"] = updateMyInfoParam.Key;

			if (!requestParams.ContainsKey ("eUId"))
				requestParams.Add ("eUId", updateMyInfoParam.Euid);
			else
				requestParams ["eUId"] = updateMyInfoParam.Euid;

			if (!requestParams.ContainsKey ("eparamType"))
				requestParams.Add ("eparamType", updateMyInfoParam.EparamType);
			else
				requestParams ["eparamType"] = updateMyInfoParam.EparamType;

			if (!requestParams.ContainsKey ("eparamValue"))
				requestParams.Add ("eparamValue", updateMyInfoParam.EparamValue);
			else
				requestParams ["eparamValue"] = updateMyInfoParam.EparamValue;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", updateMyInfoParam.Md5);
			else
				requestParams ["md5"] = updateMyInfoParam.Md5;	
			var restSharpRequestUtil = new RestSharpRequestUtil(updateMyInfoParam.Url,requestParams);
			restSharpRequestUtil.ExcuteAsync((RestSharp.IRestResponse response) => 
				{
					InvokeOnMainThread(()=>
						{
							BTProgressHUD.Dismiss();
							//在状态栏中hide使用网络指示器
							UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
						});
					if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						//获取并解析返回resultJson获取安全码结果值
						var result = response.Content;
						var updateMyInfoJson = JsonConvert.DeserializeObject<UpdateMyInfoJson>(result);
						if(updateMyInfoJson.statuscode == "1")
						{
							InvokeOnMainThread(()=>
								{
									BTProgressHUD.ShowSuccessWithStatus("保存成功",1000);
									Constants.MyInfo.Gender = genderId;
									this.NavigationController.PopViewController(true);
								});
						}
						else
						{
							
							InvokeOnMainThread(()=>
								{
									BTProgressHUD.ShowToast(updateMyInfoJson.message,showToastCentered:false,timeoutMs:1000);
								});
						}
					}
					else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut){
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast("网络超时...",showToastCentered:false,timeoutMs:1000);
							}
						);
					}
					else{
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowErrorWithStatus(Constants.ErrorStatusDes,2000);
							});
					}

				});
		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}


	public class GenderItem
	{
		public string GenderId {
			get;
			set;
		}
		public string GenderDesc {
			get;
			set;
		}
		public override string ToString ()
		{
			return GenderDesc;
		}
	}
}


