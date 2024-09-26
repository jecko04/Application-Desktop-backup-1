namespace Application_Desktop.Views
{
    partial class superAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(superAdmin));
            sidebarContainer = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            btnBranches = new Button();
            panel2 = new Panel();
            btnRole = new Button();
            panel7 = new Panel();
            btnUsers = new Button();
            menuContainer = new FlowLayoutPanel();
            panel9 = new Panel();
            btnMenu = new Button();
            panel10 = new Panel();
            btnProfile = new Button();
            panel8 = new Panel();
            btnLogout = new Button();
            panel4 = new Panel();
            btnDentalDoctors = new Button();
            panel3 = new Panel();
            btnAdmin = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            mainPanel = new Panel();
            sidebarContainer.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            menuContainer.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarContainer
            // 
            sidebarContainer.BackColor = Color.FromArgb(250, 220, 18);
            sidebarContainer.Controls.Add(panel1);
            sidebarContainer.Controls.Add(panel5);
            sidebarContainer.Controls.Add(panel2);
            sidebarContainer.Controls.Add(panel7);
            sidebarContainer.Controls.Add(panel4);
            sidebarContainer.Controls.Add(panel3);
            sidebarContainer.Controls.Add(menuContainer);
            sidebarContainer.Dock = DockStyle.Left;
            sidebarContainer.Location = new Point(0, 0);
            sidebarContainer.Margin = new Padding(0);
            sidebarContainer.Name = "sidebarContainer";
            sidebarContainer.Size = new Size(179, 690);
            sidebarContainer.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 116);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(9, 33);
            label1.Name = "label1";
            label1.Size = new Size(160, 45);
            label1.TabIndex = 0;
            label1.Text = "ORALease: Online \r\nAppointment Reservation for\r\nLocal Dental Services";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(250, 220, 18);
            panel5.Controls.Add(btnBranches);
            panel5.Location = new Point(0, 122);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(179, 34);
            panel5.TabIndex = 4;
            // 
            // btnBranches
            // 
            btnBranches.BackColor = Color.FromArgb(250, 220, 18);
            btnBranches.Dock = DockStyle.Fill;
            btnBranches.FlatAppearance.BorderColor = Color.FromArgb(250, 220, 18);
            btnBranches.FlatStyle = FlatStyle.Flat;
            btnBranches.Font = new Font("Microsoft Sans Serif", 9F);
            btnBranches.ForeColor = Color.Black;
            btnBranches.Image = (Image)resources.GetObject("btnBranches.Image");
            btnBranches.ImageAlign = ContentAlignment.MiddleLeft;
            btnBranches.Location = new Point(0, 0);
            btnBranches.Margin = new Padding(0);
            btnBranches.Name = "btnBranches";
            btnBranches.Size = new Size(179, 34);
            btnBranches.TabIndex = 3;
            btnBranches.Text = "              Branches";
            btnBranches.TextAlign = ContentAlignment.MiddleLeft;
            btnBranches.UseVisualStyleBackColor = false;
            btnBranches.Click += btnBranches_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(250, 220, 18);
            panel2.Controls.Add(btnRole);
            panel2.Location = new Point(0, 156);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(179, 34);
            panel2.TabIndex = 4;
            // 
            // btnRole
            // 
            btnRole.BackColor = Color.FromArgb(250, 220, 18);
            btnRole.Dock = DockStyle.Fill;
            btnRole.FlatAppearance.BorderColor = Color.FromArgb(250, 220, 18);
            btnRole.FlatStyle = FlatStyle.Flat;
            btnRole.Font = new Font("Microsoft Sans Serif", 9F);
            btnRole.ForeColor = Color.Black;
            btnRole.Image = (Image)resources.GetObject("btnRole.Image");
            btnRole.ImageAlign = ContentAlignment.MiddleLeft;
            btnRole.Location = new Point(0, 0);
            btnRole.Margin = new Padding(0);
            btnRole.Name = "btnRole";
            btnRole.Size = new Size(179, 34);
            btnRole.TabIndex = 3;
            btnRole.Text = "              Role";
            btnRole.TextAlign = ContentAlignment.MiddleLeft;
            btnRole.UseVisualStyleBackColor = false;
            btnRole.Click += btnRole_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(250, 220, 18);
            panel7.Controls.Add(btnUsers);
            panel7.Location = new Point(0, 190);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(179, 34);
            panel7.TabIndex = 4;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(250, 220, 18);
            btnUsers.Dock = DockStyle.Fill;
            btnUsers.FlatAppearance.BorderColor = Color.FromArgb(250, 220, 18);
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Microsoft Sans Serif", 9F);
            btnUsers.ForeColor = Color.Black;
            btnUsers.Image = (Image)resources.GetObject("btnUsers.Image");
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(0, 0);
            btnUsers.Margin = new Padding(0);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(179, 34);
            btnUsers.TabIndex = 3;
            btnUsers.Text = "              User";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(250, 220, 18);
            menuContainer.Controls.Add(panel9);
            menuContainer.Controls.Add(panel10);
            menuContainer.Controls.Add(panel8);
            menuContainer.Location = new Point(0, 292);
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
            btnMenu.Size = new Size(179, 34);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "              Account";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnProfile);
            panel10.Location = new Point(2, 34);
            panel10.Margin = new Padding(2, 0, 0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(177, 34);
            panel10.TabIndex = 4;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(250, 220, 18);
            btnProfile.Dock = DockStyle.Fill;
            btnProfile.FlatAppearance.BorderColor = Color.FromArgb(250, 220, 18);
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Microsoft Sans Serif", 9F);
            btnProfile.ForeColor = Color.Black;
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(0, 0);
            btnProfile.Margin = new Padding(0);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(177, 34);
            btnProfile.TabIndex = 3;
            btnProfile.Text = "              Settings";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnLogout);
            panel8.Location = new Point(0, 68);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(179, 34);
            panel8.TabIndex = 4;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(250, 220, 18);
            btnLogout.Dock = DockStyle.Fill;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(250, 220, 18);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 9F);
            btnLogout.ForeColor = Color.Black;
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(250, 220, 18);
            panel4.Controls.Add(btnDentalDoctors);
            panel4.Location = new Point(0, 224);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(179, 34);
            panel4.TabIndex = 4;
            // 
            // btnDentalDoctors
            // 
            btnDentalDoctors.BackColor = Color.FromArgb(250, 220, 18);
            btnDentalDoctors.Dock = DockStyle.Fill;
            btnDentalDoctors.FlatAppearance.BorderColor = Color.FromArgb(250, 220, 18);
            btnDentalDoctors.FlatStyle = FlatStyle.Flat;
            btnDentalDoctors.Font = new Font("Microsoft Sans Serif", 9F);
            btnDentalDoctors.ForeColor = Color.Black;
            btnDentalDoctors.Image = (Image)resources.GetObject("btnDentalDoctors.Image");
            btnDentalDoctors.ImageAlign = ContentAlignment.MiddleLeft;
            btnDentalDoctors.Location = new Point(0, 0);
            btnDentalDoctors.Margin = new Padding(0);
            btnDentalDoctors.Name = "btnDentalDoctors";
            btnDentalDoctors.Size = new Size(179, 34);
            btnDentalDoctors.TabIndex = 3;
            btnDentalDoctors.Text = "              Dental Doctor\r\n";
            btnDentalDoctors.TextAlign = ContentAlignment.MiddleLeft;
            btnDentalDoctors.UseVisualStyleBackColor = false;
            btnDentalDoctors.Click += btnDentalDoctors_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(250, 220, 18);
            panel3.Controls.Add(btnAdmin);
            panel3.Location = new Point(0, 258);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(179, 34);
            panel3.TabIndex = 3;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(250, 220, 18);
            btnAdmin.Dock = DockStyle.Fill;
            btnAdmin.FlatAppearance.BorderColor = Color.FromArgb(250, 220, 18);
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Microsoft Sans Serif", 9F);
            btnAdmin.ForeColor = Color.Black;
            btnAdmin.Image = (Image)resources.GetObject("btnAdmin.Image");
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(0, 0);
            btnAdmin.Margin = new Padding(0);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(179, 34);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "              Administrator\r\n";
            btnAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.Control;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(179, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(15, 0, 15, 0);
            mainPanel.Size = new Size(1101, 690);
            mainPanel.TabIndex = 2;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // superAdmin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1280, 690);
            Controls.Add(mainPanel);
            Controls.Add(sidebarContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "superAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Super Admin";
            Load += superAdmin_Load;
            sidebarContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel sidebarContainer;
        private Panel panel3;
        private Button btnAdmin;
        private FlowLayoutPanel menuContainer;
        private Panel panel9;
        private Button btnMenu;
        private Panel panel8;
        private Button btnLogout;
        private Panel panel10;
        private Button btnProfile;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel mainPanel;
        private Panel panel5;
        private Button btnBranches;
        private Panel panel2;
        private Button btnRole;
        private Panel panel4;
        private Button btnDentalDoctors;
        private Panel panel7;
        private Button btnUsers;
        private Panel panel1;
        private Label label1;
    }
}