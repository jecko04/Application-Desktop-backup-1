using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Application_Desktop.Models
{
    public class emailValidator
    {
        public static bool IsEmailValidate (string email)
        {
            if (string.IsNullOrEmpty (email)) 
                return false;

            try
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                return regex.IsMatch(email);
            }
            catch
            {
                return false;
            }

        }
        public static bool IsEmailNotValidate (string email)
        {
            return !IsEmailValidate (email);
        }

        public static bool IsEmailAdminExist(string email)
        {
            string adminQuery = "SELECT COUNT(*) FROM admin WHERE Email = @Email";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    MySqlCommand cmd = new MySqlCommand(adminQuery, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    int adminCount = Convert.ToInt32(cmd.ExecuteScalar());

                return adminCount > 0;
                
            }
            catch (Exception ex)
            {
                throw new Exception("Database error: " + ex.Message);
            }
            finally { conn.Close(); }
        }

        public static bool IsEmailSuperAdminExist(string email)
        {
            string superAdminQuery = "SELECT COUNT(*) FROM superadmin WHERE Email = @Email";

            MySqlConnection conn = databaseHelper.getConnection();
            
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmdSuper = new MySqlCommand(superAdminQuery, conn);
                cmdSuper.Parameters.AddWithValue("@Email", email);
                int superAdminCount = Convert.ToInt32(cmdSuper.ExecuteScalar());

                return superAdminCount > 0;

            }
            catch (Exception ex)
            {
                throw new Exception("Database error: " + ex.Message);
            }
            finally { conn.Close(); }
        }

        public static bool IsEmailUserExist(string email)
        {
            string UserQuery = "SELECT COUNT(*) FROM dentaldoctor WHERE Email = @email";
            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmdUser = new MySqlCommand(UserQuery, conn);
                cmdUser.Parameters.AddWithValue("@Email", email);
                int UserCount = Convert.ToInt32(cmdUser.ExecuteScalar());

                return UserCount > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Database error: " + ex.Message);
            }
            finally { conn.Close(); }
        }

    }
}
