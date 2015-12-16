using System;

using UIKit;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using CoreGraphics;

namespace lelaozuIphone
{
	public partial class AlarmDetailViewController : UIViewController
	{
		public string AlarmOrigin;
		public string AlarmId;
		private string alarmPosition = string.Empty;
		private RestSharpRequestUtil restSharpRequestUtil;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private AlarmInfoDetailParam alarmInfoDetailParam;//请求参数对象
		private List<AlarmInfoHandDetailItem> alarmInfoHandleDetailLists = new List<AlarmInfoHandDetailItem>();

		public AlarmDetailViewController () : base ("AlarmDetailViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			btn_viewMap.Hidden = true;
			btn_viewMap.TouchUpInside += (object sender, EventArgs e) => 
			{
				if(string.IsNullOrEmpty(alarmPosition )||!alarmPosition.Contains(","))
					return;
				var alarmLocationViewController = new AlarmLocationViewController(){AlarmPosition = alarmPosition};		
				alarmLocationViewController.HidesBottomBarWhenPushed = true;
				this.NavigationController.PushViewController(alarmLocationViewController,true);
			};
			loadData();
		}

		private void loadData()
		{
			if (string.IsNullOrEmpty (AlarmId))
				return;
			alarmInfoDetailParam = new AlarmInfoDetailParam (){ AId = AlarmId };

			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", alarmInfoDetailParam.Key);
			else
				requestParams ["eAId"] = alarmInfoDetailParam.Key;
			if (!requestParams.ContainsKey ("eAId"))
				requestParams.Add ("eAId",alarmInfoDetailParam.EaId);

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", alarmInfoDetailParam.EAction);
			else
				requestParams ["eaction"] = alarmInfoDetailParam.EAction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", alarmInfoDetailParam.Md5);
			else
				requestParams ["md5"] = alarmInfoDetailParam.Md5;

			//设置restsharprequest
			if (restSharpRequestUtil == null)
				restSharpRequestUtil = new RestSharpRequestUtil (alarmInfoDetailParam.Url, requestParams);
			else {
				restSharpRequestUtil.RequestParams = requestParams;
				restSharpRequestUtil.Url = alarmInfoDetailParam.Url;
			}
			//调用webservice
			restSharpRequestUtil.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{

					var result = response.Content;
					var alarmdetailInfoJson = JsonConvert.DeserializeObject<SearchAlarmDeatilInfoJson>(result);
					if(alarmdetailInfoJson.statuscode =="1")
					{
						if(alarmdetailInfoJson.data.detail.Count>0)
						{
							var detail = alarmdetailInfoJson.data.detail[0];

							InvokeOnMainThread(()=>
								{
									lbl_detail_alarmTime.Text = FormatUtil.StrToTimeFormat(detail.AlarmTime);

									lbl_detail_alarmContent.Text = FormatUtil.StrVaueFormat(detail.AlarmContent);
									lbl_detail_alarmDeviceId.Text = FormatUtil.StrVaueFormat(detail.AlarmDeviceId);
									lbl_detail_alarmPosition.Text = FormatUtil.StrVaueFormat(detail.AlarmPosition);
									alarmPosition = FormatUtil.StrVaueFormat(detail.AlarmPosition);
									if(!string.IsNullOrEmpty(alarmPosition)&& alarmPosition.Contains(","))
										btn_viewMap.Hidden = false;
									lbl_detail_alarmWay.Text = FormatUtil.StrVaueFormat(detail.AlarmWay);
									lbl_detail_cphoneNumberOne.Text = FormatUtil.StrVaueFormat(detail.CPhoneNumberOne);
									lbl_detail_cTrueName.Text = FormatUtil.StrVaueFormat(detail.CTrueName);
									lbl_detail_deviceElectricity.Text = FormatUtil.StrVaueFormat(detail.DeviceElectricity);
									lbl_detail_handleUserType.Text = FormatUtil.StrVaueFormat(detail.HandleUserType);
									lbl_detail_remark.Text = FormatUtil.StrVaueFormat(detail.Remark);
									lbl_detail_status.Text = FormatUtil.StrVaueFormat(detail.Status);
									lbl_detail_trueName.Text = FormatUtil.StrVaueFormat(detail.TrueName);
								});

						} 
						//设置报警列表处理tableview
						if(alarmdetailInfoJson.data.handdetail.Count>0)
						{
							var handleDetails = alarmdetailInfoJson.data.handdetail;
							UITableView handleTableView = new UITableView(new CGRect(0,430,375,handleDetails.Count*120));
							InvokeOnMainThread(()=>
								{
									alarmScrollView.AddSubview(handleTableView);
									alarmScrollView.ContentSize = new CGSize(Constants.Screen_Width,375+ handleDetails.Count *120);
									handleTableView.Source = new AlarmHandleSource(handleDetails);
								});

						}


					}
					else
					{
						
					}


				}
				else if(response.ResponseStatus == ResponseStatus.TimedOut)
				{
					
				}
				else
				{
					
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


