using Application_Desktop.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Model
{
    public class viewAvailableDentalServicesModel
    {
        public async Task <DataTable> GetAllDentalServices(int admin)
        {
            string query = @"SELECT dental_services.dentalservices_id, dental_services.dentalservices, dental_services.description, dental_services.duration, dental_services.frequency, dental_services.price, dental_services.dayofweek, dental_services.starttime, dental_services.endtime, dental_services.Branch_ID, dental_services.address, dental_services.isavailable, dental_services.max_appointment, branch.BranchName AS BranchName
                            FROM dental_services
                            JOIN branch ON dental_services.Branch_ID = branch.Branch_ID
                            WHERE dental_services.Branch_ID = @admin";

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
                        cmd.Parameters.AddWithValue("@admin", admin);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable datatable = new DataTable();
                            adapter.Fill(datatable);
                            return datatable.Rows.Count == 0 ? new DataTable() : datatable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving GetAllDentalServices data: {ex.Message}");
            }
        }

        public async Task DeleteDentalServices(int admin, Delete delete)
        {
            string query = @"DELETE From dental_services Where Branch_ID = @admin AND dentalservices_id = @dentalservicesId";

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
                        cmd.Parameters.AddWithValue("@dentalservicesId", delete._id);
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Deleting data: {ex.Message}");
            }
        }
    }

    public class Delete
    {
        [Required]
        public int _id { get; set; }
    }

    public class Select
    {
        [Required]
        public string _days { get; set; }
        [Required]
        public string _service { get; set; }
        [Required]
        public bool _isAvailable { get; set; }
    }
}
