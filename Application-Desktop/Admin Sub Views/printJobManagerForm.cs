using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;
using System.Management;
using Application_Desktop.Screen;

namespace Application_Desktop.Admin_Sub_Views
{
    public partial class printJobManagerForm : Form
    {
        public printJobManagerForm()
        {
            InitializeComponent();
            InitializeDataGridView();

            viewPrintJob.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewPrintJob.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            viewPrintJob.DefaultCellStyle.SelectionForeColor = Color.Black;
            viewPrintJob.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;
            viewPrintJob.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            viewPrintJob.ClearSelection();
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

        private void InitializeDataGridView()
        {
            // Clear existing columns and add new columns
            viewPrintJob.Columns.Clear();
            viewPrintJob.Columns.Add("JobName", "Job Name");
            viewPrintJob.Columns.Add("Owner", "Owner");
            viewPrintJob.Columns.Add("Status", "Status");
        }


        private void printJobManagerForm_Load(object sender, EventArgs e)
        {
            LoadPrintJobsWMI();

        }

        private void LoadPrintJobsWMI()
        {
            viewPrintJob.Rows.Clear();

            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PrintJob");
            foreach (ManagementObject job in searcher.Get())
            {
                string jobName = job["Name"]?.ToString();
                string userName = job["Owner"]?.ToString();
                string status = job["Status"]?.ToString();

                // Add job details to the DataGridView
                viewPrintJob.Rows.Add(jobName, userName, status);
            }
        }


        private void btnCancelJob_Click(object sender, EventArgs e)
        {
            if (viewPrintJob.SelectedRows.Count > 0)
            {
                string jobName = viewPrintJob.SelectedRows[0].Cells["JobName"].Value.ToString();

                // Use WMI to cancel the print job
                CancelPrintJob(jobName);

                LoadPrintJobsWMI();
            }
            else
            {

                AlertBox(Color.LightSteelBlue, Color.DodgerBlue, "No selected Job Queue", "Select a print job to cancel.", Properties.Resources.information);
            }
        }

        private void CancelPrintJob(string jobName)
        {
            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PrintJob WHERE Name = '" + jobName + "'");
            foreach (ManagementObject job in searcher.Get())
            {
                // Call the Delete method to cancel the print job
                job.Delete();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPrintJobsWMI();
            viewPrintJob.ClearSelection();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewPrintJob_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
