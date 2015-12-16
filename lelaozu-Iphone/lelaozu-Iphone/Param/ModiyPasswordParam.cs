using System;


namespace lelaozuIphone
{
	public class ModiyPasswordParam:BaseParam
	{
		public ModiyPasswordParam ()
		{
		}
		public override string Action {
			get {
				return "ModiyPassword";
			}
		}
		public override string ServiceFileName {
			get {
				return Constants.RegistLoginServiceName;
			}
		}
		public string UId {
			get;
			set;
		}
		public string Euid
		{
			get{
				return EnDeCryptUtil.Encrypt (UId);
			}
		}

		public string Password {
			get;
			set;
		}

		public string Epassword
		{
			get{
				return EnDeCryptUtil.Encrypt (Password);
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
				return EnDeCryptUtil.MD5Encrypt (Euid + Epassword + Etype + EAction + Key, Key);
			}
		}

	}
}

