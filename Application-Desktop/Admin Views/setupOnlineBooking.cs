using Application_Desktop.Admin_Sub_Views;
using Application_Desktop.Controller;
using Application_Desktop.Method;
using Application_Desktop.Model;
using Application_Desktop.Models;
using Application_Desktop.Screen;
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
using static Application_Desktop.Models.EllipseManager;

namespace Application_Desktop.Admin_Views
{
    public partial class setupOnlineBooking : Form
    {
        private setupOnlineBookingController _OnlineBookingController;
        public setupOnlineBooking()
        {
            InitializeComponent();
            _OnlineBookingController = new setupOnlineBookingController();
            ElipseManager elipseManager = new ElipseManager(5);
            elipseManager.ApplyElipseToAllButtons(this);
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

        private async void setupOnlineBooking_Load(object sender, EventArgs e)
        {
            try
            {
                getBranchIdByUserId branchId = new getBranchIdByUserId();
                BranchID branch = await branchId.GetUserBranchId();

                if (branch != null)
                {
                    int admin = branch._id;
                    await _OnlineBookingController.LoadBranches(admin, txtBranch, txtNumber, txtStreet, txtBarangay, txtCity, txtProvince, txtZipCode);
                    await _OnlineBookingController.LoadDayTime(admin, txtDayofweek);
                    await _OnlineBookingController.LoadOpenDayTime(admin, viewDayTime);

                    _OnlineBookingController.LoadMaxAppointment(txtLimit);
                    //_OnlineBookingController.LoadStatus(txtStatus);

                }
                else
                {
                    MessageBox.Show("Branch ID not found for the current user.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
        }

        //text change for day of week
        private bool isLoadingCategories = false;
        private async void txtDayofweek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoadingCategories) return; // Prevent re-entry

            isLoadingCategories = true;

            try
            {
                getBranchIdByUserId branchId = new getBranchIdByUserId();
                BranchID branch = await branchId.GetUserBranchId();

                if (branch != null)
                {
                    int admin = branch._id;

                    // Check if a valid day is selected
                    if (txtDayofweek.SelectedItem != null)
                    {
                        await _OnlineBookingController.UpdateTimeAsync(admin, txtDayofweek, dtpStartTime, dtpEndtime);
                        await _OnlineBookingController.LoadCategories(admin, txtDayofweek.Text, viewDentalServices);
                        await _OnlineBookingController.LoadMaxAppointment(admin, txtDayofweek, txtLimit);
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid day of the week.");
                    }
                }
                else
                {
                    MessageBox.Show("Branch ID not found for the current user.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating categories: {ex.Message}");
            }
            finally
            {
                isLoadingCategories = false; // Reset the flag
            }
        }

        //refresh button
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                getBranchIdByUserId branchId = new getBranchIdByUserId();
                BranchID branch = await branchId.GetUserBranchId();

                if (branch != null)
                {
                    int admin = branch._id;

                    // Load categories if a valid day is selected
                    if (txtDayofweek.SelectedItem != null) // Check if a valid day is selected
                    {
                        // Clear existing rows in the DataGridView before loading new data
                        viewDentalServices.Rows.Clear();

                        // Load categories into the DataGridView
                        await _OnlineBookingController.LoadCategories(admin, txtDayofweek.SelectedItem.ToString(), viewDentalServices);
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid day of the week before refreshing.");
                    }
                }
                else
                {
                    MessageBox.Show("Branch ID not found for the current user.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing categories: {ex.Message}");
            }
        }

        //view day time cell
        private void viewDayTime_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            _OnlineBookingController.FormatDayTimeCell(e, (DataGridView)sender);
        }


        private bool isProcessingClick = false;
        private void viewDentalServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isProcessingClick) return;

            isProcessingClick = true;

            try
            {
                // Ensure the click is within the "DentalServices" column (checkbox column)
                if (e.ColumnIndex == viewDentalServices.Columns["DentalServices"].Index && e.RowIndex >= 0)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)viewDentalServices.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    bool isChecked = cell.Value != null && (bool)cell.Value;

                    // Toggle checkbox value
                    cell.Value = !isChecked;
                }
            }
            finally
            {
                isProcessingClick = false;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Check if required fields are filled out
            if (viewDentalServices.Rows.Count == 0 || txtDayofweek.SelectedItem == null || txtLimit.SelectedItem == null)
            {
                MessageBox.Show("Please ensure all required fields are filled out.");
                return;
            }

            // Gather data from the form
            string selectedDay = txtDayofweek.SelectedItem.ToString();
            DateTime startTime = dtpStartTime.Value;
            DateTime endTime = dtpEndtime.Value;
            int maxAppointments = (int)txtLimit.SelectedItem;

            // Retrieve the branch ID
            getBranchIdByUserId branchIdHelper = new getBranchIdByUserId();
            BranchID branch = await branchIdHelper.GetUserBranchId();

            if (branch == null)
            {
                MessageBox.Show("Branch information could not be retrieved.");
                return;
            }

            try
            {
                // Insert the data into the database
                await _OnlineBookingController.InsertToDatabase(viewDentalServices, txtDayofweek, dtpStartTime, dtpEndtime, txtLimit);

                // Display success message using your AlertBox method
                AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "Services have been saved successfully", Properties.Resources.success);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private viewAvailableDentalServices ViewAvailableServicesInstance;
        private void btnView_Click(object sender, EventArgs e)
        {
            if (ViewAvailableServicesInstance == null || ViewAvailableServicesInstance.IsDisposed)
            {
                ViewAvailableServicesInstance = new viewAvailableDentalServices();
                ViewAvailableServicesInstance.Show();
            }
            else
            {
                if (ViewAvailableServicesInstance.Visible)
                {
                    ViewAvailableServicesInstance.BringToFront();
                }
                else { ViewAvailableServicesInstance.Show(); }
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
