﻿using System;

using UIKit;
using System.Collections.Generic;
using Newtonsoft.Json;
using MJRefresh;
using System.Threading.Tasks;

namespace lelaozuIphone
{
	public partial class MyHealthViewController : UIViewController
	{
		private string defaultTime;
		private List<HealthInfoItem> healthInfoLists = new List<HealthInfoItem>();
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();//请求参数
		private SearchHealthInforParam healthInfoParam;//请求参数对象

		private int pageIndex =1;//当前页码
		private RestSharpRequestUtil restSharpRequestUtil;
		private int total;//总记录数
		MJRefreshNormalHeader header;
		MJRefreshAutoNormalFooter footer;
		private HealthTableSource healthSource;
		private bool IsRefreshing = false;//是否正在获取数据
		public MyHealthViewController () : base ("MyHealthViewController", null)
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
			//defaultTime = DateTime.Now.ToString ("yyyy-MM-dd");
			defaultTime = "2015-11-05";
			txt_healthTime.Text = defaultTime;
			healthInfoParam = new SearchHealthInforParam(){Id = Constants.MyInfo.UId};
			healthSource = new HealthTableSource(healthInfoLists,this,tableView);
			tableView.Source = healthSource;
			btn_Search.TouchUpInside += (sender, e) => 
			{
				LoadData();
			};
			btn_add.TouchUpInside += (sender, e) => 
			{
				//healthSource.Add(new HealthInfoItem(){TestTime="2015-11-04",Weight="76",BloodGlucose="30"});
//				var test = new TestViewController();
//				test.HidesBottomBarWhenPushed = true;
//				this.NavigationController.PushViewController(test,true);
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
		/// <summary>
		/// Loads the data.
		/// </summary>
		private  void LoadData()
		{
			pageIndex = 1;
			UpdateHealthInfoListParam ();
			//调用webservice获取数据
			restSharpRequestUtil.ExcuteAsync ((response) => {
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
						
					}
				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
				}
				else{
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
			healthInfoParam.PageIndex = pageIndex.ToString();
			healthInfoParam.SearchTime = string.IsNullOrEmpty (txt_healthTime.Text) ?defaultTime : txt_healthTime.Text;
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
				restSharpRequestUtil = new RestSharpRequestUtil (healthInfoParam.Url,requestParams);
			else
				restSharpRequestUtil.RequestParams = requestParams;

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
		/// <summary>
		/// Loads the more data. 加载更多数据
		/// </summary>
		private void LoadMoreData()
		{
			pageIndex++;
			UpdateHealthInfoListParam ();
			restSharpRequestUtil.ExcuteAsync ((RestSharp.IRestResponse response) => {
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
						pageIndex--;
					}
					#region 模拟加载更多
//					List<HealthInfoItem> lists = new List<HealthInfoItem>(){
//						new HealthInfoItem(){TestTime="2015-11-01",Weight="76",BloodGlucose="30"},
//						new HealthInfoItem(){TestTime="2015-11-02",Weight="76",BloodGlucose="30"}
//						,new HealthInfoItem(){TestTime="2015-11-03",Weight="76",BloodGlucose="30"}
//					};
//					InvokeOnMainThread(()=>
//						{
//							healthSource.AddRows(lists);
//						});
					#endregion

				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					pageIndex--;

				}
				else
				{
					pageIndex --;
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


