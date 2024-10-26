using Application_Desktop.Controller;
using Application_Desktop.Method;
using Application_Desktop.Models;
using Application_Desktop.Screen;
using Application_Desktop.Sub_sub_Views;
using Application_Desktop.SuperAdmin_Sub_Views;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Application_Desktop.Models.EllipseManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Application_Desktop.Sub_Views
{
    //super admin 800, 282 + 30
    //admin 800, 313 + 30
    public partial class admin : Form
    {
        private accessAccountController _accessAccountController;
        public admin()
        {
            _accessAccountController = new accessAccountController();
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

        private async void registerAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadData();
                await LoadSuperAdmin();
                await LoadAccessAcc();

                DataTable accesslogs = await _accessAccountController.FetchAccessLogs();

                if (accesslogs != null && accesslogs.Rows.Count > 0)
                {
                    AddColumnAccessLogs(viewAccessLogs);
                    viewAccessLogs.DataSource = accesslogs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
        }

        private void AddColumnAccessLogs(DataGridView viewAccessLogs)
        {
            viewAccessLogs.RowHeadersVisible = false;
            viewAccessLogs.ColumnHeadersHeight = 40;

            DataGridViewTextBoxColumn Id = new DataGridViewTextBoxColumn();
            Id.HeaderText = "ID";
            Id.Name = "id";
            Id.DataPropertyName = "id";
            viewAccessLogs.Columns.Add(Id);

            DataGridViewTextBoxColumn username = new DataGridViewTextBoxColumn();
            username.HeaderText = "Username";
            username.Name = "username";
            username.DataPropertyName = "username";
            username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewAccessLogs.Columns.Add(username);

            DataGridViewTextBoxColumn branchid = new DataGridViewTextBoxColumn();
            branchid.HeaderText = "Branch Name";
            branchid.Name = "branchId";
            branchid.DataPropertyName = "BranchName";
            branchid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewAccessLogs.Columns.Add(branchid);

            DataGridViewTextBoxColumn loginTime = new DataGridViewTextBoxColumn();
            loginTime.HeaderText = "Login Time";
            loginTime.Name = "loginTime";
            loginTime.DataPropertyName = "login_time";
            viewAccessLogs.Columns.Add(loginTime);

            DataGridViewTextBoxColumn successful = new DataGridViewTextBoxColumn();
            successful.HeaderText = "Successfull";
            successful.Name = "successful";
            successful.DataPropertyName = "successful";
            successful.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewAccessLogs.Columns.Add(successful);

            DataGridViewTextBoxColumn ipAddress = new DataGridViewTextBoxColumn();
            ipAddress.HeaderText = "Ip Address";
            ipAddress.Name = "ipAddress";
            ipAddress.DataPropertyName = "ip_address";
            ipAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewAccessLogs.Columns.Add(ipAddress);
        }

        //Load Super Admin Data
        private async Task LoadSuperAdmin()
        {
            string query = @"SELECT 
                             superadmin.SuperAdmin_ID,
                             superadmin.Name, 
                             superadmin.Email, 
                             role.RoleName AS RoleName,
                             superadmin.created_at,
                             superadmin.updated_at

                             FROM superadmin
                             JOIN role ON superadmin.Role_ID = role.Role_ID";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                viewSuperAdminData.DataSource = null;
                viewSuperAdminData.Rows.Clear();
                viewSuperAdminData.Columns.Clear();

                viewAdminData.AutoGenerateColumns = false;

                AddColumnSuperAdmin();


                viewSuperAdminData.DataSource = dataTable;



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

        //Load Admin Data
        private async Task LoadData()
        {
            string query = @"SELECT 
                             admin.Admin_ID,
                             admin.Name, 
                             admin.Email, 
                             branch.BranchName AS BranchName, 
                             role.RoleName AS RoleName,
                             admin.created_at,
                             admin.updated_at,
                             admin.Role_ID,
                             admin.Branch_ID
                             FROM admin
                             JOIN branch ON admin.Branch_ID = branch.Branch_ID
                             JOIN role ON admin.Role_ID = role.Role_ID";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                viewAdminData.DataSource = null;
                viewAdminData.Rows.Clear();
                viewAdminData.Columns.Clear();

                viewAdminData.AutoGenerateColumns = false;

                AddColumnAdmin();

                viewAdminData.DataSource = dataTable;



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

        private async Task LoadAccessAcc()
        {
            string query = @"SELECT 
                             access_id,
                             Admin_ID,
                             email, 
                             username, 
                             Branch_ID
                             FROM access_account";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                viewAccessAccount.DataSource = null;
                viewAccessAccount.Rows.Clear();
                viewAccessAccount.Columns.Clear();

                viewAccessAccount.AutoGenerateColumns = false;

                AddColumnAcessAcc();

                viewAccessAccount.DataSource = dataTable;



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

        private registerAdmin registerAdminInstance;
        private void btnNewAdmin_Click_1(object sender, EventArgs e)
        {
            if (registerAdminInstance == null || registerAdminInstance.IsDisposed)
            {
                registerAdminInstance = new registerAdmin();
                registerAdminInstance.Show();
            }
            else
            {
                if (registerAdminInstance.Visible)
                {
                    registerAdminInstance.BringToFront();
                }
                else
                {
                    registerAdminInstance.Show();
                }
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            //Refresh Button
            await LoadData();
            await LoadSuperAdmin();
            await LoadAccessAcc();

            try
            {
                viewAccessLogs.DataSource = null;
                viewAccessLogs.Columns.Clear();

                DataTable accessLogs = await _accessAccountController.FetchAccessLogs();

                if (accessLogs != null && accessLogs.Rows.Count > 0)
                {
                    AddColumnAccessLogs(viewAccessLogs);

                    viewAccessLogs.DataSource = accessLogs;
                }
                else
                {
                    MessageBox.Show("No access logs found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while refreshing data: {ex.Message}");
            }

        }


        private bool isProcessingClick = false;
        private editAdmin editAdminInstance;
        private adminChangePassword adminChangePassInstance;
        private async void viewAdminData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //update
            if (viewAdminData.Columns["edit"] != null &&
        e.ColumnIndex == viewAdminData.Columns["edit"].Index && e.RowIndex >= 0)
            {

                int adminID = Convert.ToInt32(viewAdminData.Rows[e.RowIndex].Cells["Admin_ID"].Value);
                string fullname = viewAdminData.Rows[e.RowIndex].Cells["Name"].Value?.ToString() ?? string.Empty;
                string[] nameParts = fullname.Split(new char[] { ' ' }, 2);
                string fname = nameParts[0];
                string lname = nameParts.Length > 1 ? nameParts[1] : string.Empty;

                string email = viewAdminData.Rows[e.RowIndex].Cells["Email"].Value?.ToString() ?? string.Empty;

                string role = viewAdminData.Rows[e.RowIndex].Cells["Role_ID"].Value?.ToString() ?? string.Empty;
                string branch = viewAdminData.Rows[e.RowIndex].Cells["Branch_ID"].Value?.ToString() ?? string.Empty;

                if (editAdminInstance == null || editAdminInstance.IsDisposed)
                {
                    editAdminInstance = new editAdmin(adminID, fname, lname, email, role, branch);
                    editAdminInstance.Show();
                }
                else
                {
                    if (editAdminInstance.Visible)
                    {
                        editAdminInstance.BringToFront();
                    }
                    else
                    {
                        editAdminInstance.Show();
                    }
                }
            }

            //delete
            if (e.RowIndex >= 0 && e.ColumnIndex == viewAdminData.Columns["delete"].Index)
            {
                DialogResult result = MessageBox.Show("Would you like to proceed with deleting this account?", "Confirm Deletions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int admin_ID = Convert.ToInt32(viewAdminData.Rows[e.RowIndex].Cells["Admin_ID"].Value);

                    // Delete row from database
                    await DeleteRowFromDatabase(admin_ID);
                    await LoadData();
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The data has been deleted successfully", Properties.Resources.success);
                }
            }

            //change password
            if (viewAdminData.Columns["change"] != null &&
        e.ColumnIndex == viewAdminData.Columns["change"].Index && e.RowIndex >= 0)
            {

                int adminID = Convert.ToInt32(viewAdminData.Rows[e.RowIndex].Cells["Admin_ID"].Value);

                if (adminChangePassInstance == null || adminChangePassInstance.IsDisposed)
                {
                    adminChangePassInstance = new adminChangePassword(adminID);
                    adminChangePassInstance.Show();
                }
                else
                {
                    if (adminChangePassInstance.Visible)
                    {
                        adminChangePassInstance.BringToFront();
                    }
                    else
                    {
                        adminChangePassInstance.Show();
                    }
                }
            }

            //Select Check Box

            if (isProcessingClick) return; // Ignore the click if already processing

            isProcessingClick = true;

            try
            {
                // Your checkbox toggle logic here
                if (e.ColumnIndex == viewAdminData.Columns["selectAdmin"].Index)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)viewAdminData.Rows[e.RowIndex].Cells[e.ColumnIndex];
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


        public async Task<int> DeleteRowFromDatabase(int adminID)
        {
            string query = "Delete From admin Where Admin_ID = @adminID";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@adminID", adminID);
                    await cmd.ExecuteNonQueryAsync();
                    await transaction.CommitAsync();
                }
                catch (Exception transEx)
                {
                    // Rollback the transaction in case of an error
                    await transaction.RollbackAsync();
                    MessageBox.Show("Transaction failed: " + transEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { await conn.CloseAsync(); }
            return adminID;
        }



        private registerSuperAdmin superAdminInstance;
        private void btnNewSuperAdmin_Click(object sender, EventArgs e)
        {
            if (superAdminInstance == null || superAdminInstance.IsDisposed)
            {
                superAdminInstance = new registerSuperAdmin();
                superAdminInstance.Show();
            }
            else
            {
                if (superAdminInstance.Visible)
                {
                    superAdminInstance.BringToFront();
                }
                else
                {
                    superAdminInstance.Show();
                }
            }
        }


        private superadminChangePass changeSuperAdminPassInstance;
        private editSuperAdmin editSuperAdminInstance;
        private async void viewSuperAdminData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //update
            if (viewSuperAdminData.Columns["editSuperAdmin"] != null &&
        e.ColumnIndex == viewSuperAdminData.Columns["editSuperAdmin"].Index && e.RowIndex >= 0)
            {
                int superAdminID = Convert.ToInt32(viewSuperAdminData.Rows[e.RowIndex].Cells["SuperAdmin_ID"].Value);
                string fullname = viewSuperAdminData.Rows[e.RowIndex].Cells["Name"].Value?.ToString() ?? string.Empty;
                string[] nameParts = fullname.Split(new char[] { ' ' }, 2);
                string fname = nameParts[0];
                string lname = nameParts.Length > 1 ? nameParts[1] : string.Empty;
                string email = viewSuperAdminData.Rows[e.RowIndex].Cells["Email"].Value?.ToString() ?? string.Empty;

                string role = viewSuperAdminData.Rows[e.RowIndex].Cells["Role_ID"].Value?.ToString() ?? string.Empty;

                if (editSuperAdminInstance == null || editSuperAdminInstance.IsDisposed)
                {
                    editSuperAdminInstance = new editSuperAdmin(superAdminID, fname, lname, email, role);
                    editSuperAdminInstance.Show();
                }
                else
                {
                    if (editSuperAdminInstance.Visible)
                    {
                        editSuperAdminInstance.BringToFront();
                    }
                    else
                    {
                        editSuperAdminInstance.Show();
                    }
                }
            }

            //delete
            if (e.RowIndex >= 0 && e.ColumnIndex == viewSuperAdminData.Columns["deleteSuperAdmin"].Index)
            {
                DialogResult result = MessageBox.Show("Would you like to proceed with deleting this account?", "Confirm Deletions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int superadminID = Convert.ToInt32(viewSuperAdminData.Rows[e.RowIndex].Cells["SuperAdmin_ID"].Value);

                    // Delete row from database
                    await DeleteSuperAdmin(superadminID);
                    await LoadSuperAdmin();
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The data has been deleted successfully", Properties.Resources.success);
                }
            }

            //change password
            if (viewSuperAdminData.Columns["changeSuperAdmin"] != null &&
        e.ColumnIndex == viewSuperAdminData.Columns["changeSuperAdmin"].Index && e.RowIndex >= 0)
            {

                int superadminID = Convert.ToInt32(viewSuperAdminData.Rows[e.RowIndex].Cells["SuperAdmin_ID"].Value);

                if (changeSuperAdminPassInstance == null || changeSuperAdminPassInstance.IsDisposed)
                {
                    changeSuperAdminPassInstance = new superadminChangePass(superadminID);
                    changeSuperAdminPassInstance.Show();
                }
                else
                {
                    if (changeSuperAdminPassInstance.Visible)
                    {
                        changeSuperAdminPassInstance.BringToFront();
                    }
                    else
                    {
                        changeSuperAdminPassInstance.Show();
                    }
                }
            }

            //Select Check Box
            if (isProcessingClick) return; // Ignore the click if already processing

            isProcessingClick = true;

            try
            {
                // Your checkbox toggle logic here
                if (e.ColumnIndex == viewSuperAdminData.Columns["selectSuperAdmin"].Index)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)viewSuperAdminData.Rows[e.RowIndex].Cells[e.ColumnIndex];
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

        //Delete
        public async Task<int> DeleteSuperAdmin(int superadminID)
        {
            string query = "Delete from superadmin Where SuperAdmin_ID = @superadminID";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@superadminID", superadminID);
                    await cmd.ExecuteNonQueryAsync();

                    await transaction.CommitAsync();
                }
                catch (Exception transEx)
                {
                    // Rollback the transaction in case of an error
                    await transaction.RollbackAsync();
                    MessageBox.Show("Transaction failed: " + transEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { await conn.CloseAsync(); }
            return superadminID;
        }

        //Add Column
        private void AddColumnSuperAdmin()
        {

            viewSuperAdminData.RowHeadersVisible = false;
            viewSuperAdminData.ColumnHeadersHeight = 40;

            DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
            selectColumn.HeaderText = "";
            selectColumn.Name = "selectSuperAdmin";
            selectColumn.Width = 30;
            viewSuperAdminData.Columns.Add(selectColumn);
            viewSuperAdminData.Columns["selectSuperAdmin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewTextBoxColumn adminColumn = new DataGridViewTextBoxColumn();
            adminColumn.HeaderText = "ID";
            adminColumn.Name = "SuperAdmin_ID";
            adminColumn.DataPropertyName = "SuperAdmin_ID";
            viewSuperAdminData.Columns.Add(adminColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "Name";
            nameColumn.DataPropertyName = "Name";
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewSuperAdminData.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.HeaderText = "Email";
            emailColumn.Name = "Email";
            emailColumn.DataPropertyName = "Email";
            emailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewSuperAdminData.Columns.Add(emailColumn);

            DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
            roleColumn.HeaderText = "Role";
            roleColumn.Name = "Role_ID";
            roleColumn.DataPropertyName = "RoleName";
            viewSuperAdminData.Columns.Add(roleColumn);

            DataGridViewTextBoxColumn createdSuperAdmin = new DataGridViewTextBoxColumn();
            createdSuperAdmin.HeaderText = "Created At";
            createdSuperAdmin.Name = "created_at";
            createdSuperAdmin.DataPropertyName = "created_at";
            createdSuperAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewSuperAdminData.Columns.Add(createdSuperAdmin);

            DataGridViewTextBoxColumn updatedSuperAdmin = new DataGridViewTextBoxColumn();
            updatedSuperAdmin.HeaderText = "Updated At";
            updatedSuperAdmin.Name = "updated_at";
            updatedSuperAdmin.DataPropertyName = "updated_at";
            updatedSuperAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewSuperAdminData.Columns.Add(updatedSuperAdmin);

            DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn();
            editButtonColumn.HeaderText = "";
            editButtonColumn.Name = "editSuperAdmin";
            editButtonColumn.Image = Properties.Resources.edit_img;
            editButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editButtonColumn.Width = 50;
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            viewSuperAdminData.Columns.Add(editButtonColumn);

            DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Name = "deleteSuperAdmin";
            deleteButtonColumn.Image = Properties.Resources.delete_img;
            deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            deleteButtonColumn.Width = 50;
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            viewSuperAdminData.Columns.Add(deleteButtonColumn);
        }

        private void AddColumnAdmin()
        {
            viewAdminData.RowHeadersVisible = false;
            viewAdminData.ColumnHeadersHeight = 40;

            DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
            selectColumn.HeaderText = "";
            selectColumn.Name = "selectAdmin";
            selectColumn.Width = 30;
            viewAdminData.Columns.Add(selectColumn);
            viewAdminData.Columns["selectAdmin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewTextBoxColumn adminColumn = new DataGridViewTextBoxColumn();
            adminColumn.HeaderText = "ID";
            adminColumn.Name = "Admin_ID";
            adminColumn.DataPropertyName = "Admin_ID";
            viewAdminData.Columns.Add(adminColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "Name";
            nameColumn.DataPropertyName = "Name";
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewAdminData.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.HeaderText = "Email";
            emailColumn.Name = "Email";
            emailColumn.DataPropertyName = "Email";
            emailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewAdminData.Columns.Add(emailColumn);

            DataGridViewTextBoxColumn branchColumn = new DataGridViewTextBoxColumn();
            branchColumn.HeaderText = "Branch";
            branchColumn.Name = "Branch_ID";
            branchColumn.DataPropertyName = "BranchName";
            viewAdminData.Columns.Add(branchColumn);

            DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
            roleColumn.HeaderText = "Role";
            roleColumn.Name = "Role_ID";
            roleColumn.DataPropertyName = "RoleName";
            viewAdminData.Columns.Add(roleColumn);

            DataGridViewTextBoxColumn createdAdmin = new DataGridViewTextBoxColumn();
            createdAdmin.HeaderText = "Created At";
            createdAdmin.Name = "created_at";
            createdAdmin.DataPropertyName = "created_at";
            createdAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewAdminData.Columns.Add(createdAdmin);

            DataGridViewTextBoxColumn updatedAdmin = new DataGridViewTextBoxColumn();
            updatedAdmin.HeaderText = "Updated At";
            updatedAdmin.Name = "updated_at";
            updatedAdmin.DataPropertyName = "updated_at";
            updatedAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewAdminData.Columns.Add(updatedAdmin);

            DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn();
            editButtonColumn.HeaderText = "";
            editButtonColumn.Name = "edit";
            editButtonColumn.Image = Properties.Resources.edit_img;
            editButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editButtonColumn.Width = 50;
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            viewAdminData.Columns.Add(editButtonColumn);

            DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Name = "delete";
            deleteButtonColumn.Image = Properties.Resources.delete_img;
            deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            deleteButtonColumn.Width = 50;
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            viewAdminData.Columns.Add(deleteButtonColumn);
        }






        private async void btnDelete_Click(object sender, EventArgs e)
        {
            bool hasSelectedRows = false;
            var result = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                viewSuperAdminData.EndEdit();
                viewAdminData.EndEdit();

                // Deleting from viewSuperAdminData
                for (int i = viewSuperAdminData.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = viewSuperAdminData.Rows[i];
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["selectSuperAdmin"] as DataGridViewCheckBoxCell;

                    // Check if the checkbox is checked
                    if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                    {
                        hasSelectedRows = true;
                        // Get the ID of the superadmin to delete
                        int superadminID = Convert.ToInt32(row.Cells["SuperAdmin_ID"].Value);
                        viewSuperAdminData.Rows.RemoveAt(i);
                        await DeleteSuperAdmin(superadminID);
                    }
                }

                // Deleting from viewAdminData
                for (int i = viewAdminData.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = viewAdminData.Rows[i];
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["selectAdmin"] as DataGridViewCheckBoxCell;

                    // Check if the checkbox is checked
                    if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                    {
                        hasSelectedRows = true;
                        // Get the ID of the admin to delete
                        int adminID = Convert.ToInt32(row.Cells["Admin_ID"].Value);
                        viewAdminData.Rows.RemoveAt(i);
                        await DeleteRowFromDatabase(adminID);
                    }
                }

                for (int i = viewAccessAccount.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = viewAccessAccount.Rows[i];
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["selectAccessAcc"] as DataGridViewCheckBoxCell;

                    // Check if the checkbox is checked
                    if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                    {
                        hasSelectedRows = true;
                        // Get the ID of the admin to delete
                        int accessacc = Convert.ToInt32(row.Cells["access_id"].Value);
                        viewAccessAccount.Rows.RemoveAt(i);
                        await DeleteAccessAcc(accessacc);
                    }
                }

                // If no rows were selected, show a message box
                if (hasSelectedRows)
                {
                    //MessageBox.Show("No rows were selected for deletion.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The Selected rows were deleted successfully", Properties.Resources.success);
                }
                else
                {
                    AlertBox(Color.LightSteelBlue, Color.DodgerBlue, "No rows selected", "No rows were selected for deletion", Properties.Resources.information);

                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private registerAccessAccount RegisterAccessAccountInstance;
        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (RegisterAccessAccountInstance == null || RegisterAccessAccountInstance.IsDisposed)
            {
                RegisterAccessAccountInstance = new registerAccessAccount();
                RegisterAccessAccountInstance.Show();
            }
            else
            {
                if (RegisterAccessAccountInstance.Visible)
                {
                    RegisterAccessAccountInstance.BringToFront();
                }
                else
                {
                    RegisterAccessAccountInstance.Show();
                }
            }
        }

        private void viewAccessAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private async void viewPatientRecordAccessAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //delete
            if (e.RowIndex >= 0 && e.ColumnIndex == viewAccessAccount.Columns["deleteAccess"].Index)
            {
                DialogResult result = MessageBox.Show("Would you like to proceed with deleting this account?", "Confirm Deletions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int accessAcc = Convert.ToInt32(viewAccessAccount.Rows[e.RowIndex].Cells["access_id"].Value);

                    // Delete row from database
                    await DeleteAccessAcc(accessAcc);
                    await LoadAccessAcc();
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The data has been deleted successfully", Properties.Resources.success);
                }
            }

            //Select Check Box
            if (isProcessingClick) return; // Ignore the click if already processing

            isProcessingClick = true;

            try
            {
                // Your checkbox toggle logic here
                if (e.ColumnIndex == viewAccessAccount.Columns["selectAccessAcc"].Index)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)viewAccessAccount.Rows[e.RowIndex].Cells[e.ColumnIndex];
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

        private void AddColumnAcessAcc()
        {
            viewAccessAccount.RowHeadersVisible = false;
            viewAccessAccount.ColumnHeadersHeight = 40;

            DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
            selectColumn.HeaderText = "";
            selectColumn.Name = "selectAccessAcc";
            selectColumn.Width = 30;
            viewAccessAccount.Columns.Add(selectColumn);
            viewAccessAccount.Columns["selectAccessAcc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewTextBoxColumn accessColumn = new DataGridViewTextBoxColumn();
            accessColumn.HeaderText = "ID";
            accessColumn.Name = "access_id";
            accessColumn.DataPropertyName = "access_id";
            viewAccessAccount.Columns.Add(accessColumn);

            DataGridViewTextBoxColumn adminColumn = new DataGridViewTextBoxColumn();
            adminColumn.HeaderText = "ID";
            adminColumn.Name = "Admin_ID";
            adminColumn.DataPropertyName = "Admin_ID";
            viewAccessAccount.Columns.Add(adminColumn);

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.HeaderText = "Email";
            emailColumn.Name = "email";
            emailColumn.DataPropertyName = "email";
            emailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewAccessAccount.Columns.Add(emailColumn);

            DataGridViewTextBoxColumn Username = new DataGridViewTextBoxColumn();
            Username.HeaderText = "Username";
            Username.Name = "username";
            Username.DataPropertyName = "username";
            viewAccessAccount.Columns.Add(Username);

            DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
            roleColumn.HeaderText = "Branch";
            roleColumn.Name = "Branch_ID";
            roleColumn.DataPropertyName = "Branch_ID";
            viewAccessAccount.Columns.Add(roleColumn);

            DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Name = "deleteAccess";
            deleteButtonColumn.Image = Properties.Resources.delete_img;
            deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            deleteButtonColumn.Width = 50;
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            viewAccessAccount.Columns.Add(deleteButtonColumn);
        }

        public async Task<int> DeleteAccessAcc(int accessAccount)
        {
            string query = "Delete from access_account Where access_id = @accessAccount";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@accessAccount", accessAccount);
                    await cmd.ExecuteNonQueryAsync();

                    await transaction.CommitAsync();
                }
                catch (Exception transEx)
                {
                    // Rollback the transaction in case of an error
                    await transaction.RollbackAsync();
                    MessageBox.Show("Transaction failed: " + transEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { await conn.CloseAsync(); }
            return accessAccount;
        }
    }
}
