using Application_Desktop.Model;
using Application_Desktop.Models;
using Application_Desktop.Screen;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Controller
{
    public class viewAvailableDentalServicesController
    {
        private viewAvailableDentalServicesModel _viewAvailableServicesModel;
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
        public viewAvailableDentalServicesController()
        {
            _viewAvailableServicesModel = new viewAvailableDentalServicesModel();
        }
        
        public async Task LoadAvailableDentalServices(int admin, DataGridView viewDentalServices)
        {
            try
            {
                DataTable service = await _viewAvailableServicesModel.GetAllDentalServices(admin);
                viewDentalServices.DataSource = null;
                viewDentalServices.Rows.Clear();
                viewDentalServices.Columns.Clear();
                viewDentalServices.AutoGenerateColumns = false;

                AddColumnServices(viewDentalServices);

                viewDentalServices.DataSource = service;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error to LoadAvailableDentalServices data \n{ex.Message}");
            }
        }

        public void AddColumnServices(DataGridView viewDentalServices)
        {
            viewDentalServices.RowHeadersVisible = false;
            viewDentalServices.ColumnHeadersHeight = 40;

            DataGridViewTextBoxColumn Id = new DataGridViewTextBoxColumn();
            Id.HeaderText = "ID";
            Id.Name = "dentalservices_id";
            Id.DataPropertyName = "dentalservices_id";
            viewDentalServices.Columns.Add(Id);

            DataGridViewTextBoxColumn Dayofweek = new DataGridViewTextBoxColumn();
            Dayofweek.HeaderText = "Day of the week";
            Dayofweek.Name = "dayofweek";
            Dayofweek.DataPropertyName = "dayofweek";
            viewDentalServices.Columns.Add(Dayofweek);

            DataGridViewTextBoxColumn selectColumn = new DataGridViewTextBoxColumn();
            selectColumn.HeaderText = "Available";
            selectColumn.Name = "isavailable";
            selectColumn.DataPropertyName = "isavailable";
            selectColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewDentalServices.Columns.Add(selectColumn);

            DataGridViewTextBoxColumn Title = new DataGridViewTextBoxColumn();
            Title.HeaderText = "Services";
            Title.Name = "dentalservices";
            Title.DataPropertyName = "dentalservices";
            viewDentalServices.Columns.Add(Title);

            DataGridViewTextBoxColumn Description = new DataGridViewTextBoxColumn();
            Description.HeaderText = "Description";
            Description.Name = "description";
            Description.DataPropertyName = "description";
            viewDentalServices.Columns.Add(Description);

            DataGridViewTextBoxColumn Duration = new DataGridViewTextBoxColumn();
            Duration.HeaderText = "Duraiton";
            Duration.Name = "duration";
            Duration.DataPropertyName = "duration";
            viewDentalServices.Columns.Add(Duration);

            DataGridViewTextBoxColumn Frequency = new DataGridViewTextBoxColumn();
            Frequency.HeaderText = "Frequency";
            Frequency.Name = "frequency";
            Frequency.DataPropertyName = "frequency";
            viewDentalServices.Columns.Add(Frequency);

            DataGridViewTextBoxColumn Price = new DataGridViewTextBoxColumn();
            Price.HeaderText = "Price";
            Price.Name = "price";
            Price.DataPropertyName = "price";
            viewDentalServices.Columns.Add(Price);

            DataGridViewTextBoxColumn Start = new DataGridViewTextBoxColumn();
            Start.HeaderText = "Start";
            Start.Name = "starttime";
            Start.DataPropertyName = "starttime";
            viewDentalServices.Columns.Add(Start);

            DataGridViewTextBoxColumn End = new DataGridViewTextBoxColumn();
            End.HeaderText = "End";
            End.Name = "endtime";
            End.DataPropertyName = "endtime";
            viewDentalServices.Columns.Add(End);

            DataGridViewTextBoxColumn Branch = new DataGridViewTextBoxColumn();
            Branch.HeaderText = "Branch Name";
            Branch.Name = "Branch_ID";
            Branch.DataPropertyName = "BranchName";
            viewDentalServices.Columns.Add(Branch);

            DataGridViewTextBoxColumn Address = new DataGridViewTextBoxColumn();
            Address.HeaderText = "Address";
            Address.Name = "address";
            Address.DataPropertyName = "address";
            viewDentalServices.Columns.Add(Address);

            DataGridViewTextBoxColumn Max = new DataGridViewTextBoxColumn();
            Max.HeaderText = "Max Appointment";
            Max.Name = "max_appointment";
            Max.DataPropertyName = "max_appointment";
            Max.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            viewDentalServices.Columns.Add(Max);

            DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn
            {
                HeaderText = "",
                Name = "delete",
                Image = Properties.Resources.delete_img,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            };
            viewDentalServices.Columns.Add(deleteButtonColumn);
        }

        public void FormatAvailableCell(DataGridViewCellFormattingEventArgs e, DataGridView viewDentalServices)
        {
            if (e.ColumnIndex == viewDentalServices.Columns["StartTime"].Index ||
                e.ColumnIndex == viewDentalServices.Columns["EndTime"].Index)
            {
                if (e.Value != null && DateTime.TryParse(e.Value.ToString(), out DateTime time))
                {
                    // Format the time to 12-hour format with AM/PM
                    e.Value = time.ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }
        }

        public async Task LoadDeleteData(DataGridViewCellEventArgs e, int admin, DataGridView viewDentalService)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == viewDentalService.Columns["delete"].Index)
            {
                DialogResult result = MessageBox.Show("Would you like to proceed with deleting this data?", "Confirm Deletions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    

                    Delete delete = new Delete
                    {
                        _id = Convert.ToInt32(viewDentalService.Rows[e.RowIndex].Cells["dentalservices_id"].Value)
                };

                    try
                    {
                        // Delete row from database
                        await _viewAvailableServicesModel.DeleteDentalServices(admin, delete);
                        AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The data has been deleted successfully", Properties.Resources.success);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        public async Task<DataTable> SortedBy(string dentalServices, int isAvailable)
        {
            // Base query for selecting dental services
            string query = @"SELECT `dentalservices_id`, `dentalservices`, `description`, `duration`, `frequency`, `price`, 
                     `dayofweek`, `starttime`, `endtime`, `Branch_ID`, `address`, `isavailable`, 
                     `max_appointment`, `created_at`, `updated_at` 
                     FROM `dental_services` 
                     WHERE `isavailable` = @isavailable";

            if (!string.IsNullOrEmpty(dentalServices))
            {
                query += " AND `dentalservices` = @dentalservices"; 
            }

            DataTable dataTable = new DataTable();

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    await conn.OpenAsync();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@isavailable", isAvailable);

                        // Only add this parameter if dentalServices is provided
                        if (!string.IsNullOrEmpty(dentalServices))
                        {
                            cmd.Parameters.AddWithValue("@dentalservices", dentalServices);
                        }

                        // Executing the command and filling the DataTable
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            await Task.Run(() => adapter.Fill(dataTable));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SortedBy: {ex.Message}");
            }

            return dataTable;
        }



        public async Task<List<string>> SelectSortedBy()
        {
            string query = @"SELECT DISTINCT `dentalservices` FROM `dental_services`";

            List<string> dentalServicesList = new List<string>();

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    await conn.OpenAsync();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                string dentalService = reader["dentalservices"] != DBNull.Value ? reader["dentalservices"].ToString() : null;

                                if (!string.IsNullOrEmpty(dentalService) && !dentalServicesList.Contains(dentalService))
                                {
                                    dentalServicesList.Add(dentalService);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            // Return the list of dental services
            return dentalServicesList;
        }




    }
}
