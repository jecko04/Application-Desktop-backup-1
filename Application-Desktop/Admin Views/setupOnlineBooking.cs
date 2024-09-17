using Application_Desktop.Model;
using Application_Desktop.Models;
using Application_Desktop.Sub_Views;
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

namespace Application_Desktop.Admin_Views
{
    public partial class setupOnlineBooking : Form
    {
        public setupOnlineBooking()
        {
            InitializeComponent();

        }

        private async void setupOnlineBooking_Load(object sender, EventArgs e)
        {
            await GetDayAndTime();
            txtDayofweek.SelectedItem = "Monday";
        }

        private void view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async Task GetDayAndTime()
        {
            int admin = session.LoggedInSession;
            string query = @"SELECT DayOfWeek, StartTime, EndTime, IsClosed From office_hours Where Branch_ID = @admin AND IsClosed = 0";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@admin", admin);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (await reader.ReadAsync())
                {
                    DayofweekModel dayofweek = new DayofweekModel
                    {
                        _days = reader["DayOfWeek"].ToString(),
                        _start = DateTime.Today.Add(reader.GetTimeSpan("StartTime")),
                        _end = DateTime.Today.Add(reader.GetTimeSpan("EndTime")),
                        _isClose = reader.GetBoolean("IsClosed")

                    };


                    //add item
                    if (InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            txtDayofweek.Items.Add(dayofweek._days);
                        });
                    }
                    else
                    {
                        txtDayofweek.Items.Add(dayofweek._days);
                    }
                }
                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Getdayandtime error " + ex.Message);
            }
            finally { await conn.CloseAsync(); }
        }

        private async Task<DayofweekModel> GetDayOfWeekData(string selectedDay)
        {
            int admin = session.LoggedInSession;

            // Combined query using JOIN
            string query = @"SELECT 
                        oh.StartTime, oh.EndTime, 
                        b.BranchName, b.BuildingNumber, b.Street, 
                        b.Barangay, b.City, b.Province, b.PostalCode,
                        c.Title, c.Description, c.Duration, c.Frequency
                    FROM office_hours oh 
                    INNER JOIN branch b ON oh.Branch_ID = b.Branch_ID
                    INNER JOIN categories c ON oh.Branch_ID = c.Branch_ID
                    WHERE oh.Branch_ID = @admin AND oh.DayOfWeek = @dayofweek";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                // Execute the combined query
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@admin", admin);
                cmd.Parameters.AddWithValue("@dayofweek", selectedDay);
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable datatable = new DataTable();

                    adapter.Fill(datatable);

                    viewDentalServices.DataSource = null;
                    viewDentalServices.Rows.Clear();
                    viewDentalServices.Columns.Clear();

                    viewDentalServices.AutoGenerateColumns = false;

                    AddColumnServices();

                    viewDentalServices.DataSource = datatable;
                }


                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (await reader.ReadAsync())
                    {
                        // Create the DayofweekModel and Branches object from the same reader
                        Branches branch = new Branches
                        {
                            _branches = reader["BranchName"].ToString(),
                            _buildingnumber = reader["BuildingNumber"].ToString(),
                            _street = reader["Street"].ToString(),
                            _barangay = reader["Barangay"].ToString(),
                            _city = reader["City"].ToString(),
                            _province = reader["Province"].ToString(),
                            _postalcode = reader["PostalCode"].ToString()
                        };

                        // Update UI (ComboBox) for branch info
                        if (InvokeRequired)
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                txtBranch.Items.Clear();
                                txtBranch.Items.Add(branch._branches);
                                txtBranch.SelectedItem = branch._branches;
                            });
                        }
                        else
                        {
                            txtBranch.Items.Clear();
                            txtBranch.Items.Add(branch._branches);
                            txtBranch.SelectedItem = branch._branches;
                        }

                        // Return the day of the week data
                        return new DayofweekModel
                        {
                            _days = selectedDay,
                            _start = DateTime.Today.Add(reader.GetTimeSpan("StartTime")),
                            _end = DateTime.Today.Add(reader.GetTimeSpan("EndTime"))
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ChangeDayValue error: {ex.Message}");
                throw;
            }
            finally
            {
                await conn.CloseAsync();
            }

            return null;
        }

        private void AddColumnServices()
        {
            viewDentalServices.RowHeadersVisible = false;
            viewDentalServices.ColumnHeadersHeight = 40;

            DataGridViewTextBoxColumn Title = new DataGridViewTextBoxColumn();
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.DataPropertyName = "Title";
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

        private void ChangeDayValue(DayofweekModel selectedDay)
        {
            if (selectedDay != null)
            {
                dtpEndtime.Value = selectedDay._end;
                dtpStartTime.Value = selectedDay._start;
            }
        }

        private async void txtDayofweek_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDay = txtDayofweek.Text;
            var dayData = await GetDayOfWeekData(selectedDay);
            ChangeDayValue(dayData);

        }
    }
}
