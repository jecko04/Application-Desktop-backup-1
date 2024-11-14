using Application_Desktop.Controller;
using Application_Desktop.Method;
using Application_Desktop.Model;
using Application_Desktop.Screen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Application_Desktop.Models.EllipseManager;

namespace Application_Desktop.Admin_Sub_Views
{
    public partial class editPatientDetails : Form
    {
        private int id;
        private editPatientDetailsController _editPatientController;

        public editPatientDetails(int id)
        {
            _editPatientController = new editPatientDetailsController();
            this.id = id;
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
        private async void editPatientDetails_Load(object sender, EventArgs e)
        {
            try
            {
                int patientid = this.id;

                LoadToothSens(txtToothSens);

                getBranchIdByUserId branchId = new getBranchIdByUserId();
                BranchID adminId = await branchId.GetUserBranchId();

                var (patientData, genHealthData, dentHealthData) = await _editPatientController.EditPatient(patientid);

                if (patientData != null)
                {
                    txtFullnames.Text = patientData._fullname;
                    txtDOB.Value = patientData._dob;
                    txtAge.Text = patientData._age.ToString();
                    txtgenter.Text = patientData._gender;

                    if (patientData._gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
                    {
                        txtMale.Checked = true;
                    }
                    else if (patientData._gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
                    {
                        txtFemale.Checked = true;
                    }

                    txtContact.Text = patientData._contact;
                    txtEmail.Text = patientData._email;
                    txtAddress.Text = patientData._address;

                    txtEmergFullname.Text = patientData._emergency.Split('-')[0].Trim();
                    txtEmergContact.Text = patientData._emergency.Split('-')[1].Trim();
                }

                if (genHealthData != null)
                {
                    txtMedCondition.Text = genHealthData._medcondition;
                    txtCurrentMed.Text = genHealthData._currmedication;
                    txtAllergies.Text = genHealthData._allergies;
                    txtPastSurg.Text = genHealthData._pastsurg;
                    txtFamilyMed.Text = genHealthData._fammedhistory;
                    txtBloodPres.Text = genHealthData._bloodpressure;

                    chkHeartDisease.Checked = genHealthData._heartdisease;
                    chkDiabetes.Checked = genHealthData._diabetes;
                    chkSmoker.Checked = genHealthData._smoker;
                }

                if (dentHealthData != null)
                {
                    //txtLastVisit.Value = dentHealthData._lastvisit;
                    txtPastDent.Text = dentHealthData._pastdenttreatment;
                    txtToothSens.Text = dentHealthData._toothsens;

                    chkToothPain.Checked = dentHealthData._toothpain;
                    chkGumDisease.Checked = dentHealthData._gumdisease;
                    chkTeethGrin.Checked = dentHealthData._teethgrind;
                    chkOrtho.Checked = dentHealthData._ortho;
                    chkDentImp.Checked = dentHealthData._dentimps;
                    chkBleedGum.Checked = dentHealthData._bleedinggums;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Loading Data: {ex.Message}");
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
        private async Task Update(DentalPatient patient)
        {
            try
            {
                int patientid = this.id;

                if (patientid != null)
                {
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
                        //_lastvisit = txtLastVisit.Value,
                        _pastdenttreatment = txtPastDent.Text,
                        _toothpain = chkToothPain.Checked,
                        _gumdisease = chkGumDisease.Checked,
                        _teethgrind = chkTeethGrin.Checked,
                        _toothsens = txtToothSens.SelectedItem?.ToString() ?? string.Empty,
                        _ortho = chkOrtho.Checked,
                        _dentimps = chkDentImp.Checked,
                        _bleedinggums = chkBleedGum.Checked
                    };
                    await _editPatientController.UpdateDentalRecord(patient, genhealth, denthealth, patientid);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                await Update(patient);
                AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The patient record updated successfully", Properties.Resources.success);
            }
        }
        private Image selectedImage;
        private string selectedImagePath;

        private async void btnAddImages_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.tiff;*.bmp";

                // Show the dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the image into the PictureBox
                    XraysImage.Image = new Bitmap(openFileDialog.FileName);

                    selectedImage = XraysImage.Image;
                    selectedImagePath = openFileDialog.FileName;
                }
            }
        }

        private async void btnSaveImages_Click(object sender, EventArgs e)
        {
            if (selectedImage != null && !string.IsNullOrEmpty(selectedImagePath))
            {
                int patientId = this.id; 

                await _editPatientController.InsertImage(selectedImage, patientId, selectedImagePath).ConfigureAwait(false);

                MessageBox.Show("Image saved successfully.");
            }
            else
            {
                MessageBox.Show("No image selected.");
            }
        }
    }
}
