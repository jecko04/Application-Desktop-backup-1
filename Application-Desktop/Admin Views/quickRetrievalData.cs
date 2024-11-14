﻿using Application_Desktop.Controller;
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
        public PatientData PatientData { get; set; }
        public quickRetrievalData()
        {
            InitializeComponent();
            _quickRetrievalDataController = new quickRetrievalDataController();

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
            /*PatientData patientData = new PatientData();

            GenerateQRCode(patientData);*/

            txtAddNotes.Text = await _quickRetrievalDataController.SelectNotes(PatientData.UserId);
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
                    AlertBox(Color.LightCoral, Color.Red, "Check-In Required", "This appointment is not checked in.", Properties.Resources.error);
                    return;
                }

                await _quickRetrievalDataController.Complete(status, PatientData.AppointmentId);

                btnCompleted.Enabled = true;
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
            await Completed();
        }
    }
}