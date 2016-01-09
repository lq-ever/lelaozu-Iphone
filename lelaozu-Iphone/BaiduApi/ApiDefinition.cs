using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using CoreLocation;
using System.Drawing;

namespace BaiduApi
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_libraries
	//

	//[BaseType(typeof(NSObject),Delegates=new string[]{"BMKLocationServiceDelegate"})]


	/**
 *在将要启动定位时，会调用此函数
 */
	[Model,BaseType(typeof(NSObject))]	
	interface BMKLocationServiceDelegate
	{
		/**
 *在将要启动定位时，会调用此函数
 */
		[Export("willStartLocatingUser")]
		void willStartLocatingUser();

		/**
 *在停止定位后，会调用此函数
 */

		[Static,Export("didStopLocatingUser")]
		void didStopLocatingUser();

		/**
 *用户方向更新后，会调用此函数
 *@param userLocation 新的用户位置
 */
		[Export("didUpdateUserHeading:")]
		void didUpdateUserHeading(BMKUserLocation userLocation);

		/**
 *用户位置更新后，会调用此函数
 *@param userLocation 新的用户位置
 */
		[Export("didUpdateUserLocation:")]
		void didUpdateUserLocation(BMKUserLocation userLocation);

		/**
 *定位失败后，会调用此函数
 *@param error 错误号
 */

		[Static,Export("didFailToLocateUserWithError:")]
		void didFailToLocateUserWithError(NSError error);


	}


	[BaseType(typeof(NSObject))]
	interface BMKLocationService
	{
		//@property (nonatomic, readonly) BMKUserLocation *userLocation;
		[Static,Export ("userLocation")]
		BMKUserLocation userLocation{get;set;}

		/// 定位服务Delegate,调用startUserLocationService定位成功后，用此Delegate来获取定位数据
		//@property (nonatomic, assign) id<BMKLocationServiceDelegate> delegate;

		[Export ("delegate")]
		BMKLocationServiceDelegate Delegate{get;set;}

		/**
 *打开定位服务
 */
		[Export ("startUserLocationService")]
		void startUserLocationService();
		//-(void)startUserLocationService;
		/**
 *关闭定位服务
 */
		//-(void)stopUserLocationService;
		[Export ("stopUserLocationService")]
		void stopUserLocationService();


	}


	[BaseType(typeof(NSObject))]
	public partial interface BMKUserLocation
	{
		//位置更新状态，如果正在更新位置信息，则该值为YES
		//@property (readonly, nonatomic, getter=isUpdating) BOOL updating;
		[Static,Export ("updating")]
		bool updating{[Bind("isUpdating")] get; set;}
		//	bool updating{get; set;}
		/// 位置信息，如果BMKMapView的showsUserLocation为NO，或者尚未定位成功，则该值为nil
		//@property (readonly, nonatomic,retain) CLLocation *location;
		[Export ("location")]
		CLLocation location{ get; set;}
		/// heading信息，如果BMKMapView的showsUserLocation为NO，或者尚未定位成功，则该值为nil
		//@property (readonly, nonatomic, retain) CLHeading *heading;
		[Static,Export ("heading")]
		CLHeading heading {get;set;}
		/// 定位标注点要显示的标题信息
		//	@property (retain, nonatomic) NSString *title;
		[Static,Export ("title")]
		string title{ get; set;}
		/// 定位标注点要显示的子标题信息.
		//@property (retain, nonatomic) NSString *subtitle;
		[Static,Export ("subtitle")]
		string subtitle{get;set;}
	}

	[BaseType(typeof(NSObject))]
	interface BMKMapManager
	{
		/**
*启动引擎
*@param key 申请的有效key
*@param delegate 
*/


		//-(BOOL)start:(NSString*)key generalDelegate:(id<BMKGeneralDelegate>)delegate;
		[Export ("start:generalDelegate:")]
		bool start(string key,BMKGeneralDelegate delegates);
		/**
*停止引擎
*/
		[Export ("stop")]
		bool stop();
		//-(BOOL)stop; 
	}

	[Model,BaseType(typeof(NSObject))]
	interface BMKGeneralDelegate
	{
		/**
 *返回网络错误
 *@param iError 错误号
 */
		[Export ("onGetNetworkState:")]
		void onGetNetworkState(int iError);



		/**
 *返回授权验证错误
 *@param iError 错误号 : BMKErrorPermissionCheckFailure 验证失败
 */    
		[Export ("onGetPermissionState:")]
		void onGetPermissionState(int iError);
		//- (void)onGetPermissionState:(int)iError;
	}


	[BaseType (typeof(UIView))]
	interface BMKMapView
	{
		[Export ("delegate",ArgumentSemantic.Retain)] 
		NSObject WeakDelegate { get; set; }

		/// <summary>
		/// 地图View的Delegate，此处记得不用的时候需要置nil，否则影响内存的释放
		/// @property (nonatomic, retain) id<BMKMapViewDelegate> delegate;
		/// </summary>
		/// <value>The delegate.</value>
		[Export ("delegate")]
		BMKMapViewDelegate Delegate { get; set; }
		/// 当前地图类型，可设定为标准地图、实时路况、卫星地图、同时打开实时路况和卫星地图模式
		//@property (nonatomic) BMKMapType mapType;
		[Export ("mapType")]
		BMKMapType MapType{get;set;}

		/// 当前地图的经纬度范围，设定的该范围可能会被调整为适合地图窗口显示的范围
		//@property (nonatomic) BMKCoordinateRegion region;
		//[Export ("region")]
		//	BMKCoordinateRegion Region{get;set;}

		/// 指南针的位置，设定坐标以BMKMapView左上角为原点，向右向下增长
		//@property (nonatomic) CGPoint compassPosition;
		[Export ("compassPosition")]
		PointF CompassPosition{get;set;}

		/// 当前地图的中心点，改变该值时，地图的比例尺级别不会发生变化
		//@property (nonatomic) CLLocationCoordinate2D centerCoordinate;
		[Export ("centerCoordinate")]
		CLLocationCoordinate2D CenterCoordinate{get;set;}

		/// 地图比例尺级别，在手机上当前可使用的级别为3-19级
		//@property (nonatomic) float zoomLevel;
		[Export ("zoomLevel")]
		float ZoomLevel{get;set;}


		/// <summary>
		/// 地图的自定义最小比例尺级别
		/// @property (nonatomic) float minZoomLevel;
		/// </summary>
		/// <value>The minimum zoom level.</value>
		[Export ("minZoomLevel")]
		float MinZoomLevel { get; set; }

		/// <summary>
		/// 地图的自定义最大比例尺级别
		/// @property (nonatomic) float maxZoomLevel;
		/// </summary>
		/// <value>The max zoom level.</value>
		[Export ("maxZoomLevel")]
		float MaxZoomLevel { get; set; }

		/// <summary>
		/// 地图旋转角度，在手机上当前可使用的范围为－180～180度
		/// @property (nonatomic) int rotation;
		/// </summary>
		/// <value>The rotation.</value>
		[Export ("rotation")]
		int Rotation { get; set; }

		/// <summary>
		/// 地图俯视角度，在手机上当前可使用的范围为－45～0度
		/// @property (nonatomic) int overlooking;
		/// </summary>
		/// <value>The overlooking.</value>
		[Export ("overlooking")]
		int Overlooking { get; set; }

		/// <summary>
		/// 设定地图View能否支持用户多点缩放(双指)
		/// @property(nonatomic, getter=isZoomEnabled) BOOL zoomEnabled;
		/// </summary>
		/// <value><c>true</c> if zoom enabled; otherwise, <c>false</c>.</value>
		[Export ("zoomEnabled")]
		bool ZoomEnabled{ [Bind ("isZoomEnabled")]get; set; }

		/// <summary>
		/// 设定地图View能否支持用户缩放(双击或双指单击)
		/// @property(nonatomic, getter=isZoomEnabledWithTap) BOOL zoomEnabledWithTap;
		/// </summary>
		/// <value><c>true</c> if zoom enabled with tap; otherwise, <c>false</c>.</value>
		[Export ("zoomEnabledWithTap")]
		bool ZoomEnabledWithTap{ [Bind ("isZoomEnabledWithTap")]get; set; }

		/// <summary>
		/// 设定地图View能否支持用户移动地图
		/// @property(nonatomic, getter=isScrollEnabled) BOOL scrollEnabled;
		/// </summary>
		/// <value><c>true</c> if scroll enabled; otherwise, <c>false</c>.</value>
		[Export ("scrollEnabled")]
		bool ScrollEnabled{ [Bind ("isScrollEnabled")]get; set; }

		/// <summary>
		/// 设定地图View能否支持俯仰角
		/// @property(nonatomic, getter=isOverlookEnabled) BOOL overlookEnabled;
		/// </summary>
		/// <value><c>true</c> if overlook enabled; otherwise, <c>false</c>.</value>
		[Export ("overlookEnabled")]
		bool OverlookEnabled{ [Bind ("isOverlookEnabled")]get; set; }

		/// <summary>
		/// 设定地图View能否支持旋转
		/// @property(nonatomic, getter=isRotateEnabled) BOOL rotateEnabled;
		/// </summary>
		/// <value><c>true</c> if rotate enabled; otherwise, <c>false</c>.</value>
		[Export ("rotateEnabled")]
		bool RotateEnabled{ [Bind ("isRotateEnabled")]get; set; }

		/// <summary>
		/// 设定是否显式比例尺
		/// @property (nonatomic) BOOL showMapScaleBar;
		/// </summary>
		/// <value><c>true</c> if show map scale bar; otherwise, <c>false</c>.</value>
		[Export ("showMapScaleBar")]
		bool ShowMapScaleBar{ get; set; }

		/// <summary>
		/// 比例尺的位置，设定坐标以BMKMapView左上角为原点，向右向下增长
		/// @property (nonatomic) CGPoint mapScaleBarPosition;
		/// </summary>
		/// <value>The map scale bar position.</value>
		[Export ("mapScaleBarPosition")]
		PointF MapScaleBarPosition{ get; set; }

		/// <summary>
		/// 当前地图范围，采用直角坐标系表示，向右向下增长
		/// @property (nonatomic) BMKMapRect visibleMapRect;
		/// </summary>
		/// <value>The visible map rect.</value>
		//[Export ("visibleMapRect")]
		//BMKMapRect VisibleMapRect{ get; set; }

		/// <summary>
		/// 设定地图View能否支持以手势中心点为轴进行旋转和缩放
		/// @property(nonatomic, getter=isChangeWithTouchPointCenterEnabled) BOOL ChangeWithTouchPointCenterEnabled;
		/// </summary>
		/// <value><c>true</c> if change with touch point center enabled; otherwise, <c>false</c>.</value>
		[Export ("ChangeWithTouchPointCenterEnabled")]
		bool ChangeWithTouchPointCenterEnabled{ [Bind ("isChangeWithTouchPointCenterEnabled")]get; set; }
		//-(void)viewWillAppear;
		[Export ("viewWillAppear")]
		void ViewWillAppear ();
		//-(void)viewWillDisappear;
		[Export ("viewWillDisappear")]
		void ViewWillDisappear ();

		/// <summary>
		/// 放大一级比例尺
		/// - (BOOL)zoomIn;
		/// </summary>
		/// <returns><c>true</c>, if in was zoomed, <c>false</c> otherwise.</returns>
		[Export ("zoomIn")]
		bool ZoomIn ();

		/// <summary>
		/// 缩小一级比例尺
		/// - (BOOL)zoomOut;
		/// </summary>
		/// <returns><c>true</c>, if out was zoomed, <c>false</c> otherwise.</returns>
		[Export ("zoomOut")]
		bool ZoomOut ();
		/// <summary>
		/// 设定地图中心点坐标
		/// - (void)setCenterCoordinate:(CLLocationCoordinate2D)coordinate animated:(BOOL)animated;
		/// </summary>
		/// <param name="coordinate">Coordinate.</param>
		/// <param name="animated">If set to <c>true</c> animated.</param>
		[Export ("setCenterCoordinate:animated:")]
		void SetCenterCoordinate (CLLocationCoordinate2D coordinate, bool animated);

		/// <summary>
		/// 设定当前地图的显示范围,采用直角坐标系表示
		/// - (void)setVisibleMapRect:(BMKMapRect)mapRect animated:(BOOL)animate;
		/// </summary>
		/// <param name="mapRect">Map rect.</param>
		/// <param name="animated">If set to <c>true</c> animated.</param>


		/// <summary>
		/// 将经纬度坐标转换为View坐标
		/// - (CGPoint)convertCoordinate:(CLLocationCoordinate2D)coordinate toPointToView:(UIView *)view;
		/// </summary>
		/// <returns>The coordinate.</returns>
		/// <param name="coordinate">Coordinate.</param>
		/// <param name="view">View.</param>
		[Export ("convertCoordinate:toPointToView:")]
		PointF ConvertCoordinate (CLLocationCoordinate2D coordinate, UIView view);

		/// <summary>
		/// 将View坐标转换成经纬度坐标
		/// - (CLLocationCoordinate2D)convertPoint:(CGPoint)point toCoordinateFromView:(UIView *)view;
		/// </summary>
		/// <returns>The point.</returns>
		/// <param name="point">Point.</param>
		/// <param name="view">View.</param>
		[Export ("convertPoint:toCoordinateFromView:")]
		CLLocationCoordinate2D ConvertPoint (PointF point, UIView view);



	}

	[Category,BaseType (typeof(BMKMapView))]
	public partial interface LocationViewAPI
	{
		/// <summary>
		/// 设定是否显示定位图层
		/// @property (nonatomic) BOOL showsUserLocation;
		/// </summary>
		/// <value><c>true</c> if shows user location; otherwise, <c>false</c>.</value>
		[Export ("setShowsUserLocation:")]
		void SetShowsUserLocation(bool isShow);

		/// <summary>
		/// 设定定位模式，取值为：BMKUserTrackingMode
		/// @property (nonatomic) BMKUserTrackingMode userTrackingMode;
		/// </summary>
		/// <value>The user tracking mode.</value>
		[Export ("setUserTrackingMode:")]
		void SetUserTrackingMode(BMKUserTrackingMode mode);

		/// <summary>
		/// 返回定位坐标点是否在当前地图可视区域内
		/// @property (nonatomic, readonly, getter=isUserLocationVisible) BOOL userLocationVisible;
		/// </summary>
		/// <value><c>true</c> if user location visible; otherwise, <c>false</c>.</value>
		[Export ("isUserLocationVisible")]
		bool UserLocationVisible( );


		/// <summary>
		/// 动态更新我的位置数据
		/// -(void)updateLocationData:(BMKUserLocation*)userLocation;
		/// </summary>
		/// <param name="userLocation">User location.</param>
		[Export ("updateLocationData:")]
		void UpdateLocationData (BMKUserLocation userLocation);
	}
	[Model,Protocol]
	[BaseType(typeof(NSObject))]
	interface BMKMapViewDelegate
	{
		/// <summary>
		/// 地图区域即将改变时会调用此接口
		/// - (void)mapView:(BMKMapView *)mapView regionWillChangeAnimated:(BOOL)animated;
		/// </summary>
		/// <param name="mapView">Map view.</param>
		/// <param name="animated">If set to <c>true</c> animated.</param>
		[Export ("mapView:regionWillChangeAnimated:")]
		void MapView_RegionWillChangeAniamted (BMKMapView mapView, bool animated);

		/// <summary>
		/// 地图区域改变完成后会调用此接口
		/// - (void)mapView:(BMKMapView *)mapView regionDidChangeAnimated:(BOOL)animated;
		/// </summary>
		/// <param name="mapView">Map view.</param>
		/// <param name="animated">If set to <c>true</c> animated.</param>
		[Export ("mapView:regionDidChangeAnimated:")]
		void MapView_RegionDidChangeAnimated (BMKMapView mapView, bool animated);

		/// <summary>
		/// 点中底图空白处会回调此接口
		/// - (void)mapView:(BMKMapView *)mapView onClickedMapBlank:(CLLocationCoordinate2D)coordinate;
		/// </summary>
		/// <param name="mapView">Map view.</param>
		/// <param name="coordinate">Coordinate.</param>
		[Export ("mapView:onClickedMapBlank:")]
		void MapView_ClickedMapBlank (BMKMapView mapView, CLLocationCoordinate2D coordinate);

		/// <summary>
		/// 双击地图时会回调此接口
		/// - (void)mapview:(BMKMapView *)mapView onDoubleClick:(CLLocationCoordinate2D)coordinate;
		/// </summary>
		/// <param name="mapView">Map view.</param>
		/// <param name="coordinate">Coordinate.</param>
		[Export ("mapView:onDoubleClick:")]
		void MapView_DoubleClcik (BMKMapView mapView, CLLocationCoordinate2D coordinate);

		/// <summary>
		/// 长按地图时会回调此接口
		/// - (void)mapview:(BMKMapView *)mapView onLongClick:(CLLocationCoordinate2D)coordinate;
		/// </summary>
		/// <param name="mapView">Map view.</param>
		/// <param name="coordinate">Coordinate.</param>
		[Export ("mapView:onLongClick:")]
		void MapView_LongCLick (BMKMapView mapView, CLLocationCoordinate2D coordinate);

		/// <summary>
		/// 地图状态改变完成后会调用此接口
		/// - (void)mapStatusDidChanged:(BMKMapView *)mapView;
		/// </summary>
		/// <param name="mapView">Map view.</param>
		[Export ("mapStatusDidChanged:")]
		void MapStatusDidChanged (BMKMapView mapView);
	}
}

