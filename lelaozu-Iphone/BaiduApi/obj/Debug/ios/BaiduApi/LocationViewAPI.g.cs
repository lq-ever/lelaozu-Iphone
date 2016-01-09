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

namespace BaiduApi {
	public unsafe static partial class LocationViewAPI  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("BMKMapView");
		
		[Export ("setShowsUserLocation:")]
		[CompilerGenerated]
		public static void SetShowsUserLocation (this BMKMapView This, bool isShow)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setShowsUserLocation:"), isShow);
		}
		
		[Export ("setUserTrackingMode:")]
		[CompilerGenerated]
		public static void SetUserTrackingMode (this BMKMapView This, BMKUserTrackingMode mode)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setUserTrackingMode:"), (int)mode);
		}
		
		[Export ("updateLocationData:")]
		[CompilerGenerated]
		public static void UpdateLocationData (this BMKMapView This, BMKUserLocation userLocation)
		{
			if (userLocation == null)
				throw new ArgumentNullException ("userLocation");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("updateLocationData:"), userLocation.Handle);
		}
		
		[Export ("isUserLocationVisible")]
		[CompilerGenerated]
		public static bool UserLocationVisible (this BMKMapView This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isUserLocationVisible"));
		}
		
	} /* class LocationViewAPI */
}
