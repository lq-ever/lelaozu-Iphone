using System;


namespace lelaozuIphone
{
	public class AdviceRecordInfoListParam:BaseParam
	{
		public AdviceRecordInfoListParam ()
		{
		}
		public override string Action {
			get {

				return "GetAdviceRecod";
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
		public string EadviceType
		{
			get{
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
		/// <summary>
		/// 当前页码
		/// </summary>
		/// <value>The index of the page.</value>
		public string PageIndex {
			get;
			set;
		}
		public string EpageIndex
		{
			get{
				return EnDeCryptUtil.Encrypt(PageIndex);
			}
		}

		/// <summary>
		/// 每页数
		/// </summary>
		/// <value>The size of the page.</value>
		public string PageSize
		{
			get{
				return "6";
			}
		}
		public string EpageSize
		{
			get {
				return EnDeCryptUtil.Encrypt (PageSize);
			}
		}

		public override string Md5 {
			get {
				return EnDeCryptUtil.MD5Encrypt(EAction + EadviceType + Euid  + EpageIndex + EpageSize +EplatformType+ Key, Key);
			}
		}




	}
}

