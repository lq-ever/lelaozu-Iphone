using System;

using UIKit;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace lelaozuIphone
{
	public partial class WriteAdviceViewController : UIViewController
	{
		private string _adviceType = ((int)AdviceType.Consult).ToString();
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();

		private UIAlertController alertAdviceTypeController;//建议类型controller
		private UIPickerView pickerView;//建议类型 pickerView
		public WriteAdviceViewController () : base ("WriteAdviceViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			txt_adviceType.Text = "咨询";
			InitAdviceTypePicker ();
			//publish
			btn_publish.TouchUpInside += (sender, e) => 
			{
				PublishAdvice();
			};
			scrollView.ContentSize = new CoreGraphics.CGSize (scrollView.Frame.Width, scrollView.Frame.Height + 10);

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

		private void PublishAdvice()
		{
			var adviceTitle = txt_adviceTitle.Text;
			if (string.IsNullOrEmpty (adviceTitle)) {
				BTProgressHUD.ShowToast ("留言标题不能为空,请输入标题",showToastCentered:false,timeoutMs:1000);
				return ;
			}
			var adviceContent = txt_adviceContent.Text;
			if (string.IsNullOrEmpty (adviceContent)) {
				BTProgressHUD.ShowToast ("留言内容不能为空,请输入留言内容",showToastCentered:false,timeoutMs:1000);
				return ;
			}


			BTProgressHUD.Show("正在发表...",-1,ProgressHUD.MaskType.Black);
			//在状态栏中设置show网络指示器
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;
			//调用restapi注册,将用户名、密码信息写
			var adviceWriteParam = new AdviceWriteParam () {
				UId = Constants.MyInfo.UId,AdviceType = _adviceType,AdviceTitle = adviceTitle,AdviceContent = adviceContent
			};
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", adviceWriteParam.Key);
			else
				requestParams ["key"] = adviceWriteParam.Key;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", adviceWriteParam.EAction);
			else
				requestParams ["eaction"] = adviceWriteParam.EAction;

			if (!requestParams.ContainsKey ("eUId"))
				requestParams.Add ("eUId", adviceWriteParam.Euid);
			else
				requestParams ["eUId"] = adviceWriteParam.Euid;

			if (!requestParams.ContainsKey ("eAdviceType"))
				requestParams.Add ("eAdviceType", adviceWriteParam.EadviceType);
			else
				requestParams ["eAdviceType"] = adviceWriteParam.EadviceType;

			if (!requestParams.ContainsKey ("ePlatformType"))
				requestParams.Add ("ePlatformType", adviceWriteParam.EplatformType);
			else
				requestParams ["ePlatformType"] = adviceWriteParam.EplatformType;

			if (!requestParams.ContainsKey ("eAdviceTitle"))
				requestParams.Add ("eAdviceTitle", adviceWriteParam.EadviceTitle);
			else
				requestParams ["eAdviceTitle"] = adviceWriteParam.EadviceTitle;

			if (!requestParams.ContainsKey ("eAdviceContent"))
				requestParams.Add ("eAdviceContent", adviceWriteParam.EadviceContent);
			else
				requestParams ["eAdviceContent"] = adviceWriteParam.EadviceContent;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", adviceWriteParam.Md5);
			else
				requestParams ["md5"] = adviceWriteParam.Md5;	

			var restSharpRequestUtil = new RestSharpRequestUtil(adviceWriteParam.Url,requestParams);
			restSharpRequestUtil.ExcuteAsync((RestSharp.IRestResponse response) => 
				{
					InvokeOnMainThread(()=>
						{
							BTProgressHUD.Dismiss();
							//在状态栏中hide使用网络指示器
							UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
						});
					if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						//获取并解析返回resultJson获取安全码结果值
						var result = response.Content;
						var adviceWriteJson = JsonConvert.DeserializeObject<AdviceWriteJson>(result);
						if(adviceWriteJson.statuscode == "1")
						{
							InvokeOnMainThread(()=>
								{
									BTProgressHUD.ShowSuccessWithStatus("保存成功",1000);
								});
						}
						else
						{
							
							InvokeOnMainThread(()=>
								{
									BTProgressHUD.ShowToast(adviceWriteJson.message,showToastCentered:false,timeoutMs:1000);
								});
						}
					}
					else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut){
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
								BTProgressHUD.ShowErrorWithStatus(Constants.ErrorStatusDes,1000);
							});
					}

				});

		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}

	public class AdviceTypeItem
	{
		public string AdviceTypeId {
			get;
			set;
		}
		public string AdviceTypeDesc {
			get;
			set;
		}

		public override string ToString ()
		{
			return AdviceTypeDesc;
		}
	}
}


