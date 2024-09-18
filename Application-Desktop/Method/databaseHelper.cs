using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Models
{
    public static class databaseHelper
    {
        private static MySqlConnection _connection;
        private static string mysqlCon = "server=localhost; user=root; database=appointment; password=";

        public static void initializeConnection()
        {
            _connection = new MySqlConnection(mysqlCon);

            try
            {
                 _connection.OpenAsync();
                //MessageBox.Show("Connection opened successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static MySqlConnection getConnection()
        {
            return new MySqlConnection(mysqlCon); // Always return a fresh connection
        }

        // Opening and closing the connection should be done in the calling method
        public static async Task OpenConnectionAsync(MySqlConnection connection)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    await connection.OpenAsync();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception as needed
                throw new Exception("Error opening connection: " + ex.Message);
            }
        }

        public static async Task CloseConnectionAsync(MySqlConnection connection)
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    await connection.CloseAsync();
                    connection.Dispose();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception as needed
                throw new Exception("Error closing connection: " + ex.Message);
            }
        }
    }
}
