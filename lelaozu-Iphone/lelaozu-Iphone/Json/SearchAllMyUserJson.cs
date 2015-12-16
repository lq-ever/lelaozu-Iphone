using System;
using System.Collections.Generic;


namespace lelaozuIphone
{
	public class SearchAllMyUserJson:BaseJson
	{
		public SearchAllMyUserJson ()
		{
			data = new List<AllMyUserListItem> ();
		}
		public List<AllMyUserListItem> data {
			get;
			set;
		}
	}



}

