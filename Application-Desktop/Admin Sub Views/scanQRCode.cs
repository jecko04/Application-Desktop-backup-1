using Application_Desktop.Controller;
using Application_Desktop.Model;
using Application_Desktop.Screen;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.QrCode.Internal;

namespace Application_Desktop.Admin_Sub_Views
{
    public partial class scanQRCode : Form
    {
        private handleAppointmentController _handleAppointmentController;
        public scanQRCode()
        {
            _handleAppointmentController = new handleAppointmentController();
            InitializeComponent();
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

        private async Task ConfirmCheckIn(string scannedValue)
        {
            LoadingState.Visible = true;
            lblScanning.Visible = true;
            lvlScanQRC.Visible = false;

            try
            {
                btnStartScan.Visible = false;
                await Task.Delay(3000);

                // Deserialize the scanned JSON string
                var AppointmentData = JsonConvert.DeserializeObject<AppointmentData>(scannedValue);

                if (AppointmentData == null)
                {
                    MessageBox.Show("Invalid appointment data.");
                    return;
                }

                // Check if the appointment is approved
                var isApproved = await _handleAppointmentController.CheckAppointmentStatus(AppointmentData.userId);

                if (isApproved)
                {
                    // Update the check_in status in the database
                    await _handleAppointmentController.UpdateCheckInStatus(AppointmentData.userId, AppointmentData.appointment_date, AppointmentData.appointment_time);

                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        LoadingState.Visible = false;
                        lvlScanQRC.Visible = true;
                        lblScanning.Visible = false;

                        AlertBox(Color.LightGreen, Color.SeaGreen, "Valid QRCode", "Check-in successful!", Properties.Resources.success);
                    });


                }
                else
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        lblScanning.Visible = false;
                        lvlScanQRC.Visible = true;
                        LoadingState.Visible = false;
                        AlertBox(Color.LightCoral, Color.Red, "Not Valid QRCode", "Appointment is not approved or does not exist.", Properties.Resources.error);
                    });
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
                btnStartScan.Visible = true;
                lvlScanQRC.Visible = true;

                textBox1.Focus();

            }
        }

        private bool IsScanning = false;
        private void btnStartScan_Click(object sender, EventArgs e)
        {

            if (!IsScanning)
            {
                IsScanning = true;
                btnStartScan.Text = "Stop Scanning";
                lvlScanQRC.Visible = true;

                StartScanning();
            }
            else
            {
                IsScanning = false;
                btnStartScan.Text = "Start Scanning";
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
    }
}
