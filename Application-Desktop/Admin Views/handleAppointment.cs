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

namespace Application_Desktop.Admin_Views
{
    public partial class handleAppointment : Form
    {
        private handleAppointmentController _handleAppointmentController;
        public PatientData PatientData { get; set; }

        public handleAppointment()
        {
            InitializeComponent();
            PatientData = new PatientData();
            _handleAppointmentController = new handleAppointmentController();

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

        private async Task LoadReschedule()
        {
            try
            {
                DataTable reschedule = await _handleAppointmentController.RescheduleAppointment();
                viewReschedule.DataSource = null;
                viewReschedule.Rows.Clear();
                viewReschedule.Columns.Clear();

                viewReschedule.AutoGenerateColumns = false;
                AddColumnReschedule(viewReschedule);

                viewReschedule.DataSource = reschedule;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load patient records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task LoadApproved()
        {
            try
            {
                // Fetch approved appointments
                DataTable approved = await _handleAppointmentController.ApprovedAppointment();

                // Clear the DataGridView
                viewApprovedAppointment.DataSource = null;
                viewApprovedAppointment.Rows.Clear();

                // Add columns if they don't exist
                if (viewApprovedAppointment.Columns.Count == 0)
                {
                    AddColumnApproved(viewApprovedAppointment);
                }

                // Populate DataGridView with rows
                foreach (DataRow row in approved.Rows)
                {
                    string qrData = row["qr_code"].ToString(); // Ensure column name matches your database
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

        private void AddColumnReschedule(DataGridView Reschedule)
        {
            Reschedule.RowHeadersVisible = false;
            Reschedule.ColumnHeadersHeight = 40;

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                Name = "id",
                DataPropertyName = "id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Reschedule.Columns.Add(id);

            DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "User ID",
                Name = "user_id",
                DataPropertyName = "user_id",
                Visible = false
            };
            Reschedule.Columns.Add(userIdColumn);

            DataGridViewTextBoxColumn fullname = new DataGridViewTextBoxColumn
            {
                HeaderText = "Fullname",
                Name = "fullname",
                DataPropertyName = "UserName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Reschedule.Columns.Add(fullname);

            DataGridViewTextBoxColumn branches = new DataGridViewTextBoxColumn
            {
                HeaderText = "Branch",
                Name = "branches",
                DataPropertyName = "BranchName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Reschedule.Columns.Add(branches);

            DataGridViewTextBoxColumn services = new DataGridViewTextBoxColumn
            {
                HeaderText = "Services",
                Name = "services",
                DataPropertyName = "ServiceTitle",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Reschedule.Columns.Add(services);

            DataGridViewTextBoxColumn appointment_date = new DataGridViewTextBoxColumn
            {
                HeaderText = "Appointment Date",
                Name = "appointmentDate",
                DataPropertyName = "appointment_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Reschedule.Columns.Add(appointment_date);

            DataGridViewTextBoxColumn appointment_time = new DataGridViewTextBoxColumn
            {
                HeaderText = "Appointment Time",
                Name = "appointmentTime",
                DataPropertyName = "appointment_time",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Reschedule.Columns.Add(appointment_time);

            DataGridViewTextBoxColumn reschedule_date = new DataGridViewTextBoxColumn
            {
                HeaderText = "Reschedule Date",
                Name = "rescheduleDate",
                DataPropertyName = "reschedule_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Reschedule.Columns.Add(reschedule_date);

            DataGridViewTextBoxColumn reschedule_time = new DataGridViewTextBoxColumn
            {
                HeaderText = "Reschedule Time",
                Name = "rescheduleTime",
                DataPropertyName = "reschedule_time",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Reschedule.Columns.Add(reschedule_time);

            DataGridViewTextBoxColumn status = new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                Name = "status",
                DataPropertyName = "status",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

            };
            Reschedule.Columns.Add(status);
        }

        private void AddColumnApproved(DataGridView approved)
        {
            approved.RowHeadersVisible = false;
            approved.ColumnHeadersHeight = 40;
            approved.RowTemplate.Height = 150;


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
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "MM/dd/yyyy" 
                }

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
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "MM/dd/yyyy"
                }

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

                        if (!string.IsNullOrEmpty(email))
                        {
                            bool emailSent = selectedAppointmentId > 0
                                ? await SendEmailNotification(email, selectedAppointmentId.ToString(), "approved")
                                : await SendRescheduleApproved(email, rescheduleUserId.ToString(), "approved");

                            if (emailSent)
                            {
                                await approved();
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

                /*this.BeginInvoke((MethodInvoker)delegate
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


        public async Task cancelled()
        {

            string userEmailPending = await _handleAppointmentController.SelectEmail(selectedUserId);
            string userEmailApproved = await _handleAppointmentController.SelectEmail(selectedApprovedUserId);
            string userEmailReschedule = await _handleAppointmentController.SelectEmail(rescheduleUserId);


            if (string.IsNullOrEmpty(userEmailPending) && string.IsNullOrEmpty(userEmailApproved) && string.IsNullOrEmpty(userEmailReschedule))
            {
                AlertBox(Color.LightCoral, Color.Red, "Email Not Found", "User email not found.", Properties.Resources.error);
                return;
            }
            if (selectedAppointmentId > 0)
            {
                await ProcessCancellation(userEmailPending, selectedAppointmentId, viewPendingAppointment, "cancelled");
                userEmailPending = string.Empty;
                selectedAppointmentId = 0;
            }

            if (ApprovedAppointmentId > 0)
            {
                await ProcessCancellation(userEmailApproved, ApprovedAppointmentId, viewApprovedAppointment, "missed");
                userEmailApproved = string.Empty;
                ApprovedAppointmentId = 0;
            }

            if (rescheduleAppointmentId > 0)
            {
                await ProcessCancellation(userEmailReschedule, rescheduleAppointmentId, viewReschedule, "rejected");
                userEmailApproved = string.Empty;
                rescheduleAppointmentId = 0;
            }
        }

        private async Task ProcessCancellation(string userEmail, int appointmentId, DataGridView view, string cancellationType)
        {
            LoadingState.Visible = true;

            try
            {
                //await Task.Delay(3000);
                bool emailSent = false;

                if (cancellationType == "cancelled")
                {
                    emailSent = await SendCancelledNotification(userEmail, appointmentId.ToString(), cancellationType);
                }
                else if (cancellationType == "missed")
                {
                    emailSent = await SendMissedNotification(userEmail, appointmentId.ToString(), cancellationType);
                }
                else if (cancellationType == "rejected")
                {
                    emailSent = await SendRejectedNotification(userEmail, appointmentId.ToString(), cancellationType);
                }

                if (emailSent)
                {

                    if (cancellationType == "cancelled")
                    {
                        await _handleAppointmentController.Cancel(cancellationType, appointmentId);
                    }
                    else if (cancellationType == "missed")
                    {
                        await _handleAppointmentController.Missed(cancellationType, appointmentId);
                    }
                    else if (cancellationType == "rejected")
                    {
                        await _handleAppointmentController.Cancel("cancelled", appointmentId);

                    }

                    view.ClearSelection();
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        AlertBox(Color.LightGreen, Color.SeaGreen, "Appointment Cancelled", "Appointment Change Status Successfully!", Properties.Resources.success);
                        LoadingState.Visible = false;
                    });
                }
                else
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        AlertBox(Color.LightCoral, Color.Red, "Cancel Failed", "Email notification failed.", Properties.Resources.error);
                        LoadingState.Visible = false;
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"error {ex.Message}");
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
                patientData.AppointmentDate = appointmentData["appointment_date"].ToString();
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

                // Deserialize the scanned JSON string
                var AppointmentData = JsonConvert.DeserializeObject<AppointmentData>(scannedValue);

                if (AppointmentData == null)
                {
                    MessageBox.Show("Invalid appointment data.");
                    return;
                }

                bool isCheckedIn = await _handleAppointmentController.IsCheckedIn(PatientData.AppointmentId);

                if (isCheckedIn)
                {
                    await HandleCheckedIn(AppointmentData.userId);
                }
                else
                {
                    var isApproved = await _handleAppointmentController.CheckAppointmentStatus(AppointmentData.userId, AppointmentData.appointment_date, AppointmentData.appointment_time);

                    if (isApproved)
                    {
                        // Update the check_in status in the database
                        //await _handleAppointmentController.UpdateCheckInStatus(AppointmentData.userId, AppointmentData.appointment_date, AppointmentData.appointment_time);


                        //palitan at gawin if check_in == 1 already show the quickretrieval instead and if not update the check_in then show the form
                        await HandleCheckedIn(AppointmentData.userId);

                        AlertBox(Color.LightGreen, Color.SeaGreen, "Valid QRCode", "Check-in successful!", Properties.Resources.success);


                    }
                    else
                    {
                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            lblScanning.Visible = false;
                            lvlScanQRC.Visible = false;
                            LoadingState.Visible = false;
                            btnQRCode.Text = "Start Scanning";

                            AlertBox(Color.LightCoral, Color.Red, "Not Valid QRCode", "Appointment is not approved or does not exist.", Properties.Resources.error);
                        });
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during check-in: {ex.Message}");
            }
            finally
            {
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

                if (appointment != null && appointment.Rows.Count > 0)
                {
                    DataView pendingView = new DataView(appointment);
                    pendingView.RowFilter = "status = 'pending'";
                    viewPendingAppointment.DataSource = pendingView;

                    DataView approvedView = new DataView(appointment);
                    approvedView.RowFilter = "status = 'approved'";
                    viewApprovedAppointment.DataSource = approvedView;

                    DataView rescheduleView = new DataView(appointment);
                    approvedView.RowFilter = "status = 'pending' AND reschedule_date IS NOT NULL";
                    viewReschedule.DataSource = approvedView;

                    DataView cancelledView = new DataView(appointment);
                    cancelledView.RowFilter = "status = 'cancelled'";
                    viewCancelledAppointment.DataSource = cancelledView;

                    DataView missedView = new DataView(appointment);
                    missedView.RowFilter = "status = 'missed'";
                    viewMissedAppointment.DataSource = missedView;

                    DataView completeView = new DataView(appointment);
                    completeView.RowFilter = "status = 'completed'";
                    viewCompletedAppointment.DataSource = completeView;
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
        private async void viewPendingAppointment_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private int ApprovedAppointmentId;
        private int selectedApprovedUserId;
        private async void viewApprovedAppointment_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private async void viewCompletedAppointment_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (viewCompletedAppointment.SelectedRows.Count > 0)
            {
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
            else
            {
                MessageBox.Show("Please select an appointment to print the receipt.");
            }
        }

        private int rescheduleAppointmentId; //row id
        private int rescheduleUserId; //user id
        private async void viewReschedule_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
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

    }
}
