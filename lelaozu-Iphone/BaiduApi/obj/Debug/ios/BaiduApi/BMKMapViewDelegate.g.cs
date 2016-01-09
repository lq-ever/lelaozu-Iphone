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
	[Protocol (Name = "BMKMapViewDelegate", WrapperType = typeof (BMKMapViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapView_RegionWillChangeAniamted", Selector = "mapView:regionWillChangeAnimated:", ParameterType = new Type [] { typeof (BaiduApi.BMKMapView), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapView_RegionDidChangeAnimated", Selector = "mapView:regionDidChangeAnimated:", ParameterType = new Type [] { typeof (BaiduApi.BMKMapView), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapView_ClickedMapBlank", Selector = "mapView:onClickedMapBlank:", ParameterType = new Type [] { typeof (BaiduApi.BMKMapView), typeof (CLLocationCoordinate2D) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapView_DoubleClcik", Selector = "mapView:onDoubleClick:", ParameterType = new Type [] { typeof (BaiduApi.BMKMapView), typeof (CLLocationCoordinate2D) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapView_LongCLick", Selector = "mapView:onLongClick:", ParameterType = new Type [] { typeof (BaiduApi.BMKMapView), typeof (CLLocationCoordinate2D) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MapStatusDidChanged", Selector = "mapStatusDidChanged:", ParameterType = new Type [] { typeof (BaiduApi.BMKMapView) }, ParameterByRef = new bool [] { false })]
	public interface IBMKMapViewDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class BMKMapViewDelegate_Extensions {
		[CompilerGenerated]
		public static void MapView_RegionWillChangeAniamted (this IBMKMapViewDelegate This, BMKMapView mapView, bool animated)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("mapView:regionWillChangeAnimated:"), mapView.Handle, animated);
		}
		
		[CompilerGenerated]
		public static void MapView_RegionDidChangeAnimated (this IBMKMapViewDelegate This, BMKMapView mapView, bool animated)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("mapView:regionDidChangeAnimated:"), mapView.Handle, animated);
		}
		
		[CompilerGenerated]
		public static void MapView_ClickedMapBlank (this IBMKMapViewDelegate This, BMKMapView mapView, global::CoreLocation.CLLocationCoordinate2D coordinate)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_CLLocationCoordinate2D (This.Handle, Selector.GetHandle ("mapView:onClickedMapBlank:"), mapView.Handle, coordinate);
		}
		
		[CompilerGenerated]
		public static void MapView_DoubleClcik (this IBMKMapViewDelegate This, BMKMapView mapView, global::CoreLocation.CLLocationCoordinate2D coordinate)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_CLLocationCoordinate2D (This.Handle, Selector.GetHandle ("mapView:onDoubleClick:"), mapView.Handle, coordinate);
		}
		
		[CompilerGenerated]
		public static void MapView_LongCLick (this IBMKMapViewDelegate This, BMKMapView mapView, global::CoreLocation.CLLocationCoordinate2D coordinate)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_CLLocationCoordinate2D (This.Handle, Selector.GetHandle ("mapView:onLongClick:"), mapView.Handle, coordinate);
		}
		
		[CompilerGenerated]
		public static void MapStatusDidChanged (this IBMKMapViewDelegate This, BMKMapView mapView)
		{
			if (mapView == null)
				throw new ArgumentNullException ("mapView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("mapStatusDidChanged:"), mapView.Handle);
		}
		
	}
	
	internal sealed class BMKMapViewDelegateWrapper : BaseWrapper, IBMKMapViewDelegate {
		public BMKMapViewDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public BMKMapViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace BaiduApi {
	[Protocol]
	[Register("BMKMapViewDelegate", false)]
	[Model]
	public unsafe partial class BMKMapViewDelegate : NSObject, IBMKMapViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public BMKMapViewDelegate () : base (NSObjectFlag.Empty)
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
		protected BMKMapViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal BMKMapViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("mapStatusDidChanged:")]
		[CompilerGenerated]
		public virtual void MapStatusDidChanged (BMKMapView mapView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:onClickedMapBlank:")]
		[CompilerGenerated]
		public virtual void MapView_ClickedMapBlank (BMKMapView mapView, global::CoreLocation.CLLocationCoordinate2D coordinate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:onDoubleClick:")]
		[CompilerGenerated]
		public virtual void MapView_DoubleClcik (BMKMapView mapView, global::CoreLocation.CLLocationCoordinate2D coordinate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:onLongClick:")]
		[CompilerGenerated]
		public virtual void MapView_LongCLick (BMKMapView mapView, global::CoreLocation.CLLocationCoordinate2D coordinate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:regionDidChangeAnimated:")]
		[CompilerGenerated]
		public virtual void MapView_RegionDidChangeAnimated (BMKMapView mapView, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mapView:regionWillChangeAnimated:")]
		[CompilerGenerated]
		public virtual void MapView_RegionWillChangeAniamted (BMKMapView mapView, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class BMKMapViewDelegate */
}
