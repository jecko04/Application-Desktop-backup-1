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


        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private TabPage previousTab;


        private void MyNavigationPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MyNavigationPanel.SelectedTab == tabPage4)
            {
                // Create an instance of your services form
                handleAppointment appointment = new handleAppointment();

                // Set the form as a non-top-level control, so it can be added to the panel
                appointment.TopLevel = false;
                appointment.FormBorderStyle = FormBorderStyle.None; // Optional: remove borders
                appointment.Dock = DockStyle.Fill; // Fill the panel with the form

                // Clear the panel in case there are existing controls
                appointmentPanel.Controls.Clear();

                appointmentPanel.Controls.Add(appointment);
                appointment.Show();
            }

            if (MyNavigationPanel.SelectedTab == tabPage5)
            {
                // Create an instance of your services form
                adminProfileSettings adminForm = new adminProfileSettings(this);

                // Set the form as a non-top-level control, so it can be added to the panel
                adminForm.TopLevel = false;
                adminForm.FormBorderStyle = FormBorderStyle.None; // Optional: remove borders
                adminForm.Dock = DockStyle.Fill; // Fill the panel with the form

                // Clear the panel in case there are existing controls
                accountPanel.Controls.Clear();

                accountPanel.Controls.Add(adminForm);
                adminForm.Show();
            }

            if (previousTab != null && previousTab != tabPage2)
            {
                patientRecordPanel.Controls.Clear(); // Clear the panel if it's not on tabPage2
            }

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