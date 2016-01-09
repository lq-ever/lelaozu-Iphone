using System;

namespace BaiduApi
{
	public enum EN_PERMISSION_STATUS
	{
		E_PERMISSION_OK = 0,	// 授权验证通过
		E_PERMISSION_SERVER_ERROR = -200, //服务端数据错误，无法解析服务端返回数据
		E_PERMISSION_NETWORK_ERROR = -300, //无法建立与服务端的连接

	}
	public enum BMKMapType
	{
		BMKMapTypeStandard   = 1,               ///< 标准地图
		BMKMapTypeTrafficOn  = 2,               ///< 实时路况 
		BMKMapTypeSatellite  = 4,               ///< 卫星地图
		BMKMapTypeTrafficAndSatellite  = 8,     ///< 同时打开实时路况和卫星地图
	}
	public enum BMKUserTrackingMode
	{
		None = 0,             /// 普通定位模式
		Follow,               /// 定位跟随模式
		FollowWithHeading,    /// 定位罗盘模式
	} 
}

