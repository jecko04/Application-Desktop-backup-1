using Application_Desktop.Admin_Sub_Views;
using Application_Desktop.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Desktop.Admin_Views
{
    public partial class setupAppointmentTypes : Form
    {
        public setupAppointmentTypes()
        {
            InitializeComponent();

            int margin = 27;
            lineDevider.AutoSize = false; // Disable automatic sizing
            lineDevider.Height = 3; // Thickness of the line
            lineDevider.Width = this.panel2.Width - 2 * margin; // Full width of the form
            lineDevider.BackColor = Color.DimGray; // Line color
            lineDevider.BorderStyle = BorderStyle.None; // No border

            lineDevider.Left = 19;
        }

        private void setupAppointmentTypes_Load(object sender, EventArgs e)
        {
            GetTitle();
        }

        private int GetBranch()
        {
            int adminID = session.LoggedInSession;
            int branchID = -1;

            string query = "SELECT Branch_ID FROM admin WHERE Admin_ID = @adminID";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand getBranchIDCmd = new MySqlCommand(query, conn);
                getBranchIDCmd.Parameters.AddWithValue("@adminID", adminID);

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

        //Create Categories
        private void CreateCategory()
        {
            DialogResult result = MessageBox.Show("Do you want to create this Category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int createdby = session.LoggedInSession;
                int branchID = GetBranch();

                string title = txtTitle.Text;
                string description = txtDescription.Text;
                string duration = txtDuration.Text;
                string frequency = txtFrequency.Text;

                string query = @"INSERT INTO categories (Title, Description, Duration, Frequency, CreatedBy, Branch_ID, created_at, updated_at)
                            VALUES (@title, @description, @duration, @frequency, @createdby, @branchID, @createdAt, @updatedAt)";

                MySqlConnection conn = databaseHelper.getConnection();

                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@duration", duration);
                    cmd.Parameters.AddWithValue("@frequency", frequency);

                    cmd.Parameters.AddWithValue("@createdby", createdby);
                    cmd.Parameters.AddWithValue("@branchID", branchID);

                    DateTime now = DateTime.Now;
                    cmd.Parameters.AddWithValue("@createdAt", now);
                    cmd.Parameters.AddWithValue("@updatedAt", now);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("The category has been successfully created.",
                                    "Category Creation Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    txtTitle.Text = "";
                    txtDescription.Text = "";
                    txtDuration.Text = "";
                    txtFrequency.Text = "";

                    errorProvider1.SetError(txtTitle, string.Empty);
                    errorProvider2.SetError(txtDescription, string.Empty);
                    errorProvider3.SetError(txtDuration, string.Empty);
                    errorProvider4.SetError(txtFrequency, string.Empty);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string description = txtDescription.Text;
            string duration = txtDuration.Text;
            string frequency = txtFrequency.Text;

            bool valid = true;

            if (string.IsNullOrEmpty(title))
            {
                errorProvider1.SetError(borderTitle, "Title is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(borderTitle, string.Empty);
            }
            if (string.IsNullOrEmpty(description))
            {
                errorProvider2.SetError(borderDescription, "Description is required");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(borderDescription, string.Empty);
            }
            if (string.IsNullOrEmpty(duration))
            {
                errorProvider3.SetError(borderDuration, "Duration is required");
                valid = false;
            }
            else
            {
                errorProvider3.SetError(borderDuration, string.Empty);
            }
            if (string.IsNullOrEmpty(frequency))
            {
                errorProvider4.SetError(borderFrequency, "Frequency is required");
                valid = false;
            }
            else
            {
                errorProvider4.SetError(borderFrequency, string.Empty);
            }

            if (valid == true)
            {
                CreateCategory();
            }
        }

        //Fetch Titles
        private void GetTitle()
        {
            string query = @"SELECT Title FROM categories";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Clear existing items
                txtFetchTitle.Items.Clear();

                while (reader.Read())
                {
                    // Add each title to the ComboBox
                    string title = reader["Title"].ToString();
                    txtFetchTitle.Items.Add(title);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        //Fetch Details
        private void FetchDetailsForTitle(string title)
        {
            string query = @"SELECT Title, Description, Duration, Frequency FROM categories WHERE Title = @title";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", title);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Set the details in the respective text boxes
                    txtFetchTitle.Text = reader["Title"].ToString();
                    txtFetchDescription.Text = reader["Description"].ToString();
                    txtFetchDuration.Text = reader["Duration"].ToString();
                    txtFetchFrequency.Text = reader["Frequency"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


        //Fetch Details from Selected Title
        private void txtFetchTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTitle = txtFetchTitle.SelectedItem.ToString();
            FetchDetailsForTitle(selectedTitle);
        }


        //Refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetTitle();

            // Optionally, clear details if needed
            txtFetchTitle.Text = "";
            txtFetchDescription.Text = "";
            txtFetchDuration.Text = "";
            txtFetchFrequency.Text = "";
        }

        private void UpdateCategory(int categoryId)
        {
            DialogResult result = MessageBox.Show("Do you want to update this Category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                string title = txtFetchTitle.Text;
                string description = txtFetchDescription.Text;
                string duration = txtFetchDuration.Text;
                string frequency = txtFetchFrequency.Text;

                string query = @"UPDATE categories 
                     SET Title = @title, 
                         Description = @description, 
                         Duration = @duration, 
                         Frequency = @frequency,
                         updated_at = @updatedAt
                     WHERE Categories_ID = @categoryId";

                MySqlConnection conn = databaseHelper.getConnection();
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@duration", duration);
                    cmd.Parameters.AddWithValue("@frequency", frequency);

                    DateTime updatedAt = DateTime.Now;
                    cmd.Parameters.AddWithValue("@updatedAt", updatedAt);
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("The category has been successfully updated.",
                                    "Category Update Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record found with the provided ID.");
                    }

                    txtFetchTitle.Text = "";
                    txtFetchDescription.Text = "";
                    txtFetchDuration.Text = "";
                    txtFetchFrequency.Text = "";

                    errorProvider1.SetError(borderFetchTitle, string.Empty);
                    errorProvider2.SetError(borderFetchDescription, string.Empty);
                    errorProvider3.SetError(borderFetchDuration, string.Empty);
                    errorProvider4.SetError(borderFetchFrequency, string.Empty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Select Categories Id using Title
        private int GetSelectedCategoryId()
        {
            string title = txtFetchTitle.Text;
            int categoriesId = -1;
            string query = @"Select Categories_ID from categories Where Title = @title";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("title", title);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    categoriesId = reader.GetInt32("Categories_ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return categoriesId;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string title = txtFetchTitle.Text;
            string description = txtFetchDescription.Text;
            string duration = txtFetchDuration.Text;
            string frequency = txtFetchFrequency.Text;

            // Initialize a flag for validation status
            bool valid = true;

            // Check if the title is empty
            if (string.IsNullOrEmpty(title))
            {
                errorProvider1.SetError(borderFetchTitle, "Please Select Categories");

                MessageBox.Show("Please select a title first before proceeding.",
                                "Title Not Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                valid = false;
            }
            else
            {
                errorProvider1.SetError(borderFetchTitle, string.Empty);
                // If title is not empty, proceed with fetching the category ID
                int categoryId = GetSelectedCategoryId();
                if (categoryId == -1)
                {
                    MessageBox.Show("No matching category found. Please check the title and try again.");
                    valid = false;
                }
                else
                {
                    // Proceed with other validations only if category ID is valid
                    if (string.IsNullOrEmpty(description))
                    {
                        errorProvider2.SetError(borderFetchDescription, "Description is required");
                        valid = false;
                    }
                    else
                    {
                        errorProvider2.SetError(borderFetchDescription, string.Empty);
                    }

                    if (string.IsNullOrEmpty(duration))
                    {
                        errorProvider3.SetError(borderFetchDuration, "Duration is required");
                        valid = false;
                    }
                    else
                    {
                        errorProvider3.SetError(borderFetchDescription, string.Empty);
                    }

                    if (string.IsNullOrEmpty(frequency))
                    {
                        errorProvider4.SetError(borderFetchFrequency, "Frequency is required");
                        valid = false;
                    }
                    else
                    {
                        errorProvider4.SetError(borderFetchFrequency, string.Empty);
                    }

                    // Update the category if all validations pass

                    if (valid)
                    {
                        UpdateCategory(categoryId);
                    }
                }
            }
        }

        private viewCategories ViewCategoriesInstance;
        private void btnViewCategories_Click(object sender, EventArgs e)
        {

            if (ViewCategoriesInstance == null || ViewCategoriesInstance.IsDisposed)
            {
                ViewCategoriesInstance = new viewCategories();
                ViewCategoriesInstance.Show();
            }
            else
            {
                if (ViewCategoriesInstance.Visible)
                {
                    ViewCategoriesInstance.BringToFront();
                }
                else { ViewCategoriesInstance.Show(); }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
