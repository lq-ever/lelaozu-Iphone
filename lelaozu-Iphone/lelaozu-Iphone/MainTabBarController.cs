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


			var nav_health = new UINavigationController (main_healthController);
			nav_health.TabBarItem.Title = "体检";
			nav_health.TabBarItem.Image = UIImage.FromFile ("ic_menu_health_normal.png");
			nav_health.TabBarItem.SelectedImage = UIImage.FromFile ("ic_menu_health_selected.png");


			main_alarmController = new Main_AlarmController ();
			var nav_alarm = new UINavigationController(main_alarmController);
			nav_alarm.TabBarItem.Title = "报警";
			nav_alarm.TabBarItem.Image = UIImage.FromFile ("ic_menu_alarm_normal.png");
			nav_alarm.TabBarItem.SelectedImage = UIImage.FromFile ("ic_menu_alarm_selected.png");


			main_guardianController = new Main_GuardianController ();
			var nav_guardian = new UINavigationController(main_guardianController);
			nav_guardian.TabBarItem.Title = "监护人";
			nav_guardian.TabBarItem.Image = UIImage.FromFile ("ic_menu_guardian_normal.png");
			nav_guardian.TabBarItem.SelectedImage = UIImage.FromFile ("ic_menu_guardian_selected.png");


			main_myController = new Main_MyController ();
			var nav_my = new UINavigationController(main_myController);
			nav_my.TabBarItem.Title = "我的";
			nav_my.TabBarItem.Image = UIImage.FromFile ("ic_menu_mine_normal.png");
			nav_my.TabBarItem.SelectedImage = UIImage.FromFile ("ic_menu_mine_selected.png");

			ViewControllers= new UIViewController[] {
				nav_health,nav_alarm,nav_guardian,nav_my
			};
		}
			
	}
}

