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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Application_Desktop.Admin_Sub_Views
{
    public partial class viewCategories : Form
    {
        public viewCategories()
        {
            InitializeComponent();
            LoadData();
        }

        private void viewCategories_Load(object sender, EventArgs e)
        {

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


                string query = @"SELECT 
                 categories.Categories_ID,
                 categories.Title, 
                 categories.Description, 
                 categories.Duration, 
                 categories.Frequency, 
                 admin.Name AS CreatedByName, 
                 branch.BranchName AS BranchName,
                 categories.Branch_ID,
                 categories.created_at,
                 categories.updated_at
                 FROM categories
                 JOIN branch ON categories.Branch_ID = branch.Branch_ID
                 JOIN admin ON categories.CreatedBy = admin.Admin_ID
                 WHERE categories.Branch_ID = @branchID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@branchID", branchID);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                viewCategoriesDetails.DataSource = null;
                viewCategoriesDetails.Rows.Clear();
                viewCategoriesDetails.Columns.Clear();

                viewCategoriesDetails.AutoGenerateColumns = false;

                AddcolumnForCategories();

                viewCategoriesDetails.DataSource = datatable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void AddcolumnForCategories()
        {
            /*DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
            selectColumn.HeaderText = "";
            selectColumn.Name = "selectCategories";
            selectColumn.Width = 30;
            viewCategoriesDetails.Columns.Add(selectColumn);
            viewCategoriesDetails.Columns["selectCategories"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;*/

            DataGridViewTextBoxColumn categoriesColumn = new DataGridViewTextBoxColumn();
            categoriesColumn.HeaderText = "ID";
            categoriesColumn.Name = "Categories_ID";
            categoriesColumn.DataPropertyName = "Categories_ID";
            categoriesColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewCategoriesDetails.Columns.Add(categoriesColumn);

            DataGridViewTextBoxColumn titleColumn = new DataGridViewTextBoxColumn();
            titleColumn.HeaderText = "Title";
            titleColumn.Name = "Title";
            titleColumn.DataPropertyName = "Title";
            viewCategoriesDetails.Columns.Add(titleColumn);

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.HeaderText = "Description";
            descriptionColumn.Name = "Description";
            descriptionColumn.DataPropertyName = "Description";
            descriptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            viewCategoriesDetails.Columns.Add(descriptionColumn);

            DataGridViewTextBoxColumn durationColumn = new DataGridViewTextBoxColumn();
            durationColumn.HeaderText = "Duration";
            durationColumn.Name = "Duration";
            durationColumn.DataPropertyName = "Duration";
            viewCategoriesDetails.Columns.Add(durationColumn);

            DataGridViewTextBoxColumn frequencyColumn = new DataGridViewTextBoxColumn();
            frequencyColumn.HeaderText = "Frequency";
            frequencyColumn.Name = "Frequency";
            frequencyColumn.DataPropertyName = "Frequency";
            frequencyColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            viewCategoriesDetails.Columns.Add(frequencyColumn);


            DataGridViewTextBoxColumn branchColumn = new DataGridViewTextBoxColumn();
            branchColumn.HeaderText = "Branch";
            branchColumn.Name = "Branch_ID";
            branchColumn.DataPropertyName = "BranchName";
            viewCategoriesDetails.Columns.Add(branchColumn);

            DataGridViewTextBoxColumn createdByColumn = new DataGridViewTextBoxColumn();
            createdByColumn.HeaderText = "Created By";
            createdByColumn.Name = "CreatedBy";
            createdByColumn.DataPropertyName = "CreatedByName";
            viewCategoriesDetails.Columns.Add(createdByColumn);

            DataGridViewTextBoxColumn createdAtColumn = new DataGridViewTextBoxColumn();
            createdAtColumn.HeaderText = "Created At";
            createdAtColumn.Name = "created_at";
            createdAtColumn.DataPropertyName = "created_at";
            viewCategoriesDetails.Columns.Add(createdAtColumn);

            DataGridViewTextBoxColumn updatedAtColumn = new DataGridViewTextBoxColumn();
            updatedAtColumn.HeaderText = "Updated At";
            updatedAtColumn.Name = "updated_at";
            updatedAtColumn.DataPropertyName = "updated_at";
            viewCategoriesDetails.Columns.Add(updatedAtColumn);

            DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Name = "delete";
            deleteButtonColumn.Image = Properties.Resources.delete_img;
            deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            deleteButtonColumn.Width = 50;
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            viewCategoriesDetails.Columns.Add(deleteButtonColumn);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewCategoriesDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //delete
            if (e.RowIndex >= 0 && e.ColumnIndex == viewCategoriesDetails.Columns["delete"].Index)
            {
                DialogResult result = MessageBox.Show("Would you like to proceed with deleting this category?", "Confirm Deletions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int categoriesID = Convert.ToInt32(viewCategoriesDetails.Rows[e.RowIndex].Cells["Categories_ID"].Value);

                    // Delete row from database
                    DeleteFromDatabase(categoriesID);
                    LoadData();
                }
            }

            //Select Check Box
            /*if (e.ColumnIndex == viewCategoriesDetails.Columns["selectCategories"].Index)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)viewCategoriesDetails.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Value = !(cell.Value is bool && (bool)cell.Value); // Toggle checkbox value
            }*/
        }

        private void DeleteFromDatabase(int categoriesID)
        {
            string query = @"DELETE from categories Where Categories_ID = @categoriesId";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("categoriesId", categoriesID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("The item has been successfully deleted.",
                                "Delete Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }


        //not use yet baka sa susunod lmao
        private void DeleteSelected()
        {
            bool hasSelectedRows = false;
            var result = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                viewCategoriesDetails.EndEdit();

                // Deleting from viewDentalDoctorAccount
                for (int i = viewCategoriesDetails.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = viewCategoriesDetails.Rows[i];
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["selectCategories"] as DataGridViewCheckBoxCell;

                    // Check if the checkbox is checked
                    if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                    {
                        hasSelectedRows = true;
                        // Get the ID of the doctor to delete
                        int categoriesID = Convert.ToInt32(row.Cells["Categories_ID"].Value);
                        viewCategoriesDetails.Rows.RemoveAt(i);
                        DeleteFromDatabase(categoriesID);
                    }
                }

                // If no rows were selected, show a message box
                if (!hasSelectedRows)
                {
                    MessageBox.Show("No rows were selected for deletion.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
