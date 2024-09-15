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

namespace Application_Desktop.Admin_Sub_Views
{
    public partial class registerEmployees : Form
    {
        public registerEmployees()
        {
            InitializeComponent();
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
        private int GetBranch()
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return branchID;
        }
        private async Task CreateEmployee()
        {


            //personal info
            DateTime dateofbirth = txtDateofBirth.Value;

            string fullname = $"{txtfirstName.Text} {txtMiddleName.Text} {txtLastName.Text}";


            //contact info
            string email = txtEmail.Text;
            string mobile = txtMobile.Text;

            string address = $"{txtStreet.Text}, {txtBrgy.Text}, {txtCity.Text}, {txtProvince.Text}, {txtPostalCode.Text}";

            //professional info
            string position = txtPosition.Text;
            DateTime hired = txtHired.Value;
            string special = txtSpecial.Text;

            int branchID = GetBranch();



            string query = @"INSERT INTO employees (Fullname, Email, Phone, DateOfBirth, Address, Position, HireDate, Specialization, Branch_ID, created_at, updated_at)
                            VALUES (@fullname, @email, @phone, @dateofbirth, @address, @position, @hiredate, @special, @branchID, @createdAt, @updatedAt)";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fullname", fullname);
                cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", mobile);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@position", position);
                cmd.Parameters.AddWithValue("@hiredate", hired.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@special", special);

                cmd.Parameters.AddWithValue("@branchID", branchID);

                DateTime now = DateTime.Now;
                cmd.Parameters.AddWithValue("@createdAt", now);
                cmd.Parameters.AddWithValue("@updatedAt", now);

                await cmd.ExecuteNonQueryAsync();

                AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The employee data saved successfully", Properties.Resources.success);

                txtfirstName.Text = "";
                txtMiddleName.Text = "";
                txtLastName.Text = "";

                txtEmail.Text = "";
                txtMobile.Text = "";
                txtStreet.Text = "";
                txtBrgy.Text = "";
                txtCity.Text = "";
                txtProvince.Text = "";
                txtPostalCode.Text = "";

                txtPosition.Text = "";
                txtSpecial.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }


        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Personal info
            string dateofbirth = txtDateofBirth.Text;
            string first = txtfirstName.Text;
            string middle = txtMiddleName.Text;
            string last = txtLastName.Text;

            // Contact info
            string email = txtEmail.Text;
            string mobile = txtMobile.Text;
            string street = txtStreet.Text;
            string barangay = txtBrgy.Text;
            string city = txtCity.Text;
            string province = txtProvince.Text;
            string postalCode = txtPostalCode.Text;

            // Professional info
            string position = txtPosition.Text;
            string hired = txtHired.Text;
            string special = txtSpecial.Text; // Optional

            bool hasError = false;

            // Personal info validation
            if (string.IsNullOrEmpty(first))
            {
                errorProvider1.SetError(borderFirst, "First name is required");
                hasError = true;
            }
            else
            {
                errorProvider1.SetError(borderFirst, string.Empty);
            }

            if (string.IsNullOrEmpty(middle))
            {
                errorProvider1.SetError(borderMiddle, "Middle name is required");
                hasError = true;
            }
            else
            {
                errorProvider1.SetError(borderMiddle, string.Empty);
            }

            if (string.IsNullOrEmpty(last))
            {
                errorProvider1.SetError(borderLast, "Last name is required");
                hasError = true;
            }
            else
            {
                errorProvider1.SetError(borderLast, string.Empty);
            }

            if (string.IsNullOrEmpty(dateofbirth))
            {
                errorProvider1.SetError(borderDateofBirth, "Date of birth is required");
                hasError = true;
            }
            else
            {
                errorProvider1.SetError(borderDateofBirth, string.Empty);
            }

            // Contact info validation
            if (string.IsNullOrEmpty(email))
            {
                errorProvider2.SetError(borderEmail, "Email is required");
                hasError = true;
            }
            else
            {
                errorProvider2.SetError(borderEmail, string.Empty);
            }

            if (string.IsNullOrEmpty(mobile))
            {
                errorProvider2.SetError(borderMobile, "Mobile number is required");
                hasError = true;
            }
            else
            {
                errorProvider2.SetError(borderMobile, string.Empty);
            }

            if (string.IsNullOrEmpty(street))
            {
                errorProvider2.SetError(borderStreet, "Street address is required");
                hasError = true;
            }
            else
            {
                errorProvider2.SetError(borderStreet, string.Empty);
            }

            if (string.IsNullOrEmpty(barangay))
            {
                errorProvider2.SetError(borderBrgy, "Barangay is required");
                hasError = true;
            }
            else
            {
                errorProvider2.SetError(borderBrgy, string.Empty);
            }

            if (string.IsNullOrEmpty(city))
            {
                errorProvider2.SetError(borderCity, "City is required");
                hasError = true;
            }
            else
            {
                errorProvider2.SetError(borderCity, string.Empty);
            }

            if (string.IsNullOrEmpty(province))
            {
                errorProvider2.SetError(borderProvince, "Province is required");
                hasError = true;
            }
            else
            {
                errorProvider2.SetError(borderProvince, string.Empty);
            }

            if (string.IsNullOrEmpty(postalCode))
            {
                errorProvider2.SetError(borderPostal, "Postal code is required");
                hasError = true;
            }
            else
            {
                errorProvider2.SetError(borderPostal, string.Empty);
            }

            // Professional info validation
            if (string.IsNullOrEmpty(position))
            {
                errorProvider3.SetError(borderPosition, "Position is required");
                hasError = true;
            }
            else
            {
                errorProvider3.SetError(borderPosition, string.Empty);
            }

            if (string.IsNullOrEmpty(hired))
            {
                errorProvider3.SetError(borderHired, "Hire date is required");
                hasError = true;
            }
            else
            {
                errorProvider3.SetError(borderHired, string.Empty);
            }

            errorProvider3.SetError(borderSpecial, string.Empty);

            // Final check if any errors occurred
            if (!hasError)
            {
                await CreateEmployee();
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            // Get the TextBox control that triggered the event
            TextBox txtBox = sender as TextBox;
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtBox.Text, @"^\d*$"))
            {
                // If the text contains non-digit characters, clear the TextBox or handle it as needed
                txtBox.Text = new string(txtBox.Text.Where(char.IsDigit).ToArray());
                txtBox.SelectionStart = txtBox.Text.Length;
            }
        }
    }
}
