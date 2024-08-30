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
            panel1 = new Panel();
            btnSidebar = new PictureBox();
            sidebarContainer = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel7 = new Panel();
            button6 = new Button();
            panel2 = new Panel();
            btnDashboard = new Button();
            panel4 = new Panel();
            btnEmployee = new Button();
            panel11 = new Panel();
            btnDoctors = new Button();
            panel5 = new Panel();
            btnUsers = new Button();
            setupContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            btnSetup = new Button();
            panel14 = new Panel();
            btnOfficeHourAndStaff = new Button();
            panel15 = new Panel();
            btnCategory = new Button();
            panel16 = new Panel();
            btnOnlineBooking = new Button();
            menuContainer = new FlowLayoutPanel();
            panel9 = new Panel();
            btnMenu = new Button();
            panel6 = new Panel();
            btnAbout = new Button();
            panel10 = new Panel();
            btnSetting = new Button();
            panel8 = new Panel();
            btnLogout = new Button();
            mainPanel = new Panel();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            setupTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSidebar).BeginInit();
            sidebarContainer.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel11.SuspendLayout();
            panel5.SuspendLayout();
            setupContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            menuContainer.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSidebar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 30);
            panel1.TabIndex = 0;
            // 
            // btnSidebar
            // 
            btnSidebar.Cursor = Cursors.Hand;
            btnSidebar.Image = (Image)resources.GetObject("btnSidebar.Image");
            btnSidebar.Location = new Point(3, 3);
            btnSidebar.Margin = new Padding(0);
            btnSidebar.Name = "btnSidebar";
            btnSidebar.Size = new Size(31, 24);
            btnSidebar.SizeMode = PictureBoxSizeMode.Zoom;
            btnSidebar.TabIndex = 2;
            btnSidebar.TabStop = false;
            btnSidebar.Click += btnSidebar_Click;
            // 
            // sidebarContainer
            // 
            sidebarContainer.BackColor = Color.FromArgb(41, 128, 185);
            sidebarContainer.Controls.Add(flowLayoutPanel2);
            sidebarContainer.Controls.Add(panel2);
            sidebarContainer.Controls.Add(panel4);
            sidebarContainer.Controls.Add(panel11);
            sidebarContainer.Controls.Add(panel5);
            sidebarContainer.Controls.Add(setupContainer);
            sidebarContainer.Controls.Add(menuContainer);
            sidebarContainer.Dock = DockStyle.Left;
            sidebarContainer.Location = new Point(0, 30);
            sidebarContainer.Margin = new Padding(0);
            sidebarContainer.Name = "sidebarContainer";
            sidebarContainer.Size = new Size(179, 660);
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
            button6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            // panel2
            // 
            panel2.Controls.Add(btnDashboard);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(179, 34);
            panel2.TabIndex = 2;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(41, 128, 185);
            btnDashboard.Dock = DockStyle.Fill;
            btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDashboard.ForeColor = SystemColors.ButtonFace;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Margin = new Padding(0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(179, 34);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "              Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnEmployee);
            panel4.Location = new Point(0, 34);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(179, 34);
            panel4.TabIndex = 4;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(41, 128, 185);
            btnEmployee.Dock = DockStyle.Fill;
            btnEmployee.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployee.ForeColor = SystemColors.ButtonFace;
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(0, 0);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(179, 34);
            btnEmployee.TabIndex = 3;
            btnEmployee.Text = "              Employee Profile";
            btnEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnDoctors);
            panel11.Location = new Point(0, 68);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(179, 34);
            panel11.TabIndex = 9;
            // 
            // btnDoctors
            // 
            btnDoctors.BackColor = Color.FromArgb(41, 128, 185);
            btnDoctors.Dock = DockStyle.Fill;
            btnDoctors.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnDoctors.FlatStyle = FlatStyle.Flat;
            btnDoctors.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDoctors.ForeColor = SystemColors.ButtonFace;
            btnDoctors.Image = (Image)resources.GetObject("btnDoctors.Image");
            btnDoctors.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoctors.Location = new Point(0, 0);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(179, 34);
            btnDoctors.TabIndex = 3;
            btnDoctors.Text = "              Dental Doctors";
            btnDoctors.TextAlign = ContentAlignment.MiddleLeft;
            btnDoctors.UseVisualStyleBackColor = false;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnUsers);
            panel5.Location = new Point(0, 102);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(179, 34);
            panel5.TabIndex = 4;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(41, 128, 185);
            btnUsers.Dock = DockStyle.Fill;
            btnUsers.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsers.ForeColor = SystemColors.ButtonFace;
            btnUsers.Image = (Image)resources.GetObject("btnUsers.Image");
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(0, 0);
            btnUsers.Margin = new Padding(0);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(179, 34);
            btnUsers.TabIndex = 3;
            btnUsers.Text = "              Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // setupContainer
            // 
            setupContainer.BackColor = Color.FromArgb(31, 97, 141);
            setupContainer.Controls.Add(panel3);
            setupContainer.Controls.Add(panel15);
            setupContainer.Controls.Add(panel14);
            setupContainer.Controls.Add(panel16);
            setupContainer.Location = new Point(0, 136);
            setupContainer.Margin = new Padding(0);
            setupContainer.Name = "setupContainer";
            setupContainer.Size = new Size(179, 34);
            setupContainer.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSetup);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(179, 34);
            panel3.TabIndex = 3;
            // 
            // btnSetup
            // 
            btnSetup.BackColor = Color.FromArgb(41, 128, 185);
            btnSetup.Dock = DockStyle.Fill;
            btnSetup.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnSetup.FlatStyle = FlatStyle.Flat;
            btnSetup.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetup.ForeColor = SystemColors.ButtonFace;
            btnSetup.Image = (Image)resources.GetObject("btnSetup.Image");
            btnSetup.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetup.Location = new Point(0, 0);
            btnSetup.Margin = new Padding(0);
            btnSetup.Name = "btnSetup";
            btnSetup.Size = new Size(179, 34);
            btnSetup.TabIndex = 3;
            btnSetup.Text = "              Setup";
            btnSetup.TextAlign = ContentAlignment.MiddleLeft;
            btnSetup.UseVisualStyleBackColor = false;
            btnSetup.Click += btnSetup_Click;
            // 
            // panel14
            // 
            panel14.Controls.Add(btnOfficeHourAndStaff);
            panel14.Location = new Point(0, 68);
            panel14.Margin = new Padding(0);
            panel14.Name = "panel14";
            panel14.Size = new Size(179, 34);
            panel14.TabIndex = 4;
            // 
            // btnOfficeHourAndStaff
            // 
            btnOfficeHourAndStaff.BackColor = Color.FromArgb(31, 97, 141);
            btnOfficeHourAndStaff.Dock = DockStyle.Fill;
            btnOfficeHourAndStaff.FlatAppearance.BorderColor = Color.FromArgb(31, 97, 141);
            btnOfficeHourAndStaff.FlatStyle = FlatStyle.Flat;
            btnOfficeHourAndStaff.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOfficeHourAndStaff.ForeColor = SystemColors.ButtonFace;
            btnOfficeHourAndStaff.Image = (Image)resources.GetObject("btnOfficeHourAndStaff.Image");
            btnOfficeHourAndStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnOfficeHourAndStaff.Location = new Point(0, 0);
            btnOfficeHourAndStaff.Margin = new Padding(0);
            btnOfficeHourAndStaff.Name = "btnOfficeHourAndStaff";
            btnOfficeHourAndStaff.Size = new Size(179, 34);
            btnOfficeHourAndStaff.TabIndex = 3;
            btnOfficeHourAndStaff.Text = "              Employee";
            btnOfficeHourAndStaff.TextAlign = ContentAlignment.MiddleLeft;
            btnOfficeHourAndStaff.UseVisualStyleBackColor = false;
            btnOfficeHourAndStaff.Click += btnOfficeHourAndStaff_Click;
            // 
            // panel15
            // 
            panel15.Controls.Add(btnCategory);
            panel15.Location = new Point(0, 34);
            panel15.Margin = new Padding(0);
            panel15.Name = "panel15";
            panel15.Size = new Size(179, 34);
            panel15.TabIndex = 4;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.FromArgb(31, 97, 141);
            btnCategory.Dock = DockStyle.Fill;
            btnCategory.FlatAppearance.BorderColor = Color.FromArgb(31, 97, 141);
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategory.ForeColor = SystemColors.ButtonFace;
            btnCategory.Image = (Image)resources.GetObject("btnCategory.Image");
            btnCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategory.Location = new Point(0, 0);
            btnCategory.Margin = new Padding(0);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(179, 34);
            btnCategory.TabIndex = 3;
            btnCategory.Text = "              Appointment";
            btnCategory.TextAlign = ContentAlignment.MiddleLeft;
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // panel16
            // 
            panel16.Controls.Add(btnOnlineBooking);
            panel16.Location = new Point(0, 102);
            panel16.Margin = new Padding(0);
            panel16.Name = "panel16";
            panel16.Size = new Size(179, 34);
            panel16.TabIndex = 5;
            // 
            // btnOnlineBooking
            // 
            btnOnlineBooking.BackColor = Color.FromArgb(31, 97, 141);
            btnOnlineBooking.Dock = DockStyle.Fill;
            btnOnlineBooking.FlatAppearance.BorderColor = Color.FromArgb(31, 97, 141);
            btnOnlineBooking.FlatStyle = FlatStyle.Flat;
            btnOnlineBooking.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOnlineBooking.ForeColor = SystemColors.ButtonFace;
            btnOnlineBooking.Image = (Image)resources.GetObject("btnOnlineBooking.Image");
            btnOnlineBooking.ImageAlign = ContentAlignment.MiddleLeft;
            btnOnlineBooking.Location = new Point(0, 0);
            btnOnlineBooking.Margin = new Padding(0);
            btnOnlineBooking.Name = "btnOnlineBooking";
            btnOnlineBooking.Size = new Size(179, 34);
            btnOnlineBooking.TabIndex = 3;
            btnOnlineBooking.Text = "              Online Booking";
            btnOnlineBooking.TextAlign = ContentAlignment.MiddleLeft;
            btnOnlineBooking.UseVisualStyleBackColor = false;
            btnOnlineBooking.Click += btnOnlineBooking_Click;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(31, 97, 141);
            menuContainer.Controls.Add(panel9);
            menuContainer.Controls.Add(panel6);
            menuContainer.Controls.Add(panel10);
            menuContainer.Controls.Add(panel8);
            menuContainer.Location = new Point(0, 170);
            menuContainer.Margin = new Padding(0);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(179, 34);
            menuContainer.TabIndex = 8;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnMenu);
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(179, 34);
            panel9.TabIndex = 3;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(41, 128, 185);
            btnMenu.Dock = DockStyle.Fill;
            btnMenu.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = SystemColors.ButtonFace;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(179, 34);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "              Account";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnAbout);
            panel6.Location = new Point(0, 34);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(179, 34);
            panel6.TabIndex = 4;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.FromArgb(31, 97, 141);
            btnAbout.Dock = DockStyle.Fill;
            btnAbout.FlatAppearance.BorderColor = Color.FromArgb(31, 97, 141);
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbout.ForeColor = SystemColors.ButtonFace;
            btnAbout.Image = (Image)resources.GetObject("btnAbout.Image");
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(0, 0);
            btnAbout.Margin = new Padding(0);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(179, 34);
            btnAbout.TabIndex = 3;
            btnAbout.Text = "              About";
            btnAbout.TextAlign = ContentAlignment.MiddleLeft;
            btnAbout.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnSetting);
            panel10.Location = new Point(0, 68);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(179, 34);
            panel10.TabIndex = 4;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.FromArgb(31, 97, 141);
            btnSetting.Dock = DockStyle.Fill;
            btnSetting.FlatAppearance.BorderColor = Color.FromArgb(31, 97, 141);
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetting.ForeColor = SystemColors.ButtonFace;
            btnSetting.Image = (Image)resources.GetObject("btnSetting.Image");
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 0);
            btnSetting.Margin = new Padding(0);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(179, 34);
            btnSetting.TabIndex = 3;
            btnSetting.Text = "              Settings";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnLogout);
            panel8.Location = new Point(0, 102);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(179, 34);
            panel8.TabIndex = 4;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(31, 97, 141);
            btnLogout.Dock = DockStyle.Fill;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(31, 97, 141);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = SystemColors.ButtonFace;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 0);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(179, 34);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "              Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.Control;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(179, 30);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(15, 0, 15, 0);
            mainPanel.Size = new Size(1101, 660);
            mainPanel.TabIndex = 3;
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
            // adminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 690);
            Controls.Add(mainPanel);
            Controls.Add(sidebarContainer);
            Controls.Add(panel1);
            Name = "adminPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += adminPage_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSidebar).EndInit();
            sidebarContainer.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel5.ResumeLayout(false);
            setupContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel16.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnSidebar;
        private FlowLayoutPanel sidebarContainer;
        private Panel panel2;
        private Button btnDashboard;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel7;
        private Button button6;
        private Panel panel5;
        private Button btnUsers;
        private Panel panel3;
        private Button btnSetup;
        private Panel panel11;
        private Button btnDoctors;
        private Panel panel4;
        private Button btnEmployee;
        private FlowLayoutPanel menuContainer;
        private Panel panel9;
        private Button btnMenu;
        private Panel panel6;
        private Button btnAbout;
        private Panel panel10;
        private Button btnSetting;
        private Panel panel8;
        private Button btnLogout;
        private Panel mainPanel;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panel14;
        private Button btnOfficeHourAndStaff;
        private FlowLayoutPanel setupContainer;
        private Panel panel15;
        private Button btnCategory;
        private Panel panel16;
        private Button btnOnlineBooking;
        private System.Windows.Forms.Timer setupTransition;
    }
}