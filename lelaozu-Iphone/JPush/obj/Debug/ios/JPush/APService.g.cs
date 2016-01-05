//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace JPush {
	[Register("APService", true)]
	public unsafe partial class APService : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("APService");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public APService () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected APService (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal APService (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("beginLogPageView:duration:")]
		[CompilerGenerated]
		public static void BeginLogPageView (string pageName, int seconds)
		{
			if (pageName == null)
				throw new ArgumentNullException ("pageName");
			var nspageName = NSString.CreateNative (pageName);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (class_ptr, Selector.GetHandle ("beginLogPageView:duration:"), nspageName, seconds);
			NSString.ReleaseNative (nspageName);
			
		}
		
		[Export ("clearAllLocalNotifications")]
		[CompilerGenerated]
		public static void ClearAllLocalNotifications ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("clearAllLocalNotifications"));
		}
		
		[Export ("crashLogON")]
		[CompilerGenerated]
		public static void CrashLogON ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("crashLogON"));
		}
		
		[Export ("deleteLocalNotification:")]
		[CompilerGenerated]
		public static void DeleteLocalNotification (global::UIKit.UILocalNotification localNotification)
		{
			if (localNotification == null)
				throw new ArgumentNullException ("localNotification");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("deleteLocalNotification:"), localNotification.Handle);
		}
		
		[Export ("deleteLocalNotificationWithIdentifierKey:")]
		[CompilerGenerated]
		public static void DeleteLocalNotificationWithIdentifierKey (string notificationKey)
		{
			if (notificationKey == null)
				throw new ArgumentNullException ("notificationKey");
			var nsnotificationKey = NSString.CreateNative (notificationKey);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("deleteLocalNotificationWithIdentifierKey:"), nsnotificationKey);
			NSString.ReleaseNative (nsnotificationKey);
			
		}
		
		[Export ("filterValidTags:")]
		[CompilerGenerated]
		public static NSSet FilterValidTags (NSSet tags)
		{
			if (tags == null)
				throw new ArgumentNullException ("tags");
			return  Runtime.GetNSObject<NSSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("filterValidTags:"), tags.Handle));
		}
		
		[Export ("findLocalNotificationWithIdentifier:")]
		[CompilerGenerated]
		public static global::UIKit.UILocalNotification[] FindLocalNotificationWithIdentifier (string notificationKey)
		{
			if (notificationKey == null)
				throw new ArgumentNullException ("notificationKey");
			var nsnotificationKey = NSString.CreateNative (notificationKey);
			
			global::UIKit.UILocalNotification[] ret;
			ret = NSArray.ArrayFromHandle<global::UIKit.UILocalNotification>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("findLocalNotificationWithIdentifier:"), nsnotificationKey));
			NSString.ReleaseNative (nsnotificationKey);
			
			return ret;
		}
		
		[Export ("handleRemoteNotification:")]
		[CompilerGenerated]
		public static void HandleRemoteNotification (NSDictionary remoteInfo)
		{
			if (remoteInfo == null)
				throw new ArgumentNullException ("remoteInfo");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("handleRemoteNotification:"), remoteInfo.Handle);
		}
		
		[Export ("registerDeviceToken:")]
		[CompilerGenerated]
		public static void RegisterDeviceToken (NSData deviceToken)
		{
			if (deviceToken == null)
				throw new ArgumentNullException ("deviceToken");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("registerDeviceToken:"), deviceToken.Handle);
		}
		
		[Export ("registerForRemoteNotificationTypes:categories:")]
		[CompilerGenerated]
		public static void RegisterForRemoteNotificationTypes (global::System.nuint types, NSSet categories)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nuint_IntPtr (class_ptr, Selector.GetHandle ("registerForRemoteNotificationTypes:categories:"), types, categories == null ? IntPtr.Zero : categories.Handle);
		}
		
		[Export ("resetBadge")]
		[CompilerGenerated]
		public static void ResetBadge ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("resetBadge"));
		}
		
		[Export ("setAlias:callbackSelector:object:")]
		[CompilerGenerated]
		public static void SetAlias (string alias, Selector cbSelector, NSObject theTarget)
		{
			var nsalias = NSString.CreateNative (alias);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setAlias:callbackSelector:object:"), nsalias, cbSelector == null ? IntPtr.Zero : cbSelector.Handle, theTarget == null ? IntPtr.Zero : theTarget.Handle);
			NSString.ReleaseNative (nsalias);
			
		}
		
		[Export ("setBadge:")]
		[CompilerGenerated]
		public static bool SetBadge (global::System.nint value)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (class_ptr, Selector.GetHandle ("setBadge:"), value);
		}
		
		[Export ("setDebugMode")]
		[CompilerGenerated]
		public static void SetDebugMode ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("setDebugMode"));
		}
		
		[Export ("setLatitude:longitude:")]
		[CompilerGenerated]
		public static void SetLatitude (global::System.Double latitude, global::System.Double longitude)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_Double_Double (class_ptr, Selector.GetHandle ("setLatitude:longitude:"), latitude, longitude);
		}
		
		[Export ("setLocalNotification:alertBody:badge:alertAction:identifierKey:userInfo:soundName:")]
		[CompilerGenerated]
		public static global::UIKit.UILocalNotification SetLocalNotification (NSDate fireDate, string alertBody, int badge, string alertActionText, string notificationKey, NSDictionary userInfo, string soundName)
		{
			if (fireDate == null)
				throw new ArgumentNullException ("fireDate");
			if (alertBody == null)
				throw new ArgumentNullException ("alertBody");
			if (alertActionText == null)
				throw new ArgumentNullException ("alertActionText");
			if (notificationKey == null)
				throw new ArgumentNullException ("notificationKey");
			if (userInfo == null)
				throw new ArgumentNullException ("userInfo");
			var nsalertBody = NSString.CreateNative (alertBody);
			var nsalertActionText = NSString.CreateNative (alertActionText);
			var nsnotificationKey = NSString.CreateNative (notificationKey);
			var nssoundName = NSString.CreateNative (soundName);
			
			global::UIKit.UILocalNotification ret;
			ret =  Runtime.GetNSObject<global::UIKit.UILocalNotification> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setLocalNotification:alertBody:badge:alertAction:identifierKey:userInfo:soundName:"), fireDate.Handle, nsalertBody, badge, nsalertActionText, nsnotificationKey, userInfo.Handle, nssoundName));
			NSString.ReleaseNative (nsalertBody);
			NSString.ReleaseNative (nsalertActionText);
			NSString.ReleaseNative (nsnotificationKey);
			NSString.ReleaseNative (nssoundName);
			
			return ret;
		}
		
		[Export ("setLocalNotification:alertBody:badge:alertAction:identifierKey:userInfo:soundName:region:regionTriggersOnce:category:")]
		[CompilerGenerated]
		public static global::UIKit.UILocalNotification SetLocalNotification (NSDate fireDate, string alertBody, int badge, string alertActionText, string notificationKey, NSDictionary userInfo, string soundName, global::CoreLocation.CLRegion region, bool regionTriggersOnce, string category)
		{
			if (fireDate == null)
				throw new ArgumentNullException ("fireDate");
			if (alertBody == null)
				throw new ArgumentNullException ("alertBody");
			if (alertActionText == null)
				throw new ArgumentNullException ("alertActionText");
			if (notificationKey == null)
				throw new ArgumentNullException ("notificationKey");
			if (userInfo == null)
				throw new ArgumentNullException ("userInfo");
			if (soundName == null)
				throw new ArgumentNullException ("soundName");
			if (region == null)
				throw new ArgumentNullException ("region");
			if (category == null)
				throw new ArgumentNullException ("category");
			var nsalertBody = NSString.CreateNative (alertBody);
			var nsalertActionText = NSString.CreateNative (alertActionText);
			var nsnotificationKey = NSString.CreateNative (notificationKey);
			var nssoundName = NSString.CreateNative (soundName);
			var nscategory = NSString.CreateNative (category);
			
			global::UIKit.UILocalNotification ret;
			ret =  Runtime.GetNSObject<global::UIKit.UILocalNotification> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr (class_ptr, Selector.GetHandle ("setLocalNotification:alertBody:badge:alertAction:identifierKey:userInfo:soundName:region:regionTriggersOnce:category:"), fireDate.Handle, nsalertBody, badge, nsalertActionText, nsnotificationKey, userInfo.Handle, nssoundName, region.Handle, regionTriggersOnce, nscategory));
			NSString.ReleaseNative (nsalertBody);
			NSString.ReleaseNative (nsalertActionText);
			NSString.ReleaseNative (nsnotificationKey);
			NSString.ReleaseNative (nssoundName);
			NSString.ReleaseNative (nscategory);
			
			return ret;
		}
		
		[Export ("setLocation:")]
		[CompilerGenerated]
		public static void SetLocation (global::CoreLocation.CLLocation location)
		{
			if (location == null)
				throw new ArgumentNullException ("location");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setLocation:"), location.Handle);
		}
		
		[Export ("setLogOFF")]
		[CompilerGenerated]
		public static void SetLogOFF ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("setLogOFF"));
		}
		
		[Export ("setTags:alias:callbackSelector:object:")]
		[CompilerGenerated]
		public static void SetTagsWithObject (NSSet tags, string alias, Selector cbSelector, NSObject theTarget)
		{
			var nsalias = NSString.CreateNative (alias);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setTags:alias:callbackSelector:object:"), tags == null ? IntPtr.Zero : tags.Handle, nsalias, cbSelector == null ? IntPtr.Zero : cbSelector.Handle, theTarget == null ? IntPtr.Zero : theTarget.Handle);
			NSString.ReleaseNative (nsalias);
			
		}
		
		[Export ("setTags:alias:callbackSelector:target:")]
		[CompilerGenerated]
		public static void SetTagsWithTarger (NSSet tags, string alias, Selector cbSelector, NSObject theTarget)
		{
			var nsalias = NSString.CreateNative (alias);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setTags:alias:callbackSelector:target:"), tags == null ? IntPtr.Zero : tags.Handle, nsalias, cbSelector == null ? IntPtr.Zero : cbSelector.Handle, theTarget == null ? IntPtr.Zero : theTarget.Handle);
			NSString.ReleaseNative (nsalias);
			
		}
		
		[Export ("setTags:callbackSelector:object:")]
		[CompilerGenerated]
		public static void SetTagsWithTarget (NSSet tags, Selector cbSelector, NSObject theTarget)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setTags:callbackSelector:object:"), tags == null ? IntPtr.Zero : tags.Handle, cbSelector == null ? IntPtr.Zero : cbSelector.Handle, theTarget == null ? IntPtr.Zero : theTarget.Handle);
		}
		
		[Export ("setupWithOption:")]
		[CompilerGenerated]
		public static void SetupWithOption (NSDictionary launchingOption)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setupWithOption:"), launchingOption == null ? IntPtr.Zero : launchingOption.Handle);
		}
		
		[Export ("showLocalNotificationAtFront:identifierKey:")]
		[CompilerGenerated]
		public static void ShowLocalNotificationAtFront (global::UIKit.UILocalNotification notification, string notificationKey)
		{
			if (notification == null)
				throw new ArgumentNullException ("notification");
			if (notificationKey == null)
				throw new ArgumentNullException ("notificationKey");
			var nsnotificationKey = NSString.CreateNative (notificationKey);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("showLocalNotificationAtFront:identifierKey:"), notification.Handle, nsnotificationKey);
			NSString.ReleaseNative (nsnotificationKey);
			
		}
		
		[Export ("startLogPageView:")]
		[CompilerGenerated]
		public static void StartLogPageView (string pageName)
		{
			if (pageName == null)
				throw new ArgumentNullException ("pageName");
			var nspageName = NSString.CreateNative (pageName);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("startLogPageView:"), nspageName);
			NSString.ReleaseNative (nspageName);
			
		}
		
		[Export ("stopLogPageView:")]
		[CompilerGenerated]
		public static void StopLogPageView (string pageName)
		{
			if (pageName == null)
				throw new ArgumentNullException ("pageName");
			var nspageName = NSString.CreateNative (pageName);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("stopLogPageView:"), nspageName);
			NSString.ReleaseNative (nspageName);
			
		}
		
		[CompilerGenerated]
		public static string RegistrationID {
			[Export ("registrationID")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("registrationID")));
			}
			
		}
		
	} /* class APService */
}
