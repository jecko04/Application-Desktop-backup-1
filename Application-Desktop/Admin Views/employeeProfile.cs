using Application_Desktop.Admin_Sub_Views;
using Application_Desktop.Models;
using Application_Desktop.Screen;
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

namespace Application_Desktop.Admin_Views
{
    public partial class employeeProfile : Form
    {
        public employeeProfile()
        {
            InitializeComponent();

            viewEmployeeDetails.CellValueChanged += viewEmployeeDetails_CellContentClick;

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

        private registerEmployees RegisterEmployeesInstance;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (RegisterEmployeesInstance == null || RegisterEmployeesInstance.IsDisposed)
            {
                RegisterEmployeesInstance = new registerEmployees();
                RegisterEmployeesInstance.Show();
            }
            else
            {
                if (RegisterEmployeesInstance.Visible)
                {
                    RegisterEmployeesInstance.BringToFront();
                }
                else
                {
                    RegisterEmployeesInstance.Show();
                }
            }
        }

        private async Task LoadEmployees()
        {
            int adminBranchID = session.LoggedInSession;
            int branchID = -1;

            string getBranchID = "SELECT Branch_ID FROM admin WHERE Admin_ID = @adminID";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
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
                    AlertBox(Color.LightPink, Color.DarkRed, "Error", "The branch didn't retrieved successfully", Properties.Resources.error);
                    return;
                }

                // Select Employee base on Branch
                string query = @"SELECT 
                             employees.Employee_ID,
                             employees.Fullname, 
                             employees.Email, 
                             employees.Phone, 
                             employees.DateOfBirth,
                             employees.Address,
                             employees.Position,
                             employees.HireDate,
                             employees.Specialization,
                             employees.LicenseNumber,
                             employees.Status,
                             employees.Branch_ID,
                             employees.created_at,
                             employees.updated_at,
                             branch.BranchName AS BranchName
                             FROM employees
                             JOIN branch ON employees.Branch_ID = branch.Branch_ID
                             Where employees.Branch_ID = @branchID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@branchID", branchID);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable datatable = new DataTable();

                await Task.Run(() => adapter.Fill(datatable));

                viewEmployeeDetails.DataSource = null;
                viewEmployeeDetails.Rows.Clear();
                viewEmployeeDetails.Columns.Clear();

                viewEmployeeDetails.AutoGenerateColumns = false;

                AddColumnEmployee();

                viewEmployeeDetails.DataSource = datatable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { await conn.CloseAsync(); }
        }

        //add column

