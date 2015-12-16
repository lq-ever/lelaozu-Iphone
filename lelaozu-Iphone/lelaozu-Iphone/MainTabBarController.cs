using System;
using UIKit;

namespace lelaozuIphone
{
	/// <summary>
	/// Main tab bar controller.自定义tablebarcontroller
	/// </summary>
	public class MainTabBarController:UITabBarController
	{
		private Main_AlarmController main_alarmController;
		private Main_HealthController main_healthController;
		private Main_GuardianController main_guardianController;
		private Main_MyController main_myController;

		public MainTabBarController ()
		{
			main_healthController = new Main_HealthController ();

			//			main_healthController.TabBarItem.Image = UIImage.FromFile ("ic_men_health_normal.png");
			//			main_healthController.TabBarItem.SelectedImage = UIImage.FromFile ("ic_menu_health_selected.png");
			var nav_health = new UINavigationController (main_healthController);
			nav_health.TabBarItem.Title = "体检";

			main_alarmController = new Main_AlarmController ();

			//			main_alarmController.TabBarItem.Image = UIImage.FromFile ("ic_menu_alarm_normal.png");
			//			main_alarmController.TabBarItem.SelectedImage = UIImage.FromFile ("ic_menu_alarm_selected.png");
			var nav_alarm = new UINavigationController(main_alarmController);
			nav_alarm.TabBarItem.Title = "报警";

			main_guardianController = new Main_GuardianController ();
			//			main_guardianController.TabBarItem.Image = UIImage.FromFile ("ic_menu_guardian_normal.png");
			//			main_guardianController.TabBarItem.SelectedImage = UIImage.FromFile ("ic_menu_guardian_selected.png");
			var nav_guardian = new UINavigationController(main_guardianController);
			nav_guardian.TabBarItem.Title = "监护人";

			main_myController = new Main_MyController ();

			//			main_myController.TabBarItem.Image = UIImage.FromFile ("ic_menu_mine_normal.png");
			//			main_myController.TabBarItem.SelectedImage = UIImage.FromFile ("ic_menu_mine_selected.png");
			var nav_my = new UINavigationController(main_myController);
			nav_my.TabBarItem.Title = "我的";

			ViewControllers= new UIViewController[] {

				//main_healthController,main_alarmController,main_guardianController,main_myController
				nav_health,nav_alarm,nav_guardian,nav_my
			};
		}
			
	}
}

