﻿using Application_Desktop.Admin_Sub_Views;
using Application_Desktop.Models;
using Application_Desktop.Sub_sub_Views;
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

namespace Application_Desktop.Admin_Views
{
    public partial class doctorsAccount : Form
    {
        public doctorsAccount()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            int adminBranchID = session.LoggedInSession;
            int branchID = -1;

            string getBranchID = "SELECT Branch_ID FROM admin WHERE Admin_ID = @adminID";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand getBranchIDCmd = new MySqlCommand(getBranchID, conn);
                getBranchIDCmd.Parameters.AddWithValue("@adminID", adminBranchID);

                MySqlDataReader branchIDReader = getBranchIDCmd.ExecuteReader();
                if (branchIDReader.Read())
                {
                    branchID = Convert.ToInt32(branchIDReader["Branch_ID"]);
                }
                branchIDReader.Close();

                // Check if adminBranchID was correctly retrieved
                if (branchID == -1)
                {
                    MessageBox.Show("Failed to retrieve the admin's branch ID.");
                    return;
                }

                // Select Account base on Branch
                string query = @"SELECT 
                             dentaldoctor.Doctors_ID,
                             dentaldoctor.Name, 
                             dentaldoctor.Email, 
                             dentaldoctor.Password, 
                             branch.BranchName AS BranchName, 
                             role.RoleName AS RoleName,
                             admin.Name AS CreatedByName, 
                             dentaldoctor.Role_ID,
                             dentaldoctor.Branch_ID
                             FROM dentaldoctor
                             JOIN branch ON dentaldoctor.Branch_ID = branch.Branch_ID
                             JOIN admin ON dentaldoctor.CreatedBy = admin.Admin_ID
                             JOIN role ON dentaldoctor.Role_ID = role.Role_ID
                             Where dentaldoctor.Branch_ID = @branchID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@branchID", branchID);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                viewDentalDoctorAccount.DataSource = null;
                viewDentalDoctorAccount.Rows.Clear();
                viewDentalDoctorAccount.Columns.Clear();

                viewDentalDoctorAccount.AutoGenerateColumns = false;

                AddColumnDentalDoctor();

