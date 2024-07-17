using Application_Desktop.Models;
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

namespace Application_Desktop.Sub_sub_Views
{
    public partial class editSuperAdmin : Form
    {
        private int superAdminID;
        //418, 437
        public editSuperAdmin(int superAdminID, string fname, string lname, string email, string pwd, string role)
        {
            InitializeComponent();
            this.superAdminID = superAdminID;
            txtFirstName.Text = fname;
            txtLastName.Text = lname;
            txtEmail.Text = email;
            txtPassword.Text = pwd;

            PopulateRoleName();
            txtRoles.Text = GetRoleNames(role);
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

        private void UpdateSuperAdmin(int superAdminID, string fname, string lname, string email, string pwd)
        {
            errorProvider1.SetError(txtEmail, string.Empty);
            errorProvider2.SetError(txtEmail, "Email is valid");

            string fullname = $"{fname} {lname}";
            string query = "UPDATE superadmin SET " +
                           "Name = @name, " +
                           "Email = @email, " +
                           "Pwd = @pwd, " +
                           "Role_ID = @roleID " +
                           "WHERE SuperAdmin_ID = @superAdminID";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", fullname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pwd", pwd);

                idValue selectedRole = (idValue)txtRoles.SelectedItem;
                int role = selectedRole.ID;
                cmd.Parameters.AddWithValue("@roleID", role);
                cmd.Parameters.AddWithValue("@superAdminID", superAdminID);
                int rowsAffected = cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Updated");

                errorProvider1.SetError(txtEmail, string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string email = txtEmail.Text;
            string pwd = txtPassword.Text;
            string role = txtRoles.Text;


            DialogResult result = MessageBox.Show("Would you like to proceed with Updating this account?", "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (emailValidator.IsEmailValidate(email))
            {
                if (result == DialogResult.Yes)
                {
                    UpdateSuperAdmin(superAdminID, fname, lname, email, pwd);
                    this.Close();
                }
            }
            else if (emailValidator.IsEmailNotValidate(email))
            {
                errorProvider2.SetError(txtEmail, string.Empty);
                errorProvider1.SetError(txtEmail, "Email is not valid");
            }


        }
    }
}
