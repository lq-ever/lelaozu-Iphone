using System;


namespace lelaozuIphone
{
	/// <summary>
	/// 搜索会员
	/// </summary>
	public class SearchGuardianParam:BaseParam
	{
		public SearchGuardianParam ()
		{
		}
		public override string Action {
			get {
				return "SearchUserInforByCondition";
			}
		}
		public override string ServiceFileName {
			get {
				return Constants.GuardianServiceName;
			}
		}
		public string Condition {
			get;
			set;
		}
		public string Econdition
		{
			get{
				return EnDeCryptUtil.Encrypt (Condition);
			}
		}
		public string Guid {
			get;
			set;
		}
		public string Eguid
		{
			get{
				return EnDeCryptUtil.Encrypt(Guid);
			}
		}

		public override string Md5 {
			get {
				return EnDeCryptUtil.MD5Encrypt (EAction + Econdition +Eguid+ Key, Key);
			}
		} 
	}
}

