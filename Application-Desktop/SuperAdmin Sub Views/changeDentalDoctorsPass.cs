using Application_Desktop.Models;
using Application_Desktop.Screen;
using Application_Desktop.Sub_Views;
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

namespace Application_Desktop.Admin_Sub_Views
{
    public partial class changeDentalDoctorsPass : Form
    {
        private int doctorsID;
        public changeDentalDoctorsPass(int doctorsID)
        {
            InitializeComponent();
            this.doctorsID = doctorsID;

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

        public async Task<bool> SelectPassword(int doctorsID)
        {
            string Cpass = txtCurrentPass.Text;

            bool passwordVerify = false;

            string query = "Select Password from dentaldoctor where Doctors_ID = @doctorsID";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@doctorsID", doctorsID);
                MySqlDataReader reader = cmd.ExecuteReader();


                cryptography verify = new cryptography();

                while (await reader.ReadAsync())
                {
                    string storedHash = reader.GetString("Password");
                    if (verify.VerifyPassword(Cpass, storedHash))
                    {
                        passwordVerify = true;
                        errorProvider1.SetError(borderCurrent, string.Empty);
                        errorProvider4.SetError(borderCurrent, "Verified Password");
                    }
                    else
                    {
                        errorProvider4.SetError(borderCurrent, string.Empty);

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

        public async Task<bool> ChangePassword(int doctorsID)
        {
            string Cpass = txtCurrentPass.Text;
            string Npass = txtNewPass.Text;
            string CNpass = txtConfirmPass.Text;

            if (string.IsNullOrEmpty(Npass) || string.IsNullOrEmpty(CNpass))
            {
                errorProvider1.SetError(borderNew, string.Empty);
                errorProvider2.SetError(borderRepass, string.Empty);

                errorProvider1.SetError(borderNew, "Password is required.");
                errorProvider2.SetError(borderRepass, "Password is required.");
            }
            else if (CNpass != Npass)
            {
                errorProvider1.SetError(borderNew, string.Empty);
                errorProvider2.SetError(borderRepass, string.Empty);

                errorProvider1.SetError(borderNew, "Password is not match");
                errorProvider2.SetError(borderRepass, "Password is not match");
            }
            else if (passwordValidator.IsPasswordValidate(Npass) || passwordValidator.IsPasswordValidate(CNpass))
            {

                errorProvider1.SetError(borderNew, string.Empty);
                errorProvider2.SetError(borderRepass, string.Empty);

                errorProvider4.SetError(borderRepass, string.Empty);

                errorProvider4.SetError(txtNewPass, "Password is valid");
                errorProvider4.SetError(borderRepass, "Password is valid");
            }
            else if (passwordValidator.isPasswordNotValid(Npass) || passwordValidator.isPasswordNotValid(CNpass))
            {

                errorProvider1.SetError(borderNew, string.Empty);
                errorProvider2.SetError(borderRepass, string.Empty);

                errorProvider1.SetError(borderNew, "Password must be at least 8 characters long and contain at least" +
                    " one uppercase letter, one lowercase letter, and one number.");
                errorProvider2.SetError(borderRepass, "Password must be at least 8 characters long and contain at least" +
                    " one uppercase letter, one lowercase letter, and one number.");
            }



            if (string.IsNullOrEmpty(Npass))
            {
                errorProvider1.SetError(borderNew, "Password is required");
            }
            else if (string.IsNullOrEmpty(CNpass))
            {
                errorProvider2.SetError(borderRepass, "Password is required");
            }
            else if (string.IsNullOrEmpty(Cpass))
            {
                errorProvider3.SetError(borderCurrent, "Current Password is required");
            }
            else if (
            errorProvider1.GetError(borderNew) != string.Empty ||
            errorProvider2.GetError(borderRepass) != string.Empty ||
            errorProvider3.GetError(borderCurrent) != string.Empty
            )
            {

            }
            else
            {
                string query = "UPDATE dentaldoctor SET Password = @pwd WHERE Doctors_ID = @doctorsID";

                MySqlConnection conn = databaseHelper.getConnection();

                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cryptography hash = new cryptography();
                    string newPass = hash.HashPassword(Npass);
                    cmd.Parameters.AddWithValue("@pwd", newPass);
                    cmd.Parameters.AddWithValue("@doctorsID", doctorsID);
                    await cmd.ExecuteNonQueryAsync();

                    //MessageBox.Show("Password changed successfully");
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The doctor password changed successfully", Properties.Resources.success);

                    txtCurrentPass.Text = "";
                    txtNewPass.Text = "";
                    txtConfirmPass.Text = "";

                    errorProvider4.SetError(borderNew, string.Empty);
                    errorProvider4.SetError(borderRepass, string.Empty);
                    errorProvider4.SetError(borderCurrent, string.Empty);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { await conn.CloseAsync(); }

            }
            return false;
        }

        private async void btnChangePass_Click(object sender, EventArgs e)
        {
            if (await SelectPassword(doctorsID))
            {
                await ChangePassword(doctorsID);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //Show Password
            if (txtNewPass.PasswordChar == '*' || txtConfirmPass.PasswordChar == '*' || txtCurrentPass.PasswordChar == '*')
            {
                txtNewPass.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
                txtCurrentPass.PasswordChar = '\0';
            }
            else
            {
                txtNewPass.PasswordChar = '*';
                txtConfirmPass.PasswordChar = '*';
                txtCurrentPass.PasswordChar = '*';
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
