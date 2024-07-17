using Application_Desktop.Models;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class registerAdmin : Form
    {
        public registerAdmin()
        {
            InitializeComponent();

        }

        private void registerAdmin_Load(object sender, EventArgs e)
        {
            string query = "SELECT 'role' AS Type, Role_ID AS ID, RoleName AS Name FROM role " +
                "UNION ALL " +
                "SELECT 'branch' AS Type, Branch_ID AS ID, BranchName AS Name FROM branch";

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
                    string type = reader["Type"].ToString();
                    int id = Convert.ToInt32(reader["ID"]);
                    string name = reader["Name"].ToString();

                    if (type == "role")
                    {
                        if (name == "Admin")
                        {
                            idValue role = new idValue(id, name);
                            txtRoles.Items.Add(role);
                        }
                    }
                    else if (type == "branch")
                    {
                        idValue branch = new idValue(id, name);
                        txtBranch.Items.Add(branch);
                    }

                    txtRoles.DisplayMember = "Name";
                    txtRoles.ValueMember = "ID";

                    txtBranch.DisplayMember = "Name";
                    txtBranch.ValueMember = "ID";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SignUp()
        {
            string first = txtfirstName.Text;
            string last = txtLastName.Text;
            string email = txtEmail.Text;
            string pwd = txtPassword.Text;
            string role = txtRoles.Text;
            string branch = txtBranch.Text;

            //error provider
            if (string.IsNullOrEmpty(first))
            {
                errorProvider1.SetError(txtfirstName, "First Name is required.");
            }
            else
            {
                errorProvider1.SetError(txtfirstName, string.Empty);
            }

            if (string.IsNullOrEmpty(last))
            {
                errorProvider2.SetError(txtLastName, "Last Name is required.");
            }
            else
            {
                errorProvider2.SetError(txtLastName, string.Empty);
            }

            if (string.IsNullOrEmpty(email))
            {
                errorProvider3.SetError(txtEmail, "Email is required.");
            }
            else
            {
                errorProvider3.SetError(txtEmail, string.Empty);
            }

            if (string.IsNullOrEmpty(role))
            {
                errorProvider5.SetError(txtRoles, "Role is required.");
            }
            else
            {
                errorProvider5.SetError(txtRoles, string.Empty);
            }

            if (string.IsNullOrEmpty(branch))
            {
                errorProvider7.SetError(txtBranch, "Branch is required.");
            }
            else
            {
                errorProvider7.SetError(txtBranch, string.Empty);
            }

            //password error provider
            if (string.IsNullOrEmpty(pwd))
            {
                errorProvider4.SetError(txtPassword, string.Empty);

                errorProvider4.SetError(txtPassword, "Password is required.");
            }
            else if (passwordValidator.IsPasswordValidate(pwd))
            {

                errorProvider4.SetError(txtPassword, string.Empty);

                errorProvider6.SetError(txtPassword, "Password is valid");
            }
            else if (passwordValidator.isPasswordNotValid(pwd))
            {

                errorProvider4.SetError(txtPassword, string.Empty);

                errorProvider4.SetError(txtPassword, "Password must be at least 8 characters long and contain at least" +
                    " one uppercase letter, one lowercase letter, and one number.");
            }
            else
            {
                errorProvider4.SetError(txtPassword, string.Empty);
            }

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

            if (string.IsNullOrEmpty(first))
            {
                errorProvider1.SetError(txtfirstName, "First Name is required.");
            }
            else if (string.IsNullOrEmpty(last))
            {
                errorProvider2.SetError(txtLastName, "Last Name is required.");
            }
            else if (string.IsNullOrEmpty(email))
            {
                errorProvider3.SetError(txtEmail, "Email is required.");
            }
            else if (string.IsNullOrEmpty(role))
            {
                errorProvider5.SetError(txtRoles, "Role is required.");
            }
            else if (string.IsNullOrEmpty(branch))
            {
                errorProvider7.SetError(txtBranch, "Branch is required.");
            }
            else if (errorProvider1.GetError(txtfirstName) != string.Empty ||
            errorProvider2.GetError(txtLastName) != string.Empty ||
            errorProvider3.GetError(txtEmail) != string.Empty ||
            errorProvider4.GetError(txtPassword) != string.Empty ||
            errorProvider5.GetError(txtRoles) != string.Empty ||
            errorProvider5.GetError(txtBranch) != string.Empty
            )
            {

            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to create this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int createdBy = session.LoggedInSession;

                    string query = "INSERT INTO admin (Name, Email, Password, CreatedBy, Branch_ID, Role_ID)" +
                                   "VALUES" +
                                   "(@fullname, @email, @pwd, @createdBy, @branchID, @roleID)";

                    MySqlConnection conn = databaseHelper.getConnection();

                    try
                    {
                        string fullname = $"{first} {last}";

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@fullname", fullname);
                        cmd.Parameters.AddWithValue("@email", email);

                        //hash passowrd
                        cryptography hasher = new cryptography();
                        string hashPassword = hasher.HashPassword(pwd);
                        cmd.Parameters.AddWithValue("@pwd", hashPassword);

                        cmd.Parameters.AddWithValue("@createdBy", createdBy);

                        idValue selectedBranch = (idValue)txtBranch.SelectedItem;
                        int branchId = selectedBranch.ID;
                        cmd.Parameters.AddWithValue("@branchID", branchId);

                        idValue selectedRole = (idValue)txtRoles.SelectedItem;
                        int roleId = selectedRole.ID;
                        cmd.Parameters.AddWithValue("@roleID", roleId);
                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Signed-Up Successful");
                        txtfirstName.Text = "";
                        txtLastName.Text = "";
                        txtEmail.Text = "";
                        txtPassword.Text = "";
                        txtRoles.Text = "";
                        txtBranch.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { conn.Close(); }
                }
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp();
        }
    }
}
