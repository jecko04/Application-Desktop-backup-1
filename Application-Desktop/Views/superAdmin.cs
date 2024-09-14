using Application_Desktop.Models;
using Application_Desktop.Sub_sub_Views;
using Application_Desktop.Sub_Views;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class superAdmin : Form
    {
        public superAdmin()
        {
            InitializeComponent();
        }

        private void superAdmin_Load(object sender, EventArgs e)
        {

        }

        //149, 86, 203 = light violet
        //menu dropdown
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }


        //sidebar Slide
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
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

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
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
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new dashBoard());
        }
        private void btnBranches_Click(object sender, EventArgs e)
        {
            LoadForm(new viewBranches());
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LoadForm(new admin());
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

        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadForm(new dentaldoctorUsers());
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            LoadForm(new Role());
        }
    }
}
