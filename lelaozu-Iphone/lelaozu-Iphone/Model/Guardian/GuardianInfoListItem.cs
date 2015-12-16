using System;
using Foundation;

namespace lelaozuIphone
{
	public class GuardianInfoListItem:NSObject
	{
		public GuardianInfoListItem ()
		{
		}
		public string Id {
			get;
			set;
		}
		public string UId {
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
		public string TrueName {
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

		public string PhoneNumberOne {
			get;
			set;
		}

		public string ContactAddress {
			get;
			set;
		}
	}
}

