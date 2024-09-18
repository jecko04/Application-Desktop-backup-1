using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Models
{
    public static class session
    {
        private static int _loggedInSession;

        public static int LoggedInSession
        {
            get { return _loggedInSession; }
            set { _loggedInSession = value; }
        }

        public static void SetSession(int sessionId)
        {
            LoggedInSession = sessionId;
        }


        public static void Logout()
        {
            LoggedInSession = 0;
        }

    }
}
