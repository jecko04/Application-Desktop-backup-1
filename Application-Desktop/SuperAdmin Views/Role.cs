using Application_Desktop.Admin_Sub_Views;
using Application_Desktop.Models;
using Application_Desktop.Screen;
using Application_Desktop.SuperAdmin_Sub_Views;
using MySql.Data.MySqlClient;
using static Application_Desktop.Models.EllipseManager;
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
            ElipseManager elipseManager = new ElipseManager(5);
            elipseManager.ApplyElipseToAllButtons(this);
        }

        void AlertBox(Color backcolor, Color color, string title, string subtitle, Image icon)
        {
            alertBox alertbox = new alertBox();
            alertbox.BackColor = backcolor;
            alertbox.ColorAlertBox = color;
            alertbox.TitleAlertBox = title;
            alertbox.SubTitleAlertBox = subtitle;
            alertbox.IconAlertBox = icon;
            alertbox.Show();
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

                MySqlConnection conn = databaseHelper.getConnection();

                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Roles", roles);

                    int rowsAffected = cmd.ExecuteNonQuery();


                    AlertBox(Color.LightGreen, Color.SeaGreen, "Success", $"Successfully added {roles}.", Properties.Resources.success);
                    txtComboBox.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally { conn.Close(); }
            }
        }
        private viewRole ViewRoleInstance;
        private void btnViewRole_Click(object sender, EventArgs e)
        {
            if (ViewRoleInstance == null || ViewRoleInstance.IsDisposed)
            {
                ViewRoleInstance = new viewRole();
                ViewRoleInstance.Show();
            }
            else
            {
                if (ViewRoleInstance.Visible)
                {
                    ViewRoleInstance.BringToFront();
                }
                else { ViewRoleInstance.Show(); }
            }
        }

        private void btnViewRole_MouseEnter(object sender, EventArgs e)
        {
            btnViewRole.ForeColor = Color.FromArgb(52, 152, 219);
        }

        private void btnViewRole_MouseLeave(object sender, EventArgs e)
        {
            btnViewRole.ForeColor = Color.DimGray;
        }
    }
}
