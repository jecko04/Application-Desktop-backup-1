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
    public class handleAppointmentController
    {
        public handleAppointmentModel _handleAppointmentModel;

        public handleAppointmentController()
        {
            _handleAppointmentModel = new handleAppointmentModel();
        }

        public async Task<DataTable> InqueueAppointment(int admin)
        {
            string query = @"
                            SELECT 
                                a.id,
                                a.user_id,
                                u.name AS UserName,
                                b.BranchName,
                                c.Title AS ServiceTitle,
                                a.appointment_date,
                                a.appointment_time,
                                a.reschedule_date,
                                a.reschedule_time,
                                a.status,
                                a.check_in
                            FROM appointments a
                            INNER JOIN branch b ON a.selectedBranch = b.Branch_ID
                            INNER JOIN categories c ON a.selectServices = c.Categories_ID
                            INNER JOIN users u ON a.user_id = u.id
                            WHERE a.selectedBranch = @admin AND a.status = 'pending'";

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
                        cmd.Parameters.AddWithValue("@admin", admin);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();

                            await Task.Run(() => adapter.Fill(dataTable));

                            return dataTable.Rows.Count > 0 ? dataTable : new DataTable();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error on selecting Inqueue : {ex.Message}");
            }

        }

        public async Task<DataTable> ApprovedAppointment(int admin)
        {
            string query = @"
                            SELECT 
                                a.id,
                                a.user_id,
                                u.name AS UserName,
                                b.BranchName,
                                c.Title AS ServiceTitle,
                                a.appointment_date,
                                a.appointment_time,
                                a.reschedule_date,
                                a.reschedule_time,
                                a.status,
                                a.check_in
                            FROM appointments a
                            INNER JOIN branch b ON a.selectedBranch = b.Branch_ID
                            INNER JOIN categories c ON a.selectServices = c.Categories_ID
                            INNER JOIN users u ON a.user_id = u.id
                            WHERE a.selectedBranch = @admin AND a.status = 'approved'";

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
                        cmd.Parameters.AddWithValue("@admin", admin);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();

                            await Task.Run(() => adapter.Fill(dataTable));

                            return dataTable.Rows.Count > 0 ? dataTable : new DataTable();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error on selecting Inqueue : {ex.Message}");
            }

        }

        public async Task<DataTable> CancelledAppointment(int admin)
        {
            string query = @"
                            SELECT 
                                a.id,
                                a.user_id,
                                u.name AS UserName,
                                b.BranchName,
                                c.Title AS ServiceTitle,
                                a.appointment_date,
                                a.appointment_time,
                                a.reschedule_date,
                                a.reschedule_time,
                                a.status,
                                a.check_in
                            FROM appointments a
                            INNER JOIN branch b ON a.selectedBranch = b.Branch_ID
                            INNER JOIN categories c ON a.selectServices = c.Categories_ID
                            INNER JOIN users u ON a.user_id = u.id
                            WHERE a.selectedBranch = @admin AND a.status = 'cancelled'";

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
                        cmd.Parameters.AddWithValue("@admin", admin);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();

                            await Task.Run(() => adapter.Fill(dataTable));

                            return dataTable.Rows.Count > 0 ? dataTable : new DataTable();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error on selecting Inqueue : {ex.Message}");
            }

        }

        public async Task<DataTable> CompletedAppointment(int admin)
        {
            string query = @"
                            SELECT 
                                a.id,
                                a.user_id,
                                u.name AS UserName,
                                b.BranchName,
                                c.Title AS ServiceTitle,
                                a.appointment_date,
                                a.appointment_time,
                                a.reschedule_date,
                                a.reschedule_time,
                                a.status,
                                a.check_in
                            FROM appointments a
                            INNER JOIN branch b ON a.selectedBranch = b.Branch_ID
                            INNER JOIN categories c ON a.selectServices = c.Categories_ID
                            INNER JOIN users u ON a.user_id = u.id
                            WHERE a.selectedBranch = @admin AND a.status = 'completed'";

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
                        cmd.Parameters.AddWithValue("@admin", admin);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();

                            await Task.Run(() => adapter.Fill(dataTable));

                            return dataTable.Rows.Count > 0 ? dataTable : new DataTable();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error on selecting Inqueue : {ex.Message}");
            }

        }


        public async Task Approved(string status, int id)
        {
            string query = "UPDATE appointments SET status = @newStatus WHERE id = @appointmentId";

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
                        cmd.Parameters.AddWithValue("@appointmentId", id);

                        await cmd.ExecuteNonQueryAsync();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Failed to update appointment status.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating to approve : {ex.Message}");
            }
        }

        public async Task Cancel(string status, int id)
        {
            string query = "UPDATE appointments SET status = @newStatus WHERE id = @appointmentId";

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
                        cmd.Parameters.AddWithValue("@appointmentId", id);

                        await cmd.ExecuteNonQueryAsync();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Failed to cancel appointment status.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating to approve : {ex.Message}");
            }
        }

        public async Task<string> SelectEmail(int userId)
        {
            string query = @"SELECT email FROM users WHERE id = @user_id";
            string email = null;

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
                        cmd.Parameters.AddWithValue("@user_id", userId);

                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                email = reader.GetString("email");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Selecting Email: {ex.Message}");
            }

            return email;
        }

        public async Task<bool> CheckAppointmentStatus(int userId, DateTime appointmentDate, string appointmentTime)
        {
            string query = @"
                    SELECT a.status 
                    FROM appointments a
                    WHERE 
                        a.user_id = @userId 
                        AND a.appointment_date = @appointmentDate 
                        AND a.appointment_time = @appointmentTime";

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
                        cmd.Parameters.AddWithValue("@appointmentDate", appointmentDate);
                        cmd.Parameters.AddWithValue("@appointmentTime", appointmentTime);

                        var status = await cmd.ExecuteScalarAsync();
                        return status != null && status.ToString() == "approved"; // Adjust if you want to check for other statuses
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking appointment status: {ex.Message}");
            }
        }

        public async Task<bool> UpdateCheckInStatus(int userId, DateTime appointmentDate, string appointmentTime)
        {
            string query = "UPDATE appointments SET check_in = 1 WHERE user_id = @userId AND appointment_date = @appointmentDate AND appointment_time = @appointmentTime"; // Corrected parameter name

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
                        cmd.Parameters.AddWithValue("@appointmentDate", appointmentDate);
                        cmd.Parameters.AddWithValue("@appointmentTime", appointmentTime);
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

    }


}
