using System;

using UIKit;
using System.Collections.Generic;
using MJRefresh;
using Newtonsoft.Json;

namespace lelaozuIphone
{
	/// <summary>
	/// 监护人申请
	/// </summary>
	public partial class GuardianApplyViewController : UIViewController
	{
		private RestSharpRequestUtil restSharpRequestUtil;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private GetApplyInfoParam getApplyInfoParam;//请求参数对象
		List<GetApplyInfoListItem> ApplyInfoList;

		private bool IsRefreshing = false;//是否正在获取数据
		MJRefreshNormalHeader header;

		private GuardianApplyTableSource guardianApplyTableSource;

		public GuardianApplyViewController () : base ("GuardianApplyViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "监护人申请处理";
			InitView ();
		}

		private void InitView()
		{
			getApplyInfoParam = new GetApplyInfoParam (){ Id = Constants.MyInfo.UId };
			guardianApplyTableSource = new GuardianApplyTableSource (ApplyInfoList, this, tableView);
			tableView.Source = guardianApplyTableSource;
			header = new MJRefreshNormalHeader();
			header.SetTitle(Constants.PullDownLbl, MJRefreshState.Idle);
			header.SetTitle(Constants.PullDownReleaseLbl, MJRefreshState.Pulling);
			header.SetTitle(Constants.PullDownRefreshLbl, MJRefreshState.Refreshing);
			header.LastUpdatedTimeLabel.Hidden = true;
			header.RefreshingBlock = () =>  {
				OnPullDownToRefresh();
			};
			tableView.SetHeader (header);

		}
		/// <summary>
		/// Loads the data.
		/// </summary>
		private void LoadData()
		{
			//检测网络连接
//			if(!EldYoungUtil.IsConnected(this))
//			{
//				Toast.MakeText(this,"网络连接超时,请检测网络",ToastLength.Short).Show();
//				return;
//			}
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", getApplyInfoParam.Key);
			else
				requestParams ["key"] = getApplyInfoParam.Key;

			if (!requestParams.ContainsKey ("eId"))
				requestParams.Add ("eId", getApplyInfoParam.Eid);
			else
				requestParams ["eId"] = getApplyInfoParam.Eid;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", getApplyInfoParam.EAction);
			else
				requestParams ["eaction"] = getApplyInfoParam.EAction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", getApplyInfoParam.Md5);
			else
				requestParams ["md5"] = getApplyInfoParam.Md5;
			//设置restsharprequest
			if (restSharpRequestUtil == null)
				restSharpRequestUtil = new RestSharpRequestUtil (getApplyInfoParam.Url, requestParams);
			else {
				restSharpRequestUtil.RequestParams = requestParams;
				restSharpRequestUtil.Url = getApplyInfoParam.Url;
			}

			restSharpRequestUtil.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{

					var result = response.Content;
					var getApplyInfoJson = JsonConvert.DeserializeObject<GetApplyInfoJson >(result);
					if(getApplyInfoJson.statuscode =="1")
					{
						ApplyInfoList = getApplyInfoJson.data;
						InvokeOnMainThread(()=>
							{
								guardianApplyTableSource.ApplyInfoList.Clear();
								guardianApplyTableSource.ApplyInfoList.AddRange(ApplyInfoList);
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
				else
				{
					
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
				LoadData ();
			} 
		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}


	}
}


