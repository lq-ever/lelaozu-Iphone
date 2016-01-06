using System;
using JPush;
using Foundation;
using UIKit;


namespace lelaozuIphone
{
	public class JPushUtils:NSObject
	{
		
		private string guidAsAlias = string.Empty;
		public JPushUtils (UIViewController _controller)
		{
			
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
			guidAsAlias = alias;
			//调用极光接口设置别名
			APService.SetAlias(guidAsAlias,new ObjCRuntime.Selector ("tagsAliasCallback:tags:alias:"),this);

		}
		/// <summary>
		/// Tagses the alias callback.注册极光别名回调函数
		/// </summary>
		/// <param name="iResCode">I res code.</param>
		/// <param name="tags">Tags.</param>
		/// <param name="alias">Alias.</param>
		[Export("tagsAliasCallback:tags:alias:")]
		public void tagsAliasCallback(int iResCode,NSSet tags,NSString alias)
		{

			Console.WriteLine (string.Format ("resultcode:{0};nsstring alias {1}",iResCode,alias));
			if (iResCode == 0) {
				Console.WriteLine ("register alias sucess");
				//write userdefaults
				NSUserDefaults.StandardUserDefaults.SetString (guidAsAlias, Constants.JPush_Alias);
			}
			else
				//调用极光接口设置别名
				APService.SetAlias(guidAsAlias,new ObjCRuntime.Selector ("tagsAliasCallback:tags:alias:"),this);

		}
	}
}

