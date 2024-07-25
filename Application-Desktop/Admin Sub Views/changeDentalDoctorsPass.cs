using Application_Desktop.Models;
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

namespace Application_Desktop.Admin_Sub_Views
{
    public partial class changeDentalDoctorsPass : Form
    {
        private int doctorsID;
        public changeDentalDoctorsPass(int doctorsID)
        {
            InitializeComponent();
            this.doctorsID = doctorsID;
        }

        public bool SelectPassword(int doctorsID)
        {
            string Cpass = txtCurrentPass.Text;

            bool passwordVerify = false;

            string query = "Select Password from dentaldoctor where Doctors_ID = @doctorsID";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@doctorsID", doctorsID);
                MySqlDataReader reader = cmd.ExecuteReader();


                cryptography verify = new cryptography();

                while (reader.Read())
                {
                    string storedHash = reader.GetString("Password");
                    if (verify.VerifyPassword(Cpass, storedHash))
                    {
                        passwordVerify = true;
                        errorProvider1.SetError(txtCurrentPass, string.Empty);
                        errorProvider4.SetError(txtCurrentPass, "Verified Password");
                    }
                    else
                    {
                        errorProvider4.SetError(txtCurrentPass, string.Empty);

                        errorProvider1.SetError(txtCurrentPass, "Wrong Password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return passwordVerify;
        }

        public bool ChangePassword(int doctorsID)
        {
            string Cpass = txtCurrentPass.Text;
            string Npass = txtNewPass.Text;
            string CNpass = txtConfirmPass.Text;

            if (string.IsNullOrEmpty(Npass) || string.IsNullOrEmpty(CNpass))
            {
                errorProvider1.SetError(txtNewPass, string.Empty);
                errorProvider2.SetError(txtConfirmPass, string.Empty);

                errorProvider1.SetError(txtNewPass, "Password is required.");
                errorProvider2.SetError(txtConfirmPass, "Password is required.");
            }
            else if (CNpass != Npass)
            {
                errorProvider1.SetError(txtNewPass, string.Empty);
                errorProvider2.SetError(txtConfirmPass, string.Empty);

                errorProvider1.SetError(txtNewPass, "Password is not match");
                errorProvider2.SetError(txtConfirmPass, "Password is not match");
            }
            else if (passwordValidator.IsPasswordValidate(Npass) || passwordValidator.IsPasswordValidate(CNpass))
            {

                errorProvider1.SetError(txtNewPass, string.Empty);
                errorProvider2.SetError(txtConfirmPass, string.Empty);

                errorProvider4.SetError(txtConfirmPass, string.Empty);

                errorProvider4.SetError(txtNewPass, "Password is valid");
                errorProvider4.SetError(txtConfirmPass, "Password is valid");
            }
            else if (passwordValidator.isPasswordNotValid(Npass) || passwordValidator.isPasswordNotValid(CNpass))
            {

                errorProvider1.SetError(txtNewPass, string.Empty);
                errorProvider2.SetError(txtConfirmPass, string.Empty);

                errorProvider1.SetError(txtNewPass, "Password must be at least 8 characters long and contain at least" +
                    " one uppercase letter, one lowercase letter, and one number.");
                errorProvider2.SetError(txtConfirmPass, "Password must be at least 8 characters long and contain at least" +
                    " one uppercase letter, one lowercase letter, and one number.");
            }



            if (string.IsNullOrEmpty(Npass))
            {
                errorProvider1.SetError(txtNewPass, "Password is required");
            }
            else if (string.IsNullOrEmpty(CNpass))
            {
                errorProvider2.SetError(txtConfirmPass, "Password is required");
            }
            else if (string.IsNullOrEmpty(Cpass))
            {
                errorProvider3.SetError(txtCurrentPass, "Current Password is required");
            }
            else if (
            errorProvider1.GetError(txtNewPass) != string.Empty ||
            errorProvider2.GetError(txtConfirmPass) != string.Empty ||
            errorProvider3.GetError(txtCurrentPass) != string.Empty
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
                        conn.Open();
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cryptography hash = new cryptography();
                    string newPass = hash.HashPassword(Npass);
                    cmd.Parameters.AddWithValue("@pwd", newPass);
                    cmd.Parameters.AddWithValue("@doctorsID", doctorsID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Password changed successfully");

                    txtCurrentPass.Text = "";
                    txtNewPass.Text = "";
                    txtConfirmPass.Text = "";

                    errorProvider4.SetError(txtNewPass, string.Empty);
                    errorProvider4.SetError(txtConfirmPass, string.Empty);
                    errorProvider4.SetError(txtCurrentPass, string.Empty);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }

            }
            return false;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (SelectPassword(doctorsID))
            {
                ChangePassword(doctorsID);
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
    }
}
