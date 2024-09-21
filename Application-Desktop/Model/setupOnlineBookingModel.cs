using Application_Desktop.Admin_Views;
using Application_Desktop.Models;
using Application_Desktop.Screen;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Application_Desktop.Model
{
    public class setupOnlineBookingModel
    {
        public async Task<DataTable> GetAllCategories(int admin, string dayofweek)
        {
            string query = @"SELECT categories.Title, 
                               categories.Description, 
                               categories.Duration, 
                               categories.Frequency, 
                               categories.Price, 
                               COALESCE(dental_services.isavailable, 0) AS isavailable
                        FROM categories
                        LEFT JOIN dental_services
                        ON categories.Branch_ID = dental_services.Branch_ID
                        AND categories.Title = dental_services.dentalservices
                        AND dental_services.dayofweek = @dayofweek
                        WHERE categories.Branch_ID = @admin
                        GROUP BY categories.Title, 
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

                        using (MySqlDataReader reader = (MySqlDataReader) await cmd.ExecuteReaderAsync())
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
            string query = @"SELECT Title FROM categories WHERE Branch_ID = @admin";
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
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving category list data: {ex.Message}");
            }
            return categoryList;
        }

        public async Task<Branches> GetBranches(int admin)
        {
            string query = @"SELECT BranchName, BuildingNumber, Street, Barangay, City, Province, PostalCode FROM branch WHERE Branch_ID = @admin";
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
                                return new Branches
                                {
                                    _branches = reader["BranchName"].ToString(),
                                    _buildingnumber = reader["BuildingNumber"].ToString(),
                                    _street = reader["Street"].ToString(),
                                    _barangay = reader["Barangay"].ToString(),
                                    _city = reader["City"].ToString(),
                                    _province = reader["Province"].ToString(),
                                    _postalcode = reader["PostalCode"].ToString()
                                };
                            }
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving branch data: {ex.Message}");
            }
        }

        //start daytime
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
            string query = @"SELECT DayOfWeek, StartTime, EndTime FROM office_hours WHERE Branch_ID = @admin AND DayOfWeek = @daytime AND IsClosed = 0";
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
                            if (await reader.ReadAsync())
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
                            return datatable.Rows.Count == 0 ? new DataTable() : datatable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving OpenDayTime data: {ex.Message}");
            }
        }
        //end daytime


        //start insert
        public async Task CreateService(Categories service, DayTime day, Branches branch, bool isAvailable, int branchId, Status status)
        {
            string address = $"{branch._buildingnumber}, {branch._street}, {branch._barangay}, {branch._city}, {branch._province}, {branch._postalcode}";

            string query = @"
        INSERT INTO dental_services 
        (`dentalservices`, `description`, `duration`, `frequency`, `price`, `dayofweek`, `starttime`, `endtime`, `Branch_ID`, `address`, `isavailable`, max_appointment, `created_at`, `updated_at`)
        VALUES 
        (@services, @desc, @duration, @freq, @price, @dayofweek, @start, @end, @branchid, @address, @isavailable, @max, @createdAt, @updatedAt)
        ON DUPLICATE KEY UPDATE
        `description` = VALUES(`description`),
        `duration` = VALUES(`duration`),
        `frequency` = VALUES(`frequency`),
        `price` = VALUES(`price`),
        `dayofweek` = VALUES(`dayofweek`),
        `starttime` = VALUES(`starttime`),
        `endtime` = VALUES(`endtime`),
        `Branch_ID` = VALUES(`Branch_ID`),
        `address` = VALUES(`address`),
        `isavailable` = VALUES(`isavailable`),
        `max_appointment` = VALUES(`max_appointment`),
        `updated_at` = VALUES(`updated_at`)
    ";

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
                        cmd.Parameters.AddWithValue("@services", service._title);
                        cmd.Parameters.AddWithValue("@desc", service._description);
                        cmd.Parameters.AddWithValue("@duration", service._duration);
                        cmd.Parameters.AddWithValue("@freq", service._frequency);
                        cmd.Parameters.AddWithValue("@price", service._price);
                        cmd.Parameters.AddWithValue("@dayofweek", day._days);
                        cmd.Parameters.AddWithValue("@start", day._start);
                        cmd.Parameters.AddWithValue("@end", day._end);
                        cmd.Parameters.AddWithValue("@branchid", branchId);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@isavailable", isAvailable);

                        // Assuming status._max is provided from some other context
                        cmd.Parameters.AddWithValue("@max", status._max);

                        DateTime now = DateTime.Now;
                        cmd.Parameters.AddWithValue("@createdAt", now);
                        cmd.Parameters.AddWithValue("@updatedAt", now);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Inserting data: {ex.Message}");
            }
        }

        //end insert

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
}
