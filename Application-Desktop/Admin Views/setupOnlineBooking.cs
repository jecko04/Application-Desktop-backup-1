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

            await GetBranches();

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
            string query = @"Select StartTime, EndTime from office_hours Where Branch_ID = @admin AND DayOfWeek = @dayofweek";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@admin", admin);
                cmd.Parameters.AddWithValue("@dayofweek", selectedDay);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (await reader.ReadAsync())
                {

                    return new DayofweekModel
                    {
                        _days = selectedDay,
                        _start = DateTime.Today.Add(reader.GetTimeSpan("StartTime")),
                        _end = DateTime.Today.Add(reader.GetTimeSpan("EndTime")),
                    };
                }
                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ChangeDayValue error " + ex.Message);
                throw;
            }
            finally { await conn.CloseAsync(); }
            return null;
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

        private async Task GetBranches()
        {
            int admin = session.LoggedInSession;
            string query = @"Select BranchName, BuildingNumber, Street, Barangay, City, Province, PostalCode From branch Where Branch_ID = @admin";

            MySqlConnection connect = databaseHelper.getConnection();

            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    await connect.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@admin", admin);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (await reader.ReadAsync())
                {

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

                    if (InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            txtBranch.Items.Add(branch._branches);
                        });
                    }
                    else
                    {
                        txtBranch.Items.Add(branch._branches);
                    }
                }
                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"GetBranch error " + ex.Message);
            }
            finally { await connect.CloseAsync(); }
        }
    }
}
