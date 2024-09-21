using Application_Desktop.Models;
using Application_Desktop.Sub_Views;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Model
{
    public class userAccountModel
    {
        public async Task<DataTable> GetAllUsers()
        {
            string query = @"SELECT id, name, email, created_at, updated_at from users";

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
                            DataTable datatable = new DataTable();
                            adapter.Fill(datatable);
                            return datatable.Rows.Count == 0 ? new DataTable() : datatable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving GetAllUser data: {ex.Message}");
            }
        }

        public async Task<bool> DeleteUser(UserID userId)
        {
            string query = @"DELETE From users Where id = @userId";

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
                        cmd.Parameters.AddWithValue("@userId", userId._userId);
                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Deleting data: {ex.Message}");
            }
        }

    }

    public class UserID
    {
        [Required]
        public int _userId { get; set; }
    }
}
