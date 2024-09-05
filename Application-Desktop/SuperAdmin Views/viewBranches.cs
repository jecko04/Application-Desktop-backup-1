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

namespace Application_Desktop.Sub_sub_Views
{
    public partial class viewBranches : Form
    {
        public viewBranches()
        {
            InitializeComponent();
            this.AcceptButton = btnSearch;

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
        private async Task LoadData()
        {
            string query = "SELECT * FROM branch";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                await Task.Run(() => adapter.Fill(dataTable));

                viewBranchData.DataSource = null;
                viewBranchData.Rows.Clear();
                viewBranchData.Columns.Clear();

                viewBranchData.AutoGenerateColumns = false;

                AddColumnBranches();

                viewBranchData.DataSource = dataTable;



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

        private async Task DeleteRowFromDatabase(int branchID)
        {
            string query = @"Delete from branch Where Branch_ID = @branchID";

            /*Delete from admin Where Branch_ID = @branchID;
            Delete from users Where Branch_ID = @branchID;*/

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("branchID", branchID);
                    await cmd.ExecuteNonQueryAsync();
                    //MessageBox.Show("Branch deleted successfully.");
                    await LoadData();
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


        private editBranch editBranchInstance;
        private async void viewBranchData_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    await DeleteRowFromDatabase(branchID);
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The branch data has been deleted successfully", Properties.Resources.success);

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

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            //refresh data
            await LoadData();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await SearchBar();
        }

        private async Task SearchBar()
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
                    await conn.OpenAsync();
                }
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchBar", $"%{searchBar}%");

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                await Task.Run(() => adapter.Fill(dataTable));

                viewBranchData.DataSource = null;
                viewBranchData.Rows.Clear();
                viewBranchData.Columns.Clear();

                viewBranchData.AutoGenerateColumns = false;

                AddColumnBranches();

                viewBranchData.DataSource = dataTable;



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

        private void AddColumnBranches()
        {
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "Branch ID";
            idColumn.Name = "Branch_ID";
            idColumn.DataPropertyName = "Branch_ID";
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewBranchData.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Branch Name";
            nameColumn.Name = "BranchName";
            nameColumn.DataPropertyName = "BranchName";
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewBranchData.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn HouseColumn = new DataGridViewTextBoxColumn();
            HouseColumn.HeaderText = "Building Number";
            HouseColumn.Name = "BuildingNumber";
            HouseColumn.DataPropertyName = "BuildingNumber";
            HouseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewBranchData.Columns.Add(HouseColumn);

            DataGridViewTextBoxColumn streetColumn = new DataGridViewTextBoxColumn();
            streetColumn.HeaderText = "Street";
            streetColumn.Name = "Street";
            streetColumn.DataPropertyName = "Street";
            streetColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewBranchData.Columns.Add(streetColumn);

            DataGridViewTextBoxColumn brgyColumn = new DataGridViewTextBoxColumn();
            brgyColumn.HeaderText = "Barangay";
            brgyColumn.Name = "Barangay";
            brgyColumn.DataPropertyName = "Barangay";
            brgyColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewBranchData.Columns.Add(brgyColumn);

            DataGridViewTextBoxColumn cityColumn = new DataGridViewTextBoxColumn();
            cityColumn.HeaderText = "City";
            cityColumn.Name = "City";
            cityColumn.DataPropertyName = "City";
            cityColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewBranchData.Columns.Add(cityColumn);

            DataGridViewTextBoxColumn provinceColumn = new DataGridViewTextBoxColumn();
            provinceColumn.HeaderText = "Province";
            provinceColumn.Name = "Province";
            provinceColumn.DataPropertyName = "Province";
            provinceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewBranchData.Columns.Add(provinceColumn);

            DataGridViewTextBoxColumn postalColumn = new DataGridViewTextBoxColumn();
            postalColumn.HeaderText = "Postal Code";
            postalColumn.Name = "PostalCode";
            postalColumn.DataPropertyName = "PostalCode";
            postalColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewBranchData.Columns.Add(postalColumn);

            DataGridViewTextBoxColumn createColumn = new DataGridViewTextBoxColumn();
            createColumn.HeaderText = "Created At";
            createColumn.Name = "created_at";
            createColumn.DataPropertyName = "created_at";
            createColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewBranchData.Columns.Add(createColumn);

            DataGridViewTextBoxColumn updateColumn = new DataGridViewTextBoxColumn();
            updateColumn.HeaderText = "Updated At";
            updateColumn.Name = "updated_at";
            updateColumn.DataPropertyName = "updated_at";
            updateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewBranchData.Columns.Add(updateColumn);


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
        private async void viewBranches_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
    }
}
