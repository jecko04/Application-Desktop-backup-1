using Application_Desktop.Admin_Views;
using Application_Desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Desktop.Views
{
    public partial class adminPage : Form
    {
        public adminPage()
        {
            InitializeComponent();
        }

        private void adminPage_Load(object sender, EventArgs e)
        {

        }

        //menu dropdown
        bool menuExpand = false;

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }


        private void menuTransition_Tick_1(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 130)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 34)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        bool setupExpand = false;
        private void btnSetup_Click(object sender, EventArgs e)
        {
            setupTransition.Start();
        }
        private void setupTransition_Tick(object sender, EventArgs e)
        {
            if (setupExpand == false)
            {
                setupContainer.Height += 10;
                if (setupContainer.Height >= 130)
                {
                    setupTransition.Stop();
                    setupExpand = true;
                }
            }
            else
            {
                setupContainer.Height -= 10;
                if (setupContainer.Height <= 34)
                {
                    setupTransition.Stop();
                    setupExpand = false;
                }
            }
        }






        //sidebar Slide
        bool sidebarExpand = true;

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
        private void sidebarTransition_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand == true)
            {
                //179
                //37
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width <= 39)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width >= 179)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        public void LoadForm(Form form)
        {
            // Clear existing controls from the panel
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }

            // Set up the new form
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form);
            this.mainPanel.Tag = form;
            form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            session.Logout();

            MessageBox.Show("You have been logged out.");

            this.Close();

            // Redirect to login form
            loginPage loginForm = new loginPage();
            loginForm.Show();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            LoadForm(new doctorsAccount());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            LoadForm(new setupAppointmentTypes());
        }

        private void btnOfficeHourAndStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnOnlineBooking_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            LoadForm(new employeeProfile());
        }
    }
}
//179, 179