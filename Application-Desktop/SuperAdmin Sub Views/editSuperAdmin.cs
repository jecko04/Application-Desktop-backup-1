using Application_Desktop.Models;
using Application_Desktop.Screen;
using Application_Desktop.Sub_Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Application_Desktop.Models.EllipseManager;

namespace Application_Desktop.Sub_sub_Views
{
    public partial class editSuperAdmin : Form
    {
        private int superAdminID;
        //418, 437
        public editSuperAdmin(int superAdminID, string fname, string lname, string email, string role)
        {
            InitializeComponent();
            this.superAdminID = superAdminID;
            txtFirstName.Text = fname;
            txtLastName.Text = lname;
            txtEmail.Text = email;

            PopulateRoleName();
            txtRoles.Text = GetRoleNames(role);

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

        private void editSuperAdmin_Load(object sender, EventArgs e)
        {

        }

        private void PopulateRoleName()
        {
            string query = "Select Role_ID, RoleName from role";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int roleId = Convert.ToInt32(reader["Role_ID"]);
                    string roleName = reader["RoleName"].ToString();

                    txtRoles.Items.Add(new idValue(roleId, roleName));
                }
                for (int i = txtRoles.Items.Count - 1; i >= 0; i--)
                {
                    idValue item = (idValue)txtRoles.Items[i];
                    if (item.Name == "Admin" || item.Name == "User")
                    {
                        txtRoles.Items.RemoveAt(i);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private string GetRoleNames(string rolename)
        {
            string role = null;
            string query = "Select Role_ID, RoleName from role where RoleName = @rolename";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rolename", rolename);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int roleId = Convert.ToInt32(reader["Role_ID"]);
                    role = reader["RoleName"].ToString();

                    txtRoles.SelectedItem = role;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return role;
        }

        private async Task UpdateSuperAdmin(int superAdminID, string fname, string lname, string email)
        {
            errorProvider1.SetError(borderEmail, string.Empty);
            errorProvider2.SetError(borderEmail, "Email is valid");

            DialogResult result = MessageBox.Show("Would you like to proceed with Updating this account?", "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {


                string fullname = $"{fname} {lname}";
                string query = @"Update superadmin SET Name = @name, Email = @email, Role_ID = @roleID, updated_at = @updatedAt Where SuperAdmin_ID = @superAdminID";


                MySqlConnection conn = databaseHelper.getConnection();
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }

                    MySqlTransaction transaction = conn.BeginTransaction();
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@name", fullname);
                        cmd.Parameters.AddWithValue("@email", email);

                        idValue selectedRole = (idValue)txtRoles.SelectedItem;
                        int role = selectedRole.ID;
                        cmd.Parameters.AddWithValue("@roleID", role);
                        DateTime now = DateTime.Now;
                        cmd.Parameters.AddWithValue("@updatedAt", now);

                        cmd.Parameters.AddWithValue("@superAdminID", superAdminID);
                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        //MessageBox.Show("Successfully Updated");
                        AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The account has been updated successfully", Properties.Resources.success);

                        errorProvider1.SetError(borderEmail, string.Empty);

                        await transaction.CommitAsync();
                    }
                    catch (Exception transEx)
                    {
                        // Rollback the transaction in case of an error
                        await transaction.RollbackAsync();
                        MessageBox.Show("Transaction failed: " + transEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string email = txtEmail.Text;
            string role = txtRoles.Text;

            if (string.IsNullOrEmpty(fname))
            {
                errorProvider3.SetError(borderFirst, "Firstname is required");
            }
            else
            {
                errorProvider3.SetError(borderFirst, string.Empty);
            }

            if (string.IsNullOrEmpty(lname))
            {
                errorProvider4.SetError(borderLast, "Lastname is required");
            }
            else
            {
                errorProvider4.SetError(borderLast, string.Empty);
            }

            if (string.IsNullOrEmpty(role))
            {
                errorProvider5.SetError(borderRole, "Role is required");
            }
            else
            {
                errorProvider5.SetError(borderRole, string.Empty);
            }

            // email validate
            if (!emailValidator.IsEmailValidate(email))
            {
                errorProvider1.SetError(borderEmail, "Email is not valid");
            }
            else
            {
                errorProvider1.SetError(borderEmail, string.Empty);
            }

            if (errorProvider1.GetError(borderEmail) == string.Empty &&
            errorProvider3.GetError(borderFirst) == string.Empty &&
            errorProvider4.GetError(borderLast) == string.Empty &&
            errorProvider5.GetError(borderRole) == string.Empty)
            {
                await UpdateSuperAdmin(superAdminID, fname, lname, email);
                this.Close();
            }

        }
    }
}
