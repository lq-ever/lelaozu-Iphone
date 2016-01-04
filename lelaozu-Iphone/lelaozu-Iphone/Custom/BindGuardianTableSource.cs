using System;
using UIKit;
using System.Collections.Generic;
using Newtonsoft.Json;
using Foundation;
using SDWebImage;

namespace lelaozuIphone
{
	public class BindGuardianTableSource:UITableViewSource
	{
		public List<SearchGuardianListItem> SearchGuardianInfoList;
		protected UIViewController controller;
		UITableView View;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private ApplyBindGuardianParam applyBindGuardianParam = new ApplyBindGuardianParam(){UserId = Constants.MyInfo.UId};//请求参数对象
		private RestSharpRequestUtil restSharpRequestUtil;

		private UIAlertAction SendAction;
		public Action RefreshAction {
			get;
			set;
		}

		private string applyMsgContent;
		public BindGuardianTableSource (List<SearchGuardianListItem> _searchGuardianInfoList,UIViewController _controller,UITableView view)
		{
			SearchGuardianInfoList = _searchGuardianInfoList;
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
			return	SearchGuardianInfoList.Count;
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
			var item = SearchGuardianInfoList [indexPath.Row];
			var  cell = tableView.DequeueReusableCell (BindGuardianTableViewCell.Key) as BindGuardianTableViewCell;
			if (cell == null) {
				cell = BindGuardianTableViewCell.CreateCell ();
			}
			cell.Accessory = UITableViewCellAccessory.None;
			cell.SelectionStyle = UITableViewCellSelectionStyle.Gray;
			cell.Lbl_Name.Text = FormatUtil.StrVaueFormat (item.TrueName);
			cell.Lbl_PhoneNumber.Text = FormatUtil.StrVaueFormat (item.PhoneNumberOne);
			cell.Lbl_BindStatus.Text = GetGuardianStatus (item.IsPass);
			//解析获取位置
			if (string.IsNullOrEmpty (item.ContactAddress))
				cell.Lbl_Location.Text = string.Empty;
			else {
				if (item.ContactAddress.Contains ("|"))
					cell.Lbl_Location.Text = item.ContactAddress.Split (new char[]{ '|' }) [1];
				else
					cell.Lbl_Location.Text = item.ContactAddress;
			}
			//性别
			var imgSexname = item.Sex == Sex.Male ? "ic_sex_man.png" : "ic_sex_woman.png";
			cell.Img_Sex.Image = UIImage.FromFile (imgSexname);
			SetbtnAction(cell.Btn_Action,item.IsPass);//设置操作按钮文字和可用状态
				

			cell.Btn_Action.Tag = indexPath.Row;
			//按钮绑定事件 		
			cell.Btn_Action.TouchUpInside -= ActionHandler;
			cell.Btn_Action.TouchUpInside += ActionHandler;

			//set imgeHead
			cell.Img_Head.SetImage(new NSUrl(item.HeadImgReleaseUrl),UIImage.FromFile("myInfomation_headImage.png"));
			return cell;
		}
		/// <summary>
		/// Gets the guardian status.
		/// </summary>
		/// <returns>The guardian status.</returns>
		/// <param name="guardianStatus">Guardian status.</param>
		private string GetGuardianStatus(string guardianStatus)
		{
			switch (guardianStatus) {
			case "0":
				return "等待对方处理申请";

			case "1":
				return "对方已同意申请";
			case "2":
				return "对方已拒绝申请";

			default:
				return string.Empty;
			}
		}
		private void SetbtnAction(UIButton btn_action,string guardianStatus)
		{
			switch (guardianStatus) {
			case "0"://审核中
				btn_action.SetTitle("申请绑定",UIControlState.Normal);

				btn_action.Enabled = true;
				btn_action.BackgroundColor = Color.Blue;
				break;

			case "1"://同意
				btn_action.SetTitle("已绑定",UIControlState.Normal);
				btn_action.Enabled = false;
				btn_action.BackgroundColor = Color.LightGray;
				break;

			case "2"://未同意
				btn_action.SetTitle("申请绑定",UIControlState.Normal);
				btn_action.Enabled = true;
				btn_action.BackgroundColor = Color.Blue;
				break;

			default:
				btn_action.SetTitle("申请绑定",UIControlState.Normal);
				btn_action.Enabled = true;
				btn_action.BackgroundColor = Color.Blue;
				break;

			}
		}
		private void ActionHandler(object sender, EventArgs e)
		{
			NSObject observer = null;
			//var item = (sender as UIButton).ValueForKey (BindGuardianTableViewCell.Key) as  SearchGuardianListItem;

			var index = (int)(sender as UIButton).Tag;
			var item = SearchGuardianInfoList[index];
			UITextField txtMsgContent = null;
			//留言内容
			applyMsgContent = item.Remark;
			Action removeTextFieldObserver = () => {
				if(txtMsgContent!=null)
					txtMsgContent.ResignFirstResponder();
				if(observer !=null)
					NSNotificationCenter.DefaultCenter.RemoveObserver(observer);
			};
			var applyBindAlertController = UIAlertController.Create ("申请绑定", "", UIAlertControllerStyle.Alert);
			applyBindAlertController.AddTextField ((textfield) => {
				txtMsgContent = textfield;
				textfield.Placeholder = "请输入申请留言";
				textfield.Text = FormatUtil.StrVaueFormat(item.Remark);
				textfield.Frame = new CoreGraphics.CGRect(textfield.Frame.X,textfield.Frame.Y,textfield.Frame.Width,textfield.Frame.Height +30);
				observer = NSNotificationCenter.DefaultCenter.AddObserver(UITextField.TextFieldTextDidChangeNotification,HandleTextFieldTextDidChangeNotification);
			});
			var sendAction = UIAlertAction.Create ("发送", UIAlertActionStyle.Default, (action) => {
				removeTextFieldObserver();
				ApplyBindGuardian(item,applyMsgContent);
			});
			var cancelAction = UIAlertAction.Create ("取消", UIAlertActionStyle.Cancel, (action) => {
				removeTextFieldObserver();
			});
			SendAction = sendAction;
			if (FormatUtil.StrVaueFormat (item.Remark).Length <= 0)
				sendAction.Enabled = false;
			else
				sendAction.Enabled = true;
			
			//add the actions
			applyBindAlertController.AddAction (sendAction);
			applyBindAlertController.AddAction (cancelAction);
			controller.PresentViewController (applyBindAlertController, true, null);
				
		}

