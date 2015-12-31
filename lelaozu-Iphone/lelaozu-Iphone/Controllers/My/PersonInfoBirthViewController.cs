using System;

using UIKit;
using System.Collections.Generic;
using Newtonsoft.Json;
using Foundation;

namespace lelaozuIphone
{
	public partial class PersonInfoBirthViewController : UIViewController
	{
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private UIAlertController alertdateController;//日期controller
		private UIDatePicker datePicker;// 日期控件
		public PersonInfoBirthViewController () : base ("PersonInfoBirthViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "生日";
			txt_birth.Text = FormatUtil.StrToShortData(Constants.MyInfo.Age);
			//set the time
			txt_birth.ShouldBeginEditing = (textField) => {

				if(alertdateController==null && datePicker==null)
				{
					alertdateController = UIAlertController.Create("请选择日期","\n\n\n\n\n\n\n\n",UIAlertControllerStyle.ActionSheet);
					datePicker = new UIDatePicker();
					datePicker.Mode = UIDatePickerMode.Date;
					datePicker.Locale = NSLocale.FromLocaleIdentifier("zh_Hans_CN");
					alertdateController.View.AddSubview(datePicker);
					var formater = new  NSDateFormatter();
					formater.DateFormat = "yyyy-MM-dd";
					alertdateController.AddAction(UIAlertAction.Create("确定",UIAlertActionStyle.Default,(Action)=>
						{
							textField.Text = formater.StringFor(datePicker.Date);
						}));
					alertdateController.AddAction(UIAlertAction.Create("取消",UIAlertActionStyle.Cancel,(Action)=>
						{
						}));
				}

				PresentViewController(alertdateController,true,null);
				return textField.ResignFirstResponder();
			};
			btn_save.BackgroundColor = Color.Blue;
			btn_save.TouchUpInside += (sender, e) => 
			{
				Save();
			};
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		/// <summary>
		/// 保存
		/// </summary>
		private void Save()
		{
			var birth = txt_birth.Text;
			if (string.IsNullOrEmpty (birth)) {
				BTProgressHUD.ShowToast ("生日不能为空,请选择生日日期",showToastCentered:false,timeoutMs:1000);
				return ;
			}
			if (Convert.ToDateTime(birth) >= Convert.ToDateTime(DateTime.Now.ToString ("yyyy-MM-dd"))) {
				BTProgressHUD.ShowToast ("生日应小于当前日期",showToastCentered:false,timeoutMs:1000);
				return ;
			}

			BTProgressHUD.Show("正在保存...",-1,ProgressHUD.MaskType.Black);
			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;

			//调用restapi注册,将用户名、密码信息写
			var updateMyInfoParam = new UpdateMyInfoParam () {
				Uid = Constants.MyInfo.UId,ParamType = "Age",ParamValue = birth
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
									Constants.MyInfo.Age = birth;
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
					else
					{
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowErrorWithStatus(response.StatusDescription,1000);
							});
					}

				});
		}
	}
}


