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

namespace Application_Desktop.Sub_sub_Views
{
    public partial class viewBranches : Form
    {
        public viewBranches()
        {
            InitializeComponent();
            this.AcceptButton = btnSearch;
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM branch";

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

                viewBranchData.DataSource = null;
                viewBranchData.Rows.Clear();
                viewBranchData.Columns.Clear();

                viewBranchData.DataSource = dataTable;

                DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn();
                editButtonColumn.HeaderText = "";
                editButtonColumn.Name = "edit";
                editButtonColumn.Image = Properties.Resources.edit_img;
                editButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                editButtonColumn.Width = 50;
                editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                viewBranchData.Columns.Add(editButtonColumn);

                DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn();
                deleteButtonColumn.HeaderText = "";
                deleteButtonColumn.Name = "delete";
                deleteButtonColumn.Image = Properties.Resources.delete_img;
                deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                deleteButtonColumn.Width = 50;
                deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                viewBranchData.Columns.Add(deleteButtonColumn);

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

        private void DeleteRowFromDatabase(int branchID)
        {
            string query = @"Delete from branch Where Branch_ID = @branchID;
                Delete from admin Where Branch_ID = @branchID;
                Delete from users Where Branch_ID = @branchID;";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BranchID", branchID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Branch deleted successfully.");
                LoadData();

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

        private editBranch editBranchInstance;
        private void viewBranchData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //update
            if (viewBranchData.Columns["edit"] != null &&
        e.ColumnIndex == viewBranchData.Columns["edit"].Index && e.RowIndex >= 0)
            {
                // Retrieve data from the selected row with null checks
                int branchID = Convert.ToInt32(viewBranchData.Rows[e.RowIndex].Cells["Branch_ID"].Value);
                string bname = viewBranchData.Rows[e.RowIndex].Cells["BranchName"].Value?.ToString() ?? string.Empty;
                string bnum = viewBranchData.Rows[e.RowIndex].Cells["BuildingNumber"].Value?.ToString() ?? string.Empty;
                string street = viewBranchData.Rows[e.RowIndex].Cells["Street"].Value?.ToString() ?? string.Empty;
                string brgy = viewBranchData.Rows[e.RowIndex].Cells["Barangay"].Value?.ToString() ?? string.Empty;
                string city = viewBranchData.Rows[e.RowIndex].Cells["City"].Value?.ToString() ?? string.Empty;
                string province = viewBranchData.Rows[e.RowIndex].Cells["Province"].Value?.ToString() ?? string.Empty;
                string postal = viewBranchData.Rows[e.RowIndex].Cells["PostalCode"].Value?.ToString() ?? string.Empty;

                if (editBranchInstance == null || editBranchInstance.IsDisposed)
                {
                    editBranchInstance = new editBranch(branchID, bname, bnum, street, brgy, city, province, postal);
                    editBranchInstance.Show();
                }
                else
                {
                    if (editBranchInstance.Visible)
                    {
                        editBranchInstance.BringToFront();
                    }
                    else
                    {
                        editBranchInstance.Show();
                    }
                }
            }

            //delete
            if (e.RowIndex >= 0 && e.ColumnIndex == viewBranchData.Columns["delete"].Index)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this branch? This will also delete all related admin and user accounts.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int branchID = Convert.ToInt32(viewBranchData.Rows[e.RowIndex].Cells["Branch_ID"].Value);

                    // Delete row from database
                    DeleteRowFromDatabase(branchID);
                }
            }
        }

        private registerBranches registerBranchInstance;

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            if (registerBranchInstance == null || registerBranchInstance.IsDisposed)
            {
                registerBranchInstance = new registerBranches();
                registerBranchInstance.Show();
            }
            else
            {
                if (registerBranchInstance.Visible)
                {
                    registerBranchInstance.BringToFront();
                }
                else
                {
                    registerBranchInstance.Show();
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //refresh data
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchBar = txtSearchBox.Text;

            string query = "SELECT Branch_ID, BranchName, BuildingNumber, Street, Barangay, City, Province, PostalCode " +
                   "FROM branch " +
                   "WHERE Branch_ID LIKE @searchBar OR " +
                   "BranchName LIKE @searchBar OR " +
                   "BuildingNumber LIKE @searchBar OR " +
                   "Street LIKE @searchBar OR " +
                   "Barangay LIKE @searchBar OR " +
                   "City LIKE @searchBar OR " +
                   "Province LIKE @searchBar OR " +
                   "PostalCode LIKE @searchBar";
            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchBar", $"%{searchBar}%");

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                viewBranchData.DataSource = dataTable;

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
    }
}
