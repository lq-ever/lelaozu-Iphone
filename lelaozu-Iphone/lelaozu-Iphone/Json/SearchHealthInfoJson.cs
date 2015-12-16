using System;
using System.Collections.Generic;

namespace lelaozuIphone
{
	public class SearchHealthInfoJson:BaseJson 
	{
		public SearchHealthInfoJson ()
		{
			data = new HealthInfoListdataJson();
		}
		public HealthInfoListdataJson data {
			get;
			set;
		}
	}

	public class HealthInfoListdataJson
	{
		public HealthInfoListdataJson()
		{
			items = new List<HealthInfoItem> ();
		}
		public int total {
			get;
			set;
		}
		public List<HealthInfoItem> items {
			get;
			set;
		}
	}

}

