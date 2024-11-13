using Application_Desktop.Model;
using Application_Desktop.Models;
using MySql.Data.MySqlClient;
using OfficeOpenXml.FormulaParsing.Excel.Functions;
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

        public async Task<DataTable> InqueueAppointment()
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
                        WHERE a.status = 'pending' && a.reschedule_date IS NULL
                        ORDER BY a.created_at DESC";

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

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();

                            adapter.Fill(dataTable);

                            return dataTable.Rows.Count > 0 ? dataTable : null;
                        }
                    }
                }
            }
            catch (MySqlException dbEx)
            {
                throw new Exception($"Database error occurred while selecting Inqueue: {dbEx.Message}", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error on selecting Inqueue: {ex.Message}", ex);
            }
        }

        public async Task<DataTable> RescheduleAppointment()
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
                        WHERE a.status = 'pending' && a.reschedule_date IS NOT NULL
                        ORDER BY a.created_at DESC";

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

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();

                            adapter.Fill(dataTable);

                            return dataTable.Rows.Count > 0 ? dataTable : null;
                        }
                    }
                }
            }
            catch (MySqlException dbEx)
            {
                throw new Exception($"Database error occurred while selecting Inqueue: {dbEx.Message}", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error on selecting Inqueue: {ex.Message}", ex);
            }
        }

        public async Task<DataTable> ApprovedAppointment()
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
                        WHERE a.status = 'approved'
                        ORDER BY a.created_at DESC";

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

        public async Task<DataTable> CancelledAppointment()
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
                        WHERE a.status = 'cancelled'
                        ORDER BY a.created_at DESC";

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

        public async Task<DataTable> MissedAppointment()
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
                        WHERE a.status = 'missed'
                        ORDER BY a.created_at DESC";

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

        public async Task<DataTable> CompletedAppointment()
        {
            string query = @"
                            SELECT 
                                a.id,
                                a.user_id,
                                u.name AS UserName,
                                a.selectedBranch,
                                b.BranchName,
                                a.selectServices,
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
                            WHERE a.status = 'completed'
                            ORDER BY a.created_at DESC";

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

                        

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

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

                        

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

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

        public async Task Missed(string status, int id)
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

                        

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                        {
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Failed to missed appointment status.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating to approve : {ex.Message}");
            }
        }

        public async Task Complete(string status, int id)
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
                        cmd.Parameters.AddWithValue("@appointmentId", id);

                        

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
                                email = reader.GetString(reader.GetOrdinal("email"));
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
                WHERE a.user_id = @userId
                  AND a.status = 'approved' -- Assumes 'approved' is the status for approved appointments
                ORDER BY 
                    IFNULL(a.reschedule_date, a.appointment_date) DESC, 
                    IFNULL(a.reschedule_time, a.appointment_time) DESC
                LIMIT 1;";

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
            string query = @"
            UPDATE appointments 
            SET check_in = 1 
            WHERE user_id = @userId AND status = 'approved'
              AND (IFNULL(reschedule_date, appointment_date), IFNULL(reschedule_time, appointment_time)) = (
                  SELECT IFNULL(reschedule_date, appointment_date), IFNULL(reschedule_time, appointment_time) 
                  FROM appointments 
                  WHERE user_id = @userId AND status = 'approved'
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

        public async Task<ReceiptDetails> PrintReceiptDetails(int userId, int branchId, int categoriesId)
        {
            string query = @"SELECT 
                    b.BranchName,
                    u.name AS UserName,
                    c.Title AS ServiceTitle,
                    c.Price,
                    a.status
                FROM appointments a
                INNER JOIN branch b ON a.selectedBranch = b.Branch_ID
                INNER JOIN categories c ON a.selectServices = c.Categories_ID
                INNER JOIN users u ON a.user_id = u.id
                WHERE a.user_id = @userId 
                    AND a.selectedBranch = @branchId 
                    AND a.selectServices = @categoriesId
                    AND a.status = 'completed'
                ORDER BY COALESCE(a.reschedule_date, a.appointment_date) DESC
                LIMIT 1;";

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
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@branchId", branchId);
                        cmd.Parameters.AddWithValue("@categoriesId", categoriesId);

                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                // Map the query result to the ReceiptDetails object
                                var receiptDetails = new ReceiptDetails
                                {
                                    BranchName = reader.GetString("BranchName"),
                                    UserName = reader.GetString("UserName"),
                                    ServiceTitle = reader.GetString("ServiceTitle"),
                                    Price = reader.GetDecimal("Price"),
                                    Status = reader.GetString("status")
                                };

                                return receiptDetails;
                            }
                            else
                            {
                                throw new Exception("No data found for the specified branch and service.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting receipt details: {ex.Message}");
            }
        }

        public async Task<DataTable> SearchByName(string userName)
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
            WHERE u.name LIKE @userName";  // Add search filter by user name

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
                        // Use parameterized query to avoid SQL injection
                        cmd.Parameters.AddWithValue("@userName", "%" + userName + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();

                            adapter.Fill(dataTable);

                            return dataTable.Rows.Count > 0 ? dataTable : null;
                        }
                    }
                }
            }
            catch (MySqlException dbEx)
            {
                throw new Exception($"Database error occurred while searching by name: {dbEx.Message}", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error on searching by name: {ex.Message}", ex);
            }
        }

        public async Task InqueuNotif(PictureBox notif)
        {
            string query = @"SELECT COUNT(*) FROM appointments WHERE status = 'pending' AND reschedule_date IS NULL";

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
                        int count = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                        notif.Visible = count > 0;
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error {ex.Message}");
            }
        }

        public async Task RescheduleNotif(PictureBox notif)
        {
            string query = @"SELECT COUNT(*) FROM appointments WHERE status = 'pending' AND reschedule_date IS NOT NULL";

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
                        int count = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                        notif.Visible = count > 0;
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error {ex.Message}");
            }
        }
    }


}
