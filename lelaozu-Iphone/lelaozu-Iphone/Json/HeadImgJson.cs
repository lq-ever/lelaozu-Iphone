using System;
using System.Collections.Generic;

namespace lelaozuIphone
{
	public class HeadImgJson:BaseJson
	{
		public HeadImgJson ()
		{
			data = new List<ImgJsonData>();
		}
		public List<ImgJsonData> data {
			get;
			set;
		}
	}
	public class ImgJsonData
	{
		public string HeadImgUrl {
			get;
			set;
		}
	}
}

