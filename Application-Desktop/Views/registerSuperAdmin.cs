using Application_Desktop.Models;
using Isopoh.Cryptography.Blake2b;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace Application_Desktop
{
    public partial class registerSuperAdmin : Form
    {
        public registerSuperAdmin()
        {
            InitializeComponent();

        }
        private void registerSuperAdmin_Load(object sender, EventArgs e)
        {
            //Selecting roles from database
            string query = "SELECT Role_ID FROM role";
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
                        string roleName = GetRoleNameFromRoleId(Convert.ToInt32(reader["Role_ID"]));
                        txtComboBox.Items.Add(new KeyValuePair<int, string>(Convert.ToInt32(reader["Role_ID"]), roleName));
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



        private string GetRoleNameFromRoleId(int roleId)
        {
            //Getting role name
            switch (roleId)
            {
                case 1:
                    return "SuperAdmin";
                /*                case 2:
                                    return "Admin";
                                case 3:
                                    return "User";*/
                default:
                    return "Unknown Role";
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

        private void btnRegister_Click(object sender, EventArgs e)
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
                errorProvider1.SetError(txtFirstName, "First Name is required.");
            }
            else
            {
                errorProvider1.SetError(txtFirstName, string.Empty);
            }

            if (string.IsNullOrEmpty(lname))
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

            if (string.IsNullOrEmpty(roles))
            {
                errorProvider5.SetError(txtComboBox, "Roles is required.");
            }
            else
            {
                errorProvider5.SetError(txtComboBox, string.Empty);
            }


            //Password error Provider
            if (string.IsNullOrEmpty(pwd) || string.IsNullOrEmpty(rePwd))
            {
                errorProvider6.SetError(txtRePwd, string.Empty);
                errorProvider6.SetError(txtPwd, string.Empty);

                errorProvider8.SetError(txtRePwd, string.Empty);
                errorProvider8.SetError(txtPwd, string.Empty);

                errorProvider9.SetError(txtRePwd, string.Empty);
                errorProvider9.SetError(txtPwd, string.Empty);

                errorProvider4.SetError(txtPwd, "Password is required.");
                errorProvider4.SetError(txtRePwd, "Confirm Password is required.");
            }
            else if (pwd != rePwd)
            {
                errorProvider4.SetError(txtPwd, string.Empty);
                errorProvider4.SetError(txtRePwd, string.Empty);

                errorProvider8.SetError(txtRePwd, string.Empty);
                errorProvider8.SetError(txtPwd, string.Empty);

                errorProvider9.SetError(txtRePwd, string.Empty);
                errorProvider9.SetError(txtPwd, string.Empty);

                errorProvider6.SetError(txtPwd, "Password are not match.");
                errorProvider6.SetError(txtRePwd, "Password are not match.");
            }
            else if (passwordValidator.IsPasswordValidate(pwd) || passwordValidator.IsPasswordValidate(rePwd))
            {
                errorProvider4.SetError(txtPwd, string.Empty);
                errorProvider4.SetError(txtRePwd, string.Empty);

                errorProvider6.SetError(txtRePwd, string.Empty);
                errorProvider6.SetError(txtPwd, string.Empty);

                errorProvider8.SetError(txtRePwd, string.Empty);
                errorProvider8.SetError(txtPwd, string.Empty);

                errorProvider9.SetError(txtPwd, "Password is valid");
                errorProvider9.SetError(txtRePwd, "Password is valid");
            }
            else if (passwordValidator.isPasswordNotValid(pwd) || passwordValidator.isPasswordNotValid(rePwd))
            {
                errorProvider4.SetError(txtPwd, string.Empty);
                errorProvider4.SetError(txtRePwd, string.Empty);

                errorProvider6.SetError(txtRePwd, string.Empty);
                errorProvider6.SetError(txtPwd, string.Empty);

                errorProvider9.SetError(txtRePwd, string.Empty);
                errorProvider9.SetError(txtPwd, string.Empty);

                errorProvider8.SetError(txtPwd, "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.");
                errorProvider8.SetError(txtRePwd, "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.");

            }

            //Email error Provider
            if (string.IsNullOrEmpty(email))
            {
                errorProvider3.SetError(txtEmail, "Email is required.");
                errorProvider10.SetError(txtEmail, string.Empty);
                errorProvider11.SetError(txtEmail, string.Empty);
            }
            else
            {
                errorProvider3.SetError(txtEmail, string.Empty);

                // Validate if email format is correct
                if (emailValidator.IsEmailValidate(email))
                {
                    errorProvider3.SetError(txtEmail, string.Empty);
                    errorProvider11.SetError(txtEmail, string.Empty);
                    errorProvider10.SetError(txtEmail, "Email is valid.");

                    // Check if email exists in superadmin tables
                    try
                    {
                        if (emailValidator.IsEmailSuperAdminExist(email))
                        {
                            errorProvider3.SetError(txtEmail, string.Empty);
                            errorProvider10.SetError(txtEmail, string.Empty);
                            errorProvider11.SetError(txtEmail, "Email is already registered as a superadmin.");
                        }
                        else
                        {
                            errorProvider3.SetError(txtEmail, string.Empty);
                            errorProvider11.SetError(txtEmail, string.Empty);

                            errorProvider10.SetError(txtEmail, "Email is valid.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error checking email existence: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    errorProvider10.SetError(txtEmail, string.Empty);
                    errorProvider11.SetError(txtEmail, "Email is not valid.");
                }
            }


            //Input data to database
            if (!checkBox)
            {
                errorProvider7.SetError(txtLink, "Check the Terms and Condition.");
            }
            else if (string.IsNullOrEmpty(pwd) || string.IsNullOrEmpty(rePwd))
            {
                errorProvider4.SetError(txtPwd, "Password is required.");
                errorProvider4.SetError(txtRePwd, "Confirm Password is required.");
            }
            else if (pwd != rePwd)
            {
                errorProvider6.SetError(txtPwd, "Password are not match.");
                errorProvider6.SetError(txtRePwd, "Password are not match.");
            }
            else if (passwordValidator.isPasswordNotValid(pwd) || passwordValidator.isPasswordNotValid(rePwd))
            {
                errorProvider8.SetError(txtPwd, "Password must be at least 8 characters long and contain at least " +
                    "one uppercase letter, one lowercase letter, and one number.");
                errorProvider8.SetError(txtRePwd, "Password must be at least 8 characters long and contain at least " +
                    "one uppercase letter, one lowercase letter, and one number.");
            }
            else if (string.IsNullOrEmpty(email))
            {
                errorProvider3.SetError(txtEmail, "Email is required.");
            }
            else if (emailValidator.IsEmailNotValidate(email))
            {
                errorProvider11.SetError(txtEmail, "Email is not valid");
            }
            else if (
            errorProvider1.GetError(txtFirstName) != string.Empty ||
            errorProvider2.GetError(txtLastName) != string.Empty ||
            errorProvider3.GetError(txtEmail) != string.Empty ||
            errorProvider5.GetError(txtComboBox) != string.Empty
            )
            {

            }
            else
            {
                string fullname = $"{fname} {lname}";

                string query = "INSERT INTO superadmin (Name, Email, Pwd, Role_ID) " +
                    "VALUES (@fullname, @email, @pwd, @roleID)";
                MySqlConnection conn = databaseHelper.getConnection();
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fullname", fullname);
                    cmd.Parameters.AddWithValue("@email", email);
                    //Add validation of password, password hint, encryption

                    //Encryption
                    cryptography hasher = new cryptography();
                    string hashPassword = hasher.HashPassword(pwd);
                    cmd.Parameters.AddWithValue("@pwd", hashPassword);



                    //Get the selected role_ID from the comboBox
                    KeyValuePair<int, string> selectedRole = (KeyValuePair<int, string>)txtComboBox.SelectedItem;
                    int roleId = selectedRole.Key;

                    cmd.Parameters.AddWithValue("@roleID", roleId);
                    int rowsaffected = cmd.ExecuteNonQuery();

                    MessageBox.Show("Successful");
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtEmail.Text = "";
                    txtPwd.Text = "";
                    txtRePwd.Text = "";
                    txtComboBox.Text = "";
                    txtCheckBox.Checked = false;

                    errorProvider9.SetError(txtRePwd, string.Empty);
                    errorProvider9.SetError(txtPwd, string.Empty);
                    errorProvider7.SetError(txtCheckBox, string.Empty);
                    errorProvider10.SetError(txtEmail, string.Empty);
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


