using System;


namespace lelaozuIphone
{
	public class SendCodeParam:BaseParam
	{
		public SendCodeParam ()
		{
		}
		public override string Action {
			get {
				return "SendCode";
			}
		}
		public override string ServiceFileName {
			get {
				return Constants.RegistLoginServiceName;
			}
		}
		public string PhoneNumberOne {
			get;
			set;
		}
		public string EphoneNumberOne
		{
			get{
				return EnDeCryptUtil.Encrypt (PhoneNumberOne);
			}
		}
		public string Type {
			get;
			set;
		}
		public string Etype
		{
			get{
				return EnDeCryptUtil.Encrypt (Type);
			}
		}

		public override string Md5 {
			get {
				return EnDeCryptUtil.MD5Encrypt (EphoneNumberOne + Etype + EAction + Key, Key);
			}
		}
	}
}

