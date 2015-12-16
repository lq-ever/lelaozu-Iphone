using System;

namespace lelaozuIphone
{
	public class FormatUtil
	{
		public FormatUtil ()
		{
		}
		public static string StrVaueFormat(string strValue)
		{
			return string.IsNullOrEmpty (strValue) ? string.Empty : strValue;
		}
		public static string StrToTimeFormat(string strVlaue)
		{
			if (string.IsNullOrEmpty (strVlaue))
				return string.Empty;
			return Convert.ToDateTime (strVlaue).ToString ("yyyy-MM-dd HH:mm:ss");
		}
		public static string StrToShortData(string strVlaue)
		{
			if (string.IsNullOrEmpty (strVlaue))
				return string.Empty;
			return Convert.ToDateTime (strVlaue).ToString ("yyyy-MM-dd");
		}
	}
}

