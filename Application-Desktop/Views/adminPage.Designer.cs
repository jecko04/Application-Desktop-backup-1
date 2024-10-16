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
            mainPanel = new Panel();
            MyNavigationPanel = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            patientRecordPanel = new Panel();
            tabPage3 = new TabPage();
            servicesPanel = new Panel();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            accountPanel = new Panel();
            imageList1 = new ImageList(components);
            appointmentPanel = new Panel();
            MyNavigationPanel.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Transparent;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(3, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(15, 0, 15, 0);
            mainPanel.Size = new Size(1260, 582);
            mainPanel.TabIndex = 3;
            // 
            // MyNavigationPanel
            // 
            MyNavigationPanel.Controls.Add(tabPage1);
            MyNavigationPanel.Controls.Add(tabPage2);
            MyNavigationPanel.Controls.Add(tabPage3);
            MyNavigationPanel.Controls.Add(tabPage4);
            MyNavigationPanel.Controls.Add(tabPage5);
            MyNavigationPanel.Depth = 0;
            MyNavigationPanel.Dock = DockStyle.Fill;
            MyNavigationPanel.ImageList = imageList1;
            MyNavigationPanel.Location = new Point(3, 64);
            MyNavigationPanel.MouseState = MaterialSkin.MouseState.HOVER;
            MyNavigationPanel.Multiline = true;
            MyNavigationPanel.Name = "MyNavigationPanel";
            MyNavigationPanel.SelectedIndex = 0;
            MyNavigationPanel.Size = new Size(1274, 623);
            MyNavigationPanel.TabIndex = 0;
            MyNavigationPanel.SelectedIndexChanged += MyNavigationPanel_SelectedIndexChanged;
            MyNavigationPanel.Selecting += MyNavigationPanel_Selecting;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(mainPanel);
            tabPage1.ImageKey = "apps (2).png";
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1266, 588);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dashboard";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(patientRecordPanel);
            tabPage2.ImageKey = "list.png";
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1266, 588);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Patient Record";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // patientRecordPanel
            // 
            patientRecordPanel.Dock = DockStyle.Fill;
            patientRecordPanel.Location = new Point(3, 3);
            patientRecordPanel.Name = "patientRecordPanel";
            patientRecordPanel.Size = new Size(1260, 582);
            patientRecordPanel.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(servicesPanel);
            tabPage3.ImageKey = "appointment-book (5).png";
            tabPage3.Location = new Point(4, 31);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1266, 588);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Setup Services";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // servicesPanel
            // 
            servicesPanel.Dock = DockStyle.Fill;
            servicesPanel.Location = new Point(0, 0);
            servicesPanel.Name = "servicesPanel";
            servicesPanel.Size = new Size(1266, 588);
            servicesPanel.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(appointmentPanel);
            tabPage4.ImageKey = "check-in-calendar.png";
            tabPage4.Location = new Point(4, 31);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1266, 588);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Appointment";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(accountPanel);
            tabPage5.ImageKey = "account-pin-box-line (3).png";
            tabPage5.Location = new Point(4, 31);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1266, 588);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Account";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // accountPanel
            // 
            accountPanel.Dock = DockStyle.Fill;
            accountPanel.Location = new Point(0, 0);
            accountPanel.Name = "accountPanel";
            accountPanel.Size = new Size(1266, 588);
            accountPanel.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "list.png");
            imageList1.Images.SetKeyName(1, "apps (2).png");
            imageList1.Images.SetKeyName(2, "appointment-book (5).png");
            imageList1.Images.SetKeyName(3, "account-pin-box-line (3).png");
            imageList1.Images.SetKeyName(4, "check-in-calendar.png");
            // 
            // appointmentPanel
            // 
            appointmentPanel.Dock = DockStyle.Fill;
            appointmentPanel.Location = new Point(0, 0);
            appointmentPanel.Name = "appointmentPanel";
            appointmentPanel.Size = new Size(1266, 588);
            appointmentPanel.TabIndex = 0;
            // 
            // adminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 690);
            Controls.Add(MyNavigationPanel);
            DrawerTabControl = MyNavigationPanel;
            Name = "adminPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += adminPage_Load;
            MyNavigationPanel.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel mainPanel;
        private MaterialSkin.Controls.MaterialTabControl Control;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private MaterialSkin.Controls.MaterialTabControl MyNavigationPanel;
        private Panel servicesPanel;
        private Panel patientRecordPanel;
        private Panel accountPanel;
        private Panel appointmentPanel;
    }
}