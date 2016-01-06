using System;
using JPush;
using Foundation;
using UIKit;


namespace lelaozuIphone
{
	public class JPushUtils
	{
		private UIViewController controller;
		public JPushUtils (UIViewController _controller)
		{
			controller = _controller;
		}
		/// <summary>
		/// Sets the alias.设置别名
		/// </summary>
		/// <param name="alias">Alias.</param>
		public void SetAlias(string alias)
		{
			if(string.IsNullOrEmpty(alias))
				return;
			if(!RegexUtil.IsValidTagAndAlias(alias))
				return;
			//判断是否已经设置过别名，若设置过，将不在设置
			var jpush_alias = NSUserDefaults.StandardUserDefaults.StringForKey (Constants.JPush_Alias);
			if (alias == jpush_alias)
				return;
			//调用极光接口设置别名
			APService.SetAlias(alias,new ObjCRuntime.Selector ("CallBack"),controller);

		}
		[Export("CallBack")]
		public void CallBackSelector(int iResCode,NSSet tags,NSString alias)
		{
			Console.WriteLine (string.Format ("resultcode:{0};nsstring alias {1}",iResCode,alias));
		}
	}
}

