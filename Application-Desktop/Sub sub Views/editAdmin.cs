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
        public string GetRoleName(string roleID)
        {
            string role = null;
            string query = "SELECT Role_ID, RoleName FROM role WHERE Role_ID = @roleID";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@roleID", roleID);
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
        public string GetBranchName(string branchID)
        {

            string branch = null;
            string query = "Select Branch_ID, BranchName from branch Where Branch_ID = @branchID";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("branchID", branchID);
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

        public void UpdateAdmin(int adminID, string fname, string lname, string email, string pwd, string role, string branch)
        {
            string fullname = $"{fname} {lname}";

            string query = "UPDATE admin SET " +
                           "Name = @name, " +
                           "Email = @Email, " +
                           "Branch_ID = @branchID, " +
                           "Role_ID = @roleID " +
                           "WHERE Admin_ID = @adminID";
            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", fullname);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@adminID", adminID);

                if (role == "SuperAdmin")
                {
                    string query2 = "INSERT INTO superadmin (Name, Email, Pwd, Role_ID) " +
                                    "VALUES (@S_name, @S_email, @S_pwd, @S_roleID)";
                    MySqlCommand superAdminCmd = new MySqlCommand(query2, conn);

                    superAdminCmd.Parameters.AddWithValue("@S_name", fullname);
                    superAdminCmd.Parameters.AddWithValue("@S_email", email);
                    superAdminCmd.Parameters.AddWithValue("@S_pwd", pwd);

                    idValue selectedRole = (idValue)txtRoles.SelectedItem;
                    int roleId = selectedRole.ID;
                    superAdminCmd.Parameters.AddWithValue("@S_roleID", roleId);
                    superAdminCmd.ExecuteNonQuery();

                    string delete1 = "DELETE FROM admin WHERE Admin_ID = @adminID";
                    MySqlCommand deleteCmd = new MySqlCommand(delete1, conn);
                    deleteCmd.Parameters.AddWithValue("@adminID", adminID);
                    deleteCmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Updated");

                }
                else if (role == "User")
                {
                    int createdBy = session.LoggedInSession;
                    string query3 = "INSERT INTO users (Name, Email, Pwd, CreatedBy, Branch_ID, Role_ID) " +
                                    "VALUES (@U_name, @U_email, @U_pwd, @U_createdBy, @U_branchID, @U_roleID)";
                    MySqlCommand userCmd = new MySqlCommand(query3, conn);

                    userCmd.Parameters.AddWithValue("@U_name", fullname);
                    userCmd.Parameters.AddWithValue("@U_email", email);
                    userCmd.Parameters.AddWithValue("@U_pwd", pwd);

                    cmd.Parameters.AddWithValue("@U_createdBy", createdBy);

                    idValue selectedBranch = (idValue)txtBranch.SelectedItem;
                    int branchId = selectedBranch.ID;
                    userCmd.Parameters.AddWithValue("@U_branchID", branchId);

                    idValue selectedRole = (idValue)txtRoles.SelectedItem;
                    int roleId = selectedRole.ID;
                    userCmd.Parameters.AddWithValue("@U_roleID", roleId);
                    userCmd.ExecuteNonQuery();

                    string delete2 = "DELETE FROM admin WHERE Admin_ID = @adminID";
                    MySqlCommand deleteCmd = new MySqlCommand(delete2, conn);
                    deleteCmd.Parameters.AddWithValue("@adminID", adminID);
                    deleteCmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
                }
                else
                {
                    idValue selectedBranch = (idValue)txtBranch.SelectedItem;
                    int branchId = selectedBranch.ID;
                    cmd.Parameters.AddWithValue("@branchID", branchId);

                    idValue selectedRole = (idValue)txtRoles.SelectedItem;
                    int roleId = selectedRole.ID;
                    cmd.Parameters.AddWithValue("@roleID", roleId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
                }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string fname = txtfirstName.Text;
            string lname = txtLastName.Text;
            string email = txtEmail.Text;
            string pwd = txtPassword.Text;
            string role = txtRoles.Text;
            string branch = txtBranch.Text;

            UpdateAdmin(adminID, fname, lname, email, pwd, role, branch);

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
