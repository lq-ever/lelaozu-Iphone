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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V0 (IntPtr block, global::System.nint obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, global::System.nint obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::System.nint>) (descriptor->Target);
				if (del != null)
					del (obj);
			}
		} /* class SDActionArity1V0 */
		
		internal class NIDActionArity1V0 {
			IntPtr blockPtr;
			DActionArity1V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::System.nint> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::System.nint>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::System.nint obj)
			{
				invoker (blockPtr, obj);
			}
		} /* class NIDActionArity1V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DMJRefreshComponentRefreshingBlock (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMJRefreshComponentRefreshingBlock {
			static internal readonly DMJRefreshComponentRefreshingBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMJRefreshComponentRefreshingBlock))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MJRefresh.MJRefreshComponentRefreshingBlock) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDMJRefreshComponentRefreshingBlock */
		
		internal class NIDMJRefreshComponentRefreshingBlock {
			IntPtr blockPtr;
			DMJRefreshComponentRefreshingBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMJRefreshComponentRefreshingBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMJRefreshComponentRefreshingBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMJRefreshComponentRefreshingBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::MJRefresh.MJRefreshComponentRefreshingBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::MJRefresh.MJRefreshComponentRefreshingBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMJRefreshComponentRefreshingBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDMJRefreshComponentRefreshingBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate IntPtr DFuncArity2V0 (IntPtr block, IntPtr arg);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity2V0 {
			static internal readonly DFuncArity2V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DFuncArity2V0))]
			static unsafe IntPtr Invoke (IntPtr block, IntPtr arg) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Func<NSDate, NSString>) (descriptor->Target);
				Foundation.NSString retval = del ( Runtime.GetNSObject<NSDate> (arg));
				return retval != null ? retval.Handle : IntPtr.Zero;
			}
		} /* class SDFuncArity2V0 */
		
		internal class NIDFuncArity2V0 {
			IntPtr blockPtr;
			DFuncArity2V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDFuncArity2V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DFuncArity2V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDFuncArity2V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Func<NSDate, NSString> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Func<NSDate, NSString>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDFuncArity2V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe NSString Invoke (NSDate arg)
			{
				var ret =  Runtime.GetNSObject<NSString> (invoker (blockPtr, arg == null ? IntPtr.Zero : arg.Handle));
				return ret;
			}
		} /* class NIDFuncArity2V0 */
	}
}
