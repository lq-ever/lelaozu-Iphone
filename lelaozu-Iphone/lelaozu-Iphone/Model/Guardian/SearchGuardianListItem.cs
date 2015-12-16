﻿using System;
using Foundation;

namespace lelaozuIphone
{
	public class SearchGuardianListItem:NSObject
	{
		public SearchGuardianListItem ()
		{
		}
		public string UId {
			get;
			set;
		}
		public string UserName {
			get;
			set;
		}
		public string TrueName {
			get;
			set;
		}

		public string PhoneNumberOne {
			get;
			set;
		}
		public string RegisterTime {
			get;
			set;
		}
		public string HeadImgUrl {
			get;
			set;
		}

		public string HeadImgReleaseUrl
		{
			get{
				return Constants.WebDomainPath + HeadImgUrl;
			}
		}

		public string IsPass {
			get;
			set;
		}

		public Sex  Sex {
			get {
				return Gender == "男" ? Sex.Male : Sex.Female;
			}


		}

		public string Gender {
			get;
			set;
		}


		public string ContactAddress {
			get;
			set;
		}


		/// <summary>
		/// 申请的留言
		/// </summary>
		/// <value>The remark.</value>
		public string Remark {
			get;
			set;
		}
	}
}

