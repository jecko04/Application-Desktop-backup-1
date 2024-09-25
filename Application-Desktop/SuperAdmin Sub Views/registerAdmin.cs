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

        private async Task<bool> ValidateInputs()
        {
            bool isValid = true;

            // Error provider for First Name
            if (string.IsNullOrEmpty(txtfirstName.Text))
            {
                errorProvider1.SetError(borderFirst, "First Name is required.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(borderFirst, string.Empty);
            }

            // Error provider for Last Name
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                errorProvider2.SetError(borderLast, "Last Name is required.");
                isValid = false;
            }
            else
            {
                errorProvider2.SetError(borderLast, string.Empty);
            }

            // Error provider for Email
            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(email))
            {
                errorProvider3.SetError(borderEmail, "Email is required.");
                isValid = false;
            }
            else
            {
                if (!emailValidator.IsEmailValidate(email))
                {
                    errorProvider3.SetError(borderEmail, "Email is not valid.");
                    isValid = false;
                }
                else if (await emailValidator.IsEmailAdminExist(email))
                {
                    errorProvider3.SetError(borderEmail, "Email already exists. Please use a different email.");
                    isValid = false;
                }
                else
                {
                    errorProvider3.SetError(borderEmail, string.Empty);
                }
            }

            // Error provider for Password
            string pwd = txtPassword.Text;
            if (string.IsNullOrEmpty(pwd))
            {
                errorProvider4.SetError(borderPass, "Password is required.");
                isValid = false;
            }
            else if (!passwordValidator.IsPasswordValidate(pwd))
            {
                errorProvider4.SetError(borderPass, "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.");
                isValid = false;
            }
            else
            {
                errorProvider4.SetError(borderPass, string.Empty);
            }

            // Error provider for Role
            if (string.IsNullOrEmpty(txtRoles.Text))
            {
                errorProvider5.SetError(borderRole, "Role is required.");
                isValid = false;
            }
            else
            {
                errorProvider5.SetError(borderRole, string.Empty);
            }

            // Error provider for Branch
            if (string.IsNullOrEmpty(txtBranch.Text))
            {
                errorProvider7.SetError(borderBranch, "Branch is required.");
                isValid = false;
            }
            else
            {
                errorProvider7.SetError(borderBranch, string.Empty);
            }

            return isValid;
        }
        public async Task SignUp()
        {
            // Validate inputs
            if (!await ValidateInputs())
            {
                return; // Exit if validation fails
            }

            // Proceed with database operations
            string first = txtfirstName.Text;
            string last = txtLastName.Text;
            string email = txtEmail.Text;
            string pwd = txtPassword.Text;
            string role = txtRoles.Text;
            string branch = txtBranch.Text;

            DialogResult result = MessageBox.Show("Do you want to create this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int createdBy = session.LoggedInSession;

                string query = "INSERT INTO admin (Name, Email, Password, Branch_ID, Role_ID, created_at, updated_at) " +
                               "VALUES (@fullname, @email, @pwd, @branchID, @roleID, @createdAt, @updatedAt)";

                using (MySqlConnection conn = databaseHelper.getConnection())
                {
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

                            // Hash password
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
        }
        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            await SignUp();
        }
    }
}
