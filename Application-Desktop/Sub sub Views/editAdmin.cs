using Application_Desktop.Models;
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

        private int superadminID;
        public void UpdateAdmin(int adminID, string fname, string lname, string email, string pwd, string role, string branch)
        {
            string fullname = $"{fname} {lname}";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                

                if (role == "SuperAdmin")
                {
                    //email error provider
                    if (string.IsNullOrEmpty(email))
                    {
                        errorProvider3.SetError(txtEmail, "Email is required.");
                        errorProvider6.SetError(txtEmail, string.Empty);
                    }
                    else
                    {
                        errorProvider3.SetError(txtEmail, string.Empty);

                        // Validate if email format is correct
                        if (!emailValidator.IsEmailValidate(email))
                        {
                            errorProvider3.SetError(txtEmail, "Email is not valid.");
                            errorProvider6.SetError(txtEmail, string.Empty);
                        }
                        else
                        {
                            errorProvider3.SetError(txtEmail, string.Empty);
                            errorProvider6.SetError(txtEmail, "Email is valid.");

                            // Check if email already exists
                            try
                            {
                                if (emailValidator.IsEmailAdminExist(email))
                                {
                                    errorProvider3.SetError(txtEmail, "Email already exists. Please use a different email.");
                                    errorProvider6.SetError(txtEmail, string.Empty);
                                }
                                else
                                {
                                    errorProvider3.SetError(txtEmail, string.Empty);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error checking email existence: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    string insertQuery = "INSERT INTO superadmin (Name, Email, Password, Role_ID) " +
                            "VALUES " +
                            "(@S_name, @S_email, @S_pwd, @S_roleID)";
                        MySqlCommand superAdminCmd = new MySqlCommand(insertQuery, conn);
                        superAdminCmd.Parameters.AddWithValue("@S_name", fullname);
                        superAdminCmd.Parameters.AddWithValue("@S_email", email);
                        superAdminCmd.Parameters.AddWithValue("@S_pwd", pwd);

                        idValue selectedRole = (idValue)txtRoles.SelectedItem;
                        int roleId = selectedRole.ID;
                        superAdminCmd.Parameters.AddWithValue("@S_roleID", roleId);
                        superAdminCmd.ExecuteNonQuery();

                        string deleteQuery = "DELETE FROM admin WHERE Admin_ID = @adminID";
                        MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                        deleteCmd.Parameters.AddWithValue("@adminID", adminID);
                        deleteCmd.ExecuteNonQuery();

                        MessageBox.Show("Successfully Updated to SuperAdmin");
                }
                else if (role == "Admin")
                {
                    
                    string query = "UPDATE admin SET Name = @name, Email = @email, Branch_ID = @branchID, Role_ID = @roleID WHERE Admin_ID = @adminID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", fullname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@adminID", adminID);

                    idValue selectedBranch = (idValue)txtBranch.SelectedItem;
                    int branchId = selectedBranch.ID;
                    cmd.Parameters.AddWithValue("@branchID", branchId);

                    idValue selectedRole = (idValue)txtRoles.SelectedItem;
                    int roleId = selectedRole.ID;
                    cmd.Parameters.AddWithValue("@roleID", roleId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Updated admin record.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }




        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string fname = txtfirstName.Text;
            string lname = txtLastName.Text;
            string fullname = $"{fname} {lname}";

            string email = txtEmail.Text;
            string pwd = txtPassword.Text;
            string role = txtRoles.Text;
            string branch = txtBranch.Text;

            try
            {
                // empty field error provider
                if (string.IsNullOrEmpty(fname))
                {
                    errorProvider1.SetError(txtfirstName, "First name is required");
                }
                else
                {
                    errorProvider1.SetError(txtfirstName, string.Empty);
                }

                if (string.IsNullOrEmpty(lname))
                {
                    errorProvider2.SetError(txtLastName, "Last name is required");
                }
                else
                {
                    errorProvider2.SetError(txtLastName, string.Empty);
                }
                if (string.IsNullOrEmpty(email))
                {
                    errorProvider3.SetError(txtEmail, "Email is required");
                }
                else
                {
                    errorProvider3.SetError(txtEmail, string.Empty);
                }
                if (string.IsNullOrEmpty(role))
                {
                    errorProvider4.SetError(txtRoles, "Role is required");
                }
                else
                {
                    errorProvider4.SetError(txtRoles, string.Empty);
                }
                if (string.IsNullOrEmpty(branch))
                {
                    errorProvider5.SetError(txtBranch, "Branch is required");
                }
                else
                {
                    errorProvider5.SetError(txtBranch, string.Empty);
                }

                // proceed to update
                if (string.IsNullOrEmpty(fname))
                {
                    errorProvider1.SetError(txtfirstName, "First Name is required.");
                }
                else if (string.IsNullOrEmpty(lname))
                {
                    errorProvider2.SetError(txtLastName, "Last Name is required.");
                }
                else if (string.IsNullOrEmpty(email))
                {
                    errorProvider3.SetError(txtEmail, "Email is required.");
                }
                else if (string.IsNullOrEmpty(role))
                {
                    errorProvider4.SetError(txtRoles, "Role is required.");
                }
                else if (string.IsNullOrEmpty(branch))
                {
                    errorProvider5.SetError(txtBranch, "Branch is required.");
                }
                else if (errorProvider1.GetError(txtfirstName) != string.Empty ||
                        errorProvider2.GetError(txtLastName) != string.Empty ||
                        errorProvider3.GetError(txtEmail) != string.Empty ||
                        errorProvider4.GetError(txtPassword) != string.Empty ||
                        errorProvider5.GetError(txtRoles) != string.Empty ||
                        errorProvider5.GetError(txtBranch) != string.Empty)
                {
                    return;
                }
                else
                {
                    //MessageBox.Show($"Collected Data:\nFullname: {fullname}\nEmail: {email}\nPassword: {pwd}\n\nRole: {role}\nBranch: {branch}", "Changes");
                    DialogResult result = MessageBox.Show("Do you want to proceed to update this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    { 
                    UpdateAdmin(adminID, fname, lname, email, pwd, role, branch);
                    }
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