		private void HandleTextFieldTextDidChangeNotification(NSNotification notification)
		{
			var textField = notification.Object as UITextField;
			SendAction.Enabled = textField.Text.Length >= 1;
			applyMsgContent = textField.Text;
		}

		/// <summary>
		/// 申请绑定监护人
		/// </summary>
		/// <param name="item">Item.</param>
		/// <param name="applyMsgContent">Apply message content.</param>
		private void ApplyBindGuardian(SearchGuardianListItem item,string applyMsgContent)
		{


			BTProgressHUD.Show("正在申请中...",-1,ProgressHUD.MaskType.Black);
			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;

			applyBindGuardianParam.GId = item.UId;
			applyBindGuardianParam.ApplyContent = applyMsgContent;
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", applyBindGuardianParam.Key);
			else
				requestParams ["key"] = applyBindGuardianParam.Key;

			if (!requestParams.ContainsKey ("eapplycontent"))
				requestParams.Add ("eapplycontent", applyBindGuardianParam.EapplyContent);
			else
				requestParams ["eapplycontent"] = applyBindGuardianParam.EapplyContent;

			if (!requestParams.ContainsKey ("eUserId"))
				requestParams.Add ("eUserId", applyBindGuardianParam.EuserId);
			else
				requestParams ["eUserId"] = applyBindGuardianParam.EuserId;

			if (!requestParams.ContainsKey ("egid"))
				requestParams.Add ("egid", applyBindGuardianParam.Egid);
			else
				requestParams ["egid"] = applyBindGuardianParam.Egid;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", applyBindGuardianParam.EAction);
			else
				requestParams ["eaction"] = applyBindGuardianParam.EAction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", applyBindGuardianParam.Md5);
			else
				requestParams ["md5"] = applyBindGuardianParam.Md5;
			//设置restsharprequest
			if (restSharpRequestUtil == null)
				restSharpRequestUtil = new RestSharpRequestUtil (applyBindGuardianParam.Url, requestParams);
			else {
				restSharpRequestUtil.RequestParams = requestParams;
				restSharpRequestUtil.Url = applyBindGuardianParam.Url;
			}

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
					var applyGuardianJson = JsonConvert.DeserializeObject<ApplyForGuardianJson>(result);

					if(applyGuardianJson.statuscode == "1")
					{
						if(applyGuardianJson.data == "1")
						{
							InvokeOnMainThread(()=>
								{
									BTProgressHUD.ShowSuccessWithStatus("申请绑定监护人成功",1000);
									if(RefreshAction!=null)
										RefreshAction();
								});
						}
						else
						{
							InvokeOnMainThread(()=>
								{
									BTProgressHUD.ShowToast("申请绑定失败，稍后在试...",showToastCentered:false,timeoutMs:1000);
								});
						}
					}
					else
					{
						InvokeOnMainThread(()=>
							{
								BTProgressHUD.ShowToast("申请绑定失败，稍后在试...",showToastCentered:false,timeoutMs:1000);
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

