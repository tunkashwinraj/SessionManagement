using System;
using System.Web;

namespace SessionManagement_1262774.Utils
{
    public class SessionFacade
    {
        private SessionFacade() { }

        // Declare session constants for the key names
        private const string USERNAME = "USERNAME";
        private const string ACCOUNTNUM = "ACCOUNTNUM";
        private const string LASTLOGIN = "LASTLOGIN";

        public static string UserName
        {
            get => HttpContext.Current.Session[USERNAME]?.ToString();
            set => HttpContext.Current.Session[USERNAME] = value;
        }

        public static int? Account
        {
            get => HttpContext.Current.Session[ACCOUNTNUM] as int?;
            set => HttpContext.Current.Session[ACCOUNTNUM] = value;
        }

        public static DateTime? LastLogin
        {
            get => HttpContext.Current.Session[LASTLOGIN] as DateTime?;
            set => HttpContext.Current.Session[LASTLOGIN] = value;
        }
    }
}
