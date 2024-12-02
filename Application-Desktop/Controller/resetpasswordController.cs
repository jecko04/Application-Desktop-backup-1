using Application_Desktop.Model;
using Application_Desktop.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Controller
{
    public class resetpasswordController
    {

        public async Task<int> FindUserId(string email)
        {
            string query = @"SELECT Admin_ID from admin Where Email = @email";
            int adminId = 0;

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
                        cmd.Parameters.AddWithValue("@email", email);
                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                adminId = reader.GetInt32("Admin_ID");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Selecting Email {ex.Message}");
            }
            return adminId;
        }

        public async Task<int> FindUserIdSuper(string email)
        {
            string query = @"SELECT SuperAdmin_ID from superadmin Where Email = @email";
            int adminId = 0;

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
                        cmd.Parameters.AddWithValue("@email", email);
                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                adminId = reader.GetInt32("Admin_ID");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Selecting Email {ex.Message}");
            }
            return adminId;
        }


        public async Task<(int userId, string userType)> FindUserByEmail(string email)
        {
            string queryAdmin = @"SELECT Admin_ID AS UserID, 'admin' AS UserType FROM admin WHERE Email = @Email";
            string querySuperAdmin = @"SELECT SuperAdmin_ID AS UserID, 'superadmin' AS UserType FROM superadmin WHERE Email = @Email";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(queryAdmin, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                return (reader.GetInt32("UserID"), reader.GetString("UserType"));
                            }
                        }
                    }

                    using (MySqlCommand cmd = new MySqlCommand(querySuperAdmin, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                return (reader.GetInt32("UserID"), reader.GetString("UserType"));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching user: {ex.Message}");
            }

            return (0, null); // Not found
        }


        public async Task InsertResetPasswordToken(int userId, string email, string token, string userType)
        {
            string column = userType == "admin" ? "Admin_ID" : "SuperAdmin_ID";
            string query = $@"
                INSERT INTO token_desktop ({column}, email, token, tokenExpirationDate, isUsed, created_at, updated_at)
                VALUES (@UserId, @Email, @Token, @ExpirationDate, @IsUsed, @CreatedAt, @UpdatedAt)
                ON DUPLICATE KEY UPDATE
                    token = VALUES(token),
                    tokenExpirationDate = VALUES(tokenExpirationDate),
                    isUsed = VALUES(isUsed),
                    updated_at = VALUES(updated_at);";

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
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Token", token);
                        cmd.Parameters.AddWithValue("@ExpirationDate", DateTime.Now.AddMinutes(3));
                        cmd.Parameters.AddWithValue("@IsUsed", false);

                        DateTime now = DateTime.Now;
                        cmd.Parameters.AddWithValue("@CreatedAt", now);
                        cmd.Parameters.AddWithValue("@UpdatedAt", now);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inserting token: {ex.Message}");
            }
        }

        public async Task InsertResetPasswordTokenSuper(int superadminId, string email, string token)
        {
            string query = @"INSERT INTO token_desktop (SuperAdmin_ID, email, token, tokenExpirationDate, isUsed, created_at, updated_at) 
                VALUES (@superadminId, @email, @token, @expirationTime, @isUsed, @createdAt, @updatedAt)
                ON DUPLICATE KEY UPDATE 
                    token = VALUES(token),
                    tokenExpirationDate = VALUES(tokenExpirationDate),
                    isUsed = VALUES(isUsed),
                    updated_at = VALUES(updated_at);";

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
                        cmd.Parameters.AddWithValue("@superadminId", superadminId);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@token", token);
                        cmd.Parameters.AddWithValue("@expirationTime", DateTime.Now.AddMinutes(3));
                        cmd.Parameters.AddWithValue("@isUsed", false);

                        DateTime now = DateTime.Now;
                        cmd.Parameters.AddWithValue("@createdAt", now);
                        cmd.Parameters.AddWithValue("@updatedAt", now);


                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Send OTP {ex.Message}");
            }
        }

        public async Task<bool> VerifyToken(string token)
        {
            string query = @"SELECT COUNT(*) 
                     FROM token_desktop 
                     WHERE token = @token AND tokenExpirationDate > @currentDate AND isUsed = false";

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
                        cmd.Parameters.AddWithValue("@token", token);
                        cmd.Parameters.AddWithValue("@currentDate", DateTime.Now);

                        int count = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error verifying token: {ex.Message}");
            }
        }

        public async Task<int> GetAdminIdByToken(string token)
        {
            string query = @"SELECT Admin_ID FROM token_desktop WHERE token = @token AND tokenExpirationDate > NOW() AND isUsed = false";

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
                        cmd.Parameters.AddWithValue("@token", token);

                        object result = await cmd.ExecuteScalarAsync();
                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            throw new Exception("Invalid or expired token.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving admin ID: {ex.Message}");
            }
        }

        public async Task<(int AdminId, int SuperAdminId)> GetUserByToken(string token)
        {
            string query = @"SELECT Admin_ID, SuperAdmin_ID FROM token_desktop WHERE token = @token AND isUsed = 0 AND tokenExpirationDate > NOW()";
            using (MySqlConnection conn = databaseHelper.getConnection())
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@token", token);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.Read())
                        {
                            return (
                                reader.IsDBNull("Admin_ID") ? 0 : reader.GetInt32("Admin_ID"),
                                reader.IsDBNull("SuperAdmin_ID") ? 0 : reader.GetInt32("SuperAdmin_ID")
                            );
                        }
                    }
                }
            }
            return (0, 0); // Default values if no valid token is found
        }



        public async Task<bool> ChangePassword(string password, int adminId)
        {
            string query = @"UPDATE admin SET Password = @password, updated_at = @updatedAt WHERE Admin_ID = @adminId";

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
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@adminId", adminId);
                        cmd.Parameters.AddWithValue("@updatedAt", DateTime.Now);

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();
                        if (rowsAffected == 0)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating password: {ex.Message}");
            }
        }

        public async Task<bool> ChangePasswordSuper(string password, int superadminId)
        {
            string query = @"UPDATE superadmin SET Password = @password, updated_at = @updatedAt WHERE SuperAdmin_ID = @superadminId";

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
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@superadminId", superadminId);
                        cmd.Parameters.AddWithValue("@updatedAt", DateTime.Now);

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();
                        if (rowsAffected == 0)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating password: {ex.Message}");
            }
        }

        public async Task MarkTokenAsUsed(string token)
        {
            string query = @"UPDATE token_desktop SET isUsed = 1 WHERE token = @token";
            using (MySqlConnection conn = databaseHelper.getConnection())
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@token", token);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }


    }
}
