using System;
using UIKit;
using System.Collections.Generic;
using Newtonsoft.Json;
using Foundation;
using SDWebImage;

namespace lelaozuIphone
{
	public class GuardianApplyTableSource:UITableViewSource
	{
		public List<GetApplyInfoListItem> ApplyInfoList;
		protected UIViewController controller;
		UITableView View;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private ExamineBundGuardianParam examinebundGuardianParam = new ExamineBundGuardianParam();//请求参数对象
		private RestSharpRequestUtil restSharpRequestUtil;


		public Action RefreshAction {
			get;
			set;
		}
		public GuardianApplyTableSource (List<GetApplyInfoListItem> _applyInfoList,UIViewController _controller,UITableView view)
		{
			ApplyInfoList = _applyInfoList;
			controller = _controller;
			View = view;
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
			return	ApplyInfoList.Count;
		}

		/// <summary>
		/// Rows the selected.
		/// </summary>
		/// <param name="tableView">Table view.</param>
		/// <param name="indexPath">Index path.</param>
		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
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
			var item = ApplyInfoList [indexPath.Row];
			var  cell = tableView.DequeueReusableCell (GuardianApplyTableViewCell.Key) as GuardianApplyTableViewCell;
			if (cell == null) {
				cell = GuardianApplyTableViewCell.CreateCell ();
			}


			cell.Accessory = UITableViewCellAccessory.None;
			cell.SelectionStyle = UITableViewCellSelectionStyle.Gray;
			//set imgeHead
			cell.Img_Head.SetImage(new NSUrl(item.HeadImgReleaseUrl),UIImage.FromFile("myInfomation_headImage.png"));

			cell.Lbl_Name.Text = FormatUtil.StrVaueFormat (item.TrueName);
			cell.Lbl_PhoneNumber.Text = FormatUtil.StrVaueFormat (item.PhoneNumberOne);
			cell.Lbl_ApplyContent.Text = FormatUtil.StrVaueFormat (item.Remark);
			//性别
			var imgSexname = item.Sex == Sex.Male ? "ic_sex_man.png" : "ic_sex_woman.png";
			cell.Img_Sex.Image = UIImage.FromFile (imgSexname);
			SetGuardianStatusAndAction (cell, item,indexPath);
			return cell;
		}
		private void SetGuardianStatusAndAction( GuardianApplyTableViewCell cell,GetApplyInfoListItem item,NSIndexPath indexPath)
		{
			if (item.BindDeriction == 0) {
				cell.Btn_Agree.Hidden = true;
				cell.Btn_Disagree.Hidden = true;
				//被监护人
				switch (item.IsPass) {
				case "0":
					cell.Lbl_BindStatus.Text = "等待对方处理申请";
					break;
				case "1":
					cell.Lbl_BindStatus.Text = "对方已同意申请";
					break;
				case "2":
					cell.Lbl_BindStatus.Text = "对方已拒绝申请";
					break;

				}

			} else {
				//监护人
				switch (item.IsPass) {
				case "0":
					cell.Btn_Agree.Hidden = false;
					cell.Btn_Disagree.Hidden = false;
					cell.Lbl_BindStatus.Hidden = true;

//					cell.Btn_Agree.SetValueForKey (item, GuardianApplyTableViewCell.Key);
//					cell.Btn_Agree.SetValueForKey (new NSString ("1"), actionFlag);
//					cell.Btn_Agree.SetValueForKey (indexPath, _indexPath);
//					cell.Btn_Disagree.SetValueForKey (item, GuardianApplyTableViewCell.Key);
//					cell.Btn_Disagree.SetValueForKey (new NSString ("0"), actionFlag);
//					cell.Btn_Disagree.SetValueForKey (indexPath, _indexPath);

					cell.Btn_Agree.Tag = indexPath.Row;
					cell.Btn_Disagree.Tag = indexPath.Row;

					cell.Btn_Agree.TouchUpInside -= AgreeActionHandler;
					cell.Btn_Agree.TouchUpInside += AgreeActionHandler;
					cell.Btn_Disagree.TouchUpInside -= DisAgreeActionHandler;
					cell.Btn_Disagree.TouchUpInside += DisAgreeActionHandler;


					break;
				case "1":
					cell.Btn_Agree.Hidden = true;
					cell.Btn_Disagree.Hidden = true;
					cell.Lbl_BindStatus.Text = "我已同意对方申请";
					break;
				case "2":
					cell.Btn_Agree.Hidden = true;
					cell.Btn_Disagree.Hidden = true;
					cell.Lbl_BindStatus.Text = "我已拒绝对方申请";
					break;
				}

			}
		}
		/// <summary>
		/// agree事件处理程序
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		private void AgreeActionHandler(object sender, EventArgs e)
		{
			var index = (int)(sender as UIButton).Tag;
			var item = ApplyInfoList[index];
			DealApply (item, "1");
		}
		/// <summary>
		/// Dises the agree action handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		private void DisAgreeActionHandler(object sender, EventArgs e)
		{
			var index = (int)(sender as UIButton).Tag;
			var item = ApplyInfoList[index];
			DealApply (item, "0");
		}

		private void DealApply(GetApplyInfoListItem item,string actionFlag)
		{
			BTProgressHUD.Show("正在处理中...",-1,ProgressHUD.MaskType.Black);
			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;
			examinebundGuardianParam.Ifagreen = actionFlag;
			examinebundGuardianParam.Id = item.Id;

			if (!requestParams.ContainsKey ("eId"))
				requestParams.Add ("eId", examinebundGuardianParam.Eid);
			else
				requestParams ["eId"] = examinebundGuardianParam.Eid;

			if (!requestParams.ContainsKey ("eifagreen"))
				requestParams.Add ("eifagreen", examinebundGuardianParam.Eifagreen);
			else
				requestParams ["eifagreen"] = examinebundGuardianParam.Eifagreen;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", examinebundGuardianParam.EAction);
			else
				requestParams ["eaction"] = examinebundGuardianParam.EAction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", examinebundGuardianParam.Md5);
			else
				requestParams ["md5"] = examinebundGuardianParam.Md5;

			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", examinebundGuardianParam.Key);
			else
				requestParams ["key"] = examinebundGuardianParam.Key;

			//设置restsharprequest
			if (restSharpRequestUtil == null)
				restSharpRequestUtil = new RestSharpRequestUtil (examinebundGuardianParam.Url, requestParams);
			else {
				restSharpRequestUtil.RequestParams = requestParams;
				restSharpRequestUtil.Url = examinebundGuardianParam.Url;
			}
			restSharpRequestUtil.ExcuteAsync ((RestSharp.IRestResponse response) => {
				InvokeOnMainThread(()=>
					{
						BTProgressHUD.Dismiss();
						//在状态栏中hide使用网络指示器
						UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
					});
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed &&response.StatusCode == System.Net.HttpStatusCode.OK)
				{

					var result = response.Content;
					var examinebundGuardianJson = JsonConvert.DeserializeObject<ExamineBundGuardianJson>(result);
					if(examinebundGuardianJson.statuscode == "1")
					{
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowSuccessWithStatus("处理成功...",1000);
								//View.DeleteRows(new NSIndexPath[]{ indexPath },UITableViewRowAnimation.Left);
								if(RefreshAction == null)
									RefreshAction();
							});
					}
					else
					{
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast("处理失败,稍后在试...",showToastCentered:false,timeoutMs:1000);
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

