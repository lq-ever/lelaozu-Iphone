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
	[Register("BMKMapView", true)]
	public unsafe partial class BMKMapView : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("BMKMapView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public BMKMapView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public BMKMapView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected BMKMapView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal BMKMapView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("convertCoordinate:toPointToView:")]
		[CompilerGenerated]
		public virtual global::System.Drawing.PointF ConvertCoordinate (global::CoreLocation.CLLocationCoordinate2D coordinate, global::UIKit.UIView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			global::System.Drawing.PointF ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.PointF_objc_msgSend_CLLocationCoordinate2D_IntPtr (this.Handle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view.Handle);
					} else {
						global::ApiDefinition.Messaging.PointF_objc_msgSend_stret_CLLocationCoordinate2D_IntPtr (out ret, this.Handle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view.Handle);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.PointF_objc_msgSend_CLLocationCoordinate2D_IntPtr (this.Handle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view.Handle);
				} else {
					ret = global::ApiDefinition.Messaging.PointF_objc_msgSend_CLLocationCoordinate2D_IntPtr (this.Handle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view.Handle);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.PointF_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr (this.SuperHandle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view.Handle);
					} else {
						global::ApiDefinition.Messaging.PointF_objc_msgSendSuper_stret_CLLocationCoordinate2D_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view.Handle);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.PointF_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr (this.SuperHandle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view.Handle);
				} else {
					ret = global::ApiDefinition.Messaging.PointF_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr (this.SuperHandle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view.Handle);
				}
			}
			return ret;
		}
		
		[Export ("convertPoint:toCoordinateFromView:")]
		[CompilerGenerated]
		public virtual global::CoreLocation.CLLocationCoordinate2D ConvertPoint (global::System.Drawing.PointF point, global::UIKit.UIView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			global::CoreLocation.CLLocationCoordinate2D ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend_PointF_IntPtr (this.Handle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view.Handle);
					} else {
						global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend_stret_PointF_IntPtr (out ret, this.Handle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view.Handle);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend_PointF_IntPtr (this.Handle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view.Handle);
				} else {
					global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend_stret_PointF_IntPtr (out ret, this.Handle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view.Handle);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_PointF_IntPtr (this.SuperHandle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view.Handle);
					} else {
						global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret_PointF_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view.Handle);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_PointF_IntPtr (this.SuperHandle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view.Handle);
				} else {
					global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret_PointF_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view.Handle);
				}
			}
			return ret;
		}
		
		[Export ("setCenterCoordinate:animated:")]
		[CompilerGenerated]
		public virtual void SetCenterCoordinate (global::CoreLocation.CLLocationCoordinate2D coordinate, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CLLocationCoordinate2D_bool (this.Handle, Selector.GetHandle ("setCenterCoordinate:animated:"), coordinate, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_bool (this.SuperHandle, Selector.GetHandle ("setCenterCoordinate:animated:"), coordinate, animated);
			}
		}
		
		[Export ("viewWillAppear")]
		[CompilerGenerated]
		public virtual void ViewWillAppear ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("viewWillAppear"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("viewWillAppear"));
			}
		}
		
		[Export ("viewWillDisappear")]
		[CompilerGenerated]
		public virtual void ViewWillDisappear ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("viewWillDisappear"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("viewWillDisappear"));
			}
		}
		
		[Export ("zoomIn")]
		[CompilerGenerated]
		public virtual bool ZoomIn ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("zoomIn"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("zoomIn"));
			}
		}
		
		[Export ("zoomOut")]
		[CompilerGenerated]
		public virtual bool ZoomOut ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("zoomOut"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("zoomOut"));
			}
		}
		
		[CompilerGenerated]
		public virtual global::CoreLocation.CLLocationCoordinate2D CenterCoordinate {
			[Export ("centerCoordinate")]
			get {
				global::CoreLocation.CLLocationCoordinate2D ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, Selector.GetHandle ("centerCoordinate"));
						} else {
							global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("centerCoordinate"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, Selector.GetHandle ("centerCoordinate"));
					} else {
						global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("centerCoordinate"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("centerCoordinate"));
						} else {
							global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("centerCoordinate"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("centerCoordinate"));
					} else {
						global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("centerCoordinate"));
					}
				}
				return ret;
			}
			
			[Export ("setCenterCoordinate:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_CLLocationCoordinate2D (this.Handle, Selector.GetHandle ("setCenterCoordinate:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D (this.SuperHandle, Selector.GetHandle ("setCenterCoordinate:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ChangeWithTouchPointCenterEnabled {
			[Export ("isChangeWithTouchPointCenterEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isChangeWithTouchPointCenterEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isChangeWithTouchPointCenterEnabled"));
				}
			}
			
			[Export ("setChangeWithTouchPointCenterEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setChangeWithTouchPointCenterEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setChangeWithTouchPointCenterEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.PointF CompassPosition {
			[Export ("compassPosition")]
			get {
				global::System.Drawing.PointF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.PointF_objc_msgSend (this.Handle, Selector.GetHandle ("compassPosition"));
						} else {
							global::ApiDefinition.Messaging.PointF_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("compassPosition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.PointF_objc_msgSend (this.Handle, Selector.GetHandle ("compassPosition"));
					} else {
						ret = global::ApiDefinition.Messaging.PointF_objc_msgSend (this.Handle, Selector.GetHandle ("compassPosition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.PointF_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("compassPosition"));
						} else {
							global::ApiDefinition.Messaging.PointF_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("compassPosition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.PointF_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("compassPosition"));
					} else {
						ret = global::ApiDefinition.Messaging.PointF_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("compassPosition"));
					}
				}
				return ret;
			}
			
			[Export ("setCompassPosition:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_PointF (this.Handle, Selector.GetHandle ("setCompassPosition:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_PointF (this.SuperHandle, Selector.GetHandle ("setCompassPosition:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual BMKMapViewDelegate Delegate {
			[Export ("delegate")]
			get {
				BMKMapViewDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<BMKMapViewDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret =  Runtime.GetNSObject<BMKMapViewDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.PointF MapScaleBarPosition {
			[Export ("mapScaleBarPosition")]
			get {
				global::System.Drawing.PointF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.PointF_objc_msgSend (this.Handle, Selector.GetHandle ("mapScaleBarPosition"));
						} else {
							global::ApiDefinition.Messaging.PointF_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("mapScaleBarPosition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.PointF_objc_msgSend (this.Handle, Selector.GetHandle ("mapScaleBarPosition"));
					} else {
						ret = global::ApiDefinition.Messaging.PointF_objc_msgSend (this.Handle, Selector.GetHandle ("mapScaleBarPosition"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.PointF_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mapScaleBarPosition"));
						} else {
							global::ApiDefinition.Messaging.PointF_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("mapScaleBarPosition"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.PointF_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mapScaleBarPosition"));
					} else {
						ret = global::ApiDefinition.Messaging.PointF_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mapScaleBarPosition"));
					}
				}
				return ret;
			}
			
			[Export ("setMapScaleBarPosition:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_PointF (this.Handle, Selector.GetHandle ("setMapScaleBarPosition:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_PointF (this.SuperHandle, Selector.GetHandle ("setMapScaleBarPosition:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual BMKMapType MapType {
			[Export ("mapType")]
			get {
				if (IsDirectBinding) {
					return (BMKMapType) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("mapType"));
				} else {
					return (BMKMapType) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mapType"));
				}
			}
			
			[Export ("setMapType:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setMapType:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setMapType:"), (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float MaxZoomLevel {
			[Export ("maxZoomLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("maxZoomLevel"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maxZoomLevel"));
				}
			}
			
			[Export ("setMaxZoomLevel:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMaxZoomLevel:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setMaxZoomLevel:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float MinZoomLevel {
			[Export ("minZoomLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("minZoomLevel"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minZoomLevel"));
				}
			}
			
			[Export ("setMinZoomLevel:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMinZoomLevel:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setMinZoomLevel:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool OverlookEnabled {
			[Export ("isOverlookEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isOverlookEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isOverlookEnabled"));
				}
			}
			
			[Export ("setOverlookEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setOverlookEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setOverlookEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int Overlooking {
			[Export ("overlooking")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("overlooking"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("overlooking"));
				}
			}
			
			[Export ("setOverlooking:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setOverlooking:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setOverlooking:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool RotateEnabled {
			[Export ("isRotateEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRotateEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRotateEnabled"));
				}
			}
			
			[Export ("setRotateEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRotateEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRotateEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int Rotation {
			[Export ("rotation")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("rotation"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rotation"));
				}
			}
			
			[Export ("setRotation:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setRotation:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setRotation:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ScrollEnabled {
			[Export ("isScrollEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isScrollEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isScrollEnabled"));
				}
			}
			
			[Export ("setScrollEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setScrollEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setScrollEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowMapScaleBar {
			[Export ("showMapScaleBar")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showMapScaleBar"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showMapScaleBar"));
				}
			}
			
			[Export ("setShowMapScaleBar:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowMapScaleBar:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowMapScaleBar:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool ZoomEnabled {
			[Export ("isZoomEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isZoomEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isZoomEnabled"));
				}
			}
			
			[Export ("setZoomEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setZoomEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setZoomEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ZoomEnabledWithTap {
			[Export ("isZoomEnabledWithTap")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isZoomEnabledWithTap"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isZoomEnabledWithTap"));
				}
			}
			
			[Export ("setZoomEnabledWithTap:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setZoomEnabledWithTap:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setZoomEnabledWithTap:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float ZoomLevel {
			[Export ("zoomLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("zoomLevel"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("zoomLevel"));
				}
			}
			
			[Export ("setZoomLevel:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setZoomLevel:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setZoomLevel:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
		public partial class BMKMapViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal BMKMapViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new BMKMapViewAppearance Appearance {
			get { return new BMKMapViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new BMKMapViewAppearance GetAppearance<T> () where T: BMKMapView {
			return new BMKMapViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new BMKMapViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new BMKMapViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new BMKMapViewAppearance GetAppearance (UITraitCollection traits) {
			return new BMKMapViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new BMKMapViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new BMKMapViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new BMKMapViewAppearance GetAppearance<T> (UITraitCollection traits) where T: BMKMapView {
			return new BMKMapViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new BMKMapViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: BMKMapView{
			return new BMKMapViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class BMKMapView */
}
