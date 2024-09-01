using Application_Desktop.Models;
using Application_Desktop.Screen;
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
using static Application_Desktop.Models.EllipseManager;

namespace Application_Desktop.Sub_sub_Views
{
    public partial class registerBranches : Form
    {
        public registerBranches()
        {
            InitializeComponent();
            this.AcceptButton = btnSave;
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
                errorProvider1.SetError(borderBranch, "Branch Name is required.");
            }
            else
            {
                errorProvider1.SetError(borderBranch, string.Empty);
            }

            if (string.IsNullOrEmpty(houseNum))
            {
                errorProvider2.SetError(borderBuildingNumber, "House/Building Number is required.");
            }
            else
            {
                errorProvider2.SetError(borderBuildingNumber, string.Empty);
            }

            if (string.IsNullOrEmpty(street))
            {
                errorProvider3.SetError(borderStreet, "Street is required.");
            }
            else
            {
                errorProvider3.SetError(borderStreet, string.Empty);
            }

            if (string.IsNullOrEmpty(brgy))
            {
                errorProvider4.SetError(borderBrgy, "Barangay is required.");
            }
            else
            {
                errorProvider4.SetError(borderBrgy, string.Empty);
            }

            if (string.IsNullOrEmpty(city))
            {
                errorProvider5.SetError(borderCity, "City/Municipality is required.");
            }
            else
            {
                errorProvider5.SetError(borderCity, string.Empty);
            }

            if (string.IsNullOrEmpty(province))
            {
                errorProvider6.SetError(borderProvince, "Province is required.");
            }
            else
            {
                errorProvider6.SetError(borderProvince, string.Empty);
            }

            if (string.IsNullOrEmpty(postal))
            {
                errorProvider7.SetError(borderPostal, "Postal Code is required.");
            }
            else
            {
                errorProvider7.SetError(borderPostal, string.Empty);
            }


            if (string.IsNullOrEmpty(branchName))
            {
                errorProvider1.SetError(borderBranch, "Branch Name is required.");
            }
            else if (string.IsNullOrEmpty(houseNum))
            {
                errorProvider2.SetError(borderBuildingNumber, "House/Building Number is required.");
            }
            else if (string.IsNullOrEmpty(street))
            {
                errorProvider3.SetError(borderStreet, "Street is required.");
            }
            else if (string.IsNullOrEmpty(brgy))
            {
                errorProvider4.SetError(borderBrgy, "Barangay is required.");
            }
            else if (string.IsNullOrEmpty(city))
            {
                errorProvider5.SetError(borderCity, "City/Municipality is required.");
            }
            else if (string.IsNullOrEmpty(province))
            {
                errorProvider6.SetError(borderProvince, "Province is required.");
            }
            else if (string.IsNullOrEmpty(postal))
            {
                errorProvider7.SetError(borderPostal, "Postal Code is required.");
            }
            else if (
                errorProvider1.GetError(borderBranch) != string.Empty ||
                errorProvider2.GetError(borderBuildingNumber) != string.Empty ||
                errorProvider3.GetError(borderStreet) != string.Empty ||
                errorProvider4.GetError(borderBrgy) != string.Empty ||
                errorProvider5.GetError(borderCity) != string.Empty ||
                errorProvider6.GetError(borderProvince) != string.Empty ||
                errorProvider7.GetError(borderPostal) != string.Empty
                )
            {

            }
            else
            {
                string query = "INSERT INTO branch (BranchName, BuildingNumber, Street, Barangay, City, Province, PostalCode, created_at, updated_at) " +
                    "VALUES " +
                    "(@branchName, @houseNum, @street, @brgy, @city, @province, @postal, @createdAt, @updatedAt)";

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

                    DateTime now = DateTime.Now;
                    cmd.Parameters.AddWithValue("@createdAt", now);
                    cmd.Parameters.AddWithValue("@updatedAt", now);
                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("Save Successful");
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The branch data save successfully", Properties.Resources.success);

                    txtBranchName.Text = "";
                    txtHouseNum.Text = "";
                    txtStreet.Text = "";
                    txtBrgy.Text = "";
                    txtCityLists.Text = "";
                    txtProvinceList.Text = "";
                    txtPostal.Text = "";

                    errorProvider1.SetError(borderBranch, string.Empty);
                    errorProvider2.SetError(borderBuildingNumber, string.Empty);
                    errorProvider3.SetError(borderStreet, string.Empty);
                    errorProvider4.SetError(borderBrgy, string.Empty);
                    errorProvider5.SetError(borderCity, string.Empty);
                    errorProvider6.SetError(borderProvince, string.Empty);
                    errorProvider7.SetError(borderPostal, string.Empty);

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
