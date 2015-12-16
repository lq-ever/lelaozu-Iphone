using System;


namespace lelaozuIphone
{
	public class UpdateMyInfoParam:BaseParam
	{
		public UpdateMyInfoParam ()
		{
		}
		public override string Action {
			get {
				return string.Empty;
			}
		}
		public override string ServiceFileName {
			get {
				return Constants.UpdatePersonServiceName;
			}
		}
		public string Uid {
			get;
			set;
		}
		public string Euid
		{
			get{
				return EnDeCryptUtil.Encrypt (Uid);
			}
		}
		public string ParamType {
			get;
			set;
		}
		public string EparamType
		{
			get{
				return EnDeCryptUtil.Encrypt (ParamType);
			}
		}
		public string ParamValue {
			get;
			set;
		}
		public string EparamValue
		{
			get{
				return EnDeCryptUtil.Encrypt (ParamValue);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptUtil.MD5Encrypt (Euid + EparamType + EparamValue + Key, Key);
			}
		}
	}
}

