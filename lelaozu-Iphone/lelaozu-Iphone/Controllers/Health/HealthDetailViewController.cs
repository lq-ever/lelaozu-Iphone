using System;

using UIKit;
using CoreGraphics;

namespace lelaozuIphone
{
	public partial class HealthDetailViewController : UIViewController
	{
		private HealthInfoItem healthInfoItem;
		public HealthDetailViewController (HealthInfoItem _healthInfoItem) : base ("HealthDetailViewController", null)
		{
			healthInfoItem =_healthInfoItem;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationItem.Title="体检详情";
			LoadData ();
		}

		private void LoadData()
		{
			if (healthInfoItem == null)
				return;
			BTProgressHUD.Show("正在加载体检详细信息...",-1,ProgressHUD.MaskType.Black);
			healthScrollView.ContentSize = new CGSize (Constants.Screen_Width, view_ncg.Frame.Y+view_ncg.Frame.Height+10);
			healthScrollView.Bounces = true;
			healthScrollView.ScrollEnabled = true;
			healthScrollView.ShowsVerticalScrollIndicator = true;
			healthScrollView.BackgroundColor = Color.BgGray;
			Console.WriteLine (healthScrollView.Frame.Y);


			//身体质量指数
			lbl_TestTime.Text = string.IsNullOrEmpty (healthInfoItem.TestTime) ? "-" : Convert.ToDateTime(healthInfoItem.TestTime).ToString("yyyy-MM-dd HH:mm:ss");
//
//			lbl_Height.Text = string.IsNullOrEmpty (healthInfoItem.Height) ? "-" : healthInfoItem.Height+"cm/";
//			lbl_Weight.Text = string.IsNullOrEmpty (healthInfoItem.Weight) ? "-" : healthInfoItem.Weight+"kg";
			lbl_HeightWeight.Text = (string.IsNullOrEmpty (healthInfoItem.Height) ? "-/" : healthInfoItem.Height+"cm/")+(string.IsNullOrEmpty (healthInfoItem.Weight) ? "-" : healthInfoItem.Weight+"kg");
			if (!string.IsNullOrEmpty (healthInfoItem.Height) && !string.IsNullOrEmpty (healthInfoItem.Weight)) {
				var bmi = Convert.ToDouble (healthInfoItem.Weight) / ((Convert.ToDouble (healthInfoItem.Height) / 100) * (Convert.ToDouble (healthInfoItem.Height) / 100));
				lbl_BMI.Text = string.Format ("{0:F}", bmi); // bmi.ToString ();
				if (bmi > HealthStand.BMI_High || bmi < HealthStand.BMI_Low) {
					//异常
					lbl_BMI.TextColor = UIColor.Red;
					img_BMI_Arraw.Hidden = false;
				} else
					img_BMI_Arraw.Hidden = true;

			} else
				img_BMI_Arraw.Hidden = true;

			//血糖
			lbl_BloodGlucose.Text = string.IsNullOrEmpty(healthInfoItem.BloodGlucose)?"-":healthInfoItem.BloodGlucose;

			if (!string.IsNullOrEmpty (healthInfoItem.BloodGlucose)) {
				var bloodGlucose = healthInfoItem.BloodGlucose;

				if (Convert.ToDouble (bloodGlucose) > HealthStand.BloodGlucose_High || Convert.ToDouble (bloodGlucose) < HealthStand.BloodGlucose_Low) {
					lbl_BloodGlucose.TextColor =UIColor.Red;
					img_BloodGlucose_Arraw.Hidden = false;
				} else
					img_BloodGlucose_Arraw.Hidden = true;
			} else
				img_BloodGlucose_Arraw.Hidden = true;

			//血氧
			lbl_BloodOxygenParaOne.Text = string.IsNullOrEmpty(healthInfoItem.BloodOxygenParaOne)?"-":healthInfoItem.BloodOxygenParaOne;

			if (!string.IsNullOrEmpty (healthInfoItem.BloodOxygenParaOne)) {
				var bloodOxygen = healthInfoItem.BloodOxygenParaOne;
				if (Convert.ToDouble (bloodOxygen) > HealthStand.BloodOxygen_High || Convert.ToDouble (bloodOxygen) < HealthStand.BloodOxygen_Low) {
					lbl_BloodOxygenParaOne.TextColor =UIColor.Red;
					img_BloodOxygenParaOne_Arraw.Hidden = false;
				} else
					img_BloodOxygenParaOne_Arraw.Hidden = true;
			} else
				img_BloodOxygenParaOne_Arraw.Hidden = true;

			//血压
//			lbl_BloodPressureParaOne.Text = string.IsNullOrEmpty(healthInfoItem.BloodPressureParaOne)?"-":healthInfoItem.BloodPressureParaOne;
//			lbl_BloodPressureParaTwo.Text = string.IsNullOrEmpty (healthInfoItem.BloodPressureParaTwo) ? "-" : healthInfoItem.BloodPressureParaTwo;
			lbl_BloodPressurePara.Text = (string.IsNullOrEmpty (healthInfoItem.BloodPressureParaOne) ? "-" : healthInfoItem.BloodPressureParaOne + "/" )+ (string.IsNullOrEmpty (healthInfoItem.BloodPressureParaTwo) ? "-" : healthInfoItem.BloodPressureParaTwo);
			//心率
			lbl_HeartRate.Text = string.IsNullOrEmpty(healthInfoItem.HeartRate)?"-":healthInfoItem.HeartRate;

			if (!string.IsNullOrEmpty (healthInfoItem.HeartRate)) {
				var heartRate = healthInfoItem.HeartRate;
				if (Convert.ToDouble (heartRate) > HealthStand.HeartRate_High || Convert.ToDouble (heartRate) < HealthStand.HeartRate_Low) {
					lbl_HeartRate.TextColor =UIColor.Red;
					img_HeartRate_Arraw.Hidden = false;
				} else
					img_HeartRate_Arraw.Hidden = true;
			} else
				img_HeartRate_Arraw.Hidden = true;

			//肺活量
			lbl_BreathCapacity.Text = string.IsNullOrEmpty(healthInfoItem.BreathCapacity)?"-":healthInfoItem.BreathCapacity;

			if (!string.IsNullOrEmpty (healthInfoItem.BreathCapacity)) {
				var breathCapacity = healthInfoItem.BreathCapacity;
				if (Convert.ToDouble (breathCapacity) > HealthStand.BreathCapacity_High || Convert.ToDouble (breathCapacity) < HealthStand.BreathCapacity_Low) {
					lbl_BreathCapacity.TextColor= UIColor.Red;
					img_BreathCapacity_Arraw.Hidden = false;
				} else
					img_BreathCapacity_Arraw.Hidden = true;
			} else
				img_BreathCapacity_Arraw.Hidden = true;
			//体温
			lbl_BodyTemperature.Text = string.IsNullOrEmpty(healthInfoItem.BodyTemperature)?"-":healthInfoItem.BodyTemperature;

			if (!string.IsNullOrEmpty (healthInfoItem.BodyTemperature)) {
				var bodyTemperature = Convert.ToDouble (healthInfoItem.BodyTemperature);
				if (bodyTemperature > HealthStand.BodyTemperature_High || bodyTemperature < HealthStand.BodyTemperature_Low) {
					lbl_BodyTemperature.TextColor= UIColor.Red;
					img_BodyTemperature_Arraw.Hidden = false;
				} else
					img_BodyTemperature_Arraw.Hidden = true;
			} else
				img_BodyTemperature_Arraw.Hidden = true;
			//总胆固醇
			lbl_BloodLipidParaOne.Text = string.IsNullOrEmpty(healthInfoItem.BloodLipidParaOne)?"-":healthInfoItem.BloodLipidParaOne;

			if (!string.IsNullOrEmpty (healthInfoItem.BloodLipidParaOne)) {
				var bloodLipidParaOne = Convert.ToDouble (healthInfoItem.BloodLipidParaOne);
				if (bloodLipidParaOne > HealthStand.BloodLipidParaOne_High || bloodLipidParaOne < HealthStand.BloodLipidParaOne_Low) {
					lbl_BloodLipidParaOne.TextColor =UIColor.Red;
					img_BloodLipidParaOne_Arraw.Hidden = false;
				} else
					img_BloodOxygenParaOne_Arraw.Hidden = true;

			} else
				img_BloodLipidParaOne_Arraw.Hidden = true;

			//低密度脂蛋白胆固醇

			lbl_BloodLipidParaTwo.Text = string.IsNullOrEmpty(healthInfoItem.BloodLipidParaTwo)?"-":healthInfoItem.BloodLipidParaTwo;

			if (!string.IsNullOrEmpty (healthInfoItem.BloodLipidParaTwo)) {
				var bloodLipidParaTwo = Convert.ToDouble (healthInfoItem.BloodLipidParaTwo);
				if (bloodLipidParaTwo > HealthStand.BloodLipidParaTwo_High || bloodLipidParaTwo < HealthStand.BloodLipidParaTwo_Low) {
					lbl_BloodLipidParaTwo.TextColor= UIColor.Red;

					img_BloodLipidParaTwo_Arraw.Hidden = false;

				} else
					img_BloodLipidParaTwo_Arraw.Hidden = true;
			} else
				img_BloodLipidParaTwo_Arraw.Hidden = true;

			//高密度脂蛋白胆固醇

			lbl_BloodLipidParaThree.Text = string.IsNullOrEmpty(healthInfoItem.BloodLipidParaThree)?"-":healthInfoItem.BloodLipidParaThree;

			if (!string.IsNullOrEmpty (healthInfoItem.BloodLipidParaThree)) {
				var bloodLipidParaThree = Convert.ToDouble (healthInfoItem.BloodLipidParaThree);
				if (bloodLipidParaThree > HealthStand.BloodLipidParaThree_High || bloodLipidParaThree < HealthStand.BloodLipidParaThree_Low) {
					lbl_BloodLipidParaThree.TextColor= UIColor.Red;
					img_BloodLipidParaThree_Arraw.Hidden = false;
				} else
					img_BloodLipidParaThree_Arraw.Hidden = true;
			} else
				img_BloodLipidParaThree_Arraw.Hidden = true;

			//甘油三酯
			lbl_BloodLipidParaFour.Text = string.IsNullOrEmpty(healthInfoItem.BloodLipidParaFour)?"-":healthInfoItem.BloodLipidParaFour;

			if (!string.IsNullOrEmpty (healthInfoItem.BloodLipidParaFour)) {
				var bloodLipidParaFour = Convert.ToDouble (healthInfoItem.BloodLipidParaFour);
				if (bloodLipidParaFour > HealthStand.BloodLipidParaFour_High || bloodLipidParaFour < HealthStand.BloodLipidParaFour_Low) {
					lbl_BloodLipidParaFour.TextColor =UIColor.Red;
					img_BloodLipidParaFour_Arraw.Hidden = false;
				} else
					img_BloodLipidParaFour_Arraw.Hidden = true;
			} else
				img_BloodLipidParaFour_Arraw.Hidden = true;
			//酸碱度
			lbl_UrineRoutinePH.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutinePH)?"-":healthInfoItem.UrineRoutinePH;

