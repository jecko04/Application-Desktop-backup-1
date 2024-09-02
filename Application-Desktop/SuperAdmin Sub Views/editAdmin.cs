using Application_Desktop.Models;
using Application_Desktop.Screen;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Application_Desktop.Sub_sub_Views
{
    public partial class editAdmin : Form
    {

        private int adminID;
        public editAdmin(int adminID, string fname, string lname, string email, string pwd, string role, string branch)
        {
            InitializeComponent();
            this.adminID = adminID;

            txtfirstName.Text = fname;
            txtLastName.Text = lname;
            txtEmail.Text = email;
            txtPassword.Text = pwd;

            PopulateRoleComboBox();
            txtRoles.Text = GetRoleName(role);

            PopulateBranchComboBox();
            txtBranch.Text = GetBranchName(branch);

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


        //Getting the Role name and Branch name
        public void PopulateRoleComboBox()
        {
            string query = "SELECT Role_ID, RoleName FROM role";
            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                txtRoles.Items.Clear();
                while (reader.Read())
                {
                    int roleId = Convert.ToInt32(reader["Role_ID"]);
                    string roleName = reader["RoleName"].ToString();
                    txtRoles.Items.Add(new idValue(roleId, roleName));
                }
                for (int i = txtRoles.Items.Count - 1; i >= 0; i--)
                {
                    idValue item = (idValue)txtRoles.Items[i];
                    if (item.Name == "User")
                    {
                        txtRoles.Items.RemoveAt(i);
                    }
                }


                reader.Close();
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
        public string GetRoleName(string rolename)
        {
            string role = null;
            string query = "SELECT Role_ID, RoleName FROM role WHERE RoleName = @rolename";

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

                if (reader.Read())
                {
                    int roleId = Convert.ToInt32(reader["Role_ID"]);
                    role = reader["RoleName"].ToString();

                    txtRoles.SelectedItem = role;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return role;
        }

        public void PopulateBranchComboBox()
        {

            string query = "SELECT Branch_ID, BranchName FROM branch";
            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                txtBranch.Items.Clear();
                while (reader.Read())
                {
                    int branchId = Convert.ToInt32(reader["Branch_ID"]);
                    string branchName = reader["BranchName"].ToString();
                    txtBranch.Items.Add(new idValue(branchId, branchName));

                }

                reader.Close();
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
        public string GetBranchName(string branchname)
        {

            string branch = null;
            string query = "Select Branch_ID, BranchName from branch Where BranchName = @branchname";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("branchname", branchname);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int branchId = Convert.ToInt32(reader["Branch_ID"]);
                    branch = reader["BranchName"].ToString();

                    txtBranch.SelectedItem = branch;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return branch;
        }

        public void UpdateAdmin(int adminID, string email, string pwd, string role)
        {

            if (role == "SuperAdmin")
            {
                InsertSuperAdmin(email, pwd, adminID);
            }
            if (role == "Admin")
            {
                Update(email, adminID);
            }

        }


        private void InsertSuperAdmin(string email, string pwd, int adminID)
        {
            txtEmail.Text = email;
            txtPassword.Text = pwd;

            string fname = txtfirstName.Text;
            string lname = txtLastName.Text;
            string fullname = $"{fname} {lname}";

            // Validate if email format is correct
            if (emailValidator.IsEmailNotValidate(email))
            {
                errorProvider3.SetError(borderEmail, "Email is not valid.");
                errorProvider6.SetError(borderEmail, string.Empty);
                return;
            }
            else
            {
                errorProvider3.SetError(borderEmail, string.Empty);
                errorProvider6.SetError(borderEmail, "Email is valid.");
            }

            // Check if email already exists
            try
            {
                if (emailValidator.IsEmailSuperAdminExist(email))
                {
                    errorProvider7.SetError(borderEmail, "Email already exists. Please use a different email.");
                    errorProvider6.SetError(borderEmail, string.Empty);

                    //MessageBox.Show("Email already exists. Please use a different email.");
                    AlertBox(Color.LightSteelBlue, Color.DodgerBlue, "Information", "Email already exist. Please use different email", Properties.Resources.information);
                    return;
                }
                else
                {
                    errorProvider7.SetError(borderEmail, string.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking email existence: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate other fields
            if (errorProvider1.GetError(borderFirst) != string.Empty ||
                errorProvider2.GetError(borderLast) != string.Empty ||
                errorProvider3.GetError(borderEmail) != string.Empty ||
                errorProvider4.GetError(txtPassword) != string.Empty ||
                errorProvider5.GetError(borderRole) != string.Empty ||
                errorProvider5.GetError(borderBranch) != string.Empty)
            {
                return;
            }

            string insertQuery = "INSERT INTO superadmin (Name, Email, Password, Role_ID, created_at, updated_at) " +
                                "VALUES " +
                                "(@S_name, @S_email, @S_pwd, @S_roleID, @createdAt, @updatedAt)";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand superAdminCmd = new MySqlCommand(insertQuery, conn);
                superAdminCmd.Parameters.AddWithValue("@S_name", fullname);
                superAdminCmd.Parameters.AddWithValue("@S_email", email);
                superAdminCmd.Parameters.AddWithValue("@S_pwd", pwd);

                idValue selectedRole = (idValue)txtRoles.SelectedItem;
                int roleId = selectedRole.ID;
                superAdminCmd.Parameters.AddWithValue("@S_roleID", roleId);

                DateTime now = DateTime.Now;
                superAdminCmd.Parameters.AddWithValue("@createdAt", now);
                superAdminCmd.Parameters.AddWithValue("@updatedAt", now);
                superAdminCmd.ExecuteNonQuery();

                string deleteQuery = "DELETE FROM admin WHERE Admin_ID = @adminID";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                deleteCmd.Parameters.AddWithValue("@adminID", adminID);
                deleteCmd.ExecuteNonQuery();

                //MessageBox.Show("Successfully Updated to SuperAdmin");
                AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The account has been change to super admin", Properties.Resources.success);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inputting Data to SuperAdmin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Update(string email, int adminID)
        {
            txtEmail.Text = email;

            string fname = txtfirstName.Text;
            string lname = txtLastName.Text;
            string fullname = $"{fname} {lname}";
            string query = "UPDATE admin SET Name = @name, Email = @email, Branch_ID = @branchID, Role_ID = @roleID, updated_at = @updatedAt WHERE Admin_ID = @adminID";

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
                cmd.Parameters.AddWithValue("@adminID", adminID);

                idValue selectedBranch = (idValue)txtBranch.SelectedItem;
                int branchId = selectedBranch.ID;
                cmd.Parameters.AddWithValue("@branchID", branchId);

                DateTime now = DateTime.Now;
                cmd.Parameters.AddWithValue("@updatedAt", now);

                idValue selectedRole = (idValue)txtRoles.SelectedItem;
                int roleId = selectedRole.ID;
                cmd.Parameters.AddWithValue("@roleID", roleId);

                cmd.ExecuteNonQuery();

                //MessageBox.Show("Successfully Updated admin record.");
                AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The account has been updated successfully", Properties.Resources.success);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating Data to Admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string fname = txtfirstName.Text;
            string lname = txtLastName.Text;

            string email = txtEmail.Text;
            string pwd = txtPassword.Text;
            string role = txtRoles.Text;
            string branch = txtBranch.Text;

            try
            {
                // empty field error provider
                if (string.IsNullOrEmpty(fname))
                {
                    errorProvider1.SetError(borderFirst, "First name is required");
                }
                else
                {
                    errorProvider1.SetError(borderFirst, string.Empty);
                }

                if (string.IsNullOrEmpty(lname))
                {
                    errorProvider2.SetError(borderLast, "Last name is required");
                }
                else
                {
                    errorProvider2.SetError(borderLast, string.Empty);
                }
                if (string.IsNullOrEmpty(email))
                {
                    errorProvider3.SetError(borderEmail, "Email is required");
                }
                else
                {
                    errorProvider3.SetError(borderEmail, string.Empty);
                }
                if (string.IsNullOrEmpty(role))
                {
                    errorProvider4.SetError(borderRole, "Role is required");
                }
                else
                {
                    errorProvider4.SetError(borderRole, string.Empty);
                }
                if (string.IsNullOrEmpty(branch))
                {
                    errorProvider5.SetError(borderBranch, "Branch is required");
                }
                else
                {
                    errorProvider5.SetError(borderBranch, string.Empty);
                }



                // proceed to update
                if (errorProvider1.GetError(borderFirst) != string.Empty ||
                        errorProvider2.GetError(borderLast) != string.Empty ||
                        errorProvider3.GetError(borderEmail) != string.Empty ||
                        errorProvider4.GetError(txtPassword) != string.Empty ||
                        errorProvider5.GetError(borderRole) != string.Empty ||
                        errorProvider5.GetError(borderBranch) != string.Empty)
                {
                    return;
                }
                else
                {
                    UpdateAdmin(adminID, email, pwd, role);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking email existence: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void editAdmin_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
