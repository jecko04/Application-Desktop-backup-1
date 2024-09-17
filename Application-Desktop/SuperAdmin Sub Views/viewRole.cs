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

namespace Application_Desktop.SuperAdmin_Sub_Views
{
    public partial class viewRole : Form
    {
        public viewRole()
        {
            InitializeComponent();
        }

        private async void viewRole_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            string query = @"Select Role_ID, RoleName From role";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open) { await conn.OpenAsync(); }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable datatable = new DataTable();

                adapter.Fill(datatable);

                viewExistingRole.DataSource = null;
                viewExistingRole.Rows.Clear();
                viewExistingRole.Columns.Clear();

                viewExistingRole.AutoGenerateColumns = false;

                AddColumnRole();

                viewExistingRole.DataSource = datatable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { await conn.CloseAsync(); }
        }

        private void AddColumnRole()
        {
            DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
            roleColumn.HeaderText = "ID";
            roleColumn.Name = "Role_ID";
            roleColumn.DataPropertyName = "Role_ID";
            roleColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewExistingRole.Columns.Add(roleColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Role Name";
            nameColumn.Name = "RoleName";
            nameColumn.DataPropertyName = "RoleName";
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            viewExistingRole.Columns.Add(nameColumn);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
