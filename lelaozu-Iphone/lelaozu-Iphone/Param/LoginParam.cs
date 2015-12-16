using System;

namespace lelaozuIphone
{
	/// <summary>
	/// Login parameter.
	/// </summary>
	public class LoginParam:BaseParam
	{
		public LoginParam ()
		{
		}
		public string LoginName {
			get;
			set;
		}
		public string ELoginName
		{
			get{
				return	EnDeCryptUtil.Encrypt (LoginName);
			}
		}
		public string LoginPwd {
			get;
			set;
		}
		public string ELoginPwd
		{
			get{
				return EnDeCryptUtil.Encrypt (LoginPwd);
			}
		}
		public override string Action {
			get {
				return "Login";
			}
		}
		public override string ServiceFileName {
			get {
				return Constants.RegistLoginServiceName;
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptUtil.MD5Encrypt (EAction + ELoginName + ELoginPwd + Key, Key);
			}
		}
	}
}

