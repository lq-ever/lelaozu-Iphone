using System;

using UIKit;
using System.Collections.Generic;
using MJRefresh;
using Newtonsoft.Json;
using Foundation;

namespace lelaozuIphone
{
	public partial class OtherAlarmViewController : UIViewController
	{
		private string defaultStartTime,defaultEndTime;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private AlarmInfoListParam alarmInfoListParam;//请求参数对象
		private int pageIndex =1;//当前页码
		private RestSharpRequestUtil restSharpRequestUtil;
		private int total;//总记录数
		private List<AlarmInfoListItem> alarmInfoLists = new List<AlarmInfoListItem>();
		private List<AllMyUserListItem> myUserLists;//我的监护人列表
		private SearchAllMyUserParam myUserParam = new SearchAllMyUserParam(){UserId = Constants.MyInfo.UId};//我的监护人请求参数对象
		private Dictionary<string,string> myUserRequestParams = new Dictionary<string, string>();//监护人web请求
		private string myUserId;//选择的监护人
		private bool btnSearchFlag = false;//监听是否点击查询
		private bool IsRefreshing = false;//是否正在获取数据

		MJRefreshNormalHeader header;
		MJRefreshAutoNormalFooter footer;
		private AlarmTableSource alarmSource;
		private List<AlarmTypeItem> alarmTypeList;
		private string alarmTypeId;//选择的报警类型


		private UIAlertController alertdateController;//日期controller
		private UIDatePicker datePicker;// 日期控件
		private UIAlertController alertAlarmTypeController;//报警方式controller
		private UIPickerView pickerView;//报警方式 pickerView

