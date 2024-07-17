using Application_Desktop.Models;
using Application_Desktop.Sub_sub_Views;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Application_Desktop.Sub_Views
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            LoadData();
            LoadSuperAdmin();
        }

        private void registerAdmin_Load(object sender, EventArgs e)
        {
        }

        //Load Super Admin Data
        private void LoadSuperAdmin()
        {
            string query = @"SELECT 
                             superadmin.SuperAdmin_ID,
                             superadmin.Name, 
                             superadmin.Email, 
                             superadmin.Password, 
                             role.RoleName AS RoleName
                             FROM superadmin
                             JOIN role ON superadmin.Role_ID = role.Role_ID";

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

                viewSuperAdminData.DataSource = null;
                viewSuperAdminData.Rows.Clear();
                viewSuperAdminData.Columns.Clear();

                viewAdminData.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn adminColumn = new DataGridViewTextBoxColumn();
                adminColumn.HeaderText = "SuperAdmin ID";
                adminColumn.Name = "SuperAdmin_ID";
                adminColumn.DataPropertyName = "SuperAdmin_ID";
                viewSuperAdminData.Columns.Add(adminColumn);

                DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
                nameColumn.HeaderText = "Name";
                nameColumn.Name = "Name";
                nameColumn.DataPropertyName = "Name";
                viewSuperAdminData.Columns.Add(nameColumn);

                DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
                emailColumn.HeaderText = "Email";
                emailColumn.Name = "Email";
                emailColumn.DataPropertyName = "Email";
                viewSuperAdminData.Columns.Add(emailColumn);

                DataGridViewTextBoxColumn passwordColumn = new DataGridViewTextBoxColumn();
                passwordColumn.HeaderText = "Password";
                passwordColumn.Name = "Password";
                passwordColumn.DataPropertyName = "Password";
                viewSuperAdminData.Columns.Add(passwordColumn);

                DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
                roleColumn.HeaderText = "Role";
                roleColumn.Name = "Role_ID";
                roleColumn.DataPropertyName = "RoleName";
                viewSuperAdminData.Columns.Add(roleColumn);


                viewSuperAdminData.DataSource = dataTable;


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

                DataGridViewImageColumn changeButtonColumn = new DataGridViewImageColumn();
                changeButtonColumn.HeaderText = "";
                changeButtonColumn.Name = "changeSuperAdmin";
                changeButtonColumn.Image = Properties.Resources.change;
                changeButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                changeButtonColumn.Width = 50;
                changeButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                viewSuperAdminData.Columns.Add(changeButtonColumn);

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

        //Load Admin Data
        private void LoadData()
        {
            string query = @"SELECT 
                             admin.Admin_ID,
                             admin.Name, 
                             admin.Email, 
                             admin.Password, 
                             branch.BranchName AS BranchName, 
                             role.RoleName AS RoleName,
                             superadmin.Name AS CreatedByName, 
                             admin.Role_ID,
                             admin.Branch_ID
                             FROM admin
                             JOIN branch ON admin.Branch_ID = branch.Branch_ID
                             JOIN superadmin ON admin.CreatedBy = superadmin.SuperAdmin_ID
                             JOIN role ON admin.Role_ID = role.Role_ID";

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

                viewAdminData.DataSource = null;
                viewAdminData.Rows.Clear();
                viewAdminData.Columns.Clear();

                viewAdminData.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn adminColumn = new DataGridViewTextBoxColumn();
                adminColumn.HeaderText = "Admin ID";
                adminColumn.Name = "Admin_ID";
                adminColumn.DataPropertyName = "Admin_ID";
                viewAdminData.Columns.Add(adminColumn);

                DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
                nameColumn.HeaderText = "Name";
                nameColumn.Name = "Name";
                nameColumn.DataPropertyName = "Name";
                viewAdminData.Columns.Add(nameColumn);

                DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
                emailColumn.HeaderText = "Email";
                emailColumn.Name = "Email";
                emailColumn.DataPropertyName = "Email";
                viewAdminData.Columns.Add(emailColumn);

                DataGridViewTextBoxColumn passwordColumn = new DataGridViewTextBoxColumn();
                passwordColumn.HeaderText = "Password";
                passwordColumn.Name = "Password";
                passwordColumn.DataPropertyName = "Password";
                viewAdminData.Columns.Add(passwordColumn);


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

                DataGridViewTextBoxColumn createdByColumn = new DataGridViewTextBoxColumn();
                createdByColumn.HeaderText = "Created By";
                createdByColumn.Name = "CreatedBy";
                createdByColumn.DataPropertyName = "CreatedByName";
                viewAdminData.Columns.Add(createdByColumn);

                viewAdminData.DataSource = dataTable;

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

                DataGridViewImageColumn changeButtonColumn = new DataGridViewImageColumn();
                changeButtonColumn.HeaderText = "";
                changeButtonColumn.Name = "change";
                changeButtonColumn.Image = Properties.Resources.change;
                changeButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                changeButtonColumn.Width = 50;
                changeButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                viewAdminData.Columns.Add(changeButtonColumn);

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Refresh Button
            LoadData();
            LoadSuperAdmin();
        }

        private editAdmin editAdminInstance;
        private adminChangePassword adminChangePassInstance;
        private void viewAdminData_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                string pwd = viewAdminData.Rows[e.RowIndex].Cells["Password"].Value?.ToString() ?? string.Empty;

                string role = viewAdminData.Rows[e.RowIndex].Cells["Role_ID"].Value?.ToString() ?? string.Empty;
                string branch = viewAdminData.Rows[e.RowIndex].Cells["Branch_ID"].Value?.ToString() ?? string.Empty;

                if (editAdminInstance == null || editAdminInstance.IsDisposed)
                {
                    editAdminInstance = new editAdmin(adminID, fname, lname, email, pwd, role, branch);
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
                    DeleteRowFromDatabase(admin_ID);
                    LoadData();
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
        }


        public int DeleteRowFromDatabase(int adminID)
        {
            string query = "Delete From admin Where Admin_ID = @adminID";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@adminID", adminID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Row deleted successfully from database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return adminID;
        }

        private void btnSuperAdminRefresh_Click(object sender, EventArgs e)
        {
            LoadSuperAdmin();
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
        private void viewSuperAdminData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
                string pwd = viewSuperAdminData.Rows[e.RowIndex].Cells["Password"].Value?.ToString() ?? string.Empty;

                string role = viewSuperAdminData.Rows[e.RowIndex].Cells["Role_ID"].Value?.ToString() ?? string.Empty;

                if (editSuperAdminInstance == null || editSuperAdminInstance.IsDisposed)
                {
                    editSuperAdminInstance = new editSuperAdmin(superAdminID, fname, lname, email, pwd, role);
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
                    DeleteSuperAdmin(superadminID);
                    LoadSuperAdmin();
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

        }

        public int DeleteSuperAdmin(int superadminID)
        {
            string query = "Delete from superadmin Where SuperAdmin_ID = @superadminID";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@superadminID", superadminID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Row deleted successfully from database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return superadminID;
        }


    }
}
