using System;
using RestSharp;
using System.Collections.Generic;

namespace lelaozuIphone
{
	/// <summary>
	/// Rest sharp request util.
	/// </summary>
	public class RestSharpRequestUtil
	{
		private RestClient client;
		private RestRequest restRequest;

		//public string Url;

		private string _url;
		public string Url {
			get {
				return _url;
			}
			set{
				_url = value;
				client.BaseUrl = new Uri(Url);
			}

		}

		private Dictionary<string,string> requestParams;
		public Dictionary<string,string> RequestParams {
			get {
				return requestParams;
			}
			set {
				requestParams = value;
				SetRestParams ();
			}
		}

//		public RestSharpRequestUtil ()
//		{
//			
//		}
//
//		public RestSharpRequestUtil(string _url)
//		{
//			InitRestSharpRequest (_url);
//		}
//
//		public RestSharpRequestUtil (string _url,Dictionary<string,string> _requestParams)
//		{
//			InitRestSharpRequest (_url);
//			RequestParams = _requestParams;
//
//		}
//
//
//		private void InitRestSharpRequest(string _url)
//		{
//			Url = _url;
//			client = new RestClient(Url);
//
//			restRequest = new RestRequest (Method.POST);
//			restRequest.AddHeader ("Content-Type","application/x-www-form-urlencoded");
//			restRequest.Timeout = 5000;
//
//		}

		public RestSharpRequestUtil()
		{
			client = new RestClient ();
			restRequest = new RestRequest (Method.POST);
			restRequest.AddHeader ("Content-Type","application/x-www-form-urlencoded");
			restRequest.Timeout = 5000;

		}
		public RestSharpRequestUtil(string _url):this()
		{
			Url = _url;
		}

		public RestSharpRequestUtil(string _url,Dictionary<string,string> _requestParams):this(_url)
		{
			RequestParams = _requestParams;
		}


		/// <summary>
		/// 创建请求参数
		/// </summary>
		private void SetRestParams()
		{
			if (restRequest.Parameters != null && restRequest.Parameters.Count > 0)
				restRequest.Parameters.Clear();

			if (RequestParams != null && RequestParams.Count > 0) {
				foreach (var key in RequestParams.Keys) {
					restRequest.AddParameter (key, RequestParams [key]);
				}
			}
		}

		/// <summary>
		/// 异步执行
		/// </summary>
		/// <returns>The async.</returns>
		public void ExcuteAsync(Action<IRestResponse> callback)
		{
			client.ExecuteAsync (restRequest, (response) => {

				callback(response);

			});

		}


	}
}

