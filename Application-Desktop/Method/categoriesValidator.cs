using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Application_Desktop.Models
{
    public class categoriesValidator
    {


        public static async Task<int> GetBranchID()
        {
            int admin = session.LoggedInSession;
            int branchID = -1;

            string getBranchID = "SELECT Branch_ID FROM admin WHERE Admin_ID = @adminID";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand getBranchIDCmd = new MySqlCommand(getBranchID, conn);
                getBranchIDCmd.Parameters.AddWithValue("@adminID", admin);

                MySqlDataReader branchIDReader = getBranchIDCmd.ExecuteReader();
                if (await branchIDReader.ReadAsync())
                {
                    branchID = Convert.ToInt32(branchIDReader["Branch_ID"]);
                }
                await branchIDReader.CloseAsync();

                // Check if adminBranchID was correctly retrieved
                if (branchID == -1)
                {
                    MessageBox.Show("Failed to retrieve the admin's branch ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                await conn.CloseAsync();
            }

            return branchID; // Return branchID
        }

        public async static Task<bool> IsCategoryExist(string categoryName)
        {
            int branch = await GetBranchID();
            string category = "SELECT COUNT(*) FROM categories WHERE Title = @title AND Branch_ID = @branchID";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(category, conn);
                cmd.Parameters.AddWithValue("@title", categoryName);
                cmd.Parameters.AddWithValue("@branchID", branch);
                
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
