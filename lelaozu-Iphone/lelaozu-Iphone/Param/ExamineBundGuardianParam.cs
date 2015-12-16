using System;


namespace lelaozuIphone
{
	public class ExamineBundGuardianParam:BaseParam
	{
		public ExamineBundGuardianParam ()
		{
		}
		public override string Action {
			get {
				return "ExamineBundGuardian";
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
		public string Ifagreen {
			get;
			set;
		}
		public string Eifagreen {
			get{
				return EnDeCryptUtil.Encrypt (Ifagreen);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptUtil.MD5Encrypt (EAction+Eid+Eifagreen+Key,Key);

			}
		}
	}
}

