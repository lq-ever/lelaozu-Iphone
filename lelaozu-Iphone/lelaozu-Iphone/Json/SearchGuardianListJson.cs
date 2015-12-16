using System;
using System.Collections.Generic;


namespace lelaozuIphone
{
	public class SearchGuardianListJson:BaseJson
	{
		public SearchGuardianListJson ()
		{
			data = new List<SearchGuardianListItem> ();
		}
		public List<SearchGuardianListItem> data {
			get;
			set;
		}
	}
}

