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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Application_Desktop.Model
{
    public class setupOnlineBookingModel
    {
        public async Task<DataTable> GetAllCategories(int admin, string dayofweek)
        {
            string query = @"SELECT categories.Categories_ID,  
                       categories.Title, 
                       categories.Description, 
                       categories.Duration, 
                       categories.Frequency, 
                       categories.Price, 
                       COALESCE(dental_services.isavailable, 0) AS isavailable,
                       COALESCE(categories.required_med_history, 0) AS required_med_history,  
                       COALESCE(categories.required_dent_history, 0) AS required_dent_history
                FROM categories
                LEFT JOIN dental_services
                ON categories.Branch_ID = dental_services.Branch_ID
                AND categories.Title = dental_services.dentalservices
                AND dental_services.dayofweek = @dayofweek
                WHERE categories.Branch_ID = @admin
                GROUP BY categories.Categories_ID,  
                         categories.Title, 
                         categories.Description, 
                         categories.Duration, 
                         categories.Frequency, 
                         categories.Price;";


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
                        cmd.Parameters.AddWithValue("@dayofweek", dayofweek);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable datatable = new DataTable();
                            await Task.Run(() => adapter.Fill(datatable)); // Ensures async handling

                            // Return an empty DataTable if no rows were found
                            return datatable;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Log or rethrow the error, avoid UI logic in model
                throw new Exception($"Error retrieving categories data: {ex.Message}");
            }
        }

        public async Task<Status> GetMaxAppointment(int admin, string dayofweek)
        {
            string query = @"SELECT max_appointment FROM dental_services WHERE Branch_ID = @admin AND dayofweek = @dayofweek";

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
                        cmd.Parameters.AddWithValue("@dayofweek", dayofweek);

                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                Status status = new Status
                                {
                                    _max = reader.GetInt32("max_appointment")
                                };
                                return status;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving max appointment: {ex.Message}");
            }

            return null;
        }


        public async Task<List<Categories>> GetAllCategoriesTitle(int admin)
        {
            string query = @"SELECT Categories_ID, Title FROM categories WHERE Branch_ID = @admin";

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
                                    _id = reader.GetInt32("Categories_ID"),
                                    _title = reader["Title"].ToString()
                                };
                                categoryList.Add(category);
                            }
                            await reader.CloseAsync();
                        }
                    }
                }
            }
            catch (MySqlException ex)  // Use specific exception handling
            {
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

        //start daytime
        public async Task<List<DayTime>> GetAllDayTime(int admin)
        {
            string query = @"SELECT OfficeHour_ID, DayOfWeek, StartTime, EndTime, IsClosed FROM office_hours WHERE Branch_ID = @admin AND IsClosed = 0";

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
                                    _id = reader.GetInt32("OfficeHour_ID"),
                                    _days = reader["DayOfWeek"].ToString(),
                                    _start = DateTime.Today.Add(reader.GetTimeSpan("StartTime")),
                                    _end = DateTime.Today.Add(reader.GetTimeSpan("EndTime")),
                                    _isClose = reader.GetBoolean("IsClosed")
                                };
                                dayOfWeekList.Add(dayofweek);
                            }
                            await reader.CloseAsync();
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
                            }
                            await reader.CloseAsync();

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
        //end daytime


        //start insert
        public async Task SaveDentalServices(List<DentalService> services, int officeHourId, string dayOfWeek)
        {
            using (MySqlConnection conn = databaseHelper.getConnection())
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                foreach (var service in services)
                {
                    string query = @"
                    INSERT INTO dental_services 
                    (`Categories_ID`, `OfficeHour_ID`, `dentalservices`, `dayofweek`, `Branch_ID`, `address`, `isavailable`, `max_appointment`, `created_at`, `updated_at`)
                    VALUES 
                    (@categoriesId, @officehourId, @services, @dayofweek, @branchId, @address, @isavailable, @max, @createdAt, @updatedAt)
                    ON DUPLICATE KEY UPDATE
                    `Categories_ID` = VALUES(`Categories_ID`),
                    `OfficeHour_ID` = VALUES(`OfficeHour_ID`),
                    `dentalservices` = VALUES(`dentalservices`),
                    `dayofweek` = VALUES(`dayofweek`),
                    `Branch_ID` = VALUES(`Branch_ID`),
                    `address` = VALUES(`address`),
                    `isavailable` = VALUES(`isavailable`),
                    `max_appointment` = VALUES(`max_appointment`),
                    `updated_at` = VALUES(`updated_at`)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@categoriesId", service.CategoriesId);
                        cmd.Parameters.AddWithValue("@officehourId", officeHourId);
                        cmd.Parameters.AddWithValue("@services", service.DentalServices);
                        cmd.Parameters.AddWithValue("@dayofweek", dayOfWeek);
                        cmd.Parameters.AddWithValue("@branchId", service.BranchId);
                        cmd.Parameters.AddWithValue("@address", service.Address);
                        cmd.Parameters.AddWithValue("@isavailable", service.IsAvailable);
                        cmd.Parameters.AddWithValue("@max", service.MaxAppointment);
                        cmd.Parameters.AddWithValue("@createdAt", service.CreatedAt);
                        cmd.Parameters.AddWithValue("@updatedAt", service.UpdatedAt);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
        }


        public async Task<int> GetOfficeHourIdByDay(string dayOfWeek)
        {
            int officeHourId = -1; // Default value if not found

            using (MySqlConnection conn = databaseHelper.getConnection())
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                string query = "SELECT OfficeHour_ID FROM office_hours WHERE DayOfWeek = @dayOfWeek"; 

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dayOfWeek", dayOfWeek);
                    object result = await cmd.ExecuteScalarAsync();

                    if (result != null)
                    {
                        officeHourId = Convert.ToInt32(result);
                    }
                }
            }

            return officeHourId;
        }


        //end insert

    }

    public class DayTime
    {
        [Required]
        public int _id { get; set; }

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
        public int _id { get; set; }

        [Required]
        public string _title { get; set; }
        [Required]
        public string _description { get; set; }
        [Required]
        public string _duration { get; set; }
        [Required]
        public string _frequency { get; set; }
        [Required]
        public decimal _price { get; set; }
    }

    public class services
    {
        [Required]
        public string _isavailable { get; set; }
        [Required]
        public string _dayofweek { get; set; }
    }
    public class Status
    {
        [Required]
        public int _max { get; set; }
    }

    public class DentalService
    {
        public int CategoriesId { get; set; }
        public int OfficeHourId { get; set; }
        public string DentalServices { get; set; }
        public string DayOfWeek { get; set; }
        public int BranchId { get; set; }
        public string Address { get; set; }
        public bool IsAvailable { get; set; }
        public int MaxAppointment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}
