using Application_Desktop.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
            string query = @"SELECT Branch_ID FROM admin WHERE Admin_ID = @admin";

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
                            if (await reader.ReadAsync()) // Read the data
                            {
                                return new BranchID
                                {
                                    _id = int.Parse(reader["Branch_ID"].ToString())
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception as needed
                Console.WriteLine(ex.Message);
            }

            return null; // Return null if no data found or on error
        }
    }

        public class BranchID
    {
        public int _id { get; set; }
    }

}
