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

namespace Application_Desktop.Views
{
    public partial class accessLogin : Form
    {
        private accessAccountController _accessAccountController;
        public accessLogin()
        {
            _accessAccountController = new accessAccountController();
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

        private void accessLogin_Load(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                getBranchIdByUserId branchIdFetcher = new getBranchIdByUserId();
                BranchID branch = await branchIdFetcher.GetUserBranchId();

                if (branch != null)
                {
                    int branchId = branch._id;
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;

                    IPAddressHelper addressHelper = new IPAddressHelper();
                    string ipAddress = await addressHelper.GetPublicIPAddress();

                    bool isValid = await _accessAccountController.ValidateAccess(username, password, branchId, ipAddress);

                    if (isValid)
                    {
                        AlertBox(Color.LightGreen, Color.SeaGreen, "Access Granted", "Welcome!", Properties.Resources.success);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        bool accountExists = await _accessAccountController.CheckAccountExists(username, branchId);

                        if (accountExists)
                        {
                            AlertBox(Color.LightPink, Color.DarkRed, "Access Denied", "Invalid Username or Password.", Properties.Resources.error);
                        }
                        else
                        {
                            AlertBox(Color.LightPink, Color.DarkRed, "Access Denied", "No access account found for this branch.", Properties.Resources.error);
                        }
                    }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
