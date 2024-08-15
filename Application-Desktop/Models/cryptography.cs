using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Isopoh.Cryptography.Argon2;
using BCrypt.Net;

namespace Application_Desktop.Models
{
    public class cryptography
    {
        public string HashPassword(string password)
        {
            /*int workFactor = 10;*/ // This is the cost factor
            return BCrypt.Net.BCrypt.HashPassword(password, 10); // Ensure 10 rounds
        }
        public bool VerifyPassword(string password, string hashPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashPassword);
        }
    }
}
