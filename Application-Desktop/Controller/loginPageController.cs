using Application_Desktop.Models;
using Application_Desktop.Views;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace Application_Desktop.Controller
{
    public class loginPageController
    {
        public async Task InsertOtp(int userId, string email, int otp)
        {
            string query = @"INSERT INTO otp (Admin_ID, email, otp, otpExpirationDate, isUsed, created_at, updated_at) 
                     VALUES (@adminId, @email, @otp, @expirationTime, @isUsed, @createdAt, @updatedAt)
                     ON DUPLICATE KEY UPDATE 
                         otp = VALUES(otp),
                         otpExpirationDate = VALUES(otpExpirationDate),
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
                        cmd.Parameters.AddWithValue("@adminId", userId);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@otp", otp);
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

        public async Task InsertOtpSuper(int superadminId, string email, int otp)
        {
            string query = @"INSERT INTO otp (SuperAdmin_ID, email, otp, otpExpirationDate, isUsed, created_at, updated_at) 
                     VALUES (@superadminId, @email, @otp, @expirationTime, @isUsed, @createdAt, @updatedAt)
                     ON DUPLICATE KEY UPDATE 
                         otp = VALUES(otp),
                         otpExpirationDate = VALUES(otpExpirationDate),
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
                        cmd.Parameters.AddWithValue("@otp", otp);
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


        public async Task<int?> SelectBranchID(int adminId)
        {
            string query = @"SELECT Branch_ID from admin where Admin_ID = @adminId";

            using (MySqlConnection conn = databaseHelper.getConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@adminId", adminId);
                    using (MySqlDataReader reader = (MySqlDataReader) await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            int branchId = reader.GetInt32("Branch_ID");
                            return branchId;
                        }
                    }
                }
            }
            return null;
        }

        public async Task<bool> CheckUnusedOtp(int userId)
        {
            string query = "SELECT otp, otpExpirationDate, isUsed FROM otp WHERE Admin_ID = @userId AND isUsed = true ORDER BY otpExpirationDate DESC LIMIT 1";

            using (MySqlConnection conn = databaseHelper.getConnection())
            {
                await conn.OpenAsync();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            DateTime expiration = reader.GetDateTime("otpExpirationDate");
                            bool isUsed = reader.GetBoolean("isUsed");

                            if (DateTime.Now < expiration)
                            {
                                return true; 
                            }
                        }
                    }
                }
            }

            return false; 
        }

        public async Task<bool> CheckUnusedOtpSuper(int superAdminId)
        {
            string query = "SELECT otp, otpExpirationDate, isUsed FROM otp WHERE SuperAdmin_ID = @superAdminId AND isUsed = true ORDER BY otpExpirationDate DESC LIMIT 1";

            using (MySqlConnection conn = databaseHelper.getConnection())
            {
                await conn.OpenAsync();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@superAdminId", superAdminId);

                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            DateTime expiration = reader.GetDateTime("otpExpirationDate");
                            bool isUsed = reader.GetBoolean("isUsed");

                            if (DateTime.Now < expiration)
                            {
                                return true;
                            }
                        }                    
                    }
                }
            }

            return false; 
        }

        public async Task<bool> VerifyOTP(int adminId, string otp)
        {
            string query = "SELECT otp, otpExpirationDate, isUsed FROM otp WHERE Admin_ID = @adminId AND isUsed = false AND otp = @otp ORDER BY otpExpirationDate DESC LIMIT 1";

            using (MySqlConnection conn = databaseHelper.getConnection())
            {
                await conn.OpenAsync();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@adminId", adminId);
                    cmd.Parameters.AddWithValue("@otp", otp);

                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            DateTime expiration = reader.GetDateTime("otpExpirationDate");

                            if (DateTime.Now < expiration)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        public async Task<bool> VerifyOTPsuper(int superAdminId, string otp)
        {
            string query = "SELECT otp, otpExpirationDate, isUsed FROM otp WHERE SuperAdmin_ID = @superAdminId AND isUsed = false AND otp = @otp ORDER BY otpExpirationDate DESC LIMIT 1";

            using (MySqlConnection conn = databaseHelper.getConnection())
            {
                await conn.OpenAsync();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@superAdminId", superAdminId);
                    cmd.Parameters.AddWithValue("@otp", otp);

                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            DateTime expiration = reader.GetDateTime("otpExpirationDate");

                            if (DateTime.Now < expiration)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }


        public async Task UpdateOtpStatusAsync(int? userId, int? superadminId, bool isUsed)
        {

            string query = @"UPDATE otp SET isUsed = @isUsed WHERE Admin_ID = @userId AND isUsed = false";

            using (MySqlConnection conn = databaseHelper.getConnection())
            {
                await conn.OpenAsync();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId.HasValue ? userId.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@superAdminId", superadminId.HasValue ? superadminId.Value : DBNull.Value);

                    cmd.Parameters.AddWithValue("@isUsed", isUsed);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateOtpStatusAsyncSuper(int superAdminId, bool isUsed)
        {
            string query = "UPDATE otp SET isUsed = @isUsed WHERE SuperAdmin_ID = @superAdminId AND isUsed = false ORDER BY otpExpirationDate DESC LIMIT 1";

            using (MySqlConnection conn = databaseHelper.getConnection())
            {
                await conn.OpenAsync();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@superAdminId", superAdminId);
                    cmd.Parameters.AddWithValue("@isUsed", isUsed);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
