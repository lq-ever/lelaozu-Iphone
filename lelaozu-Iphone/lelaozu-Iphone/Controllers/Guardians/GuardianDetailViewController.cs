using System;

using UIKit;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace lelaozuIphone
{
	public partial class GuardianDetailViewController : UIViewController
	{
		public string UId;
		private RestSharpRequestUtil restSharpRequestUtil;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private GuardianDetailInfoParam guardianInfoDetailParam;//请求参数对象
		public GuardianDetailViewController () : base ("GuardianDetailViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "详情";
			LoadDetailData ();
			scrollView.BackgroundColor = Color.BgGray;
			scrollView.ContentSize = new CoreGraphics.CGSize (scrollView.Frame.Width, scrollView.Frame.Height + 10);
		}

		private void LoadDetailData()
		{
			if (string.IsNullOrEmpty (UId))
				return;
			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;
			BTProgressHUD.Show("正在加载用户详细数据...",-1,ProgressHUD.MaskType.Black);
			guardianInfoDetailParam = new GuardianDetailInfoParam (){ Id = UId };
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", guardianInfoDetailParam.Key);
			else
				requestParams ["eId"] = guardianInfoDetailParam.Key;
			if (!requestParams.ContainsKey ("eId"))
				requestParams.Add ("eId",guardianInfoDetailParam.Eid);

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", guardianInfoDetailParam.EAction);
			else
				requestParams ["eaction"] = guardianInfoDetailParam.EAction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", guardianInfoDetailParam.Md5);
			else
				requestParams ["md5"] = guardianInfoDetailParam.Md5;
			//设置restsharprequest
			if (restSharpRequestUtil == null)
				restSharpRequestUtil = new RestSharpRequestUtil (guardianInfoDetailParam.Url, requestParams);
			else {
				restSharpRequestUtil.RequestParams = requestParams;
				restSharpRequestUtil.Url = guardianInfoDetailParam.Url;
			}
			//调用监护人详情web服务
			restSharpRequestUtil.ExcuteAsync ((RestSharp.IRestResponse response) => {
				InvokeOnMainThread(()=>
					{
						BTProgressHUD.Dismiss();
						//在状态栏中hide使用网络指示器
						UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
					});
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{

					var result = response.Content;
					var guardianDetailInfoJson = JsonConvert.DeserializeObject<GuardianDetailInfoJson>(result);
					if(guardianDetailInfoJson.statuscode == "1")
					{
						if(guardianDetailInfoJson.data!=null && guardianDetailInfoJson.data.Count >0)
						{
							var detailItem = guardianDetailInfoJson.data[0];
							InvokeOnMainThread(()=>
								{
									lbl_TrueName.Text = FormatUtil.StrVaueFormat(detailItem.TrueName);
									lbl_Gender.Text = FormatUtil.StrVaueFormat(detailItem.Gender);
									lbl_Brnl.Text = FormatUtil.StrVaueFormat(detailItem.BRNL);
									lbl_PhoneNumberOne.Text = FormatUtil.StrVaueFormat(detailItem.PhoneNumberOne);
									lbl_IDNumber.Text =  FormatUtil.StrVaueFormat(detailItem.IDNumber);
									lbl_ContactAddress.Text = FormatUtil.StrVaueFormat(detailItem.ContactAddress);
									lbl_TelePhoneNumber.Text =FormatUtil.StrVaueFormat(detailItem.TelePhoneNumber);
									lbl_Email.Text = FormatUtil.StrVaueFormat(detailItem.Email);
									lbl_Height.Text = FormatUtil.StrVaueFormat(detailItem.Height);
									lbl_Weight.Text = FormatUtil.StrVaueFormat(detailItem.Weight);
									lbl_HereditaryDisease.Text = FormatUtil.StrVaueFormat(detailItem.HereditaryDisease);

								});

						}

					}
					else
					{
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast("获取用户详情信息失败...",showToastCentered:false,timeoutMs:1000);
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
				else{
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


