using Application_Desktop.Model;
using Application_Desktop.Models;
using Application_Desktop.Screen;
using Application_Desktop.Views;
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
using static Application_Desktop.Models.EllipseManager;

namespace Application_Desktop.SuperAdmin_Views
{
    public partial class superAdminProfileSetting : Form
    {
        private readonly superAdmin _superAdmin;
        public superAdminProfileSetting(superAdmin superadmin)
        {
            InitializeComponent();
            _superAdmin = superadmin;

            ElipseManager elipseManager = new ElipseManager(5);
            elipseManager.ApplyElipseToAllButtons(this);

            ElipseManager elipseManagerPanel = new ElipseManager(15);
            elipseManagerPanel.ApplyElipseToPanel(profileInfoPanel);
            elipseManagerPanel.ApplyElipseToPanel(updatePasswordPanel);
            //elipseManagerPanel.ApplyElipseToPanel(deleteAccountPanel);
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

        private async void superAdminProfileSetting_Load(object sender, EventArgs e)
        {
            await GetSuperAdminNames();
        }

        //Select Name and Email of Current User

        private async Task<superAdminProfileUpdateInfoModel> GetSuperAdminNames()
        {
            int admin = session.LoggedInSession;

            string query = @"Select Name, Email From superadmin Where SuperAdmin_ID = @superadmin";

            MySqlConnection conn = databaseHelper.getConnection();
            superAdminProfileUpdateInfoModel adminNames = new superAdminProfileUpdateInfoModel();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@superadmin", admin);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (await reader.ReadAsync())
                {

                    string fullName = reader.GetString("Name");
                    string email = reader.GetString("Email");

                    // Split the full name into first and last name
                    var (firstName, lastName) = SplitFullName(fullName);

                    adminNames._name = fullName; // Store the full name if needed
                    adminNames._email = email;

                    // Set the first and last names as needed

                    txtFirstname.Text = adminNames._firstname = firstName;
                    txtLastname.Text = adminNames._lastname = lastName;
                    txtEmail.Text = adminNames._email;
                }
                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Selecting admin name error" + ex.Message);
            }
            finally { await conn.CloseAsync(); }
            return adminNames;
        }

        //Split names
        private (string FirstName, string LastName) SplitFullName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return (string.Empty, string.Empty);
            }

            string[] nameParts = fullName.Split(' ');

            if (nameParts.Length < 2)
            {
                return (nameParts[0], string.Empty); // Only one part
            }

            string firstName = nameParts[0];
            string lastName = string.Join(' ', nameParts.Skip(1)); // Combine remaining parts as last name

