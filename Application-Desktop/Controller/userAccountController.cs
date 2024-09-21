using Application_Desktop.Model;
using Application_Desktop.Screen;
using Application_Desktop.Sub_Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Controller
{
    public class userAccountController
    {
        private userAccountModel _userAccountModel;

        public userAccountController()
        {
            _userAccountModel = new userAccountModel();
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

        public async Task LoadUsersData(DataGridView viewUserAccount)
        {
            try
            {
                DataTable users = await _userAccountModel.GetAllUsers();
                viewUserAccount.DataSource = null;
                viewUserAccount.Rows.Clear();
                viewUserAccount.Columns.Clear();
                viewUserAccount.AutoGenerateColumns = false;

                AddColumnUsers(viewUserAccount);

                viewUserAccount.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error to LoadAvailableDentalServices data \n{ex.Message}");
            }
        }

        private void AddColumnUsers(DataGridView viewUserAccount)
        {
            viewUserAccount.RowHeadersVisible = false;
            viewUserAccount.ColumnHeadersHeight = 40;

            DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
            selectColumn.HeaderText = "";
            selectColumn.Name = "selectUser";
            selectColumn.DataPropertyName = "selectUser";
            selectColumn.ReadOnly = false;
            selectColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewUserAccount.Columns.Add(selectColumn);

            DataGridViewTextBoxColumn Id = new DataGridViewTextBoxColumn();
            Id.HeaderText = "ID";
            Id.Name = "id";
            Id.DataPropertyName = "id";
            viewUserAccount.Columns.Add(Id);

            DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
            Name.HeaderText = "Name";
            Name.Name = "name";
            Name.DataPropertyName = "name";
            viewUserAccount.Columns.Add(Name);
            
            DataGridViewTextBoxColumn Email = new DataGridViewTextBoxColumn();
            Email.HeaderText = "Email";
            Email.Name = "email";
            Email.DataPropertyName = "email";
            viewUserAccount.Columns.Add(Email);

            DataGridViewTextBoxColumn Description = new DataGridViewTextBoxColumn();
            Description.HeaderText = "Created";
            Description.Name = "created_at";
            Description.DataPropertyName = "created_at";
            viewUserAccount.Columns.Add(Description);

            DataGridViewTextBoxColumn Duration = new DataGridViewTextBoxColumn();
            Duration.HeaderText = "Updated";
            Duration.Name = "updated_at";
            Duration.DataPropertyName = "updated_at";
            viewUserAccount.Columns.Add(Duration);
        }

        public async Task DeleteUserData(DataGridView viewUserAccount)
        {
            foreach (DataGridViewRow row in viewUserAccount.Rows)
            {
                // Skip the new row placeholder
                if (row.IsNewRow) continue;

                // Access the checkbox cell and check if it's checked
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["selectUser"] as DataGridViewCheckBoxCell;

                // If the checkbox is selected (checked)
                if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                {

                    UserID user = new UserID
                    {
                        _userId = Convert.ToInt32(row.Cells["id"].Value)

                    };

                    bool success = await _userAccountModel.DeleteUser(user);

                    if (success)
                    {
                        viewUserAccount.Rows.Remove(row);
                    }
                }
            }
        }

    }
}
