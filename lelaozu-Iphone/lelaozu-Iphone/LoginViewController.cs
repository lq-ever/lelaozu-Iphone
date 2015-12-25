﻿using System;

using UIKit;
using System.Collections.Generic;
using Newtonsoft.Json;
using Foundation;


namespace lelaozuIphone
{
	public partial class LoginViewController : UIViewController
	{
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();//请求参数

		public LoginViewController () : base ("LoginViewController", null)
		{
			
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "登录";
			InitView ();

		}
		private void InitView()
		{
			txt_Username.ReturnKeyType = UIReturnKeyType.Done;
			txt_Username.ShouldReturn = delegate(UITextField textField) {
				return textField.ResignFirstResponder ();
			};

			txt_Password.SecureTextEntry = true;
			txt_Password.ShouldReturn = (textField) => {
				return textField.ResignFirstResponder();
			};
			// remember username password
			if (true) {
				txt_Username.Text = string.IsNullOrEmpty(NSUserDefaults.StandardUserDefaults.StringForKey (Constants.Login_UserName))?string.Empty:NSUserDefaults.StandardUserDefaults.StringForKey (Constants.Login_UserName);
				txt_Password.Text = string.IsNullOrEmpty (NSUserDefaults.StandardUserDefaults.StringForKey (Constants.Login_PassWorde)) ? string.Empty : NSUserDefaults.StandardUserDefaults.StringForKey (Constants.Login_PassWorde);
			}
			//register
			btn_register.TouchUpInside += (object sender, EventArgs e) => 
			{
				this.NavigationController.PushViewController(new RegisterViewController(),true);
			};
			//forgetPwd
			btn_forgetPwd.TouchUpInside += (object sender, EventArgs e) => 
			{
				var forgetPwdController = new SendSecurityCodeController(){SendType ="",PhoneNumber= string.Empty};
				this.NavigationController.PushViewController(forgetPwdController,true);
			};
			//login
			btn_Login.TouchUpInside += (sender, e) => 
			{
				Login();
			};


		}
		/// <summary>
		/// login
		/// </summary>
		private void Login()
		{
			txt_Username.ResignFirstResponder ();
			txt_Password.ResignFirstResponder ();
			var userName = txt_Username.Text;
			var userPwd = txt_Password.Text;
			if(string.IsNullOrEmpty(userName)||string.IsNullOrEmpty(userPwd))
			{
				BTProgressHUD.ShowToast ("用户名或密码不能为空,请填写...",showToastCentered:false,timeoutMs:1000);
				return;
			}
			if (!RegexUtil.IsValidUserName (userName)) {
				
				BTProgressHUD.ShowToast ("请输入正确规范用户名，由中英文、数字、下划线组成",showToastCentered:false,timeoutMs:1000);
				return;
			}
			if (!RegexUtil.IsPassWord (userPwd)) {
				BTProgressHUD.ShowToast ( "请输入正确规范密码，由字母、数字和符号两种以上组成",showToastCentered:false,timeoutMs:1000);
				return;
			}
			BTProgressHUD.Show("正在登录中...",-1,ProgressHUD.MaskType.Black);
			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;

			var loginParam = new LoginParam () {
				LoginName = userName,LoginPwd = userPwd
			};
			//初始化请求参数
			SetRestRequestParams (loginParam);
			var restSharpRequestUtil = new RestSharpRequestUtil (loginParam.Url, requestParams);
			restSharpRequestUtil.ExcuteAsync ((response) => {
				InvokeOnMainThread(()=>
					{
						BTProgressHUD.Dismiss();
						//在状态栏中hide使用网络指示器
						UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
					});
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					//获取并解析返回resultJson获取安全码结果值
					var resultJson = response.Content;
					var loginJson = JsonConvert.DeserializeObject<LoginJson>(resultJson);
					if(loginJson.statuscode == "1")
					{
						Constants.MyInfo = loginJson.data.Table[0];
						InvokeOnMainThread(()=>
							{
								//remember usename\password
								if(true)
								{
									NSUserDefaults.StandardUserDefaults.SetString(userName,Constants.Login_UserName);
									NSUserDefaults.StandardUserDefaults.SetString(userPwd,Constants.Login_PassWorde);
								}
								// login sucess  set tabbarcontroller as  rootviewcontroller
								this.View.Window.RootViewController = new MainTabBarController();


							});
					}
					else
					{
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast(loginJson.message,showToastCentered:false,timeoutMs:1000);
							});
					}
					
				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
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


			
		/// <summary>
		/// 设置参数值
		/// </summary>
		/// <param name="msgInfoParam">Message info parameter.</param>
		private void SetRestRequestParams(LoginParam _loginParam)
		{
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", _loginParam.Key);
			else
				requestParams ["key"] = _loginParam.Key;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", _loginParam.EAction);
			else
				requestParams ["eaction"] = _loginParam.EAction;
			if (!requestParams.ContainsKey ("eLoginName"))
				requestParams.Add ("eLoginName", _loginParam.ELoginName);
			else
				requestParams ["eLoginName"] = _loginParam.ELoginName;
			if (!requestParams.ContainsKey ("eLoginPwd"))
				requestParams.Add ("eLoginPwd", _loginParam.ELoginPwd);
			else
				requestParams ["eLoginPwd"] = _loginParam.ELoginPwd;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", _loginParam.Md5);
			else
				requestParams ["md5"] = _loginParam.Md5;

		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			this.NavigationController.NavigationBarHidden = true;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


