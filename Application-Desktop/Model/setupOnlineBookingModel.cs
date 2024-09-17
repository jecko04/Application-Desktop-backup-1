using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Model
{
    public class setupOnlineBookingModel
    {
    }

    public class DayofweekModel
    {
        [Required]
        public string _days { get; set; }
        [Required]
        public DateTime _start { get; set; }
        [Required]
        public DateTime _end { get; set; }
        public bool _isClose { get; set; }
    }

    public class Branches 
    {
        [Required]
        public string _branches { get; set; }
        public string _buildingnumber { get; set; }
        public string _street { get; set; }
        public string _barangay { get; set; }
        public string _city { get; set; }
        public string _province { get; set; }
        public string _postalcode { get; set; }
        public string _address { get; set; }
    }

    public class Categories
    {
        [Required]
        public string _title { get; set; }
        [Required]
        public string _description { get; set; }
        [Required]
        public string _duration { get; set; }
        [Required]
        public string _frequency { get; set; }
    }
}
