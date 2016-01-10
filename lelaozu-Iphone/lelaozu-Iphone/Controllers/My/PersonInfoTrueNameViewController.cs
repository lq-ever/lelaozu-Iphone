using System;

using UIKit;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace lelaozuIphone
{
	public partial class PersonInfoTrueNameViewController : UIViewController
	{
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		public PersonInfoTrueNameViewController () : base ("PersonInfoTrueNameViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title ="真实姓名";
			scrollView.Frame = Constants.Screen_Frame;
			txt_trueName.Text = FormatUtil.StrVaueFormat (Constants.MyInfo.TrueName);
			txt_trueName.ReturnKeyType = UIReturnKeyType.Done;
			txt_trueName.ShouldReturn = (textField) => {
				return textField.ResignFirstResponder();
			};
			btn_save.BackgroundColor = Color.Blue;
			//btn_save upside
			btn_save.TouchUpInside += (object sender, EventArgs e) => 
			{
				txt_trueName.ResignFirstResponder();
				Save();
			};
			scrollView.ContentSize = new CoreGraphics.CGSize (scrollView.Frame.Width, scrollView.Frame.Height + 10);
		}


		/// <summary>
		/// 保存
		/// </summary>
		private void Save()
		{
			var trueName = txt_trueName.Text;
			if (string.IsNullOrEmpty (trueName)) {
				BTProgressHUD.ShowToast ("真实姓名不能为空,请输入真实姓名",showToastCentered:false,timeoutMs:1000);
				return ;
			}
			if (!RegexUtil.IsTrueName (trueName)) {
				
				BTProgressHUD.ShowToast ("真实姓名不可包含字母、数字、特殊符号和非法词汇[2~8个汉字]\n",showToastCentered:false,timeoutMs:1000);
				return ;
			}
			BTProgressHUD.Show("正在保存...",-1,ProgressHUD.MaskType.Black);
			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;

			//调用restapi注册,将用户名、密码信息写
			var updateMyInfoParam = new UpdateMyInfoParam () {
				Uid = Constants.MyInfo.UId,ParamType = "TrueName",ParamValue = trueName
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
									Constants.MyInfo.TrueName = trueName;
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
}


