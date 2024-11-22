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

            string token = GenerateSecureToken();
            string resetLink = $"http://localhost:8080/resetpassword?token={WebUtility.UrlEncode(token)}";

            string email = txtEmail.Text;
            int adminId = await _resetpasswordController.FindUserId(email);

            if (adminId <= 0)
            {
                MessageBox.Show("Email not found. Please check and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            string to = email;
            string from = "smtc.dentalcare@gmail.com";
            string pass = "esttldcshliffgwz";
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Subject = "Reset Your Password";
            message.IsBodyHtml = true;
            message.Body = $@"<html>
                    <body style=""font-family: Arial, sans-serif; color: #333; line-height: 1.6;"">
                        <div style=""max-width: 600px; margin: auto; padding: 20px; border: 1px solid #ccc; border-radius: 10px;"">
                            <h2 style=""color: #2980b9; text-align: center;"">Password Reset Request</h2>
                            <p>Dear Valued User,</p>

                            <p>
                                We received a request to reset your password. Use the link below to complete the process:
                            </p>

                            <p style=""text-align: center; font-size: 24px; font-weight: bold; color: #c0392b;"">
                            <a href=""{resetLink}"">{resetLink}</a>
                            </p>

                            <p>If you did not request to reset your password, please ignore this message or contact support if you have concerns.</p>

                            <p style=""text-align: center; font-style: italic; color: #7f8c8d;"">
                                ""Your security is our priority.""
                            </p>

                            <hr style=""border: 1px solid #ddd;"">

                        </div>
                    </body>
                </html>";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                EnableSsl = true,
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(from, pass)
            };
            try
            {
                smtp.Send(message);
                await _resetpasswordController.InsertResetPasswordToken(adminId, email, token);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"error {ex.Message}");
            }
            return false;
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
            await SendEmailNotif();
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
