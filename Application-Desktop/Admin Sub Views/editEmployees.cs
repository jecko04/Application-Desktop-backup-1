using Application_Desktop.Models;
using Application_Desktop.Screen;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Application_Desktop.Models.EllipseManager;

namespace Application_Desktop.Admin_Sub_Views
{
    public partial class editEmployees : Form
    {
        private int employeesID;
        public editEmployees(int employeesID, string fname, string middle, string lname, DateTime doh, string email, string phone, string street, string barangay, string city, string province, string postalCode, string position, DateTime hired, string special)
        {
            InitializeComponent();
            this.employeesID = employeesID;

            txtfirstName.Text = fname;
            txtMiddleName.Text = middle;
            txtLastName.Text = lname;
            txtDateofBirth.Text = doh.ToString("yyyy/MM/dd");
            txtEmail.Text = email;
            txtMobile.Text = phone;

            txtStreet.Text = street;
            txtBrgy.Text = barangay;
            txtCity.Text = city;
            txtProvince.Text = province;
            txtPostalCode.Text = postalCode;

            txtPosition.Text = position;
            txtHired.Text = hired.ToString("yyyy/MM/dd");
            txtSpecial.Text = special;

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

        private void editEmployees_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task EmployeeUpdate()
        {

            //perosonal info
            string fullname = $"{txtfirstName.Text} {txtMiddleName.Text} {txtLastName.Text}";
            string doh = txtDateofBirth.Text;

            //contact info
            string email = txtEmail.Text;
            string mobile = txtMobile.Text;

            string address = $"{txtStreet.Text}, {txtBrgy.Text}, {txtCity.Text}, {txtProvince.Text}, {txtPostalCode.Text}";

            //professional info
            string position = txtPosition.Text;
            string hired = txtHired.Text;
            string special = txtSpecial.Text;


            string query = @"UPDATE employees SET
                    Fullname = @fullname,
                    Email = @email,
                    Phone = @phone,
                    DateOfBirth = @dateofbirth,
                    Address = @address,
                    Position = @position,
                    HireDate = @hired,
                    Specialization = @special,
                    updated_at = @updatedAt
                WHERE Employee_ID = @employee";

            MySqlConnection conn = databaseHelper.getConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@employee", employeesID);
                cmd.Parameters.AddWithValue("@fullname", fullname);
                cmd.Parameters.AddWithValue("@dateofbirth", doh);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", mobile);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@position", position);
                cmd.Parameters.AddWithValue("@hired", hired);

                cmd.Parameters.AddWithValue("@special", special);

                DateTime now = DateTime.Now;
                cmd.Parameters.AddWithValue("@updatedAt", now);
                await cmd.ExecuteNonQueryAsync();

                AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The employee data has been updated successfully", Properties.Resources.success);

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

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { await conn.CloseAsync(); }


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
                await EmployeeUpdate();
            }

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
