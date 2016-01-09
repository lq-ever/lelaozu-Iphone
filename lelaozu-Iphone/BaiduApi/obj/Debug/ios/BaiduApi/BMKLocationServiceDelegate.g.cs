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
	[Register("BMKLocationServiceDelegate", false)]
	[Model]
	public unsafe partial class BMKLocationServiceDelegate : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public BMKLocationServiceDelegate () : base (NSObjectFlag.Empty)
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
		protected BMKLocationServiceDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal BMKLocationServiceDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("didFailToLocateUserWithError:")]
		[CompilerGenerated]
		public static void didFailToLocateUserWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didStopLocatingUser")]
		[CompilerGenerated]
		public static void didStopLocatingUser ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didUpdateUserHeading:")]
		[CompilerGenerated]
		public virtual void didUpdateUserHeading (BMKUserLocation userLocation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didUpdateUserLocation:")]
		[CompilerGenerated]
		public virtual void didUpdateUserLocation (BMKUserLocation userLocation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("willStartLocatingUser")]
		[CompilerGenerated]
		public virtual void willStartLocatingUser ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class BMKLocationServiceDelegate */
}
