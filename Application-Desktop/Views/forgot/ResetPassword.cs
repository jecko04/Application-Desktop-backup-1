using Application_Desktop.Controller;
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

namespace Application_Desktop.Views.forgot
{
    public partial class ResetPassword : Form
    {
        private readonly string _token;
        private int _adminId;
        private resetpasswordController _resetpasswordController;
        public ResetPassword(string token)
        {
            InitializeComponent();
            _token = token;
            _resetpasswordController = new resetpasswordController();
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

        private async void ResetPassword_Load(object sender, EventArgs e)
        {


        }

        private async Task<bool> VerifyTokenAsync(string token)
        {
            return await _resetpasswordController.VerifyToken(token);
        }

        private async Task ChangePassword(string newPass)
        {


            btnSubmit.Enabled = false;
            btnSubmit.Text = "Updating...";
            try
            {
                bool isChanged = await _resetpasswordController.ChangePassword(newPass, _adminId);
                if (isChanged)
                {
                    AlertBox(Color.LightGreen, Color.SeaGreen, "New Password Set", "Successfully change password", Properties.Resources.success);
                }
                else
                {
                    AlertBox(Color.LightPink, Color.Red, "Failed to set", "Failed to change password", Properties.Resources.success);
                }

                await Task.Delay(3000);
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Changing Password {ex.Message}");
            }
            finally
            {
                btnSubmit.Enabled = true;
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string newPass = txtNewPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(newPass))
            {
                errorProvider1.SetError(txtNewPassword, "Please fill in the password.");
            }
            else if (newPass.Length < 8)
            {
                errorProvider1.SetError(txtNewPassword, "Password must be at least 8 characters.");
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, string.Empty);
            }

            if (string.IsNullOrEmpty(confirmPass))
            {
                errorProvider1.SetError(txtConfirmPassword, "Please confirm the password.");
            }
            else if (newPass != confirmPass)
            {
                errorProvider1.SetError(txtConfirmPassword, "Passwords do not match.");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, string.Empty);
            }

            if (string.IsNullOrEmpty(errorProvider1.GetError(txtNewPassword)) &&
                string.IsNullOrEmpty(errorProvider1.GetError(txtConfirmPassword)))
            {
                _ = ChangePassword(newPass);
            }
            else
            {
                MessageBox.Show("Please fix the errors before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void ResetPassword_Load_1(object sender, EventArgs e)
        {
            bool isValid = await VerifyTokenAsync(_token);
            if (!isValid)
            {
                MessageBox.Show("Invalid or expired token.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            try
            {
                _adminId = await _resetpasswordController.GetAdminIdByToken(_token);

                if (_adminId <= 0)
                {
                    MessageBox.Show("Invalid or expired token.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
