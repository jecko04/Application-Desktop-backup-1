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
    public partial class editDentalDoctorAccounts : Form
    {
        private int doctorsID;
        public editDentalDoctorAccounts(int doctorsID, string fname, string lname, string email, string pwd, string role, string branch)
        {
            InitializeComponent();
            this.doctorsID = doctorsID;

            txtfirstName.Text = fname;
            txtLastName.Text = lname;
            txtEmail.Text = email;
            txtPassword.Text = pwd;

            txtRoles.Text = GetRoleName(role);

            txtBranch.Text = GetBranchName(branch);

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

        public string GetRoleName(string rolename)
        {
            string role = null;
            string query = "SELECT Role_ID, RoleName FROM role WHERE RoleName = @rolename";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rolename", rolename);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int roleId = Convert.ToInt32(reader["Role_ID"]);
                    role = reader["RoleName"].ToString();

                    txtRoles.SelectedItem = role;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return role;
        }


        public string GetBranchName(string branchname)
        {

            string branch = null;
            string query = "Select Branch_ID, BranchName from branch Where BranchName = @branchname";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("branchname", branchname);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int branchId = Convert.ToInt32(reader["Branch_ID"]);
                    branch = reader["BranchName"].ToString();

                    txtBranch.SelectedItem = branch;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return branch;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task DentalAccountUpdate(int doctorsID)
        {
            int CreatedBy = session.LoggedInSession;

            string query = @"Update dentaldoctor Set Name = @fullname, Email = @email, CreatedBy = @createdBy, updated_at = @updatedAt 
                           Where Doctors_ID = @doctorsID";

            string fullname = $"{txtfirstName.Text} {txtLastName.Text}";
            string email = txtEmail.Text;

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open) { await conn.OpenAsync(); }
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@fullname", fullname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@createdBy", CreatedBy);

                DateTime updatedAt = DateTime.Now;
                cmd.Parameters.AddWithValue("@updatedAt", updatedAt);
                cmd.Parameters.AddWithValue("@doctorsID", doctorsID);
                await cmd.ExecuteNonQueryAsync();

                AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The account has been updated successfully", Properties.Resources.success);


                this.Close();

                errorProvider1.SetError(borderFirst, string.Empty);
                errorProvider1.SetError(borderLast, string.Empty);
                errorProvider1.SetError(borderEmail, string.Empty);
                errorProvider1.SetError(borderRole, string.Empty);
                errorProvider1.SetError(borderBranch, string.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { await conn.CloseAsync(); }
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string fname = txtfirstName.Text;
            string lname = txtLastName.Text;

            string email = txtEmail.Text;
            string role = txtRoles.Text;
            string branch = txtBranch.Text;


            // empty field error provider
            if (string.IsNullOrEmpty(fname))
            {
                errorProvider1.SetError(borderFirst, "First name is required");
            }
            else
            {
                errorProvider1.SetError(borderFirst, string.Empty);
            }

            if (string.IsNullOrEmpty(lname))
            {
                errorProvider2.SetError(borderLast, "Last name is required");
            }
            else
            {
                errorProvider2.SetError(borderLast, string.Empty);
            }
            if (string.IsNullOrEmpty(email))
            {
                errorProvider3.SetError(borderEmail, "Email is required");
            }
            else
            {
                errorProvider3.SetError(borderEmail, string.Empty);
            }
            if (string.IsNullOrEmpty(role))
            {
                errorProvider4.SetError(borderRole, "Role is required");
            }
            else
            {
                errorProvider4.SetError(borderRole, string.Empty);
            }
            if (string.IsNullOrEmpty(branch))
            {
                errorProvider5.SetError(borderBranch, "Branch is required");
            }
            else
            {
                errorProvider5.SetError(borderBranch, string.Empty);
            }



            // proceed to update
            if (errorProvider1.GetError(borderFirst) != string.Empty ||
                    errorProvider2.GetError(borderLast) != string.Empty ||
                    errorProvider3.GetError(borderEmail) != string.Empty ||
                    errorProvider4.GetError(borderRole) != string.Empty ||
                    errorProvider5.GetError(borderBranch) != string.Empty)
            {
                return;
            }
            else
            {
                await DentalAccountUpdate(doctorsID);
            }
        }
    }
}
