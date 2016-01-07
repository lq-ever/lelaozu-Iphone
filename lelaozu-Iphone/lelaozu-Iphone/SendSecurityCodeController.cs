using System;

using UIKit;
using Foundation;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading;



namespace lelaozuIphone
{
	public partial class SendSecurityCodeController : UIViewController
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
		private Dictionary<string,string> requestsendcodeParams = new Dictionary<string,string> ();
		private string securityCode;
		private NSTimer timer;
		private int secondsCountDown= 60;
		//NSObject observer = null;
		public SendSecurityCodeController () : base ("SendSecurityCodeController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			InitView();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.

		}
		/// <summary>
		/// Inits the view.
		/// </summary>
		private void InitView()
		{
			//default hidden
			lbl_sendCodeStatusShow.Hidden = true;
			
			if (sendType == "FindPwd") {
				this.NavigationItem.Title = "找回登录密码";
				txt_phoneNumber.Enabled = true;
				txt_phoneNumber.Placeholder = "请输入手机号";
				txt_phoneNumber.KeyboardType = UIKeyboardType.NumberPad;
				txt_phoneNumber.ReturnKeyType = UIReturnKeyType.Done;
				txt_phoneNumber.ShouldReturn = ((textField) => {
					return textField.ResignFirstResponder();
				});
			} else if (sendType == "ModifyPwd") {
				this.NavigationItem.Title = "修改登录密码";
				txt_phoneNumber.Enabled = false;
				SetPhoneNumberShow ();
			} else if (sendType == "ModifyPayPwd") {
				this.NavigationItem.Title = "设置支付密码";
				txt_phoneNumber.Enabled = false;
				SetPhoneNumberShow ();
			}

			//拨打客服
			lbl_customPhone.UserInteractionEnabled = true;
			var callPhoneRecognizer = new UITapGestureRecognizer ((UITapGestureRecognizer obj) => {
				var callUrl = new NSUrl("tel:"+lbl_customPhone.Text);
				if(!UIApplication.SharedApplication.OpenUrl(callUrl))
				{
					var callFailController = UIAlertController.Create("不支持","当前设备不支持",UIAlertControllerStyle.Alert);
					callFailController.AddAction(UIAlertAction.Create("确定",UIAlertActionStyle.Default,null));
					PresentViewController(callFailController,true,null);
				};
			});
			lbl_customPhone.AddGestureRecognizer (callPhoneRecognizer);

			//发送验证码
			btn_sendCode.Enabled = true;
			btn_sendCode.BackgroundColor = Color.Blue;
			btn_sendCode.TouchUpInside += (sender, e) => 
			{
				lbl_sendCodeStatusShow.Hidden = true;
				btn_sendCode.Enabled = false;
				btn_sendCode.BackgroundColor = Color.LightGray;
				SendCode();
			};
			//nstimer

			//txt_phonenumber
			txt_phoneNumber.KeyboardType = UIKeyboardType.NumbersAndPunctuation;
			txt_phoneNumber.ReturnKeyType = UIReturnKeyType.Done;
			txt_phoneNumber.ShouldReturn = (textField) => {
				return textField.ResignFirstResponder();
			};
			//securityCode
			txt_securityCode.ReturnKeyType = UIReturnKeyType.Done;
			txt_securityCode.KeyboardType = UIKeyboardType.NumbersAndPunctuation;
			txt_securityCode.ShouldReturn = ((textField) => {
				return textField.ResignFirstResponder();
			});

//			Action removeTextFieldObserver = () => {
//				if(observer !=null)
//					NSNotificationCenter.DefaultCenter.RemoveObserver(observer);
//			};
			NSNotificationCenter.DefaultCenter.AddObserver (UITextField.TextFieldTextDidChangeNotification, (NSNotification obj) => {
				var textField = obj.Object as UITextField;
				btn_next.Enabled = textField.Text.Length >= 1;
				btn_next.BackgroundColor = btn_next.Enabled?Color.Blue:Color.LightGray;
			}, txt_securityCode);
			//下一步
			btn_next.Enabled = false;
			btn_next.BackgroundColor = Color.LightGray;
			btn_next.TouchUpInside += (object sender, EventArgs e) => 
			{
				
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

				var setPassWordViewController = new SetPassWordViewController(){SendType = sendType};
				if(sendType == "FindPwd")
				{
					setPassWordViewController.PhoneNumber = phoneNumber;
				}
				this.NavigationController.PushViewController(setPassWordViewController,true);
			};

			scrollView.ContentSize = new CoreGraphics.CGSize (scrollView.Frame.Width, scrollView.Frame.Height + 10);

		}
		private void CreateNSTimerAndFire()
		{
			if(timer == null)
				timer = NSTimer.CreateScheduledTimer (1, this, new ObjCRuntime.Selector ("timeMethod"), null,true);
		}
		[Export("timeMethod")]
		public void TimeFireMethod()
		{
			if(secondsCountDown ==1)
			{
				timer.Invalidate ();
				timer = null;
				secondsCountDown =60;
				btn_sendCode.SetTitle("发送验证码",UIControlState.Normal);
				btn_sendCode.Enabled = true;
				btn_sendCode.BackgroundColor = Color.Blue;

			}
			else
			{
				secondsCountDown --;
				btn_sendCode.SetTitle(secondsCountDown+"秒后可重发",UIControlState.Normal);
				btn_sendCode.Enabled = false;
				btn_sendCode.BackgroundColor = Color.LightGray;
			}
		}
		private void SetPhoneNumberShow()
		{

			if (!string.IsNullOrEmpty (phoneNumber)) {
				var midleStr = phoneNumber.Substring (3, 4);
				var resultStr = phoneNumber.Replace (midleStr, "****");
				txt_phoneNumber.Text = resultStr;
			}

		}

