using Application_Desktop.Controller;
using Application_Desktop.Model;
using Application_Desktop.Models;
using Application_Desktop.Screen;
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

namespace Application_Desktop.SuperAdmin_Sub_Views
{
    public partial class registerAccessAccount : Form
    {
        private accessAccountController _accessAccountController;
        public registerAccessAccount()
        {
            _accessAccountController = new accessAccountController();
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

        private async void registerAccessAccount_Load(object sender, EventArgs e)
        {
            try
            {
                List<AccessAccount> accessList = await _accessAccountController.SelectAdmin();

                txtEmail.Items.Clear();

                foreach (var access in accessList)
                {
                    txtEmail.Items.Add(access._email);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading access accounts: {ex.Message}");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            var access = new AccessAccount
            {
                _email = txtEmail.Text,
                _password = txtPassword.Text,
                _branchName = txtBranch.Text,
                _usrename = txtUsername.Text
            };

            // Validate the access account data
            var validationErrors = access.validate();
            errorProvider1.Clear();

            // Check if the username already exists
            if (await _accessAccountController.UsernameExists(access._usrename))
            {
                if (!validationErrors.ContainsKey("Username"))
                {
                    validationErrors.Add("Username", "This username is already taken. Please choose a different one.");
                }
            }

            // Check if the email already exists
            if (await _accessAccountController.EmailExists(access._email))
            {
                if (!validationErrors.ContainsKey("Email"))
                {
                    validationErrors.Add("Email", "This email is already registered. Please use a different email.");
                }
            }

            // Validate the password using your passwordValidator class
            if (passwordValidator.isPasswordNotValid(access._password))
            {
                if (!validationErrors.ContainsKey("Password"))
                {
                    validationErrors.Add("Password", "Password must be at least 8 characters long, contain at least one uppercase letter and one number.");
                }
            }

            foreach (var error in validationErrors)
            {
                switch (error.Key)
                {
                    case "Email":
                        errorProvider1.SetError(borderEmail, error.Value);
                        break;
                    case "Username":
                        errorProvider1.SetError(borderUsername, error.Value);
                        break;
                    case "BranchName":
                        errorProvider1.SetError(borderBranch, error.Value);
                        break;
                    case "Password":
                        errorProvider1.SetError(borderPass, error.Value);
                        break;
                }
            }

            if (validationErrors.Count == 0)
            {
                await _accessAccountController.Create(access);
                AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "Access account saved successfully", Properties.Resources.success);
            }
        }

        private async void txtFullname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtEmail.SelectedIndex != -1)
            {
                try
                {
                    string selectedAdminEmail = txtEmail.Text;

                    int adminId = await _accessAccountController.SelectAdminID(selectedAdminEmail);

                    var branchInfo = await _accessAccountController.SelectBranchByAdmin(selectedAdminEmail);

                    if (branchInfo != null)
                    {
                        txtBranch.Text = branchInfo._branchName;
                    }
                    else
                    {
                        MessageBox.Show("No branch found for this admin.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving branch info: {ex.Message}");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
