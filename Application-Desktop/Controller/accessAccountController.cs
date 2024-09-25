using Application_Desktop.Model;
using Application_Desktop.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.IsisMtt.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Controller
{
    public class accessAccountController
    {
        private accessAccountModel _accessAccountModel;
        public accessAccountController()
        {
            _accessAccountModel = new accessAccountModel();
        }

        // ACCESS START
        public async Task<bool> ValidateAccess(string username, string password, int admin)
        {
            string query = @"SELECT password FROM access_account WHERE username = @username AND Branch_ID = @admin";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    await conn.OpenAsync();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@admin", admin);

                        object result = await cmd.ExecuteScalarAsync(); // Use object to handle null

                        if (result != null)
                        {
                            string storedHashedPassword = (string)result;

                            cryptography hash = new cryptography();
                            return hash.VerifyPassword(password, storedHashedPassword);
                        }
                        else
                        {
                            return false; // No access account found for this branch
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error validating access: {ex.Message}");
            }
        }

        public async Task<bool> CheckAccountExists(string username, int admin)
        {
            string query = @"SELECT COUNT(*) FROM access_account WHERE username = @username AND Branch_ID = @admin";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    await conn.OpenAsync();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@admin", admin);

                        int count = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                        return count > 0; 
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking account existence: {ex.Message}");
            }
        }
        //ACCESS END


        public async Task<List<AccessAccount>> SelectAdmin()
        {
            string query = @"SELECT Email FROM admin";
            List<AccessAccount> accessAccounts = new List<AccessAccount>();

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                AccessAccount access = new AccessAccount
                                {
                                    _email = reader.GetString("Email")
                                };
                                accessAccounts.Add(access);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error selecting admin: {ex.Message}", ex);
            }

            return accessAccounts;
        }

        public async Task<AccessAccount> SelectBranchByAdmin(string admin)
        {
            string query = @"SELECT b.Branch_ID, b.BranchName 
                            FROM branch b
                            INNER JOIN admin a ON b.Branch_ID = a.Branch_ID
                            WHERE a.Email = @email";


            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", admin);
                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                AccessAccount access = new AccessAccount
                                {
                                    _branchId = reader.GetInt32("Branch_ID"),
                                    _branchName = reader.GetString("BranchName")
                                };

                                return access;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error selecting admin: {ex.Message}", ex);
            }
            return null;
        }

        public async Task<int> SelectAdminID(string email)
        {
            string query = @"SELECT Admin_ID FROM admin WHERE Email = @Email";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        object result = await cmd.ExecuteScalarAsync();
                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            throw new Exception("Admin not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error selecting Admin ID: {ex.Message}", ex);
            }
        }

        public async Task<bool> UsernameExists(string username)
        {
            string query = @"SELECT COUNT(*) FROM access_account WHERE username = @username";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        int count = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                        return count > 0; 
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking username existence: {ex.Message}", ex);
            }
        }

        public async Task<bool> EmailExists(string email)
        {
            string query = @"SELECT COUNT(*) FROM access_account WHERE email = @Email";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        int count = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                        return count > 0; 
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking email existence: {ex.Message}", ex);
            }
        }


        public async Task Create(AccessAccount accessAccount)
        {
            accessAccount._adminId = await SelectAdminID(accessAccount._email); 
            var branchInfo = await SelectBranchByAdmin(accessAccount._email); 
            if (branchInfo != null)
            {
                accessAccount._branchId = branchInfo._branchId; 
            }
            else
            {
                throw new Exception("Branch not found for the given admin.");
            }

            string query = @"INSERT INTO `access_account`(`Admin_ID`, `email`, `username`, `password`, `Branch_ID`, `created_at`, `updated_at`)
                     VALUES(@adminId, @email, @username, @password, @branchId, @createdAt, @updatedAt)";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@adminId", accessAccount._adminId);
                        cmd.Parameters.AddWithValue("@email", accessAccount._email);
                        cmd.Parameters.AddWithValue("@username", accessAccount._usrename);

                        cryptography hasher = new cryptography();
                        string hashedPassword = hasher.HashPassword(accessAccount._password);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);

                        cmd.Parameters.AddWithValue("@branchId", accessAccount._branchId);
                        cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@updatedAt", DateTime.Now);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating access account: {ex.Message}", ex);
            }
        }

    }
}
