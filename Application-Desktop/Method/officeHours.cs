using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Models
{
    public class officeHours
    {
        // OfficeHour.cs
        public class OfficeHour
        {
            public DayOfWeek Day { get; set; }
            public TimeSpan Start { get; set; }
            public TimeSpan End { get; set; }
        }

        // TimeSlot.cs
        public class TimeSlot
        {
            public TimeSpan Start { get; set; }
            public TimeSpan End { get; set; }
        }

        // Exception.cs
        public class Exception
        {
            public DateTime Date { get; set; }
            public string Reason { get; set; }
        }

    }
}
