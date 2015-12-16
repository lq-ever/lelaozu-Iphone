using System;

namespace lelaozuIphone
{
	public enum Sex
	{
		Female =1,
		Male=0,
	}

	public enum AdviceType
	{

		Consult =0,//咨询
		Suggest =1,//建议
		Complain=2,//投诉
		Other =3,//其它
		All =4//全部
	}

	public enum FuncType
	{
		PersonInfo =1,//个人信息
		AccountSecurity=2,//账户安全
		Advice =3,//投诉建议
		PersonInfoTrueName=4,//真实姓名
		PersonInfoIdCardNo=5,//身份证号码
		PersonInfoGender =6,//性别
		PersonInfoBirth =7,//生日
		PersonInfoFixedPhone=8,//固定电话
		PersonInfoEmail =9,//邮箱
		PersonInfoCardLocation=10//身份证所在地
	}
}

