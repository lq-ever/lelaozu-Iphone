﻿using System;

using UIKit;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace lelaozuIphone
{
	public partial class PersonInfoCardLocationViewController : UIViewController
	{
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		public PersonInfoCardLocationViewController () : base ("PersonInfoCardLocationViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "身份证所在地";
			txt_idCardLocation.Text = FormatUtil.StrVaueFormat (Constants.MyInfo.IDAddress); 

			txt_idCardLocation.KeyboardType = UIKeyboardType.Default;
			txt_idCardLocation.ReturnKeyType = UIReturnKeyType.Done;
			txt_idCardLocation.ShouldReturn = (textField) => {
				return txt_idCardLocation.ResignFirstResponder();
			};

			//btn_save
			btn_save.BackgroundColor = Color.Blue;
			btn_save.TouchUpInside += (sender, e) => 
			{
				txt_idCardLocation.ResignFirstResponder();
				Save();
			};
		}

		/// <summary>
		/// 保存
		/// </summary>
		private void Save()
		{
			var idCardLocation = txt_idCardLocation.Text;
			if (string.IsNullOrEmpty (idCardLocation)) {
				BTProgressHUD.ShowToast ("身份证所在地不能为空,请输入",showToastCentered:false,timeoutMs:1000);
				return ;
			}

			BTProgressHUD.Show("正在保存...",-1,ProgressHUD.MaskType.Black);
			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;


			var updateMyInfoParam = new UpdateMyInfoParam () {
				Uid = Constants.MyInfo.UId,ParamType = "IDAddress",ParamValue = idCardLocation
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
									Constants.MyInfo.IDAddress = idCardLocation;
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
								BTProgressHUD.ShowErrorWithStatus(Constants.ErrorStatusDes,1000);
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
}