        private void AddColumnEmployee()
        {
            DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
            selectColumn.HeaderText = "";
            selectColumn.Name = "selectEmployees";
            selectColumn.Width = 30;
            viewEmployeeDetails.Columns.Add(selectColumn);
            viewEmployeeDetails.Columns["selectEmployees"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewTextBoxColumn employeeColumn = new DataGridViewTextBoxColumn();
            employeeColumn.HeaderText = "Employee ID";
            employeeColumn.Name = "Employee_ID";
            employeeColumn.DataPropertyName = "Employee_ID";
            viewEmployeeDetails.Columns.Add(employeeColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Fullname";
            nameColumn.Name = "Fullname";
            nameColumn.DataPropertyName = "Fullname";
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewEmployeeDetails.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.HeaderText = "Email";
            emailColumn.Name = "Email";
            emailColumn.DataPropertyName = "Email";
            emailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewEmployeeDetails.Columns.Add(emailColumn);

            DataGridViewTextBoxColumn phoneColumn = new DataGridViewTextBoxColumn();
            phoneColumn.HeaderText = "Phone/Mobile";
            phoneColumn.Name = "Phone";
            phoneColumn.DataPropertyName = "Phone";
            phoneColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewEmployeeDetails.Columns.Add(phoneColumn);

            DataGridViewTextBoxColumn dobColumn = new DataGridViewTextBoxColumn();
            dobColumn.HeaderText = "Date of Birth";
            dobColumn.Name = "DateOfBirth";
            dobColumn.DataPropertyName = "DateOfBirth";
            dobColumn.DefaultCellStyle.Format = "yyyy-MM-dd";
            viewEmployeeDetails.Columns.Add(dobColumn);

            DataGridViewTextBoxColumn addressColumn = new DataGridViewTextBoxColumn();
            addressColumn.HeaderText = "Address";
            addressColumn.Name = "Address";
            addressColumn.DataPropertyName = "Address";
            viewEmployeeDetails.Columns.Add(addressColumn);

            DataGridViewTextBoxColumn positionColumn = new DataGridViewTextBoxColumn();
            positionColumn.HeaderText = "Position";
            positionColumn.Name = "Position";
            positionColumn.DataPropertyName = "Position";
            viewEmployeeDetails.Columns.Add(positionColumn);

            DataGridViewTextBoxColumn hireDateColumn = new DataGridViewTextBoxColumn();
            hireDateColumn.HeaderText = "Hire Date";
            hireDateColumn.Name = "HireDate";
            hireDateColumn.DataPropertyName = "HireDate";
            viewEmployeeDetails.Columns.Add(hireDateColumn);

            DataGridViewTextBoxColumn specializationColumn = new DataGridViewTextBoxColumn();
            specializationColumn.HeaderText = "Specialization";
            specializationColumn.Name = "Specialization";
            specializationColumn.DataPropertyName = "Specialization";
            viewEmployeeDetails.Columns.Add(specializationColumn);

            DataGridViewTextBoxColumn licenseColumn = new DataGridViewTextBoxColumn();
            licenseColumn.HeaderText = "License Number";
            licenseColumn.Name = "LicenseNumber";
            licenseColumn.DataPropertyName = "LicenseNumber";
            viewEmployeeDetails.Columns.Add(licenseColumn);

            DataGridViewTextBoxColumn branchColumn = new DataGridViewTextBoxColumn();
            branchColumn.HeaderText = "Branch";
            branchColumn.Name = "Branch_ID";
            branchColumn.DataPropertyName = "BranchName";
            viewEmployeeDetails.Columns.Add(branchColumn);

            DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn();
            statusColumn.HeaderText = "Status";
            statusColumn.Name = "Status";
            statusColumn.DataPropertyName = "Status";

            // Add items to the ComboBox column
            statusColumn.Items.AddRange(new object[] {
                "active",     // Employee is actively working
                "inactive",   // Employee is not currently active
                "terminated", // Employee has been let go from the practice
                "retired"     // Employee has retired
            });

            viewEmployeeDetails.Columns.Add(statusColumn);

            DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn();
            editButtonColumn.HeaderText = "";
            editButtonColumn.Name = "edit";
            editButtonColumn.Image = Properties.Resources.edit_img;
            editButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editButtonColumn.Width = 50;
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            viewEmployeeDetails.Columns.Add(editButtonColumn);

            DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Name = "delete";
            deleteButtonColumn.Image = Properties.Resources.delete_img;
            deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            deleteButtonColumn.Width = 50;
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            viewEmployeeDetails.Columns.Add(deleteButtonColumn);
        }

        private async void employeeProfile_Load(object sender, EventArgs e)
        {
            await LoadEmployees();
        }

        //refresh
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadEmployees();
        }

        private async void viewEmployeeDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update status
            viewEmployeeDetails.EndEdit();

            if (e.ColumnIndex == viewEmployeeDetails.Columns["Status"].Index && e.RowIndex >= 0)
            {
                var newStatus = viewEmployeeDetails.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                var employeeId = viewEmployeeDetails.Rows[e.RowIndex].Cells["Employee_ID"].Value.ToString();

                await UpdateEmployeeStatus(employeeId, newStatus);
                this.BeginInvoke(new Action(() =>
                {
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The employee status updated successfully", Properties.Resources.success);
                }));
            }
        }

        private async Task UpdateEmployeeStatus(string employeeId, string newStatus)
        {
            string query = @"Update employees Set Status = @status Where Employee_ID = @employeeID";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                   await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@employeeID", employeeId);
                await cmd.ExecuteNonQueryAsync();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { await conn.CloseAsync(); }
        }

    }
}
