using Application_Desktop.Models;
using MySql.Data.MySqlClient;
using System.Drawing;



namespace Application_Desktop
{
    public partial class Role : Form
    {
        //Connection to Database
        /*private string mysqlCon = "server=localhost; user=root; database=appointment; password=";*/

        public Role()
        {
            InitializeComponent();
            /*MySqlConnection conn = new MySqlConnection(mysqlCon);
            try
            {
                conn.Open();
                MessageBox.Show("Connection Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }*/
        }

        private void txtComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelectedRoles.Text = txtComboBox.Text;
        }

        private void Role_Load(object sender, EventArgs e)
        {
            txtComboBox.Items.Add("SuperAdmin");
            txtComboBox.Items.Add("Admin");
            txtComboBox.Items.Add("User");

        }

        private void btnAddRoles_Click_1(object sender, EventArgs e)
        {
            string roles = txtComboBox.Text.ToString();
            if (String.IsNullOrEmpty(roles))
            {
                MessageBox.Show("No empty field allowed");
            }
            else
            {
                string query = "INSERT INTO role (RoleName) VALUES (@Roles)";

                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    try
                    {

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Roles", roles);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show($"Successfully added {roles}.");
                        txtComboBox.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }
    }
}