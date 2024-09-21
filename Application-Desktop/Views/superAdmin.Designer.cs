﻿namespace Application_Desktop.Views
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
            panel1 = new Panel();
            label1 = new Label();
            btnSidebar = new PictureBox();
            sidebarContainer = new FlowLayoutPanel();
            panel5 = new Panel();
            btnBranches = new Button();
            panel3 = new Panel();
            btnAdmin = new Button();
            panel2 = new Panel();
            btnRole = new Button();
            menuContainer = new FlowLayoutPanel();
            panel9 = new Panel();
            btnMenu = new Button();
            panel6 = new Panel();
            button5 = new Button();
            panel10 = new Panel();
            btnProfile = new Button();
            panel8 = new Panel();
            btnLogout = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            mainPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSidebar).BeginInit();
            sidebarContainer.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            menuContainer.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSidebar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 30);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 16);
            label1.TabIndex = 2;
            label1.Text = "DENTAL CLINIC NAME";
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
            btnSidebar.TabIndex = 1;
            btnSidebar.TabStop = false;
            btnSidebar.Click += btnSidebar_Click;
            // 
            // sidebarContainer
            // 
            sidebarContainer.BackColor = Color.FromArgb(41, 128, 185);
            sidebarContainer.Controls.Add(panel5);
            sidebarContainer.Controls.Add(panel3);
            sidebarContainer.Controls.Add(panel2);
            sidebarContainer.Controls.Add(menuContainer);
            sidebarContainer.Dock = DockStyle.Left;
            sidebarContainer.Location = new Point(0, 30);
            sidebarContainer.Margin = new Padding(0);
            sidebarContainer.Name = "sidebarContainer";
            sidebarContainer.Size = new Size(179, 660);
            sidebarContainer.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnBranches);
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(179, 34);
            panel5.TabIndex = 4;
            // 
            // btnBranches
            // 
            btnBranches.BackColor = Color.FromArgb(41, 128, 185);
            btnBranches.Dock = DockStyle.Fill;
            btnBranches.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnBranches.FlatStyle = FlatStyle.Flat;
            btnBranches.Font = new Font("Microsoft Sans Serif", 9F);
            btnBranches.ForeColor = SystemColors.ButtonFace;
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
            // panel3
            // 
            panel3.Controls.Add(btnAdmin);
            panel3.Location = new Point(0, 34);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(179, 34);
            panel3.TabIndex = 3;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(41, 128, 185);
            btnAdmin.Dock = DockStyle.Fill;
            btnAdmin.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Microsoft Sans Serif", 9F);
            btnAdmin.ForeColor = SystemColors.ButtonFace;
            btnAdmin.Image = (Image)resources.GetObject("btnAdmin.Image");
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(0, 0);
            btnAdmin.Margin = new Padding(0);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(179, 34);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "              SuperAdmin/Admin";
            btnAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnRole);
            panel2.Location = new Point(0, 68);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(179, 34);
            panel2.TabIndex = 4;
            // 
            // btnRole
            // 
            btnRole.BackColor = Color.FromArgb(41, 128, 185);
            btnRole.Dock = DockStyle.Fill;
            btnRole.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnRole.FlatStyle = FlatStyle.Flat;
            btnRole.Font = new Font("Microsoft Sans Serif", 9F);
            btnRole.ForeColor = SystemColors.ButtonFace;
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
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(31, 97, 141);
            menuContainer.Controls.Add(panel9);
            menuContainer.Controls.Add(panel6);
            menuContainer.Controls.Add(panel10);
            menuContainer.Controls.Add(panel8);
            menuContainer.Location = new Point(0, 102);
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
            btnMenu.Font = new Font("Microsoft Sans Serif", 9F);
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
            panel6.Controls.Add(button5);
            panel6.Location = new Point(0, 34);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(179, 34);
            panel6.TabIndex = 4;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(31, 97, 141);
            button5.Dock = DockStyle.Fill;
            button5.FlatAppearance.BorderColor = Color.FromArgb(31, 97, 141);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 9F);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 0);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(179, 34);
            button5.TabIndex = 3;
            button5.Text = "              About";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnProfile);
            panel10.Location = new Point(0, 68);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(179, 34);
            panel10.TabIndex = 4;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(31, 97, 141);
            btnProfile.Dock = DockStyle.Fill;
            btnProfile.FlatAppearance.BorderColor = Color.FromArgb(31, 97, 141);
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Microsoft Sans Serif", 9F);
            btnProfile.ForeColor = SystemColors.ButtonFace;
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(0, 0);
            btnProfile.Margin = new Padding(0);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(179, 34);
            btnProfile.TabIndex = 3;
            btnProfile.Text = "              Settings";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
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
            btnLogout.Font = new Font("Microsoft Sans Serif", 9F);
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
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.Control;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(179, 30);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(15, 0, 15, 0);
            mainPanel.Size = new Size(1101, 660);
            mainPanel.TabIndex = 2;
            // 
            // superAdmin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1280, 690);
            Controls.Add(mainPanel);
            Controls.Add(sidebarContainer);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "superAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Super Admin";
            Load += superAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSidebar).EndInit();
            sidebarContainer.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox btnSidebar;
        private FlowLayoutPanel sidebarContainer;
        private Panel panel3;
        private Button btnAdmin;
        private FlowLayoutPanel menuContainer;
        private Panel panel9;
        private Button btnMenu;
        private Panel panel6;
        private Button button5;
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
    }
}