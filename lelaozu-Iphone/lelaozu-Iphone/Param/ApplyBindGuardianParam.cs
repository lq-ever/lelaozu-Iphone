using System;


namespace lelaozuIphone
{
	/// <summary>
	/// 申请绑定监护人
	/// </summary>
	public class ApplyBindGuardianParam:BaseParam
	{
		public ApplyBindGuardianParam ()
		{
		}
		public override string Action {
			get {
				return "ApplyForGuardian";
			}
		}
		public override string ServiceFileName {
			get {
				return Constants.GuardianServiceName;
			}
		}

		public string ApplyContent {
			get;
			set;
		}
		public string EapplyContent {
			get{
				return EnDeCryptUtil.Encrypt (ApplyContent);
			}
		}
		public string UserId {
			get;
			set;
		}
		public string EuserId
		{
			get{
				return EnDeCryptUtil.Encrypt (UserId);
			}
		}
		public string GId {
			get;
			set;
		}
		public string Egid {
			get {
				return EnDeCryptUtil.Encrypt (GId);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptUtil.MD5Encrypt (EAction + EapplyContent + EuserId + Egid + Key, Key);
			}
		}
	}
}

