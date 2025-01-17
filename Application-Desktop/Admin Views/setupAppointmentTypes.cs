﻿using Application_Desktop.Admin_Sub_Views;
using Application_Desktop.Model;
using Application_Desktop.Models;
using Application_Desktop.Screen;
using ElipseToolDemo;
using MaterialSkin.Controls;
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
using static Application_Desktop.Models.EllipseManager;

namespace Application_Desktop.Admin_Views
{
    public partial class setupAppointmentTypes : Form
    {

        public setupAppointmentTypes()
        {
            InitializeComponent();
            ElipseManager elipseManager = new ElipseManager(5);
            elipseManager.ApplyElipseToAllButtons(this);

            ElipseManager elipseManagerPanel = new ElipseManager(15);
            elipseManagerPanel.ApplyElipseToPanel(PanelOfficeHours);
            elipseManagerPanel.ApplyElipseToPanel(dentalServicePanel);
            elipseManagerPanel.ApplyElipseToPanel(updateDentalServicePanel);

            txtPrice.TextChanged += new EventHandler(txtPrice_TextChanged_1);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress_1);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave_1);

            txtFetchPrice.TextChanged += new EventHandler(txtFetchPrice_TextChanged);
            this.txtFetchPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFetchPrice_KeyPress);
            this.txtFetchPrice.Leave += new System.EventHandler(this.txtFetchPrice_Leave);

            ApplyCustomFormatToDateTimePickers(this.Controls);

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

        private async void setupAppointmentTypes_Load(object sender, EventArgs e)
        {
            await GetTitle();
            await LoadOfficeHour();
            await LoadIsClosed();

           

        }

        private void ApplyCustomFormatToDateTimePickers(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Format = DateTimePickerFormat.Custom;
                    dateTimePicker.CustomFormat = "hh mm tt"; // Custom format as 'HH mm A'
                }
                else if (control.HasChildren) // Recursively apply to child controls
                {
                    ApplyCustomFormatToDateTimePickers(control.Controls);
                }
            }
        }

        // It get branch Id
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
                MessageBox.Show($"GetBranch error" + ex.Message);
            }
            finally { conn.Close(); }

            return branchID;
        }

        //Create Categories
        private async Task CreateCategory()
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

                string rawPrice = txtPrice.Text.Replace("₱", "").Replace(",", "").Trim();

                /*bool IscheckedMed = chkRequiredMed.Checked;
                bool IscheckedDent = chkRequiredDent.Checked;*/

                if (!decimal.TryParse(rawPrice, out decimal price))
                {
                    MessageBox.Show("Invalid price input.");
                    return;
                }

                string query = @"INSERT INTO categories (Title, Description, Duration, Frequency, Price, Branch_ID, created_at, updated_at)
                            VALUES (@title, @description, @duration, @frequency, @price, @branchID, @createdAt, @updatedAt)";

                MySqlConnection conn = databaseHelper.getConnection();

                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@duration", duration);
                    cmd.Parameters.AddWithValue("@frequency", frequency);
                    cmd.Parameters.AddWithValue("@price", price);

                    cmd.Parameters.AddWithValue("@branchID", branchID);


                    DateTime now = DateTime.Now;
                    cmd.Parameters.AddWithValue("@createdAt", now);
                    cmd.Parameters.AddWithValue("@updatedAt", now);
                    await cmd.ExecuteNonQueryAsync();

                    AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The category has been successfully created", Properties.Resources.success);

                    txtTitle.Text = "";
                    txtDescription.Text = "";
                    txtDuration.Text = "";
                    txtFrequency.Text = "";
                    txtPrice.Text = "";


                    errorProvider1.SetError(txtTitle, string.Empty);
                    errorProvider2.SetError(txtDescription, string.Empty);
                    errorProvider3.SetError(txtDuration, string.Empty);
                    errorProvider4.SetError(txtFrequency, string.Empty);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Create Category error" + ex.Message);
                }
                finally { await conn.CloseAsync(); }
            }
        }


        //Fetch Titles
        private async Task GetTitle()
        {
            int branchid = await GetAdminBranch();

            string query = @"SELECT Title FROM categories Where Branch_ID = @branchID";

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
                txtFetchTitle.Items.Clear();

                while (await reader.ReadAsync())
                {
                    // Add each title to the ComboBox
                    string title = reader["Title"].ToString();
                    txtFetchTitle.Items.Add(title);
                }
                await reader.CloseAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"GetTitle error" + ex.Message);
            }
            finally
            {
                await conn.CloseAsync();
            }
        }

        private async Task<int> GetAdminBranch()
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



                // Check if branchID was correctly retrieved
                if (branchID == -1)
                {
                    MessageBox.Show("Failed to retrieve the admin's branch ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"GetAdminBranch error" + ex.Message);
            }
            finally
            {
                await conn.CloseAsync();
            }
            return branchID;
        }


        //Fetch Details
        private async Task FetchDetailsForTitle(string title)
        {

            int branchID = await GetAdminBranch();
            int categories = await GetSelectedCategoryId();
            string query = @"SELECT Title, Description, Duration, Frequency, Price FROM categories WHERE Categories_ID = @categories AND Branch_ID = @branchid";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@branchid", branchID);
                cmd.Parameters.AddWithValue("@categories", categories);
                MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    // Set the details in the respective text boxes
                    //txtFetchTitle.Text = reader["Title"].ToString();
                    txtFetchDescription.Text = reader["Description"].ToString();
                    txtFetchDuration.Text = reader["Duration"].ToString();
                    txtFetchFrequency.Text = reader["Frequency"].ToString();
                    txtFetchPrice.Text = reader["Price"].ToString();

                }

                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fetch Detail error" + ex.Message);
            }
            finally
            {
                await conn.CloseAsync();
            }
        }


        //Fetch Details from Selected Title
        private async void txtFetchTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTitle = txtFetchTitle.SelectedItem.ToString();
            await FetchDetailsForTitle(selectedTitle);
        }



        // Update the categories
        private async Task UpdateCategory()
        {
            DialogResult result = MessageBox.Show("Do you want to update this Category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //int branchID = await GetAdminBranch();
                int categoryId = await GetSelectedCategoryId();

                string title = txtFetchTitle.Text;
                string description = txtFetchDescription.Text;
                string duration = txtFetchDuration.Text;
                string frequency = txtFetchFrequency.Text;
                string newTitle = txtNewTitle.Text;

                string rawPrice = txtFetchPrice.Text.Replace("₱", "").Replace(",", "").Trim();


                if (!decimal.TryParse(rawPrice, out decimal price))
                {
                    MessageBox.Show("Invalid price input.");
                    return;
                }


                string query = @"UPDATE categories SET
                         Description = @description, 
                         Duration = @duration, 
                         Frequency = @frequency,
                         Price = @price,
                         updated_at = @updatedAt";

                if (!string.IsNullOrEmpty(newTitle))
                {
                    query += ", Title = @newTitle";
                }
                query += " WHERE Categories_ID = @categories";

                MySqlConnection conn = databaseHelper.getConnection();
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@duration", duration);
                    cmd.Parameters.AddWithValue("@frequency", frequency);
                    cmd.Parameters.AddWithValue("@price", price);




                    DateTime updatedAt = DateTime.Now;
                    cmd.Parameters.AddWithValue("@updatedAt", updatedAt);
                    //cmd.Parameters.AddWithValue("@branchID", branchID);
                    cmd.Parameters.AddWithValue("@categories", categoryId);

                    if (!string.IsNullOrEmpty(newTitle))
                    {
                        cmd.Parameters.AddWithValue("@newTitle", newTitle);
                    }

                    int rowsAffected = await cmd.ExecuteNonQueryAsync();

                    if (rowsAffected > 0)
                    {
                        AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The category has been successfully updated", Properties.Resources.success);
                    }
                    else
                    {
                        AlertBox(Color.LightPink, Color.DarkRed, "Error", "No record found with the provided ID", Properties.Resources.error);
                    }

                    txtFetchTitle.Text = "";
                    txtFetchDescription.Text = "";
                    txtFetchDuration.Text = "";
                    txtFetchFrequency.Text = "";
                    txtNewTitle.Text = "";
                    txtFetchPrice.Text = "";


                    errorProvider1.SetError(txtFetchTitle, string.Empty);
                    errorProvider2.SetError(txtFetchDescription, string.Empty);
                    errorProvider3.SetError(txtFetchDuration, string.Empty);
                    errorProvider4.SetError(txtFetchFrequency, string.Empty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Update category error" + ex.Message);
                }
                finally
                {
                    await conn.CloseAsync();
                }
            }
        }

        //Select Categories Id using Title
        private async Task<int> GetSelectedCategoryId()
        {
            string title = txtFetchTitle.Text;
            int categoriesId = -1;
            int branchid = await GetAdminBranch();

            string query = @"Select Categories_ID from categories Where Title = @title AND Branch_ID = @branchid";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@branchid", branchid);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    categoriesId = reader.GetInt32("Categories_ID");
                }
                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Select CategoryId error" + ex.Message);
            }
            finally { conn.Close(); }
            return categoriesId;
        }



        // It save setup office hours
        private async Task SaveOfficeHours()
        {
            //get branch
            int branchID = GetBranch();

            // Arrays for DateTimePickers and CheckBoxes
            DateTimePicker[] startPickers = { dateTimePicker2, dateTimePicker4, dateTimePicker6, dateTimePicker8, dateTimePicker10, dateTimePicker12, dateTimePicker14 };
            DateTimePicker[] endPickers = { dateTimePicker1, dateTimePicker3, dateTimePicker5, dateTimePicker7, dateTimePicker9, dateTimePicker11, dateTimePicker13 };
            CheckBox[] closeCheckBoxes = { mondayClose, tuesdayClose, wednesdayClose, thursdayClose, fridayClose, saturdayClose, sundayClose };

            // Days of the week
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            string query = @"
                            INSERT INTO office_hours (DayOfWeek, StartTime, EndTime, IsClosed, Branch_ID, created_at, updated_at)
                            VALUES (@DayOfWeek, @StartTime, @EndTime, @IsClosed, @branchID, @createdAt, @updatedAt)
                            ON DUPLICATE KEY UPDATE 
                                StartTime = VALUES(StartTime),
                                EndTime = VALUES(EndTime),
                                IsClosed = VALUES(IsClosed),
                                updated_at = VALUES(updated_at);";


            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                for (int i = 0; i < days.Length; i++)
                {
                    // Extract time as a string
                    string startTime = startPickers[i].Value.ToString("HH:mm:ss");
                    string endTime = endPickers[i].Value.ToString("HH:mm:ss");
                    bool isClosed = closeCheckBoxes[i].Checked;

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DayOfWeek", days[i]);
                    cmd.Parameters.AddWithValue("@StartTime", startTime);   // Store only the time part
                    cmd.Parameters.AddWithValue("@EndTime", endTime);       // Store only the time part
                    cmd.Parameters.AddWithValue("@IsClosed", isClosed);
                    cmd.Parameters.AddWithValue("@branchID", branchID);

                    DateTime now = DateTime.Now;
                    cmd.Parameters.AddWithValue("@createdAt", now);
                    cmd.Parameters.AddWithValue("@updatedAt", now);

                    // Execute the query for each day
                    await cmd.ExecuteNonQueryAsync();
                }

                AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "Office hours saved successfully", Properties.Resources.success);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Save OfficeHour error" + ex.Message);
            }
            finally
            {
                await conn.CloseAsync();
            }
        }



        //Apply to All CheckBox
        private DateTime[] originalStartValues;
        private DateTime[] originalEndValues;

        private void ApplyToAll()
        {
            DateTimePicker[] startPickers = { dateTimePicker2, dateTimePicker4, dateTimePicker6, dateTimePicker8, dateTimePicker10, dateTimePicker12, dateTimePicker14 };
            DateTimePicker[] endPickers = { dateTimePicker1, dateTimePicker3, dateTimePicker5, dateTimePicker7, dateTimePicker9, dateTimePicker11, dateTimePicker13 };

            // Get the start and end values from the selected DateTimePickers
            DateTime start = dateTimePicker16.Value;
            DateTime end = dateTimePicker15.Value;

            if (originalStartValues == null)
            {
                originalStartValues = startPickers.Select(picker => picker.Value).ToArray();
            }
            if (originalEndValues == null)
            {
                originalEndValues = endPickers.Select(picker => picker.Value).ToArray();
            }

            // Apply the start and end values to all DateTimePickers in the arrays
            foreach (var picker in startPickers)
            {
                picker.Value = start;
            }
            foreach (var picker in endPickers)
            {
                picker.Value = end;
            }
        }

        // Changed to Original Value
        private void RevertToOriginal()
        {
            DateTimePicker[] startPickers = { dateTimePicker2, dateTimePicker4, dateTimePicker6, dateTimePicker8, dateTimePicker10, dateTimePicker12, dateTimePicker14 };
            DateTimePicker[] endPickers = { dateTimePicker1, dateTimePicker3, dateTimePicker5, dateTimePicker7, dateTimePicker9, dateTimePicker11, dateTimePicker13 };

            // Revert to the original values
            for (int i = 0; i < startPickers.Length; i++)
            {
                startPickers[i].Value = originalStartValues[i];
            }
            for (int i = 0; i < endPickers.Length; i++)
            {
                endPickers[i].Value = originalEndValues[i];
            }

            // Clear the stored original values
            originalStartValues = null;
            originalEndValues = null;
        }

        private void btnApplyToAll_CheckedChanged(object sender, EventArgs e)
        {
            if (btnApplyToAll.Checked)
            {
                ApplyToAll(); // Apply the values to all DateTimePickers
            }
            else
            {
                RevertToOriginal(); // Revert to the original values
            }
        }

        // It Load the OfficeHour data value in database 
        private async Task LoadOfficeHour()
        {
            int branchID = GetBranch();
            string query = @"SELECT StartTime, EndTime FROM office_hours WHERE Branch_ID = @branchID";

            DateTimePicker[] startPickers = { dateTimePicker2, dateTimePicker4, dateTimePicker6, dateTimePicker8, dateTimePicker10, dateTimePicker12, dateTimePicker14 };
            DateTimePicker[] endPickers = { dateTimePicker1, dateTimePicker3, dateTimePicker5, dateTimePicker7, dateTimePicker9, dateTimePicker11, dateTimePicker13 };

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@branchID", branchID);

                MySqlDataReader reader = cmd.ExecuteReader();

                int startIndex = 0;
                int endIndex = 0;

                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        if (startIndex < startPickers.Length && endIndex < endPickers.Length)
                        {
                            TimeSpan start = reader.GetTimeSpan("StartTime");
                            TimeSpan end = reader.GetTimeSpan("EndTime");

                            DateTime startDateTime = DateTime.Today.Add(start);
                            DateTime endDateTime = DateTime.Today.Add(end);

                            startPickers[startIndex].Value = startDateTime;
                            endPickers[endIndex].Value = endDateTime;

                            startIndex++;
                            endIndex++;
                        }
                        else
                        {
                            // Handle case when there are more rows than DateTimePickers
                            MessageBox.Show("There are more office hours records than available DateTimePickers.");
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No office hours found for this branch. Please add office hours first.");
                }

                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"LoadOfficeHour error: {ex.Message}");
            }
            finally
            {
                await conn.CloseAsync();
            }
        }




        // It load the IsClosed data value in database
        private async Task LoadIsClosed()
        {
            int branchID = GetBranch();
            string query = @"SELECT DayOfWeek, IsClosed FROM office_hours WHERE Branch_ID = @branchID";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@branchID", branchID);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        string days = reader.GetString("DayOfWeek");
                        int isClosed = reader.GetInt32("IsClosed");

                        CheckBox checkbox = days switch
                        {
                            "Monday" => mondayClose,
                            "Tuesday" => tuesdayClose,
                            "Wednesday" => wednesdayClose,
                            "Thursday" => thursdayClose,
                            "Friday" => fridayClose,
                            "Saturday" => saturdayClose,
                            "Sunday" => sundayClose,
                        };

                        checkbox.Checked = (isClosed == 1);
                    }
                }
                else
                {
                    return;
                }

                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"LoadIsClosed error: " + ex.Message);
            }
            finally
            {
                await conn.CloseAsync();
            }
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void txtFetchPrice_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                // Avoid empty input
                if (string.IsNullOrWhiteSpace(textBox.Text))
                    return;

                // Store the current cursor position before any modification
                int originalSelectionStart = textBox.SelectionStart;
                int originalLength = textBox.Text.Length;

                // Remove the peso symbol and any commas to work with the raw numeric value
                string rawText = textBox.Text.Replace("₱", "").Replace(",", "").Trim();

                if (decimal.TryParse(rawText, out decimal value))
                {
                    // Reformat the text with the peso symbol and two decimal places
                    textBox.Text = "₱" + value.ToString("N2");

                    // Adjust the cursor position after reformatting
                    int newLength = textBox.Text.Length;
                    int lengthDifference = newLength - originalLength;

                    // Move the cursor back to the original position, adjusting for the new text length
                    textBox.SelectionStart = originalSelectionStart + lengthDifference;
                }
                else
                {
                    // If the input is not a valid number, reset to just the peso symbol
                    textBox.Text = "₱";
                    textBox.SelectionStart = textBox.Text.Length; // Set cursor at the end
                }
            }
        }

        private void txtFetchPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is MaterialSkin.Controls.MaterialTextBox textBox)
            {
                // Allow only digits, control keys (like backspace), and a single decimal point
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true; // Reject the input
                }

                // Allow only one decimal point
                if (e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1)
                {
                    e.Handled = true; // Reject additional decimal points
                }
            }
        }

        private void txtFetchPrice_Leave(object sender, EventArgs e)
        {
            if (sender is MaterialSkin.Controls.MaterialTextBox textBox)
            {
                // Remove the peso symbol and commas for parsing
                string rawText = textBox.Text.Replace("₱", "").Replace(",", "").Trim();

                if (decimal.TryParse(rawText, out decimal value))
                {
                    // Format the number with the peso symbol and two decimal places
                    textBox.Text = "₱" + value.ToString("N2");
                }
                else
                {
                    // If the input is invalid, reset to ₱0.00
                    textBox.Text = "₱0.00";
                }
            }
        }

        private async void btnSubmits_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string description = txtDescription.Text;
            string duration = txtDuration.Text;
            string frequency = txtFrequency.Text;

            bool valid = true;

            if (string.IsNullOrEmpty(title))
            {
                errorProvider5.SetError(txtTitle, "Title is required");
                valid = false;
            }
            else
            {
                errorProvider5.SetError(txtTitle, string.Empty);
            }
            if (await categoriesValidator.IsCategoryExist(title))
            {
                errorProvider1.SetError(txtTitle, "Title is already exist");
                this.BeginInvoke(new Action(() =>
                {
                    AlertBox(Color.LightSteelBlue, Color.DodgerBlue, "Already Exist", "Title is already exist. Please use different title", Properties.Resources.information);
                }));
                valid = false;
            }
            else
            {
                errorProvider1.SetError(txtTitle, string.Empty);
            }

            if (string.IsNullOrEmpty(description))
            {
                errorProvider2.SetError(txtDescription, "Description is required");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(txtDescription, string.Empty);
            }
            if (string.IsNullOrEmpty(duration))
            {
                errorProvider3.SetError(txtDuration, "Duration is required");
                valid = false;
            }
            else
            {
                errorProvider3.SetError(txtDuration, string.Empty);
            }
            if (string.IsNullOrEmpty(frequency))
            {
                errorProvider4.SetError(txtFrequency, "Frequency is required");
                valid = false;
            }
            else
            {
                errorProvider4.SetError(txtFrequency, string.Empty);
            }

            if (valid == true)
            {
                await CreateCategory();
            }
        }

        private void txtPrice_TextChanged_1(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                // Avoid empty input
                if (string.IsNullOrWhiteSpace(textBox.Text))
                    return;

                // Store the current cursor position before any modification
                int originalSelectionStart = textBox.SelectionStart;
                int originalLength = textBox.Text.Length;

                // Remove the peso symbol and any commas to work with the raw numeric value
                string rawText = textBox.Text.Replace("₱", "").Replace(",", "").Trim();

                if (decimal.TryParse(rawText, out decimal value))
                {
                    // Reformat the text with the peso symbol and two decimal places
                    textBox.Text = "₱" + value.ToString("N2");

                    // Adjust the cursor position after reformatting
                    int newLength = textBox.Text.Length;
                    int lengthDifference = newLength - originalLength;

                    // Move the cursor back to the original position, adjusting for the new text length
                    textBox.SelectionStart = originalSelectionStart + lengthDifference;
                }
                else
                {
                    // If the input is not a valid number, reset to just the peso symbol
                    textBox.Text = "₱";
                    textBox.SelectionStart = textBox.Text.Length; // Set cursor at the end
                }
            }
        }

        private void txtPrice_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (sender is MaterialSkin.Controls.MaterialTextBox textBox)
            {
                // Allow only digits, control keys (like backspace), and a single decimal point
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true; // Reject the input
                }

                // Allow only one decimal point
                if (e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1)
                {
                    e.Handled = true; // Reject additional decimal points
                }
            }
        }

        private void txtPrice_Leave_1(object sender, EventArgs e)
        {
            if (sender is MaterialSkin.Controls.MaterialTextBox textBox)
            {
                // Remove the peso symbol and commas for parsing
                string rawText = textBox.Text.Replace("₱", "").Replace(",", "").Trim();

                if (decimal.TryParse(rawText, out decimal value))
                {
                    // Format the number with the peso symbol and two decimal places
                    textBox.Text = "₱" + value.ToString("N2");
                }
                else
                {
                    // If the input is invalid, reset to ₱0.00
                    textBox.Text = "₱0.00";
                }
            }
        }

        private async void btnUpdates_Click(object sender, EventArgs e)
        {
            string title = txtFetchTitle.Text;
            string description = txtFetchDescription.Text;
            string duration = txtFetchDuration.Text;
            string frequency = txtFetchFrequency.Text;

            string newTitle = txtNewTitle.Text;

            // Initialize a flag for validation status
            bool valid = true;

            // Check if the title is empty
            if (string.IsNullOrEmpty(title))
            {
                errorProvider1.SetError(txtFetchTitle, "Please Select Categories");

                AlertBox(Color.LightSteelBlue, Color.DodgerBlue, "No title selected", "Please select a title before proceeding", Properties.Resources.information);

                valid = false;
            }
            else
            {
                errorProvider1.SetError(txtFetchTitle, string.Empty);
                // If title is not empty, proceed with fetching the category ID
                int categoryId = await GetSelectedCategoryId();
                if (categoryId == -1)
                {
                    AlertBox(Color.LightPink, Color.DarkRed, "No Matching Found", "Please check the title and try again", Properties.Resources.error);
                    valid = false;
                }
                else
                {
                    // Proceed with other validations only if category ID is valid
                    if (string.IsNullOrEmpty(description))
                    {
                        errorProvider2.SetError(txtFetchDescription, "Description is required");
                        valid = false;
                    }
                    else
                    {
                        errorProvider2.SetError(txtFetchDescription, string.Empty);
                    }

                    if (string.IsNullOrEmpty(duration))
                    {
                        errorProvider3.SetError(txtFetchDuration, "Duration is required");
                        valid = false;
                    }
                    else
                    {
                        errorProvider3.SetError(txtFetchDuration, string.Empty);
                    }

                    if (string.IsNullOrEmpty(frequency))
                    {
                        errorProvider4.SetError(txtFetchFrequency, "Frequency is required");
                        valid = false;
                    }
                    else
                    {
                        errorProvider4.SetError(txtFetchFrequency, string.Empty);
                    }

                    if (await categoriesValidator.IsCategoryExist(newTitle))
                    {
                        errorProvider1.SetError(txtNewTitle, "Categories title is alread exist");
                        valid = false;
                    }
                    else
                    {
                        errorProvider1.SetError(txtNewTitle, string.Empty);
                    }

                    // Update the category if all validations pass

                    if (valid)
                    {
                        await UpdateCategory();
                    }
                }
            }
        }

        private async void btnUpdateRefesher_Click(object sender, EventArgs e)
        {
            await GetTitle();

            txtFetchTitle.Text = "";
            txtFetchDescription.Text = "";
            txtFetchDuration.Text = "";
            txtFetchFrequency.Text = "";
        }

        private void PanelOfficeHours_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnSaveOfficeHour_Click(object sender, EventArgs e)
        {
            await SaveOfficeHours();
        }

        private viewCategories ViewCategoriesInstance;

        private void btnViewServices_Click(object sender, EventArgs e)
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

        private void dateTimePicker14_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}