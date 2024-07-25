using Application_Desktop.Models;
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
    }
}
