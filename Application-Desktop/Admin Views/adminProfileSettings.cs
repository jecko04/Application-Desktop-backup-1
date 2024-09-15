using Application_Desktop.Model;
using Application_Desktop.Models;
using Application_Desktop.Screen;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Application_Desktop.Models.EllipseManager;

namespace Application_Desktop.Admin_Views
{
    public partial class adminProfileSettings : Form
    {


        public adminProfileSettings()
        {
            InitializeComponent();

            ElipseManager elipseManager = new ElipseManager(5);
            elipseManager.ApplyElipseToAllButtons(this);

            ElipseManager elipseManagerPanel = new ElipseManager(15);
            elipseManagerPanel.ApplyElipseToPanel(profileInfoPanel);
            elipseManagerPanel.ApplyElipseToPanel(updatePasswordPanel);
            elipseManagerPanel.ApplyElipseToPanel(deleteAccountPanel);


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
        private async void adminProfileSettings_Load(object sender, EventArgs e)
        {
            await GetAdminNames();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private async void btnProfileSave_Click(object sender, EventArgs e)
        {
            try
            {
                profileSettingModel updateProfile = new profileSettingModel
                {
                    _name = txtFirstname.Text + " " + txtLastname.Text,
                    _email = txtEmail.Text,
                };
                await UpdateProfileInfo(updateProfile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Select Name and Email of Current User

        private async Task<profileSettingModel> GetAdminNames()
        {
            int admin = session.LoggedInSession;

            string query = @"Select Name, Email From admin Where Admin_ID = @admin";

            MySqlConnection conn = databaseHelper.getConnection();
            profileSettingModel adminNames = new profileSettingModel();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@admin", admin);
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

        //Update Profile
        private async Task UpdateProfileInfo(profileSettingModel adminProfile)
        {
            int admin = session.LoggedInSession;
            string query = @"UPDATE admin SET Name = @name, Email = @email Where Admin_ID = @adminId";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", adminProfile._name);
                cmd.Parameters.AddWithValue("@email", adminProfile._email);
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
    }
}
