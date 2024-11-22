using Application_Desktop.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
                        using (MySqlDataReader reader = (MySqlDataReader) await cmd.ExecuteReaderAsync())
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
        public async Task InsertResetPasswordToken(int adminId, string email, string token)
        {
            string query = @"INSERT INTO token_desktop (Admin_ID, email, token, tokenExpirationDate, isUsed, created_at, updated_at) 
                VALUES (@adminId, @email, @token, @expirationTime, @isUsed, @createdAt, @updatedAt)
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
                        cmd.Parameters.AddWithValue("@adminId", adminId);
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



        public async Task<bool> ChangePassword(string password, int adminId)
        {
            string query = @"UPDATE admin SET password = @password, updated_at = @updatedAt WHERE Admin_ID = @adminId";

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


    }
}
