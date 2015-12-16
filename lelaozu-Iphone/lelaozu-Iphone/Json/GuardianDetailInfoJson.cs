using System;
using System.Collections.Generic;

namespace lelaozuIphone
{
	public class GuardianDetailInfoJson:BaseJson 
	{
		public GuardianDetailInfoJson ()
		{
			data = new List<GuardianDetailInfoItem> ();
		}
		public List<GuardianDetailInfoItem> data {
			get;
			set;
		}
	}
}

