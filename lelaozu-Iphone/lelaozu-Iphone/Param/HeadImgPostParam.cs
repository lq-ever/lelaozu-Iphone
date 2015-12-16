using System;


namespace lelaozuIphone
{
	public class HeadImgPostParam:BaseParam
	{
		public HeadImgPostParam ()
		{
		}
		public override string Action {
			get {
				return string.Empty;
			}
		}
		public override string ServiceFileName {
			get {
				return Constants.HeadImgServiceName;
			}
		}
		public string UId {
			get;
			set;
		}

		public string Euid
		{
			get{
				return EnDeCryptUtil.Encrypt(UId);
			}
		}
		public string ImageStr {
			get;
			set;
		}
		public string EimageStr
		{
			get{
				return EnDeCryptUtil.Encrypt (ImageStr);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptUtil.MD5Encrypt (Euid +EimageStr+ Key, Key);
			}
		}

	}
}