		/// <summary>
		/// Valids the input.
		/// </summary>
		/// <returns><c>true</c>, if input was valided, <c>false</c> otherwise.</returns>
		private bool ValidInput()
		{
			if(sendType == "FindPwd")
				phoneNumber = txt_phoneNumber.Text;
			if (string.IsNullOrEmpty (phoneNumber) || !RegexUtil.IsMobileNo (phoneNumber)) {
				BTProgressHUD.ShowToast ("输入正确规范的手机号,且不能为空",showToastCentered:false,timeoutMs:1000);
				return false;
			}
			return true;
		}

		/// <summary>
		/// 发送验证码
		/// </summary>
		private void SendCode()
		{
			if (!ValidInput ()) {
				return;
			}

			BTProgressHUD.Show("正在发送验证码...",-1,ProgressHUD.MaskType.Black);
			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;

			var sendCodeParam = new SendCodeParam () {
				PhoneNumberOne = phoneNumber,Type = sendType
			};
			//使用restsharpApi方式
			SetRestRequestSendCodeParams (sendCodeParam);
			var restSharpRequestUtil = new RestSharpRequestUtil(sendCodeParam.Url,requestsendcodeParams);
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
					var sendCodeJson = JsonConvert.DeserializeObject<SendCodeJson>(result);
					if(sendCodeJson.statuscode =="1")
					{
						InvokeOnMainThread(()=>
							{
								
								securityCode = sendCodeJson.data.ToString();
								BTProgressHUD.ShowToast("验证码发送成功...",showToastCentered:false,timeoutMs:1000);
								lbl_sendCodeStatusShow.Hidden = false;
								CreateNSTimerAndFire();
							});
					}
					else
					{
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast(sendCodeJson.message,showToastCentered:false,timeoutMs:1000);
								btn_sendCode.Enabled = true;
								btn_sendCode.BackgroundColor = Color.Blue;
							});
					}
				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					InvokeOnMainThread(()=>
						{
							BTProgressHUD.ShowToast("网络超时...",showToastCentered:false,timeoutMs:1000);
							btn_sendCode.Enabled = true;
							btn_sendCode.BackgroundColor = Color.Blue;
						});
				}
				else
				{
					InvokeOnMainThread(()=>
						{
							BTProgressHUD.ShowErrorWithStatus(Constants.ErrorStatusDes,1000);
							btn_sendCode.Enabled = true;
							btn_sendCode.BackgroundColor = Color.Blue;
						});

				}
			});
		}

		/// <summary>
		/// 设置发送短信参数值
		/// </summary>
		/// <param name="msgInfoParam">Message info parameter.</param>
		private void SetRestRequestSendCodeParams(SendCodeParam sendcodeParam)
		{
			if (!requestsendcodeParams.ContainsKey ("key"))
				requestsendcodeParams.Add ("key", sendcodeParam.Key);
			else
				requestsendcodeParams ["key"] = sendcodeParam.Key;

			if (!requestsendcodeParams.ContainsKey ("eaction"))
				requestsendcodeParams.Add ("eaction", sendcodeParam.EAction);
			else
				requestsendcodeParams ["eaction"] = sendcodeParam.EAction;

			if (!requestsendcodeParams.ContainsKey ("ePhoneNumberOne"))
				requestsendcodeParams.Add ("ePhoneNumberOne", sendcodeParam.EphoneNumberOne);
			else
				requestsendcodeParams ["ePhoneNumberOne"] = sendcodeParam.EphoneNumberOne;
			if (!requestsendcodeParams.ContainsKey ("eType"))
				requestsendcodeParams.Add ("eType", sendcodeParam.Etype);
			else
				requestsendcodeParams ["eType"] = sendcodeParam.Etype;
			if (!requestsendcodeParams.ContainsKey ("md5"))
				requestsendcodeParams.Add ("md5", sendcodeParam.Md5);
			else
				requestsendcodeParams ["md5"] = sendcodeParam.Md5;



		}
		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			if (timer != null)
				timer.Invalidate ();
		}
	}
}


