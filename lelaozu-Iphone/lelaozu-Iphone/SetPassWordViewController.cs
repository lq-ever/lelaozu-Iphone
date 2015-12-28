using System;

using UIKit;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace lelaozuIphone
{
	public partial class SetPassWordViewController : UIViewController
	{
		private string sendType;
		public string SendType {
			get {
				return sendType;
			}
			set
			{
				sendType = value;
			}
		}
		private string phoneNumber;
		public string PhoneNumber
		{
			get{
				return phoneNumber;
			}
			set{
				phoneNumber = value;
			}
		}
		private string passWord, confirmPassWord;
		private Dictionary<string,string> requestsubmitParams = new Dictionary<string,string> ();
		public SetPassWordViewController () : base ("SetPassWordViewController", null)
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "设置密码";
			InitView ();
		}

		private void InitView()
		{
			if (sendType == "FindPwd") {
				txt_pwd.Placeholder = "输入新登录密码";
				txt_confirmPwd.Placeholder = "再次输入新登录密码";
			} else if (sendType == "ModifyPwd") {
				txt_pwd.Placeholder = "输入新登录密码";
				txt_confirmPwd.Placeholder = "再次输入新登录密码";
			} else if (sendType == "ModifyPayPwd") {
				txt_pwd.Placeholder = "输入新支付密码";
				txt_confirmPwd.Placeholder = "再次输入新支付密码";
			}
			///submit
			btn_submit.TouchUpInside += (object sender, EventArgs e) => 
			{
				Submit();
			};
		}

		/// <summary>
		/// Submit this instance.
		/// </summary>
		private void Submit()
		{
			passWord = txt_pwd.Text;
			if (string.IsNullOrEmpty (passWord)) {
				BTProgressHUD.ShowToast ("密码不能为空,请输入密码",showToastCentered:false,timeoutMs:1000);
				return ;
			}
			confirmPassWord = txt_confirmPwd.Text;
			if (string.IsNullOrEmpty (confirmPassWord)) {
				
				BTProgressHUD.ShowToast ("确认密码不能为空,请输入确认密码",showToastCentered:false,timeoutMs:1000);
				return ;
			}
			if (passWord != confirmPassWord) {
				BTProgressHUD.ShowToast ("输入两次密码不一致,请检查",showToastCentered:false,timeoutMs:1000);
				return ;
			}
			if (!RegexUtil.IsPassWord (passWord)) {
				BTProgressHUD.ShowToast ("请输入正确规范用户名6-20位，建议由字母、数字和符号两种以上组成",showToastCentered:false,timeoutMs:1000);
				return;
			}

			BTProgressHUD.Show("正在提交...",-1,ProgressHUD.MaskType.Black);
			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;

			//调用restapi注册,将用户名、密码信息写
			var modipwdParam = new ModiyPasswordParam () {
				Type = sendType,Password = passWord
			};
			if (sendType == "FindPwd")
				modipwdParam.UId = phoneNumber;
			else
				modipwdParam.UId = Constants.MyInfo.UId;

			//初始化参数
			SetRestRequestParams (modipwdParam);
			var restSharpRequestUtil = new RestSharpRequestUtil(modipwdParam.Url,requestsubmitParams);
			restSharpRequestUtil.ExcuteAsync ((RestSharp.IRestResponse response) => {
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
					var setpwdJson = JsonConvert.DeserializeObject<SetPasswordJson>(result);
					if(setpwdJson.statuscode =="1")
					{

						InvokeOnMainThread(()=>
							{
								BTProgressHUD.Show(setpwdJson.message,-1,ProgressHUD.MaskType.Black);
								if(sendType =="FindPwd")
									this.NavigationController.PopToRootViewController(true);
								else
								{
									//pop to account securitycontroller
									foreach(var controller in this.NavigationController.ViewControllers)
									{
										if(controller is AccountSecurityViewController)
											this.NavigationController.PopToViewController(controller,true);
									}
								}
									

							});
					}
					else
					{
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.Show(setpwdJson.message,-1,ProgressHUD.MaskType.Black);
							});
					}


				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					InvokeOnMainThread(()=>
						{
							BTProgressHUD.ShowToast("网络超时...",showToastCentered:false,timeoutMs:1000);

						});
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
		/// <summary>
		/// Sets the rest request parameters.
		/// </summary>
		/// <param name="registerInfoParam">Register info parameter.</param>
		private void SetRestRequestParams(ModiyPasswordParam modipwdParam)
		{
			if (!requestsubmitParams.ContainsKey ("key"))
				requestsubmitParams.Add ("key", modipwdParam.Key);
			else
				requestsubmitParams ["key"] = modipwdParam.Key;

			if (!requestsubmitParams.ContainsKey ("eaction"))
				requestsubmitParams.Add ("eaction", modipwdParam.EAction);
			else
				requestsubmitParams ["eaction"] = modipwdParam.EAction;

			if (!requestsubmitParams.ContainsKey ("eUId")) 
				requestsubmitParams.Add ("eUId", modipwdParam.Euid);	
			else
				requestsubmitParams ["eUId"] = modipwdParam.Euid;

			if (!requestsubmitParams.ContainsKey ("ePassword")) 
				requestsubmitParams.Add ("ePassword", modipwdParam.Epassword);	
			else
				requestsubmitParams ["ePassword"] = modipwdParam.Epassword;


			if (!requestsubmitParams.ContainsKey ("eType"))
				requestsubmitParams.Add ("eType", modipwdParam.Etype);
			else
				requestsubmitParams ["eType"] = modipwdParam.Etype;

			if (!requestsubmitParams.ContainsKey ("md5"))
				requestsubmitParams.Add ("md5", modipwdParam.Md5);
			else
				requestsubmitParams ["md5"] = modipwdParam.Md5;

		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


