using System;

using UIKit;
using System.Collections.Generic;
using MJRefresh;
using Newtonsoft.Json;

namespace lelaozuIphone
{
	public partial class AdviceRecordViewController : UIViewController
	{
		private string _adviceType = ((int)AdviceType.All).ToString();//默认all类型
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private AdviceRecordInfoListParam adviceRecordInfoListParam;//请求参数对象
		private int pageIndex =1;//当前页码
		private RestSharpRequestUtil restSharpRequestUtil;
		private int total;//总记录数
		private List<AdviceRecordInfoItem> adviceRecordLists = new List<AdviceRecordInfoItem>();
		private bool IsRefreshing = false;//是否正在获取数据
		MJRefreshNormalHeader header;
		MJRefreshAutoNormalFooter footer;
		private AdviceRecordTableSource adviceRecordSource;

		private UIAlertController alertAdviceTypeController;//建议类型controller
		private UIPickerView pickerView;//建议类型 pickerView
		public AdviceRecordViewController () : base ("AdviceRecordViewController", null)
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
			//初始化请求参数信息
			adviceRecordInfoListParam = new AdviceRecordInfoListParam () {
				UId = Constants.MyInfo.UId,
				AdviceType = _adviceType
			};
			//set tablesource
			adviceRecordSource = new AdviceRecordTableSource (adviceRecordLists, this, tableView);
			tableView.Source = adviceRecordSource;
			//set tableview header and footer
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

			//init advicepicker
			InitAdviceTypePicker();
			txt_adviceType.Text = "全部";
			//第一次进入自动刷新
			header.BeginRefreshing();
		}

