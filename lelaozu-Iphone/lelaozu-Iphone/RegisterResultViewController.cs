using System;

using UIKit;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using Foundation;
using JPush;



namespace lelaozuIphone
{
	public partial class RegisterResultViewController : UIViewController
	{
		private string phoneNumber;
		private string nickName;
		private string passWord;
		private string securityCode;

		public string PhoneNumber {
			get{
				return phoneNumber;
			}
			set{
				phoneNumber = value;
			}
		}
		public string NickName {
			get {
				return nickName;
			}
			set{
				nickName = value;
			}
		}
		public string PassWord
		{
			get{
				return passWord;
			}
			set{
				passWord = value;
			}
		}
		public string SecurityCode
		{
			get{
				return securityCode;
			}
			set{
				securityCode = value;
			}
		}

		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private Dictionary<string,string> requestSmsParams = new Dictionary<string, string>();

		private NSTimer timer;

		private int SecondsCountDown= 60;
		//NSObject observer = null;

		private string guidAsAlias = string.Empty;
		public RegisterResultViewController () : base ("RegisterResultViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "填写短信验证码";

			//set the phoneNumber
			if (!string.IsNullOrEmpty (phoneNumber))
				txt_phoneNumber.Text = phoneNumber;
			txt_phoneNumber.Enabled = false;

			//default hidden
			lbl_sendCodeStatusShow.Hidden = true;

			//nstimer

			//start timer
			CreateNSTimerAndFire ();

			//sendCode发送验证码
			btn_send.Enabled = false;
			btn_send.BackgroundColor = Color.LightGray;
			btn_send.TouchUpInside += (object sender, EventArgs e) => 
			{
				lbl_sendCodeStatusShow.Hidden = true;
				btn_send.Enabled = false;
				SendSMS(phoneNumber);
			};

//			Action removeTextFieldObserver = () => {
//				if(observer !=null)
//					NSNotificationCenter.DefaultCenter.RemoveObserver(observer);
//			};
			 NSNotificationCenter.DefaultCenter.AddObserver (UITextField.TextFieldTextDidChangeNotification, (NSNotification obj) => {
				var textField = obj.Object as UITextField;
			
				btn_submit.Enabled = textField.Text.Length >= 1;
				btn_submit.BackgroundColor = btn_submit.Enabled?Color.Blue:Color.LightGray;
			}, txt_securityCode);

			txt_securityCode.ReturnKeyType = UIReturnKeyType.Done;
			txt_securityCode.KeyboardType = UIKeyboardType.NumbersAndPunctuation;

			txt_securityCode.ShouldReturn = ((textField) => {
				return textField.ResignFirstResponder();
			});


			//register
			btn_submit.Enabled = false;
			btn_submit.BackgroundColor = Color.LightGray;
			btn_submit.TouchUpInside += (object sender, EventArgs e) => 
			{
				
				txt_securityCode.ResignFirstResponder();
				var inputCode = txt_securityCode.Text;

				if(string.IsNullOrEmpty(inputCode) || !RegexUtil.IsSecurityCode(inputCode))
				{
					BTProgressHUD.ShowToast ("请输入接收到的手机验证码,且不能为空",showToastCentered:false,timeoutMs:1000);
					return ;
				}
				if(inputCode!=securityCode)
				{
					BTProgressHUD.ShowToast ("输入验证码不正确,请重新填写",showToastCentered:false,timeoutMs:1000);
					return;
				}
				Reister();
			};

		}


		private void CreateNSTimerAndFire()
		{
			if(timer == null)
				timer = NSTimer.CreateScheduledTimer (1, this, new ObjCRuntime.Selector ("timeMethod"), null,true);
		}
		[Export("timeMethod")]
		public void TimeFireMethod()
		{
			if(SecondsCountDown ==1)
			{
				timer.Invalidate ();
				timer = null;
				SecondsCountDown =60;
				btn_send.SetTitle("发送验证码",UIControlState.Normal);
				btn_send.Enabled = true;
				btn_send.BackgroundColor = Color.Blue;


			}
			else
			{
				SecondsCountDown --;
				btn_send.SetTitle(SecondsCountDown+"秒后可重发",UIControlState.Normal);
				btn_send.Enabled = false;
				btn_send.BackgroundColor = Color.LightGray;
			}
		}

		#region 重新发送验证码

