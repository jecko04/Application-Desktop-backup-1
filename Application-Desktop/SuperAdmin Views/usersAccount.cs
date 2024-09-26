using Application_Desktop.Controller;
using Application_Desktop.Method;
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

namespace Application_Desktop.SuperAdmin_Views
{
    public partial class usersAccount : Form
    {
        private userAccountController _userAccountController;
        public usersAccount()
        {
            _userAccountController = new userAccountController();
            InitializeComponent();

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
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void usersAccount_Load(object sender, EventArgs e)
        {
            try
            {
                await _userAccountController.LoadUsersData(viewUsersAccount);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                await _userAccountController.LoadUsersData(viewUsersAccount);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            bool hasSelectedRows = false;
            foreach (DataGridViewRow row in viewUsersAccount.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["selectUser"] as DataGridViewCheckBoxCell;

                if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                {
                    hasSelectedRows = true;
                    break;
                }
            }
            if (!hasSelectedRows)
            {
                AlertBox(Color.LightSteelBlue, Color.DodgerBlue, "No rows selected", "No rows were selected for deletion", Properties.Resources.information);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                viewUsersAccount.EndEdit();
                await _userAccountController.DeleteUserData(viewUsersAccount);

                AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The account has been deleted successfully", Properties.Resources.success);
            }
        }
        private bool isProcessingClick = false;
        private async void viewUsersAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isProcessingClick) return;

            if (e.RowIndex >= 0 && e.ColumnIndex == viewUsersAccount.Columns["selectUser"].Index)
            {
                isProcessingClick = true;

                try
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)viewUsersAccount.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    bool isChecked = cell.Value != null && (bool)cell.Value;
                    cell.Value = !isChecked;
                }
                finally
                {
                    isProcessingClick = false;
                }
            }
        }
    }
}
