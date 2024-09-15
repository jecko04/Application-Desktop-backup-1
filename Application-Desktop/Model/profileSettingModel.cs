using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Model
{
    public class profileSettingModel
    {
        [Required]
        public string _name { get; set; }
        [Required]
        public string _email { get; set; }

        public string _firstname { get; set; }
        public string _lastname { get; set; }
    }
}