			if (!string.IsNullOrEmpty (healthInfoItem.UrineRoutinePH)) {
				var urineRoutinePh = Convert.ToDouble (healthInfoItem.UrineRoutinePH);
				if (urineRoutinePh > HealthStand.PH_High || urineRoutinePh < HealthStand.PH_Low) {
					lbl_UrineRoutinePH.TextColor= UIColor.Red;
					img_UrineRoutinePH_Arraw.Hidden = false;
				} else
					img_UrineRoutinePH_Arraw.Hidden = true;
			} else
				img_UrineRoutinePH_Arraw.Hidden = true;
			//尿比重
			lbl_UrineRoutineSG.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutineSG)?"-":healthInfoItem.UrineRoutineSG;

			if (!string.IsNullOrEmpty (healthInfoItem.UrineRoutineSG)) {
				var urineRoutineSg = Convert.ToDouble (healthInfoItem.UrineRoutineSG);
				if (urineRoutineSg > HealthStand.UrineRoutineSG_High || urineRoutineSg < HealthStand.UrineRoutineSG_Low) {
					lbl_UrineRoutineSG.TextColor =UIColor.Red;
					img_UrineRoutineSG_Arraw.Hidden = false;
				} else
					img_UrineRoutineSG_Arraw.Hidden = true;
			} else
				img_UrineRoutineSG_Arraw.Hidden = true;

