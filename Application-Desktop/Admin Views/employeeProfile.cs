using Application_Desktop.Admin_Sub_Views;
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
    public partial class employeeProfile : Form
    {
        public employeeProfile()
        {
            InitializeComponent();
        }

        private void employeeProfile_Load(object sender, EventArgs e)
        {

        }

        private void CreateEmployees()
        {

        }

        private createEmployees CreateEmployeesInstance;

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            if (CreateEmployeesInstance == null || CreateEmployeesInstance.IsDisposed)
            {
                CreateEmployeesInstance = new createEmployees();
                CreateEmployeesInstance.Show();
            }
            else
            {
                if (CreateEmployeesInstance.Visible)
                {
                    CreateEmployeesInstance.BringToFront();
                }
                else
                {
                    CreateEmployeesInstance.Show();
                }
            }
        }
    }
}
