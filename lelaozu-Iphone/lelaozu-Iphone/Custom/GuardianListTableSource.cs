using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using Newtonsoft.Json;

namespace lelaozuIphone
{
	public class GuardianListTableSource:UITableViewSource
	{
		public List<GuardianInfoListItem> GuardianInfoList;
		protected UIViewController controller;
		UITableView View;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private UnBindGuardianParam unBindGuardianParam = new UnBindGuardianParam();//请求参数对象
		private RestSharpRequestUtil restSharpRequestUtil;

		/// <summary>
		/// 监护人列表数据源
		/// </summary>
		private NSString _indexPath = new NSString("indexPath");

		public Action RefreshAction {
			get;
			set;
		}

		public GuardianListTableSource (List<GuardianInfoListItem> _guardianInfoList,UIViewController _controller,UITableView view)
		{
			GuardianInfoList = _guardianInfoList;
			controller = _controller;
			View = view;
		}

		public void Add(GuardianInfoListItem _guardianInfoListItem)
		{
			GuardianInfoList.Add(_guardianInfoListItem);
			View.InsertRows(new NSIndexPath[]{ NSIndexPath.FromRowSection(GuardianInfoList.Count - 1, 0) }, UITableViewRowAnimation.Left);

		}

		public void AddRows(List<GuardianInfoListItem> _guardianInfoList)
		{
			foreach (var item in _guardianInfoList) {
				GuardianInfoList.Add (item);
				View.InsertRows(new NSIndexPath[]{ NSIndexPath.FromRowSection(GuardianInfoList.Count - 1, 0) }, UITableViewRowAnimation.Left);

			}
		}

		/// <summary>
		/// Numbers the of sections.
		/// </summary>
		/// <returns>The of sections.</returns>
		/// <param name="tableView">Table view.</param>
		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;

		}
		/// <summary>
		/// Gets the height for row.行高
		/// </summary>
		/// <returns>The height for row.</returns>
		/// <param name="tableView">Table view.</param>
		/// <param name="indexPath">Index path.</param>
		public override nfloat GetHeightForRow (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			return 90;
		}
		/// <summary>
		/// Rowses the in section.
		/// </summary>
		/// <returns>The in section.</returns>
		/// <param name="tableview">Tableview.</param>
		/// <param name="section">Section.</param>
		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return	GuardianInfoList.Count;
		}

		/// <summary>
		/// Rows the selected.
		/// </summary>
		/// <param name="tableView">Table view.</param>
		/// <param name="indexPath">Index path.</param>
		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var item = GuardianInfoList [indexPath.Row];
			var guardianDetailController = new GuardianDetailViewController (){UId = item.UId};
			guardianDetailController.HidesBottomBarWhenPushed = true;
			controller.NavigationController.PushViewController(guardianDetailController,true);
			tableView.DeselectRow (indexPath, true);
		}
		/// <summary>
		/// Gets the cell.
		/// </summary>
		/// <returns>The cell.</returns>
		/// <param name="tableView">Table view.</param>
		/// <param name="indexPath">Index path.</param>
		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var item = GuardianInfoList [indexPath.Row];
			var  cell = tableView.DequeueReusableCell (GuardianListCell.Key) as GuardianListCell;
			if (cell == null) {
				cell = GuardianListCell.CreateCell ();
			}
			cell.Lbl_Name.Text = FormatUtil.StrVaueFormat (item.TrueName);
			//设置地址
			if (string.IsNullOrEmpty (item.ContactAddress))
				cell.Lbl_Location.Text = string.Empty;
			else {
				if (item.ContactAddress.Contains ("|"))
					cell.Lbl_Location.Text = item.ContactAddress.Split (new char[]{ '|' }) [1];
				else
					cell.Lbl_Location.Text = item.ContactAddress;

			}
			cell.Lbl_PhoneNumber.Text = FormatUtil.StrVaueFormat (item.PhoneNumberOne);
			var imgSexname = item.Sex == Sex.Male ? "ic_sex_man.png" : "ic_sex_woman.png";
			cell.Img_Sex.Image = UIImage.FromFile (imgSexname);

