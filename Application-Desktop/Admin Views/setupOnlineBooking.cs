using Application_Desktop.Controller;
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
        private setupOnlineBookingController _OnlineBookingController;
        public setupOnlineBooking()
        {
            InitializeComponent();
            _OnlineBookingController = new setupOnlineBookingController();
        }

        private async void setupOnlineBooking_Load(object sender, EventArgs e)
        {
            int admin = session.LoggedInSession;
            await _OnlineBookingController.LoadCategories(admin, viewDentalServices);
            await _OnlineBookingController.LoadBranches(admin, txtBranch, txtNumber, txtStreet, txtBarangay, txtCity, txtProvince, txtZipCode);
            await _OnlineBookingController.LoadDayTime(admin, txtDayofweek);
            await _OnlineBookingController.LoadOpenDayTime(admin, viewDayTime);
            await _OnlineBookingController.LoadCategoryList(admin, txtDentalServices);

            _OnlineBookingController.LoadStatus(txtStatus);
        }

        //text change for day of week
        private async void txtDayofweek_SelectedIndexChanged(object sender, EventArgs e)
        {
            int admin = session.LoggedInSession;
            await _OnlineBookingController.UpdateTimeAsync(admin, txtDayofweek, dtpStartTime, dtpEndtime);
        }

        //text change for dental services
        private async void txtDentalServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            int admin = session.LoggedInSession;
            await _OnlineBookingController.LoadCategoriesDataBySearch(admin, viewDentalServices, txtDentalServices);
        }

        //refresh button
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            int admin = session.LoggedInSession;
            txtDentalServices.Text = "";
            if (string.IsNullOrEmpty(txtDentalServices.Text))
            {
                await _OnlineBookingController.LoadCategories(admin, viewDentalServices);
            }
        }

        //view day time cell
        private void viewDayTime_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            _OnlineBookingController.FormatDayTimeCell(e, (DataGridView)sender);
        }
    }
}
