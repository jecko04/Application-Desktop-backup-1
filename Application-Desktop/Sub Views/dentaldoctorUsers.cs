using Application_Desktop.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Desktop.Sub_Views
{
    public partial class dentaldoctorUsers : Form
    {
        public dentaldoctorUsers()
        {
            InitializeComponent();
            LoadDentalData();
        }

        private void dentaldoctorUsers_Load(object sender, EventArgs e)
        {

        }

        private void LoadDentalData()
        {
            string query = "SELECT * FROM dentaldoctor";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                viewDentalAccount.DataSource = null;
                viewDentalAccount.Rows.Clear();
                viewDentalAccount.Columns.Clear();

                viewDentalAccount.DataSource = dataTable;

                DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn();
                editButtonColumn.HeaderText = "";
                editButtonColumn.Name = "view";
                editButtonColumn.Image = Properties.Resources.view;
                editButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                editButtonColumn.Width = 50;
                editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                viewDentalAccount.Columns.Add(editButtonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
