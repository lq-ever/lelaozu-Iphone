using System;


namespace lelaozuIphone
{
	/// <summary>
	/// 查询健康信息请求参数类
	/// </summary>
	public class SearchHealthInforParam:BaseParam
	{
		public SearchHealthInforParam ()
		{
		}
		public override string Action {
			get {
				return "SearchHealthInfor";
			}
		}
		public override string ServiceFileName {
			get {
				return Constants.HealthInfoServiceName;
			}
		}
		public string Id {
			get;
			set;
		}
		public string Eid
		{
			get {
				return EnDeCryptUtil.Encrypt (Id);
			}
		}
		public string SearchTime {
			get;
			set;
		}
		public string EsearchTime
		{
			get{
				return EnDeCryptUtil.Encrypt (SearchTime);
			}
		}
		public string PageIndex {
			get;
			set;
		}
		public string EpageIndex
		{
			get {
				return EnDeCryptUtil.Encrypt (PageIndex);
			}
		}
		public string PageSize {
			get {
				return "7";
			}
		}
		public string EpageSize {
			get{
				return EnDeCryptUtil.Encrypt (PageSize);
			}
		}
	    public override string Md5 {
			get {
				return EnDeCryptUtil.MD5Encrypt (EAction + Eid + EsearchTime+EpageIndex+EpageSize + Key, Key);
			}
		}

	}
}

