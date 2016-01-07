using System;

using UIKit;
using System.Collections.Generic;
using Newtonsoft.Json;
using MJRefresh;

namespace lelaozuIphone
{
	/// <summary>
	/// Bind guardian view controller.搜索申请绑定监护人
	/// </summary>
	public partial class BindGuardianViewController : UIViewController
	{
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private SearchGuardianParam searchGuardianParam = new SearchGuardianParam(){Guid = Constants.MyInfo.UId};//请求参数对象
		private RestSharpRequestUtil restSharpRequestUtil;
		protected bool HasLoadedOnce;
		private List<SearchGuardianListItem> searchBindGuardianList = new List<SearchGuardianListItem>();
		private BindGuardianTableSource bindGuadianSource;

		MJRefreshNormalHeader header;
		private bool IsRefreshing = false;//是否正在获取数据
		private bool btnSearchFlag = false;//监听是否点击查询

		public BindGuardianViewController () : base ("BindGuardianViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "绑定监护人";
			txt_Condition.ReturnKeyType = UIReturnKeyType.Search;
			txt_Condition.ShouldReturn = ((textField) => {
				QuerryBindGuardian(txt_Condition.Text);
				return textField.ResignFirstResponder();

			});
			bindGuadianSource = new BindGuardianTableSource (searchBindGuardianList, this, tableView);
			bindGuadianSource.RefreshAction = () => {
				//QuerryBindGuardian(txt_Condition.Text);
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
			tableView.Source = bindGuadianSource;
			btn_Search.TouchUpInside += (sender, e) => 
			{
				btnSearchFlag = true;
				txt_Condition.ResignFirstResponder();
				QuerryBindGuardian(txt_Condition.Text);
			};

		}



		/// <summary>
		/// Querries the bind guardian.
		/// </summary>
		private void QuerryBindGuardian(string condition)
		{

			if(string.IsNullOrEmpty(condition))
				return;
			if(btnSearchFlag)
				BTProgressHUD.Show("正在加载中...",-1,ProgressHUD.MaskType.Black);

			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;

			searchGuardianParam.Condition = condition;

			if (!requestParams.ContainsKey ("econdition"))
				requestParams.Add ("econdition", searchGuardianParam.Econdition);
			else
				requestParams ["econdition"] = searchGuardianParam.Econdition;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", searchGuardianParam.EAction);
			else
				requestParams ["eaction"] = searchGuardianParam.EAction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", searchGuardianParam.Md5);
			else
				requestParams ["md5"] = searchGuardianParam.Md5;

			if (!requestParams.ContainsKey ("eguid"))
				requestParams.Add ("eguid", searchGuardianParam.Eguid);
			else
				requestParams ["eguid"] = searchGuardianParam.Eguid;

			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", searchGuardianParam.Key);
			else
				requestParams ["key"] = searchGuardianParam.Key;
			//设置restsharprequest
			if (restSharpRequestUtil == null)
				restSharpRequestUtil = new RestSharpRequestUtil (searchGuardianParam.Url, requestParams);
			else {
				restSharpRequestUtil.RequestParams = requestParams;
				restSharpRequestUtil.Url = searchGuardianParam.Url;
			}

			//调用web服务
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
					var searchGardianlistInfoJson = JsonConvert.DeserializeObject<SearchGuardianListJson>(result);
					if(searchGardianlistInfoJson.statuscode == "1")
					{
						searchBindGuardianList = searchGardianlistInfoJson.data;
						InvokeOnMainThread(()=>
							{
								bindGuadianSource.SearchGuardianInfoList.Clear();
								bindGuadianSource.SearchGuardianInfoList.AddRange(searchBindGuardianList);
								tableView.ReloadData();
							});
					}
					else
					{
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast("获取会员信息失败",showToastCentered:false,timeoutMs:1000);
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
							BTProgressHUD.ShowErrorWithStatus(Constants.ErrorStatusDes,1000);
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
		/// Raises the pull down to refresh event.下拉刷新
		/// </summary>
		private void OnPullDownToRefresh()
		{
			if (!IsRefreshing) {
				IsRefreshing = true;
				btnSearchFlag = false;
				QuerryBindGuardian (txt_Condition.Text);
			} 
		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


