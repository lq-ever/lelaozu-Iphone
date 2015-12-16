using System;

using UIKit;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace lelaozuIphone
{
	public partial class PersonInfoEmailViewController : UIViewController
	{
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();

		public PersonInfoEmailViewController () : base ("PersonInfoEmailViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "电子邮箱";
			//电子邮箱
			txt_email.Text = FormatUtil.StrVaueFormat(Constants.MyInfo.Email);

		}

		/// <summary>
		/// 保存
		/// </summary>
		private void Save()
		{
			var email = txt_email.Text;
			if (string.IsNullOrEmpty (email)) {
//				Toast.MakeText(this,"邮箱不能为空,请输入邮箱",ToastLength.Short).Show();
//				return ;
			}
			if (!RegexUtil.IsEmail (email)) {
//				Toast.MakeText(this,"输入邮箱不规范",ToastLength.Short).Show();
//				return ;
			}
//			ProgressDialogUtil.StartProgressDialog(this,"正在保存...");
//			//检测网络连接
//			if(!EldYoungUtil.IsConnected(this))
//			{
//				Toast.MakeText(this,"网络连接超时,请检测网络",ToastLength.Short).Show();	
//				ProgressDialogUtil.StopProgressDialog();
//				return;
//			}

			//调用restapi注册,将用户名、密码信息写
			var updateMyInfoParam = new UpdateMyInfoParam () {
				Uid = Constants.MyInfo.UId,ParamType = "Email",ParamValue = email
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
					if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						//获取并解析返回resultJson获取安全码结果值
						var result = response.Content;
						var updateMyInfoJson = JsonConvert.DeserializeObject<UpdateMyInfoJson>(result);
						if(updateMyInfoJson.statuscode == "1")
						{
//							RunOnUiThread(()=>
//								{
//									Toast.MakeText(this,"保存成功",ToastLength.Short).Show();
//									Global.MyInfo.Email = email;
//									ProgressDialogUtil.StopProgressDialog();
//									this.Finish();
//									OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
//								});
							InvokeOnMainThread(()=>
								{
									Constants.MyInfo.Email = email;
									this.NavigationController.PopViewController(true);
								});
						}
						else
						{
//							RunOnUiThread(()=>
//								{
//									Toast.MakeText(this,updateMyInfoJson.message,ToastLength.Short).Show();
//									ProgressDialogUtil.StopProgressDialog();
//									return;
//								});
						}
					}
					else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut){
//						RunOnUiThread(()=>
//							{
//								Toast.MakeText(this,"网络连接超时，请重试",ToastLength.Short).Show();
//								ProgressDialogUtil.StopProgressDialog();
//								return;
//							});
					}
					else
					{
//						RunOnUiThread(()=>
//							{
//								Toast.MakeText(this,response.StatusDescription,ToastLength.Short).Show();
//								ProgressDialogUtil.StopProgressDialog();
//								return;
//							});
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


