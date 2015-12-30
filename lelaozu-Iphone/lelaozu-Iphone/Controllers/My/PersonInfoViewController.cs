using System;

using UIKit;
using System.Collections.Generic;

namespace lelaozuIphone
{
	public partial class PersonInfoViewController : UIViewController
	{
		public  List<InfoItem> sectionOneInfoLists = new List<InfoItem>();
		public List<InfoItem>  sectionTwoInfoLists = new List<InfoItem>();
		public List<InfoItem>  secitonThreeInfoLists = new List<InfoItem>(); 
		public PersonInfoViewController () : base ("PersonInfoViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "个人信息";
			tableView.Source = new PersonInfoTableSource (this);
		   
		}

		/// <summary>
		/// Loads the data.
		/// </summary>
		private void LoadData()
		{
			sectionOneInfoLists.Clear ();
			sectionTwoInfoLists.Clear ();
			secitonThreeInfoLists.Clear ();
			//sectionOne
			sectionOneInfoLists.Add (new InfoItem (){Title= "用户名" ,TitleValue = Constants.MyInfo.UserName,IsSkip = false});
			sectionOneInfoLists.Add (new InfoItem (){Title ="真实姓名",TitleValue = FormatUtil.StrVaueFormat(Constants.MyInfo.TrueName),IsSkip = true,FuncType= FuncType.PersonInfoTrueName});
			sectionOneInfoLists.Add (new InfoItem (){Title="身份证号" ,TitleValue = FormatUtil.StrVaueFormat(Constants.MyInfo.IDNumber),IsSkip = false});
			var genderValue = string.Empty;
			if (string.IsNullOrEmpty (Constants.MyInfo.Gender))
				genderValue= "未设置";
			else if (Constants.MyInfo.Gender.Equals ("0"))
				genderValue = "男";
			else if (Constants.MyInfo.Gender.Equals ("1"))
				genderValue = "女";
			sectionOneInfoLists.Add (new InfoItem (){ Title="性别",TitleValue= genderValue,IsSkip = true,FuncType = FuncType.PersonInfoGender});
			sectionOneInfoLists.Add(new InfoItem(){Title="生日",TitleValue= FormatUtil.StrToShortData(Constants.MyInfo.Age),IsSkip= true,FuncType= FuncType.PersonInfoBirth});

			//sectionTwo
			var iphoneNumber = Constants.MyInfo.PhoneNumberOne;
			var resultPhonNumber = string.Empty;
			if (!string.IsNullOrEmpty (iphoneNumber)) {
				var midleStr = iphoneNumber.Substring (3, 4);
				resultPhonNumber = iphoneNumber.Replace (midleStr, "****");
			} 
			sectionTwoInfoLists.Add (new InfoItem (){ Title="手机号码",TitleValue = resultPhonNumber,IsSkip = false});
			sectionTwoInfoLists.Add (new InfoItem (){ Title="固定电话",TitleValue= FormatUtil.StrVaueFormat(Constants.MyInfo.TelePhoneNumber),IsSkip = true,FuncType= FuncType.PersonInfoFixedPhone});
			sectionTwoInfoLists.Add (new InfoItem (){ Title = "电子邮箱",TitleValue = FormatUtil.StrVaueFormat(Constants.MyInfo.Email),IsSkip = true,FuncType = FuncType.PersonInfoEmail});
			//sectionThree
			secitonThreeInfoLists.Add(new InfoItem(){Title="身份证所在地",TitleValue=FormatUtil.StrVaueFormat(Constants.MyInfo.IDAddress),IsSkip = true,FuncType = FuncType.PersonInfoCardLocation});
			tableView.ReloadData ();
		}


		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			LoadData ();
		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}


	public class InfoItem
	{
		public string Title {
			get;
			set;
		}
		public string TitleValue {
			get;
			set;
		}
		public FuncType FuncType {
			get;
			set;
		}
		public bool IsSkip {
			get;
			set;
		}
	}
}


