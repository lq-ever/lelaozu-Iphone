using System;

using UIKit;

using CoreLocation;
using MapKit;
using CoreGraphics;
namespace lelaozuIphone
{
	/// <summary>
	/// Alarm location view controller.警报地图查看
	/// </summary>
	public partial class AlarmLocationViewController : UIViewController
	{
		private string alarmPosition;
		public string AlarmPosition {
			get {
				return alarmPosition;
			}
			set {
				alarmPosition = value;
			}
		}
		private MKMapView _mkMapView;
		private double nPosition, ePosition;
		public AlarmLocationViewController () : base ("AlarmLocationViewController", null)
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title = "报警位置显示";
			InitView ();
		}

		/// <summary>
		/// Inits the view.
		/// </summary>
		private void InitView()
		{
			if (!string.IsNullOrEmpty (alarmPosition) && alarmPosition.Contains (",")) {
				var Positions =  alarmPosition.Split(new char[]{','});
				nPosition =  Convert.ToDouble(Positions [0].Substring (1));
				ePosition =  Convert.ToDouble(Positions [1].Substring (1));
			}

			_mkMapView = new MKMapView(Constants.Screen_Frame);
			_mkMapView.MapType = MKMapType.Standard;
			CLLocationCoordinate2D coor = new CLLocationCoordinate2D(nPosition,ePosition);
//			var mkpoint = MKMapPoint.FromCoordinate (coor);
//			var replacepoint = new CLLocationCoordinate2D (mkpoint.X, mkpoint.Y);
			double zoomLevel = 0.02;  
			 
			var region = new MKCoordinateRegion (coor, new MKCoordinateSpan (zoomLevel, zoomLevel));
			_mkMapView.SetRegion (region, true);
			_mkMapView.AddAnnotation (new  MKPointAnnotation (){ Title = "报警位置", Coordinate = coor });
			this.View.AddSubview (_mkMapView);
		

		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}


				

}


