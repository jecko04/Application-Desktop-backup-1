using Application_Desktop.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Application_Desktop.Controller
{
    public class adminDashboardController
    {
        public async Task<int> CountAllPending()
        {
            string query = @"SELECT Count(*) FROM appointments WHERE status = 'pending'";
            int pendingCount = 0;

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
                        pendingCount = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while counting pending appointments.", ex);
            }
            return pendingCount;
        }

        public async Task<int> CountAllApproved()
        {
            string query = @"SELECT Count(*) FROM appointments WHERE status = 'approved'";
            int pendingCount = 0;

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
                        pendingCount = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while counting approved appointments.", ex);
            }
            return pendingCount;
        }

        public async Task<int> CountAllCancelled()
        {
            string query = @"SELECT Count(*) FROM appointments WHERE status = 'cancelled'";
            int pendingCount = 0;

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
                        pendingCount = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while counting cancel appointments.", ex);
            }
            return pendingCount;
        }

        public async Task<int> CountAllCompleted()
        {
            string query = @"SELECT Count(*) FROM appointments WHERE status = 'completed'";
            int pendingCount = 0;

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
                        pendingCount = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while counting complete appointments.", ex);
            }
            return pendingCount;
        }

        public async Task<int> CountAllPatient()
        {
            string query = @"SELECT Count(*) FROM patients";
            int pendingCount = 0;

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
                        pendingCount = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while counting patient appointments.", ex);
            }
            return pendingCount;
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
                    WHERE a.status = 'pending'";

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

                            return dataTable; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error on selecting Inqueue: {ex.Message}");
            }
        }
    }
}