		public OtherAlarmViewController () : base ("OtherAlarmViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			InitView();
		}
		private void InitView()
		{
			defaultEndTime = DateTime.Now.ToString ("yyyy-MM-dd");
			defaultStartTime = DateTime.Now.AddDays (-7).ToString ("yyyy-MM-dd");
			txt_endTime.Text = defaultEndTime;
			txt_startTime.Text = defaultStartTime;

			//set alamtime datepicker
			txt_startTime.ShouldBeginEditing = (textField) => {
				if(alertdateController==null && datePicker==null)
				{
					alertdateController = UIAlertController.Create("请选择日期","\n\n\n\n\n\n\n\n",UIAlertControllerStyle.ActionSheet);
					datePicker = new UIDatePicker();
					datePicker.Mode = UIDatePickerMode.Date;
					datePicker.Locale = NSLocale.FromLocaleIdentifier("zh_Hans_CN");
					alertdateController.View.AddSubview(datePicker);
					var formater = new  NSDateFormatter();
					formater.DateFormat = "yyyy-MM-dd";
					alertdateController.AddAction(UIAlertAction.Create("确定",UIAlertActionStyle.Default,(Action)=>
						{
							textField.Text = formater.StringFor(datePicker.Date);
						}));
					alertdateController.AddAction(UIAlertAction.Create("取消",UIAlertActionStyle.Cancel,(Action)=>
						{
						}));
				}

				PresentViewController(alertdateController,true,null);
				return textField.ResignFirstResponder();
			};

			txt_endTime.ShouldBeginEditing = (textField) => {
				if(alertdateController==null && datePicker==null)
				{
					alertdateController = UIAlertController.Create("请选择日期","\n\n\n\n\n\n\n\n",UIAlertControllerStyle.ActionSheet);
					datePicker = new UIDatePicker();
					datePicker.Mode = UIDatePickerMode.Date;
					datePicker.Locale = NSLocale.FromLocaleIdentifier("zh_Hans_CN");
					alertdateController.View.AddSubview(datePicker);
					var formater = new  NSDateFormatter();
					formater.DateFormat = "yyyy-MM-dd";
					alertdateController.AddAction(UIAlertAction.Create("确定",UIAlertActionStyle.Default,(Action)=>
						{
							textField.Text = formater.StringFor(datePicker.Date);
						}));
					alertdateController.AddAction(UIAlertAction.Create("取消",UIAlertActionStyle.Cancel,(Action)=>
						{
						}));
				}

				PresentViewController(alertdateController,true,null);
				return textField.ResignFirstResponder();
			};

			alarmInfoListParam =  new AlarmInfoListParam();
			alarmSource = new AlarmTableSource (alarmInfoLists, this, tableView);
			tableView.Source = alarmSource;
			btn_search.TouchUpInside += (object sender, EventArgs e) => 
			{
				btnSearchFlag = true;
				LoadData();
			};

			header = new MJRefreshNormalHeader();
			header.SetTitle(Constants.PullDownLbl, MJRefreshState.Idle);
			header.SetTitle(Constants.PullDownReleaseLbl, MJRefreshState.Pulling);
			header.SetTitle(Constants.PullDownRefreshLbl, MJRefreshState.Refreshing);
			header.LastUpdatedTimeLabel.Hidden = true;
			header.RefreshingBlock = () =>  {
				OnPullDownToRefresh();
			};
			tableView.SetHeader (header);

			footer = new MJRefreshAutoNormalFooter ();
			footer.SetTitle(Constants.PullUpLbl, MJRefreshState.Idle);
			footer.SetTitle(Constants.PullUpRefreshLbl, MJRefreshState.Refreshing);
			footer.RefreshingBlock = () => {
				OnPullUpToRefresh();
			};
			tableView.SetFooter (footer);



			InitAlarmTypePicker();
			InitUserPicker ();

			//set myUserController
			txt_MyUser.ShouldBeginEditing = (textField) => {
				AllMyUserListItem selectItem = null;
				var alertMyUserController = UIAlertController.Create("选择我的监护人","\n\n\n\n\n\n\n\n",UIAlertControllerStyle.ActionSheet);
				var pickerView = new UIPickerView();
				var userPickModel = new CustomPickerModel<AllMyUserListItem>(myUserLists);

				userPickModel.PickerAction =(item)=>
				{
					selectItem = item;
				};

				pickerView.Model = userPickModel;

				alertMyUserController.AddAction(UIAlertAction.Create("确定",UIAlertActionStyle.Default,(Action)=>
					{
						if(selectItem!=null)
						{
							myUserId = selectItem.UId;
							textField.Text = selectItem.TrueName;
						}
					}));
				alertMyUserController.AddAction(UIAlertAction.Create("取消",UIAlertActionStyle.Cancel,(Action)=>
					{
					}));
				alertMyUserController.View.AddSubview(pickerView);
				PresentViewController(alertMyUserController,true,null);
				return textField.ResignFirstResponder();

			};


		}
		/// <summary>
		/// 初始化报警类型
		/// </summary>
		private void InitAlarmTypePicker()
		{
			alarmTypeList = new List<AlarmTypeItem> ()
			{
				new AlarmTypeItem(){AlarmTypeId="0",AlarmTypeDesc="PAUL报警"},new AlarmTypeItem(){AlarmTypeId="1",AlarmTypeDesc="摔倒报警"},
				new AlarmTypeItem(){AlarmTypeId="1002",AlarmTypeDesc="紧急求助报警"},new AlarmTypeItem(){AlarmTypeId="1003",AlarmTypeDesc="无活动报警"},
				new AlarmTypeItem(){AlarmTypeId="1011",AlarmTypeDesc="防盗报警"},new AlarmTypeItem(){AlarmTypeId="1012",AlarmTypeDesc="火灾报警"},
				new AlarmTypeItem(){AlarmTypeId="1013",AlarmTypeDesc="燃气泄漏报警"}
			};
			alarmTypeId = alarmTypeList [0].AlarmTypeId;
			txt_alarmType.Text = alarmTypeList [0].AlarmTypeDesc;

			//set alarmtype 
			txt_alarmType.ShouldBeginEditing = (textField) => {
				AlarmTypeItem selectItem = null;
				if(alertAlarmTypeController ==null && pickerView ==null)
				{
					alertAlarmTypeController = UIAlertController.Create("选择报警类型\n\n\n\n\n\n\n\n","",UIAlertControllerStyle.ActionSheet);
					pickerView = new UIPickerView();
					var alarmTypeModel = new CustomPickerModel<AlarmTypeItem>(alarmTypeList);
					alarmTypeModel.PickerAction = (item)=>
					{
						selectItem = item;
					};
					pickerView.Model = alarmTypeModel;

					alertAlarmTypeController.View.AddSubview(pickerView);
					alertAlarmTypeController.AddAction(UIAlertAction.Create("确定",UIAlertActionStyle.Default,(Action)=>
						{
							if(selectItem!=null)
							{
								alarmTypeId = selectItem.AlarmTypeId;
								textField.Text = selectItem.AlarmTypeDesc;
							}
						}));
					alertAlarmTypeController.AddAction(UIAlertAction.Create("取消",UIAlertActionStyle.Cancel,(Action)=>
						{
						}));

				}
				PresentViewController(alertAlarmTypeController,true,null);
				return textField.ResignFirstResponder();
			};
		}

