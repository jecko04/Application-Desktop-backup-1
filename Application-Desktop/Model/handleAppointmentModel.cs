using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Model
{
    public class handleAppointmentModel
    {
    }

    public class appointment
    {
        public int _branch { get; set; }
        public int _services { get; set; }
        public DateTime _date { get; set; }
        public DateTime _time { get; set; }
        public DateTime _reschedDate { get; set; }
        public DateTime _reschedTime { get; set; }
        public string _status { get; set; }
        public Boolean _checkIns { get; set; } 
    }
}
