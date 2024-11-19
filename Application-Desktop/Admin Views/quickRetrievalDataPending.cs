using Application_Desktop.Controller;
using Application_Desktop.Model;
using Application_Desktop.Screen;
using MaterialSkin.Controls;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Application_Desktop.Admin_Views
{
    public partial class quickRetrievalDataPending : MaterialForm
    {
        quickRetrievalDataController _quickRetrievalDataController;
        handleAppointment _handleAppointment;
        public PatientData PatientData { get; set; }

        public quickRetrievalDataPending()
        {
            InitializeComponent();
            _quickRetrievalDataController = new quickRetrievalDataController();
            _handleAppointment = new handleAppointment();

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
            txtAppointmentDate.Text = PatientData.AppointmentDate != DateTime.MinValue
                ? PatientData.AppointmentDate.ToString("MM/dd/yyyy")
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


        private void quickRetrievalDataPending_Load(object sender, EventArgs e)
        {

        }

        private async Task<bool> SendEmailNotification(string userEmail, string appointmentId, string status)
        {
            string fromEmail = "smtc.dentalcare@gmail.com";
            string appPassword = "pskv swrc tyqh hldz"; // Use the App Password here


            // Create a new MailMessage object
            MailMessage mail = new MailMessage(fromEmail, userEmail);
            mail.Subject = $"Update on Your Appointment Status";
            mail.IsBodyHtml = true;

            mail.Body = $@"<html>
                <body style=""font-family: Arial, sans-serif; color: #333; line-height: 1.6;"">
                    <div style=""max-width: 600px; margin: auto; padding: 20px; border: 1px solid #ccc; border-radius: 10px;"">
                        <h2 style=""color: #2c3e50; text-align: center;"">Appointment Status Update</h2>
                        <p>Dear Valued Patient,</p>

                        <p>
                            This is to notify you that your appointment with Appointment ID 
                            <strong>{appointmentId}</strong> has been marked as 
                            <strong style=""color: #27ae60;"">{status}</strong>.
                        </p>

                        <p>We sincerely appreciate your trust in us and look forward to seeing you soon!</p>

                        <p style=""text-align: center; font-style: italic; color: #7f8c8d;"">
                            ""Your smile is our top priority!""
                        </p>

                        <hr style=""border: 1px solid #ddd;"">

                        <footer style=""text-align: center;"">
                            <p style=""color: #2980b9; font-size: 16px; margin: 0;"">Ynares, DMJ Bldg, A. Mabini St, Rodriguez, Rizal</p>
                            <p style=""color: #2980b9; font-size: 16px; margin: 0;"">0933 821 2439</p>
                            <p style=""color: #2980b9; font-size: 16px; margin: 10px 0;"">P4JR+4J4, L.M.Santos St, Rosario, Rodriguez, 1860 Rizal</p>
                            <p style=""color: #2980b9; font-size: 16px; margin: 0;"">0933 821 2439</p>
                        </footer>

                        <p style=""text-align: center; color: #7f8c8d; font-size: 14px; margin-top: 20px;"">
                            Thank you for choosing our dental care. We are always here to assist you!
                        </p>
                    </div>
                </body>
              </html>";

            // Set up the SMTP client
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(fromEmail, appPassword),
                EnableSsl = true
            };



            try
            {
                await smtpClient.SendMailAsync(mail);

                return true;
            }
            catch (Exception ex)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    AlertBox(Color.LightCoral, Color.Red, "Failed to Send Email", "Unable to send notification.", Properties.Resources.error);

                });
                return false;
            }
        }

        private async Task<bool> SendSMSApproved(string phone, string appointmentId, string status)
        {
            const string accountId = "AC99fbd29885d0f879e600bb828ba7d859";
            const string authToken = "641177ec08958fbeb518ea79b5294fa0";

            TwilioClient.Init(accountId, authToken);

            try
            {
                var message = await MessageResource.CreateAsync(
                    body: $"Dear Valued Client,\n\nYour appointment (ID: {appointmentId}) has been successfully updated with the status: {status}.\n\nThank you for choosing SMTC Dental Care! We look forward to serving you.\n\nBest regards,\nSMTC Dental Care Team",
                    from: new Twilio.Types.PhoneNumber("+14843417234"),
                    to: new Twilio.Types.PhoneNumber(phone)
                );

                return message != null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending SMS: {ex.Message}");
                return false;
            }
        }

        private async Task<bool> SendSMSRejected(string phone, string appointmentId)
        {
            const string accountId = "AC99fbd29885d0f879e600bb828ba7d859";
            const string authToken = "641177ec08958fbeb518ea79b5294fa0";

            TwilioClient.Init(accountId, authToken);

            try
            {
                var message = await MessageResource.CreateAsync(
                    body: $"Dear Valued Client,\n\nWe regret to inform you that your appointment (ID: {appointmentId}) has been declined. We sincerely apologize for any inconvenience this may cause.\n\nPlease feel free to contact us at SMTC Dental Care for any further assistance.\n\nThank you for your understanding.\n\nBest regards,\nSMTC Dental Care Team",
                    from: new Twilio.Types.PhoneNumber("+14843417234"), // Replace with verified alphanumeric sender ID if available
                    to: new Twilio.Types.PhoneNumber(phone)
                );

                return message != null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending SMS: {ex.Message}");
                return false;
            }
        }

        private async Task approved()
        {
            btnApproved.Enabled = false;
            btnApproved.Text = "Updating...";
            try
            {
                DialogResult dialogResult = MessageBox.Show(
                       "Do you want to approve this dental appointment?",
                       "Confirm Approval",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question
                   );

                if (dialogResult == DialogResult.Yes)
                {
                    int userIdToApprove = PatientData.AppointmentId;
                    string email = PatientData.Email;
                    string status = "approved";

                    string phone = await _quickRetrievalDataController.SelectPhone(PatientData.UserId);
                    

                    if (!string.IsNullOrEmpty(email))
                    {
                        bool emailSent = await SendEmailNotification(email, userIdToApprove.ToString(), "approved");
                        bool phoneSent = await SendSMSApproved(phone, userIdToApprove.ToString(), "approved");

                        if (emailSent && phoneSent)
                        {
                            // Proceed with further actions after email is successfully sent
                            await _quickRetrievalDataController.Approved(status, userIdToApprove);
                            AlertBox(Color.LightGreen, Color.SeaGreen, "Approval Processed", "Appointment has been approved and notification sent.", Properties.Resources.success);
                           
                            return;
                        }
                        else
                        {
                            AlertBox(Color.LightCoral, Color.Red, "Email Notification Failed", "Approval processed, but email notification failed.", Properties.Resources.error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("User email not found. Cannot send notification.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error approving: {ex.Message}");
            }
            finally
            {
                btnApproved.Enabled = true;
                btnApproved.Text = "Approved";
            }
        }
        private async void btnApproved_Click(object sender, EventArgs e)
        {
            await approved();
        }

        private async Task<bool> SendCancelledNotification(string userEmail, string appointmentId, string status)
        {
            string fromEmail = "smtc.dentalcare@gmail.com";
            string appPassword = "pskv swrc tyqh hldz"; // Use the App Password here

            // Create a new MailMessage object
            MailMessage mail = new MailMessage(fromEmail, userEmail);
            mail.Subject = $"Update on Your Appointment Status";
            mail.IsBodyHtml = true;

            mail.Body = $@"<html>
                    <body style=""font-family: Arial, sans-serif; color: #333; line-height: 1.6;"">
                        <div style=""max-width: 600px; margin: auto; padding: 20px; border: 1px solid #ccc; border-radius: 10px;"">
                            <h2 style=""color: #c0392b; text-align: center;"">Appointment Status Update</h2>
                            <p>Dear Valued Patient,</p>

                            <p>
                                We regret to inform you that your appointment with Appointment ID 
                                <strong>{appointmentId}</strong> has been <strong style=""color: #e74c3c;"">rejected</strong>.
                            </p>

                            <p>We understand that this may be disappointing and apologize for any inconvenience caused. If you have any questions, please contact us at your earliest convenience.</p>

                            <p style=""text-align: center; font-style: italic; color: #7f8c8d;"">
                                ""Your smile is still our top priority!""
                            </p>

                            <hr style=""border: 1px solid #ddd;"">

                            <footer style=""text-align: center;"">
                                <p style=""color: #2980b9; font-size: 16px; margin: 0;"">Ynares, DMJ Bldg, A. Mabini St, Rodriguez, Rizal</p>
                                <p style=""color: #2980b9; font-size: 16px; margin: 0;"">0933 821 2439</p>
                                <p style=""color: #2980b9; font-size: 16px; margin: 10px 0;"">P4JR+4J4, L.M.Santos St, Rosario, Rodriguez, 1860 Rizal</p>
                                <p style=""color: #2980b9; font-size: 16px; margin: 0;"">0933 821 2439</p>
                            </footer>

                            <p style=""text-align: center; color: #7f8c8d; font-size: 14px; margin-top: 20px;"">
                                Thank you for understanding. We hope to serve you in the future!
                            </p>
                        </div>
                    </body>
                  </html>";

            // Set up the SMTP client
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(fromEmail, appPassword),
                EnableSsl = true
            };

            // Send the email
            try
            {
                await smtpClient.SendMailAsync(mail);


                return true;
            }
            catch (Exception ex)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    AlertBox(Color.LightCoral, Color.Red, "Failed to Send Email", $"Unable to send email: {ex.Message}", Properties.Resources.error);
                });
                return false;
            }
        }

        public async Task rejected()
        {
            btnReject.Enabled = false;
            btnReject.Text = "Updating...";
            try
            {
                DialogResult dialogResult = MessageBox.Show(
                       "Do you want to reject this dental appointment?",
                       "Confirm Approval",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question
                   );

                if (dialogResult == DialogResult.Yes)
                {
                    int userIdToApprove = PatientData.AppointmentId;
                    string email = PatientData.Email;
                    string status = "cancelled";

                    string phone = await _quickRetrievalDataController.SelectPhone(PatientData.UserId);


                    if (!string.IsNullOrEmpty(email))
                    {
                        bool emailSent = await SendCancelledNotification(email, userIdToApprove.ToString(), "cancelled");
                        bool phoneSent = await SendSMSRejected(phone, userIdToApprove.ToString());

                        if (emailSent && phoneSent)
                        {
                            // Proceed with further actions after email is successfully sent
                            await _quickRetrievalDataController.Cancel(status, userIdToApprove);                           
                            AlertBox(Color.LightGreen, Color.SeaGreen, "Rejection Processed", "Appointment has been rejected and notification sent.", Properties.Resources.success);
                         
                            return;
                        }
                        else
                        {
                            AlertBox(Color.LightCoral, Color.Red, "Email Notification Failed", "Approval processed, but email notification failed.", Properties.Resources.error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("User email not found. Cannot send notification.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error approving: {ex.Message}");
            }
            finally
            {
                btnReject.Enabled = true;
                btnReject.Text = "Reject";
            }
        }

        private async void btnReject_Click(object sender, EventArgs e)
        {
            await rejected();
        }
    }
}
