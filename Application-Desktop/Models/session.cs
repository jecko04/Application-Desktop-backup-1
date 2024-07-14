using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Models
{
    public static class session
    {
        public static int LoggedInSession { get; set; }

        public static void Logout()
        {
            LoggedInSession = 0;
        }

    }
}
