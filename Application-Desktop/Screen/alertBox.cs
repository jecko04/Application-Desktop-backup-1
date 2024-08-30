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

namespace Application_Desktop.Screen
{
    public partial class alertBox : Form
    {
        public alertBox()
        {
            InitializeComponent();
        }

        private int progress = 0;
        private void AlertTimer_Tick(object sender, EventArgs e)
        {
            progress += 2;
            AlertProgressBar.Width = progress;
            if (progress >= 400)
            {
                AlertTimer.Stop();
                this.Close();
            }
        }


        private void alertBox_Load_1(object sender, EventArgs e)
        {

            AlertTimer.Start();
        }

        public Color BackColorAlertBox
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public Color ColorAlertBox
        {
            get { return AlertProgressBar.BackColor; }
            set { AlertProgressBar.BackColor = AlertTitle.ForeColor = AlernSubTitle.ForeColor = value; }
        }

        public Image IconAlertBox
        {
            get { return AlertPicture.Image; }
            set { AlertPicture.Image = value; }
        }

        public string TitleAlertBox
        {
            get { return AlertTitle.Text; }
            set { AlertTitle.Text = value; }
        }

        public string SubTitleAlertBox
        {
            get { return AlernSubTitle.Text; }
            set { AlernSubTitle.Text = value; }
        }
    }
}
