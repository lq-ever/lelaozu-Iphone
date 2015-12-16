using System;


namespace lelaozuIphone
{
	public class GuardianDetailInfoParam:BaseParam
	{
		//监护人详情
		public GuardianDetailInfoParam ()
		{
		}
		public override string Action {
			get {
				return "SeachUserDetail";
			}
		}
		public override string ServiceFileName {
			get {
				return Constants.GuardianServiceName;
			}
		}
		public string Id {
			get;
			set;
		}
		public string Eid {
			get{
				return EnDeCryptUtil.Encrypt (Id);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptUtil.MD5Encrypt (EAction+Eid+Key,Key);
			}
		}
	}
}

