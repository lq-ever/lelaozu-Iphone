using System;


namespace lelaozuIphone
{
	public class UpdatePersonInfoParam:BaseParam
	{
		public UpdatePersonInfoParam ()
		{
		}
		public override string Action {
			get {
				return string.Empty;
			}
		}
		public override string ServiceFileName {
			get {
				return Constants.UpdatePersonServiceName;
			}
		}

		public string Uid {
			get;
			set;
		}
		public string Euid
		{
			get{
				return EnDeCryptUtil.Encrypt (Uid);
			}
		}
		public string TrueName {
			get;
			set;
		}
		public string EtrueName
		{
			get{
				return EnDeCryptUtil.Encrypt (TrueName);
			}
		}
		public string IdCardNo {
			get;
			set;
		}
		public string EidCardNo
		{
			get {
				return EnDeCryptUtil.Encrypt (IdCardNo);
			}
		}
		public string Gender {
			get;
			set;
		}
		public string Egender {
			get{
				return EnDeCryptUtil.Encrypt (Gender);
			}
		}
		public string Birth {
			get;
			set;
		}
		public string Ebirth
		{
			get {
				return EnDeCryptUtil.Encrypt (Birth);
			}
		}
		public string PhoneNumberOne {
			get;
			set;
		}
		public string EphoneNumberOne
		{
			get{
				return EnDeCryptUtil.Encrypt (PhoneNumberOne);
			}
		}
		public string FixedPhone {
			get;
			set;
		}
		public string EfixedPhone
		{
			get{
				return	EnDeCryptUtil.Encrypt (FixedPhone);
			}
		}
		public string Email {
			get;
			set;
		}
		public string Eemail
		{
			get{
				return EnDeCryptUtil.Encrypt (Email);
			}
		}

		public string IdCardLocation {
			get;
			set;
		}
		public string EidCardLocation
		{
			get{
				return EnDeCryptUtil.Encrypt (IdCardLocation);
			}
		}

		public string TrueAddress {
			get;
			set;
		}

		public string EtrueAddress
		{
			get {
				return EnDeCryptUtil.Encrypt (TrueAddress);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptUtil.MD5Encrypt (Euid+EtrueName+EidCardNo+Egender+Ebirth+EphoneNumberOne+EfixedPhone+Eemail+EidCardLocation+EtrueAddress+Key,Key);
			}
		}

	}
}

