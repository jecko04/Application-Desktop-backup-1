using Application_Desktop.Controller;
using Application_Desktop.Method;
using Application_Desktop.Screen;
using Application_Desktop.Sub_Views;
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
using System.Formats.Asn1;
using Application_Desktop.Model;
using Newtonsoft.Json;
using System.IO.Ports;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using Application_Desktop.Admin_Sub_Views;
using Org.BouncyCastle.Asn1.Cmp;

namespace Application_Desktop.Admin_Views
{
    public partial class handleAppointment : Form
    {
        private handleAppointmentController _handleAppointmentController;
        public handleAppointment()
        {
            InitializeComponent();
            _handleAppointmentController = new handleAppointmentController();

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

        private async void handleAppointment_Load(object sender, EventArgs e)
        {
            LoadButton();

            timer1.Tick += timer1_Tick;

            await LoadInqueue();
            await LoadApproved();
            await LoadCancelled();
            await LoadCompleted();

            viewPendingAppointment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewPendingAppointment.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            viewPendingAppointment.DefaultCellStyle.SelectionForeColor = Color.Black;
            viewPendingAppointment.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;
            viewPendingAppointment.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            viewPendingAppointment.ClearSelection();

            viewApprovedAppointment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewApprovedAppointment.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            viewApprovedAppointment.DefaultCellStyle.SelectionForeColor = Color.Black;
            viewApprovedAppointment.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;
            viewApprovedAppointment.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            viewApprovedAppointment.ClearSelection();

            viewCompletedAppointment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewCompletedAppointment.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            viewCompletedAppointment.DefaultCellStyle.SelectionForeColor = Color.Black;
            viewCompletedAppointment.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;
            viewCompletedAppointment.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            viewCompletedAppointment.ClearSelection();
        }


        private async Task LoadInqueue()
        {
            try
            {
                DataTable inqueue = await _handleAppointmentController.InqueueAppointment();
                viewPendingAppointment.DataSource = null;
                viewPendingAppointment.Rows.Clear();
                viewPendingAppointment.Columns.Clear();

                viewPendingAppointment.AutoGenerateColumns = false;
                AddColumnInqueue(viewPendingAppointment);

                viewPendingAppointment.DataSource = inqueue;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load patient records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadApproved()
        {
            try
            {
                getBranchIdByUserId branchId = new getBranchIdByUserId();
                BranchID adminId = await branchId.GetUserBranchId();
                DataTable approved = await _handleAppointmentController.ApprovedAppointment();
                viewApprovedAppointment.DataSource = null;
                viewApprovedAppointment.Rows.Clear();
                viewApprovedAppointment.Columns.Clear();

                viewApprovedAppointment.AutoGenerateColumns = false;
                AddColumnApproved(viewApprovedAppointment);

                viewApprovedAppointment.DataSource = approved;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load patient records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadCancelled()
        {
            try
            {
                getBranchIdByUserId branchId = new getBranchIdByUserId();
                BranchID adminId = await branchId.GetUserBranchId();
                DataTable cancelled = await _handleAppointmentController.CancelledAppointment();
                viewCancelledAppointment.DataSource = null;
                viewCancelledAppointment.Rows.Clear();
                viewCancelledAppointment.Columns.Clear();

                viewCancelledAppointment.AutoGenerateColumns = false;
                AddColumnCancelled(viewCancelledAppointment);

                viewCancelledAppointment.DataSource = cancelled;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load patient records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadCompleted()
        {
            try
            {
                getBranchIdByUserId branchId = new getBranchIdByUserId();
                BranchID adminId = await branchId.GetUserBranchId();
                DataTable completed = await _handleAppointmentController.CompletedAppointment();
                viewCompletedAppointment.DataSource = null;
                viewCompletedAppointment.Rows.Clear();
                viewCompletedAppointment.Columns.Clear();

                viewCompletedAppointment.AutoGenerateColumns = false;
                AddColumnCompleted(viewCompletedAppointment);

                viewCompletedAppointment.DataSource = completed;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load patient records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddColumnInqueue(DataGridView Inqueue)
        {
            Inqueue.RowHeadersVisible = false;
            Inqueue.ColumnHeadersHeight = 40;

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                Name = "id",
                DataPropertyName = "id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(id);

            DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "User ID",
                Name = "user_id",
                DataPropertyName = "user_id",
                Visible = false
            };
            Inqueue.Columns.Add(userIdColumn);

            DataGridViewTextBoxColumn fullname = new DataGridViewTextBoxColumn
            {
                HeaderText = "Fullname",
                Name = "fullname",
                DataPropertyName = "UserName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(fullname);

            DataGridViewTextBoxColumn branches = new DataGridViewTextBoxColumn
            {
                HeaderText = "Branch",
                Name = "branches",
                DataPropertyName = "BranchName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(branches);

            DataGridViewTextBoxColumn services = new DataGridViewTextBoxColumn
            {
                HeaderText = "Services",
                Name = "services",
                DataPropertyName = "ServiceTitle",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(services);

            DataGridViewTextBoxColumn appointment_date = new DataGridViewTextBoxColumn
            {
                HeaderText = "Appointment Date",
                Name = "appointmentDate",
                DataPropertyName = "appointment_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(appointment_date);

            DataGridViewTextBoxColumn appointment_time = new DataGridViewTextBoxColumn
            {
                HeaderText = "Appointment Time",
                Name = "appointmentTime",
                DataPropertyName = "appointment_time",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(appointment_time);

            DataGridViewTextBoxColumn reschedule_date = new DataGridViewTextBoxColumn
            {
                HeaderText = "Reschedule Date",
                Name = "rescheduleDate",
                DataPropertyName = "reschedule_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(reschedule_date);

            DataGridViewTextBoxColumn reschedule_time = new DataGridViewTextBoxColumn
            {
                HeaderText = "Reschedule Time",
                Name = "rescheduleTime",
                DataPropertyName = "reschedule_time",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(reschedule_time);

            DataGridViewTextBoxColumn status = new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                Name = "status",
                DataPropertyName = "status",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Inqueue.Columns.Add(status);
        }
        private void AddColumnApproved(DataGridView approved)
        {
            approved.RowHeadersVisible = false;
            approved.ColumnHeadersHeight = 40;

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                Name = "id",
                DataPropertyName = "id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            approved.Columns.Add(id);

            DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "User ID",
                Name = "user_id",
                DataPropertyName = "user_id",
                Visible = false
            };
            approved.Columns.Add(userIdColumn);

            DataGridViewTextBoxColumn fullname = new DataGridViewTextBoxColumn
            {
                HeaderText = "Fullname",
                Name = "fullname",
                DataPropertyName = "UserName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            approved.Columns.Add(fullname);

            DataGridViewTextBoxColumn branches = new DataGridViewTextBoxColumn
            {
                HeaderText = "Branch",
                Name = "branches",
                DataPropertyName = "BranchName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            approved.Columns.Add(branches);

            DataGridViewTextBoxColumn services = new DataGridViewTextBoxColumn
            {
                HeaderText = "Services",
                Name = "services",
                DataPropertyName = "ServiceTitle",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            approved.Columns.Add(services);

            DataGridViewTextBoxColumn appointment_date = new DataGridViewTextBoxColumn
            {
                HeaderText = "Appointment Date",
                Name = "appointmentDate",
                DataPropertyName = "appointment_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            approved.Columns.Add(appointment_date);

            DataGridViewTextBoxColumn appointment_time = new DataGridViewTextBoxColumn
            {
                HeaderText = "Appointment Time",
                Name = "appointmentTime",
                DataPropertyName = "appointment_time",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            approved.Columns.Add(appointment_time);

            DataGridViewTextBoxColumn reschedule_date = new DataGridViewTextBoxColumn
            {
                HeaderText = "Reschedule Date",
                Name = "rescheduleDate",
                DataPropertyName = "reschedule_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            approved.Columns.Add(reschedule_date);

            DataGridViewTextBoxColumn reschedule_time = new DataGridViewTextBoxColumn
            {
                HeaderText = "Reschedule Time",
                Name = "rescheduleTime",
                DataPropertyName = "reschedule_time",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            approved.Columns.Add(reschedule_time);

            DataGridViewTextBoxColumn status = new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                Name = "status",
                DataPropertyName = "status",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            approved.Columns.Add(status);

            DataGridViewTextBoxColumn check_in = new DataGridViewTextBoxColumn
            {
                HeaderText = "Check In",
                Name = "check_in",
                DataPropertyName = "check_in",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            approved.Columns.Add(check_in);

        }
        private void AddColumnCancelled(DataGridView cancelled)
        {
            cancelled.RowHeadersVisible = false;
            cancelled.ColumnHeadersHeight = 40;

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                Name = "id",
                DataPropertyName = "id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            cancelled.Columns.Add(id);

            DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "User ID",
                Name = "user_id",
                DataPropertyName = "user_id",
                Visible = false
            };
            cancelled.Columns.Add(userIdColumn);

            DataGridViewTextBoxColumn fullname = new DataGridViewTextBoxColumn
            {
                HeaderText = "Fullname",
                Name = "fullname",
                DataPropertyName = "UserName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            cancelled.Columns.Add(fullname);

            DataGridViewTextBoxColumn branches = new DataGridViewTextBoxColumn
            {
                HeaderText = "Branch",
                Name = "branches",
                DataPropertyName = "BranchName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            cancelled.Columns.Add(branches);

            DataGridViewTextBoxColumn services = new DataGridViewTextBoxColumn
            {
                HeaderText = "Services",
                Name = "services",
                DataPropertyName = "ServiceTitle",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            cancelled.Columns.Add(services);

            DataGridViewTextBoxColumn appointment_date = new DataGridViewTextBoxColumn
            {
                HeaderText = "Appointment Date",
                Name = "appointmentDate",
                DataPropertyName = "appointment_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            cancelled.Columns.Add(appointment_date);

            DataGridViewTextBoxColumn appointment_time = new DataGridViewTextBoxColumn
            {
                HeaderText = "Appointment Time",
                Name = "appointmentTime",
                DataPropertyName = "appointment_time",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            cancelled.Columns.Add(appointment_time);

            DataGridViewTextBoxColumn reschedule_date = new DataGridViewTextBoxColumn
            {
                HeaderText = "Reschedule Date",
                Name = "rescheduleDate",
                DataPropertyName = "reschedule_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            cancelled.Columns.Add(reschedule_date);

            DataGridViewTextBoxColumn reschedule_time = new DataGridViewTextBoxColumn
            {
                HeaderText = "Reschedule Time",
                Name = "rescheduleTime",
                DataPropertyName = "reschedule_time",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            cancelled.Columns.Add(reschedule_time);

            DataGridViewTextBoxColumn status = new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                Name = "status",
                DataPropertyName = "status",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            cancelled.Columns.Add(status);

            DataGridViewTextBoxColumn check_in = new DataGridViewTextBoxColumn
            {
                HeaderText = "Check In",
                Name = "check_in",
                DataPropertyName = "check_in",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            cancelled.Columns.Add(check_in);

        }
        private void AddColumnCompleted(DataGridView completed)
        {
            completed.RowHeadersVisible = false;
            completed.ColumnHeadersHeight = 40;

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                Name = "id",
                DataPropertyName = "id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            completed.Columns.Add(id);

            DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "User ID",
                Name = "user_id",
                DataPropertyName = "user_id",
                Visible = false
            };
            completed.Columns.Add(userIdColumn);

            DataGridViewTextBoxColumn branchId = new DataGridViewTextBoxColumn
            {
                HeaderText = "Brnach ID",
                Name = "branch_id",
                DataPropertyName = "selectedBranch",
                Visible = false
            };
            completed.Columns.Add(branchId);

            DataGridViewTextBoxColumn categoriesId = new DataGridViewTextBoxColumn
            {
                HeaderText = "Category ID",
                Name = "categories_id",
                DataPropertyName = "selectServices",
                Visible = false
            };
            completed.Columns.Add(categoriesId);

            DataGridViewTextBoxColumn fullname = new DataGridViewTextBoxColumn
            {
                HeaderText = "Fullname",
                Name = "fullname",
                DataPropertyName = "UserName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            completed.Columns.Add(fullname);

            DataGridViewTextBoxColumn branches = new DataGridViewTextBoxColumn
            {
                HeaderText = "Branch",
                Name = "branches",
                DataPropertyName = "BranchName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            completed.Columns.Add(branches);

            DataGridViewTextBoxColumn services = new DataGridViewTextBoxColumn
            {
                HeaderText = "Services",
                Name = "services",
                DataPropertyName = "ServiceTitle",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            completed.Columns.Add(services);

            DataGridViewTextBoxColumn appointment_date = new DataGridViewTextBoxColumn
            {
                HeaderText = "Appointment Date",
                Name = "appointmentDate",
                DataPropertyName = "appointment_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            completed.Columns.Add(appointment_date);

            DataGridViewTextBoxColumn appointment_time = new DataGridViewTextBoxColumn
            {
                HeaderText = "Appointment Time",
                Name = "appointmentTime",
                DataPropertyName = "appointment_time",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            completed.Columns.Add(appointment_time);

            DataGridViewTextBoxColumn reschedule_date = new DataGridViewTextBoxColumn
            {
                HeaderText = "Reschedule Date",
                Name = "rescheduleDate",
                DataPropertyName = "reschedule_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            completed.Columns.Add(reschedule_date);

            DataGridViewTextBoxColumn reschedule_time = new DataGridViewTextBoxColumn
            {
                HeaderText = "Reschedule Time",
                Name = "rescheduleTime",
                DataPropertyName = "reschedule_time",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            completed.Columns.Add(reschedule_time);

            DataGridViewTextBoxColumn status = new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                Name = "status",
                DataPropertyName = "status",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            completed.Columns.Add(status);

            DataGridViewTextBoxColumn check_in = new DataGridViewTextBoxColumn
            {
                HeaderText = "Check In",
                Name = "check_in",
                DataPropertyName = "check_in",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            completed.Columns.Add(check_in);

        }



        private int selectedAppointmentId;
        private int selectedUserId;
        private async void viewPendingAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = viewPendingAppointment.Rows[e.RowIndex];

                if (selectedRow.Cells["id"].Value != null &&
                    Int32.TryParse(selectedRow.Cells["id"].Value.ToString(), out selectedAppointmentId) &&
                    selectedRow.Cells["user_id"].Value != null &&
                    Int32.TryParse(selectedRow.Cells["user_id"].Value.ToString(), out selectedUserId))
                {

                    string userEmail = await _handleAppointmentController.SelectEmail(selectedUserId);

                    if (!string.IsNullOrEmpty(userEmail))
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show("No email found for the selected appointment.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to convert Appointment ID to integer.");
                }
            }
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
                            This is to notify you that your appointment with User ID 
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
                AlertBox(Color.LightGreen, Color.SeaGreen, "Email Sent!", "Notification sent successfully!", Properties.Resources.success);
                return true; // Email sent successfully
            }
            catch (Exception ex)
            {
                AlertBox(Color.LightCoral, Color.Red, "Failed to Send Email", "Unable to send email notification.", Properties.Resources.error);
                return false; // Failed to send email
            }
        }



        public async Task approved()
        {
            string value = "approved";

            if (selectedAppointmentId > 0)
            {
                await _handleAppointmentController.Approved(value, selectedAppointmentId);

                // Clear selection and reset the selectedAppointmentId
                viewPendingAppointment.ClearSelection();
                selectedAppointmentId = 0;

                AlertBox(Color.LightGreen, Color.SeaGreen, "Appointment Approved", "Appointment Set Successfully!", Properties.Resources.success);
            }

        }

        private async void btnApprove_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId > 0)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Do you want to approve this dental appointment?",
                    "Confirm Approval",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes)
                {
                    string userEmail = await _handleAppointmentController.SelectEmail(selectedUserId);

                    if (!string.IsNullOrEmpty(userEmail))
                    {
                        // Send email notification
                        bool emailSent = await SendEmailNotification(userEmail, selectedUserId.ToString(), "approved");

                        if (emailSent)
                        {
                            await approved();
                            await LoadInqueue();
                        }
                    }
                    else
                    {
                        MessageBox.Show("User email not found. Cannot send notification.");
                    }
                }
            }
            else
            {
                AlertBox(Color.LightSteelBlue, Color.DodgerBlue, "No Selected Appointment", "Select an appointment first to approve.", Properties.Resources.information);
            }
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
                                We regret to inform you that your appointment with User ID 
                                <strong>{appointmentId}</strong> has been <strong style=""color: #e74c3c;"">{status}</strong>.
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
                AlertBox(Color.LightGreen, Color.SeaGreen, "Email Sent!", "Cancellation notification sent successfully!", Properties.Resources.success);
                return true;
            }
            catch (Exception ex)
            {
                AlertBox(Color.LightCoral, Color.Red, "Failed to Send Email", $"Unable to send cancellation email: {ex.Message}", Properties.Resources.error);
                return false;
            }
        }
        public async Task cancelled()
        {
            string value = "cancelled";

            if (selectedAppointmentId > 0)
            {
                await _handleAppointmentController.Cancel(value, selectedAppointmentId);
                AlertBox(Color.LightGreen, Color.SeaGreen, "Appointment Cancelled", "Appointment Cancelled Successfully!", Properties.Resources.success);

                // Clear the selection and reset the selectedAppointmentId
                viewPendingAppointment.ClearSelection();
                selectedAppointmentId = 0;
            }
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId > 0)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Do you want to cancel this dental appointment?",
                    "Confirm Cancellation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes)
                {
                    await cancelled();

                    string userEmail = await _handleAppointmentController.SelectEmail(selectedUserId);

                    if (!string.IsNullOrEmpty(userEmail))
                    {
                        // Send email notification
                        bool emailSent = await SendCancelledNotification(userEmail, selectedUserId.ToString(), "cancelled");

                        if (emailSent)
                        {
                            await LoadInqueue();
                        }
                    }
                    else
                    {
                        MessageBox.Show("User email not found. Cannot send cancellation notification.");
                    }
                }
            }
            else
            {
                AlertBox(Color.LightSteelBlue, Color.DodgerBlue, "No Selected Appointment", "Select an appointment first to cancel.", Properties.Resources.information);
            }
        }

        private int ApprovedAppointmentId;
        private int selectedApprovedUserId;
        private async void viewApprovedAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = viewApprovedAppointment.Rows[e.RowIndex];

                if (selectedRow.Cells["id"].Value != null &&
                    Int32.TryParse(selectedRow.Cells["id"].Value.ToString(), out ApprovedAppointmentId) &&
                    selectedRow.Cells["user_id"].Value != null &&
                    Int32.TryParse(selectedRow.Cells["user_id"].Value.ToString(), out selectedApprovedUserId))
                {

                    string userEmail = await _handleAppointmentController.SelectEmail(selectedApprovedUserId);

                    if (!string.IsNullOrEmpty(userEmail))
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show("No email found for the selected appointment.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to convert Appointment ID to integer.");
                }
            }
        }

        private async Task completed()
        {
            string value = "completed";

            if (ApprovedAppointmentId > 0)
            {
                await _handleAppointmentController.Complete(value, ApprovedAppointmentId);
                AlertBox(Color.LightGreen, Color.SeaGreen, "Appointment Completed", "Appointment Completed Successfully!", Properties.Resources.success);

                // Clear the selection and reset the selectedAppointmentId
                viewApprovedAppointment.ClearSelection();
                ApprovedAppointmentId = 0;
            }

        }

        private async void btnComplete_Click(object sender, EventArgs e)
        {
            if (ApprovedAppointmentId > 0)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Do you want to change this dental appointment status to complete?",
                    "Confirm Completion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes)
                {
                    await completed();

                    await LoadApproved();
                }
                else
                {
                    MessageBox.Show("User email not found. Cannot send cancellation notification.");
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3)
            {
                btnComplete.Enabled = true;
            }
            else
            {
                btnComplete.Enabled = false;
            }

            if (tabControl1.SelectedTab == tabPage1)
            {
                btnInqueue.Visible = true;
            }
            else
            {
                btnInqueue.Visible = false;
            }

            /*if (tabControl1.SelectedTab == tabPage2)
            {
                btnApprove.Visible = true;
                btnCancel.Visible = true;
            }
            else
            {
                btnApprove.Visible = false;
                btnCancel.Visible = false;
            }*/
        }

        private void LoadButton()
        {
            btnComplete.Enabled = false;
            btnInqueue.Visible = false;
            /*btnPrintReceipt.Visible = false;
            btnReschedule.Visible = false;
            btnApprove.Visible = true;
            btnCancel.Visible = true;*/


            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
        }

        private async Task ConfirmCheckIn(string scannedValue)
        {
            try
            {
                // Deserialize the scanned JSON string
                var AppointmentData = JsonConvert.DeserializeObject<AppointmentData>(scannedValue);

                if (AppointmentData == null)
                {
                    MessageBox.Show("Invalid appointment data.");
                    return;
                }

                // Check if the appointment is approved
                var isApproved = await _handleAppointmentController.CheckAppointmentStatus(AppointmentData.userId, AppointmentData.appointment_date, AppointmentData.appointment_time);

                if (isApproved)
                {
                    // Update the check_in status in the database
                    await _handleAppointmentController.UpdateCheckInStatus(AppointmentData.userId, AppointmentData.appointment_date, AppointmentData.appointment_time);

                    AlertBox(Color.LightGreen, Color.SeaGreen, "Valid QRCode", "Check-in successful!", Properties.Resources.success);

                }
                else
                {
                    AlertBox(Color.LightCoral, Color.Red, "Not Valid QRCode", "Appointment is not approved or does not exist.", Properties.Resources.error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during check-in: {ex.Message}");
            }
            finally
            {
                QRCode.Focus();
            }
        }


        private void QRCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string scannedValue = QRCode.Text.Trim();

                _ = ConfirmCheckIn(scannedValue);

                QRCode.Clear();

                this.BeginInvoke((MethodInvoker)delegate
                {
                    QRCode.Focus();
                });
            }
        }

        private async void btnRefresher_Click(object sender, EventArgs e)
        {
            await LoadInqueue();
            viewPendingAppointment.ClearSelection();

            await LoadApproved();
            viewApprovedAppointment.ClearSelection();

            await LoadCancelled();
            viewCancelledAppointment.ClearSelection();

            await LoadCompleted();
            viewCompletedAppointment.ClearSelection();
        }

        bool isCollapsed = true;

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                qrCodePanel.Height += 10;
                if (qrCodePanel.Height >= 92)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                qrCodePanel.Height -= 10;
                if (qrCodePanel.Height <= 50)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }





        private receiptForm ReceiptFormInstance;


        private async void viewCompletedAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (viewCompletedAppointment.SelectedRows.Count > 0)
            {
                var selectedRow = viewCompletedAppointment.SelectedRows[0];
                int branchId = Convert.ToInt32(selectedRow.Cells["branch_id"].Value);
                int categoriesId = Convert.ToInt32(selectedRow.Cells["categories_id"].Value);

                var receiptDetails = await _handleAppointmentController.PrintReceiptDetails(branchId, categoriesId);

                if (ReceiptFormInstance == null || ReceiptFormInstance.IsDisposed)
                {
                    ReceiptFormInstance = new receiptForm();

                    ReceiptFormInstance.SetReceiptDetails(receiptDetails);
                    ReceiptFormInstance.Show();
                }
                else
                {
                    if (ReceiptFormInstance.Visible)
                    {
                        ReceiptFormInstance.BringToFront();
                    }
                    else
                    {
                        ReceiptFormInstance.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to print the receipt.");
            }
        }

        private printJobManagerForm PrintJobManagementInstance;
        private void btnInqueue_Click(object sender, EventArgs e)
        {
            if (PrintJobManagementInstance == null || PrintJobManagementInstance.IsDisposed)
            {
                PrintJobManagementInstance = new printJobManagerForm();

                PrintJobManagementInstance.Show();
            }
            else
            {
                if (PrintJobManagementInstance.Visible)
                {
                    PrintJobManagementInstance.BringToFront();
                }
                else
                {
                    PrintJobManagementInstance.Show();
                }
            }
        }
    }
}
