using Application_Desktop.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public async Task LoadCategories(int admin, DataGridView viewDentalServices)
        {
            try
            {
                DataTable categories = await _setupBookingModel.GetAllCategories(admin);

                // Now that you have the data, pass it to the view (the DataGridView)
                viewDentalServices.DataSource = null;
                viewDentalServices.Rows.Clear();
                viewDentalServices.Columns.Clear();

                // Prevent automatic column generation
                viewDentalServices.AutoGenerateColumns = false;

                // Add columns (this can be a method in your View/SetupOnlineBooking class)
                AddColumnServices(viewDentalServices);

                // Assign the data to the DataGridView
                viewDentalServices.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}");
            }
        }

        public async Task LoadCategoriesDataBySearch(int admin, DataGridView viewDentalServices, ComboBox servicesComboBox)
        {
            try
            {
                string selectedTitle = servicesComboBox.SelectedItem?.ToString();

                DataTable categories = await _setupBookingModel.SearchCategoryData(admin, selectedTitle);

                // Now that you have the data, pass it to the view (the DataGridView)
                viewDentalServices.DataSource = null;
                viewDentalServices.Rows.Clear();
                viewDentalServices.Columns.Clear();

                // Prevent automatic column generation
                viewDentalServices.AutoGenerateColumns = false;

                // Add columns (this can be a method in your View/SetupOnlineBooking class)
                AddColumnServices(viewDentalServices);

                // Assign the data to the DataGridView
                viewDentalServices.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories data by search: {ex.Message}");
            }
        }

        private void AddColumnServices(DataGridView viewDentalServices)
        {
            viewDentalServices.RowHeadersVisible = false;
            viewDentalServices.ColumnHeadersHeight = 40;

            DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
            selectColumn.HeaderText = "";
            selectColumn.Name = "DentalServices";
            selectColumn.Width = 30;
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
        }

        private Dictionary<string, Categories> _categories = new Dictionary<string, Categories>();
        public async Task LoadCategoryList(int admin, ComboBox categoryComboBox)
        {
            try
            {
                List<Categories> categoriesList = await _setupBookingModel.GetAllCategoriesTitle(admin);
                if (categoriesList != null && categoriesList.Count > 0)
                {
                    // Clear and populate the ComboBox with days
                    _dayOfWeekData.Clear();
                    categoryComboBox.Items.Clear();

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
    } 
}
