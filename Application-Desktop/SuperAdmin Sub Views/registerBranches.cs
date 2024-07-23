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

namespace Application_Desktop.Sub_sub_Views
{
    public partial class registerBranches : Form
    {
        public registerBranches()
        {
            InitializeComponent();
            this.AcceptButton = btnSave;
        }

        private void registerBranches_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string branchName = txtBranchName.Text;
            string houseNum = txtHouseNum.Text;
            string street = txtStreet.Text;
            string brgy = txtBrgy.Text;
            string city = txtCityLists.Text;
            string province = txtProvinceList.Text;
            string postal = txtPostal.Text;


            //Error Provider
            if (string.IsNullOrEmpty(branchName))
            {
                errorProvider1.SetError(txtBranchName, "Branch Name is required.");
            }
            else
            {
                errorProvider1.SetError(txtBranchName, string.Empty);
            }

            if (string.IsNullOrEmpty(houseNum))
            {
                errorProvider2.SetError(txtHouseNum, "House/Building Number is required.");
            }
            else
            {
                errorProvider2.SetError(txtHouseNum, string.Empty);
            }

            if (string.IsNullOrEmpty(street))
            {
                errorProvider3.SetError(txtStreet, "Street is required.");
            }
            else
            {
                errorProvider3.SetError(txtStreet, string.Empty);
            }

            if (string.IsNullOrEmpty(brgy))
            {
                errorProvider4.SetError(txtBrgy, "Barangay is required.");
            }
            else
            {
                errorProvider4.SetError(txtBrgy, string.Empty);
            }

            if (string.IsNullOrEmpty(city))
            {
                errorProvider5.SetError(txtCityLists, "City/Municipality is required.");
            }
            else
            {
                errorProvider5.SetError(txtCityLists, string.Empty);
            }

            if (string.IsNullOrEmpty(province))
            {
                errorProvider6.SetError(txtProvinceList, "Province is required.");
            }
            else
            {
                errorProvider6.SetError(txtProvinceList, string.Empty);
            }

            if (string.IsNullOrEmpty(postal))
            {
                errorProvider7.SetError(txtPostal, "Postal Code is required.");
            }
            else
            {
                errorProvider7.SetError(txtPostal, string.Empty);
            }


            if (string.IsNullOrEmpty(branchName))
            {
                errorProvider1.SetError(txtBranchName, "Branch Name is required.");
            }
            else if (string.IsNullOrEmpty(houseNum))
            {
                errorProvider2.SetError(txtHouseNum, "House/Building Number is required.");
            }
            else if (string.IsNullOrEmpty(street))
            {
                errorProvider3.SetError(txtStreet, "Street is required.");
            }
            else if (string.IsNullOrEmpty(brgy))
            {
                errorProvider4.SetError(txtBrgy, "Barangay is required.");
            }
            else if (string.IsNullOrEmpty(city))
            {
                errorProvider5.SetError(txtCityLists, "City/Municipality is required.");
            }
            else if (string.IsNullOrEmpty(province))
            {
                errorProvider6.SetError(txtProvinceList, "Province is required.");
            }
            else if (string.IsNullOrEmpty(postal))
            {
                errorProvider7.SetError(txtPostal, "Postal Code is required.");
            }
            else if (
                errorProvider1.GetError(txtBranchName) != string.Empty ||
                errorProvider2.GetError(txtHouseNum) != string.Empty ||
                errorProvider3.GetError(txtStreet) != string.Empty ||
                errorProvider4.GetError(txtBrgy) != string.Empty ||
                errorProvider5.GetError(txtCityLists) != string.Empty ||
                errorProvider6.GetError(txtProvinceList) != string.Empty ||
                errorProvider7.GetError(txtPostal) != string.Empty
                )
            {

            }
            else
            {
                string query = "INSERT INTO branch (BranchName, BuildingNumber, Street, Barangay, City, Province, PostalCode) " +
                    "VALUES " +
                    "(@branchName, @houseNum, @street, @brgy, @city, @province, @postal)";

                MySqlConnection conn = databaseHelper.getConnection();
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@branchName", branchName);
                    cmd.Parameters.AddWithValue("@houseNum", houseNum);
                    cmd.Parameters.AddWithValue("@street", street);
                    cmd.Parameters.AddWithValue("@brgy", brgy);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@province", province);
                    cmd.Parameters.AddWithValue("@postal", postal);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Save Successful");
                    txtBranchName.Text = "";
                    txtHouseNum.Text = "";
                    txtStreet.Text = "";
                    txtBrgy.Text = "";
                    txtCityLists.Text = "";
                    txtProvinceList.Text = "";
                    txtPostal.Text = "";

                    errorProvider1.SetError(txtBranchName, string.Empty);
                    errorProvider2.SetError(txtHouseNum, string.Empty);
                    errorProvider3.SetError(txtStreet, string.Empty);
                    errorProvider4.SetError(txtBrgy, string.Empty);
                    errorProvider5.SetError(txtCityLists, string.Empty);
                    errorProvider6.SetError(txtProvinceList, string.Empty);
                    errorProvider7.SetError(txtPostal, string.Empty);

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
}
