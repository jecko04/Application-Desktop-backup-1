using Application_Desktop.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Controller
{
    public class quickRetrievalDataController
    {
        public async Task<bool> SaveNotes(string notes, int userId, string email)
        {
            string query = @"INSERT INTO notes (user_id, email, notes, created_at, updated_at)
                     VALUES (@userId, @Email, @Notes, @CreatedAt, @UpdatedAt)
                     ON DUPLICATE KEY UPDATE
                         notes = VALUES(notes),
                         email = VALUES(email),
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
                        cmd.Parameters.AddWithValue("@Notes", notes);
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);

                        await cmd.ExecuteNonQueryAsync();
                        return true; 
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"error on saving {ex.Message}");
                return false;
            }
        }

        public async Task<string> SelectNotes(int userId)
        {
            string query = @"SELECT notes FROM notes WHERE user_id = @userId";
            string notes = null;

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
                        cmd.Parameters.AddWithValue("@userId", userId);

                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                notes = reader.GetString("notes");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error selecting notes: {ex.Message}", ex);
            }

            return notes;
        }

        public async Task<bool> IsCheckedIn(int appointmentId)
        {
            string query = "SELECT check_in FROM appointments WHERE id = @appointmentId";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                        object result = await cmd.ExecuteScalarAsync();

                        return result != null && Convert.ToBoolean(result);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking check_in status: {ex.Message}");
            }
        }

        public async Task Complete(string status, int appointmentId)
        {
            string query = "UPDATE appointments SET status = @newStatus WHERE id = @appointmentId && check_in = TRUE";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@newStatus", status);
                        cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                        {
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Failed to complete appointment status.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating to approve : {ex.Message}");
            }
        }

        public async Task RescheduleReason(int appointmentId, int userId, string reason)
        {
            string query = @"INSERT INTO reschedule_reasons (appointment_id, user_id, reason, created_at, updated_at)
                     VALUES (@appointmentId, @userId, @reason, @createdAt, @updatedAt)
                     ON DUPLICATE KEY UPDATE 
                         reason = VALUES(reason),
                         updated_at = VALUES(updated_at)";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@reason", reason);

                        DateTime now = DateTime.Now;
                        cmd.Parameters.AddWithValue("@createdAt", now);
                        cmd.Parameters.AddWithValue("@updatedAt", now);
                        
                        await cmd.ExecuteNonQueryAsync();

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding reason for reschedule {ex.Message}");
            }
        }

        public async Task Rescheduled(int userId, int services, DateTime rescheduleDate, DateTime rescheduleTime)
        {
            string query = @"
                    UPDATE appointments
                    SET selectServices = @services, reschedule_date = @rescheduleDate, reschedule_time = @rescheduleTime, check_in = 0, updated_at = @updatedAt
                    WHERE id = (
                        SELECT id
                        FROM appointments
                        WHERE user_id = @userId
                        ORDER BY created_at DESC, updated_at DESC
                        LIMIT 1
                    )
                    AND user_id = @userId AND status = 'approved'";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        //cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@services", services);
                        cmd.Parameters.AddWithValue("@rescheduleDate", rescheduleDate);
                        cmd.Parameters.AddWithValue("@rescheduleTime", rescheduleTime);

                        DateTime now = DateTime.Now;
                        cmd.Parameters.AddWithValue("@updatedAt", now);

                        await cmd.ExecuteNonQueryAsync();

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error on rescheduling {ex.Message}");
            }
        }

        public async Task<bool> UpdateCheckInStatus(int userId, int appointmentId)
        {
            string query = @"
            UPDATE appointments 
                SET check_in = 1 
                WHERE user_id = @userId 
                    AND id = @appointmentId 
                    AND status = 'approved'
                    AND (IFNULL(reschedule_date, appointment_date), IFNULL(reschedule_time, appointment_time)) = (
                        SELECT IFNULL(reschedule_date, appointment_date), IFNULL(reschedule_time, appointment_time) 
                        FROM appointments 
                        WHERE user_id = @userId 
                          AND id = @appointmentId 
                          AND status = 'approved'
                        ORDER BY IFNULL(reschedule_date, appointment_date) DESC, IFNULL(reschedule_time, appointment_time) DESC 
                        LIMIT 1
                    )";
            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                       /*cmd.Parameters.AddWithValue("@appointmentDate", appointmentDate);
                        cmd.Parameters.AddWithValue("@appointmentTime", appointmentTime);*/
                        int affectedRows = await cmd.ExecuteNonQueryAsync();
                        return affectedRows > 0; // Indicates whether an update was made
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating check-in status: {ex.Message}");
            }
        }

        public class Service
        {
            public int Categories_ID { get; set; }
            public string Title { get; set; }
        }


        public async Task<List<Service>> SelectPopulateServices(int selectedBranch)
        {
            string query = @"SELECT Categories_ID, Title FROM categories WHERE Branch_ID = @selectedBranch";
            List<Service> services = new List<Service>();

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@selectedBranch", selectedBranch);

                        using (MySqlDataReader reader = (MySqlDataReader) await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                var service = new Service
                                {
                                    Categories_ID = reader.GetInt32("Categories_ID"),
                                    Title = reader.GetString("Title")
                                };
                                services.Add(service);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error populating services: {ex.Message}");
            }

            return services;
        }
    }
}
