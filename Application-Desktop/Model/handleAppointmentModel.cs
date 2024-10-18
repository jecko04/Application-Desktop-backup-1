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

    public class AppointmentData
    {
        public int userId { get; set; }
        public string branch_name { get; set; }
        public string services { get; set; }
        public DateTime appointment_date { get; set; }
        public string appointment_time { get; set; }
    }

    public class ReceiptDetails
    {
        public string BranchName { get; set; }
        public string UserName { get; set; }
        public string ServiceTitle { get; set; }
        public string Status { get; set; }
        public decimal Price { get; set; }
    }
}
