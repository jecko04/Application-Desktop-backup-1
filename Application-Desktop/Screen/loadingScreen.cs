using Application_Desktop.Views;
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
    public partial class loadingScreen : Form
    {
        public loadingScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 1;
            int percentage = (panel2.Width * 100) / 540;
            label2.Text = percentage.ToString() + "%";
            if (panel2.Width >= 540)
            {
                timer1.Stop();
                loginPage form = new loginPage();
                form.Show();
                this.Hide();
            }
        }
    }
}
