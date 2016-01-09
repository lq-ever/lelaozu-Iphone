
using Foundation;
using UIKit;
using System;
using JPush;

namespace lelaozuIphone
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIViewController rootViewController;
		public override UIWindow Window {
			get;
			set;
		}

		private bool isLaunchedByNotification =false;

	//	BMKMapManager* _mapManager;   

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{


			 
			// Override point for customization after application launch.
			// If not required for your application you can safely delete this method

			//NSThread.SleepFor(2);//show splash delay 延长LaunchScreen.xib启动画面 

			Console.WriteLine ("start method: finishedLaunching...\\n");

 			Window = new UIWindow(UIScreen.MainScreen.Bounds);

			//judge is goto launched

			if (string.IsNullOrEmpty (Constants.LastVersionCode) || Constants.CurrentVersionCode != Constants.LastVersionCode) {
				//goto guider
				rootViewController = new UINavigationController(new UserGuiderViewController());

			} else {
				//goto zhujiemian
				rootViewController = new UINavigationController(new LoginViewController());
			}		
			Window.RootViewController = rootViewController;
			Window.BackgroundColor = UIColor.White;
			Window.MakeKeyAndVisible ();
			#region 极光推送配置
			//Required
			if(float.Parse(UIDevice.CurrentDevice.SystemVersion)>=8.0)
			{
				//可以添加自定义categories
				APService.RegisterForRemoteNotificationTypes((uint)(UIUserNotificationType.Alert|UIUserNotificationType.Sound
					|UIUserNotificationType.Badge),null);
			}
			else
			{
				//categories 必须为nil
				APService.RegisterForRemoteNotificationTypes((uint)(UIUserNotificationType.Alert|UIUserNotificationType.Sound
					|UIUserNotificationType.Badge),null);
			}
			// Required
			APService.SetupWithOption(launchOptions);
			APService.SetDebugMode();
			#endregion

			#region baidumap
			// 要使用百度地图，请先启动BaiduMapManager  
//			_mapManager = [[BMKMapManager alloc]init];   
//			// 如果要关注网络及授权验证事件，请设定     generalDelegate参数  
			//			BOOL ret = [_mapManager start:@"在此处输入您的授权Key"  generalDelegate:nil];  //gw1iEfOjrDPvibEuk4prqdP3
//			if (!ret) {  
//				NSLog(@"manager start failed!");  
//			}  

//			var mapManager = new BMKMapManager();
//			bool ret= mapManager.start("gw1iEfOjrDPvibEuk4prqdP3",null);
//			if(!ret)
//				Console.WriteLine("manager start failed...");
			
			#endregion
			//UIApplicationLaunchOptionsRemoteNotificationKey 
			if (launchOptions != null) {
				Console.WriteLine (" launchOptions is not null...\n");
				NSDictionary remoteNotification = (NSDictionary)launchOptions.ObjectForKey (UIApplication.LaunchOptionsRemoteNotificationKey);
				if (remoteNotification != null) {
				
					//通过点击通知栏进入应用
					Console.WriteLine (" 通过点击通知栏进入应用...\n");
					isLaunchedByNotification = true;

				} else {
					//通过点击应用图标进入应用
					Console.WriteLine (" 通过点击应用图标进入应用...\n");
					isLaunchedByNotification = false;
				}
			} else {
				Console.WriteLine (" launchOptions is null...\n");
			}


			return true;

		}

		/// <summary>
		/// Registereds for remote notifications.提交devicetoken
		/// </summary>
		/// <param name="application">Application.</param>
		/// <param name="deviceToken">Device token.</param>
		public override void RegisteredForRemoteNotifications (UIApplication application, NSData deviceToken)
		{
			//throw new System.NotImplementedException ();

			// Required
			APService.RegisterDeviceToken(deviceToken);
		}
		/// <summary>
		/// Faileds to register for remote notifications.
		/// </summary>
		/// <param name="application">Application.</param>
		/// <param name="error">Error.</param>
		public override void FailedToRegisterForRemoteNotifications (UIApplication application, NSError error)
		{
			//get token failed
			Console.WriteLine(string.Format("devicetoke 获取失败{0}",error.ToString()));
		}

		/// <summary>
		/// Receiveds the remote notification.ios 6 bellow 接收到消息
		/// </summary>
		/// <param name="application">Application.</param>
		/// <param name="userInfo">User info.</param>
		public override void ReceivedRemoteNotification (UIApplication application, NSDictionary userInfo)
		{
			//throw new System.NotImplementedException ();
			Console.WriteLine("start method ReceivedRemoteNotification...\n");
			// Required
			APService.HandleRemoteNotification(userInfo);
		}
		/// <summary>
		/// Dids the receive remote notification.接收到消息IOS 7 Support Required and above
		/// </summary>
		/// <param name="application">Application.</param>
		/// <param name="userInfo">User info.</param>
		/// <param name="completionHandler">Completion handler.</param>
		public override void DidReceiveRemoteNotification (UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler)
		{
			// 取得 APNs 标准信息内容
//			NSDictionary *aps = [userInfo valueForKey:@"aps"];
//			NSString *content = [aps valueForKey:@"alert"]; //推送显示的内容
//			NSInteger badge = [[aps valueForKey:@"badge"] integerValue]; //badge数量
//			NSString *sound = [aps valueForKey:@"sound"]; //播放的声音
//
//			// 取得Extras字段内容
//			NSString *customizeField1 = [userInfo valueForKey:@"customizeExtras"]; //服务端中Extras字段，key是自己定义的
//			NSLog(@"content =[%@], badge=[%d], sound=[%@], customize field  =[%@]",content,badge,sound,customizeField1);
			Console.WriteLine("start method DidReceiveRemoteNotification...\n");
			NSDictionary aps = (NSDictionary)userInfo.ValueForKey (new NSString ("aps"));
			var content = aps.ValueForKey (new NSString("alert"));//推送显示的内容

			// 取得Extras字段内容
			var alarmId = userInfo.ValueForKey (new NSString("aid"));//报警消息id

			Console.WriteLine (string.Format("content:{0};alarmId:{1}",content,alarmId));
			// Required
			APService.HandleRemoteNotification(userInfo);
			//clear badge 
			if(UIApplication.SharedApplication.ApplicationIconBadgeNumber>0)
				UIApplication.SharedApplication.ApplicationIconBadgeNumber--;
			APService.SetBadge (UIApplication.SharedApplication.ApplicationIconBadgeNumber);
			// UIApplicationStateActive, 在前台运行
			// UIApplicationStateInactive,未启动app
			//UIApplicationStateBackground    app在后台

			if (UIApplication.SharedApplication.ApplicationState == UIApplicationState.Active) {
				//此时app在前台运行,不会收到通知栏提醒，需要手动创建一个alertview框，进行提醒

				var notificationController = UIAlertController.Create ("收到推送消息", content.ToString (), UIAlertControllerStyle.Alert);
					notificationController.AddAction (UIAlertAction.Create ("忽略", UIAlertActionStyle.Cancel, (UIAlertAction obj) => {
					}));
					notificationController.AddAction (UIAlertAction.Create ("查看", UIAlertActionStyle.Default, (UIAlertAction obj) => {
					    //跳转到报警详细界面
					    var tabController = Window.RootViewController as UITabBarController;
						var alarmDetailController = new AlarmDetailViewController (){AlarmId = alarmId.ToString(),HidesBottomBarWhenPushed = true };
						(tabController.SelectedViewController as UINavigationController).ViewControllers[0].NavigationController.PushViewController(alarmDetailController, true);

					}));
					this.Window.RootViewController.PresentViewController (notificationController, true, null);
			} 
			else 
			{
				//未启动app or app在后台 能收到通知栏提醒 ,但必须触摸通知栏消息才能进入此分支，如果是只是点击应用图标启动，将不会进入分支
				if (Constants.HasLogin) {
					//已经登录
					var tabController = Window.RootViewController as UITabBarController;
					var alarmDetailController = new AlarmDetailViewController (){AlarmId = alarmId.ToString(),HidesBottomBarWhenPushed = true };
					(tabController.SelectedViewController as UINavigationController).ViewControllers[0].NavigationController.PushViewController(alarmDetailController, true);

				} else {
					//未登录
					Constants.PushNot = true;
					Constants.PushAlarmId = alarmId.ToString ();

				}
			
			}
			if (completionHandler != null)
				completionHandler (UIBackgroundFetchResult.NewData);
		}







		public override void OnResignActivation (UIApplication application)
		{
			// Invoked when the application is about to move from active to inactive state.
			// This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
			// or when the user quits the application and it begins the transition to the background state.
			// Games should use this method to pause the game.
		}

		public override void DidEnterBackground (UIApplication application)
		{
			// Use this method to release shared resources, save user data, invalidate timers and store the application state.
			// If your application supports background exection this method is called instead of WillTerminate when the user quits.
		}

		public override void WillEnterForeground (UIApplication application)
		{
			// Called as part of the transiton from background to active state.
			// Here you can undo many of the changes made on entering the background.
//			UIApplication.SharedApplication.ApplicationIconBadgeNumber = 0;//清除角标
//			UIApplication.SharedApplication.CancelAllLocalNotifications ();// 取消通知栏
		}

		public override void OnActivated (UIApplication application)
		{
			// Restart any tasks that were paused (or not yet started) while the application was inactive. 
			// If the application was previously in the background, optionally refresh the user interface.
		}

		public override void WillTerminate (UIApplication application)
		{
			// Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
		}
	}
}


