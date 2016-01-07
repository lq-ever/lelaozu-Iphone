using System;

using UIKit;
using System.Collections.Generic;
using Newtonsoft.Json;
using Foundation;
using JPush;


namespace lelaozuIphone
{
	public partial class LoginViewController : UIViewController
	{
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();//请求参数

		public LoginViewController () : base ("LoginViewController", null)
		{
			
		}
		private string guidAsAlias = string.Empty;
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "登录";
			this.NavigationController.NavigationBar.BarTintColor = Color.Blue;
			this.NavigationController.NavigationBar.Translucent = false;
			this.NavigationController.NavigationBar.TintColor = UIColor.White;
			var titleAttributs = new UIStringAttributes ();
			titleAttributs.ForegroundColor = UIColor.White;
			titleAttributs.Font = UIFont.SystemFontOfSize(20f);
			this.NavigationController.NavigationBar.TitleTextAttributes = titleAttributs;

			InitView ();

		}
		private void InitView()
		{
			txt_Username.ReturnKeyType = UIReturnKeyType.Done;
			txt_Username.KeyboardType = UIKeyboardType.Default;
			txt_Username.ShouldReturn = delegate(UITextField textField) {
				return textField.ResignFirstResponder ();
			};

			txt_Password.ReturnKeyType = UIReturnKeyType.Done;
			txt_Password.SecureTextEntry = true;
			txt_Password.ShouldReturn = (textField) => {
				return textField.ResignFirstResponder();
			};

			//check password default true 记住密码
			//cb_password.ButtonType = UIButtonType.Custom;
			cb_password.SetImage(UIImage.FromFile("ic_register_combox_normal.png"),UIControlState.Normal);
			cb_password.SetImage(UIImage.FromFile("ic_register_combox_selected.png"),UIControlState.Selected);
			cb_password.Selected = true;
			cb_password.AddTarget ((sender, e) => {
				cb_password.Selected =!cb_password.Selected;
				if(cb_password.Selected)
					NSUserDefaults.StandardUserDefaults.SetBool(true,Constants.Remember_Check);
				else
					NSUserDefaults.StandardUserDefaults.SetBool(false,Constants.Remember_Check);
					
			}, UIControlEvent.TouchUpInside);

		

			// remember username password如果选择了记住密码
			if (NSUserDefaults.StandardUserDefaults.BoolForKey (Constants.Remember_Check)) {
				cb_password.Selected = true;
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
				var forgetPwdController = new SendSecurityCodeController(){SendType ="FindPwd",PhoneNumber= string.Empty};
				this.NavigationController.PushViewController(forgetPwdController,true);
			};
			//login
			btn_Login.TouchUpInside += (sender, e) => 
			{
				txt_Username.ResignFirstResponder();
				txt_Password.ResignFirstResponder();
				Login();
			};
//			//键盘将要显示时候
//			UIKeyboard.Notifications.ObserveWillShow ((sender, e) => {
//				var kbdBounds = e.FrameEnd;
//				CoreGraphics.CGRect txtFrame;
//				if(txt_Username.IsFirstResponder)
//				{
//					txtFrame = txt_Username.Frame;
//					txtFrame.Y -= kbdBounds.Height;
//					txt_Username.Frame = txtFrame;
//				}
//				else
//				{
//					txtFrame = txt_Password.Frame;
//					txtFrame.Y -= kbdBounds.Height;
//					txt_Password.Frame = txtFrame;
//				}
//			});
//			//键盘将要消失时候
//			UIKeyboard.Notifications.ObserveDidHide ((sender, e) => {
//				var kbdBounds = e.FrameEnd;
//				CoreGraphics.CGRect txtFrame;
//				if(txt_Username.IsFirstResponder)
//				{
//					txtFrame = txt_Username.Frame;
//					txtFrame.Y += kbdBounds.Height;
//					txt_Username.Frame = txtFrame;
//				}
//				else
//				{
//					txtFrame = txt_Password.Frame;
//					txtFrame.Y += kbdBounds.Height;
//					txt_Password.Frame = txtFrame;
//				}
//			});

			scrollView.ContentSize = new CoreGraphics.CGSize (scrollView.Frame.Width, scrollView.Frame.Height + 10);
		}
		/// <summary>
		/// login
		/// </summary>
		private void Login()
		{

			guidAsAlias = string.Empty;
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
						var Uid = Constants.MyInfo.UId;
						var alias = Uid.Replace("-","_");

						InvokeOnMainThread(()=>
							{
								//调用极光接口设置别名
								SetAlias(alias);

								//remember usename\password
								if(cb_password.Selected)
								{
									NSUserDefaults.StandardUserDefaults.SetString(userName,Constants.Login_UserName);
									NSUserDefaults.StandardUserDefaults.SetString(userPwd,Constants.Login_PassWorde);
									NSUserDefaults.StandardUserDefaults.SetBool(true,Constants.Remember_Check);
								}
								//set hasLogin true
								Constants.HasLogin =true;
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
							BTProgressHUD.ShowErrorWithStatus(Constants.ErrorStatusDes,1000);
						});
				}

			});

		}
		/// <summary>
		/// Sets the alias.设置别名
		/// </summary>
		/// <param name="alias">Alias.</param>
		private void SetAlias(string alias)
		{
			if(string.IsNullOrEmpty(alias))
				return;
			if(!RegexUtil.IsValidTagAndAlias(alias))
				return;
			//判断是否已经设置过别名，若设置过，将不在设置
			var jpush_alias = NSUserDefaults.StandardUserDefaults.StringForKey (Constants.JPush_Alias);
			if (alias == jpush_alias)
				return;
			guidAsAlias = alias;
			//调用极光接口设置别名
			APService.SetAlias(guidAsAlias,new ObjCRuntime.Selector ("tagsAliasCallback:tags:alias:"),this);

		}
		/// <summary>
		/// Tagses the alias callback.注册极光别名回调函数
		/// </summary>
		/// <param name="iResCode">I res code.</param>
		/// <param name="tags">Tags.</param>
		/// <param name="alias">Alias.</param>
	    [Export("tagsAliasCallback:tags:alias:")]
		public void tagsAliasCallback(int iResCode,NSSet tags,NSString alias)
		{
			Console.WriteLine (string.Format ("resultcode:{0};nsstring alias {1}",iResCode,alias));
			if (iResCode == 0) {
				Console.WriteLine ("register alias sucess");
				//write userdefaults
				NSUserDefaults.StandardUserDefaults.SetString (guidAsAlias, Constants.JPush_Alias);
			}
			else
				//调用极光接口设置别名
				APService.SetAlias(guidAsAlias,new ObjCRuntime.Selector ("tagsAliasCallback:tags:alias:"),this);
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
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			this.NavigationController.SetNavigationBarHidden( true,true);

		}
		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			this.NavigationController.SetNavigationBarHidden(false,true);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

				
	}
}


