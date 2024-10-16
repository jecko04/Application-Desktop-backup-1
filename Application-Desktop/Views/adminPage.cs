using Application_Desktop.Admin_Views;
using Application_Desktop.Models;
using Application_Desktop.Screen;
using Application_Desktop.Sub_Views;
using MaterialSkin.Controls;
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
    public partial class adminPage : MaterialForm
    {
        public adminPage()
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
                if (menuContainer.Height >= 100)
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
                if (setupContainer.Height >= 100)
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            session.Logout();

            MessageBox.Show("You have been logged out.");

            this.Close();

            loginPage loginForm = new loginPage();
            loginForm.Show();
        }


        private void btnCategory_Click(object sender, EventArgs e)
        {
            LoadForm(new setupAppointmentTypes());
        }

        private void btnOnlineBooking_Click(object sender, EventArgs e)
        {
            LoadForm(new setupOnlineBooking());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            LoadForm(new employeeProfile());
        }


        private void btnSetting_Click(object sender, EventArgs e)
        {
            LoadForm(new adminProfileSettings(this));
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }


        bool patientExpand = false;
        private void PatientTransition_Tick(object sender, EventArgs e)
        {
            if (patientExpand == false)
            {
                recordContainer.Height += 10;
                if (recordContainer.Height >= 68)
                {
                    PatientTransition.Stop();
                    patientExpand = true;
                }
            }
            else
            {
                recordContainer.Height -= 10;
                if (recordContainer.Height <= 34)
                {
                    PatientTransition.Stop();
                    patientExpand = false;
                }
            }
        }

        private void btnPatientRecord_Click_1(object sender, EventArgs e)
        {
            PatientTransition.Start();
        }

        bool appointExpand = false;
        private void AppointTransition_Tick(object sender, EventArgs e)
        {
            if (appointExpand == false)
            {
                appointmentContainer.Height += 10;
                if (appointmentContainer.Height >= 139)
                {
                    AppointTransition.Stop();
                    appointExpand = true;
                }
            }
            else
            {
                appointmentContainer.Height -= 10;
                if (appointmentContainer.Height <= 34)
                {
                    AppointTransition.Stop();
                    appointExpand = false;
                }
            }
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            AppointTransition.Start();
        }

        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            using (accessLogin access = new accessLogin())
            {
                if (access.ShowDialog() == DialogResult.OK)
                {
                    LoadForm(new patientRecord());
                }
            }
        }

        private void btnPending_Click(object sender, EventArgs e)
        {

        }

        private void btnViewAllAppointment_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private TabPage previousTab;


        private void MyNavigationPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MyNavigationPanel.SelectedTab == tabPage3)
            {
                // Create an instance of your services form
                setupAppointmentTypes servicesForm = new setupAppointmentTypes();

                // Set the form as a non-top-level control, so it can be added to the panel
                servicesForm.TopLevel = false;
                servicesForm.FormBorderStyle = FormBorderStyle.None; // Optional: remove borders
                servicesForm.Dock = DockStyle.Fill; // Fill the panel with the form

                // Clear the panel in case there are existing controls
                servicesPanel.Controls.Clear();

                servicesPanel.Controls.Add(servicesForm);
                servicesForm.Show();
            }
            
            if (previousTab != null && previousTab != tabPage2)
            {
                patientRecordPanel.Controls.Clear(); // Clear the panel if it's not on tabPage2
            }

            // Check if the selected tab is tabPage2
            if (MyNavigationPanel.SelectedTab == tabPage2)
            {
                // Clear the panel before loading new content
                patientRecordPanel.Controls.Clear();

                // Show the login form (accessLogin) first
                using (accessLogin access = new accessLogin())
                {
                    // If login is successful (DialogResult.OK), show the patientRecord form
                    if (access.ShowDialog() == DialogResult.OK)
                    {
                        // Create an instance of the patientRecord form
                        patientRecord patientRecord = new patientRecord();

                        // Set the form as a non-top-level control, so it can be added to the panel
                        patientRecord.TopLevel = false;
                        patientRecord.FormBorderStyle = FormBorderStyle.None; // Optional: remove borders
                        patientRecord.Dock = DockStyle.Fill; // Fill the panel with the form

                        // Add the patientRecord form to the panel and display it
                        patientRecordPanel.Controls.Add(patientRecord);
                        patientRecord.Show();
                    }
                    else
                    {
                        // If login is unsuccessful, reset the TabControl to the previous tab
                        MyNavigationPanel.SelectedTab = previousTab;
                    }
                }
            }
            else
            {
                // If switching away from tabPage2, ensure the panel is cleared
                patientRecordPanel.Controls.Clear();
            }
        }

        private void MyNavigationPanel_Selecting(object sender, TabControlCancelEventArgs e)
        {
            previousTab = MyNavigationPanel.SelectedTab;
        }
    }
}
//179, 179