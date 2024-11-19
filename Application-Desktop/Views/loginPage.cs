using Application_Desktop.Controller;
using Application_Desktop.Method;
using Application_Desktop.Models;
using Application_Desktop.Screen;
using Application_Desktop.Sub_Views;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static Application_Desktop.Models.EllipseManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Application_Desktop.Views
{
    public partial class loginPage : Form
    {
        private loginPageController _loginPageController;
        //private sendEmailReminder _sendEmailReminder;

        public loginPage()
        {
            InitializeComponent();
            _loginPageController = new loginPageController();

            this.AcceptButton = btnLogins;

            ElipseManager elipseManager = new ElipseManager(5);
            elipseManager.ApplyElipseToAllButtons(this);

            /*timerReminder.Interval = 14400000; // 4 hours in milliseconds
            timerReminder.Tick += timerReminder_Tick;
            timerReminder.Start();*/
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

        private void loginPage_Load(object sender, EventArgs e)
        {

        }

        private async Task Login()
        {
            string email = txtEmail.Text;
            string pwd = txtPass.Text;

            //Error Provider
            if (string.IsNullOrEmpty(email))
            {
                errorProvider1.SetError(txtEmail, "Email is required");
            }
            else
            {
                errorProvider1.SetError(txtEmail, string.Empty);
            }
            if (string.IsNullOrEmpty(pwd))
            {
                errorProvider2.SetError(txtPass, "Password is required");
            }
            else
            {
                errorProvider2.SetError(txtPass, string.Empty);
            }

            //Select Data
            if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(pwd))
            {
                errorProvider1.SetError(txtEmail, "Email is required");
                errorProvider2.SetError(txtPass, "Password is required");
            }
            else if (string.IsNullOrEmpty(email))
            {
                errorProvider2.SetError(txtPass, string.Empty);

                errorProvider1.SetError(txtEmail, "Email is required");

            }
            else if (string.IsNullOrEmpty(pwd))
            {
                errorProvider1.SetError(txtEmail, string.Empty);

                errorProvider2.SetError(txtPass, "Password is required");
            }
            else if (
            errorProvider1.GetError(txtEmail) != string.Empty ||
            errorProvider2.GetError(txtPass) != string.Empty
            )
            {

            }
            else
            {
                btnLogins.Text = "Loading...";
                btnLogins.Enabled = false;

                string query = "SELECT 'SuperAdmin' AS Role, SuperAdmin_ID AS ID, email AS Name, password AS Pass FROM superadmin " +
                "UNION ALL " +
                "SELECT 'Admin' AS Role, Admin_ID AS ID, email AS Name, password AS Pass FROM admin";

                MySqlConnection conn = databaseHelper.getConnection();


                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    bool emailFound = false;
                    bool passwordVerified = false;


                    cryptography verify = new cryptography();

                    while (await reader.ReadAsync())
                    {
                        string Role = reader["Role"].ToString();
                        string name = reader["Name"].ToString();
                        string pass = reader["Pass"].ToString();

                        if (email.Equals(reader.GetString("Name"), StringComparison.OrdinalIgnoreCase)) // Case-insensitive email comparison
                        {
                            emailFound = true;

                            string storedHash = reader.GetString("Pass");

                            if (verify.VerifyPassword(pwd, storedHash))
                            {
                                passwordVerified = true;

                                int ID;
                                if (Role.StartsWith("SuperAdmin"))
                                {
                                    ID = reader.GetInt32("ID");
                                    session.LoggedInSession = ID;

                                    bool hasUnusedOtp = await _loginPageController.CheckUnusedOtpSuper(ID);

                                    if (!hasUnusedOtp)
                                    {
                                        await SendOTPSuper();

                                        AlertBox(Color.LightGreen, Color.SeaGreen, "Verification Send", "Please check your gmail", Properties.Resources.success);

                                        await Task.Delay(2000);

                                        otpSuper otp = new otpSuper();
                                        otp.BringToFront();
                                        otp.Show();
                                    }
                                    else
                                    {
                                        //MessageBox.Show("An OTP exists. Logging in directly.");
                                        superAdmin superadmin = new superAdmin();
                                        superadmin.BringToFront();
                                        superadmin.Show();
                                    }


                                    this.Hide();

                                    break;
                                }
                                else if (Role.StartsWith("Admin"))
                                {
                                    ID = reader.GetInt32("ID");
                                    session.LoggedInSession = ID;


                                    bool hasUnusedOtp = await _loginPageController.CheckUnusedOtp(ID);

                                    if (!hasUnusedOtp)
                                    {
                                        await SendOTP();

                                        AlertBox(Color.LightGreen, Color.SeaGreen, "Verification Send", "Please check your gmail", Properties.Resources.success);

                                        await Task.Delay(2000);

                                        otp otp = new otp();
                                        otp.BringToFront();
                                        otp.Show();
                                    }
                                    else
                                    {
                                        //MessageBox.Show("An OTP exists. Logging in directly.");
                                        adminPage adminForm = new adminPage();
                                        adminForm.BringToFront();
                                        adminForm.Show();
                                    }

                                    this.Hide();

                                    break;
                                }

                                this.Hide();
                                errorProvider1.SetError(txtEmail, string.Empty);
                                errorProvider2.SetError(txtPass, string.Empty);
                                break;
                            }

                        }
                    }
                    if (!emailFound)
                    {
                        errorProvider1.SetError(txtEmail, "Email not found");
                    }
                    else
                    {
                        errorProvider1.SetError(txtEmail, string.Empty);
                    }
                    if (!passwordVerified)
                    {
                        errorProvider2.SetError(txtPass, "Password is incorrect");
                    }
                    else
                    {
                        errorProvider2.SetError(txtPass, string.Empty);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    await conn.CloseAsync();
                    btnLogins.Text = "Login";
                    btnLogins.Enabled = true;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnLogins_Click(object sender, EventArgs e)
        {
            await Login();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            //Show Password
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private async Task SendOTP()
        {
            int ID = session.LoggedInSession;
            string email = txtEmail.Text;


            int Vcode = new Random().Next(100000, 999999);

            string to = txtEmail.Text;
            string from = "smtc.dentalcare@gmail.com";
            string pass = "esttldcshliffgwz";
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Subject = "Your Verification Code";
            message.IsBodyHtml = true;
            message.Body = $@"<html>
                    <body style=""font-family: Arial, sans-serif; color: #333; line-height: 1.6;"">
                        <div style=""max-width: 600px; margin: auto; padding: 20px; border: 1px solid #ccc; border-radius: 10px;"">
                            <h2 style=""color: #c0392b; text-align: center;"">Your OTP Code</h2>
                            <p>Dear Valued User,</p>

                            <p>
                                Your OTP code is <strong style=""color: #2980b9;"">{Vcode}</strong>. 
                                Please enter this code to complete your verification process.
                            </p>

                            <p>If you did not request this code, please disregard this message.</p>

                            <p style=""text-align: center; font-style: italic; color: #7f8c8d;"">
                                ""Your security is our top priority!""
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

                await _loginPageController.InsertOtp(ID, email, Vcode);

            }
            catch (Exception ex)
            {
                throw new Exception($"error {ex.Message}");
            }
        }

        private async Task SendOTPSuper()
        {
            int ID = session.LoggedInSession;
            string email = txtEmail.Text;

            int Vcode = new Random().Next(100000, 999999);

            string to = txtEmail.Text;
            string from = "smtc.dentalcare@gmail.com";
            string pass = "esttldcshliffgwz";
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Subject = "Your Verification Code";
            message.IsBodyHtml = true;
            message.Body = $@"<html>
                    <body style=""font-family: Arial, sans-serif; color: #333; line-height: 1.6;"">
                        <div style=""max-width: 600px; margin: auto; padding: 20px; border: 1px solid #ccc; border-radius: 10px;"">
                            <h2 style=""color: #c0392b; text-align: center;"">Your OTP Code</h2>
                            <p>Dear Valued User,</p>

                            <p>
                                Your OTP code is <strong style=""color: #2980b9;"">{Vcode}</strong>. 
                                Please enter this code to complete your verification process.
                            </p>

                            <p>If you did not request this code, please disregard this message.</p>

                            <p style=""text-align: center; font-style: italic; color: #7f8c8d;"">
                                ""Your security is our top priority!""
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


                await _loginPageController.InsertOtpSuper(ID, email, Vcode);

            }
            catch (Exception ex)
            {
                throw new Exception($"error {ex.Message}");
            }
        }

        private void timeVcode_Tick(object sender, EventArgs e)
        {

        }

        private async void timerReminder_Tick(object sender, EventArgs e)
        {
           /* try
            {
                await _sendEmailReminder.CheckAppointmentAndSendReminder();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error timer {ex.Message}");
            }*/
        }
    }
}
