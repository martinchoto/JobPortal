using NuGet.Protocol.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Core.Constants
{
	public class DataConstants
	{
		//Formats
		public const string DECIMAL_FORMAT = "0.##";
		public const string DATE_FORMAT = "dd/MM/yy HH:mm";

		//Company
		public const int COMPANY_LEN = 20;
		public const int ADDRESS_LEN = 100;
		public const int LOCATION_LEN = 50;

		//Event 
		public const int EVENT_NAME = 50 ;

		//JobOffer
		public const int JOBOFFER_POSITION = 50;
		public const int JOBOFFER_STATUS = 50;
		public const int JOBOFFER_BONUS = 50;

		//Application
		public const int APP_NAME = 30;
		public const int APP_FULLNAME = 100;
		public const int APP_EMAIL = 50;

		//Type
		public const int TYPE_NAME = 50;

		//AppUser
		public const int USER_FIRST = 50;
		public const int USER_LAST = 50;

	}
}
