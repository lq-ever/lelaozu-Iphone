
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

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			  
			// Override point for customization after application launch.
			// If not required for your application you can safely delete this method

			//NSThread.SleepFor(2);//show splash delay 延长LaunchScreen.xib启动画面 

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
			#endregion
			return true;

		}

		public override void RegisteredForRemoteNotifications (UIApplication application, NSData deviceToken)
		{
			//throw new System.NotImplementedException ();
			// Required
			APService.RegisterDeviceToken(deviceToken);
		}


		public override void ReceivedRemoteNotification (UIApplication application, NSDictionary userInfo)
		{
			//throw new System.NotImplementedException ();
			// Required
			APService.HandleRemoteNotification(userInfo);
		}

		public override void DidReceiveRemoteNotification (UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler)
		{
			// IOS 7 Support Required
			APService.HandleRemoteNotification(userInfo);
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