			//尿胆元
			lbl_UrineRoutineURO.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutineURO)?"-":healthInfoItem.UrineRoutineURO;

			if (!string.IsNullOrEmpty (healthInfoItem.UrineRoutineURO)) {
				var urineRoutineUro = Convert.ToDouble (healthInfoItem.UrineRoutineURO);
				if (urineRoutineUro > HealthStand.UrineRoutineURO_High || urineRoutineUro < HealthStand.UrineRoutineURO_Low) {
					lbl_UrineRoutineURO.TextColor =UIColor.Red;
					img_UrineRoutineURO_Arraw.Hidden = false;
				} else
					img_UrineRoutineURO_Arraw.Hidden = true;
			} else
				img_UrineRoutineURO_Arraw.Hidden = true;
			//隐血
			lbl_UrineRoutineBLO.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutineBLO)?"-":healthInfoItem.UrineRoutineBLO;
			//白细胞(WBC):(WBC/uL)
			lbl_UrineRoutineWBC.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutineWBC)?"-":healthInfoItem.UrineRoutineWBC;
			//尿蛋白(PRO)
//			lbl_UrineRoutineRPO.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutinePRO)?"-":healthInfoItem.UrineRoutinePRO;
//			//尿糖(GLU)
//			lbl_UrineRoutineGLU.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutineGLU)?"-":healthInfoItem.UrineRoutineGLU;
			BTProgressHUD.Dismiss();	
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


