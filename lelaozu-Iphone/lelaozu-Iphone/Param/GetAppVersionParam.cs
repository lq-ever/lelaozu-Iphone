using System;


namespace lelaozuIphone
{
	public class GetAppVersionParam:BaseParam
	{
		public GetAppVersionParam ()
		{
		}
		public override string Action {
			get {
				return string.Empty;
			}
		}
		public override string ServiceFileName {
			get {
				return Constants.GetAppVersionServiceName;
			}
		}
		public string AppPlatform {
			get{
				return Constants.App_Platform;
			}
		}
		public string EappPlatform
		{
			get{
				return EnDeCryptUtil.Encrypt (AppPlatform);
			}
		}
		public string PackageName
		{
			get{
				return Constants.Package_Name;
			}
		}
		public string EpackageName
		{
			get{
				return EnDeCryptUtil.Encrypt (PackageName);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptUtil.MD5Encrypt (EappPlatform + EpackageName + Key, Key);
			}
		}
	}
}