		/// <summary>
		/// Inits the advice type picker.
		/// </summary>
		private void InitAdviceTypePicker()
		{
			var adviceTypeList = new List<AdviceTypeItem>{new AdviceTypeItem{AdviceTypeId= ((int)AdviceType.Consult).ToString(),AdviceTypeDesc="咨询"},
				new AdviceTypeItem{AdviceTypeId= ((int)AdviceType.Suggest).ToString(),AdviceTypeDesc="建议"},
				new AdviceTypeItem{AdviceTypeId=((int)AdviceType.Complain).ToString(),AdviceTypeDesc="投诉"},
				new AdviceTypeItem{AdviceTypeId=((int)AdviceType.Other).ToString(),AdviceTypeDesc="其它"}};
			txt_adviceType.ShouldBeginEditing = (textField) => {

				AdviceTypeItem selectItem = null;
				if(alertAdviceTypeController == null && pickerView == null)
				{
					alertAdviceTypeController = UIAlertController.Create("请选择建议类型","\n\n\n\n\n\n\n\n",UIAlertControllerStyle.ActionSheet);
					pickerView = new UIPickerView();
					var genderModel = new CustomPickerModel<AdviceTypeItem>(adviceTypeList);
					genderModel.PickerAction = (item)=>
					{
						selectItem = item;
					};
					pickerView.Model = genderModel;
					alertAdviceTypeController.View.AddSubview(pickerView);
					alertAdviceTypeController.AddAction(UIAlertAction.Create("确定",UIAlertActionStyle.Default,(Action)=>
						{
							if(selectItem!=null)
							{
								_adviceType = selectItem.AdviceTypeId;
								textField.Text = selectItem.AdviceTypeDesc;
								header.BeginRefreshing();
							}
						}));
					alertAdviceTypeController.AddAction(UIAlertAction.Create("取消",UIAlertActionStyle.Cancel,(Action)=>
						{
							
						}));
				}
				PresentViewController(alertAdviceTypeController,true,null);
				return textField.ResignFirstResponder();
			};

		}
		/// <summary>
		/// 初始化数据
		/// </summary>
		private void LoadData()
		{
			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;
			pageIndex =1;
			UpdateAdviceInfoListParam ();
			//调用webservice获取数据
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
					var adviceRecordInfoJson = JsonConvert.DeserializeObject<AdviceRecordInfoJson>(result);
					if(adviceRecordInfoJson.statuscode == "1")
					{

						total =  adviceRecordInfoJson.data.total;
						adviceRecordLists = adviceRecordInfoJson.data.items;

						InvokeOnMainThread(()=>
							{
								lbl_recordNum.Text = total.ToString();
								adviceRecordSource.AdviceRecordList.Clear();
								adviceRecordSource.AdviceRecordList.AddRange(adviceRecordLists);
								tableView.ReloadData();
							});

					}
					else
					{
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast("获取建议列表信息错误",showToastCentered:false,timeoutMs:1000);
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
				else
				{
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
		private void UpdateAdviceInfoListParam()
		{
			adviceRecordInfoListParam.PageIndex = pageIndex.ToString();
			adviceRecordInfoListParam.AdviceType = _adviceType;
			SetRestRequestParams ();
		}

		/// <summary>
		/// 设置参数值
		/// </summary>
		/// <param name="msgInfoParam">Message info parameter.</param>
		private void SetRestRequestParams()
		{
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", adviceRecordInfoListParam.Key);
			else
				requestParams ["key"] = adviceRecordInfoListParam.Key;

			if (!requestParams.ContainsKey ("eAdviceType"))
				requestParams.Add ("eAdviceType", adviceRecordInfoListParam.EadviceType);
			else
				requestParams ["eAdviceType"] = adviceRecordInfoListParam.EadviceType;

			if (!requestParams.ContainsKey ("ePlatformType"))
				requestParams.Add ("ePlatformType", adviceRecordInfoListParam.EplatformType);
			else
				requestParams ["ePlatformType"] = adviceRecordInfoListParam.EplatformType;

			if (!requestParams.ContainsKey ("eUserId"))
				requestParams.Add ("eUserId", adviceRecordInfoListParam.Euid);
			else
				requestParams ["eUserId"] = adviceRecordInfoListParam.Euid;
			if (!requestParams.ContainsKey ("ePageIndex"))
				requestParams.Add ("ePageIndex", adviceRecordInfoListParam.EpageIndex);
			else
				requestParams ["ePageIndex"] = adviceRecordInfoListParam.EpageIndex;

			if (!requestParams.ContainsKey ("ePageSize"))
				requestParams.Add ("ePageSize", adviceRecordInfoListParam.EpageSize);
			else
				requestParams ["ePageSize"] = adviceRecordInfoListParam.EpageSize;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", adviceRecordInfoListParam.EAction);
			else
				requestParams ["eaction"] = adviceRecordInfoListParam.EAction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", adviceRecordInfoListParam.Md5);
			else
				requestParams ["md5"] = adviceRecordInfoListParam.Md5;
			//设置restsharprequest
			if (restSharpRequestUtil == null)
				restSharpRequestUtil = new RestSharpRequestUtil (adviceRecordInfoListParam.Url, requestParams);
			else {
				restSharpRequestUtil.RequestParams = requestParams;
				restSharpRequestUtil.Url = adviceRecordInfoListParam.Url;
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

		/// <summary>
		/// 获取更多数据
		/// </summary>
		private void LoadMoreData()
		{

			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;
			pageIndex++;
			UpdateAdviceInfoListParam ();
			//调用webservice获取数据
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
					var adviceRecordInfoJson = JsonConvert.DeserializeObject<AdviceRecordInfoJson>(result);
					if(adviceRecordInfoJson.statuscode == "1")
					{
						total =  adviceRecordInfoJson.data.total;
						adviceRecordLists.AddRange(adviceRecordInfoJson.data.items);

						InvokeOnMainThread(()=>
							{
								lbl_recordNum.Text = total.ToString();
								adviceRecordSource.AddRows(adviceRecordInfoJson.data.items);
							});
					}
					else
					{
						pageIndex--;
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast("获取更多建议信息错误",showToastCentered:false,timeoutMs:1000);
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
					pageIndex--;
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


