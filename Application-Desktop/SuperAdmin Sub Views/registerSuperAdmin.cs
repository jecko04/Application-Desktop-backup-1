using Application_Desktop.Models;
using Application_Desktop.Screen;
using Isopoh.Cryptography.Blake2b;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text.RegularExpressions;
using static Application_Desktop.Models.EllipseManager;

namespace Application_Desktop
{
    public partial class registerSuperAdmin : Form
    {
        public registerSuperAdmin()
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
        private async void registerSuperAdmin_Load(object sender, EventArgs e)
        {
            await PopulateRoleName();
        }

        public async Task PopulateRoleName()
        {
            //Selecting roles from database


            string query = "SELECT 'role' AS Type, Role_ID AS ID, RoleName AS Name FROM role";
            MySqlConnection conn = databaseHelper.getConnection();
            try
            {

                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                {
                    while (await reader.ReadAsync())
                    {
                        string type = reader["Type"].ToString();
                        int id = Convert.ToInt32(reader["ID"]);
                        string name = reader["Name"].ToString();

                        if (type == "role")
                        {
                            if (name == "SuperAdmin")
                            {
                                idValue role = new idValue(id, name);
                                txtComboBox.Items.Add(role);
                            }
                        }

                        txtComboBox.DisplayMember = "Name";
                        txtComboBox.ValueMember = "ID";
                    }
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

        public async Task RegSuperAdmin(string fname, string lname, string email, string pwd, string rePwd, string roles)
        {
            // Input data to database
            string fullname = $"{fname} {lname}";
            string query = "INSERT INTO superadmin (Name, Email, Password, Role_ID, created_at, updated_at) " +
                "VALUES (@fullname, @email, @pwd, @roleID, @createdAt, @updatedAt)";

            using MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                await conn.OpenAsync();
                MySqlTransaction transaction = await conn.BeginTransactionAsync();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fullname", fullname);
                    cmd.Parameters.AddWithValue("@email", email);

                    // Encryption
                    cryptography hasher = new cryptography();
                    string hashPassword = hasher.HashPassword(pwd);
                    cmd.Parameters.AddWithValue("@pwd", hashPassword);

                    // Get the selected role_ID from the comboBox
                    idValue selectedRole = (idValue)txtComboBox.SelectedItem;
                    int roleId = selectedRole.ID;
                    cmd.Parameters.AddWithValue("@roleID", roleId);

                    DateTime now = DateTime.Now;
                    cmd.Parameters.AddWithValue("@createdAt", now);
                    cmd.Parameters.AddWithValue("@updatedAt", now);

                    int rowsAffected = await cmd.ExecuteNonQueryAsync();
                    await transaction.CommitAsync();

                    AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "Super admin created successfully", Properties.Resources.success);

                    // Clear the input fields
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtEmail.Text = "";
                    txtPwd.Text = "";
                    txtRePwd.Text = "";
                    txtComboBox.Text = "";

                    // Clear error providers
                    errorProvider9.SetError(borderRePass, string.Empty);
                    errorProvider10.SetError(borderEmail, string.Empty);
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



        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string email = txtEmail.Text;
            string pwd = txtPwd.Text;
            string rePwd = txtRePwd.Text;
            string roles = txtComboBox.Text;

            // Error Provider for textbox/combo box
            if (string.IsNullOrEmpty(fname))
            {
                errorProvider1.SetError(borderFirst, "First Name is required.");
                return; // Exit if there's an error
            }
            else
            {
                errorProvider1.SetError(borderFirst, string.Empty);
            }

            if (string.IsNullOrEmpty(lname))
            {
                errorProvider2.SetError(borderLast, "Last Name is required.");
                return; // Exit if there's an error
            }
            else
            {
                errorProvider2.SetError(borderLast, string.Empty);
            }

            if (string.IsNullOrEmpty(email))
            {
                errorProvider3.SetError(borderEmail, "Email is required.");
                return; // Exit if there's an error
            }
            else
            {
                errorProvider3.SetError(borderEmail, string.Empty);
            }

            if (string.IsNullOrEmpty(roles))
            {
                errorProvider5.SetError(borderRole, "Roles is required.");
                return; // Exit if there's an error
            }
            else
            {
                errorProvider5.SetError(borderRole, string.Empty);
            }

            // Password error Provider
            if (string.IsNullOrEmpty(pwd) || string.IsNullOrEmpty(rePwd))
            {
                errorProvider4.SetError(borderPass, "Password is required.");
                errorProvider4.SetError(borderRePass, "Confirm Password is required.");
                return; // Exit if there's an error
            }
            else
            {
                errorProvider4.SetError(borderPass, string.Empty);
                errorProvider4.SetError(borderRePass, string.Empty);
            }

            if (pwd != rePwd)
            {
                errorProvider6.SetError(borderPass, "Passwords do not match.");
                errorProvider6.SetError(borderRePass, "Passwords do not match.");
                return; // Exit if there's an error
            }
            else
            {
                errorProvider6.SetError(borderPass, string.Empty);
                errorProvider6.SetError(borderRePass, string.Empty);
            }

            if (passwordValidator.isPasswordNotValid(pwd) || passwordValidator.isPasswordNotValid(rePwd))
            {
                errorProvider8.SetError(borderPass, "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.");
                errorProvider8.SetError(borderRePass, "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.");
                return; // Exit if there's an error
            }
            else
            {
                errorProvider8.SetError(borderPass, string.Empty);
                errorProvider8.SetError(borderRePass, string.Empty);
            }

            // Email validation
            if (!emailValidator.IsEmailValidate(email))
            {
                errorProvider11.SetError(borderEmail, "Email is not valid.");
                return; // Exit if there's an error
            }
            else
            {
                errorProvider11.SetError(borderEmail, string.Empty);
            }

            // Check if email exists in superadmin tables
            try
            {
                if (await emailValidator.IsEmailSuperAdminExist(email))
                {
                    errorProvider10.SetError(borderEmail, "Email is already registered as a superadmin.");
                    return; // Exit if there's an error
                }
                else
                {
                    errorProvider10.SetError(borderEmail, string.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking email existence: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if there's an error
            }

            // Call the method to register the superadmin
            await RegSuperAdmin(fname, lname, email, pwd, rePwd, roles);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


