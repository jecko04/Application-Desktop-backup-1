using Application_Desktop.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Application_Desktop.Admin_Views
{
    public partial class setupStaff : Form
    {
        public setupStaff()
        {
            InitializeComponent();

            txtFetchEmployee.SelectedIndexChanged += txtFetchEmployee_SelectedIndexChanged;
        }

        private async void setupStaff_Load(object sender, EventArgs e)
        {
            SetupDataGrid();
            await LoadDentist();
            await GetDayofWeek();

        }



        private async Task GetDayofWeek()
        {
            int branchid = await GetEmployeeBranch();
            int isAvailable = 0;

            string query = @"Select DayOfWeek from office_hours where Branch_ID = @branchID AND IsClosed = @isclose";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@branchID", branchid);
                cmd.Parameters.AddWithValue("@isclose", isAvailable);

                MySqlDataReader reader = cmd.ExecuteReader();

                // Clear existing items
                txtDayofweek.Items.Clear();

                while (await reader.ReadAsync())
                {
                    // Add each title to the ComboBox
                    string name = reader["DayOfWeek"].ToString();
                    txtDayofweek.Items.Add(name);
                }

                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    await conn.CloseAsync();
                }
            }
        }
        private async Task<int> GetEmployeeBranch()
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return branchID;
        }

        private async Task LoadDentist()
        {
            int branchid = await GetEmployeeBranch();

            string query = @"Select Fullname as Type, Employee_ID as ID from employees where Branch_ID = @branchID";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@branchID", branchid);

                MySqlDataReader reader = cmd.ExecuteReader();

                // Clear existing items
                txtFetchEmployee.Items.Clear();

                while (await reader.ReadAsync())
                {
                    // Add each title to the ComboBox
                    string name = reader["Type"].ToString();
                    int id = Convert.ToInt32(reader["ID"]);

                    idValue employee = new idValue(id, name);
                    txtFetchEmployee.Items.Add(employee);
                }

                // Set DisplayMember and ValueMember after adding items
                txtFetchEmployee.DisplayMember = "Name";
                txtFetchEmployee.ValueMember = "ID";

                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    await conn.CloseAsync();
                }
            }
        }

        private async Task LoadEmployeeTimeSlot()
        {
            if (txtFetchEmployee.SelectedItem == null)
            {
                MessageBox.Show("Please select a dentist.");
                return;
            }

            // Get the selected dentist
            idValue selectedDentist = (idValue)txtFetchEmployee.SelectedItem;
            int employeeID = selectedDentist.ID;

            int branchID = await GetEmployeeBranch();
            string query = @"SELECT Employee_ID, DayOfWeek, StartTime, EndTime, IsAvailable 
                     FROM employee_availabilities 
                     WHERE Employee_ID = @employeeID AND Branch_ID = @branchID";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@branchID", branchID);
                cmd.Parameters.AddWithValue("@employeeID", employeeID);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable datatable = new DataTable();

                adapter.Fill(datatable);

                viewAvailability.DataSource = null;
                viewAvailability.Rows.Clear();
                viewAvailability.Columns.Clear();

                viewAvailability.AutoGenerateColumns = false;

                AddColumnEmployee();

                viewAvailability.DataSource = datatable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    await conn.CloseAsync();
                }
            }
        }
        private async Task<int> GetSelectedNameID()
        {
            string name = txtFetchEmployee.Text;
            int employeeid = -1;
            int branchid = await GetEmployeeBranch();

            string query = @"Select Employee_ID from employee_availabilities Where Fullname = @name AND Branch_ID = @branchid";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@branchid", branchid);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    employeeid = reader.GetInt32("Categories_ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return employeeid;
        }

        private void SetupDataGrid()
        {
            // Employee Column
            DataGridViewTextBoxColumn employeeColumn = new DataGridViewTextBoxColumn();
            employeeColumn.HeaderText = "Employee";
            employeeColumn.Name = "Employee_ID";
            employeeColumn.DataPropertyName = "Employee_ID";
            employeeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewAvailability.Columns.Add(employeeColumn);

            // DayOfWeek Column
            DataGridViewTextBoxColumn dayOfWeekColumn = new DataGridViewTextBoxColumn();
            dayOfWeekColumn.HeaderText = "Day of Week";
            dayOfWeekColumn.Name = "DayOfWeek";
            dayOfWeekColumn.DataPropertyName = "DayOfWeek";
            dayOfWeekColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewAvailability.Columns.Add(dayOfWeekColumn);

            // StartTime Column
            DataGridViewTextBoxColumn startTimeColumn = new DataGridViewTextBoxColumn();
            startTimeColumn.HeaderText = "Start Time";
            startTimeColumn.Name = "StartTime";
            startTimeColumn.DataPropertyName = "StartTime";
            startTimeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewAvailability.Columns.Add(startTimeColumn);

            // EndTime Column
            DataGridViewTextBoxColumn endTimeColumn = new DataGridViewTextBoxColumn();
            endTimeColumn.HeaderText = "End Time";
            endTimeColumn.Name = "EndTime";
            endTimeColumn.DataPropertyName = "EndTime";
            endTimeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewAvailability.Columns.Add(endTimeColumn);

            // IsAvailable Column
            DataGridViewTextBoxColumn isAvailableColumn = new DataGridViewTextBoxColumn();
            isAvailableColumn.HeaderText = "Available";
            isAvailableColumn.Name = "IsAvailable";
            isAvailableColumn.DataPropertyName = "IsAvailable";
            viewAvailability.Columns.Add(isAvailableColumn);

            // Action Column
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "Action";
            btnDelete.Name = "Remove";
            btnDelete.Text = "Remove";
            btnDelete.UseColumnTextForButtonValue = true;
            viewAvailability.Columns.Add(btnDelete);

            viewAvailability.AllowUserToAddRows = false;
            viewAvailability.AllowUserToDeleteRows = false;
        }

        private void AddColumnEmployee()
        {
            // Employee Column
            DataGridViewTextBoxColumn employeeColumn = new DataGridViewTextBoxColumn();
            employeeColumn.HeaderText = "Employee";
            employeeColumn.Name = "Employee_ID";
            employeeColumn.DataPropertyName = "Employee_ID";
            employeeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewAvailability.Columns.Add(employeeColumn);

            // DayOfWeek Column
            DataGridViewTextBoxColumn dayOfWeekColumn = new DataGridViewTextBoxColumn();
            dayOfWeekColumn.HeaderText = "Day of Week";
            dayOfWeekColumn.Name = "DayOfWeek";
            dayOfWeekColumn.DataPropertyName = "DayOfWeek";
            dayOfWeekColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewAvailability.Columns.Add(dayOfWeekColumn);

            // StartTime Column
            DataGridViewTextBoxColumn startTimeColumn = new DataGridViewTextBoxColumn();
            startTimeColumn.HeaderText = "Start Time";
            startTimeColumn.Name = "StartTime";
            startTimeColumn.DataPropertyName = "StartTime";
            startTimeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewAvailability.Columns.Add(startTimeColumn);

            // EndTime Column
            DataGridViewTextBoxColumn endTimeColumn = new DataGridViewTextBoxColumn();
            endTimeColumn.HeaderText = "End Time";
            endTimeColumn.Name = "EndTime";
            endTimeColumn.DataPropertyName = "EndTime";
            endTimeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewAvailability.Columns.Add(endTimeColumn);

            // IsAvailable Column
            DataGridViewTextBoxColumn isAvailableColumn = new DataGridViewTextBoxColumn();
            isAvailableColumn.HeaderText = "Available";
            isAvailableColumn.Name = "IsAvailable";
            isAvailableColumn.DataPropertyName = "IsAvailable";
            viewAvailability.Columns.Add(isAvailableColumn);

            // Action Column
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "Action";
            btnDelete.Name = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            viewAvailability.Columns.Add(btnDelete);

            viewAvailability.AllowUserToAddRows = false;
            viewAvailability.AllowUserToDeleteRows = false;
        }

        private void btnAddAvailability_Click(object sender, EventArgs e)
        {
            string employee = txtFetchEmployee.Text;
            string dayOfWeek = txtDayofweek.Text;
            string startTime = txtStart.Value.ToShortTimeString();
            string endTime = txtEnd.Value.ToShortTimeString();
            bool isAvailable = chkAvailable.Checked;

            // Add a new row to the DataGridView
            viewAvailability.Rows.Add(employee, dayOfWeek, startTime, endTime, isAvailable);
        }

        private async void viewAvailability_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == viewAvailability.Columns["Remove"].Index)
            {
                viewAvailability.Rows.RemoveAt(e.RowIndex);
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == viewAvailability.Columns["Delete"].Index)
            {
                // Get the Employee_ID of the selected row
                int employeeID = Convert.ToInt32(viewAvailability.Rows[e.RowIndex].Cells["Employee_ID"].Value);

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Remove from DataGridView
                    viewAvailability.Rows.RemoveAt(e.RowIndex);

                    // Remove from Database
                    await DeleteFromDatabase(employeeID);
                }
            }

        }

        private async Task DeleteFromDatabase(int employeeID)
        {
            string query = @"DELETE from employees Where Employees_ID = @employeeid";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("employeeid", employeeID);
                await cmd.ExecuteNonQueryAsync();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { await conn.CloseAsync(); }
        }

        private async Task<int> GetEmployeeID(string employeeName)
        {
            string query = "SELECT Employee_ID FROM employees WHERE Fullname = @Employee_Name";
            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Employee_Name", employeeName);

                object result = await cmd.ExecuteScalarAsync();
                return result != null ? Convert.ToInt32(result) : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                await conn.CloseAsync();
            }
        }

        private async Task InsertToDatabase()
        {
            //string employeeName = txtFetchEmployee.Text;
            //int employeeID = await GetEmployeeID(employeeName);


            int branchID = await GetEmployeeBranch();
            string dayOfWeek = txtDayofweek.Text;
            string startTime = txtStart.Value.ToShortTimeString();
            string endTime = txtEnd.Value.ToShortTimeString();
            bool isAvailable = chkAvailable.Checked;

            string query = @"
                        INSERT INTO employee_availabilities (Employee_ID, DayOfWeek, StartTime, EndTime, Branch_ID, IsAvailable, created_at, updated_at)
                        VALUES (@Employee_ID, @DayOfWeek, @StartTime, @EndTime, @Branch_ID, @IsAvailable, @createdAt, @updatedAt)
                        ON DUPLICATE KEY UPDATE 
                            StartTime = VALUES(StartTime),
                            EndTime = VALUES(EndTime),
                            IsAvailable = VALUES(IsAvailable),
                            updated_at = VALUES(updated_at);";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                foreach (DataGridViewRow row in viewAvailability.Rows)
                {
                    if (row.IsNewRow) continue;

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    if (txtFetchEmployee.SelectedItem is idValue selectedEmployee)
                    {
                        int employeeID = selectedEmployee.ID;
                        cmd.Parameters.AddWithValue("@Employee_ID", employeeID);
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid employee.");
                        return;
                    }

                    cmd.Parameters.AddWithValue("@DayOfWeek", row.Cells["DayOfWeek"].Value?.ToString());
                    cmd.Parameters.AddWithValue("@StartTime", row.Cells["StartTime"].Value?.ToString());
                    cmd.Parameters.AddWithValue("@EndTime", row.Cells["EndTime"].Value?.ToString());
                    cmd.Parameters.AddWithValue("@Branch_ID", branchID);
                    cmd.Parameters.AddWithValue("@IsAvailable", row.Cells["IsAvailable"].Value);

                    DateTime now = DateTime.Now;
                    cmd.Parameters.AddWithValue("@createdAt", now);
                    cmd.Parameters.AddWithValue("@updatedAt", now);

                    await cmd.ExecuteNonQueryAsync();
                }

                MessageBox.Show("Save successfully");
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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await InsertToDatabase();
        }

        private void btnEmployeeSched_Click(object sender, EventArgs e)
        {

        }

        private async void txtFetchEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadEmployeeTimeSlot();
        }
    }
}
