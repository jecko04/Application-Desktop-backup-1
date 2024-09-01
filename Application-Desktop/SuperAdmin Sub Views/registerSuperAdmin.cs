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
            PopulateRoleName();
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
        private void registerSuperAdmin_Load(object sender, EventArgs e)
        {

        }

        public void PopulateRoleName()
        {
            //Selecting roles from database


            string query = "SELECT 'role' AS Type, Role_ID AS ID, RoleName AS Name FROM role";
            MySqlConnection conn = databaseHelper.getConnection();
            try
            {

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                {
                    while (reader.Read())
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
                conn.Close();
            }
        }

        private void txtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Check box checker
            if (txtCheckBox.Checked)
            {
                errorProvider7.SetError(txtLink, string.Empty);
            }
        }

        public void RegSuperAdmin()
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string email = txtEmail.Text;
            string pwd = txtPwd.Text;
            string rePwd = txtRePwd.Text;
            string roles = txtComboBox.Text;

            bool checkBox = txtCheckBox.Checked;



            //Error Provider for textbox/combo box
            if (string.IsNullOrEmpty(fname))
            {
                errorProvider1.SetError(borderFirst, "First Name is required.");
            }
            else
            {
                errorProvider1.SetError(borderFirst, string.Empty);
            }

            if (string.IsNullOrEmpty(lname))
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

            if (string.IsNullOrEmpty(roles))
            {
                errorProvider5.SetError(borderRole, "Roles is required.");
            }
            else
            {
                errorProvider5.SetError(borderRole, string.Empty);
            }


            //Password error Provider
            if (string.IsNullOrEmpty(pwd) || string.IsNullOrEmpty(rePwd))
            {
                errorProvider6.SetError(borderRePass, string.Empty);
                errorProvider6.SetError(borderPass, string.Empty);

                errorProvider8.SetError(borderRePass, string.Empty);
                errorProvider8.SetError(borderPass, string.Empty);

                errorProvider9.SetError(borderRePass, string.Empty);
                errorProvider9.SetError(borderPass, string.Empty);

                errorProvider4.SetError(borderPass, "Password is required.");
                errorProvider4.SetError(borderRePass, "Confirm Password is required.");
            }
            else if (pwd != rePwd)
            {
                errorProvider4.SetError(borderPass, string.Empty);
                errorProvider4.SetError(borderRePass, string.Empty);

                errorProvider8.SetError(borderRePass, string.Empty);
                errorProvider8.SetError(borderPass, string.Empty);

                errorProvider9.SetError(borderRePass, string.Empty);
                errorProvider9.SetError(borderPass, string.Empty);

                errorProvider6.SetError(borderPass, "Password are not match.");
                errorProvider6.SetError(borderRePass, "Password are not match.");
            }
            else if (passwordValidator.IsPasswordValidate(pwd) || passwordValidator.IsPasswordValidate(rePwd))
            {
                errorProvider4.SetError(borderPass, string.Empty);
                errorProvider4.SetError(borderRePass, string.Empty);

                errorProvider6.SetError(borderRePass, string.Empty);
                errorProvider6.SetError(borderPass, string.Empty);

                errorProvider8.SetError(borderRePass, string.Empty);
                errorProvider8.SetError(borderPass, string.Empty);

                errorProvider9.SetError(borderPass, "Password is valid");
                errorProvider9.SetError(borderRePass, "Password is valid");
            }
            else if (passwordValidator.isPasswordNotValid(pwd) || passwordValidator.isPasswordNotValid(rePwd))
            {
                errorProvider4.SetError(borderPass, string.Empty);
                errorProvider4.SetError(borderRePass, string.Empty);

                errorProvider6.SetError(borderRePass, string.Empty);
                errorProvider6.SetError(borderPass, string.Empty);

                errorProvider9.SetError(borderRePass, string.Empty);
                errorProvider9.SetError(borderPass, string.Empty);

                errorProvider8.SetError(borderPass, "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.");
                errorProvider8.SetError(borderRePass, "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.");

            }

            //Email error Provider
            if (string.IsNullOrEmpty(email))
            {
                errorProvider3.SetError(borderEmail, "Email is required.");
                errorProvider10.SetError(borderEmail, string.Empty);
                errorProvider11.SetError(borderEmail, string.Empty);
            }
            else
            {
                errorProvider3.SetError(borderEmail, string.Empty);

                // Validate if email format is correct
                if (emailValidator.IsEmailValidate(email))
                {
                    errorProvider3.SetError(borderEmail, string.Empty);
                    errorProvider11.SetError(borderEmail, string.Empty);
                    errorProvider10.SetError(borderEmail, "Email is valid.");

                    // Check if email exists in superadmin tables
                    try
                    {
                        if (emailValidator.IsEmailSuperAdminExist(email))
                        {
                            errorProvider3.SetError(borderEmail, string.Empty);
                            errorProvider10.SetError(borderEmail, string.Empty);
                            errorProvider11.SetError(borderEmail, "Email is already registered as a superadmin.");
                        }
                        else
                        {
                            errorProvider3.SetError(borderEmail, string.Empty);
                            errorProvider11.SetError(borderEmail, string.Empty);

                            errorProvider10.SetError(borderEmail, "Email is valid.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error checking email existence: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    errorProvider10.SetError(borderEmail, string.Empty);
                    errorProvider11.SetError(borderEmail, "Email is not valid.");
                }
            }


            //Input data to database
            if (!checkBox)
            {
                errorProvider7.SetError(borderTerms, "Check the Terms and Condition.");
            }
            else
            {
                errorProvider7.SetError(borderTerms, string.Empty);

                if (string.IsNullOrEmpty(pwd) || string.IsNullOrEmpty(rePwd))
                {
                    errorProvider4.SetError(borderPass, "Password is required.");
                    errorProvider4.SetError(borderRePass, "Confirm Password is required.");
                }
                else
                {
                    errorProvider4.SetError(borderPass, string.Empty);
                    errorProvider4.SetError(borderRePass, string.Empty);

                    if (pwd != rePwd)
                    {
                        errorProvider6.SetError(borderPass, "Passwords do not match.");
                        errorProvider6.SetError(borderRePass, "Passwords do not match.");
                    }
                    else
                    {
                        errorProvider6.SetError(borderPass, string.Empty);
                        errorProvider6.SetError(borderRePass, string.Empty);

                        if (passwordValidator.isPasswordNotValid(pwd) || passwordValidator.isPasswordNotValid(rePwd))
                        {
                            errorProvider8.SetError(borderPass, "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.");
                            errorProvider8.SetError(borderRePass, "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.");
                        }
                        else
                        {
                            errorProvider8.SetError(borderPass, string.Empty);
                            errorProvider8.SetError(borderRePass, string.Empty);

                            if (string.IsNullOrEmpty(email))
                            {
                                errorProvider3.SetError(borderEmail, "Email is required.");
                            }
                            else
                            {
                                errorProvider3.SetError(borderEmail, string.Empty);

                                if (emailValidator.IsEmailNotValidate(email))
                                {
                                    errorProvider11.SetError(borderEmail, "Email is not valid");
                                }
                                else
                                {
                                    errorProvider11.SetError(borderEmail, string.Empty);

                                    if (
                                        errorProvider1.GetError(borderFirst) != string.Empty ||
                                        errorProvider2.GetError(borderLast) != string.Empty ||
                                        errorProvider3.GetError(borderEmail) != string.Empty ||
                                        errorProvider5.GetError(borderRole) != string.Empty
                                    )
                                    {
                                        // Do nothing if there are errors
                                    }
                                    else
                                    {
                                        string fullname = $"{fname} {lname}";

                                        string query = "INSERT INTO superadmin (Name, Email, Password, Role_ID, created_at, updated_at) " +
                                            "VALUES (@fullname, @email, @pwd, @roleID, @createdAt, @updatedAt)";
                                        MySqlConnection conn = databaseHelper.getConnection();
                                        try
                                        {
                                            conn.Open();

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

                                            int rowsAffected = cmd.ExecuteNonQuery();

                                            //MessageBox.Show("Successful");

                                            AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "Super admin created successfully", Properties.Resources.success);

                                            txtFirstName.Text = "";
                                            txtLastName.Text = "";
                                            txtEmail.Text = "";
                                            txtPwd.Text = "";
                                            txtRePwd.Text = "";
                                            txtComboBox.Text = "";
                                            checkBox = false;

                                            // Clear error providers
                                            errorProvider9.SetError(borderRePass, string.Empty);
                                            errorProvider9.SetError(borderPass, string.Empty);
                                            errorProvider7.SetError(borderTerms, string.Empty);
                                            errorProvider10.SetError(borderEmail, string.Empty);
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
                                }
                            }
                        }
                    }
                }
            }


        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegSuperAdmin();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


