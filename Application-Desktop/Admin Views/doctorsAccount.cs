using Application_Desktop.Admin_Sub_Views;
using Application_Desktop.Models;
using Application_Desktop.Sub_sub_Views;
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

namespace Application_Desktop.Admin_Views
{
    public partial class doctorsAccount : Form
    {
        public doctorsAccount()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            int adminBranchID = session.LoggedInSession;
            int branchID = -1;

            string getBranchID = "SELECT Branch_ID FROM admin WHERE Admin_ID = @adminID";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand getBranchIDCmd = new MySqlCommand(getBranchID, conn);
                getBranchIDCmd.Parameters.AddWithValue("@adminID", adminBranchID);

                MySqlDataReader branchIDReader = getBranchIDCmd.ExecuteReader();
                if (branchIDReader.Read())
                {
                    branchID = Convert.ToInt32(branchIDReader["Branch_ID"]);
                }
                branchIDReader.Close();

                // Check if adminBranchID was correctly retrieved
                if (branchID == -1)
                {
                    MessageBox.Show("Failed to retrieve the admin's branch ID.");
                    return;
                }

                // Select Account base on Branch
                string query = @"SELECT 
                             dentaldoctor.Doctors_ID,
                             dentaldoctor.Name, 
                             dentaldoctor.Email, 
                             dentaldoctor.Password, 
                             branch.BranchName AS BranchName, 
                             role.RoleName AS RoleName,
                             admin.Name AS CreatedByName, 
                             dentaldoctor.Role_ID,
                             dentaldoctor.Branch_ID
                             FROM dentaldoctor
                             JOIN branch ON dentaldoctor.Branch_ID = branch.Branch_ID
                             JOIN admin ON dentaldoctor.CreatedBy = admin.Admin_ID
                             JOIN role ON dentaldoctor.Role_ID = role.Role_ID
                             Where dentaldoctor.Branch_ID = @branchID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@branchID", branchID);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                viewDentalDoctorAccount.DataSource = null;
                viewDentalDoctorAccount.Rows.Clear();
                viewDentalDoctorAccount.Columns.Clear();

                viewDentalDoctorAccount.AutoGenerateColumns = false;

                AddColumnDentalDoctor();

                viewDentalDoctorAccount.DataSource = datatable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void AddColumnDentalDoctor()
        {
            DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
            selectColumn.HeaderText = "";
            selectColumn.Name = "selectDoctors";
            selectColumn.Width = 30;
            viewDentalDoctorAccount.Columns.Add(selectColumn);
            viewDentalDoctorAccount.Columns["selectDoctors"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewTextBoxColumn adminColumn = new DataGridViewTextBoxColumn();
            adminColumn.HeaderText = "Doctors ID";
            adminColumn.Name = "Doctors_ID";
            adminColumn.DataPropertyName = "Doctors_ID";
            viewDentalDoctorAccount.Columns.Add(adminColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "Name";
            nameColumn.DataPropertyName = "Name";
            viewDentalDoctorAccount.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.HeaderText = "Email";
            emailColumn.Name = "Email";
            emailColumn.DataPropertyName = "Email";
            viewDentalDoctorAccount.Columns.Add(emailColumn);

            DataGridViewTextBoxColumn passwordColumn = new DataGridViewTextBoxColumn();
            passwordColumn.HeaderText = "Password";
            passwordColumn.Name = "Password";
            passwordColumn.DataPropertyName = "Password";
            viewDentalDoctorAccount.Columns.Add(passwordColumn);


            DataGridViewTextBoxColumn branchColumn = new DataGridViewTextBoxColumn();
            branchColumn.HeaderText = "Branch";
            branchColumn.Name = "Branch_ID";
            branchColumn.DataPropertyName = "BranchName";
            viewDentalDoctorAccount.Columns.Add(branchColumn);

            DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
            roleColumn.HeaderText = "Role";
            roleColumn.Name = "Role_ID";
            roleColumn.DataPropertyName = "RoleName";
            viewDentalDoctorAccount.Columns.Add(roleColumn);

            DataGridViewTextBoxColumn createdByColumn = new DataGridViewTextBoxColumn();
            createdByColumn.HeaderText = "Created By";
            createdByColumn.Name = "CreatedBy";
            createdByColumn.DataPropertyName = "CreatedByName";
            viewDentalDoctorAccount.Columns.Add(createdByColumn);

            DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn();
            editButtonColumn.HeaderText = "";
            editButtonColumn.Name = "edit";
            editButtonColumn.Image = Properties.Resources.edit_img;
            editButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editButtonColumn.Width = 50;
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            viewDentalDoctorAccount.Columns.Add(editButtonColumn);

            DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Name = "delete";
            deleteButtonColumn.Image = Properties.Resources.delete_img;
            deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            deleteButtonColumn.Width = 50;
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            viewDentalDoctorAccount.Columns.Add(deleteButtonColumn);

            DataGridViewImageColumn changeButtonColumn = new DataGridViewImageColumn();
            changeButtonColumn.HeaderText = "";
            changeButtonColumn.Name = "change";
            changeButtonColumn.Image = Properties.Resources.change;
            changeButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            changeButtonColumn.Width = 50;
            changeButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            viewDentalDoctorAccount.Columns.Add(changeButtonColumn);
        }

        private registerDentalDoctorAccount RegisterDentalDoctorInstance;
        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            if (RegisterDentalDoctorInstance == null || RegisterDentalDoctorInstance.IsDisposed)
            {
                RegisterDentalDoctorInstance = new registerDentalDoctorAccount();
                RegisterDentalDoctorInstance.Show();
            }
            else
            {
                if (RegisterDentalDoctorInstance.Visible)
                {
                    RegisterDentalDoctorInstance.BringToFront();
                }
                else
                {
                    RegisterDentalDoctorInstance.Show();
                }
            }
        }

        private void viewDentalDoctorAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
