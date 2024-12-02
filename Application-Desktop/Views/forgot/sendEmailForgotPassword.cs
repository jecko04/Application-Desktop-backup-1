using Application_Desktop.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application_Desktop.Models;
using System.Security.Cryptography;
using static System.Net.WebRequestMethods;
using MySql.Data.MySqlClient;
using Application_Desktop.Screen;

namespace Application_Desktop.Views.forgot
{

    public partial class sendEmailForgotPassword : Form
    {
        private resetpasswordController _resetpasswordController;
        public sendEmailForgotPassword()
        {
            _resetpasswordController = new resetpasswordController();
            InitializeComponent();
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

        private void sendEmailForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private string GenerateSecureToken()
        {
            using (var cryptoProvider = new RNGCryptoServiceProvider())
            {
                byte[] tokenData = new byte[16];
                cryptoProvider.GetBytes(tokenData);
                return Convert.ToBase64String(tokenData);
            }
        }



        private async Task<bool> SendEmailForgotPassword()
        {
            //int ID = session.LoggedInSession;
            //string email = txtEmail.Text;

            string email = txtEmail.Text;
            string token = GenerateSecureToken();
            string resetLink = $"http://localhost:8080/resetpassword?token={WebUtility.UrlEncode(token)}";

            var (userId, userType) = await _resetpasswordController.FindUserByEmail(email);

            if (userId <= 0 || string.IsNullOrEmpty(userType))
            {
                MessageBox.Show("Email not found. Please check and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string to = email;
            string from = "smtc.dentalcare@gmail.com";
            string pass = "esttldcshliffgwz";
            MailMessage message = new MailMessage
            {
                From = new MailAddress(from),
                Subject = "Reset Your Password",
                IsBodyHtml = true,
                Body = $@"<html>
            <body style='font-family: Arial, sans-serif;'>
                <div style='max-width: 600px; margin: auto;'>
                    <h2>Password Reset Request</h2>
                    <p>Use the link below to reset your password:</p>
                    <p><a href='{resetLink}'>{resetLink}</a></p>
                </div>
            </body>
        </html>"
            };
            message.To.Add(to);

            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                EnableSsl = true,
                Port = 587,
                Credentials = new NetworkCredential(from, pass)
            })
            {
                try
                {
                    smtp.Send(message);
                    await _resetpasswordController.InsertResetPasswordToken(userId, email, token, userType);
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error sending email: {ex.Message}");
                }
            }
        }

        //Send Forgot Password Link

        private async Task SendEmailNotif()
        {
            btnLogins.Enabled = false;
            btnLogins.Text = "Sending...";
            try
            {

                bool isSend = await SendEmailForgotPassword();
                if (isSend)
                {
                    btnLogins.Enabled = true;
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Send Reset Password Link", "", Properties.Resources.success);


                }
                else
                {
                    btnLogins.Enabled = true;
                    AlertBox(Color.LightPink, Color.Red, "Failed Send Reset Password Link", "", Properties.Resources.error);


                }

                await Task.Delay(3000);

                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"error {ex.Message}");
            }
            finally
            {

            }
        }

        private async void btnLogins_Click(object sender, EventArgs e)
        {
            btnLogins.Enabled = false;
            btnLogins.Text = "Sending...";
            try
            {
                bool isSend = await SendEmailForgotPassword();
                if (isSend)
                {
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Reset Password Link Sent", "", Properties.Resources.success);
                }
                else
                {
                    AlertBox(Color.LightPink, Color.Red, "Failed to Send Reset Password Link", "", Properties.Resources.error);
                }
                await Task.Delay(3000);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLogins.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendEmailForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