//			cell.Btn_Action.SetValueForKey (item, GuardianListCell.Key);
//			cell.Btn_Action.SetValueForKey (indexPath, _indexPath);


//			cell.Btn_Action.SetValueForKeyPath (item, GuardianListCell.Key);
//			cell.Btn_Action.SetValueForKeyPath (indexPath, _indexPath);

			cell.Btn_Action.Tag = indexPath.Row;


			cell.Btn_Action.TouchUpInside -= ActionHandle;
		    cell.Btn_Action.TouchUpInside += ActionHandle;

			cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
			cell.SelectionStyle = UITableViewCellSelectionStyle.Gray;
			//todo:set imgeHead

			return cell;
		}

		private void ActionHandle(object sender, EventArgs e)
		{
			
			var index = (int)(sender as UIButton).Tag;
			var item = GuardianInfoList[index];
//			var item = (sender as UIButton).ValueForKeyPath (GuardianListCell.Key) as  GuardianInfoListItem;
//			var indexPath = (sender as UIButton).ValueForKeyPath (_indexPath) as NSIndexPath;
			var unbindAlertController = UIAlertController.Create ("解绑", "您确定要解绑吗？", UIAlertControllerStyle.Alert);
			unbindAlertController.AddAction (UIAlertAction.Create ("确定", UIAlertActionStyle.Default, (action) => {
				UnBindGuardian(item);
			}));
				
			unbindAlertController.AddAction (UIAlertAction.Create ("取消", UIAlertActionStyle.Cancel, (action) => {
				
			}));
			controller.PresentViewController (unbindAlertController, true, null);

		}
		/// <summary>
		/// 解绑监护人
		/// </summary>
		/// <param name="userId">User identifier.</param>
		private void UnBindGuardian(GuardianInfoListItem item)
		{
			//调用webservice

		
			BTProgressHUD.Show("正在解绑中...",-1,ProgressHUD.MaskType.Black);
			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;

			unBindGuardianParam.Id = item.Id;
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", unBindGuardianParam.Key);
			else
				requestParams ["key"] = unBindGuardianParam.Key;
			if (!requestParams.ContainsKey ("eId"))
				requestParams.Add ("eId", unBindGuardianParam.Eid);
			else
				requestParams ["eId"] = unBindGuardianParam.Eid;
			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", unBindGuardianParam.EAction);
			else
				requestParams ["eaction"] = unBindGuardianParam.EAction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", unBindGuardianParam.Md5);
			else
				requestParams ["md5"] = unBindGuardianParam.Md5;
			//设置restsharprequest
			if (restSharpRequestUtil == null)
				restSharpRequestUtil = new RestSharpRequestUtil (unBindGuardianParam.Url,requestParams);
			else
				restSharpRequestUtil.RequestParams = requestParams;
			//调用解绑web服务
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
					var unBindGuardianJson = JsonConvert.DeserializeObject<UnBindGuardianJson>(result);
					if(unBindGuardianJson.statuscode == "1")
					{
						if(unBindGuardianJson.data == "1")
						{
							InvokeOnMainThread(()=>
								{
									//解绑成功
									BTProgressHUD.ShowSuccessWithStatus("解绑成功",1000);
									//View.DeleteRows(new NSIndexPath[]{ indexPath },UITableViewRowAnimation.Left);
									if(RefreshAction!=null)
										RefreshAction();
								});
						}
						else
						{

							InvokeOnMainThread(()=>
								{
									BTProgressHUD.ShowToast("解绑失败，稍后在试...",showToastCentered:false,timeoutMs:1000);
								});
						}
					}
					else
					{

						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast("解绑失败，稍后在试...",showToastCentered:false,timeoutMs:1000);
							});
					}


				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					InvokeOnMainThread(()=>
						{
							BTProgressHUD.ShowToast("网络超时...",showToastCentered:false,timeoutMs:1000);
						}
					);
				}
				else
				{
					InvokeOnMainThread(()=>
						{
							BTProgressHUD.ShowErrorWithStatus(response.StatusDescription,1000);
						});
				}
			});	
		}

	}
}

