using System;


namespace lelaozuIphone
{
	public class AdviceWriteParam:BaseParam
	{
		public AdviceWriteParam ()
		{
		}
		public override string Action {
			get {
				return "WriteAdvice";
			}
		}
		public override string ServiceFileName {
			get {
				return Constants.AdviceInfoServiceName;
			}
		}
		public string UId {
			get;
			set;
		}
		public string Euid
		{
			get {
				return EnDeCryptUtil.Encrypt (UId);
			}
		}
		public string AdviceType {
			get;
			set;
		}
		public string EadviceType {
			get {
				return EnDeCryptUtil.Encrypt (AdviceType);
			}
		}
		public string PlatformType
		{
			get{
				return "0";//个人中心
			}
		}
		public string EplatformType
		{
			get{
				return EnDeCryptUtil.Encrypt (PlatformType);
			}
		}
		public string AdviceTitle {
			get;
			set;
		}
		public string EadviceTitle
		{
			get{
				return EnDeCryptUtil.Encrypt (AdviceTitle);
			}
		}
		public string AdviceContent {
			get;
			set;
		}
		public string EadviceContent
		{
			get{
				return EnDeCryptUtil.Encrypt (AdviceContent);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptUtil.MD5Encrypt (EAction + EadviceType+EadviceTitle+EadviceContent + Euid + EplatformType+Key, Key);
			}
		}

	}
}