		/// <summary>
		/// 发送消息
		/// </summary>
		/// <param name="phoneNum">Phone number.</param>
		private void SendSMS(string _phoneNumber)
		{
			

			BTProgressHUD.Show("正在发送验证码...",-1,ProgressHUD.MaskType.Black);
			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;

			var smsInfoParam = new SmsInfoParam () {
				PhoneNumber = _phoneNumber,NickName = nickName,PassWord = passWord
			};

			//使用restsharpApi方式

			SetRestRequestParams (smsInfoParam);

			var restSharpRequestHelp = new RestSharpRequestUtil(smsInfoParam.Url,requestSmsParams);

			restSharpRequestHelp.ExcuteAsync ((response) => {
				InvokeOnMainThread(()=>
					{
						BTProgressHUD.Dismiss();
						//在状态栏中hide使用网络指示器
						UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
					});
				if(response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{

					//获取并解析返回resultJson获取安全码结果值
					var resultJson = response.Content;
					var smsJson = JsonConvert.DeserializeObject<SmsJson>(resultJson);
					if(smsJson.statuscode =="1")
					{
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.Show("验证码发送成功...",-1,ProgressHUD.MaskType.Black);
								//start timer
								timer.Fire();
								securityCode = smsJson.data.ToString();
								lbl_sendCodeStatusShow.Hidden = false;
							});
					}

					else
					{
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast(smsJson.message,showToastCentered:false,timeoutMs:1000);
								btn_send.Enabled = true;
							});
					}
				}
				else if(response.ResponseStatus == ResponseStatus.TimedOut)
				{
					InvokeOnMainThread(()=>
						{
							BTProgressHUD.ShowToast("网络超时...",showToastCentered:false,timeoutMs:1000);
							btn_send.Enabled = true;
						}
					);
				}
				else
				{
					InvokeOnMainThread(()=>
						{
							BTProgressHUD.ShowErrorWithStatus(Constants.ErrorStatusDes,2000);
							btn_send.Enabled = true;
						});
				}

			});
		}



		/// <summary>
		/// 设置发送短信参数值
		/// </summary>
		/// <param name="msgInfoParam">Message info parameter.</param>
		private void SetRestRequestParams(SmsInfoParam smsInfoParam)
		{
			if (!requestSmsParams.ContainsKey ("key"))
				requestSmsParams.Add ("key", smsInfoParam.Key);
			else
				requestSmsParams ["key"] = smsInfoParam.Key;

			if (!requestSmsParams.ContainsKey ("eaction"))
				requestSmsParams.Add ("eaction", smsInfoParam.EAction);
			else
				requestSmsParams ["eaction"] = smsInfoParam.EAction;
			if (!requestSmsParams.ContainsKey ("ePhoneNumber"))
				requestSmsParams.Add ("ePhoneNumber", smsInfoParam.EphoneNumber);
			else
				requestSmsParams ["ePhoneNumber"] = smsInfoParam.EphoneNumber;
			if (!requestSmsParams.ContainsKey ("ePassword"))
				requestSmsParams.Add ("ePassword", smsInfoParam.EpassWord);
			else
				requestSmsParams ["ePassword"] = smsInfoParam.EpassWord;
			if (!requestSmsParams.ContainsKey ("eNickName"))
				requestSmsParams.Add ("eNickName", smsInfoParam.EnickName);
			else
				requestSmsParams ["eNickName"] = smsInfoParam.EnickName;
			if (!requestSmsParams.ContainsKey ("md5"))
				requestSmsParams.Add ("md5", smsInfoParam.Md5);
			else
				requestSmsParams ["md5"] = smsInfoParam.Md5;



		}

		#endregion


		#region 注册

		/// <summary>
		/// Reister this instance.
		/// </summary>
		private void Reister()
		{
			guidAsAlias = string.Empty;
			BTProgressHUD.Show("正在注册...",-1,ProgressHUD.MaskType.Black);
			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;


			//todo:调用restapi注册,将用户名、密码信息写
			var registerInfoParam = new RegisterInfoParam () {
				PhoneNumber = phoneNumber,NickName = nickName,PassWord = passWord
			};

			//初始化参数
			SetRestRequestParams (registerInfoParam);

			var restSharpRequestUtil = new RestSharpRequestUtil(registerInfoParam.Url,requestParams);
			restSharpRequestUtil.ExcuteAsync ((response) => {
				InvokeOnMainThread(()=>
					{
						BTProgressHUD.Dismiss();
						//在状态栏中hide使用网络指示器
						UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
					});
				if(response.ResponseStatus == ResponseStatus.Completed &&response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					//获取并解析返回resultJson获取Guid结果值

					var resultJson = response.Content;
					var registerJson = JsonConvert.DeserializeObject<RegisterJson>(resultJson);
					if(registerJson.statuscode=="1")
					{
						Constants.MyInfo = registerJson.data.Table[0];

						var Uid = Constants.MyInfo.UId;
						var alias = Uid.Replace("-","_");
						//注册用户成功，写极光推送别名,进入主界面
						InvokeOnMainThread(()=>
							{
								//调用极光接口设置别名
								SetAlias(alias);
								//save username and password 
								NSUserDefaults.StandardUserDefaults.SetString(nickName,Constants.Login_UserName);
								NSUserDefaults.StandardUserDefaults.SetString(passWord,Constants.Login_PassWorde);
								NSUserDefaults.StandardUserDefaults.SetBool(true,Constants.Remember_Check);

								//set hasLogin true
								Constants.HasLogin =true;
								this.View.Window.RootViewController = new MainTabBarController();
							});

					}
					else
					{
						//注册失败
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast(registerJson.message,showToastCentered:false,timeoutMs:1000);
							});
					}


				}
				else if(response.ResponseStatus == ResponseStatus.TimedOut)
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
							BTProgressHUD.ShowErrorWithStatus(Constants.ErrorStatusDes,2000);
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
		/// Sets the rest request parameters.
		/// </summary>
		/// <param name="registerInfoParam">Register info parameter.</param>
		private void SetRestRequestParams(RegisterInfoParam registerInfoParam)
		{
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", registerInfoParam.Key);
			else
				requestParams ["key"] = registerInfoParam.Key;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", registerInfoParam.EAction);
			else
				requestParams ["eaction"] = registerInfoParam.EAction;

			if (!requestParams.ContainsKey ("ePhoneNumber"))
				requestParams.Add ("ePhoneNumber", registerInfoParam.EphoneNumber);
			else
				requestParams ["ePhoneNumber"] = registerInfoParam.EphoneNumber;

			if (!requestParams.ContainsKey ("ePassword"))
				requestParams.Add ("ePassword", registerInfoParam.EpassWord);
			else
				requestParams ["ePassword"] = registerInfoParam.EpassWord;

			if (!requestParams.ContainsKey ("eNickName"))
				requestParams.Add ("eNickName", registerInfoParam.EnickName);
			else
				requestParams ["eNickName"] = registerInfoParam.EnickName;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", registerInfoParam.Md5);
			else
				requestParams ["md5"] = registerInfoParam.Md5;


		}
		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			if (timer != null)
				timer.Invalidate ();
			
		}

		#endregion
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


