using Application_Desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Model
{
    public class superAdminProfileSettingModel
    {
    }

    public class superAdminProfileUpdateInfoModel
    {
        [Required]
        public string _name { get; set; }
        [Required]
        [EmailAddress]
        public string _email { get; set; }

        public string _firstname { get; set; }
        public string _lastname { get; set; }

        public Dictionary<string, string> validate()
        {
            var error = new Dictionary<string, string>();

            if (string.IsNullOrEmpty(_firstname))
            {
                error["Firstname"] = "Firstname is required";
            }

            if (string.IsNullOrEmpty(_lastname))
            {
                error["Lastname"] = "Lastname is required";
            }

            if (string.IsNullOrWhiteSpace(_email) || !_email.Contains("@"))
            {
                error["Email"] = "A valid email is required.";
            }
            return error;
        }
    }

    public class superAdminUpdatePasswordModel
    {
        [Required]
        public string _currentPassword { get; set; }
        [Required]
        public string _newPassword { get; set; }
        [Required]
        public string _confrimPassword { get; set; }

        public Dictionary<string, string> validate()
        {
            var error = new Dictionary<string, string>();

            //empty field
            if (string.IsNullOrEmpty(_currentPassword))
            {
                error["Current"] = "Current password is required";
            }

            //validate password
            if (!passwordValidator.IsPasswordValidate(_newPassword))
            {
                error["NotValid"] = "Password must be at least 8 characters long and contain at least\" +\r\n                    \" one uppercase letter, one lowercase letter, and one number";
            }

            //not match
            if (_newPassword != _confrimPassword)
            {
                error["NotMatch"] = "The new password is not match";
            }

            return error;

        }
    }
}
