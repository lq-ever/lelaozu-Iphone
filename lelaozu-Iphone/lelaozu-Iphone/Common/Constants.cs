
using System;
using UIKit;
using CoreGraphics;
using Foundation;

namespace lelaozuIphone
{
	public class Constants
	{
		public Constants ()
		{
		}

		/// <summary>
		/// The app platform.APP版本名称 
		/// </summary>
		public const string App_Platform ="Ios";

		public const string Package_Name ="com.eldyoung.lelaozu";

		/// <summary>
		/// app  The CF bundle version.build code
		/// </summary>
		public const string CFBundleVersion = "CFBundleVersion";
		/// <summary>
		/// The CF bundle short version string.app verson code
		/// </summary>
		public const string CFBundleShortVersionString = "CFBundleShortVersionString";

		/// <summary>
		/// The current version.bulid "CFBundleVersion" or version "CFBundleShortVersionString"
		/// </summary>
		public static string CurrentVersionCode = NSBundle.MainBundle.InfoDictionary [Constants.CFBundleVersion].ToString();

		/// <summary>
		/// The last version string.版本标识
		/// </summary>
		public const string LastVersionStr = "LastVersion";

		/// <summary>
		/// The last version code.
		/// </summary>
		public static string LastVersionCode = NSUserDefaults.StandardUserDefaults.StringForKey(Constants.LastVersionStr);

		public const string Remember_Check= "Remember_Check";
		public const string Login_UserName ="UserName";
		public const string Login_PassWorde ="PassWord";

		/// <summary>
		/// The J push alias.
		/// </summary>
		public const string JPush_Alias = "Alias";

		public static bool PushNot = false;
		public static string PushAlarmId= string.Empty;

		public const string ErrorStatusDes="未知错误，请联系管理员...";

		/// <summary>
		/// The has login.程序是否已经登录
		/// </summary>
		public static bool HasLogin = false;

		/// <summary>
		/// The screen frame.
		/// </summary>
		public static CGRect Screen_Frame = UIScreen.MainScreen.Bounds;

		/// <summary>
		/// The width of the screen.
		/// </summary>
		public static nfloat Screen_Width = Screen_Frame.Size.Width;
		/// <summary>
		/// The height of the screen.
		/// </summary>
		public static nfloat Screen_Height = Screen_Frame.Size.Height;

		/// <summary>
		/// The key.调用服务key
		/// </summary>
		public const string key="yiyang";

		/// <summary>
		/// The service domain path.服务域名
		/// </summary>
		public const string ServiceDomainPath="http://dataserver.lelaozu.com/Android/";

		/// <summary>
		/// The web domain path.网站域名
		/// </summary>
		public const string WebDomainPath ="http://i.lelaozu.com";


		/// <summary>
		/// The name of the regist login service.登录注册相关
		/// </summary>
		public const string RegistLoginServiceName = "AndroidDataService.aspx";

		/// <summary>
		/// The name of the alarm service.报警信息相关
		/// </summary>
		public const string AlarmServiceName ="AlarmInforDataService.aspx";

		/// <summary>
		/// The name of the guardian service.监护人信息相关
		/// </summary>
		public const string GuardianServiceName ="UserBind.aspx";

	
		/// <summary>
		/// The name of the health info service.健康体检信息相关
		/// </summary>
		public const string HealthInfoServiceName = "HealthInforDataService.aspx"; 
	
		/// <summary>
		/// The name of the head image service.头像上传
		/// </summary>
		public const string HeadImgServiceName ="SaveHeadImg.aspx";

		/// <summary>
		/// The name of the update person service.个人信息
		/// </summary>
		public const string UpdatePersonServiceName="UpdateBaseInfo.aspx";

		/// <summary>
		/// The name of the get app version service.软件版本
		/// </summary>
		public const string GetAppVersionServiceName ="GetAppVersionService.aspx";

		/// <summary>
		/// The name of the advice info service.投诉建议信息服务
		/// </summary>
		public const string AdviceInfoServiceName= "DoMessageInfor.aspx";

		public static PersonInfoItem MyInfo;


		public const string PullDownLbl = "下拉刷新";
		public const string PullDownRefreshLbl ="正在刷新...";
		public const string PullDownReleaseLbl ="释放即可刷新";

		public const string PullUpLbl ="点击或上拉加载更多";
		public const string PullUpRefreshLbl ="正在加载...";
		public const string PullUpReleaseLbl ="释放即可加载";




	}
}

