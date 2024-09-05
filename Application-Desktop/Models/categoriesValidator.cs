using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Application_Desktop.Models
{
    public class categoriesValidator
    {

        public async static Task<bool> IsCategoryExist(string categoryName)
        {
            string category = "SELECT COUNT(*) FROM categories WHERE Title = @title";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(category, conn);
                cmd.Parameters.AddWithValue("@title", categoryName);
                int categoryCount = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                return categoryCount > 0;

            }
            catch (Exception ex)
            {
                throw new Exception("Database error: " + ex.Message);
            }
            finally { await conn.CloseAsync(); }
        }
    }
}
