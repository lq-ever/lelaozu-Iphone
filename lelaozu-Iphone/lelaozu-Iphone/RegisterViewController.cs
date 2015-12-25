using System;

using UIKit;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace lelaozuIphone
{
	public partial class RegisterViewController : UIViewController
	{
		private string phoneNumber;
		private string nickName;
		private string passWord;
		private string confirmPassWord;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		public RegisterViewController () : base ("RegisterViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationController.NavigationBarHidden = false;
			this.Title = "注册";
			InitView();
			scrollView.ContentSize = new CoreGraphics.CGSize (scrollView.Frame.Width, scrollView.Frame.Height + 10);

		}
		private void InitView()
		{

			//linkAgree
			lbl_linkAgree.UserInteractionEnabled = true;
			var agreeRecognizer = new UITapGestureRecognizer ((UITapGestureRecognizer obj) => {
				this.NavigationController.PushViewController(new ServiceAgreeViewController(),true);
			});
			lbl_linkAgree.AddGestureRecognizer (agreeRecognizer);

			//btn_next
			btn_next.TouchUpInside += (object sender, EventArgs e) => 
			{
				initInput();
				if(ValidInput())
				{
					var msgContent = "我们将发送验证码短信到这个号码\n\n"+phoneNumber;
					var sendAlertContreller = UIAlertController.Create("确认手机号码",msgContent,UIAlertControllerStyle.Alert);
					sendAlertContreller.AddAction(UIAlertAction.Create("确定",UIAlertActionStyle.Default,(UIAlertAction obj) => 
						{
							SendSMS (phoneNumber);
						}));
					sendAlertContreller.AddAction(UIAlertAction.Create("取消",UIAlertActionStyle.Cancel,(UIAlertAction obj) => 
						{
						}));
					PresentViewController(sendAlertContreller,true,null);
						
				}
			};
		}

		/// <summary>
		/// Valids the input.
		/// </summary>
		/// <returns><c>true</c>, if input was valided, <c>false</c> otherwise.</returns>
		private bool ValidInput()
		{
			
			nickName = txt_registerUserName.Text;
			if (string.IsNullOrEmpty (nickName)) {
				BTProgressHUD.ShowToast ("用户名不能为空,请先填写用户名",showToastCentered:false,timeoutMs:1000);
				return false;
			}
			if (!RegexUtil.IsValidUserName (nickName)) {
				BTProgressHUD.ShowToast ("请输入规范的用户名,建议由中英文、数字、下划线组成",showToastCentered:false,timeoutMs:1000);
				return false;
			}
			passWord = txt_registerPwd.Text;
			if (string.IsNullOrEmpty (passWord)) {
				BTProgressHUD.ShowToast ("密码不能为空,请输入密码",showToastCentered:false,timeoutMs:1000);
				return false;
			}
			if (!RegexUtil.IsPassWord (passWord)) {
				BTProgressHUD.ShowToast ("请输入规范的密码,建议由字母、数字和符号两种以上组成",showToastCentered:false,timeoutMs:1000);
				return false;
			}
			confirmPassWord = txt_registerConfirmPwd.Text;
			if (string.IsNullOrEmpty (confirmPassWord)) {
				BTProgressHUD.ShowToast ("确认密码不能为空,请输入确认密码",showToastCentered:false,timeoutMs:1000);
				return false;
			}
			if (passWord != confirmPassWord) {
				BTProgressHUD.ShowToast ("输入两次密码不一致,请检查",showToastCentered:false,timeoutMs:1000);
				return false;
			}

			phoneNumber = txt_phoneNum.Text;
			if (string.IsNullOrEmpty (phoneNumber) || !RegexUtil.IsMobileNo (phoneNumber)) {
				BTProgressHUD.ShowToast ("输入正确规范的手机号,且不能为空",showToastCentered:false,timeoutMs:1000);
				return false;
			}
			return true;	
		}
		private void initInput()
		{
			phoneNumber = string.Empty;
			nickName = string.Empty;
			passWord = string.Empty;
			confirmPassWord = string.Empty;
		}
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
				PhoneNumber = phoneNumber,NickName = nickName,PassWord = passWord
			};

			//使用restsharpApi方式

			SetRestRequestParams (smsInfoParam);

			var restSharpRequestUtil = new RestSharpRequestUtil(smsInfoParam.Url,requestParams);

			restSharpRequestUtil.ExcuteAsync ((response) => {
				InvokeOnMainThread(()=>
					{
						BTProgressHUD.Dismiss();
						//在状态栏中hide使用网络指示器
						UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
					});
				if(response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					//获取并解析返回resultJson获取安全码结果值
					var result= response.Content;
					var smsJson = JsonConvert.DeserializeObject<SmsJson>(result);
					if(smsJson.statuscode =="1")
					{;
						InvokeOnMainThread(()=>
							{
								var registerResultController = new RegisterResultViewController()
								{
									PhoneNumber = phoneNumber,NickName = nickName,PassWord = passWord,SecurityCode = smsJson.data.ToString()
								};
								this.NavigationController.PushViewController(registerResultController,true);
							});
					}
					else
					{
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast(smsJson.message,showToastCentered:false,timeoutMs:1000);
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
							BTProgressHUD.ShowErrorWithStatus(response.StatusDescription,1000);
						});
				}
			});
		}

		/// <summary>
		/// 设置参数值
		/// </summary>
		/// <param name="msgInfoParam">Message info parameter.</param>
		private void SetRestRequestParams(SmsInfoParam smsInfoParam)
		{
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", smsInfoParam.Key);
			else
				requestParams ["key"] = smsInfoParam.Key;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", smsInfoParam.EAction);
			else
				requestParams ["eaction"] = smsInfoParam.EAction;
			if (!requestParams.ContainsKey ("ePhoneNumber"))
				requestParams.Add ("ePhoneNumber", smsInfoParam.EphoneNumber);
			else
				requestParams ["ePhoneNumber"] = smsInfoParam.EphoneNumber;
			if (!requestParams.ContainsKey ("ePassword"))
				requestParams.Add ("ePassword", smsInfoParam.EpassWord);
			else
				requestParams ["ePassword"] = smsInfoParam.EpassWord;
			if (!requestParams.ContainsKey ("eNickName"))
				requestParams.Add ("eNickName", smsInfoParam.EnickName);
			else
				requestParams ["eNickName"] = smsInfoParam.EnickName;
			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", smsInfoParam.Md5);
			else
				requestParams ["md5"] = smsInfoParam.Md5;

		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


