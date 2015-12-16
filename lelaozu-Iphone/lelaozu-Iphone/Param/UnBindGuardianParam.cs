using System;


namespace lelaozuIphone
{
	/// <summary>
	/// 解绑参数对象
	/// </summary>
	public class UnBindGuardianParam:BaseParam
	{
		public UnBindGuardianParam ()
		{
			
		}
		public override string Action {
			get {
				return "UnBundGuardian";
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

