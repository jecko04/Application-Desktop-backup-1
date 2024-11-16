using Application_Desktop.Controller;
using Application_Desktop.Model;
using Application_Desktop.Screen;
using Google.Protobuf.WellKnownTypes;
using MaterialSkin.Controls;
using QRCoder;
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
    public partial class quickRetrievalData : MaterialForm
    {
        quickRetrievalDataController _quickRetrievalDataController;
        handleAppointment _handleAppointment;
        public PatientData PatientData { get; set; }
        public quickRetrievalData()
        {
            InitializeComponent();
            _quickRetrievalDataController = new quickRetrievalDataController();
            _handleAppointment = new handleAppointment();

            ApplyCustomFormatToDateTimePickers();

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

        /*private void GenerateQRCode(PatientData patientData)
        {
           
        }*/

        private void ApplyCustomFormatToDateTimePickers()
        {
            dtpRescheduleTime.Format = DateTimePickerFormat.Custom;
            dtpRescheduleTime.CustomFormat = "hh mm tt";
        }

        public void LoadPatientData(PatientData patientData)
        {
            PatientData = patientData;

            if (patientData == null || string.IsNullOrEmpty(patientData.Qrcode))
            {
                MessageBox.Show("QR code data is missing.");
                return;
            }

            string jsonData = patientData.Qrcode;

            try
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();

                QRCodeData qrCodeData = qrGenerator.CreateQrCode(jsonData, QRCodeGenerator.ECCLevel.Q);

                QRCode qrCode = new QRCode(qrCodeData);

                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                if (ptQrcode != null)
                {
                    ptQrcode.Image = qrCodeImage;
                }
                else
                {
                    MessageBox.Show("PictureBox (ptQrcode) is not initialized.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating QR code: {ex.Message}");
            }

            // Populate controls in the form with the patient data
            txtFullnames.Text = PatientData.FullName;
            txtDOB.Text = DateTime.TryParse(PatientData.DateOfBirth, out DateTime dateofbirth)
                ? dateofbirth.ToString("MM/dd/yyyy")
                : string.Empty;
            txtAge.Text = PatientData.Age;
            txtGender.Text = PatientData.Gender;
            txtContact.Text = PatientData.Phone;
            txtEmail.Text = PatientData.Email;
            txtAddress.Text = PatientData.Address;
            string emergencyContact = PatientData.EmergencyContact;

            string[] contactParts = emergencyContact.Split('-');

            if (contactParts.Length == 2)
            {
                txtEmergFullname.Text = contactParts[0];
                txtEmergContact.Text = contactParts[1];
            }
            else
            {
                MessageBox.Show("Emergency contact format is incorrect.");
            }

            txtMedCondition.Text = PatientData.MedicalConditions;
            txtCurrentMed.Text = PatientData.CurrentMedications;
            txtAllergies.Text = PatientData.Allergies;
            txtPastSurg.Text = PatientData.PastSurgeries;
            txtFamilyMed.Text = PatientData.FamilyMedicalHistory;
            txtBloodPres.Text = PatientData.BloodPressure;
            chkDiabetes.Checked = PatientData.Diabetes;
            chkHeartDisease.Checked = PatientData.HeartDisease;
            chkSmoker.Checked = PatientData.Smoker;

            txtPastDent.Text = PatientData.PastDentalTreatments;
            chkToothPain.Checked = PatientData.FrequentToothPain;
            chkGumDisease.Checked = PatientData.GumDiseaseHistory;
            chkBleedGum.Checked = PatientData.BleedingGums;
            chkOrtho.Checked = PatientData.OrthodonticTreatment;
            chkTeethGrin.Checked = PatientData.TeethGrinding;
            chkDentImp.Checked = PatientData.DentalImplants;
            txtToothSensitivity.Text = PatientData.ToothSensitivity;

            txtAppointmentId.Text = PatientData.AppointmentId.ToString() ?? "N/A";
            txtBranch.Text = PatientData.Branch;
            txtServices.Text = PatientData.Services;
            txtAppointmentDate.Text = DateTime.TryParse(PatientData.AppointmentDate, out DateTime appointmentDate)
                 ? appointmentDate.ToString("MM/dd/yyyy")
                 : string.Empty;

            txtAppointmentTime.Text = DateTime.TryParse(PatientData.AppointmentTime, out DateTime appointmentTime)
                ? appointmentTime.ToString("hh:mm tt")
                : string.Empty;

            txtRescheduleDate.Text = DateTime.TryParse(PatientData.RescheduleDate, out DateTime rescheduleDate)
                ? rescheduleDate.ToString("MM/dd/yyyy")
                : string.Empty;

            txtRescheduleTime.Text = DateTime.TryParse(PatientData.RescheduleTime, out DateTime rescheduleTime)
                ? rescheduleTime.ToString("hh:mm tt")
                : string.Empty;
            txtStatus.Text = PatientData.Status;
            txtCheckin.Text = PatientData.Check_In ? "Checked-In" : "Not Checked-In";
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmergContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private async void quickRetrievalData_Load(object sender, EventArgs e)
        {
            txtAddNotes.Text = await _quickRetrievalDataController.SelectNotes(PatientData.UserId);
            var services = await _quickRetrievalDataController.SelectPopulateServices(PatientData.SelectedBranch);

            cmbServices.DataSource = services;
            cmbServices.DisplayMember = "Title";
            cmbServices.ValueMember = "Categories_ID";
            cmbServices.SelectedValue = PatientData.SelectServices;

        }


        private async Task SaveNote()
        {
            btnSaveNotes.Enabled = false;
            btnSaveNotes.Text = "Saving...";
            try
            {
                string notes = txtAddNotes.Text;

                bool success = await _quickRetrievalDataController.SaveNotes(notes, PatientData.UserId, PatientData.Email);

                if (success)
                {
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Save Complete", "Saving successfully", Properties.Resources.success);
                }
                else
                {
                    AlertBox(Color.Red, Color.DarkRed, "Save Failed", "An error occurred while saving.", Properties.Resources.error);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error on saving notes {ex.Message}");
            }
            finally
            {
                btnSaveNotes.Enabled = true;
                btnSaveNotes.Text = "Save Notes";

            }
        }

        private async void btnSaveNotes_Click(object sender, EventArgs e)
        {
            await SaveNote();
        }

        private async Task Completed()
        {
            btnCompleted.Enabled = false;
            btnCompleted.Text = "Updating...";

            try
            {
                await Task.Delay(3000);

                string status = "completed";
                bool checkedIn = await _quickRetrievalDataController.IsCheckedIn(PatientData.AppointmentId);

                if (!checkedIn)
                {
                    btnCompleted.Enabled = true;
                    btnCompleted.Text = "Complete";
                    AlertBox(Color.LightCoral, Color.Red, "Check-In Required", "This appointment is not checked in.", Properties.Resources.error);
                    return;
                }

                await _quickRetrievalDataController.Complete(status, PatientData.AppointmentId);

                btnCompleted.Enabled = true;
                btnCompleted.Text = "Complete";
                AlertBox(Color.LightGreen, Color.SeaGreen, "Appointment Completed", "Appointment Change Status Successfully!", Properties.Resources.success);
            }
            catch (Exception ex)
            {
                throw new Exception($"error on updating to complete {ex.Message}");
            }
            finally
            {
                btnCompleted.Enabled = true;
                btnCompleted.Text = "Complete";
            }
        }

        private async void btnCompleted_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show(
                "Are you sure you want to complete this appointment?",
                "Confirm Complete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmationResult == DialogResult.Yes)
            {
                await Completed();
            }
            else
            {
                return;
            }


        }

        private async Task Reschedule()
        {
            btnReschedule.Enabled = false;
            btnReschedule.Text = "Updating...";

            try
            {
                await Task.Delay(3000);

                DateTime rescheduleDate = dtpRescheduleDate.Value;
                DateTime rescheduleTime = dtpRescheduleTime.Value;
                string reschedReason = txtRescheduleReason.Text;
                int services = (int)cmbServices.SelectedValue;

                if (string.IsNullOrEmpty(reschedReason))
                {
                    btnReschedule.Enabled = true;
                    btnReschedule.Text = "Reschedule";
                    AlertBox(Color.LightCoral, Color.Red, "Reschedule Reason Required", "reschedule failed.", Properties.Resources.error);
                    return;
                }

                await _quickRetrievalDataController.Rescheduled(PatientData.UserId, services, rescheduleDate, rescheduleTime);
                await _quickRetrievalDataController.RescheduleReason(PatientData.AppointmentId, PatientData.UserId, reschedReason);

                btnReschedule.Enabled = true;
                btnReschedule.Text = "Reschedule";
                AlertBox(Color.LightGreen, Color.SeaGreen, "Appointment Reschedule", "Appointment rescheduled successfully!", Properties.Resources.success);

            }
            catch (Exception ex)
            {
                throw new Exception($"Error in updating resched {ex.Message}");
            }
            finally
            {
                btnReschedule.Enabled = true;
                btnReschedule.Text = "Reschedule";
            }
        }

        private async void btnReschedule_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show(
                "Are you sure you want to reschedule this appointment?",
                "Confirm Reschedule",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmationResult == DialogResult.Yes)
            {
                await Reschedule();
            }
            else
            {
                return;
            }
        }

        public async Task CheckedIn()
        {
            btnCheckedIn.Enabled = false;
            btnCheckedIn.Text = "Updating...";

            try
            {
                await Task.Delay(3000);

                await _quickRetrievalDataController.UpdateCheckInStatus(PatientData.UserId, PatientData.AppointmentId);

                btnCheckedIn.Enabled = true;
                btnCheckedIn.Text = "Checked-In";
                AlertBox(Color.LightGreen, Color.SeaGreen, "Appointment Checked-In", "Appointment checked-in successfully!", Properties.Resources.success);

            }
            catch (Exception ex)
            {
                throw new Exception($"Error in updating resched {ex.Message}");
            }
            finally
            {
                btnCheckedIn.Enabled = true;
                btnCheckedIn.Text = "Checked-In";
            }
        }

        private async void btnCheckedIn_Click(object sender, EventArgs e)
        {
            await CheckedIn();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            if (PatientData != null)
            {
                txtAddNotes.Clear();
                ClearPatientData();

                PatientData = await _handleAppointment.GetPatientDataWithHistories(PatientData.UserId);


                LoadPatientData(PatientData);

                try
                {
                    string notes = await _quickRetrievalDataController.SelectNotes(PatientData.UserId);
                    txtAddNotes.Text = notes ?? "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving notes: {ex.Message}");
                }

            }
            else
            {
                MessageBox.Show("Patient data is not available.");
            }
        }

        public void ClearPatientData()
        {
            // Clear all text fields
            txtFullnames.Clear();
            txtDOB.Clear();
            txtAge.Clear();
            txtGender.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtEmergFullname.Clear();
            txtEmergContact.Clear();
            txtMedCondition.Clear();
            txtCurrentMed.Clear();
            txtAllergies.Clear();
            txtPastSurg.Clear();
            txtFamilyMed.Clear();
            txtBloodPres.Clear();
            txtPastDent.Clear();
            txtToothSensitivity.Clear();
            txtAppointmentId.Clear();
            txtBranch.Clear();
            txtServices.Clear();
            txtAppointmentDate.Clear();
            txtAppointmentTime.Clear();
            txtRescheduleDate.Clear();
            txtRescheduleTime.Clear();
            txtStatus.Clear();
            txtCheckin.Clear();

            // Clear Checkboxes
            chkDiabetes.Checked = false;
            chkHeartDisease.Checked = false;
            chkSmoker.Checked = false;
            chkToothPain.Checked = false;
            chkGumDisease.Checked = false;
            chkBleedGum.Checked = false;
            chkOrtho.Checked = false;
            chkTeethGrin.Checked = false;
            chkDentImp.Checked = false;

            // Clear PictureBox (if applicable)
            if (ptQrcode != null)
            {
                ptQrcode.Image = null;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
