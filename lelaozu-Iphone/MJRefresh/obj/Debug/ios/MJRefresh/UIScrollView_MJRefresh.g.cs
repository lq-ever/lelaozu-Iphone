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
	public unsafe static partial class UIScrollView_MJRefresh  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("UIScrollView");
		
		[Export ("footer")]
		[CompilerGenerated]
		public static MJRefreshFooter GetFooter (this global::UIKit.UIScrollView This)
		{
			return  Runtime.GetNSObject<MJRefreshFooter> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("footer")));
		}
		
		[Export ("header")]
		[CompilerGenerated]
		public static MJRefreshHeader GetHeader (this global::UIKit.UIScrollView This)
		{
			return  Runtime.GetNSObject<MJRefreshHeader> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("header")));
		}
		
		[Export ("reloadDataBlock")]
		[CompilerGenerated]
		public unsafe static global::System.Action<global::System.nint> GetReloadDataBlock (this global::UIKit.UIScrollView This)
		{
			IntPtr ret;
			ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("reloadDataBlock"));
			return global::ObjCRuntime.Trampolines.NIDActionArity1V0.Create (ret);
		}
		
		[Export ("totalDataCount")]
		[CompilerGenerated]
		public static global::System.nint GetTotalDataCount (this global::UIKit.UIScrollView This)
		{
			return global::ApiDefinition.Messaging.nint_objc_msgSend (This.Handle, Selector.GetHandle ("totalDataCount"));
		}
		
		[Export ("setFooter:")]
		[CompilerGenerated]
		public static void SetFooter (this global::UIKit.UIScrollView This, MJRefreshFooter footer)
		{
			if (footer == null)
				throw new ArgumentNullException ("footer");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setFooter:"), footer.Handle);
		}
		
		[Export ("setHeader:")]
		[CompilerGenerated]
		public static void SetHeader (this global::UIKit.UIScrollView This, MJRefreshHeader header)
		{
			if (header == null)
				throw new ArgumentNullException ("header");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setHeader:"), header.Handle);
		}
		
		[Export ("setReloadDataBlock:")]
		[CompilerGenerated]
		public unsafe static void SetReloadDataBlock (this global::UIKit.UIScrollView This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<global::System.nint> action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			BlockLiteral *block_ptr_action;
			BlockLiteral block_action;
			block_action = new BlockLiteral ();
			block_ptr_action = &block_action;
			block_action.SetupBlock (Trampolines.SDActionArity1V0.Handler, action);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setReloadDataBlock:"), (IntPtr) block_ptr_action);
			block_ptr_action->CleanupBlock ();
			
		}
		
	} /* class UIScrollView_MJRefresh */
}
