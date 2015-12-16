using System;

using UIKit;
using System.Collections.Generic;
using Newtonsoft.Json;

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
		public BindGuardianViewController () : base ("BindGuardianViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "绑定监护人";
			bindGuadianSource = new BindGuardianTableSource (searchBindGuardianList, this, tableView);
			bindGuadianSource.RefreshAction = () => {
				QuerryBindGuardian(txt_Condition.Text);
			};
			tableView.Source = bindGuadianSource;
			btn_Search.TouchUpInside += (sender, e) => 
			{
				if(string.IsNullOrEmpty(txt_Condition.Text))
					return;
				QuerryBindGuardian(txt_Condition.Text);
			};

		}



		/// <summary>
		/// Querries the bind guardian.
		/// </summary>
		private void QuerryBindGuardian(string condition)
		{
			//ProgressDialogUtil.StartProgressDialog(this,"正在加载中...");
			//检测网络连接
//			if(!EldYoungUtil.IsConnected(this))
//			{
//				Toast.MakeText(this,"网络连接超时,请检测网络",ToastLength.Short).Show();
//				ProgressDialogUtil.StopProgressDialog();
//				return;
//			}
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
						
					}


				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					
				}
				else{
					
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


