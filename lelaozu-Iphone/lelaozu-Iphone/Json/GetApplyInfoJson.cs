using System;
using System.Collections.Generic;


namespace lelaozuIphone
{
	public class GetApplyInfoJson:BaseJson
	{
		public GetApplyInfoJson ()
		{
			data = new List<GetApplyInfoListItem> ();
		}
		public List<GetApplyInfoListItem> data {
			get;
			set;
		}
	}
}

