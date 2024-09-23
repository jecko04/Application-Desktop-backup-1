using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Model
{
    public class patientRecordModel
    {
    }

    public class PatientRecord
    {
        [Required]
        public string _fullname { get; set; }

        [Required]
        [Range(0, 120)]
        public int _age { get; set; }

        [Required]
        public DateTime _dob { get; set; }

        [Required]
        public string _gender { get; set; }

        [Required]
        public string _contact { get; set; }

        [Required]
        [EmailAddress]
        public string _email { get; set; }

        [Required]
        public string _address { get; set; }

        [Required]
        public string _emergency { get; set; }

    }

    public class PatientGenHealth
    {
        public string _medcondition { get; set; }
        public string _currmedication { get; set; }
        public string _allergies { get; set; }
        public string _pastsurg { get; set; }
        public string _fammedhistory { get; set; }
        public string _bloodpressure { get; set; }
        public bool _heartdisease { get; set; }
        public bool _diabetes { get; set; }
        public bool _smoker { get; set; }
    }

    public class PatientDentHealth
    {
        public DateTime _lastvisit { get; set; }
        public string _pastdenttreatment { get; set; }
        public bool _toothpain { get; set; }
        public bool _gumdisease { get; set; }
        public bool _teethgrind { get; set; }
        public string _toothsens { get; set; }
        public bool _ortho { get; set; }
        public bool _dentimps { get; set; }
        public bool _bleedinggums { get; set; }


    }
}
