using Application_Desktop.Admin_Views;
using Application_Desktop.Models;
using Application_Desktop.Screen;
using Application_Desktop.Sub_sub_Views;
using Application_Desktop.Sub_Views;
using Application_Desktop.SuperAdmin_Views;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Application_Desktop.Views
{
    public partial class superAdmin : Form
    {
        public superAdmin()
        {
            InitializeComponent();
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
                if (menuContainer.Height >= 105)
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

        public void LoadForm(Form form)
        {
            // Clear existing controls from the panel
            foreach (Control ctrl in this.mainPanel.Controls)
            {
                if (ctrl is Form oldForm)
                {
                    oldForm.Dispose(); // Dispose of the old form to free resources
                }
            }

            this.mainPanel.Controls.Clear(); // Clear all controls

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

        private void btnRole_Click(object sender, EventArgs e)
        {
            LoadForm(new Role());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadForm(new superAdminProfileSetting(this));
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDentalDoctors_Click(object sender, EventArgs e)
        {
            LoadForm(new doctorsAccount());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadForm(new usersAccount());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
