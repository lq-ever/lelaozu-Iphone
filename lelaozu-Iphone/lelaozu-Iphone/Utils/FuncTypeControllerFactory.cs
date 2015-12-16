using System;
using UIKit;

namespace lelaozuIphone
{
	public class FuncTypeControllerFactory
	{
		public FuncTypeControllerFactory ()
		{
		}
		/// <summary>
		/// Creates the func view controller.
		/// </summary>
		/// <returns>The func view controller.</returns>
		/// <param name="_funcType">Func type.</param>
		public static UIViewController CreateFuncViewController(FuncType _funcType)
		{
			UIViewController controller = null;
			switch (_funcType) {
			case FuncType.PersonInfo:
				controller = new PersonInfoViewController ();
				break;
			case FuncType.AccountSecurity:
				controller = new AccountSecurityViewController ();
				break;
			case FuncType.Advice:
				controller = new AdviceViewController ();
				break;
			case FuncType.PersonInfoBirth:
				controller = new PersonInfoBirthViewController ();
				break;
			case FuncType.PersonInfoCardLocation:
				controller = new PersonInfoCardLocationViewController ();
				break;
			case FuncType.PersonInfoEmail:
				controller = new PersonInfoEmailViewController ();
				break;
			case FuncType.PersonInfoFixedPhone:
				controller = new PersonInfoFixedPhoneViewController ();
				break;
			case FuncType.PersonInfoGender:
				controller = new PersonInfoGenderViewController ();
				break;
			case FuncType.PersonInfoTrueName:
				controller = new PersonInfoTrueNameViewController ();
				break;
			}
			return controller;
		}
	}
}

