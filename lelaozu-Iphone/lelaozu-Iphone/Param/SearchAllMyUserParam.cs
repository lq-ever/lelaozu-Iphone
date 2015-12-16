using System;


namespace lelaozuIphone
{
	public class SearchAllMyUserParam:BaseParam
	{
		public SearchAllMyUserParam ()
		{
		}
		public override string Action {
			get {
				return "SearchAllMyUser";
			}
		}
		public override string ServiceFileName {
			get {
				return Constants.AlarmServiceName;
			}
		}
		public string UserId {
			get;
			set;
		}
		public string EuserId
		{
			get{
				return	EnDeCryptUtil.Encrypt (UserId);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptUtil.MD5Encrypt (EuserId + EAction + Key, Key);
			}
		}
	}
}

