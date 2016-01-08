using System;

using UIKit;
using System.Collections.Generic;
using MJRefresh;
using Newtonsoft.Json;
using Foundation;

namespace lelaozuIphone
{
	public partial class OtherHealthViewController : UIViewController
	{
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private SearchHealthInforParam healthInfoParam;//请求参数对象

		private int pageIndex =1;//当前页码
		private RestSharpRequestUtil restSharpRequestUtil;
		private int total;//总记录数
		private List<HealthInfoItem> healthInfoLists = new List<HealthInfoItem>();

		private List<AllMyUserListItem> myUserLists;//我的监护人列表
		private SearchAllMyUserParam myUserParam = new SearchAllMyUserParam(){UserId = Constants.MyInfo.UId};//我的监护人请求参数对象
		private Dictionary<string,string> myUserRequestParams = new Dictionary<string, string>();//监护人web请求
		private string myUserId;
		private bool btnSearchFlag = false;//监听是否点击查询
		private bool IsRefreshing = false;//是否正在获取数据
		MJRefreshNormalHeader header;
		MJRefreshAutoNormalFooter footer;
		private HealthTableSource healthSource;
		private string defaultTime;
		private UIAlertController alertdateController;
		private UIDatePicker datePicker;// 日期控件
		public OtherHealthViewController () : base ("OtherHealthViewController", null)
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
			
			txt_healthTime.Placeholder = "请输入体检时间";
			defaultTime = DateTime.Now.ToString ("yyyy-MM-dd");
			//defaultTime = "2015-11-05";
			txt_healthTime.Text = defaultTime;
			healthInfoParam = new SearchHealthInforParam ();
			healthSource = new HealthTableSource(healthInfoLists,this,tableView);
			tableView.Source = healthSource;
			//btn_search
			btn_Search.BackgroundColor = Color.Blue;
			btn_Search.TouchUpInside += (sender, e) => 
			{
				btnSearchFlag = true;
				LoadData();
			};

			//set the time 
			txt_healthTime.ShouldBeginEditing = (textField) => {
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
			#region 配置下拉上拉刷新头部
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
			#endregion
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
				BTProgressHUD.Show("正在查询健康体检信息...",-1,ProgressHUD.MaskType.Black);
			pageIndex =1;
			UpdateHealthInfoListParam ();
			restSharpRequestUtil.ExcuteAsync ((response) => {
				InvokeOnMainThread(()=>
					{
						BTProgressHUD.Dismiss();
						//在状态栏中hide使用网络指示器
						UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
					});
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					var result = response.Content;
					var healthInfoJson = JsonConvert.DeserializeObject<SearchHealthInfoJson>(result);
					if(healthInfoJson.statuscode == "1")
					{
						total =  healthInfoJson.data.total;
						healthInfoLists = healthInfoJson.data.items;
						InvokeOnMainThread(()=>
							{
								healthSource.healthList.Clear();
								healthSource.healthList.AddRange(healthInfoLists);
								tableView.ReloadData();
							});
					}
					else
					{
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast("查询健康体检信息错误",showToastCentered:false,timeoutMs:1000);
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
		private void UpdateHealthInfoListParam()
		{
			healthInfoParam.Id = myUserId;
			healthInfoParam.PageIndex = pageIndex.ToString();
			healthInfoParam.SearchTime = string.IsNullOrEmpty (txt_healthTime.Text) ? defaultTime : txt_healthTime.Text;
			SetRestRequestParams ();

		}
		/// <summary>
		/// 设置参数值
		/// </summary>
		/// <param name="msgInfoParam">Message info parameter.</param>
		private void SetRestRequestParams()
		{
			if (!requestParams.ContainsKey ("ESearchTime"))
				requestParams.Add ("ESearchTime", healthInfoParam.EsearchTime);
			else
				requestParams ["ESearchTime"] = healthInfoParam.EsearchTime;
			if (!requestParams.ContainsKey ("eUserId"))
				requestParams.Add ("eUserId", healthInfoParam.Eid);
			else
				requestParams ["eUserId"] = healthInfoParam.Eid;

			if (!requestParams.ContainsKey ("ePageIndex"))
				requestParams.Add ("ePageIndex", healthInfoParam.EpageIndex);
			else
				requestParams ["ePageIndex"] = healthInfoParam.EpageIndex;

			if (!requestParams.ContainsKey ("ePageSize"))
				requestParams.Add ("ePageSize", healthInfoParam.EpageSize);
			else
				requestParams ["ePageSize"] = healthInfoParam.EpageSize;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", healthInfoParam.EAction);
			else
				requestParams ["eaction"] = healthInfoParam.EAction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", healthInfoParam.Md5);
			else
				requestParams ["md5"] = healthInfoParam.Md5;

			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", healthInfoParam.Key);
			else
				requestParams ["key"] = healthInfoParam.Key;

			//设置restsharprequest
			if (restSharpRequestUtil == null)
				restSharpRequestUtil = new RestSharpRequestUtil (healthInfoParam.Url, requestParams);
			else {
				restSharpRequestUtil.RequestParams = requestParams;
				restSharpRequestUtil.Url = healthInfoParam.Url;
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
			UpdateHealthInfoListParam ();
			restSharpRequestUtil.ExcuteAsync ((response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed &&response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					var result = response.Content;
					var searchHealthInfoJson = JsonConvert.DeserializeObject<SearchHealthInfoJson>(result);
					if(searchHealthInfoJson.statuscode == "1")
					{
						total =  searchHealthInfoJson.data.total;
						healthInfoLists.AddRange(searchHealthInfoJson.data.items);
						InvokeOnMainThread(()=>
							{
								healthSource.AddRows(searchHealthInfoJson.data.items);
							});

					}
					else
					{
						pageIndex --;
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast("获取更多体检信息错误",showToastCentered:false,timeoutMs:1000);
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
							BTProgressHUD.ShowErrorWithStatus(Constants.ErrorStatusDes,2000);
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


