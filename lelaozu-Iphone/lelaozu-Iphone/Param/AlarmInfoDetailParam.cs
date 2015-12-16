using System;


namespace lelaozuIphone
{
	public class AlarmInfoDetailParam:BaseParam
	{
		public AlarmInfoDetailParam ()
		{
		}
		public override string Action {
			get {
				return "SearchAlarmDetailInfor";
			}
		}
		public override string ServiceFileName {
			get {
				return Constants.AlarmServiceName;
			}
		}
		/// <summary>
		/// 报警Id
		/// </summary>
		/// <value>A identifier.</value>
		public string AId {
			get;
			set;
		}
		public string EaId
		{
			get{
				return EnDeCryptUtil.Encrypt (AId);
			}
		}

		public override string Md5 {
			get {
				return EnDeCryptUtil.MD5Encrypt (EaId + EAction + Key, Key);
			}
		}
	}
}

