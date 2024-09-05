using Application_Desktop.Models;
using Application_Desktop.Screen;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Application_Desktop.Models.EllipseManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Application_Desktop.Sub_sub_Views
{
    public partial class editBranch : Form
    {
        //469, 467
        private int branchID;
        public editBranch(int branchID, string bname, string bnum, string street, string brgy, string city, string province, string postal)
        {
            InitializeComponent();
            this.branchID = branchID;
            txtBname.Text = bname;
            txtBnum.Text = bnum;
            txtStreet.Text = street;
            txtBrgy.Text = brgy;
            txtCity.Text = city;
            txtProvince.Text = province;
            txtPostal.Text = postal;

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
        private void editBranch_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async Task UpdateBranch(int branchID, string bname, string bnum, string street, string brgy, string city, string province, string postal)
        {
            string query = "UPDATE branch  " +
                "SET " +
                "BranchName = @BranchName, " +
                "BuildingNumber = @BuildingNumber, " +
                "Street = @Street, " +
                "Barangay = @Barangay,  " +
                "City = @City, " +
                "Province = @Province," +
                " PostalCode = @PostalCode " +
                "WHERE Branch_ID = @BranchID";

            MySqlConnection conn = databaseHelper.getConnection();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BranchName", bname);
                    cmd.Parameters.AddWithValue("@BuildingNumber", bnum);
                    cmd.Parameters.AddWithValue("@Street", street);
                    cmd.Parameters.AddWithValue("@Barangay", brgy);
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@Province", province);
                    cmd.Parameters.AddWithValue("@PostalCode", postal);
                    cmd.Parameters.AddWithValue("@BranchID", branchID);

                    await cmd.ExecuteNonQueryAsync();

                    await transaction.CommitAsync();
                    //MessageBox.Show("Branch details updated successfully.");
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The branch data has been updated successfully", Properties.Resources.success);
                    this.Close();
                }
                catch (Exception transEx)
                {
                    // Rollback the transaction in case of an error
                    await transaction.RollbackAsync();
                    MessageBox.Show("Transaction failed: " + transEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                await conn.CloseAsync();
            }
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            string bname = txtBname.Text;
            string bnum = txtBnum.Text;
            string street = txtStreet.Text;
            string brgy = txtBrgy.Text;
            string city = txtCity.Text;
            string province = txtProvince.Text;
            string postal = txtPostal.Text;

            // Call method to update branch details
            await UpdateBranch(branchID, bname, bnum, street, brgy, city, province, postal);

            this.Close();
        }
    }
}
