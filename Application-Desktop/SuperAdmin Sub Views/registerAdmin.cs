using Application_Desktop.Models;
using Application_Desktop.Screen;
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
using static Application_Desktop.Models.EllipseManager;

namespace Application_Desktop.Sub_sub_Views
{
    public partial class registerAdmin : Form
    {
        public registerAdmin()
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

        private async void registerAdmin_Load(object sender, EventArgs e)
        {
            await LoadRoleBranch();
        }

        private async Task LoadRoleBranch()
        {
            string query = "SELECT 'role' AS Type, Role_ID AS ID, RoleName AS Name FROM role " +
               "UNION ALL " +
               "SELECT 'branch' AS Type, Branch_ID AS ID, BranchName AS Name FROM branch";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (await reader.ReadAsync())
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
                await conn.CloseAsync();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async Task SignUp()
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
                errorProvider1.SetError(borderFirst, "First Name is required.");
            }
            else
            {
                errorProvider1.SetError(borderFirst, string.Empty);
            }

            if (string.IsNullOrEmpty(last))
            {
                errorProvider2.SetError(borderLast, "Last Name is required.");
            }
            else
            {
                errorProvider2.SetError(borderLast, string.Empty);
            }

            if (string.IsNullOrEmpty(email))
            {
                errorProvider3.SetError(borderEmail, "Email is required.");
            }
            else
            {
                errorProvider3.SetError(borderEmail, string.Empty);
            }

            if (string.IsNullOrEmpty(role))
            {
                errorProvider5.SetError(borderRole, "Role is required.");
            }
            else
            {
                errorProvider5.SetError(borderRole, string.Empty);
            }

            if (string.IsNullOrEmpty(branch))
            {
                errorProvider7.SetError(borderBranch, "Branch is required.");
            }
            else
            {
                errorProvider7.SetError(borderBranch, string.Empty);
            }

            //password error provider
            if (string.IsNullOrEmpty(pwd))
            {
                errorProvider4.SetError(borderPass, string.Empty);

                errorProvider4.SetError(borderPass, "Password is required.");
            }
            else if (passwordValidator.IsPasswordValidate(pwd))
            {

                errorProvider4.SetError(borderPass, string.Empty);

                errorProvider6.SetError(borderPass, "Password is valid");
            }
            else if (passwordValidator.isPasswordNotValid(pwd))
            {

                errorProvider4.SetError(borderPass, string.Empty);

                errorProvider4.SetError(borderPass, "Password must be at least 8 characters long and contain at least" +
                    " one uppercase letter, one lowercase letter, and one number.");
            }
            else
            {
                errorProvider4.SetError(borderPass, string.Empty);
            }

            //email error provider
            if (string.IsNullOrEmpty(email))
            {
                errorProvider3.SetError(borderEmail, "Email is required.");
                errorProvider6.SetError(borderEmail, string.Empty);
            }
            else
            {
                errorProvider3.SetError(borderEmail, string.Empty);

                // Validate if email format is correct
                if (!emailValidator.IsEmailValidate(email))
                {
                    errorProvider3.SetError(borderEmail, "Email is not valid.");
                    errorProvider6.SetError(borderEmail, string.Empty);
                }
                else
                {
                    errorProvider3.SetError(borderEmail, string.Empty);
                    errorProvider6.SetError(borderEmail, "Email is valid.");

                    // Check if email already exists
                    try
                    {
                        if (await emailValidator.IsEmailAdminExist(email))
                        {
                            errorProvider3.SetError(borderEmail, "Email already exists. Please use a different email.");
                            errorProvider6.SetError(borderEmail, string.Empty);
                        }
                        else
                        {
                            errorProvider3.SetError(borderEmail, string.Empty);
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
                errorProvider1.SetError(borderFirst, "First Name is required.");
            }
            else if (string.IsNullOrEmpty(last))
            {
                errorProvider2.SetError(borderLast, "Last Name is required.");
            }
            else if (string.IsNullOrEmpty(email))
            {
                errorProvider3.SetError(borderEmail, "Email is required.");
            }
            else if (string.IsNullOrEmpty(role))
            {
                errorProvider5.SetError(borderRole, "Role is required.");
            }
            else if (string.IsNullOrEmpty(branch))
            {
                errorProvider7.SetError(borderBranch, "Branch is required.");
            }
            else if (errorProvider1.GetError(borderFirst) != string.Empty ||
            errorProvider2.GetError(borderLast) != string.Empty ||
            errorProvider3.GetError(borderEmail) != string.Empty ||
            errorProvider4.GetError(borderPass) != string.Empty ||
            errorProvider5.GetError(borderRole) != string.Empty ||
            errorProvider5.GetError(borderBranch) != string.Empty
            )
            {

            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to create this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int createdBy = session.LoggedInSession;

                    string query = "INSERT INTO admin (Name, Email, Password, Branch_ID, Role_ID, created_at, updated_at)" +
                                   "VALUES" +
                                   "(@fullname, @email, @pwd, @branchID, @roleID, @createdAt, @updatedAt)";

                    MySqlConnection conn = databaseHelper.getConnection();

                    try
                    {
                        string fullname = $"{first} {last}";

                        if (conn.State != ConnectionState.Open)
                        {
                            await conn.OpenAsync();
                        }

                        MySqlTransaction transaction = conn.BeginTransaction();
                        try
                        {
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@fullname", fullname);
                            cmd.Parameters.AddWithValue("@email", email);

                            //hash passowrd
                            cryptography hasher = new cryptography();
                            string hashPassword = hasher.HashPassword(pwd);
                            cmd.Parameters.AddWithValue("@pwd", hashPassword);


                            idValue selectedBranch = (idValue)txtBranch.SelectedItem;
                            int branchId = selectedBranch.ID;
                            cmd.Parameters.AddWithValue("@branchID", branchId);

                            idValue selectedRole = (idValue)txtRoles.SelectedItem;
                            int roleId = selectedRole.ID;
                            cmd.Parameters.AddWithValue("@roleID", roleId);

                            DateTime now = DateTime.Now;
                            cmd.Parameters.AddWithValue("@createdAt", now);
                            cmd.Parameters.AddWithValue("@updatedAt", now);
                            await cmd.ExecuteNonQueryAsync();

                            await transaction.CommitAsync();

                            //MessageBox.Show("Signed-Up Successful
                            AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The admin created successfully", Properties.Resources.success);

                            txtfirstName.Text = "";
                            txtLastName.Text = "";
                            txtEmail.Text = "";
                            txtPassword.Text = "";
                            txtRoles.Text = "";
                            txtBranch.Text = "";

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
                    finally { await conn.CloseAsync(); }
                }
            }
        }
        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            await SignUp();
        }
    }
}
