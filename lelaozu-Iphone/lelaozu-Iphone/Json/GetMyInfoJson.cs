using System;
using System.Collections.Generic;


namespace lelaozuIphone
{
	public class GetMyInfoJson:BaseJson
	{
		public GetMyInfoJson ()
		{
			data = new List<PersonInfoItem>();
		}
		public  List<PersonInfoItem> data {
			get;
			set;
		}
	}
}

