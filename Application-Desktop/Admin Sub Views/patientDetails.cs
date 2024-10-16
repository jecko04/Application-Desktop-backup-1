using Application_Desktop.Controller;
using Application_Desktop.Method;
using Application_Desktop.Model;
using Application_Desktop.Screen;
using Mysqlx;
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
    public partial class patientDetails : Form
    {
        private patientDetailsController _patientController;
        public patientDetails()
        {
            InitializeComponent();
            _patientController = new patientDetailsController();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void patientDetails_Load(object sender, EventArgs e)
        {
            try
            {
                LoadToothSens(txtToothSens);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Load Data {ex.Message}");
            }
        }

        public void LoadToothSens(ComboBox toothsens)
        {
            toothsens.Items.Clear();

            toothsens.Items.Add("None");
            toothsens.Items.Add("Cold");
            toothsens.Items.Add("Hot");
            toothsens.Items.Add("Sweet");

            toothsens.SelectedItem = "None";
        }


        private async Task Create(DentalPatient patient)
        {
            try
            {
                getBranchIdByUserId branchId = new getBranchIdByUserId();
                BranchID branch = await branchId.GetUserBranchId();

                if (branch != null)
                {
                    int admin = branch._id;
                    GenHealth genhealth = new GenHealth
                    {
                        _medcondition = txtMedCondition.Text,
                        _currmedication = txtCurrentMed.Text,
                        _allergies = txtAllergies.Text,
                        _pastsurg = txtPastSurg.Text,
                        _fammedhistory = txtFamilyMed.Text,
                        _bloodpressure = txtBloodPres.Text,
                        _heartdisease = chkHeartDisease.Checked,
                        _diabetes = chkDiabetes.Checked,
                        _smoker = chkSmoker.Checked,
                    };

                    DentHealth denthealth = new DentHealth
                    {
                        _lastvisit = txtLastVisit.Value,
                        _pastdenttreatment = txtPastDent.Text,
                        _toothpain = chkToothPain.Checked,
                        _gumdisease = chkGumDisease.Checked,
                        _teethgrind = chkTeethGrin.Checked,
                        _toothsens = txtToothSens.SelectedItem?.ToString() ?? string.Empty,
                        _ortho = chkOrtho.Checked,
                        _dentimps = chkDentImp.Checked,
                        _bleedinggums = chkBleedGum.Checked
                    };
                    await _patientController.CreateDentalRecord(patient, genhealth, denthealth, admin);
                }
                else
                {
                    MessageBox.Show("Branch ID not found for the current user.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating dental record: {ex.Message}");
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContact1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmergContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBloodPres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/')
            {
                e.Handled = true; // Prevent non-numeric input
            }

            // If the user tries to input more than one decimal point, block it
            if (e.KeyChar == '/' && (sender as TextBox).Text.Contains('/'))
            {
                e.Handled = true; // Block additional decimal points
            }
        }

        private void dentalPatientTab_Click(object sender, EventArgs e)
        {

        }

        private async void btnSaveRecord_Click(object sender, EventArgs e)
        {
            var patient = new DentalPatient
            {
                _fullname = txtFullnames.Text,
                _age = int.TryParse(txtAge.Text, out int age) ? age : -1,
                _dob = txtDOB.Value,
                _gender = txtMale.Checked ? "Male" : txtFemale.Checked ? "Female" : string.Empty,
                _contact = txtContact.Text,
                _email = txtEmail.Text,
                _address = txtAddress.Text,
                _emergency = $"{txtEmergFullname.Text} - {txtEmergContact.Text}"
            };

            var validationErrors = patient.validate();
            errorProvider1.Clear();

            foreach (var error in validationErrors)
            {
                switch (error.Key)
                {
                    case "Fullname":
                        errorProvider1.SetError(txtFullnames, error.Value);
                        break;
                    case "Age":
                        errorProvider1.SetError(txtAge, error.Value);
                        break;
                    case "Gender":
                        errorProvider1.SetError(txtgenter, error.Value);
                        break;
                    case "Contact":
                        errorProvider1.SetError(txtContact, error.Value);
                        break;
                    case "Email":
                        errorProvider1.SetError(txtEmail, error.Value);
                        break;
                    case "Address":
                        errorProvider1.SetError(txtAddress, error.Value);
                        break;
                }
            }

            if (validationErrors.Count == 0)
            {
                await Create(patient);
                AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The patient record saved successfully", Properties.Resources.success);
            }
        }

        private void materialLabel14_Click(object sender, EventArgs e)
        {

        }

        private void tapPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
