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

namespace Application_Desktop.Sub_Views
{
    public partial class dentaldoctorUsers : Form
    {
        public dentaldoctorUsers()
        {
            InitializeComponent();
            LoadDentalData();
        }

        private void dentaldoctorUsers_Load(object sender, EventArgs e)
        {

        }

        private void LoadDentalData()
        {
            string query = @"SELECT 
                             dentaldoctor.Doctors_ID,
                             dentaldoctor.Name, 
                             dentaldoctor.Email, 
                             dentaldoctor.Password, 
                             branch.BranchName AS BranchName, 
                             role.RoleName AS RoleName,
                             admin.Name AS CreatedByName
                             FROM dentaldoctor
                             JOIN branch ON dentaldoctor.Branch_ID = branch.Branch_ID
                             JOIN admin ON dentaldoctor.CreatedBy = admin.Admin_ID
                             JOIN role ON dentaldoctor.Role_ID = role.Role_ID";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                viewDentalAccount.DataSource = null;
                viewDentalAccount.Rows.Clear();
                viewDentalAccount.Columns.Clear();

                AddColumnDentalDoctor();

                viewDentalAccount.DataSource = dataTable;

                
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

        private void AddColumnDentalDoctor()
        {
            DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
            selectColumn.HeaderText = "";
            selectColumn.Name = "selectDoctors";
            selectColumn.Width = 30;
            viewDentalAccount.Columns.Add(selectColumn);
            viewDentalAccount.Columns["selectDoctors"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewTextBoxColumn adminColumn = new DataGridViewTextBoxColumn();
            adminColumn.HeaderText = "Doctors ID";
            adminColumn.Name = "Doctors_ID";
            adminColumn.DataPropertyName = "Doctors_ID";
            viewDentalAccount.Columns.Add(adminColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "Name";
            nameColumn.DataPropertyName = "Name";
            viewDentalAccount.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.HeaderText = "Email";
            emailColumn.Name = "Email";
            emailColumn.DataPropertyName = "Email";
            viewDentalAccount.Columns.Add(emailColumn);

            DataGridViewTextBoxColumn passwordColumn = new DataGridViewTextBoxColumn();
            passwordColumn.HeaderText = "Password";
            passwordColumn.Name = "Password";
            passwordColumn.DataPropertyName = "Password";
            viewDentalAccount.Columns.Add(passwordColumn);


            DataGridViewTextBoxColumn branchColumn = new DataGridViewTextBoxColumn();
            branchColumn.HeaderText = "Branch";
            branchColumn.Name = "Branch_ID";
            branchColumn.DataPropertyName = "BranchName";
            viewDentalAccount.Columns.Add(branchColumn);

            DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
            roleColumn.HeaderText = "Role";
            roleColumn.Name = "Role_ID";
            roleColumn.DataPropertyName = "RoleName";
            viewDentalAccount.Columns.Add(roleColumn);

            DataGridViewTextBoxColumn createdByColumn = new DataGridViewTextBoxColumn();
            createdByColumn.HeaderText = "Created By";
            createdByColumn.Name = "CreatedBy";
            createdByColumn.DataPropertyName = "CreatedByName";
            viewDentalAccount.Columns.Add(createdByColumn);

            DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn();
            editButtonColumn.HeaderText = "";
            editButtonColumn.Name = "view";
            editButtonColumn.Image = Properties.Resources.view;
            editButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editButtonColumn.Width = 50;
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            viewDentalAccount.Columns.Add(editButtonColumn);
        }
    }
}
