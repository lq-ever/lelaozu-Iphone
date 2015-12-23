using System;

using UIKit;
using System.Collections.Generic;
using MJRefresh;
using Newtonsoft.Json;

namespace lelaozuIphone
{
	public partial class MyGuardianViewController : UIViewController
	{
		

		private List<GuardianInfoListItem> guardianInfoList= new List<GuardianInfoListItem>();
	
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private MineGuardianInfoListParam myGuardianInfoListParam;//请求参数对象
		private int pageIndex =1;//当前页码
		private RestSharpRequestUtil restSharpRequestUtil;
		private int total;//总记录数
		private bool IsRefreshing = false;//是否正在获取数据
		MJRefreshNormalHeader header;
		MJRefreshAutoNormalFooter footer;
		private GuardianListTableSource guardianSource;

		public MyGuardianViewController () : base ("MyGuardianViewController", null)
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
			//初始化请求参数对象
			myGuardianInfoListParam = new MineGuardianInfoListParam (){ UserId = Constants.MyInfo.UId };
			guardianSource = new GuardianListTableSource(guardianInfoList,this,tableView);
			tableView.Source = guardianSource;
			guardianSource.RefreshAction = () => {
				header.BeginRefreshing();
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
			//第一次进入自动刷新
			header.BeginRefreshing();
		}

		private void LoadData()
		{
			pageIndex = 1;
			UpdateGuardianInfoListParam ();
			//调用webservice获取数据
			restSharpRequestUtil.ExcuteAsync ((response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					var result = response.Content;
					var guardianInfoJson =  JsonConvert.DeserializeObject<GuardianInfoJson>(result);
					if(guardianInfoJson.statuscode =="1")
					{
						total = guardianInfoJson.data.total;
						guardianInfoList = guardianInfoJson.data.items;
						InvokeOnMainThread(()=>
							{
								guardianSource.GuardianInfoList.Clear();
								guardianSource.GuardianInfoList.AddRange(guardianInfoList);
								tableView.ReloadData();
							});
					}
					else
					{
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast("获取监护人列表信息失败...",showToastCentered:false,timeoutMs:1000);
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
		private void UpdateGuardianInfoListParam()
		{
			myGuardianInfoListParam.PageIndex = pageIndex.ToString();
			SetRestRequestParams ();
		}

		private void SetRestRequestParams()
		{
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", myGuardianInfoListParam.Key);
			else
				requestParams ["key"] = myGuardianInfoListParam.Key;

			if (!requestParams.ContainsKey ("eUserId"))
				requestParams.Add ("eUserId", myGuardianInfoListParam.EuserId);
			else
				requestParams ["eUserId"] = myGuardianInfoListParam.EuserId;

			if (!requestParams.ContainsKey ("ePageIndex"))
				requestParams.Add ("ePageIndex", myGuardianInfoListParam.EpageIndex);
			else
				requestParams ["ePageIndex"] = myGuardianInfoListParam.EpageIndex;

			if (!requestParams.ContainsKey ("ePageSize"))
				requestParams.Add ("ePageSize", myGuardianInfoListParam.EpageSize);
			else
				requestParams ["ePageSize"] = myGuardianInfoListParam.EpageSize;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", myGuardianInfoListParam.EAction);
			else
				requestParams ["eaction"] = myGuardianInfoListParam.EAction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", myGuardianInfoListParam.Md5);
			else
				requestParams ["md5"] = myGuardianInfoListParam.Md5;
			//设置restsharprequest
			if (restSharpRequestUtil == null)
				restSharpRequestUtil = new RestSharpRequestUtil (myGuardianInfoListParam.Url, requestParams);
			else {
				restSharpRequestUtil.RequestParams = requestParams;
				restSharpRequestUtil.Url = myGuardianInfoListParam.Url;
			}
		}
		/// <summary>
		/// Raises the pull down to refresh event.下拉刷新
		/// </summary>
		private void OnPullDownToRefresh()
		{
			if (!IsRefreshing) {
				IsRefreshing = true;
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
				LoadMoreData ();
			}
		}

		private void LoadMoreData()
		{
			pageIndex++;
			UpdateGuardianInfoListParam ();
			restSharpRequestUtil.ExcuteAsync ((response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed &&response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					var result = response.Content;
					var guardianInfoJson =  JsonConvert.DeserializeObject<GuardianInfoJson>(result); 
					if(guardianInfoJson.statuscode == "1")
					{
						total = guardianInfoJson.data.total;
						guardianInfoList.AddRange(guardianInfoJson.data.items);
						InvokeOnMainThread(()=>
							{
								guardianSource.AddRows(guardianInfoJson.data.items);
							});

					}
					else
					{
						pageIndex --;
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast("获取更多监护人列表信息出错...",showToastCentered:false,timeoutMs:1000);
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