            return (firstName, lastName);
        }

        //Delete Account
        private async Task<bool> DeleteAccount()
        {
            int adminId = session.LoggedInSession;
            string query = @"DELETE from superadmin Where SuperAdmin_ID = @admin";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@admin", adminId);
                int rowsAffected = await cmd.ExecuteNonQueryAsync();



                return rowsAffected > 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { await conn.CloseAsync(); }
            return false;
        }
       /* private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Warning: Deleting your account will permanently delete all of its data. Are you sure you want to proceed?",
                "Delete Account",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (result == DialogResult.Yes)
            {
                // Proceed with deletion
                bool isDeleted = await DeleteAccount();
                if (isDeleted)
                {

                    session.Logout();

                    this.BeginInvoke(new Action(() =>
                    {
                        AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "Account deleted successfully. You have been logged out", Properties.Resources.success);

                        Task.Delay(2000).ContinueWith(t =>
                        {
                            this.Invoke(new Action(() =>
                            {
                                _superAdmin.Close();

                                loginPage loginForm = new loginPage();
                                loginForm.Show();
                            }));
                        });
                    }));
                }
            }
        }*/

        //Changed password
        private async Task<bool> GetCurrentPassword(superAdminUpdatePasswordModel superAdminPassword)
        {
            bool passwordVerify = false;
            int adminID = session.LoggedInSession;

            string query = "Select Password from superadmin where SuperAdmin_ID = @adminID";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@adminID", adminID);
                MySqlDataReader reader = cmd.ExecuteReader();


                cryptography verify = new cryptography();

                while (await reader.ReadAsync())
                {
                    string storedHash = reader.GetString("Password");
                    if (verify.VerifyPassword(superAdminPassword._currentPassword, storedHash))
                    {
                        passwordVerify = true;
                        errorProvider1.SetError(borderCurrent, string.Empty);
                        errorProvider3.SetError(borderCurrent, "Verified Password");
                    }
                    else
                    {
                        errorProvider3.SetError(borderCurrent, string.Empty);

                        errorProvider1.SetError(borderCurrent, "Wrong Password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { await conn.CloseAsync(); }
            return passwordVerify;
        }

        private async Task<bool> ChangePassword(superAdminUpdatePasswordModel superAdminPassword)
        {
            int adminID = session.LoggedInSession;

            string query = @"Update superadmin Set Password = @password Where SuperAdmin_ID = @admin";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@admin", adminID);

                cryptography hash = new cryptography();
                string newHash = hash.HashPassword(superAdminPassword._newPassword);
                cmd.Parameters.AddWithValue("@password", newHash);

                await cmd.ExecuteNonQueryAsync();

                txtCurrent.Text = "";
                txtNew.Text = "";
                txtConfirm.Text = "";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { await conn.CloseAsync(); }
            return false;
        }


        private async void btnSavePass_Click(object sender, EventArgs e)
        {
            try
            {
                var profilePassword = new superAdminUpdatePasswordModel
                {
                    _confrimPassword = txtConfirm.Text,
                    _newPassword = txtNew.Text,
                    _currentPassword = txtCurrent.Text
                };

                var validationErrors = profilePassword.validate();

                errorProvider1.Clear();
                errorProvider2.Clear();

                foreach (var error in validationErrors)
                {
                    switch (error.Key)
                    {
                        case "Current":
                            errorProvider1.SetError(borderCurrent, error.Value);
                            break;
                        case "NotValid":
                            errorProvider1.SetError(borderNew, error.Value);
                            errorProvider1.SetError(borderConfirm, error.Value);
                            break;
                        case "NotMatch":
                            errorProvider1.SetError(borderNew, error.Value);
                            errorProvider1.SetError(borderConfirm, error.Value);
                            break;
                    }
                }

                if (validationErrors.Count == 0)
                {

                    superAdminUpdatePasswordModel updatePassword = new superAdminUpdatePasswordModel
                    {
                        _currentPassword = txtCurrent.Text,
                        _newPassword = txtNew.Text,
                        _confrimPassword = txtConfirm.Text
                    };
                    if (await GetCurrentPassword(updatePassword))
                    {
                        bool isChanged = await ChangePassword(updatePassword);
                        if (isChanged)
                        {

                            session.Logout();



                            this.BeginInvoke(new Action(() =>
                            {
                                AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "Changed password successfully. You have been logged out", Properties.Resources.success);

                                Task.Delay(2000).ContinueWith(t =>
                                {
                                    this.Invoke(new Action(() =>
                                    {
                                        _superAdmin.Close();

                                        loginPage loginForm = new loginPage();
                                        loginForm.Show();
                                    }));
                                });
                            }));
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Update Profile
        private async Task UpdateProfileInfo(superAdminProfileUpdateInfoModel superAdminProfile)
        {
            int admin = session.LoggedInSession;
            string query = @"UPDATE superadmin SET Name = @name, Email = @email Where SuperAdmin_ID = @adminId";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", superAdminProfile._name);
                cmd.Parameters.AddWithValue("@email", superAdminProfile._email);
                cmd.Parameters.AddWithValue("@adminId", admin);
                await cmd.ExecuteNonQueryAsync();

                AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "Profile information has been successfully updated", Properties.Resources.success);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Update" + ex.Message);
            }
            finally { await conn.CloseAsync(); }
        }

        private async void btnProfileSave_Click(object sender, EventArgs e)
        {
            try
            {
                var profileInfo = new superAdminProfileUpdateInfoModel
                {
                    _name = txtFirstname.Text + " " + txtLastname.Text,
                    _email = txtEmail.Text,
                    _firstname = txtFirstname.Text,
                    _lastname = txtLastname.Text
                };

                var validationErrors = profileInfo.validate();

                errorProvider1.Clear();
                errorProvider2.Clear();

                foreach (var error in validationErrors)
                {
                    if (error.Key == "Firstname")
                        errorProvider1.SetError(borderFirst, error.Value);
                    if (error.Key == "Lastname")
                        errorProvider1.SetError(borderLast, error.Value);
                    if (error.Key == "Email")
                        errorProvider2.SetError(borderEmail, error.Value);
                    // Add other fields as necessary
                }

                if (validationErrors.Count == 0)
                {
                    superAdminProfileUpdateInfoModel updateProfile = new superAdminProfileUpdateInfoModel
                    {
                        _name = txtFirstname.Text + " " + txtLastname.Text,
                        _email = txtEmail.Text,
                    };
                    await UpdateProfileInfo(updateProfile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
