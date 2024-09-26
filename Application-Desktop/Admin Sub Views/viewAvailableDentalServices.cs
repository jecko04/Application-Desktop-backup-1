using Application_Desktop.Controller;
using Application_Desktop.Method;
using Application_Desktop.Model;
using Application_Desktop.Screen;
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

namespace Application_Desktop.Admin_Sub_Views
{
    public partial class viewAvailableDentalServices : Form
    {
        private viewAvailableDentalServicesController _viewAvailableServicesController;
        public viewAvailableDentalServices()
        {
            _viewAvailableServicesController = new viewAvailableDentalServicesController();
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void viewAvailableDentalServices_Load(object sender, EventArgs e)
        {
            try
            {
                getBranchIdByUserId branchId = new getBranchIdByUserId();
                BranchID branch = await branchId.GetUserBranchId();

                if (branch != null)
                {
                    int admin = branch._id;

                    await _viewAvailableServicesController.LoadAvailableDentalServices(admin, viewDentalServices);

                    List<string> result = await _viewAvailableServicesController.SelectSortedBy();
                    txtServices.Items.Clear();
                    txtServices.Items.AddRange(result.ToArray());
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

        public async Task SortedBy()
        {
            int isAvailable = btnAvailable.Checked ? 1 : 0;

            string selectedService = txtServices.SelectedItem?.ToString();

            DataTable result;

            if (btnAvailable.Checked && selectedService == null)
            {
                result = await _viewAvailableServicesController.SortedBy(null, isAvailable);
            }
            else if (selectedService != null)
            {
                result = await _viewAvailableServicesController.SortedBy(selectedService, isAvailable);
            }
            else
            {
                return;
            }

            viewDentalServices.DataSource = null;
            viewDentalServices.Rows.Clear();

            viewDentalServices.DataSource = result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void viewDentalServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                getBranchIdByUserId branchId = new getBranchIdByUserId();
                BranchID branch = await branchId.GetUserBranchId();

                if (branch == null)
                {
                    MessageBox.Show("Branch ID not found for the current user.");
                    return;
                }

                int admin = branch._id;

                if (e.RowIndex >= 0 && e.ColumnIndex == viewDentalServices.Columns["delete"].Index)
                {
                    await _viewAvailableServicesController.LoadDeleteData(e, admin, viewDentalServices);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the deletion process: {ex.Message}");
            }
        }

        private void viewDentalServices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            _viewAvailableServicesController.FormatAvailableCell(e, (DataGridView)sender);
        }

        private async void txtServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            await SortedBy();
        }

        private async void btnAvailable_CheckedChanged(object sender, EventArgs e)
        {
            await SortedBy();
        }
    }
}
