using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Application_Desktop.Models
{
    public class passwordValidator
    {
        public static bool IsPasswordValidate(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(password);
        }

        public static bool isPasswordNotValid(string password)
        {
            return !IsPasswordValidate(password);
        }
    }
}
