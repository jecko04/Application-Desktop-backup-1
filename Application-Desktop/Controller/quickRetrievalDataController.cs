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
    }
}
