using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Model
{
    public class accessAccountModel
    {

    }

    public class AccessAccount
    {
        [Required]
        public int _adminId { get; set; }

        [Required]
        [EmailAddress]
        public string _email { get; set; }
        [EmailAddress]
        public string _usrename { get; set; }

        [Required]
        public int _branchId { get; set; }

        [Required]
        public string _branchName { get; set; }

        [Required]
        public string _password { get; set; }

        public Dictionary<string, string> validate()
        {
            var error = new Dictionary<string, string>();

            // Check if email is null or invalid
            if (string.IsNullOrWhiteSpace(_email) || !_email.Contains("@"))
            {
                error["Email"] = "A valid email is required.";
            }

            if (string.IsNullOrWhiteSpace(_usrename))
            {
                error["Username"] = "Username is required.";
            }

            // Check if branch name is provided
            if (string.IsNullOrEmpty(_branchName))
            {
                error["BranchName"] = "Branch name is required.";
            }

            // Check if password is provided
            if (string.IsNullOrEmpty(_password))
            {
                error["Password"] = "Password is required.";
            }

            return error;
        }
    }

    public class AccessAccountLogs
    {
        [Required]
        public string _username { get; set; }
        [Required]
        public int _branchId { get; set; }
        [Required]
        public DateTime _loginTime { get; set; }
        [Required]
        public int _success { get; set; }
        [Required]
        [MaxLength(50)]
        public string _ipAddress { get; set; }

    }
}
