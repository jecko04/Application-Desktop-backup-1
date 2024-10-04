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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Application_Desktop.Admin_Sub_Views
{
    public partial class viewCategories : Form
    {
        public viewCategories()
        {
            InitializeComponent();

        }

        private async void viewCategories_Load(object sender, EventArgs e)
        {
            await LoadData();
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
                if (await branchIDReader.ReadAsync())
                {
                    branchID = Convert.ToInt32(branchIDReader["Branch_ID"]);
                }
                await branchIDReader.CloseAsync();

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
                 categories.Price,
                 categories.required_med_history,
                 categories.required_dent_history,
                 branch.BranchName AS BranchName,
                 categories.Branch_ID,
                 categories.created_at,
                 categories.updated_at
                 FROM categories
                 JOIN branch ON categories.Branch_ID = branch.Branch_ID
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
            finally { await conn.CloseAsync(); }
        }

        private void AddcolumnForCategories()
        {

            DataGridViewTextBoxColumn categoriesColumn = new DataGridViewTextBoxColumn();
            categoriesColumn.HeaderText = "ID";
            categoriesColumn.Name = "Categories_ID";
            categoriesColumn.DataPropertyName = "Categories_ID";
            categoriesColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

            DataGridViewTextBoxColumn price = new DataGridViewTextBoxColumn();
            price.HeaderText = "Price";
            price.Name = "Price";
            price.DataPropertyName = "Price";
            viewCategoriesDetails.Columns.Add(price);

            DataGridViewTextBoxColumn requiredMed = new DataGridViewTextBoxColumn();
            requiredMed.HeaderText = "Required Medical History";
            requiredMed.Name = "required_med_history";
            requiredMed.DataPropertyName = "required_med_history";
            viewCategoriesDetails.Columns.Add(requiredMed);

            DataGridViewTextBoxColumn requiredDent = new DataGridViewTextBoxColumn();
            requiredDent.HeaderText = "Required Dental History";
            requiredDent.Name = "required_dent_history";
            requiredDent.DataPropertyName = "required_dent_history";
            viewCategoriesDetails.Columns.Add(requiredDent);

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

        private async void viewCategoriesDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //delete
            if (e.RowIndex >= 0 && e.ColumnIndex == viewCategoriesDetails.Columns["delete"].Index)
            {
                DialogResult result = MessageBox.Show("Would you like to proceed with deleting this category?", "Confirm Deletions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int categoriesID = Convert.ToInt32(viewCategoriesDetails.Rows[e.RowIndex].Cells["Categories_ID"].Value);

                    // Delete row from database
                    await DeleteFromDatabase(categoriesID);
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The item has been deleted successfully", Properties.Resources.success);
                    await LoadData();
                }
            }

            //Select Check Box
            /*if (e.ColumnIndex == viewCategoriesDetails.Columns["selectCategories"].Index)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)viewCategoriesDetails.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Value = !(cell.Value is bool && (bool)cell.Value); // Toggle checkbox value
            }*/
        }

        private async Task DeleteFromDatabase(int categoriesID)
        {
            string query = @"DELETE from categories Where Categories_ID = @categoriesId";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("categoriesId", categoriesID);
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
