using Application_Desktop.Method;
using Application_Desktop.Model;
using Application_Desktop.Models;
using Application_Desktop.Sub_Views;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Application_Desktop.Controller
{
    public class setupOnlineBookingController
    {
        private setupOnlineBookingModel _setupBookingModel;

        public setupOnlineBookingController()
        {
            _setupBookingModel = new setupOnlineBookingModel();
        }


        // start categories
        public async Task LoadCategories(int admin, string dayOfWeek, DataGridView viewDentalServices)
        {
            try
            {
                // Clear the DataGridView rows to avoid duplication
                viewDentalServices.Rows.Clear();

                // Fetch the services from the model
                DataTable services = await _setupBookingModel.GetAllCategories(admin, dayOfWeek);

                // Avoid adding columns multiple times
                if (viewDentalServices.Columns.Count == 0)
                {
                    AddColumnServices(viewDentalServices);
                }

                // Populate the DataGridView with services
                foreach (DataRow service in services.Rows)
                {
                    // Add a new row to the DataGridView
                    int rowIndex = viewDentalServices.Rows.Add();
                    DataGridViewRow row = viewDentalServices.Rows[rowIndex];

                    // Set the values for the newly added row
                    row.Cells["Title"].Value = service["Title"];
                    row.Cells["Description"].Value = service["Description"];
                    row.Cells["Duration"].Value = service["Duration"];
                    row.Cells["Frequency"].Value = service["Frequency"];
                    row.Cells["Price"].Value = service["Price"];

                    // Ensure 'isavailable' is properly handled
                    if (viewDentalServices.Columns["DentalServices"] is DataGridViewCheckBoxColumn)
                    {
                        DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["DentalServices"];

                        // Assign the checkbox value directly based on isavailable
                        checkBoxCell.Value = Convert.ToInt32(service["isavailable"]) == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                // Display error message if something goes wrong
                MessageBox.Show($"Error loading categories: {ex.Message}");
            }
        }

        public async Task LoadMaxAppointment(int admin, ComboBox dayofweek, ComboBox maxComboBox)
        {
            try
            {
                Status max = await _setupBookingModel.GetMaxAppointment(admin, dayofweek.Text);

                // Assuming you have a ComboBox for max appointments
                if (max != null)
                {
                    maxComboBox.SelectedItem = max._max; 
                }
                else
                {
                    maxComboBox.SelectedItem = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading max appointment: {ex.Message}");
            }
        }
        
        private void AddColumnServices(DataGridView viewDentalServices)
        {
            viewDentalServices.RowHeadersVisible = false;
            viewDentalServices.ColumnHeadersHeight = 40;

            DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
            selectColumn.HeaderText = "";
            selectColumn.Name = "DentalServices";
            selectColumn.DataPropertyName = "isavailable";
            selectColumn.Width = 30;
            selectColumn.ReadOnly = false;
            viewDentalServices.Columns.Add(selectColumn);
            viewDentalServices.Columns["DentalServices"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewTextBoxColumn Title = new DataGridViewTextBoxColumn();
            Title.HeaderText = "Services";
            Title.Name = "Title";
            Title.DataPropertyName = "Title";
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewDentalServices.Columns.Add(Title);

            DataGridViewTextBoxColumn Description = new DataGridViewTextBoxColumn();
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.DataPropertyName = "Description";
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewDentalServices.Columns.Add(Description);

            DataGridViewTextBoxColumn Duration = new DataGridViewTextBoxColumn();
            Duration.HeaderText = "Duration";
            Duration.Name = "Duration";
            Duration.DataPropertyName = "Duration";
            Duration.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewDentalServices.Columns.Add(Duration);

            DataGridViewTextBoxColumn Frequency = new DataGridViewTextBoxColumn();
            Frequency.HeaderText = "Frequency";
            Frequency.Name = "Frequency";
            Frequency.DataPropertyName = "Frequency";
            Frequency.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewDentalServices.Columns.Add(Frequency);

            DataGridViewTextBoxColumn Price = new DataGridViewTextBoxColumn();
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.DataPropertyName = "Price";
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewDentalServices.Columns.Add(Price);
        }

        private Dictionary<string, Categories> _categories = new Dictionary<string, Categories>();
        public async Task LoadCategoryList(int admin, ComboBox categoryComboBox)
        {
            try
            {
                List<Categories> categoriesList = await _setupBookingModel.GetAllCategoriesTitle(admin);
                if (categoriesList != null && categoriesList.Count > 0)
                {


                    foreach (var category in categoriesList)
                    {
                        categoryComboBox.Items.Add(category._title);
                        _categories[category._title] = category;
                    }
                }
                else
                {
                    MessageBox.Show("No data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading category list: {ex.Message}");
            }
        }

        //end categories

        //start branches

        public async Task LoadBranches(int admin, ComboBox branchComboBox, TextBox number, TextBox street, TextBox barangay, TextBox city, TextBox province, TextBox zip)
        {
            try
            {
                Branches branch = await _setupBookingModel.GetBranches(admin);

                if (branch != null)
                {
                    branchComboBox.Items.Clear();
                    branchComboBox.Items.Add(branch._branches);
                    branchComboBox.SelectedItem = branch._branches;

                    number.Clear();
                    number.Text = branch._buildingnumber;

                    street.Clear();
                    street.Text = branch._street;

                    barangay.Clear();
                    barangay.Text = branch._barangay;

                    city.Clear();
                    city.Text = branch._city;

                    province.Clear();
                    province.Text = branch._province;

                    zip.Clear();
                    zip.Text = branch._postalcode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading branches: {ex.Message}");
            }
        }

        //end branches

        //start day time

        private Dictionary<string, DayTime> _dayOfWeekData = new Dictionary<string, DayTime>();
        public async Task LoadDayTime(int admin, ComboBox dayComboBox)
        {
            try
            {
                List<DayTime> dayOfWeekList = await _setupBookingModel.GetAllDayTime(admin);
                if (dayOfWeekList != null && dayOfWeekList.Count > 0)
                {
                    // Clear and populate the ComboBox with days
                    _dayOfWeekData.Clear();
                    dayComboBox.Items.Clear();

                    foreach (var dayofweek in dayOfWeekList)
                    {
                        dayComboBox.Items.Add(dayofweek._days);
                        _dayOfWeekData[dayofweek._days] = dayofweek;
                    }

                    dayComboBox.SelectedIndex = 0;

                    if (dayComboBox.Items.Count > 0)
                    {
                        dayComboBox.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("No data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading day time: {ex.Message}");
            }
        }

        public async Task UpdateTimeAsync(int admin, ComboBox dayComboBox, DateTimePicker start, DateTimePicker end)
        {
            try
            {
                if (dayComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a day.");
                    return;
                }

                string selectedDay = dayComboBox.SelectedItem.ToString();
                DayTime dayTime = await _setupBookingModel.SearchDayTimeData(admin, selectedDay);

                if (dayTime != null)
                {
                    start.Value = dayTime._start;
                    end.Value = dayTime._end;
                }
                else
                {
                    MessageBox.Show("No data found for the selected day.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating time: {ex.Message}");
            }
        }

        public void LoadStatus(ComboBox status)
        {
            status.Items.Clear();
            status.Items.Add("Available");
            status.Items.Add("Unavailable");

            status.SelectedItem = "Available";
        }

        public void LoadMaxAppointment(ComboBox max)
        {
            int[] value = {
        0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
    };

            max.Items.Clear();

            foreach (var limit in value)
            {
                max.Items.Add(limit);
            }

            max.SelectedItem = 0;
        }

        public async Task LoadOpenDayTime(int admin, DataGridView viewDayTime)
        {
            try
            {
                DataTable daytime = await _setupBookingModel.GetOpenDayTime(admin);

                viewDayTime.DataSource = null;
                viewDayTime.Rows.Clear();
                viewDayTime.Columns.Clear();

                viewDayTime.AutoGenerateColumns = false;

                AddColumnDayTime(viewDayTime);

                viewDayTime.DataSource = daytime;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories data by search: {ex.Message}");
            }
        }

        private void AddColumnDayTime(DataGridView viewDayTime)
        {
            viewDayTime.RowHeadersVisible = false;
            viewDayTime.ColumnHeadersHeight = 40;

            DataGridViewTextBoxColumn Days = new DataGridViewTextBoxColumn();
            Days.HeaderText = "Day of the week";
            Days.Name = "DayOfWeek";
            Days.DataPropertyName = "DayOfWeek";
            Days.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewDayTime.Columns.Add(Days);

            DataGridViewTextBoxColumn StartTime = new DataGridViewTextBoxColumn();
            StartTime.HeaderText = "Start Time";
            StartTime.Name = "StartTime";
            StartTime.DataPropertyName = "StartTime";
            StartTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewDayTime.Columns.Add(StartTime);

            DataGridViewTextBoxColumn EndTime = new DataGridViewTextBoxColumn();
            EndTime.HeaderText = "End Time";
            EndTime.Name = "EndTime";
            EndTime.DataPropertyName = "EndTime";
            EndTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewDayTime.Columns.Add(EndTime);
        }

        public void FormatDayTimeCell(DataGridViewCellFormattingEventArgs e, DataGridView viewDayTime)
        {
            if (e.ColumnIndex == viewDayTime.Columns["StartTime"].Index ||
                e.ColumnIndex == viewDayTime.Columns["EndTime"].Index)
            {
                if (e.Value != null && DateTime.TryParse(e.Value.ToString(), out DateTime time))
                {
                    // Format the time to 12-hour format with AM/PM
                    e.Value = time.ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }
        }
        //end day time

        //start insert data

        public async Task InsertToDatabase(DataGridView viewDentalServices, ComboBox dayComboBox, DateTimePicker start, DateTimePicker end, ComboBox maxComboBox)
        {
            if (viewDentalServices == null || dayComboBox.SelectedItem == null || maxComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please ensure all required fields are filled out.");
                return;
            }

            string selectedDay = dayComboBox.SelectedItem.ToString();
            DateTime startTime = start.Value;
            DateTime endTime = end.Value;
            int maxAppointments = (int)maxComboBox.SelectedItem;

            try
            {
                // Retrieve branch information
                getBranchIdByUserId branchId = new getBranchIdByUserId();
                BranchID b = await branchId.GetUserBranchId();

                if (b != null)
                {
                    int admin = b._id;
                    Branches branch = await _setupBookingModel.GetBranches(admin); // Assuming you have a method to get branch details

                    if (branch == null)
                    {
                        MessageBox.Show("Branch information could not be retrieved.");
                        return;
                    }

                    // Loop through selected services and insert or update them
                    foreach (DataGridViewRow row in viewDentalServices.Rows)
                    {
                        if (row.IsNewRow) continue; // Skip the new row placeholder

                        DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["DentalServices"];
                        bool isChecked = checkBoxCell.Value != null && (bool)checkBoxCell.Value; // Checked or unchecked state

                        // Retrieve service details from the row
                        string serviceTitle = row.Cells["Title"].Value?.ToString();
                        string description = row.Cells["Description"].Value?.ToString();
                        string duration = row.Cells["Duration"].Value?.ToString();
                        string frequency = row.Cells["Frequency"].Value?.ToString();
                        decimal price = decimal.Parse(row.Cells["Price"].Value?.ToString() ?? "0");

                        Categories service = new Categories
                        {
                            _title = serviceTitle,
                            _description = description,
                            _duration = duration,
                            _frequency = frequency,
                            _price = price
                        };

                        DayTime dayTime = new DayTime
                        {
                            _days = selectedDay,
                            _start = startTime,
                            _end = endTime
                        };

                        Status status = new Status
                        {
                            _max = maxAppointments // Assign maxAppointments to the Status object
                        };

                        await _setupBookingModel.CreateService(service, dayTime, branch, isChecked, b._id, status);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting or updating data: {ex.Message}");
            }
        }


    }
}
