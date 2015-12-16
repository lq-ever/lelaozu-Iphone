using System;


namespace lelaozuIphone
{
	public class GuardianMeInfoListParam:BaseParam
	{
		public GuardianMeInfoListParam ()
		{
		}
		public override string Action {
			get {
				return "CustodyMeUsers";
			}
		}
		public override string ServiceFileName {
			get {
				return Constants.GuardianServiceName;
			}
		}
		public string UserId {
			get;
			set;
		}
		public string EuserId
		{
			get{
				return EnDeCryptUtil.Encrypt (UserId);
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
				return EnDeCryptUtil.MD5Encrypt (EAction + EuserId + EpageIndex + EpageSize + Key, Key);
			}
		}

	}
}

