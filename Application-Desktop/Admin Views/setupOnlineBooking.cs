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

namespace Application_Desktop.Admin_Views
{
    public partial class setupOnlineBooking : Form
    {
        public setupOnlineBooking()
        {
            InitializeComponent();
        }

        private void setupOnlineBooking_Load(object sender, EventArgs e)
        {

        }

        private async Task GetBranch()
        {
            int adminId = session.LoggedInSession;


        }
        private async Task FetchDayofWeek(string dayofweek)
        {
            string query = @"SELECT DayOfWeek from office_hours Where ";
        }

        private void view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