                viewDentalDoctorAccount.DataSource = datatable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        // Column
        private void AddColumnDentalDoctor()
        {
            DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
            selectColumn.HeaderText = "";
            selectColumn.Name = "selectDoctors";
            selectColumn.Width = 30;
            viewDentalDoctorAccount.Columns.Add(selectColumn);
            viewDentalDoctorAccount.Columns["selectDoctors"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewTextBoxColumn adminColumn = new DataGridViewTextBoxColumn();
            adminColumn.HeaderText = "Doctors ID";
            adminColumn.Name = "Doctors_ID";
            adminColumn.DataPropertyName = "Doctors_ID";
            viewDentalDoctorAccount.Columns.Add(adminColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "Name";
            nameColumn.DataPropertyName = "Name";
            viewDentalDoctorAccount.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.HeaderText = "Email";
            emailColumn.Name = "Email";
            emailColumn.DataPropertyName = "Email";
            viewDentalDoctorAccount.Columns.Add(emailColumn);

            DataGridViewTextBoxColumn passwordColumn = new DataGridViewTextBoxColumn();
            passwordColumn.HeaderText = "Password";
            passwordColumn.Name = "Password";
            passwordColumn.DataPropertyName = "Password";
            viewDentalDoctorAccount.Columns.Add(passwordColumn);


            DataGridViewTextBoxColumn branchColumn = new DataGridViewTextBoxColumn();
            branchColumn.HeaderText = "Branch";
            branchColumn.Name = "Branch_ID";
            branchColumn.DataPropertyName = "BranchName";
            viewDentalDoctorAccount.Columns.Add(branchColumn);

            DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
            roleColumn.HeaderText = "Role";
            roleColumn.Name = "Role_ID";
            roleColumn.DataPropertyName = "RoleName";
            viewDentalDoctorAccount.Columns.Add(roleColumn);

            DataGridViewTextBoxColumn createdByColumn = new DataGridViewTextBoxColumn();
            createdByColumn.HeaderText = "Created By";
            createdByColumn.Name = "CreatedBy";
            createdByColumn.DataPropertyName = "CreatedByName";
            viewDentalDoctorAccount.Columns.Add(createdByColumn);

            DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn();
            editButtonColumn.HeaderText = "";
            editButtonColumn.Name = "edit";
            editButtonColumn.Image = Properties.Resources.edit_img;
            editButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editButtonColumn.Width = 50;
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            viewDentalDoctorAccount.Columns.Add(editButtonColumn);

            DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Name = "delete";
            deleteButtonColumn.Image = Properties.Resources.delete_img;
            deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            deleteButtonColumn.Width = 50;
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            viewDentalDoctorAccount.Columns.Add(deleteButtonColumn);

            DataGridViewImageColumn changeButtonColumn = new DataGridViewImageColumn();
            changeButtonColumn.HeaderText = "";
            changeButtonColumn.Name = "change";
            changeButtonColumn.Image = Properties.Resources.change;
            changeButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            changeButtonColumn.Width = 50;
            changeButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            viewDentalDoctorAccount.Columns.Add(changeButtonColumn);
        }

        private registerDentalDoctorAccount RegisterDentalDoctorInstance;
        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            if (RegisterDentalDoctorInstance == null || RegisterDentalDoctorInstance.IsDisposed)
            {
                RegisterDentalDoctorInstance = new registerDentalDoctorAccount();
                RegisterDentalDoctorInstance.Show();
            }
            else
            {
                if (RegisterDentalDoctorInstance.Visible)
                {
                    RegisterDentalDoctorInstance.BringToFront();
                }
                else
                {
                    RegisterDentalDoctorInstance.Show();
                }
            }
        }

        private changeDentalDoctorsPass changeDentalDoctorsPassInstance;
        private editDentalDoctorAccounts editDentalDoctorAccountsInstance;
        private void viewDentalDoctorAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //update
            if (viewDentalDoctorAccount.Columns["edit"] != null &&
        e.ColumnIndex == viewDentalDoctorAccount.Columns["edit"].Index && e.RowIndex >= 0)
            {

                int doctorsID = Convert.ToInt32(viewDentalDoctorAccount.Rows[e.RowIndex].Cells["Doctors_ID"].Value);
                string fullname = viewDentalDoctorAccount.Rows[e.RowIndex].Cells["Name"].Value?.ToString() ?? string.Empty;
                string[] nameParts = fullname.Split(new char[] { ' ' }, 2);
                string fname = nameParts[0];
                string lname = nameParts.Length > 1 ? nameParts[1] : string.Empty;

                string email = viewDentalDoctorAccount.Rows[e.RowIndex].Cells["Email"].Value?.ToString() ?? string.Empty;
                string pwd = viewDentalDoctorAccount.Rows[e.RowIndex].Cells["Password"].Value?.ToString() ?? string.Empty;

                string role = viewDentalDoctorAccount.Rows[e.RowIndex].Cells["Role_ID"].Value?.ToString() ?? string.Empty;
                string branch = viewDentalDoctorAccount.Rows[e.RowIndex].Cells["Branch_ID"].Value?.ToString() ?? string.Empty;

                if (editDentalDoctorAccountsInstance == null || editDentalDoctorAccountsInstance.IsDisposed)
                {
                    editDentalDoctorAccountsInstance = new editDentalDoctorAccounts(doctorsID, fname, lname, email, pwd, role, branch);
                    editDentalDoctorAccountsInstance.Show();
                }
                else
                {
                    if (editDentalDoctorAccountsInstance.Visible)
                    {
                        editDentalDoctorAccountsInstance.BringToFront();
                    }
                    else
                    {
                        editDentalDoctorAccountsInstance.Show();
                    }
                }
            }

            //delete
            if (e.RowIndex >= 0 && e.ColumnIndex == viewDentalDoctorAccount.Columns["delete"].Index)
            {
                DialogResult result = MessageBox.Show("Would you like to proceed with deleting this account?", "Confirm Deletions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int doctors_ID = Convert.ToInt32(viewDentalDoctorAccount.Rows[e.RowIndex].Cells["Doctors_ID"].Value);

                    // Delete row from database
                    DeleteRowFromDatabase(doctors_ID);
                    LoadData();
                }
            }

            //change password
            if (viewDentalDoctorAccount.Columns["change"] != null &&
            e.ColumnIndex == viewDentalDoctorAccount.Columns["change"].Index && e.RowIndex >= 0)
            {

                int doctorsID = Convert.ToInt32(viewDentalDoctorAccount.Rows[e.RowIndex].Cells["Doctors_ID"].Value);

                if (changeDentalDoctorsPassInstance == null || changeDentalDoctorsPassInstance.IsDisposed)
                {
                    changeDentalDoctorsPassInstance = new changeDentalDoctorsPass(doctorsID);
                    changeDentalDoctorsPassInstance.Show();
                }
                else
                {
                    if (changeDentalDoctorsPassInstance.Visible)
                    {
                        changeDentalDoctorsPassInstance.BringToFront();
                    }
                    else
                    {
                        changeDentalDoctorsPassInstance.Show();
                    }
                }
            }
            //Select Check Box
            if (e.ColumnIndex == viewDentalDoctorAccount.Columns["selectDoctors"].Index)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)viewDentalDoctorAccount.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Value = !(cell.Value is bool && (bool)cell.Value); // Toggle checkbox value
            }
        }



        public int DeleteRowFromDatabase(int doctorsID)
        {
            string query = "Delete From dentaldoctor Where Doctors_ID = @doctorsID";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@doctorsID", doctorsID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return doctorsID;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //refresh button
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                viewDentalDoctorAccount.EndEdit();

                // Deleting from viewAdminData
                for (int i = viewDentalDoctorAccount.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = viewDentalDoctorAccount.Rows[i];
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["selectDoctors"] as DataGridViewCheckBoxCell;

                    // Check if the checkbox is checked
                    if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                    {
                        // Get the ID of the admin to delete
                        int doctorsID = Convert.ToInt32(row.Cells["Doctors_ID"].Value);
                        viewDentalDoctorAccount.Rows.RemoveAt(i);
                        DeleteRowFromDatabase(doctorsID);
                    }
                }
            }
        }
    }
}