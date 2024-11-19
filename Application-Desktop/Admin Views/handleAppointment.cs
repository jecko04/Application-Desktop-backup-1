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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Org.BouncyCastle.Utilities.IO;
using QRCoder;
using System.Management;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Application_Desktop.Admin_Views
{
    public partial class handleAppointment : Form
    {
        private handleAppointmentController _handleAppointmentController;
        private sendEmailReminder _sendEmailReminder;
        public PatientData PatientData { get; set; }

        public handleAppointment()
        {
            InitializeComponent();
            PatientData = new PatientData();
            _handleAppointmentController = new handleAppointmentController();
            _sendEmailReminder = new sendEmailReminder();

            viewApprovedAppointment.CellFormatting += viewApprovedAppointment_CellFormatting;
            viewPendingAppointment.CellFormatting += viewPendingAppointment_CellFormatting;
            viewReschedule.CellFormatting += viewReschedule_CellFormatting;
            viewMissedAppointment.CellFormatting += viewMissedAppointment_CellFormatting;
            viewCancelledAppointment.CellFormatting += viewCancelledAppointment_CellFormatting;
            viewCompletedAppointment.CellFormatting += viewCompletedAppointment_CellFormatting;



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
            SetupDataGridView();
            //timer1.Tick += timer1_Tick;

            await LoadInqueue();
            await LoadApproved();
            await LoadCancelled();
            await LoadReschedule();
            await LoadMissed();
            await LoadCompleted();

            //

            viewPendingAppointment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewPendingAppointment.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            viewPendingAppointment.DefaultCellStyle.SelectionForeColor = Color.Black;
            viewPendingAppointment.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;
            viewPendingAppointment.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            viewPendingAppointment.ClearSelection();

            //

            viewReschedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewReschedule.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            viewReschedule.DefaultCellStyle.SelectionForeColor = Color.Black;
            viewReschedule.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;
            viewReschedule.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            viewReschedule.ClearSelection();

            //

            viewApprovedAppointment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewApprovedAppointment.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            viewApprovedAppointment.DefaultCellStyle.SelectionForeColor = Color.Black;
            viewApprovedAppointment.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;
            viewApprovedAppointment.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            viewApprovedAppointment.ClearSelection();

            //

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

                if (inqueue != null)
                {
                    viewPendingAppointment.DataSource = null;
                    viewPendingAppointment.Rows.Clear();

                    if (viewPendingAppointment.Columns["QrCodeImage"] == null)
                    {
                        AddColumnInqueue(viewPendingAppointment);
                    }

                    foreach (DataRow row in inqueue.Rows)
                    {
                        string qrData = row["qr_code"].ToString();
                        Bitmap qrCodeImage = GenerateQrCode(qrData);

                        viewPendingAppointment.Rows.Add(
                            qrCodeImage,
                            row["id"],
                            row["user_id"],
                            row["UserName"],
                            row["BranchName"],
                            row["ServiceTitle"],
                            row["appointment_date"],
                            row["appointment_time"],
                            row["reschedule_date"],
                            row["reschedule_time"],
                            row["status"],
                            row["check_in"]
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No appointments found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load approved appointments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadReschedule()
        {
            try
            {
                DataTable reschedule = await _handleAppointmentController.RescheduleAppointment();

                viewReschedule.DataSource = null;
                viewReschedule.Rows.Clear();

                if (viewReschedule.Columns["QrCodeImage"] == null)
                {
                    AddColumnReschedule(viewReschedule);
                }

                foreach (DataRow row in reschedule.Rows)
                {
                    string qrData = row["qr_code"].ToString();
                    Bitmap qrCodeImage = GenerateQrCode(qrData);

                    viewReschedule.Rows.Add(
                        qrCodeImage,
                        row["id"],
                        row["user_id"],
                        row["UserName"],
                        row["BranchName"],
                        row["ServiceTitle"],
                        row["appointment_date"],
                        row["appointment_time"],
                        row["reschedule_date"],
                        row["reschedule_time"],
                        row["status"],
                        row["check_in"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load rescheduled appointments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task LoadApproved()
        {
            try
            {
                DataTable approved = await _handleAppointmentController.ApprovedAppointment();

                viewApprovedAppointment.DataSource = null;
                viewApprovedAppointment.Rows.Clear();

                if (viewApprovedAppointment.Columns["QrCodeImage"] == null)
                {
                    AddColumnApproved(viewApprovedAppointment);
                }

                foreach (DataRow row in approved.Rows)
                {
                    string qrData = row["qr_code"].ToString(); 
                    Bitmap qrCodeImage = GenerateQrCode(qrData);

                    viewApprovedAppointment.Rows.Add(
                        qrCodeImage,
                        row["id"],
                        row["user_id"],
                        row["UserName"],
                        row["BranchName"],
                        row["ServiceTitle"],
                        row["appointment_date"],
                        row["appointment_time"],
                        row["reschedule_date"],
                        row["reschedule_time"],
                        row["status"],
                        row["check_in"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load approved appointments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async Task LoadMissed()
        {
            try
            {
                getBranchIdByUserId branchId = new getBranchIdByUserId();
                BranchID adminId = await branchId.GetUserBranchId();
                DataTable missed = await _handleAppointmentController.MissedAppointment();
                viewMissedAppointment.DataSource = null;
                viewMissedAppointment.Rows.Clear();
                viewMissedAppointment.Columns.Clear();

                viewMissedAppointment.AutoGenerateColumns = false;
                AddColumnMissed(viewMissedAppointment);

                viewMissedAppointment.DataSource = missed;

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
                DataTable completed = await _handleAppointmentController.CompletedAppointment();

                viewCompletedAppointment.DataSource = null;
                viewCompletedAppointment.Rows.Clear();

                if (viewCompletedAppointment.Columns["QrCodeImage"] == null)
                {
                    AddColumnCompleted(viewCompletedAppointment);
                }

                foreach (DataRow row in completed.Rows)
                {
                    string qrData = row["qr_code"].ToString(); 
                    Bitmap qrCodeImage = GenerateQrCode(qrData);

                    viewCompletedAppointment.Rows.Add(
                        qrCodeImage,
                        row["id"],
                        row["user_id"],
                        row["selectedBranch"],
                        row["selectServices"],
                        row["UserName"],
                        row["BranchName"],
                        row["ServiceTitle"],
                        row["appointment_date"],
                        row["appointment_time"],
                        row["reschedule_date"],
                        row["reschedule_time"],
                        row["status"],
                        row["check_in"]
                    );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load patient records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Bitmap GenerateQrCode(string qrData)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    return qrCode.GetGraphic(20); // 20 = pixels per module
                }
            }
        }

        private void AddColumnInqueue(DataGridView Inqueue)
        {
            Inqueue.RowHeadersVisible = false;
            Inqueue.ColumnHeadersHeight = 40;
            //Inqueue.RowTemplate.Height = 150;

            // Adding QR Code column
            if (!Inqueue.Columns.Contains("qrCode"))
            {
                DataGridViewImageColumn qrCodeColumn = new DataGridViewImageColumn
                {
                    HeaderText = "QR Code",
                    Name = "qrCode",
                    Width = 150,
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                Inqueue.Columns.Add(qrCodeColumn);
            }

            // Adding ID column
            if (!Inqueue.Columns.Contains("id"))
            {
                DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn
                {
                    HeaderText = "ID",
                    Name = "id",
                    DataPropertyName = "id",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                Inqueue.Columns.Add(id);
            }

            // Adding User ID column
            if (!Inqueue.Columns.Contains("user_id"))
            {
                DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "User ID",
                    Name = "user_id",
                    DataPropertyName = "user_id",
                    Visible = false
                };
                Inqueue.Columns.Add(userIdColumn);
            }

            // Adding Fullname column
            if (!Inqueue.Columns.Contains("fullname"))
            {
                DataGridViewTextBoxColumn fullname = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Fullname",
                    Name = "fullname",
                    DataPropertyName = "UserName",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                Inqueue.Columns.Add(fullname);
            }

            // Adding Branch column
            if (!Inqueue.Columns.Contains("branches"))
            {
                DataGridViewTextBoxColumn branches = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Branch",
                    Name = "branches",
                    DataPropertyName = "BranchName",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                Inqueue.Columns.Add(branches);
            }

            // Adding Services column
            if (!Inqueue.Columns.Contains("services"))
            {
                DataGridViewTextBoxColumn services = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Services",
                    Name = "services",
                    DataPropertyName = "ServiceTitle",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                Inqueue.Columns.Add(services);
            }

            // Adding Appointment Date column
            if (!Inqueue.Columns.Contains("appointmentDate"))
            {
                DataGridViewTextBoxColumn appointment_date = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Appointment Date",
                    Name = "appointmentDate",
                    DataPropertyName = "appointment_date",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "MM/dd/yyyy"
                    }
                };
                Inqueue.Columns.Add(appointment_date);
            }

            // Adding Appointment Time column
            if (!Inqueue.Columns.Contains("appointmentTime"))
            {
                DataGridViewTextBoxColumn appointment_time = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Appointment Time",
                    Name = "appointmentTime",
                    DataPropertyName = "appointment_time",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                Inqueue.Columns.Add(appointment_time);
            }

            // Adding Reschedule Date column
            if (!Inqueue.Columns.Contains("rescheduleDate"))
            {
                DataGridViewTextBoxColumn reschedule_date = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Reschedule Date",
                    Name = "rescheduleDate",
                    DataPropertyName = "reschedule_date",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "MM/dd/yyyy"
                    }
                };
                Inqueue.Columns.Add(reschedule_date);
            }

            // Adding Reschedule Time column
            if (!Inqueue.Columns.Contains("rescheduleTime"))
            {
                DataGridViewTextBoxColumn reschedule_time = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Reschedule Time",
                    Name = "rescheduleTime",
                    DataPropertyName = "reschedule_time",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                Inqueue.Columns.Add(reschedule_time);
            }

            // Adding Status column
            if (!Inqueue.Columns.Contains("status"))
            {
                DataGridViewTextBoxColumn status = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Status",
                    Name = "status",
                    DataPropertyName = "status",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                Inqueue.Columns.Add(status);
            }
        }
        private void AddColumnReschedule(DataGridView Reschedule)
        {
            Reschedule.RowHeadersVisible = false;
            Reschedule.ColumnHeadersHeight = 40;
            //Reschedule.RowTemplate.Height = 150;

            if (!Reschedule.Columns.Contains("qrCode"))
            {
                DataGridViewImageColumn qrCodeColumn = new DataGridViewImageColumn
                {
                    HeaderText = "QR Code",
                    Name = "qrCode",
                    Width = 150,
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                Reschedule.Columns.Add(qrCodeColumn);
            }

            if (!Reschedule.Columns.Contains("id"))
            {
                DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn
                {
                    HeaderText = "ID",
                    Name = "id",
                    DataPropertyName = "id",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                Reschedule.Columns.Add(id);
            }

            if (!Reschedule.Columns.Contains("user_id"))
            {
                DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "User ID",
                    Name = "user_id",
                    DataPropertyName = "user_id",
                    Visible = false
                };
                Reschedule.Columns.Add(userIdColumn);
            }

            if (!Reschedule.Columns.Contains("fullname"))
            {
                DataGridViewTextBoxColumn fullname = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Fullname",
                    Name = "fullname",
                    DataPropertyName = "UserName",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                Reschedule.Columns.Add(fullname);
            }

            if (!Reschedule.Columns.Contains("branches"))
            {
                DataGridViewTextBoxColumn branches = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Branch",
                    Name = "branches",
                    DataPropertyName = "BranchName",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                Reschedule.Columns.Add(branches);
            }

            if (!Reschedule.Columns.Contains("services"))
            {
                DataGridViewTextBoxColumn services = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Services",
                    Name = "services",
                    DataPropertyName = "ServiceTitle",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                Reschedule.Columns.Add(services);
            }

            if (!Reschedule.Columns.Contains("appointmentDate"))
            {
                DataGridViewTextBoxColumn appointment_date = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Appointment Date",
                    Name = "appointmentDate",
                    DataPropertyName = "appointment_date",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "MM/dd/yyyy"
                    }
                };
                Reschedule.Columns.Add(appointment_date);
            }

            if (!Reschedule.Columns.Contains("appointmentTime"))
            {
                DataGridViewTextBoxColumn appointment_time = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Appointment Time",
                    Name = "appointmentTime",
                    DataPropertyName = "appointment_time",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                Reschedule.Columns.Add(appointment_time);
            }

            if (!Reschedule.Columns.Contains("rescheduleDate"))
            {
                DataGridViewTextBoxColumn reschedule_date = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Reschedule Date",
                    Name = "rescheduleDate",
                    DataPropertyName = "reschedule_date",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "MM/dd/yyyy"
                    }
                };
                Reschedule.Columns.Add(reschedule_date);
            }

            if (!Reschedule.Columns.Contains("rescheduleTime"))
            {
                DataGridViewTextBoxColumn reschedule_time = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Reschedule Time",
                    Name = "rescheduleTime",
                    DataPropertyName = "reschedule_time",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                Reschedule.Columns.Add(reschedule_time);
            }

            if (!Reschedule.Columns.Contains("status"))
            {
                DataGridViewTextBoxColumn status = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Status",
                    Name = "status",
                    DataPropertyName = "status",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                Reschedule.Columns.Add(status);
            }
        }
        private void AddColumnApproved(DataGridView approved)
        {
            approved.RowHeadersVisible = false;
            approved.ColumnHeadersHeight = 40;
            //approved.RowTemplate.Height = 150;

            if (!approved.Columns.Contains("qrCode"))
            {
                DataGridViewImageColumn qrCodeColumn = new DataGridViewImageColumn
                {
                    HeaderText = "QR Code",
                    Name = "qrCode",
                    Width = 150,
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                approved.Columns.Add(qrCodeColumn);
            }

            if (!approved.Columns.Contains("id"))
            {
                DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn
                {
                    HeaderText = "ID",
                    Name = "id",
                    DataPropertyName = "id",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                approved.Columns.Add(id);
            }

            if (!approved.Columns.Contains("user_id"))
            {
                DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "User ID",
                    Name = "user_id",
                    DataPropertyName = "user_id",
                    Visible = false
                };
                approved.Columns.Add(userIdColumn);
            }

            if (!approved.Columns.Contains("fullname"))
            {
                DataGridViewTextBoxColumn fullname = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Fullname",
                    Name = "fullname",
                    DataPropertyName = "UserName",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                approved.Columns.Add(fullname);
            }

            if (!approved.Columns.Contains("branches"))
            {
                DataGridViewTextBoxColumn branches = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Branch",
                    Name = "branches",
                    DataPropertyName = "BranchName",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                approved.Columns.Add(branches);
            }

            if (!approved.Columns.Contains("services"))
            {
                DataGridViewTextBoxColumn services = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Services",
                    Name = "services",
                    DataPropertyName = "ServiceTitle",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                approved.Columns.Add(services);
            }

            if (!approved.Columns.Contains("appointmentDate"))
            {
                DataGridViewTextBoxColumn appointment_date = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Appointment Date",
                    Name = "appointmentDate",
                    DataPropertyName = "appointment_date",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "MM/dd/yyyy"
                    }
                };
                approved.Columns.Add(appointment_date);
            }

            if (!approved.Columns.Contains("appointmentTime"))
            {
                DataGridViewTextBoxColumn appointment_time = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Appointment Time",
                    Name = "appointmentTime",
                    DataPropertyName = "appointment_time",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                approved.Columns.Add(appointment_time);
            }

            if (!approved.Columns.Contains("rescheduleDate"))
            {
                DataGridViewTextBoxColumn reschedule_date = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Reschedule Date",
                    Name = "rescheduleDate",
                    DataPropertyName = "reschedule_date",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "MM/dd/yyyy"
                    }
                };
                approved.Columns.Add(reschedule_date);
            }

            if (!approved.Columns.Contains("rescheduleTime"))
            {
                DataGridViewTextBoxColumn reschedule_time = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Reschedule Time",
                    Name = "rescheduleTime",
                    DataPropertyName = "reschedule_time",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                approved.Columns.Add(reschedule_time);
            }

            if (!approved.Columns.Contains("status"))
            {
                DataGridViewTextBoxColumn status = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Status",
                    Name = "status",
                    DataPropertyName = "status",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                approved.Columns.Add(status);
            }

            if (!approved.Columns.Contains("check_in"))
            {
                DataGridViewTextBoxColumn check_in = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Check In",
                    Name = "check_in",
                    DataPropertyName = "check_in",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                approved.Columns.Add(check_in);
            }
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

        private void AddColumnMissed(DataGridView missed)
        {
            missed.RowHeadersVisible = false;
            missed.ColumnHeadersHeight = 40;

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                Name = "id",
                DataPropertyName = "id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            missed.Columns.Add(id);

            DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "User ID",
                Name = "user_id",
                DataPropertyName = "user_id",
                Visible = false
            };
            missed.Columns.Add(userIdColumn);

            DataGridViewTextBoxColumn fullname = new DataGridViewTextBoxColumn
            {
                HeaderText = "Fullname",
                Name = "fullname",
                DataPropertyName = "UserName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            missed.Columns.Add(fullname);

            DataGridViewTextBoxColumn branches = new DataGridViewTextBoxColumn
            {
                HeaderText = "Branch",
                Name = "branches",
                DataPropertyName = "BranchName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            missed.Columns.Add(branches);

            DataGridViewTextBoxColumn services = new DataGridViewTextBoxColumn
            {
                HeaderText = "Services",
                Name = "services",
                DataPropertyName = "ServiceTitle",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            missed.Columns.Add(services);

            DataGridViewTextBoxColumn appointment_date = new DataGridViewTextBoxColumn
            {
                HeaderText = "Appointment Date",
                Name = "appointmentDate",
                DataPropertyName = "appointment_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            missed.Columns.Add(appointment_date);

            DataGridViewTextBoxColumn appointment_time = new DataGridViewTextBoxColumn
            {
                HeaderText = "Appointment Time",
                Name = "appointmentTime",
                DataPropertyName = "appointment_time",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            missed.Columns.Add(appointment_time);

            DataGridViewTextBoxColumn reschedule_date = new DataGridViewTextBoxColumn
            {
                HeaderText = "Reschedule Date",
                Name = "rescheduleDate",
                DataPropertyName = "reschedule_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            missed.Columns.Add(reschedule_date);

            DataGridViewTextBoxColumn reschedule_time = new DataGridViewTextBoxColumn
            {
                HeaderText = "Reschedule Time",
                Name = "rescheduleTime",
                DataPropertyName = "reschedule_time",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            missed.Columns.Add(reschedule_time);

            DataGridViewTextBoxColumn status = new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                Name = "status",
                DataPropertyName = "status",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            missed.Columns.Add(status);

            DataGridViewTextBoxColumn check_in = new DataGridViewTextBoxColumn
            {
                HeaderText = "Check In",
                Name = "check_in",
                DataPropertyName = "check_in",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            missed.Columns.Add(check_in);

        }
        private void AddColumnCompleted(DataGridView completed)
        {
            completed.RowHeadersVisible = false;
            completed.ColumnHeadersHeight = 40;
            //completed.RowTemplate.Height = 150;

            if (!completed.Columns.Contains("qrCode"))
            {
                DataGridViewImageColumn qrCodeColumn = new DataGridViewImageColumn
                {
                    HeaderText = "QR Code",
                    Name = "qrCode",
                    Width = 150,
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                completed.Columns.Add(qrCodeColumn);
            }

            if (!completed.Columns.Contains("id"))
            {
                DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn
                {
                    HeaderText = "ID",
                    Name = "id",
                    DataPropertyName = "id",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                completed.Columns.Add(id);
            }

            if (!completed.Columns.Contains("user_id"))
            {
                DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "User ID",
                    Name = "user_id",
                    DataPropertyName = "user_id",
                    Visible = false
                };
                completed.Columns.Add(userIdColumn);
            }

            if (!completed.Columns.Contains("branch_id"))
            {
                DataGridViewTextBoxColumn branchId = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Branch ID",
                    Name = "branch_id",
                    DataPropertyName = "selectedBranch",
                    Visible = false
                };
                completed.Columns.Add(branchId);
            }

            if (!completed.Columns.Contains("categories_id"))
            {
                DataGridViewTextBoxColumn categoryId = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Categories ID",
                    Name = "categories_id",
                    DataPropertyName = "selectServices",
                    Visible = false
                };
                completed.Columns.Add(categoryId);
            }

            if (!completed.Columns.Contains("fullname"))
            {
                DataGridViewTextBoxColumn fullname = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Fullname",
                    Name = "fullname",
                    DataPropertyName = "UserName",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                completed.Columns.Add(fullname);
            }

            if (!completed.Columns.Contains("branches"))
            {
                DataGridViewTextBoxColumn branches = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Branch",
                    Name = "branches",
                    DataPropertyName = "BranchName",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                completed.Columns.Add(branches);
            }

            if (!completed.Columns.Contains("services"))
            {
                DataGridViewTextBoxColumn services = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Services",
                    Name = "services",
                    DataPropertyName = "ServiceTitle",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                completed.Columns.Add(services);
            }

            if (!completed.Columns.Contains("appointmentDate"))
            {
                DataGridViewTextBoxColumn appointment_date = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Appointment Date",
                    Name = "appointmentDate",
                    DataPropertyName = "appointment_date",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "MM/dd/yyyy"
                    }
                };
                completed.Columns.Add(appointment_date);
            }

            if (!completed.Columns.Contains("appointmentTime"))
            {
                DataGridViewTextBoxColumn appointment_time = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Appointment Time",
                    Name = "appointmentTime",
                    DataPropertyName = "appointment_time",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                completed.Columns.Add(appointment_time);
            }

            if (!completed.Columns.Contains("rescheduleDate"))
            {
                DataGridViewTextBoxColumn reschedule_date = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Reschedule Date",
                    Name = "rescheduleDate",
                    DataPropertyName = "reschedule_date",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "MM/dd/yyyy"
                    }
                };
                completed.Columns.Add(reschedule_date);
            }

            if (!completed.Columns.Contains("rescheduleTime"))
            {
                DataGridViewTextBoxColumn reschedule_time = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Reschedule Time",
                    Name = "rescheduleTime",
                    DataPropertyName = "reschedule_time",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                completed.Columns.Add(reschedule_time);
            }

            if (!completed.Columns.Contains("status"))
            {
                DataGridViewTextBoxColumn status = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Status",
                    Name = "status",
                    DataPropertyName = "status",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                completed.Columns.Add(status);
            }

            if (!completed.Columns.Contains("check_in"))
            {
                DataGridViewTextBoxColumn check_in = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Check In",
                    Name = "check_in",
                    DataPropertyName = "check_in",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };
                completed.Columns.Add(check_in);
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
                /*this.BeginInvoke((MethodInvoker)delegate
                {
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Email Sent!", "Notification sent successfully!", Properties.Resources.success);

                });*/
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


        public async Task approved()
        {
            string value = "approved";
            LoadingState.Visible = true;

            try
            {
                if (selectedAppointmentId > 0)
                {
                    await _handleAppointmentController.Approved(value, selectedAppointmentId);
                    viewPendingAppointment.ClearSelection();
                    selectedAppointmentId = 0;
                }
                else if (rescheduleAppointmentId > 0)
                {
                    await _handleAppointmentController.Approved(value, rescheduleAppointmentId);
                    viewReschedule.ClearSelection();
                    rescheduleAppointmentId = 0;
                }

                AlertBox(Color.LightGreen, Color.SeaGreen, "Appointment Approved", "Appointment Change Status Successfully!", Properties.Resources.success);
            }
            catch (Exception ex)
            {
                AlertBox(Color.LightCoral, Color.Red, "Error", $"An error occurred: {ex.Message}", Properties.Resources.error);
            }
            finally
            {
                LoadingState.Visible = false;
            }
        }

        //na edit
        private async void btnApprove_Click(object sender, EventArgs e)
        {
            LoadingState.Visible = true;

            try
            {
                if (selectedAppointmentId > 0 || rescheduleAppointmentId > 0)
                {
                    DialogResult dialogResult = MessageBox.Show(
                        "Do you want to approve this dental appointment?",
                        "Confirm Approval",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        int userIdToApprove = selectedAppointmentId > 0 ? selectedUserId : rescheduleUserId;
                        string email = await _handleAppointmentController.SelectEmail(userIdToApprove);
                        string phone = await _handleAppointmentController.SelectPhone(userIdToApprove);

                        if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(phone))
                        {
                            bool emailSent = selectedAppointmentId > 0
                                ? await SendEmailNotification(email, selectedAppointmentId.ToString(), "approved")
                                : await SendRescheduleApproved(email, rescheduleUserId.ToString(), "approved");

                            bool smsSent = selectedAppointmentId > 0
                                ? await SendSMSApproved(phone, selectedAppointmentId.ToString(), "approved")
                                : await SendSMSApproved(phone, rescheduleUserId.ToString(), "approved");
                            MessageBox.Show(phone);
                            MessageBox.Show(email);

                            if (emailSent && smsSent)
                            {
                                await approved();
                            }
                            else
                            {
                                AlertBox(Color.LightCoral, Color.Red, "Email/SMS Notification Failed", "Email/SMS notification failed.", Properties.Resources.error);
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
            catch (Exception ex)
            {
                AlertBox(Color.LightCoral, Color.Red, "Error", $"An error occurred: {ex.Message}", Properties.Resources.error);
            }
            finally
            {
                // Hide loading state after all operations are complete
                LoadingState.Visible = false;
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

        private async Task<bool> SendMissedNotification(string userEmail, string appointmentId, string status)
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
                                <strong>{appointmentId}</strong> has been changed to <strong style=""color: #e74c3c;"">{status}</strong> due to missed appointment.
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

                /* this.BeginInvoke((MethodInvoker)delegate
                 {
                     AlertBox(Color.LightGreen, Color.SeaGreen, "Email Sent!", "Cancellation notification sent successfully!", Properties.Resources.success);

                 });*/
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

        private async Task<bool> SendRejectedNotification(string userEmail, string appointmentId, string status)
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
                                We regret to inform you that your reschedule appointment request with Appointment ID 
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


        public async Task cancelled()
        {

            string emailPending = await _handleAppointmentController.SelectEmail(selectedUserId);
            string emailApproved = await _handleAppointmentController.SelectEmail(selectedApprovedUserId);
            string emailReschedule = await _handleAppointmentController.SelectEmail(rescheduleUserId);

            string phonePending = await _handleAppointmentController.SelectPhone(selectedUserId);
            string phoneApproved = await _handleAppointmentController.SelectPhone(selectedApprovedUserId);
            string phoneReschedule = await _handleAppointmentController.SelectPhone(rescheduleUserId);

            if (string.IsNullOrEmpty(emailPending) && string.IsNullOrEmpty(emailApproved) && string.IsNullOrEmpty(emailReschedule))
            {
                AlertBox(Color.LightCoral, Color.Red, "Email Not Found", "User email not found.", Properties.Resources.error);
                return;
            }

            // Handle cancellations
            if (selectedAppointmentId > 0)
            {
                await ProcessCancellation(emailPending, phonePending, selectedAppointmentId, viewPendingAppointment, "cancelled");
            }

            if (ApprovedAppointmentId > 0)
            {
                await ProcessCancellation(emailApproved, phoneApproved, ApprovedAppointmentId, viewApprovedAppointment, "missed");
            }

            if (rescheduleAppointmentId > 0)
            {
                await ProcessCancellation(emailReschedule, phoneReschedule, rescheduleAppointmentId, viewReschedule, "rejected");
            }
        }

        private async Task ProcessCancellation(string email, string phone, int appointmentId, DataGridView view, string cancellationType)
        {
            LoadingState.Visible = true;

            try
            {
                bool emailSent = false;
                bool phoneSent = false;

                switch (cancellationType)
                {
                    case "cancelled":
                        emailSent = await SendCancelledNotification(email, appointmentId.ToString(), cancellationType);
                        phoneSent = await SendSMSRejected(phone, appointmentId.ToString());
                        break;

                    case "missed":
                        emailSent = await SendMissedNotification(email, appointmentId.ToString(), cancellationType);
                        phoneSent = await SendSMSRejected(phone, appointmentId.ToString());
                        break;

                    case "rejected":
                        emailSent = await SendRejectedNotification(email, appointmentId.ToString(), cancellationType);
                        phoneSent = await SendSMSRejected(phone, appointmentId.ToString());
                        break;
                }

                if (emailSent && phoneSent)
                {
                    await _handleAppointmentController.Cancel(cancellationType, appointmentId);
                    view.ClearSelection();

                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        AlertBox(Color.LightGreen, Color.SeaGreen, "Appointment Cancelled", "Appointment status changed successfully!", Properties.Resources.success);
                    });
                }
                else
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        AlertBox(Color.LightCoral, Color.Red, "Cancel Failed", "Notification failed.", Properties.Resources.error);
                    });
                }
            }
            catch (Exception ex)
            {
                // Add context only if necessary
                throw new Exception($"Error occurred: {ex.Message}", ex);
            }
            finally
            {
                LoadingState.Visible = false;
            }
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {

            if (selectedAppointmentId > 0 || ApprovedAppointmentId > 0 || rescheduleAppointmentId > 0)
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
                    if (selectedAppointmentId > 0)
                        await LoadInqueue();

                    if (ApprovedAppointmentId > 0)
                        await LoadApproved();

                    if (rescheduleAppointmentId > 0)
                        await LoadReschedule();

                }
            }
            else
            {
                AlertBox(Color.LightSteelBlue, Color.DodgerBlue, "No Selected Appointment", "Select an appointment first to cancel.", Properties.Resources.information);
            }

        }




        private async Task completed()
        {
            string value = "completed";

            if (ApprovedAppointmentId > 0)
            {
                LoadingState.Visible = true;

                try
                {
                    await Task.Delay(3000);

                    bool checkedIn = await _handleAppointmentController.IsCheckedIn(ApprovedAppointmentId);

                    if (!checkedIn)
                    {
                        LoadingState.Visible = false;
                        AlertBox(Color.LightCoral, Color.Red, "Check-In Required", "This appointment is not checked in.", Properties.Resources.error);
                        return;
                    }

                    await _handleAppointmentController.Complete(value, ApprovedAppointmentId);

                    LoadingState.Visible = false;
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Appointment Completed", "Appointment Change Status Successfully!", Properties.Resources.success);

                    // Clear the selection and reset the selectedAppointmentId
                    viewApprovedAppointment.ClearSelection();
                    ApprovedAppointmentId = 0;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error {ex.Message}");
                }
                finally
                {
                    LoadingState.Visible = false;

                }

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
        private async Task<bool> SendRescheduleApproved(string userEmail, string appointmentId, string status)
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
                            This is to notify you that your rescheduled appointment with Appointment ID 
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
                /*this.BeginInvoke((MethodInvoker)delegate
                {
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Email Sent!", "Notification sent successfully!", Properties.Resources.success);

                });*/
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



        private async void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
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

            await _handleAppointmentController.InqueuNotif(InqueueNotif);

            /*if (tabControl1.SelectedTab == tabPage2)
            {
                InqueueNotif.Visible = false;
            }*/

            await _handleAppointmentController.RescheduleNotif(reschedNotif);

            /*if (tabControl1.SelectedTab == tabPage6)
            {
                reschedNotif.Visible = false;
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

        private async void btnRefresher_Click(object sender, EventArgs e)
        {
            try
            {
                await LoadInqueue();
                viewPendingAppointment.ClearSelection();
                selectedAppointmentId = 0;
                selectedUserId = 0;

                await LoadReschedule();
                viewReschedule.ClearSelection();
                rescheduleAppointmentId = 0;
                rescheduleUserId = 0;

                await LoadApproved();
                viewApprovedAppointment.ClearSelection();

                await LoadCancelled();
                viewCancelledAppointment.ClearSelection();
                ApprovedAppointmentId = 0;
                selectedApprovedUserId = 0;

                await LoadMissed();
                viewMissedAppointment.ClearSelection();

                await LoadCompleted();
                viewCompletedAppointment.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during refresh: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool isCollapsed = true;

        public async Task<PatientData> GetPatientDataWithHistories(int userId)
        {
            var patientData = new PatientData();

            // Step 1: Fetch patient record using user_id
            var patientRecord = await _handleAppointmentController.SelectPatientRecord(userId);
            if (patientRecord != null)
            {
                patientData.FullName = patientRecord["fullname"].ToString();
                patientData.DateOfBirth = patientRecord["date_of_birth"].ToString();
                patientData.Age = patientRecord["age"].ToString();
                patientData.Gender = patientRecord["gender"].ToString();
                patientData.Phone = patientRecord["phone"].ToString();
                patientData.Email = patientRecord["email"].ToString();
                patientData.Address = patientRecord["address"].ToString();
                patientData.EmergencyContact = patientRecord["emergency_contact"].ToString();

                // Retrieve patient_id from the fetched patient record
                patientData.PatientId = int.Parse(patientRecord["id"].ToString());
            }

            // Step 2: Fetch medical history using patient_id
            if (patientData.PatientId > 0)
            {
                var medicalHistory = await _handleAppointmentController.SelectPatientMedicalRecord(patientData.PatientId);
                if (medicalHistory != null)
                {
                    patientData.MedicalConditions = medicalHistory["medical_conditions"].ToString();
                    patientData.CurrentMedications = medicalHistory["current_medications"].ToString();
                    patientData.Allergies = medicalHistory["allergies"].ToString();
                    patientData.PastSurgeries = medicalHistory["past_surgeries"].ToString();
                    patientData.FamilyMedicalHistory = medicalHistory["family_medical_history"].ToString();
                    patientData.BloodPressure = medicalHistory["blood_pressure"].ToString();
                    patientData.HeartDisease = bool.TryParse(medicalHistory["heart_disease"].ToString(), out bool heartDisease) ? heartDisease : false;
                    patientData.Diabetes = bool.TryParse(medicalHistory["diabetes"].ToString(), out bool diabetes) ? diabetes : false;
                    patientData.Smoker = bool.TryParse(medicalHistory["smoker"].ToString(), out bool smoker) ? smoker : false;
                }
            }

            // Step 3: Fetch dental history using patient_id
            if (patientData.PatientId > 0)
            {
                var dentalHistory = await _handleAppointmentController.SelectPatientDentalRecord(patientData.PatientId);
                if (dentalHistory != null)
                {
                    patientData.PastDentalTreatments = dentalHistory["past_dental_treatments"].ToString();
                    patientData.FrequentToothPain = bool.TryParse(dentalHistory["frequent_tooth_pain"].ToString(), out bool frequentToothPain) ? frequentToothPain : false;
                    patientData.GumDiseaseHistory = bool.TryParse(dentalHistory["gum_disease_history"].ToString(), out bool gumDiseaseHistory) ? gumDiseaseHistory : false;
                    patientData.TeethGrinding = bool.TryParse(dentalHistory["teeth_grinding"].ToString(), out bool teethGrinding) ? teethGrinding : false;
                    patientData.OrthodonticTreatment = bool.TryParse(dentalHistory["orthodontic_treatment"].ToString(), out bool orthodonticTreatment) ? orthodonticTreatment : false;
                    patientData.DentalImplants = bool.TryParse(dentalHistory["dental_implants"].ToString(), out bool dentalImplants) ? dentalImplants : false;
                    patientData.BleedingGums = bool.TryParse(dentalHistory["bleeding_gums"].ToString(), out bool bleedingGums) ? bleedingGums : false;
                    patientData.ToothSensitivity = dentalHistory["tooth_sensitivity"].ToString();
                }
            }

            // Step 4: Fetch the latest approved appointment data with Branch and Services
            var appointmentData = await _handleAppointmentController.GetDentalPatientAppointment(userId);
            if (appointmentData != null)
            {
                patientData.AppointmentId = int.Parse(appointmentData["id"].ToString());
                patientData.UserId = int.Parse(appointmentData["user_id"].ToString());
                patientData.Qrcode = appointmentData["qr_code"].ToString();
                patientData.SelectedBranch = int.Parse(appointmentData["selectedBranch"].ToString());
                patientData.SelectServices = int.Parse(appointmentData["selectServices"].ToString());
                patientData.Branch = appointmentData["BranchName"].ToString();
                patientData.Services = appointmentData["Services"].ToString();
                patientData.AppointmentDate = Convert.ToDateTime(appointmentData["appointment_date"]);
                patientData.AppointmentTime = appointmentData["appointment_time"].ToString();
                patientData.RescheduleDate = appointmentData["reschedule_date"]?.ToString();
                patientData.RescheduleTime = appointmentData["reschedule_time"]?.ToString();
                patientData.Status = appointmentData["status"].ToString();
                patientData.Check_In = bool.TryParse(appointmentData["check_in"].ToString(), out bool check_in) ? check_in : false;
            }

            //MessageBox.Show(patientData.Qrcode);
            return patientData;
        }

        private async Task ConfirmCheckIn(string scannedValue)
        {
            LoadingState.Visible = true;
            lblScanning.Visible = true;
            lvlScanQRC.Visible = false;

            try
            {
                await Task.Delay(3000);

                var AppointmentData = JsonConvert.DeserializeObject<AppointmentData>(scannedValue);

                if (AppointmentData == null)
                {
                    MessageBox.Show("Invalid appointment data.");
                    return;
                }

                var branchName = AppointmentData.branch_name;
                var services = AppointmentData.services;

                var status = await _handleAppointmentController.GetAppointmentStatus(AppointmentData.userId, branchName, services);

                MessageBox.Show(status);
                if (string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("Appointment status not found.");
                    return;
                }

                if (status == "approved" || status == "completed")
                {
                    await HandleCheckedIn(AppointmentData.userId);
                }
                else if (status == "pending")
                {
                    await HandlePending(AppointmentData.userId);
                }
                else
                {
                    MessageBox.Show($"Unexpected appointment status: {status}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during check-in: {ex.Message}");
            }
            finally
            {
                // Reset UI elements
                LoadingState.Visible = false;
                lblScanning.Visible = false;
                lvlScanQRC.Visible = false;
                btnQRCode.Text = "Start Scanning";

                textBox1.Focus();
            }
        }



        private async Task HandleCheckedIn(int userId)
        {
            try
            {
                var patientData = await GetPatientDataWithHistories(userId);

                this.BeginInvoke((MethodInvoker)delegate
                {
                    try
                    {
                        LoadingState.Visible = false;
                        lvlScanQRC.Visible = false;
                        lblScanning.Visible = false;
                        btnQRCode.Text = "Start Scanning";

                        quickRetrievalData newForm = new quickRetrievalData();
                        newForm.LoadPatientData(patientData);
                        newForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating UI: {ex.Message}");
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving patient data: {ex.Message}");
            }
        }

        private async Task HandlePending(int userId)
        {
            try
            {
                var patientData = await GetPatientDataWithHistories(userId);

                this.BeginInvoke((MethodInvoker)delegate
                {
                    try
                    {
                        LoadingState.Visible = false;
                        lvlScanQRC.Visible = false;
                        lblScanning.Visible = false;
                        btnQRCode.Text = "Start Scanning";

                        quickRetrievalDataPending form2 = new quickRetrievalDataPending();
                        form2.LoadPatientData(patientData);
                        form2.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating UI: {ex.Message}");
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving patient data: {ex.Message}");
            }
        }


        private scanQRCode ScanQRCodeInstance;

        private bool IsScanning = false;

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            //timer1.Start();

            if (!IsScanning)
            {
                IsScanning = true;
                btnQRCode.Text = "Stop Scanning";
                lvlScanQRC.Visible = true;

                StartScanning();
            }
            else
            {
                IsScanning = false;
                btnQRCode.Text = "Start Scanning";
                lvlScanQRC.Visible = false;

                StopScanning();
            }
        }

        private void StartScanning()
        {
            textBox1.Focus();
        }

        private void StopScanning()
        {
            textBox1.Focus();
            textBox1.Clear();
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && IsScanning)
            {
                e.SuppressKeyPress = true;

                string scannedValue = textBox1.Text.Trim();

                _ = ConfirmCheckIn(scannedValue);

                textBox1.Clear();
            }
        }




        private receiptForm ReceiptFormInstance;
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

        private async void btnSearcher_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable appointment = await _handleAppointmentController.SearchByName(txtSearchBoxes.Text);

                if (appointment.Rows.Count > 0)
                {
                    DataView pendingView = new DataView(appointment);
                    pendingView.RowFilter = "status = 'pending' AND reschedule_date IS NULL";
                    viewPendingAppointment.DataSource = pendingView;

                    DataView approvedView = new DataView(appointment);
                    approvedView.RowFilter = "status = 'approved'";
                    viewApprovedAppointment.DataSource = approvedView;

                    DataView rescheduleView = new DataView(appointment);
                    rescheduleView.RowFilter = "status = 'pending' AND reschedule_date IS NOT NULL";
                    viewReschedule.DataSource = rescheduleView;

                    DataView cancelledView = new DataView(appointment);
                    cancelledView.RowFilter = "status = 'cancelled'";
                    viewCancelledAppointment.DataSource = cancelledView;

                    DataView missedView = new DataView(appointment);
                    missedView.RowFilter = "status = 'missed'";
                    viewMissedAppointment.DataSource = missedView;

                    DataView completeView = new DataView(appointment);
                    completeView.RowFilter = "status = 'completed'";
                    viewCompletedAppointment.DataSource = completeView;

                    foreach (DataRow row in appointment.Rows)
                    {
                        if (row["qr_code"] != DBNull.Value)
                        {
                            string qrData = row["qr_code"].ToString();
                            Bitmap qrCodeImage = GenerateQrCode(qrData);

                            foreach (DataGridViewRow dataGridViewRow in viewPendingAppointment.Rows)
                            {
                                if (dataGridViewRow.Cells["qrCode"] != null)
                                {
                                    dataGridViewRow.Cells["qrCode"].Value = qrCodeImage;
                                }
                            }

                            foreach (DataGridViewRow dataGridViewRow in viewApprovedAppointment.Rows)
                            {
                                if (dataGridViewRow.Cells["qrCode"] != null)
                                {
                                    dataGridViewRow.Cells["qrCode"].Value = qrCodeImage;
                                }
                            }

                            foreach (DataGridViewRow dataGridViewRow in viewReschedule.Rows)
                            {
                                if (dataGridViewRow.Cells["qrCode"] != null)
                                {
                                    dataGridViewRow.Cells["qrCode"].Value = qrCodeImage;
                                }
                            }

                            foreach (DataGridViewRow dataGridViewRow in viewCompletedAppointment.Rows)
                            {
                                if (dataGridViewRow.Cells["qrCode"] != null)
                                {
                                    dataGridViewRow.Cells["qrCode"].Value = qrCodeImage;
                                }
                            }


                        }
                    }
                }
                else
                {
                    AlertBox(Color.LightSteelBlue, Color.DodgerBlue, "No results", "No patient found with the given search term", Properties.Resources.information);
                }
            }
            catch (Exception ex)
            {
                AlertBox(Color.LightCoral, Color.Red, "Error", "An error occurred while searching for patient data: " + ex.Message, Properties.Resources.error);
            }
        }


        private int selectedAppointmentId;
        private int selectedUserId;

        private int ApprovedAppointmentId;
        private int selectedApprovedUserId;


        private int rescheduleAppointmentId; //row id
        private int rescheduleUserId; //user id

        private void viewApprovedAppointment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (viewApprovedAppointment.Columns[e.ColumnIndex].Name == "check_in" && e.Value != null)
            {
                if (e.Value is bool checkInStatus)
                {
                    e.Value = checkInStatus ? "Checked-in" : "Not Checked-in";
                    e.FormattingApplied = true;
                }
            }

            if (viewApprovedAppointment.Columns[e.ColumnIndex].Name == "appointmentTime" && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime time))
                {
                    e.Value = time.ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }

            if (viewApprovedAppointment.Columns[e.ColumnIndex].Name == "rescheduleTime" && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime time))
                {
                    e.Value = time.ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }
        }

        private void viewPendingAppointment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (viewPendingAppointment.Columns[e.ColumnIndex].Name == "check_in" && e.Value != null)
            {
                if (e.Value is bool checkInStatus)
                {
                    e.Value = checkInStatus ? "Checked-in" : "Not Checked-in";
                    e.FormattingApplied = true;
                }
            }

            if (viewPendingAppointment.Columns[e.ColumnIndex].Name == "appointmentTime" && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime time))
                {
                    e.Value = time.ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }

            if (viewPendingAppointment.Columns[e.ColumnIndex].Name == "rescheduleTime" && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime time))
                {
                    e.Value = time.ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }
        }

        private void viewReschedule_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (viewReschedule.Columns[e.ColumnIndex].Name == "check_in" && e.Value != null)
            {
                if (e.Value is bool checkInStatus)
                {
                    e.Value = checkInStatus ? "Checked-in" : "Not Checked-in";
                    e.FormattingApplied = true;
                }
            }

            if (viewReschedule.Columns[e.ColumnIndex].Name == "appointmentTime" && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime time))
                {
                    e.Value = time.ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }

            if (viewReschedule.Columns[e.ColumnIndex].Name == "rescheduleTime" && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime time))
                {
                    e.Value = time.ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }
        }

        private void viewCancelledAppointment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (viewCancelledAppointment.Columns[e.ColumnIndex].Name == "check_in" && e.Value != null)
            {
                if (e.Value is bool checkInStatus)
                {
                    e.Value = checkInStatus ? "Checked-in" : "Not Checked-in";
                    e.FormattingApplied = true;
                }
            }

            if (viewCancelledAppointment.Columns[e.ColumnIndex].Name == "appointmentTime" && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime time))
                {
                    e.Value = time.ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }

            if (viewCancelledAppointment.Columns[e.ColumnIndex].Name == "rescheduleTime" && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime time))
                {
                    e.Value = time.ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }
        }

        private void viewMissedAppointment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (viewMissedAppointment.Columns[e.ColumnIndex].Name == "check_in" && e.Value != null)
            {
                if (e.Value is bool checkInStatus)
                {
                    e.Value = checkInStatus ? "Checked-in" : "Not Checked-in";
                    e.FormattingApplied = true;
                }
            }

            if (viewMissedAppointment.Columns[e.ColumnIndex].Name == "appointmentTime" && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime time))
                {
                    e.Value = time.ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }

            if (viewMissedAppointment.Columns[e.ColumnIndex].Name == "rescheduleTime" && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime time))
                {
                    e.Value = time.ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }
        }

        private void viewCompletedAppointment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (viewCompletedAppointment.Columns[e.ColumnIndex].Name == "check_in" && e.Value != null)
            {
                if (e.Value is bool checkInStatus)
                {
                    e.Value = checkInStatus ? "Checked-in" : "Not Checked-in";
                    e.FormattingApplied = true;
                }
            }

            if (viewCompletedAppointment.Columns[e.ColumnIndex].Name == "appointmentTime" && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime time))
                {
                    e.Value = time.ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }

            if (viewCompletedAppointment.Columns[e.ColumnIndex].Name == "rescheduleTime" && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime time))
                {
                    e.Value = time.ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }
        }

        private Dictionary<int, int> originalRowHeights = new Dictionary<int, int>();
        private int expandedRowHeight = 150;
        private int defaultRowHeight = 30;

        private void SetupDataGridView()
        {
            foreach (DataGridViewRow row in viewCompletedAppointment.Rows)
            {
                originalRowHeights[row.Index] = row.Height;
            }

            viewCompletedAppointment.RowTemplate.Height = defaultRowHeight;

            viewCompletedAppointment.CellClick += viewCompletedAppointment_CellClick;

            foreach (DataGridViewRow row in viewPendingAppointment.Rows)
            {
                originalRowHeights[row.Index] = row.Height;
            }

            viewPendingAppointment.RowTemplate.Height = defaultRowHeight;

            viewPendingAppointment.CellClick += viewPendingAppointment_CellClick;

            foreach (DataGridViewRow row in viewReschedule.Rows)
            {
                originalRowHeights[row.Index] = row.Height;
            }

            viewReschedule.RowTemplate.Height = defaultRowHeight;

            viewReschedule.CellClick += viewReschedule_CellClick;

            foreach (DataGridViewRow row in viewApprovedAppointment.Rows)
            {
                originalRowHeights[row.Index] = row.Height;
            }

            viewApprovedAppointment.RowTemplate.Height = defaultRowHeight;

            viewApprovedAppointment.CellClick += viewApprovedAppointment_CellClick;
        }



        private async void viewApprovedAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dgv = sender as DataGridView;

            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Height = defaultRowHeight;
                }

                if (dgv.Rows[e.RowIndex].Height == expandedRowHeight)
                {
                    dgv.Rows[e.RowIndex].Height = defaultRowHeight;
                }
                else
                {
                    dgv.Rows[e.RowIndex].Height = expandedRowHeight;
                }

                DataGridViewRow selectedRow = viewApprovedAppointment.Rows[e.RowIndex];

                if (selectedRow.Cells["id"].Value != null &&
                    Int32.TryParse(selectedRow.Cells["id"].Value.ToString(), out ApprovedAppointmentId) &&
                    selectedRow.Cells["user_id"].Value != null &&
                    Int32.TryParse(selectedRow.Cells["user_id"].Value.ToString(), out selectedApprovedUserId))
                {

                    string userEmail = await _handleAppointmentController.SelectEmail(selectedApprovedUserId);
                    string phone = await _handleAppointmentController.SelectPhone(selectedApprovedUserId);


                    if (!string.IsNullOrEmpty(userEmail) && !string.IsNullOrEmpty(phone))
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

            /*if (e.RowIndex >= 0)
            {
                
            }*/
        }

        private async void viewPendingAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Height = defaultRowHeight;
                }

                if (dgv.Rows[e.RowIndex].Height == expandedRowHeight)
                {
                    dgv.Rows[e.RowIndex].Height = defaultRowHeight;
                }
                else
                {
                    dgv.Rows[e.RowIndex].Height = expandedRowHeight;
                }


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

        private async void viewReschedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Height = defaultRowHeight;
                }

                if (dgv.Rows[e.RowIndex].Height == expandedRowHeight)
                {
                    dgv.Rows[e.RowIndex].Height = defaultRowHeight;
                }
                else
                {
                    dgv.Rows[e.RowIndex].Height = expandedRowHeight;
                }


                DataGridViewRow selectedRow = viewReschedule.Rows[e.RowIndex];

                if (selectedRow.Cells["id"].Value != null &&
                    Int32.TryParse(selectedRow.Cells["id"].Value.ToString(), out rescheduleAppointmentId) &&
                    selectedRow.Cells["user_id"].Value != null &&
                    Int32.TryParse(selectedRow.Cells["user_id"].Value.ToString(), out rescheduleUserId))
                {

                    string userEmail = await _handleAppointmentController.SelectEmail(selectedUserId);

                    if (!string.IsNullOrEmpty(userEmail))
                    {
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Failed to convert Appointment ID to integer.");
                }
            }
        }

        private async void viewCompletedAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Height = defaultRowHeight;
                }

                if (dgv.Rows[e.RowIndex].Height == expandedRowHeight)
                {
                    dgv.Rows[e.RowIndex].Height = defaultRowHeight;
                }
                else
                {
                    dgv.Rows[e.RowIndex].Height = expandedRowHeight;
                }

                var selectedRow = viewCompletedAppointment.SelectedRows[0];
                int branchId = Convert.ToInt32(selectedRow.Cells["branch_id"].Value);
                int categoriesId = Convert.ToInt32(selectedRow.Cells["categories_id"].Value);
                int userId = Convert.ToInt32(selectedRow.Cells["user_id"].Value);

                var receiptDetails = await _handleAppointmentController.PrintReceiptDetails(userId, branchId, categoriesId);

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

            /*if (viewCompletedAppointment.SelectedRows.Count > 0)
            {
               
            }
            else
            {
                MessageBox.Show("Please select an appointment to print the receipt.");
            }*/
        }

        private async void btnReminder_Click(object sender, EventArgs e)
        {
            btnReminder.Enabled = false;
            btnReminder.Text = "Sending...";
            try
            {
                bool isSend = await _sendEmailReminder.CheckAppointmentAndSendReminder();

                if (isSend)
                {
                    AlertBox(Color.LightGreen, Color.SeaGreen, "Reminder Sent", "Reminder notification sent successfully", Properties.Resources.success);
                }
                else
                {
                    AlertBox(Color.LightPink, Color.Red, "Reminder Error", "Failed to send reminder notification", Properties.Resources.error);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error sending reminder {ex.Message}");
            }
            finally
            {
                btnReminder.Enabled = true;
                btnReminder.Text = "Send Reminder";
            }
        }
    }
}
