namespace Application_Desktop.Views
{
    partial class adminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPage));
            sidebarContainer = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel7 = new Panel();
            button6 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnDashboard = new Button();
            recordContainer = new FlowLayoutPanel();
            panel13 = new Panel();
            btnPatientRecord = new Button();
            panel5 = new Panel();
            btnViewPatient = new Button();
            setupContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            btnSetup = new Button();
            panel15 = new Panel();
            btnCategory = new Button();
            panel16 = new Panel();
            btnOnlineBooking = new Button();
            appointmentContainer = new FlowLayoutPanel();
            panel19 = new Panel();
            btnAppointment = new Button();
            panel22 = new Panel();
            btnViewAllAppointment = new Button();
            panel4 = new Panel();
            btnEmployee = new Button();
            menuContainer = new FlowLayoutPanel();
            panel9 = new Panel();
            btnMenu = new Button();
            panel18 = new Panel();
            panel10 = new Panel();
            btnSetting = new Button();
            panel8 = new Panel();
            btnLogout = new Button();
            mainPanel = new Panel();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            setupTransition = new System.Windows.Forms.Timer(components);
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            elipseControl2 = new ElipseToolDemo.ElipseControl();
            PatientTransition = new System.Windows.Forms.Timer(components);
            AppointTransition = new System.Windows.Forms.Timer(components);
            sidebarContainer.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            recordContainer.SuspendLayout();
            panel13.SuspendLayout();
            panel5.SuspendLayout();
            setupContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            appointmentContainer.SuspendLayout();
            panel19.SuspendLayout();
            panel22.SuspendLayout();
            panel4.SuspendLayout();
            menuContainer.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarContainer
            // 
            sidebarContainer.BackColor = Color.FromArgb(250, 220, 18);
            sidebarContainer.Controls.Add(flowLayoutPanel2);
            sidebarContainer.Controls.Add(panel1);
            sidebarContainer.Controls.Add(panel2);
            sidebarContainer.Controls.Add(recordContainer);
            sidebarContainer.Controls.Add(setupContainer);
            sidebarContainer.Controls.Add(appointmentContainer);
            sidebarContainer.Controls.Add(panel4);
            sidebarContainer.Controls.Add(menuContainer);
            sidebarContainer.Dock = DockStyle.Left;
            sidebarContainer.Location = new Point(0, 0);
            sidebarContainer.Margin = new Padding(0);
            sidebarContainer.Name = "sidebarContainer";
            sidebarContainer.Size = new Size(185, 690);
            sidebarContainer.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(123, 44, 191);
            flowLayoutPanel2.Controls.Add(panel7);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(185, 0);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(button6);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(173, 34);
            panel7.TabIndex = 2;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(123, 44, 191);
            button6.Dock = DockStyle.Fill;
            button6.FlatAppearance.BorderColor = Color.White;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 9F);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 0);
            button6.Name = "button6";
            button6.Size = new Size(173, 34);
            button6.TabIndex = 3;
            button6.Text = "         Dashboard";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(182, 40);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(250, 220, 18);
            panel2.Controls.Add(btnDashboard);
            panel2.Location = new Point(0, 48);
            panel2.Margin = new Padding(0, 2, 0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(184, 34);
            panel2.TabIndex = 2;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(250, 220, 18);
            btnDashboard.Dock = DockStyle.Fill;
            btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(250, 220, 18);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Microsoft Sans Serif", 9F);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Margin = new Padding(0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(184, 34);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "              Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // recordContainer
            // 
            recordContainer.BackColor = Color.FromArgb(250, 220, 18);
            recordContainer.Controls.Add(panel13);
            recordContainer.Controls.Add(panel5);
            recordContainer.Location = new Point(0, 84);
            recordContainer.Margin = new Padding(0, 2, 0, 0);
            recordContainer.Name = "recordContainer";
            recordContainer.Size = new Size(184, 34);
            recordContainer.TabIndex = 9;
            // 
            // panel13
            // 
            panel13.Controls.Add(btnPatientRecord);
            panel13.Location = new Point(0, 0);
            panel13.Margin = new Padding(0);
            panel13.Name = "panel13";
            panel13.Size = new Size(185, 34);
            panel13.TabIndex = 11;
            // 
            // btnPatientRecord
            // 
            btnPatientRecord.BackColor = Color.FromArgb(250, 220, 18);
            btnPatientRecord.Dock = DockStyle.Fill;
            btnPatientRecord.FlatAppearance.BorderColor = Color.FromArgb(250, 220, 18);
            btnPatientRecord.FlatStyle = FlatStyle.Flat;
            btnPatientRecord.Font = new Font("Microsoft Sans Serif", 9F);
            btnPatientRecord.ForeColor = Color.Black;
            btnPatientRecord.Image = (Image)resources.GetObject("btnPatientRecord.Image");
            btnPatientRecord.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatientRecord.Location = new Point(0, 0);
            btnPatientRecord.Margin = new Padding(0);
            btnPatientRecord.Name = "btnPatientRecord";
            btnPatientRecord.Size = new Size(185, 34);
            btnPatientRecord.TabIndex = 3;
            btnPatientRecord.Text = "              Patient Records";
            btnPatientRecord.TextAlign = ContentAlignment.MiddleLeft;
            btnPatientRecord.UseVisualStyleBackColor = false;
            btnPatientRecord.Click += btnPatientRecord_Click_1;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnViewPatient);
            panel5.Location = new Point(0, 34);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(213, 34);
            panel5.TabIndex = 3;
            // 
            // btnViewPatient
            // 
            btnViewPatient.BackColor = Color.FromArgb(250, 220, 18);
            btnViewPatient.Dock = DockStyle.Fill;
            btnViewPatient.FlatAppearance.BorderColor = Color.FromArgb(250, 220, 18);
            btnViewPatient.FlatStyle = FlatStyle.Flat;
            btnViewPatient.Font = new Font("Microsoft Sans Serif", 9F);
            btnViewPatient.ForeColor = Color.Black;
            btnViewPatient.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewPatient.Location = new Point(0, 0);
            btnViewPatient.Margin = new Padding(0);
            btnViewPatient.Name = "btnViewPatient";
            btnViewPatient.Size = new Size(213, 34);
            btnViewPatient.TabIndex = 3;
            btnViewPatient.Text = "              View Patient Records";
            btnViewPatient.TextAlign = ContentAlignment.MiddleLeft;
            btnViewPatient.UseVisualStyleBackColor = false;
            btnViewPatient.Click += btnViewPatient_Click;
            // 
            // setupContainer
            // 
            setupContainer.BackColor = Color.FromArgb(250, 220, 18);
            setupContainer.Controls.Add(panel3);
            setupContainer.Controls.Add(panel15);
            setupContainer.Controls.Add(panel16);
            setupContainer.Location = new Point(0, 120);
            setupContainer.Margin = new Padding(0, 2, 0, 0);
            setupContainer.Name = "setupContainer";
            setupContainer.Size = new Size(184, 34);
            setupContainer.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSetup);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 34);
            panel3.TabIndex = 3;
            // 
            // btnSetup
            // 
            btnSetup.BackColor = Color.FromArgb(250, 220, 18);
            btnSetup.Dock = DockStyle.Fill;
            btnSetup.FlatAppearance.BorderColor = Color.FromArgb(250, 220, 18);
            btnSetup.FlatStyle = FlatStyle.Flat;
            btnSetup.Font = new Font("Microsoft Sans Serif", 9F);
            btnSetup.ForeColor = Color.Black;
            btnSetup.Image = (Image)resources.GetObject("btnSetup.Image");
            btnSetup.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetup.Location = new Point(0, 0);
            btnSetup.Margin = new Padding(0);
            btnSetup.Name = "btnSetup";
            btnSetup.Size = new Size(185, 34);
            btnSetup.TabIndex = 3;
            btnSetup.Text = "              Setup Services ";
            btnSetup.TextAlign = ContentAlignment.MiddleLeft;
            btnSetup.UseVisualStyleBackColor = false;
            btnSetup.Click += btnSetup_Click;
            // 
            // panel15
            // 
            panel15.Controls.Add(btnCategory);
            panel15.Location = new Point(1, 34);
            panel15.Margin = new Padding(1, 0, 0, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(213, 34);
            panel15.TabIndex = 4;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.Transparent;
            btnCategory.Dock = DockStyle.Fill;
            btnCategory.FlatAppearance.BorderColor = Color.FromArgb(31, 97, 141);
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.Font = new Font("Microsoft Sans Serif", 9F);
            btnCategory.ForeColor = Color.Black;
            btnCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategory.Location = new Point(0, 0);
            btnCategory.Margin = new Padding(0);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(213, 34);
            btnCategory.TabIndex = 3;
            btnCategory.Text = "              Services / OpenHours";
            btnCategory.TextAlign = ContentAlignment.MiddleLeft;
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // panel16
            // 
            panel16.Controls.Add(btnOnlineBooking);
            panel16.Location = new Point(1, 68);
            panel16.Margin = new Padding(1, 0, 0, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(213, 34);
            panel16.TabIndex = 5;
            // 
            // btnOnlineBooking
            // 
            btnOnlineBooking.BackColor = Color.Transparent;
            btnOnlineBooking.Dock = DockStyle.Fill;
            btnOnlineBooking.FlatAppearance.BorderColor = Color.FromArgb(31, 97, 141);
            btnOnlineBooking.FlatAppearance.BorderSize = 0;
            btnOnlineBooking.FlatStyle = FlatStyle.Flat;
            btnOnlineBooking.Font = new Font("Microsoft Sans Serif", 9F);
            btnOnlineBooking.ForeColor = Color.Black;
            btnOnlineBooking.ImageAlign = ContentAlignment.MiddleLeft;
            btnOnlineBooking.Location = new Point(0, 0);
            btnOnlineBooking.Margin = new Padding(0);
            btnOnlineBooking.Name = "btnOnlineBooking";
            btnOnlineBooking.Size = new Size(213, 34);
            btnOnlineBooking.TabIndex = 3;
            btnOnlineBooking.Text = "              Services Availability\r\n";
            btnOnlineBooking.TextAlign = ContentAlignment.MiddleLeft;
            btnOnlineBooking.UseVisualStyleBackColor = false;
            btnOnlineBooking.Click += btnOnlineBooking_Click;
            // 
            // appointmentContainer
            // 
            appointmentContainer.BackColor = Color.FromArgb(250, 220, 18);
            appointmentContainer.Controls.Add(panel19);
            appointmentContainer.Controls.Add(panel22);
            appointmentContainer.Location = new Point(0, 156);
            appointmentContainer.Margin = new Padding(0, 2, 8, 0);
            appointmentContainer.Name = "appointmentContainer";
            appointmentContainer.Size = new Size(184, 34);
            appointmentContainer.TabIndex = 9;
            // 
            // panel19
            // 
            panel19.Controls.Add(btnAppointment);
            panel19.Location = new Point(0, 0);
            panel19.Margin = new Padding(0);
            panel19.Name = "panel19";
            panel19.Size = new Size(185, 34);
            panel19.TabIndex = 3;
            // 
            // btnAppointment
            // 
            btnAppointment.BackColor = Color.FromArgb(250, 220, 18);
            btnAppointment.BackgroundImageLayout = ImageLayout.Center;
            btnAppointment.Dock = DockStyle.Fill;
            btnAppointment.FlatAppearance.BorderColor = Color.FromArgb(250, 220, 18);
            btnAppointment.FlatStyle = FlatStyle.Flat;
            btnAppointment.Font = new Font("Microsoft Sans Serif", 9F);
            btnAppointment.ForeColor = Color.Black;
            btnAppointment.Image = (Image)resources.GetObject("btnAppointment.Image");
            btnAppointment.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppointment.Location = new Point(0, 0);
            btnAppointment.Margin = new Padding(0);
            btnAppointment.Name = "btnAppointment";
            btnAppointment.Padding = new Padding(0, 0, 15, 0);
            btnAppointment.RightToLeft = RightToLeft.No;
            btnAppointment.Size = new Size(185, 34);
            btnAppointment.TabIndex = 3;
            btnAppointment.Text = "              Appointment";
            btnAppointment.TextAlign = ContentAlignment.MiddleLeft;
            btnAppointment.UseVisualStyleBackColor = false;
            btnAppointment.Click += btnAppointment_Click;
            // 
            // panel22
            // 
            panel22.Controls.Add(btnViewAllAppointment);
            panel22.Location = new Point(0, 34);
            panel22.Margin = new Padding(0);
            panel22.Name = "panel22";
            panel22.Size = new Size(213, 34);
            panel22.TabIndex = 4;
            // 
            // btnViewAllAppointment
            // 
            btnViewAllAppointment.BackColor = Color.Transparent;
            btnViewAllAppointment.Dock = DockStyle.Fill;
            btnViewAllAppointment.FlatAppearance.BorderColor = Color.FromArgb(31, 97, 141);
            btnViewAllAppointment.FlatAppearance.BorderSize = 0;
            btnViewAllAppointment.FlatStyle = FlatStyle.Flat;
            btnViewAllAppointment.Font = new Font("Microsoft Sans Serif", 9F);
            btnViewAllAppointment.ForeColor = Color.Black;
            btnViewAllAppointment.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewAllAppointment.Location = new Point(0, 0);
            btnViewAllAppointment.Margin = new Padding(0);
            btnViewAllAppointment.Name = "btnViewAllAppointment";
            btnViewAllAppointment.Size = new Size(213, 34);
            btnViewAllAppointment.TabIndex = 3;
            btnViewAllAppointment.Text = "              View All Appointments";
            btnViewAllAppointment.TextAlign = ContentAlignment.MiddleLeft;
            btnViewAllAppointment.UseVisualStyleBackColor = false;
            btnViewAllAppointment.Click += btnViewAllAppointment_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(250, 220, 18);
            panel4.Controls.Add(btnEmployee);
            panel4.Location = new Point(0, 192);
            panel4.Margin = new Padding(0, 2, 0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(184, 34);
            panel4.TabIndex = 4;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(250, 220, 18);
            btnEmployee.Dock = DockStyle.Fill;
            btnEmployee.FlatAppearance.BorderColor = Color.FromArgb(250, 220, 18);
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Microsoft Sans Serif", 9F);
            btnEmployee.ForeColor = Color.Black;
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(0, 0);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(184, 34);
            btnEmployee.TabIndex = 3;
            btnEmployee.Text = "              Employee Profile";
            btnEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(250, 220, 18);
            menuContainer.Controls.Add(panel9);
            menuContainer.Controls.Add(panel10);
            menuContainer.Controls.Add(panel8);
            menuContainer.Location = new Point(0, 228);
            menuContainer.Margin = new Padding(0, 2, 0, 0);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(184, 34);
            menuContainer.TabIndex = 8;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnMenu);
            panel9.Controls.Add(panel18);
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(185, 34);
            panel9.TabIndex = 3;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(250, 220, 18);
            btnMenu.Dock = DockStyle.Fill;
            btnMenu.FlatAppearance.BorderColor = Color.FromArgb(250, 220, 18);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Microsoft Sans Serif", 9F);
            btnMenu.ForeColor = Color.Black;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(185, 34);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "              Account\r\n";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel18
            // 
            panel18.BackColor = Color.White;
            panel18.Location = new Point(14, 33);
            panel18.Name = "panel18";
            panel18.Size = new Size(157, 1);
            panel18.TabIndex = 10;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnSetting);
            panel10.Location = new Point(0, 34);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(213, 34);
            panel10.TabIndex = 4;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.Transparent;
            btnSetting.Dock = DockStyle.Fill;
            btnSetting.FlatAppearance.BorderColor = Color.FromArgb(31, 97, 141);
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Microsoft Sans Serif", 9F);
            btnSetting.ForeColor = Color.Black;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 0);
            btnSetting.Margin = new Padding(0);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(213, 34);
            btnSetting.TabIndex = 3;
            btnSetting.Text = "              Profile Setting";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnLogout);
            panel8.Location = new Point(0, 68);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(213, 34);
            panel8.TabIndex = 4;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Dock = DockStyle.Fill;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(31, 97, 141);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 9F);
            btnLogout.ForeColor = Color.Black;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 0);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(213, 34);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "              Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Transparent;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(185, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(15, 0, 15, 0);
            mainPanel.Size = new Size(1095, 690);
            mainPanel.TabIndex = 3;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick_1;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick_1;
            // 
            // setupTransition
            // 
            setupTransition.Interval = 10;
            setupTransition.Tick += setupTransition_Tick;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = mainPanel;
            // 
            // elipseControl2
            // 
            elipseControl2.CornerRadius = 5;
            elipseControl2.TargetControl = sidebarContainer;
            // 
            // PatientTransition
            // 
            PatientTransition.Interval = 10;
            PatientTransition.Tick += PatientTransition_Tick;
            // 
            // AppointTransition
            // 
            AppointTransition.Interval = 10;
            AppointTransition.Tick += AppointTransition_Tick;
            // 
            // adminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 690);
            Controls.Add(mainPanel);
            Controls.Add(sidebarContainer);
            Name = "adminPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += adminPage_Load;
            sidebarContainer.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            recordContainer.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel5.ResumeLayout(false);
            setupContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel16.ResumeLayout(false);
            appointmentContainer.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel4.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel sidebarContainer;
        private Panel panel2;
        private Button btnDashboard;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel7;
        private Button button6;
        private Panel panel3;
        private Button btnSetup;
        private Panel panel4;
        private Button btnEmployee;
        private FlowLayoutPanel menuContainer;
        private Panel panel9;
        private Button btnMenu;
        private Panel panel10;
        private Button btnSetting;
        private Panel panel8;
        private Button btnLogout;
        private Panel mainPanel;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private FlowLayoutPanel setupContainer;
        private Panel panel15;
        private Button btnCategory;
        private Panel panel16;
        private Button btnOnlineBooking;
        private System.Windows.Forms.Timer setupTransition;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private ElipseToolDemo.ElipseControl elipseControl2;
        private FlowLayoutPanel recordContainer;
        private Panel panel5;
        private Button btnViewPatient;
        private Panel panel18;
        private FlowLayoutPanel appointmentContainer;
        private Panel panel19;
        private Button btnAppointment;
        private Panel panel22;
        private Button btnViewAllAppointment;
        private Panel panel13;
        private Button btnPatientRecord;
        private System.Windows.Forms.Timer PatientTransition;
        private System.Windows.Forms.Timer AppointTransition;
        private Panel panel1;
    }
}