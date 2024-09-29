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
                viewDentalServices.Rows.Clear();

                DataTable services = await _setupBookingModel.GetAllCategories(admin, dayOfWeek);

                // Avoid adding columns multiple times
                if (viewDentalServices.Columns.Count == 0)
                {
                    AddColumnServices(viewDentalServices);
                }

                foreach (DataRow service in services.Rows)
                {
                    int rowIndex = viewDentalServices.Rows.Add();
                    DataGridViewRow row = viewDentalServices.Rows[rowIndex];

                    // Set the values for the newly added row
                    row.Cells["Categories_ID"].Value = service["Categories_ID"];
                    row.Cells["Title"].Value = service["Title"];
                    row.Cells["Description"].Value = service["Description"];
                    row.Cells["Duration"].Value = service["Duration"];
                    row.Cells["Frequency"].Value = service["Frequency"];
                    row.Cells["Price"].Value = service["Price"];

                    // Set required_med_history and required_dent_history values
                    row.Cells["RequiredMedHistory"].Value = Convert.ToBoolean(service["required_med_history"]);
                    row.Cells["RequiredDentHistory"].Value = Convert.ToBoolean(service["required_dent_history"]);

                    // Ensure 'isavailable' is properly handled
                    if (viewDentalServices.Columns["DentalServices"] is DataGridViewCheckBoxColumn)
                    {
                        DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["DentalServices"];
                        checkBoxCell.Value = Convert.ToInt32(service["isavailable"]) == 1;
                    }
                }
            }
            catch (Exception ex)
            {
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

            // Add the checkbox column for isavailable
            DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "",
                Name = "DentalServices",
                DataPropertyName = "isavailable",
                Width = 30,
                ReadOnly = false
            };
            viewDentalServices.Columns.Add(selectColumn);
            viewDentalServices.Columns["DentalServices"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Add other columns
            viewDentalServices.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Category ID",
                Name = "Categories_ID", 
                DataPropertyName = "Categories_ID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Visible = false
            });


            viewDentalServices.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Services",
                Name = "Title",
                DataPropertyName = "Title",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            viewDentalServices.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Description",
                Name = "Description",
                DataPropertyName = "Description",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            viewDentalServices.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Duration",
                Name = "Duration",
                DataPropertyName = "Duration",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            viewDentalServices.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Frequency",
                Name = "Frequency",
                DataPropertyName = "Frequency",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            viewDentalServices.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price",
                Name = "Price",
                DataPropertyName = "Price",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Add columns for required_med_history and required_dent_history
            viewDentalServices.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Med",
                Name = "RequiredMedHistory",
                DataPropertyName = "required_med_history",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            viewDentalServices.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Dent",
                Name = "RequiredDentHistory",
                DataPropertyName = "required_dent_history",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
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

            if (!int.TryParse(maxComboBox.SelectedItem?.ToString(), out int maxAppointments))
            {
                MessageBox.Show("Please select a valid maximum appointment value.");
                return;
            }

            // Validate the start and end times
            if (startTime >= endTime)
            {
                MessageBox.Show("Start time must be before end time.");
                return;
            }

            try
            {
                getBranchIdByUserId branchId = new getBranchIdByUserId();
                BranchID b = await branchId.GetUserBranchId();

                if (b == null)
                {
                    MessageBox.Show("Branch ID could not be retrieved.");
                    return; // Handle as necessary
                }

                Branches branchDetails = await _setupBookingModel.GetBranches(b._id);

                if (branchDetails == null)
                {
                    MessageBox.Show("Branch details could not be retrieved.");
                    return; // Handle as necessary
                }


                List<DentalService> services = new List<DentalService>();

                foreach (DataGridViewRow row in viewDentalServices.Rows)
                {
                    if (row.IsNewRow) continue;

                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["DentalServices"];
                    bool isChecked = checkBoxCell.Value != null && (bool)checkBoxCell.Value;

                    string serviceTitle = row.Cells["Title"].Value?.ToString();
                    if (string.IsNullOrEmpty(serviceTitle))
                    {
                        MessageBox.Show("Service title is null or empty for a row. Please check your data.");
                        return; // Handle as necessary
                    }

                    if (row.Cells["Categories_ID"].Value == null)
                    {
                        MessageBox.Show("Category ID is null for a row. Please check your data.");
                        return; // Handle as necessary
                    }
                    int categoryId = Convert.ToInt32(row.Cells["Categories_ID"].Value); // Ensure this value exists

                    DentalService service = new DentalService
                    {
                        CategoriesId = categoryId,
                        DentalServices = serviceTitle,
                        BranchId = b._id,
                        IsAvailable = isChecked,
                        MaxAppointment = maxAppointments,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,


                        Address = $"{branchDetails._buildingnumber} {branchDetails._street}, {branchDetails._barangay}, {branchDetails._city}, {branchDetails._province}, {branchDetails._postalcode}"


                    };

                    services.Add(service);
                }

                int officeHourId = await _setupBookingModel.GetOfficeHourIdByDay(selectedDay);
                await _setupBookingModel.SaveDentalServices(services, officeHourId, selectedDay);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving branch information: {ex.Message}");
            }
        }


    }
}
