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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            MyNavigationPanel = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            btnUpdateRefesher = new MaterialSkin.Controls.MaterialButton();
            calendarPanel = new Panel();
            panel6 = new Panel();
            lblDate = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            dayContainer = new FlowLayoutPanel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            viewPending = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            txtPending = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            txtApproved = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            txtCancel = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            panel4 = new Panel();
            txtCompleted = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            panel5 = new Panel();
            txtDentalPatient = new Label();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            label3 = new Label();
            tabPage2 = new TabPage();
            patientRecordPanel = new Panel();
            tabPage3 = new TabPage();
            servicesPanel = new Panel();
            tabPage4 = new TabPage();
            appointmentPanel = new Panel();
            tabPage5 = new TabPage();
            accountPanel = new Panel();
            imageList1 = new ImageList(components);
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            MyNavigationPanel.SuspendLayout();
            tabPage1.SuspendLayout();
            calendarPanel.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewPending).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
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
            tabPage1.Controls.Add(btnUpdateRefesher);
            tabPage1.Controls.Add(calendarPanel);
            tabPage1.Controls.Add(viewPending);
            tabPage1.Controls.Add(flowLayoutPanel1);
            tabPage1.Controls.Add(label3);
            tabPage1.ImageKey = "apps (2).png";
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1266, 588);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dashboard";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnUpdateRefesher
            // 
            btnUpdateRefesher.AutoSize = false;
            btnUpdateRefesher.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateRefesher.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateRefesher.Depth = 0;
            btnUpdateRefesher.HighEmphasis = true;
            btnUpdateRefesher.Icon = (Image)resources.GetObject("btnUpdateRefesher.Icon");
            btnUpdateRefesher.Location = new Point(1185, 9);
            btnUpdateRefesher.Margin = new Padding(4, 6, 4, 6);
            btnUpdateRefesher.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateRefesher.Name = "btnUpdateRefesher";
            btnUpdateRefesher.NoAccentTextColor = Color.Empty;
            btnUpdateRefesher.Size = new Size(40, 36);
            btnUpdateRefesher.TabIndex = 109;
            btnUpdateRefesher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateRefesher.UseAccentColor = false;
            btnUpdateRefesher.UseVisualStyleBackColor = true;
            btnUpdateRefesher.Click += btnUpdateRefesher_Click;
            // 
            // calendarPanel
            // 
            calendarPanel.Controls.Add(panel6);
            calendarPanel.Controls.Add(btnPrev);
            calendarPanel.Controls.Add(btnNext);
            calendarPanel.Controls.Add(dayContainer);
            calendarPanel.Controls.Add(label13);
            calendarPanel.Controls.Add(label12);
            calendarPanel.Controls.Add(label11);
            calendarPanel.Controls.Add(label10);
            calendarPanel.Controls.Add(label9);
            calendarPanel.Controls.Add(label8);
            calendarPanel.Controls.Add(label7);
            calendarPanel.Location = new Point(874, 250);
            calendarPanel.Name = "calendarPanel";
            calendarPanel.Size = new Size(357, 298);
            calendarPanel.TabIndex = 24;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(250, 220, 18);
            panel6.Controls.Add(lblDate);
            panel6.Location = new Point(4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(350, 30);
            panel6.TabIndex = 27;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(27, 5);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(290, 21);
            lblDate.TabIndex = 12;
            lblDate.Text = "MONTH YEAR";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrev.BackColor = Color.FromArgb(255, 66, 0);
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.ForeColor = SystemColors.ControlLight;
            btnPrev.Location = new Point(4, 272);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(75, 23);
            btnPrev.TabIndex = 26;
            btnPrev.Text = "Previous";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNext.BackColor = Color.FromArgb(255, 66, 0);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ForeColor = SystemColors.ControlLight;
            btnNext.Location = new Point(276, 272);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 25;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // dayContainer
            // 
            dayContainer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dayContainer.Location = new Point(3, 52);
            dayContainer.Name = "dayContainer";
            dayContainer.Size = new Size(351, 214);
            dayContainer.TabIndex = 11;
            dayContainer.Paint += dayContainer_Paint;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(309, 36);
            label13.Name = "label13";
            label13.Size = new Size(23, 13);
            label13.TabIndex = 10;
            label13.Text = "Sat";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(265, 36);
            label12.Name = "label12";
            label12.Size = new Size(20, 13);
            label12.TabIndex = 9;
            label12.Text = "Fri";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(210, 36);
            label11.Name = "label11";
            label11.Size = new Size(26, 13);
            label11.TabIndex = 8;
            label11.Text = "Thu";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(160, 36);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(31, 13);
            label10.TabIndex = 7;
            label10.Text = "Wed";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(114, 36);
            label9.Name = "label9";
            label9.Size = new Size(24, 13);
            label9.TabIndex = 6;
            label9.Text = "Tue";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(62, 36);
            label8.Name = "label8";
            label8.Size = new Size(31, 13);
            label8.TabIndex = 5;
            label8.Text = "Mon";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 36);
            label7.Name = "label7";
            label7.Size = new Size(27, 13);
            label7.TabIndex = 4;
            label7.Text = "Sun";
            // 
            // viewPending
            // 
            viewPending.AllowUserToAddRows = false;
            viewPending.AllowUserToDeleteRows = false;
            viewPending.AllowUserToResizeColumns = false;
            viewPending.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightYellow;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            viewPending.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            viewPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewPending.BackgroundColor = Color.White;
            viewPending.BorderStyle = BorderStyle.None;
            viewPending.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewPending.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.NullValue = "N/A";
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            viewPending.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            viewPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "N/A";
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            viewPending.DefaultCellStyle = dataGridViewCellStyle3;
            viewPending.EnableHeadersVisualStyles = false;
            viewPending.GridColor = Color.White;
            viewPending.Location = new Point(38, 255);
            viewPending.Margin = new Padding(0);
            viewPending.Name = "viewPending";
            viewPending.ReadOnly = true;
            viewPending.RowTemplate.Height = 25;
            viewPending.Size = new Size(833, 293);
            viewPending.TabIndex = 23;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Location = new Point(38, 94);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1193, 158);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(41, 56, 218);
            panel1.Controls.Add(txtPending);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 120);
            panel1.TabIndex = 0;
            // 
            // txtPending
            // 
            txtPending.AutoSize = true;
            txtPending.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPending.ForeColor = Color.White;
            txtPending.Location = new Point(21, 64);
            txtPending.Name = "txtPending";
            txtPending.Size = new Size(71, 30);
            txtPending.TabIndex = 2;
            txtPending.Text = "Count";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(165, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 28);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 0;
            label1.Text = "Pending";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(255, 66, 0);
            panel2.Controls.Add(txtApproved);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(241, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 120);
            panel2.TabIndex = 1;
            // 
            // txtApproved
            // 
            txtApproved.AutoSize = true;
            txtApproved.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtApproved.ForeColor = Color.White;
            txtApproved.Location = new Point(24, 64);
            txtApproved.Name = "txtApproved";
            txtApproved.Size = new Size(71, 30);
            txtApproved.TabIndex = 3;
            txtApproved.Text = "Count";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(164, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 50);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 28);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 1;
            label2.Text = "Approved";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(250, 220, 18);
            panel3.Controls.Add(txtCancel);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(479, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(232, 120);
            panel3.TabIndex = 2;
            // 
            // txtCancel
            // 
            txtCancel.AutoSize = true;
            txtCancel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCancel.ForeColor = Color.White;
            txtCancel.Location = new Point(24, 64);
            txtCancel.Name = "txtCancel";
            txtCancel.Size = new Size(71, 30);
            txtCancel.TabIndex = 4;
            txtCancel.Text = "Count";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(164, 54);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 50);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 28);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 1;
            label4.Text = "Cancelled";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(255, 66, 0);
            panel4.Controls.Add(txtCompleted);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(717, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(232, 120);
            panel4.TabIndex = 3;
            // 
            // txtCompleted
            // 
            txtCompleted.AutoSize = true;
            txtCompleted.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCompleted.ForeColor = Color.White;
            txtCompleted.Location = new Point(24, 64);
            txtCompleted.Name = "txtCompleted";
            txtCompleted.Size = new Size(71, 30);
            txtCompleted.TabIndex = 5;
            txtCompleted.Text = "Count";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(170, 54);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 50);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 28);
            label5.Name = "label5";
            label5.Size = new Size(92, 21);
            label5.TabIndex = 1;
            label5.Text = "Completed";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(41, 56, 218);
            panel5.Controls.Add(txtDentalPatient);
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(955, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(232, 120);
            panel5.TabIndex = 5;
            // 
            // txtDentalPatient
            // 
            txtDentalPatient.AutoSize = true;
            txtDentalPatient.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDentalPatient.ForeColor = Color.White;
            txtDentalPatient.Location = new Point(24, 64);
            txtDentalPatient.Name = "txtDentalPatient";
            txtDentalPatient.Size = new Size(71, 30);
            txtDentalPatient.TabIndex = 6;
            txtDentalPatient.Text = "Count";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(168, 54);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(80, 50);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(24, 28);
            label6.Name = "label6";
            label6.Size = new Size(112, 21);
            label6.TabIndex = 1;
            label6.Text = "Dental Patient";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(38, 15);
            label3.Name = "label3";
            label3.Size = new Size(118, 30);
            label3.TabIndex = 2;
            label3.Text = "Dashboard";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(patientRecordPanel);
            tabPage2.ImageKey = "list.png";
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1266, 628);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Patient Record";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // patientRecordPanel
            // 
            patientRecordPanel.Dock = DockStyle.Fill;
            patientRecordPanel.Location = new Point(3, 3);
            patientRecordPanel.Name = "patientRecordPanel";
            patientRecordPanel.Size = new Size(1260, 622);
            patientRecordPanel.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(servicesPanel);
            tabPage3.ImageKey = "appointment-book (5).png";
            tabPage3.Location = new Point(4, 31);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1266, 628);
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
            servicesPanel.Size = new Size(1266, 628);
            servicesPanel.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(appointmentPanel);
            tabPage4.ImageKey = "check-in-calendar.png";
            tabPage4.Location = new Point(4, 31);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1266, 628);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Appointment";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // appointmentPanel
            // 
            appointmentPanel.Dock = DockStyle.Fill;
            appointmentPanel.Location = new Point(0, 0);
            appointmentPanel.Name = "appointmentPanel";
            appointmentPanel.Size = new Size(1266, 628);
            appointmentPanel.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(accountPanel);
            tabPage5.ImageKey = "account-pin-box-line (3).png";
            tabPage5.Location = new Point(4, 31);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1266, 628);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Account";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // accountPanel
            // 
            accountPanel.Dock = DockStyle.Fill;
            accountPanel.Location = new Point(0, 0);
            accountPanel.Name = "accountPanel";
            accountPanel.Size = new Size(1266, 628);
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
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = viewPending;
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
            Text = "SMTC Dental Care";
            Load += adminPage_Load;
            MyNavigationPanel.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            calendarPanel.ResumeLayout(false);
            calendarPanel.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewPending).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
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
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Label label4;
        private Panel panel4;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label txtPending;
        private Label txtApproved;
        private Label txtCancel;
        private Label txtCompleted;
        private Label txtDentalPatient;
        private DataGridView viewPending;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private Panel calendarPanel;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private FlowLayoutPanel dayContainer;
        private Label lblDate;
        private Button btnPrev;
        private Button btnNext;
        private Panel panel6;
        private MaterialSkin.Controls.MaterialButton btnUpdateRefesher;
    }
}