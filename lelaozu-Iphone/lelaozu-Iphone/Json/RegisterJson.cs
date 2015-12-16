using System;

namespace lelaozuIphone
{
	public class RegisterJson:BaseJson
	{
		public RegisterJson ()
		{
			data = new LoginJsonData ();
		}
		public LoginJsonData data {
			get;
			set;
		}
	}
}

