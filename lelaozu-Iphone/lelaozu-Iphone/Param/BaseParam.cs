using System;

namespace lelaozuIphone
{
	public abstract class BaseParam
	{
		/// <summary>
		/// Gets the key.服务key
		/// </summary>
		/// <value>The key.</value>
		public string Key
		{
			get{
				return Constants.key;
			}
		}

		public abstract string Action {
			get;
		}
		/// <summary>
		/// Gets the E action.服务方法参数
		/// </summary>
		/// <value>The E action.</value>
		public string EAction
		{
			get{
				return EnDeCryptUtil.Encrypt (Action);
			}
		}
	
		/// <summary>
		/// Gets the name of the service file. 服务文件名
		/// </summary>
		/// <value>The name of the service file.</value>
		public abstract string ServiceFileName {
			get;
		}
		/// <summary>
		/// Gets the URL.服务地址
		/// </summary>
		/// <value>The URL.</value>
		public string Url
		{
			get{
				return Constants.ServiceDomainPath + ServiceFileName;
			}
		}

		public abstract string Md5 {
			get;
		}
	}
}

