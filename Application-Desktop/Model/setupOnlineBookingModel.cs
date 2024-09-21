using Application_Desktop.Admin_Views;
using Application_Desktop.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Model
{
    public class setupOnlineBookingModel
    {
        public async Task<DataTable> GetAllCategories(int admin)
        {
            string query = @"SELECT Title, Description, Duration, Frequency FROM categories WHERE Branch_ID = @admin";
            try
            {           
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@admin", admin);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable datatable = new DataTable();
                            adapter.Fill(datatable);
                            return datatable.Rows.Count == 0 ? new DataTable() : datatable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or rethrow the error, avoid UI logic in model
                throw new Exception($"Error retrieving categories data: {ex.Message}");
            }
        }

        public async Task<DataTable> SearchCategoryData(int admin, string title)
        {
            string query = @"SELECT Title, Description, Duration, Frequency FROM categories WHERE Branch_ID = @admin AND Title = @title";
            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@admin", admin);
                        cmd.Parameters.AddWithValue("@title", title);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable datatable = new DataTable();
                            adapter.Fill(datatable);
                            return datatable.Rows.Count == 0 ? new DataTable() : datatable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving search categories data: {ex.Message}");
            }
        }

        public async Task<List<Categories>> GetAllCategoriesTitle(int admin)
        {
            string query = @"SELECT Title From categories Where Branch_ID = @admin";

            List<Categories> categoryList = new List<Categories>();
            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@admin", admin);
                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                Categories category = new Categories
                                {
                                    _title = reader["Title"].ToString()
                                };
                                categoryList.Add(category);
                            }
                            await reader.CloseAsync();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                // Log or rethrow the error, avoid UI logic in model
                throw new Exception($"Error retrieving category list data: {ex.Message}");
            }
            return categoryList;
        }

        public async Task<Branches> GetBranches(int admin)
        {
            string query = @"SELECT BranchName, BuildingNumber, Street, Barangay, City, Province, PostalCode From branch Where Branch_ID = @admin";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@admin", admin);
                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
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
                                return branch;
                            }
                            await reader.CloseAsync();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                // Log or rethrow the error, avoid UI logic in model
                throw new Exception($"Error retrieving branch data: {ex.Message}");
            }
            return null;
        }

        public async Task<List<DayTime>> GetAllDayTime(int admin)
        {
            string query = @"SELECT DayOfWeek, StartTime, EndTime, IsClosed FROM office_hours WHERE Branch_ID = @admin AND IsClosed = 0";

            List<DayTime> dayOfWeekList = new List<DayTime>();
            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@admin", admin);
                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                DayTime dayofweek = new DayTime
                                {
                                    _days = reader["DayOfWeek"].ToString(),
                                    _start = DateTime.Today.Add(reader.GetTimeSpan("StartTime")),
                                    _end = DateTime.Today.Add(reader.GetTimeSpan("EndTime")),
                                    _isClose = reader.GetBoolean("IsClosed")
                                };
                                dayOfWeekList.Add(dayofweek);
                            }await reader.CloseAsync();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving Day of Week data: {ex.Message}");
            }

            return dayOfWeekList;
        }

        public async Task<DayTime> SearchDayTimeData(int admin, string dayTime)
        {
            string query = @"SELECT DayOfWeek, StartTime, EndTime From office_hours Where Branch_ID = @admin AND DayOfWeek = @daytime";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@admin", admin);
                        cmd.Parameters.AddWithValue("@daytime", dayTime);
                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                DayTime gettime = new DayTime
                                { 
                                    _days = reader["DayOfWeek"].ToString(),
                                    _start = DateTime.Today.Add(reader.GetTimeSpan("StartTime")),
                                    _end = DateTime.Today.Add(reader.GetTimeSpan("EndTime"))
                                };
                                return gettime;
                            }await reader.CloseAsync();
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving DayTime data: {ex.Message}");
            }
            return null;
        }

        public async Task<DataTable> GetOpenDayTime(int admin)
        {
            string query = @"SELECT DayOfWeek, StartTime, EndTime, IsClosed FROM office_hours WHERE Branch_ID = @admin AND IsClosed = 0";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@admin", admin);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable datatable = new DataTable();

                            adapter.Fill(datatable);

                            return datatable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or rethrow the error, avoid UI logic in model
                throw new Exception($"Error retrieving OpenDayTime data: {ex.Message}");
            }
        }
    }

    public class DayTime
    {
        [Required]
        public string _days { get; set; }
        [Required]
        public DateTime _start { get; set; }
        [Required]
        public DateTime _end { get; set; }
        [Required]
        public bool _isClose { get; set; }
    }

    public class Branches 
    {
        [Required]
        public string _branches { get; set; }
        [Required]
        public string _buildingnumber { get; set; }
        [Required]
        public string _street { get; set; }
        [Required]
        public string _barangay { get; set; }
        [Required]
        public string _city { get; set; }
        [Required]
        public string _province { get; set; }
        [Required]
        public string _postalcode { get; set; }
    }

    public class Categories
    {
        [Required]
        public string _title { get; set; }
        [Required]
        public string _description { get; set; }
        [Required]
        public string _duration { get; set; }
        [Required]
        public string _frequency { get; set; }
    }
}