		/// <summary>
		/// 获取我的监护人数据
		/// </summary>
		private void InitUserPicker()
		{
			if (!myUserRequestParams.ContainsKey ("eUserId"))
				myUserRequestParams.Add ("eUserId", myUserParam.EuserId);
			else
				myUserRequestParams ["eUserId"] = myUserParam.EuserId;

			if (!myUserRequestParams.ContainsKey ("eaction"))
				myUserRequestParams.Add ("eaction", myUserParam.EAction);
			else
				myUserRequestParams ["eaction"] = myUserParam.EAction;

			if (!myUserRequestParams.ContainsKey ("md5"))
				myUserRequestParams.Add ("md5", myUserParam.Md5);
			else
				myUserRequestParams ["md5"] = myUserParam.Md5;

			if (!myUserRequestParams.ContainsKey ("key"))
				myUserRequestParams.Add ("key", myUserParam.Key);
			else
				myUserRequestParams ["key"] = myUserParam.Key;
			//设置restsharprequest
			if (restSharpRequestUtil == null)
				restSharpRequestUtil = new RestSharpRequestUtil (myUserParam.Url, myUserRequestParams);
			else {
				restSharpRequestUtil.Url = myUserParam.Url;
				restSharpRequestUtil.RequestParams = myUserRequestParams;
			}
			restSharpRequestUtil.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					var result = response.Content;
					var searchMyUserJson = JsonConvert.DeserializeObject<SearchAllMyUserJson>(result);
					if(searchMyUserJson.statuscode == "1")
					{
						myUserLists = searchMyUserJson.data;
						InvokeOnMainThread(()=>
							{
								//设置默认值
								if(myUserLists.Count>0)
								{
									myUserId = myUserLists[0].UId;
									txt_MyUser.Text = myUserLists[0].TrueName;
								}
								//第一次进入自动刷新
								header.BeginRefreshing();
							});

					}
				}
				else
				{

				}

			});

		}
		/// <summary>
		/// Loads the data.
		/// </summary>
		private void LoadData()
		{
			if (string.IsNullOrEmpty (myUserId)) {
				header.EndRefreshing ();
				IsRefreshing = false;
				return;
			}
			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;
			if(btnSearchFlag)
				BTProgressHUD.Show("正在查询报警信息...",-1,ProgressHUD.MaskType.None);
			pageIndex =1;
			UpdateAlarmInfoListParam ();
			//调用webservice获取数据
			restSharpRequestUtil.ExcuteAsync ((response) => {
				InvokeOnMainThread(()=>
					{
						BTProgressHUD.Dismiss();
						//在状态栏中hide使用网络指示器
						UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
					});
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK )
				{
					var result = response.Content;
					var alarmlistInfoJson = JsonConvert.DeserializeObject<SearchAlarmInfoJson>(result);
					if(alarmlistInfoJson.statuscode == "1")
					{
						total =  alarmlistInfoJson.data.total;
						alarmInfoLists = alarmlistInfoJson.data.items;
						InvokeOnMainThread(()=>
							{
								alarmSource.alarmList.Clear();
								alarmSource.alarmList.AddRange(alarmInfoLists);
								tableView.ReloadData();
							});

					}
					else
					{
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast("获取报警列表信息错误",showToastCentered:false,timeoutMs:1000);
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
							BTProgressHUD.ShowErrorWithStatus(response.StatusDescription,1000);
						});
				}
				InvokeOnMainThread(()=>
					{
						header.EndRefreshing();
						IsRefreshing = false;

					});
			});
		}
		/// <summary>
		/// 更新参数请求对象
		/// </summary>
		private void UpdateAlarmInfoListParam()
		{
			alarmInfoListParam.UserId = myUserId;
			alarmInfoListParam.PageIndex = pageIndex.ToString();
			alarmInfoListParam.StartTime = string.IsNullOrEmpty( txt_startTime.Text)?defaultStartTime:txt_startTime.Text;
			alarmInfoListParam.EndTime = string.IsNullOrEmpty( txt_endTime.Text)?defaultEndTime:txt_endTime.Text;
			alarmInfoListParam.AlarmType = alarmTypeId;
			SetRestRequestParams ();
		}
		/// <summary>
		/// 设置参数值
		/// </summary>
		/// <param name="msgInfoParam">Message info parameter.</param>
		private void SetRestRequestParams()
		{
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", alarmInfoListParam.Key);
			else
				requestParams ["key"] = alarmInfoListParam.Key;

			if (!requestParams.ContainsKey ("eAlarmType"))
				requestParams.Add ("eAlarmType", alarmInfoListParam.EalarmType);
			else
				requestParams ["eAlarmType"] = alarmInfoListParam.EalarmType;

			if (!requestParams.ContainsKey ("eUserId"))
				requestParams.Add ("eUserId", alarmInfoListParam.EuserId);
			else
				requestParams ["eUserId"] = alarmInfoListParam.EuserId;

			if (!requestParams.ContainsKey ("eStartTime"))
				requestParams.Add ("eStartTime", alarmInfoListParam.EstartTime);
			else
				requestParams ["eStartTime"] = alarmInfoListParam.EstartTime;

			if (!requestParams.ContainsKey ("eEndTime"))
				requestParams.Add ("eEndTime", alarmInfoListParam.EendTime);
			else
				requestParams ["eEndTime"] = alarmInfoListParam.EendTime;

			if (!requestParams.ContainsKey ("ePageIndex"))
				requestParams.Add ("ePageIndex", alarmInfoListParam.EpageIndex);
			else
				requestParams ["ePageIndex"] = alarmInfoListParam.EpageIndex;

			if (!requestParams.ContainsKey ("ePageSize"))
				requestParams.Add ("ePageSize", alarmInfoListParam.EpageSize);
			else
				requestParams ["ePageSize"] = alarmInfoListParam.EpageSize;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", alarmInfoListParam.EAction);
			else
				requestParams ["eaction"] = alarmInfoListParam.EAction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", alarmInfoListParam.Md5);
			else
				requestParams ["md5"] = alarmInfoListParam.Md5;
			//设置restsharprequest
			if (restSharpRequestUtil == null)
				restSharpRequestUtil = new RestSharpRequestUtil (alarmInfoListParam.Url, requestParams);
			else {
				restSharpRequestUtil.RequestParams = requestParams;
				restSharpRequestUtil.Url = alarmInfoListParam.Url;
			}

		}
		/// <summary>
		/// Raises the pull down to refresh event.下拉刷新
		/// </summary>
		private void OnPullDownToRefresh()
		{
			if (!IsRefreshing) {
				IsRefreshing = true;
				btnSearchFlag = false;
				LoadData ();
			} 
		}
		/// <summary>
		/// Raises the pull up to refresh event.上拉加载更多
		/// </summary>
		private void OnPullUpToRefresh()
		{
			if (!IsRefreshing) {
				IsRefreshing = true;
				btnSearchFlag = false;
				LoadMoreData ();
			}
		}
		/// <summary>
		/// Loads the more data.
		/// </summary>
		private void LoadMoreData()
		{
			if (string.IsNullOrEmpty (myUserId)) {
				footer.EndRefreshing ();
				IsRefreshing = false;
				return;
			}
			pageIndex++;
			UpdateAlarmInfoListParam ();
			//调用webservice获取数据
			restSharpRequestUtil.ExcuteAsync ((response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					var result = response.Content;
					var alarmlistInfoJson = JsonConvert.DeserializeObject<SearchAlarmInfoJson>(result);
					if(alarmlistInfoJson.statuscode == "1")
					{
						total =  alarmlistInfoJson.data.total;
						alarmInfoLists.AddRange(alarmlistInfoJson.data.items);
						InvokeOnMainThread(()=>
							{
								alarmSource.AddRows(alarmlistInfoJson.data.items);
							});
					}
					else
					{
						pageIndex --;
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast("获取报警列表信息错误",showToastCentered:false,timeoutMs:1000);
							});
					}
				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					pageIndex--;
					InvokeOnMainThread(()=>
						{
							BTProgressHUD.ShowToast("网络超时...",showToastCentered:false,timeoutMs:1000);
						});
				}
				else
				{
					pageIndex --;
					InvokeOnMainThread(()=>
						{
							BTProgressHUD.ShowErrorWithStatus(response.StatusDescription,1000);
						});
				}
				InvokeOnMainThread(()=>
					{
						footer.EndRefreshing();
						IsRefreshing = false;
					});
			});
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		
				
			  
		}
	}
}


