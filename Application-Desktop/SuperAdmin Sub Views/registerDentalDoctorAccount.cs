﻿using Application_Desktop.Models;
using Application_Desktop.Screen;
using Application_Desktop.Sub_Views;
using ElipseToolDemo;
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
    public partial class registerDentalDoctorAccount : Form
    {
        public registerDentalDoctorAccount()
        {
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

        private async void registerDentalDoctorAccount_Load(object sender, EventArgs e)
        {
            await GettingRoleBranchName();
            //await GetEmployeeNames();
        }


        private static async Task<int[]> GetBranchID()
        {
            int adminBranchID = session.LoggedInSession;
            int branchID = -1;


            List<int> branchIDs = new List<int>();
            string getBranchID = "SELECT Branch_ID FROM branch";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand getBranchIDCmd = new MySqlCommand(getBranchID, conn);
                MySqlDataReader branchIDReader = (MySqlDataReader) await getBranchIDCmd.ExecuteReaderAsync();

                while (await branchIDReader.ReadAsync())
                {
                    branchIDs.Add(Convert.ToInt32(branchIDReader["Branch_ID"]));
                }
                await branchIDReader.CloseAsync();

                // Check if adminBranchID was correctly retrieved
                if (branchIDs.Count == 0)
                {
                    MessageBox.Show("No branch IDs were retrieved.");
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

            return branchIDs.ToArray();
        }


        private async Task GettingRoleBranchName()
        {

            int[] branchID = await GetBranchID();


            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                string inClause = string.Join(",", branchID.Select((_, index) => $"@branchID{index}"));
                string query = $@"
                    SELECT 'role' AS Type, Role_ID AS ID, RoleName AS Name 
                    FROM role 
                    UNION ALL 
                    SELECT 'branch' AS Type, Branch_ID AS ID, BranchName AS Name 
                    FROM branch 
                    WHERE Branch_ID IN ({inClause})";


                MySqlCommand cmd = new MySqlCommand(query, conn);
                for (int i = 0; i < branchID.Length; i++)
                {
                    cmd.Parameters.AddWithValue($"@branchID{i}", branchID[i]);
                }

                MySqlDataReader reader = cmd.ExecuteReader();
                while (await reader.ReadAsync())
                {
                    string type = reader["Type"].ToString();
                    int id = Convert.ToInt32(reader["ID"]);
                    string name = reader["Name"].ToString();

                    if (type == "role")
                    {
                        if (name == "User")
                        {
                            idValue role = new idValue(id, name);
                            txtRoles.Items.Add(role);
                            txtRoles.SelectedItem = role;
                        }
                    }
                    else if (type == "branch")
                    {
                        idValue branch = new idValue(id, name);
                        txtBranch.Items.Add(branch);
                        txtBranch.SelectedItem = branch;
                    }

                    txtRoles.DisplayMember = "Name";
                    txtRoles.ValueMember = "ID";

                    txtBranch.DisplayMember = "Name";
                    txtBranch.ValueMember = "ID";
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


        private async Task SignUp()
        {
            string first = txtfirstName.Text;
            string last = txtLastName.Text;
            string email = txtEmail.Text;
            string pwd = txtPassword.Text;
            string role = txtRoles.Text;
            string branch = txtBranch.Text;

            //error provider
            if (string.IsNullOrEmpty(first))
            {
                errorProvider1.SetError(borderFirst, "First Name is required.");
            }
            else
            {
                errorProvider1.SetError(borderFirst, string.Empty);
            }

            if (string.IsNullOrEmpty(last))
            {
                errorProvider1.SetError(borderLast, "First Name is required.");
            }
            else
            {
                errorProvider1.SetError(borderLast, string.Empty);
            }

            if (string.IsNullOrEmpty(email))
            {
                errorProvider3.SetError(borderEmail, "Email is required.");
            }
            else
            {
                errorProvider3.SetError(borderEmail, string.Empty);
            }

            if (string.IsNullOrEmpty(role))
            {
                errorProvider5.SetError(borderRoles, "Role is required.");
            }
            else
            {
                errorProvider5.SetError(borderRoles, string.Empty);
            }

            if (string.IsNullOrEmpty(branch))
            {
                errorProvider7.SetError(borderBranch, "Branch is required.");
            }
            else
            {
                errorProvider7.SetError(borderBranch, string.Empty);
            }

            //password error provider
            if (string.IsNullOrEmpty(pwd))
            {
                errorProvider4.SetError(borderPass, string.Empty);

                errorProvider4.SetError(borderPass, "Password is required.");
            }
            else if (passwordValidator.IsPasswordValidate(pwd))
            {

                errorProvider4.SetError(borderPass, string.Empty);

                errorProvider6.SetError(borderPass, "Password is valid");
            }
            else if (passwordValidator.isPasswordNotValid(pwd))
            {

                errorProvider4.SetError(borderPass, string.Empty);

                errorProvider4.SetError(borderPass, "Password must be at least 8 characters long and contain at least" +
                    " one uppercase letter, one lowercase letter, and one number.");
            }
            else
            {
                errorProvider4.SetError(borderPass, string.Empty);
            }

            //email error provider
            if (string.IsNullOrEmpty(email))
            {
                errorProvider3.SetError(borderEmail, "Email is required.");
                errorProvider6.SetError(borderEmail, string.Empty);
            }
            else
            {
                errorProvider3.SetError(borderEmail, string.Empty);

                // Validate if email format is correct
                if (!emailValidator.IsEmailValidate(email))
                {
                    errorProvider3.SetError(borderEmail, "Email is not valid.");
                    errorProvider6.SetError(borderEmail, string.Empty);
                }
                else
                {
                    errorProvider3.SetError(borderEmail, string.Empty);
                    errorProvider6.SetError(borderEmail, "Email is valid.");

                    // Check if email already exists
                    try
                    {
                        if (await emailValidator.IsEmailUserExist(email))
                        {
                            errorProvider3.SetError(borderEmail, "Email already exists. Please use a different email.");
                            errorProvider6.SetError(borderEmail, string.Empty);
                        }
                        else
                        {
                            errorProvider3.SetError(borderEmail, string.Empty);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error checking email existence: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (string.IsNullOrEmpty(first))
            {
                errorProvider1.SetError(borderFirst, "First Name is required.");
            }
            else if (string.IsNullOrEmpty(last))
            {
                errorProvider3.SetError(borderLast, "Email is required.");
            }
            else if (string.IsNullOrEmpty(email))
            {
                errorProvider3.SetError(borderEmail, "Email is required.");
            }
            else if (string.IsNullOrEmpty(role))
            {
                errorProvider5.SetError(borderRoles, "Role is required.");
            }
            else if (string.IsNullOrEmpty(branch))
            {
                errorProvider7.SetError(borderBranch, "Branch is required.");
            }
            else if (errorProvider1.GetError(borderFirst) != string.Empty || errorProvider1.GetError(borderLast) != string.Empty ||
            errorProvider3.GetError(borderEmail) != string.Empty ||
            errorProvider4.GetError(borderPass) != string.Empty ||
            errorProvider5.GetError(borderRoles) != string.Empty ||
            errorProvider5.GetError(borderBranch) != string.Empty
            )
            {

            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to create this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int createdBy = session.LoggedInSession;

                    string query = "INSERT INTO dentaldoctor (Name, Email, Password, Branch_ID, Role_ID, created_at, updated_at)" +
                                   "VALUES" +
                                   "(@fullname, @email, @pwd, @branchID, @roleID, @createdAt, @updatedAt)";

                    MySqlConnection conn = databaseHelper.getConnection();
                    try
                    {
                        string fullname = $"{first} {last}";

                        if (conn.State != ConnectionState.Open)
                        {
                            await conn.OpenAsync();
                        }

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@fullname", fullname);
                        cmd.Parameters.AddWithValue("@email", email);

                        //hash passowrd
                        cryptography hasher = new cryptography();
                        string hashPassword = hasher.HashPassword(pwd);
                        cmd.Parameters.AddWithValue("@pwd", hashPassword);


                        idValue selectedBranch = (idValue)txtBranch.SelectedItem;
                        int branchId = selectedBranch.ID;
                        cmd.Parameters.AddWithValue("@branchID", branchId);

                        idValue selectedRole = (idValue)txtRoles.SelectedItem;
                        int roleId = selectedRole.ID;
                        cmd.Parameters.AddWithValue("@roleID", roleId);

                        DateTime now = DateTime.Now;
                        cmd.Parameters.AddWithValue("@createdAt", now);
                        cmd.Parameters.AddWithValue("@updatedAt", now);
                        await cmd.ExecuteNonQueryAsync();


                        //MessageBox.Show("Signed-Up Successful");
                        AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The account created successfully", Properties.Resources.success);
                        //txtEmployees.Text = "";
                        txtfirstName.Text = "";
                        txtLastName.Text = "";
                        txtEmail.Text = "";
                        txtPassword.Text = "";

                        errorProvider6.SetError(txtEmail, string.Empty);
                        errorProvider6.SetError(txtPassword, string.Empty);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { await conn.CloseAsync(); }
                }
            }
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            await SignUp();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
