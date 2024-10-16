using Application_Desktop.Models;
using Application_Desktop.Sub_Views;
using MaterialSkin.Controls;
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

namespace Application_Desktop.Views
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
            
            this.AcceptButton = btnLogins;

            ElipseManager elipseManager = new ElipseManager(5);
            elipseManager.ApplyElipseToAllButtons(this);
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
    }
}
