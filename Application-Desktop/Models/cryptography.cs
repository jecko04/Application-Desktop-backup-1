using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Isopoh.Cryptography.Argon2;

namespace Application_Desktop.Models
{
    public class cryptography
    {
        public string HashPassword(string password)
        {
            return Argon2.Hash(password);
        }
        public bool VerifyPassword(string password, string hashPassword)
        {
            return Argon2.Verify(hashPassword, password);
        }
    }
}
