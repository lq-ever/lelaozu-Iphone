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

namespace MJRefresh {
	public unsafe static partial class UIView_MJExtension  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("UIView");
		
		[Export ("mj_h")]
		[CompilerGenerated]
		public static global::System.nfloat GetMj_h (this global::UIKit.UIView This)
		{
			return global::ApiDefinition.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("mj_h"));
		}
		
		[Export ("mj_x")]
		[CompilerGenerated]
		public static global::System.nfloat GetMj_x (this global::UIKit.UIView This)
		{
			return global::ApiDefinition.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("mj_x"));
		}
		
		[Export ("setMj_h:")]
		[CompilerGenerated]
		public static void SetMj_h (this global::UIKit.UIView This, global::System.nfloat value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("setMj_h:"), value);
		}
		
		[Export ("setMj_x:")]
		[CompilerGenerated]
		public static void SetMj_x (this global::UIKit.UIView This, global::System.nfloat value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("setMj_x:"), value);
		}
		
	} /* class UIView_MJExtension */
}
