using Application_Desktop.Admin_Sub_Views;
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

namespace Application_Desktop.Admin_Views
{
    public partial class patientRecord : Form
    {
        public patientRecord()
        {
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void patientRecord_Load(object sender, EventArgs e)
        {

        }

        private void viewPatientRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private patientDetails PatientDetailsInstance;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (PatientDetailsInstance == null || PatientDetailsInstance.IsDisposed)
            {
                PatientDetailsInstance = new patientDetails();
                PatientDetailsInstance.Show();
            }
            else
            {
                if (PatientDetailsInstance.Visible)
                {
                    PatientDetailsInstance.BringToFront();
                }
                else
                {
                    PatientDetailsInstance.Show();
                }
            }
        }
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
