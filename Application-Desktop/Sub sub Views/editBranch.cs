using Application_Desktop.Models;
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

        public void UpdateBranch(int branchID, string bname, string bnum, string street, string brgy, string city, string province, string postal)
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
                    conn.Open();
                }
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BranchName", bname);
                cmd.Parameters.AddWithValue("@BuildingNumber", bnum);
                cmd.Parameters.AddWithValue("@Street", street);
                cmd.Parameters.AddWithValue("@Barangay", brgy);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Province", province);
                cmd.Parameters.AddWithValue("@PostalCode", postal);
                cmd.Parameters.AddWithValue("@BranchID", branchID);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Branch details updated successfully.");

                this.Close();
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            string bname = txtBname.Text;
            string bnum = txtBnum.Text;
            string street = txtStreet.Text;
            string brgy = txtBrgy.Text;
            string city = txtCity.Text;
            string province = txtProvince.Text;
            string postal = txtPostal.Text;

            // Call method to update branch details
            UpdateBranch(branchID, bname, bnum, street, brgy, city, province, postal);

            this.Close();
        }
    }
}
