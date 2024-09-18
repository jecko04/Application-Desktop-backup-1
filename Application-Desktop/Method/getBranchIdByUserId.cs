using Application_Desktop.Models;
using Application_Desktop.Sub_Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Method
{
    public class getBranchIdByUserId
    {
        
        public async Task<BranchID> GetUserBranchId()
        {
            int admin = session.LoggedInSession;
            string query = @"SELECT Branch_ID From admin Where Admin_ID = @admin";

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
                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                BranchID branch = new BranchID()
                                {
                                    _id = reader.GetInt32("Branch_ID")
                                };
                                return branch;
                            }await reader.CloseAsync();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving admin id data: {ex.Message}");
            }
            return null;
        }
    }

    public class BranchID
    {
        [Required]
        public int _id { get; set; }
    }
}
