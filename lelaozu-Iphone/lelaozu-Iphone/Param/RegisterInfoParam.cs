using System;


namespace lelaozuIphone
{
	public class RegisterInfoParam:BaseParam
	{
		public RegisterInfoParam ()
		{
		}

		public override string Action
		{
			get {
				return "Register";
			}
		}

		public override string ServiceFileName {
			get {
				return Constants.RegistLoginServiceName;
			}
		}
		public string PhoneNumber {
			get;
			set;
		}
		public string EphoneNumber
		{
			get{ return EnDeCryptUtil.Encrypt (PhoneNumber);}
		}
		public string PassWord {
			get;
			set;
		}
		public string EpassWord
		{
			get{
				return EnDeCryptUtil.Encrypt (PassWord);
			}
		}
		public string NickName {
			get;
			set;
		}
		public string EnickName
		{
			get{
				return EnDeCryptUtil.Encrypt (NickName);
			}
		}

		public override string Md5 {
			get{
				return EnDeCryptUtil.MD5Encrypt (EAction+EphoneNumber+EpassWord+EnickName+Key,Key);
			}
		}

	


	}
}

