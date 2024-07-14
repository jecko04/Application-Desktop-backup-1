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
                _connection.Open();
                //MessageBox.Show("Connection opened successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static MySqlConnection getConnection()
        {
            return _connection;
        }

        public static void closeConnection()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
                _connection.Dispose();
            }
        }


    }
}
