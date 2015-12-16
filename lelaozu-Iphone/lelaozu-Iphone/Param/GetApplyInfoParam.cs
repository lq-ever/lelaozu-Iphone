using System;


namespace lelaozuIphone
{
	public class GetApplyInfoParam:BaseParam
	{
		public GetApplyInfoParam ()
		{
		}
		public override string Action {
			get {
				return "GetApplyInfor";
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

		public string Eid
		{
			get {
				return EnDeCryptUtil.Encrypt (Id);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptUtil.MD5Encrypt (EAction + Eid + Key, Key);
			}
		}
	}
}

