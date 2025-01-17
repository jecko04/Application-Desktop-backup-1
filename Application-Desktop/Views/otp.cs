﻿using Application_Desktop.Controller;
using Application_Desktop.Models;
using Application_Desktop.Screen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Desktop.Views
{
    public partial class otp : Form
    {
        private loginPageController _loginPageController;
        public otp()
        {
            _loginPageController = new loginPageController();
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

        private async Task InsertOTP()
        {
            int ID = session.LoggedInSession;
            int? superadmin = null;
            string enteredOtp = txtOtpCode.Text;

            bool isValid = await _loginPageController.VerifyOTP(ID, enteredOtp);

            if (isValid)
            {
                await _loginPageController.UpdateOtpStatusAsync(ID, superadmin, true);


                adminPage adminForm = new adminPage();
                adminForm.BringToFront();
                adminForm.Show();

                this.Hide();

                this.BeginInvoke((MethodInvoker)delegate
               {
                   AlertBox(Color.LightGreen, Color.SeaGreen, "Login Successful", "OTP Verification Code Success", Properties.Resources.success);
               });
            }
            else
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    AlertBox(Color.LightPink, Color.Red, "OTP is Not Valid", "OTP Verification Code Failed", Properties.Resources.error);
                });
            }

        }
        private async void btnVerify_Click(object sender, EventArgs e)
        {
            await InsertOTP();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            session.Logout();

            this.Hide();

            this.BeginInvoke(new Action(() =>
            {
                AlertBox(Color.LightGreen, Color.SeaGreen, "Logout Success", "You have been logged out successfully.", Properties.Resources.success);

                Task.Delay(2000).ContinueWith(t =>
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Hide();

                        loginPage loginForm = new loginPage();
                        loginForm.Show();
                    }));
                });
            }));
        }
    }
}
