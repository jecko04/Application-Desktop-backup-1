using Application_Desktop.Admin_Views;
using Application_Desktop.Controller;
using Application_Desktop.Method;
using Application_Desktop.Models;
using Application_Desktop.Screen;
using Application_Desktop.Sub_Views;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Application_Desktop.Models.EllipseManager;

namespace Application_Desktop.Views
{
    public partial class adminPage : MaterialForm
    {
        private adminDashboardController _adminDashboardController;
        public adminPage()
        {
            InitializeComponent();
            _adminDashboardController = new adminDashboardController();

            ElipseManager elipseManagerPanel = new ElipseManager(15);
            elipseManagerPanel.ApplyElipseToPanel(panel1);
            elipseManagerPanel.ApplyElipseToPanel(panel2);
            elipseManagerPanel.ApplyElipseToPanel(panel3);
            elipseManagerPanel.ApplyElipseToPanel(panel4);
            elipseManagerPanel.ApplyElipseToPanel(panel5);

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

        private async void adminPage_Load(object sender, EventArgs e)
        {
            await CountAll();
            await LoadInqueue();

            displayDays();
        }

        private async Task CountAll()
        {
            try
            {
                int pendingCount = await _adminDashboardController.CountAllPending();
                int approvedCount = await _adminDashboardController.CountAllApproved();
                int cancelledCount = await _adminDashboardController.CountAllCancelled();
                int completedCount = await _adminDashboardController.CountAllCompleted();
                int patientCount = await _adminDashboardController.CountAllPatient();

                txtPending.Text = pendingCount.ToString();
                txtApproved.Text = approvedCount.ToString();
                txtCancel.Text = cancelledCount.ToString();
                txtCompleted.Text = completedCount.ToString();
                txtDentalPatient.Text = patientCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task LoadInqueue()
        {
            try
            {
                DataTable inqueue = await _adminDashboardController.InqueueAppointment();
                viewPending.DataSource = null;
                viewPending.Rows.Clear();
                viewPending.Columns.Clear();

                viewPending.AutoGenerateColumns = false;
                AddColumnInqueue(viewPending);

                viewPending.DataSource = inqueue;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load patient records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddColumnInqueue(DataGridView Inqueue)
        {
            Inqueue.RowHeadersVisible = false;
            Inqueue.ColumnHeadersHeight = 40;

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                Name = "id",
                DataPropertyName = "id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(id);

            DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "User ID",
                Name = "user_id",
                DataPropertyName = "user_id",
                Visible = false
            };
            Inqueue.Columns.Add(userIdColumn);

            DataGridViewTextBoxColumn fullname = new DataGridViewTextBoxColumn
            {
                HeaderText = "Fullname",
                Name = "fullname",
                DataPropertyName = "UserName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(fullname);

            DataGridViewTextBoxColumn branches = new DataGridViewTextBoxColumn
            {
                HeaderText = "Branch",
                Name = "branches",
                DataPropertyName = "BranchName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(branches);

            DataGridViewTextBoxColumn services = new DataGridViewTextBoxColumn
            {
                HeaderText = "Services",
                Name = "services",
                DataPropertyName = "ServiceTitle",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(services);

            DataGridViewTextBoxColumn appointment_date = new DataGridViewTextBoxColumn
            {
                HeaderText = "Appointment Date",
                Name = "appointmentDate",
                DataPropertyName = "appointment_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(appointment_date);

            DataGridViewTextBoxColumn appointment_time = new DataGridViewTextBoxColumn
            {
                HeaderText = "Appointment Time",
                Name = "appointmentTime",
                DataPropertyName = "appointment_time",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(appointment_time);

            DataGridViewTextBoxColumn reschedule_date = new DataGridViewTextBoxColumn
            {
                HeaderText = "Reschedule Date",
                Name = "rescheduleDate",
                DataPropertyName = "reschedule_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(reschedule_date);

            DataGridViewTextBoxColumn reschedule_time = new DataGridViewTextBoxColumn
            {
                HeaderText = "Reschedule Time",
                Name = "rescheduleTime",
                DataPropertyName = "reschedule_time",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(reschedule_time);

            DataGridViewTextBoxColumn status = new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                Name = "status",
                DataPropertyName = "status",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(status);
        }



        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void LoadAppointmentForm()
        {
            if (appointmentPanel.Controls.Count > 0)
            {
                var oldForm = appointmentPanel.Controls[0] as Form;
                if (oldForm != null)
                {
                    oldForm.Dispose();
                }
            }

            handleAppointment appointment = new handleAppointment();
            appointment.TopLevel = false;
            appointment.FormBorderStyle = FormBorderStyle.None;
            appointment.Dock = DockStyle.Fill;

            appointmentPanel.Controls.Clear();
            appointmentPanel.Controls.Add(appointment);
            appointment.Show();
        }
        private void LoadAdminProfileSettingsForm()
        {

            if (accountPanel.Controls.Count > 0)
            {
                var oldForm = accountPanel.Controls[0] as Form;
                if (oldForm != null)
                {
                    oldForm.Dispose();
                }
            }
            adminProfileSettings adminForm = new adminProfileSettings(this);

            adminForm.TopLevel = false;
            adminForm.FormBorderStyle = FormBorderStyle.None;
            adminForm.Dock = DockStyle.Fill;

            accountPanel.Controls.Clear();  // Clear panel to ensure it reloads each time
            accountPanel.Controls.Add(adminForm);
            adminForm.Show();
        }
        private void LoadAppointmentTypesForm()
        {
            if (servicesPanel.Controls.Count > 0)
            {
                var oldForm = servicesPanel.Controls[0] as Form;
                if (oldForm != null)
                {
                    oldForm.Dispose();
                }
            }

            setupAppointmentTypes servicesForm = new setupAppointmentTypes();

            servicesForm.TopLevel = false;
            servicesForm.FormBorderStyle = FormBorderStyle.None;
            servicesForm.Dock = DockStyle.Fill;

            servicesPanel.Controls.Clear();  // Clear panel to ensure it reloads each time
            servicesPanel.Controls.Add(servicesForm);
            servicesForm.Show();
        }
        private void LoadPatientRecordForm()
        {
            if (patientRecordPanel.Controls.Count > 0)
            {
                var oldForm = patientRecordPanel.Controls[0] as Form;
                if (oldForm != null)
                {
                    oldForm.Dispose();
                }
            }

            patientRecordPanel.Controls.Clear();  // Always clear to reload fresh data

            using (accessLogin access = new accessLogin())
            {
                if (access.ShowDialog() == DialogResult.OK)
                {
                    patientRecord patientRecord = new patientRecord();

                    patientRecord.TopLevel = false;
                    patientRecord.FormBorderStyle = FormBorderStyle.None;
                    patientRecord.Dock = DockStyle.Fill;

                    patientRecordPanel.Controls.Add(patientRecord);
                    patientRecord.Show();
                }
                else
                {
                    MyNavigationPanel.SelectedTab = previousTab;  // Revert to previous tab if login is canceled
                }
            }
        }

        private TabPage previousTab;
        private void MyNavigationPanel_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (MyNavigationPanel.SelectedTab == tabPage4)
            {
                LoadAppointmentForm();
            }

            if (MyNavigationPanel.SelectedTab == tabPage5)
            {
                LoadAdminProfileSettingsForm();
            }

            if (MyNavigationPanel.SelectedTab == tabPage3)
            {
                LoadAppointmentTypesForm();
            }

            if (MyNavigationPanel.SelectedTab == tabPage2)
            {
                LoadPatientRecordForm();
            }


        }



        private void MyNavigationPanel_Selecting(object sender, TabControlCancelEventArgs e)
        {
            previousTab = MyNavigationPanel.SelectedTab;
        }

        private int month = DateTime.Now.Month;
        private int year = DateTime.Now.Year;
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            LoadDaysForMonth(month, year);
        }
        private void LoadDaysForMonth(int month, int year)
        {
            try
            {
                DateTime startOfTheMonth = new DateTime(year, month, 1);
                int daysInMonth = DateTime.DaysInMonth(year, month);
                int dayOfWeek = (int)startOfTheMonth.DayOfWeek;

                dayContainer.Controls.Clear();

                int currentDay = DateTime.Now.Day;

                for (int i = 0; i < dayOfWeek; i++)
                {
                    days empty = new days();
                    dayContainer.Controls.Add(empty);
                }

                for (int i = 1; i <= daysInMonth; i++)
                {
                    UserControlDays ucDays = new UserControlDays();
                    ucDays.daysll(i);

                    if (i == currentDay && month == DateTime.Now.Month && year == DateTime.Now.Year)
                    {
                        ucDays.HighlightToday();
                    }

                    dayContainer.Controls.Add(ucDays);
                }

                string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                lblDate.Text = monthname + " " + year;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Error loading days: {ex.Message}");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }

            LoadDaysForMonth(month, year);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }

            LoadDaysForMonth(month, year);
        }

        private void dayContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnUpdateRefesher_Click(object sender, EventArgs e)
        {
            await LoadInqueue();
            await CountAll();

            displayDays();
        }
    }
}
//179, 179