using Application_Desktop.Admin_Sub_Views;
using Application_Desktop.Controller;
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

                adapter.Fill(datatable);

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
            viewEmployeeDetails.RowHeadersVisible = false;
            viewEmployeeDetails.ColumnHeadersHeight = 40;

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
                "inactive"  // Employee is not currently active
            });

            statusColumn.ReadOnly = false;

            // Ensure that only the Status column is editable
            foreach (DataGridViewColumn column in viewEmployeeDetails.Columns)
            {
                if (column.Name != "Status")
                {
                    column.ReadOnly = true;
                }
            }


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

        private bool isProcessingClick = false;
        private editEmployees EditEmployeesInstance;
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

            //Edit emploees details
            if (viewEmployeeDetails.Columns["edit"] != null &&
        e.ColumnIndex == viewEmployeeDetails.Columns["edit"].Index && e.RowIndex >= 0)
            {

                int emploeesID = Convert.ToInt32(viewEmployeeDetails.Rows[e.RowIndex].Cells["Employee_ID"].Value);
                string fullname = viewEmployeeDetails.Rows[e.RowIndex].Cells["Fullname"].Value?.ToString() ?? string.Empty;
                string[] nameParts = fullname.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string fname = nameParts.Length > 0 ? nameParts[0] : string.Empty;
                string middle = nameParts.Length > 2 ? nameParts[1] : string.Empty;
                string lname = nameParts.Length > 1 ? nameParts[nameParts.Length - 1] : string.Empty;

                string email = viewEmployeeDetails.Rows[e.RowIndex].Cells["Email"].Value?.ToString() ?? string.Empty;
                string phone = viewEmployeeDetails.Rows[e.RowIndex].Cells["Phone"].Value?.ToString() ?? string.Empty;

                string dobString = viewEmployeeDetails.Rows[e.RowIndex].Cells["DateOfBirth"].Value?.ToString() ?? string.Empty;
                string hireDateString = viewEmployeeDetails.Rows[e.RowIndex].Cells["HireDate"].Value?.ToString() ?? string.Empty;

                // Parse the strings to DateTime objects
                DateTime dob, hireDate;

                bool isDobValid = DateTime.TryParse(dobString, out dob);
                bool isHireDateValid = DateTime.TryParse(hireDateString, out hireDate);

                // Format the DateTime objects to the desired format
                string formattedDob = isDobValid ? dob.ToString("MMMM/dd/yyyy") : string.Empty;
                string formattedHireDate = isHireDateValid ? hireDate.ToString("MMMM/dd/yyyy") : string.Empty;

                string address = viewEmployeeDetails.Rows[e.RowIndex].Cells["Address"].Value?.ToString() ?? string.Empty;
                string[] addressParts = address.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                string street = addressParts.Length > 0 ? addressParts[0] : string.Empty;
                string barangay = addressParts.Length > 1 ? addressParts[1] : string.Empty;
                string city = addressParts.Length > 2 ? addressParts[2] : string.Empty;
                string province = addressParts.Length > 3 ? addressParts[3] : string.Empty;
                string postalCode = addressParts.Length > 4 ? addressParts[4] : string.Empty;

                string position = viewEmployeeDetails.Rows[e.RowIndex].Cells["Position"].Value?.ToString() ?? string.Empty;

                string special = viewEmployeeDetails.Rows[e.RowIndex].Cells["Specialization"].Value?.ToString() ?? string.Empty;


                if (EditEmployeesInstance == null || EditEmployeesInstance.IsDisposed)
                {
                    EditEmployeesInstance = new editEmployees(emploeesID, fname, middle, lname, dob, email, phone, street, barangay, city, province, postalCode, position, hireDate, special);
                    EditEmployeesInstance.Show();
                }
                else
                {
                    if (EditEmployeesInstance.Visible)
                    {
                        EditEmployeesInstance.BringToFront();
                    }
                    else
                    {
                        EditEmployeesInstance.Show();
                    }
                }
            }

            //delete
            if (e.RowIndex >= 0 && e.ColumnIndex == viewEmployeeDetails.Columns["delete"].Index)
            {
                DialogResult result = MessageBox.Show("Would you like to proceed with deleting this account?", "Confirm Deletions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int doctors_ID = Convert.ToInt32(viewEmployeeDetails.Rows[e.RowIndex].Cells["Employee_ID"].Value);

                    // Delete row from database
                    await DeleteRowFromDatabase(doctors_ID);
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The data has been deleted successfully", Properties.Resources.success);
                    await LoadEmployees();
                }
            }

            //Select Check Box

            if (isProcessingClick) return; // Ignore the click if already processing

            isProcessingClick = true;

            try
            {
                // Your checkbox toggle logic here
                if (e.ColumnIndex == viewEmployeeDetails.Columns["selectEmployees"].Index)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)viewEmployeeDetails.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    bool isChecked = cell.Value != null && (bool)cell.Value;
                    cell.Value = !isChecked;
                }
            }
            finally
            {
                // Allow clicks again after processing
                isProcessingClick = false;
            }
        }



        public async Task<int> DeleteRowFromDatabase(int employeeID)
        {
            string query = "Delete From employees Where Employee_ID = @employeeid";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@employeeid", employeeID);
                await cmd.ExecuteNonQueryAsync();

                AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The account has been deleted successfully", Properties.Resources.success);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { await conn.CloseAsync(); }
            return employeeID;
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

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            bool hasSelectedRows = false;

            for (int i = 0; i < viewEmployeeDetails.Rows.Count; i++)
            {
                DataGridViewRow row = viewEmployeeDetails.Rows[i];
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["selectEmployees"] as DataGridViewCheckBoxCell;

                if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                {
                    hasSelectedRows = true;
                    break;
                }
            }

            if (!hasSelectedRows)
            {
                AlertBox(Color.LightSteelBlue, Color.DodgerBlue, "No rows selected", "No rows were selected for deletion", Properties.Resources.information);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                for (int i = viewEmployeeDetails.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = viewEmployeeDetails.Rows[i];
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["selectEmployees"] as DataGridViewCheckBoxCell;

                    // Check if the checkbox is checked
                    if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                    {
                        int doctorsID = Convert.ToInt32(row.Cells["Employee_ID"].Value);
                        viewEmployeeDetails.Rows.RemoveAt(i);
                        await DeleteRowFromDatabase(doctorsID);
                    }
                }

                AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The selected data has been deleted successfully", Properties.Resources.success);
            }
        }
    }
}
