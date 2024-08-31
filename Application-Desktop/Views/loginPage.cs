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

namespace Application_Desktop.Views
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void loginPage_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pwd = txtPassword.Text;

            //Error Provider
            if (string.IsNullOrEmpty(email))
            {
                errorProvider1.SetError(borderEmail, "Email is required");
            }
            else
            {
                errorProvider1.SetError(borderEmail, string.Empty);
            }
            if (string.IsNullOrEmpty(pwd))
            {
                errorProvider2.SetError(borderPassword, "Password is required");
            }
            else
            {
                errorProvider2.SetError(borderPassword, string.Empty);
            }

            //Select Data
            if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(pwd))
            {
                errorProvider1.SetError(borderEmail, "Email is required");
                errorProvider2.SetError(borderPassword, "Password is required");
            }
            else if (string.IsNullOrEmpty(email))
            {
                errorProvider2.SetError(borderPassword, string.Empty);

                errorProvider1.SetError(borderEmail, "Email is required");

            }
            else if (string.IsNullOrEmpty(pwd))
            {
                errorProvider1.SetError(borderEmail, string.Empty);

                errorProvider2.SetError(borderPassword, "Password is required");
            }
            else if (
            errorProvider1.GetError(borderEmail) != string.Empty ||
            errorProvider2.GetError(borderPassword) != string.Empty
            )
            {

            }
            else
            {


                string query = "SELECT 'SuperAdmin' AS Role, SuperAdmin_ID AS ID, email AS Name, password AS Pass FROM superadmin " +
                "UNION ALL " +
                "SELECT 'Admin' AS Role, Admin_ID AS ID, email AS Name, password AS Pass FROM admin";

                MySqlConnection conn = databaseHelper.getConnection();
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    bool emailFound = false;
                    bool passwordVerified = false;


                    cryptography verify = new cryptography();

                    while (reader.Read())
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

                                    MessageBox.Show("Welcome Super Admin");

                                    this.Hide();
                                    superAdmin superadmin = new superAdmin();
                                    superadmin.BringToFront();
                                    superadmin.Show();
                                    break;
                                }
                                else if (Role.StartsWith("Admin"))
                                {
                                    ID = reader.GetInt32("ID");
                                    session.LoggedInSession = ID;

                                    MessageBox.Show("Welcome Admin");

                                    this.Hide();
                                    adminPage adminForm = new adminPage();
                                    adminForm.BringToFront();
                                    adminForm.Show();
                                    break;
                                }

                                this.Hide();
                                errorProvider1.SetError(borderEmail, string.Empty);
                                errorProvider2.SetError(borderPassword, string.Empty);
                                break;
                            }

                        }
                    }
                    if (!emailFound)
                    {
                        errorProvider1.SetError(borderEmail, "Email not found");
                    }
                    else
                    {
                        errorProvider1.SetError(borderEmail, string.Empty);
                    }
                    if (!passwordVerified)
                    {
                        errorProvider2.SetError(borderPassword, "Password is incorrect");
                    }
                    else
                    {
                        errorProvider2.SetError(borderPassword, string.Empty);
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
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Show Password
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
