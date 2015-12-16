using System;


namespace lelaozuIphone
{
	public class GetMyInfoParam:BaseParam
	{
		public GetMyInfoParam ()
		{
		}
		public override string Action {
			get {
				return "GetMyInfo";
			}
		}
		public override string ServiceFileName {
			get {
				return Constants.RegistLoginServiceName;
			}
		}
		public string Uid {
			get;
			set;
		}
		public string Euid
		{
			get{
				return EnDeCryptUtil.Encrypt (Uid);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptUtil.MD5Encrypt (EAction + Euid + Key, Key);
			}
		}
	}
}

