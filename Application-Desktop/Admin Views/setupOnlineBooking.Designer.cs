namespace Application_Desktop.Admin_Views
{
    partial class setupOnlineBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setupOnlineBooking));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label40 = new Label();
            pictureBox1 = new PictureBox();
            viewDentalServices = new DataGridView();
            borderFetchTitle = new Panel();
            panel35 = new Panel();
            panel36 = new Panel();
            panel37 = new Panel();
            panel38 = new Panel();
            txtFetchTitle = new ComboBox();
            label8 = new Label();
            label1 = new Label();
            borderStartTime = new Panel();
            button3 = new Button();
            panel44 = new Panel();
            panel49 = new Panel();
            panel50 = new Panel();
            panel51 = new Panel();
            dtpStartTime = new DateTimePicker();
            borderEndtime = new Panel();
            button2 = new Button();
            panel19 = new Panel();
            panel24 = new Panel();
            panel29 = new Panel();
            panel34 = new Panel();
            dtpEndtime = new DateTimePicker();
            label18 = new Label();
            label17 = new Label();
            borderBranch = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            txtFetchBranch = new ComboBox();
            label2 = new Label();
            btnNewAccount = new Button();
            btnRefresh = new Button();
            btnView = new Button();
            panel2 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            comboBox1 = new ComboBox();
            label3 = new Label();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            comboBox2 = new ComboBox();
            borderTitle = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            panel18 = new Panel();
            panel20 = new Panel();
            txtTitle = new TextBox();
            label4 = new Label();
            panel21 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewDentalServices).BeginInit();
            borderFetchTitle.SuspendLayout();
            borderStartTime.SuspendLayout();
            borderEndtime.SuspendLayout();
            borderBranch.SuspendLayout();
            panel2.SuspendLayout();
            panel11.SuspendLayout();
            borderTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label40);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1106, 30);
            panel1.TabIndex = 0;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label40.Location = new Point(33, 7);
            label40.Name = "label40";
            label40.Size = new Size(165, 16);
            label40.TabIndex = 90;
            label40.Text = "Setup  >  Online Booking";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 89;
            pictureBox1.TabStop = false;
            // 
            // viewDentalServices
            // 
            viewDentalServices.AllowUserToAddRows = false;
            viewDentalServices.AllowUserToDeleteRows = false;
            viewDentalServices.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewDentalServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewDentalServices.BackgroundColor = Color.White;
            viewDentalServices.BorderStyle = BorderStyle.None;
            viewDentalServices.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewDentalServices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            viewDentalServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            viewDentalServices.DefaultCellStyle = dataGridViewCellStyle2;
            viewDentalServices.Location = new Point(13, 144);
            viewDentalServices.Margin = new Padding(0, 0, 10, 0);
            viewDentalServices.Name = "viewDentalServices";
            viewDentalServices.ReadOnly = true;
            viewDentalServices.RowTemplate.Height = 25;
            viewDentalServices.Size = new Size(951, 279);
            viewDentalServices.TabIndex = 2;
            viewDentalServices.CellContentClick += view_CellContentClick;
            // 
            // borderFetchTitle
            // 
            borderFetchTitle.Controls.Add(panel35);
            borderFetchTitle.Controls.Add(panel36);
            borderFetchTitle.Controls.Add(panel37);
            borderFetchTitle.Controls.Add(panel38);
            borderFetchTitle.Controls.Add(txtFetchTitle);
            borderFetchTitle.Location = new Point(13, 74);
            borderFetchTitle.Name = "borderFetchTitle";
            borderFetchTitle.Size = new Size(213, 24);
            borderFetchTitle.TabIndex = 80;
            // 
            // panel35
            // 
            panel35.BackColor = Color.FromArgb(93, 173, 226);
            panel35.Dock = DockStyle.Right;
            panel35.Location = new Point(212, 1);
            panel35.Name = "panel35";
            panel35.Size = new Size(1, 22);
            panel35.TabIndex = 3;
            // 
            // panel36
            // 
            panel36.BackColor = Color.FromArgb(93, 173, 226);
            panel36.Dock = DockStyle.Bottom;
            panel36.Location = new Point(1, 23);
            panel36.Name = "panel36";
            panel36.Size = new Size(212, 1);
            panel36.TabIndex = 2;
            // 
            // panel37
            // 
            panel37.BackColor = Color.FromArgb(93, 173, 226);
            panel37.Dock = DockStyle.Top;
            panel37.Location = new Point(1, 0);
            panel37.Name = "panel37";
            panel37.Size = new Size(212, 1);
            panel37.TabIndex = 1;
            // 
            // panel38
            // 
            panel38.BackColor = Color.FromArgb(93, 173, 226);
            panel38.Dock = DockStyle.Left;
            panel38.Location = new Point(0, 0);
            panel38.Name = "panel38";
            panel38.Size = new Size(1, 24);
            panel38.TabIndex = 0;
            // 
            // txtFetchTitle
            // 
            txtFetchTitle.BackColor = SystemColors.InactiveBorder;
            txtFetchTitle.Dock = DockStyle.Fill;
            txtFetchTitle.DropDownHeight = 75;
            txtFetchTitle.Font = new Font("Tahoma", 9.75F);
            txtFetchTitle.FormattingEnabled = true;
            txtFetchTitle.IntegralHeight = false;
            txtFetchTitle.ItemHeight = 16;
            txtFetchTitle.Location = new Point(0, 0);
            txtFetchTitle.Name = "txtFetchTitle";
            txtFetchTitle.Size = new Size(213, 24);
            txtFetchTitle.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(14, 55);
            label8.Name = "label8";
            label8.Size = new Size(77, 16);
            label8.TabIndex = 79;
            label8.Text = "Day of week";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(14, 124);
            label1.Name = "label1";
            label1.Size = new Size(95, 16);
            label1.TabIndex = 81;
            label1.Text = "Dental Services";
            // 
            // borderStartTime
            // 
            borderStartTime.Controls.Add(button3);
            borderStartTime.Controls.Add(panel44);
            borderStartTime.Controls.Add(panel49);
            borderStartTime.Controls.Add(panel50);
            borderStartTime.Controls.Add(panel51);
            borderStartTime.Controls.Add(dtpStartTime);
            borderStartTime.Font = new Font("Tahoma", 9.75F);
            borderStartTime.Location = new Point(250, 75);
            borderStartTime.Name = "borderStartTime";
            borderStartTime.Size = new Size(107, 23);
            borderStartTime.TabIndex = 85;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(102, 204, 102);
            button3.FlatAppearance.BorderColor = Color.FromArgb(102, 204, 102);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9F);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(315, 32);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(48, 25);
            button3.TabIndex = 59;
            button3.Text = "Apply";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel44
            // 
            panel44.BackColor = Color.FromArgb(93, 173, 226);
            panel44.Dock = DockStyle.Right;
            panel44.Location = new Point(106, 1);
            panel44.Name = "panel44";
            panel44.Size = new Size(1, 21);
            panel44.TabIndex = 3;
            // 
            // panel49
            // 
            panel49.BackColor = Color.FromArgb(93, 173, 226);
            panel49.Dock = DockStyle.Bottom;
            panel49.Location = new Point(1, 22);
            panel49.Name = "panel49";
            panel49.Size = new Size(106, 1);
            panel49.TabIndex = 2;
            // 
            // panel50
            // 
            panel50.BackColor = Color.FromArgb(93, 173, 226);
            panel50.Dock = DockStyle.Top;
            panel50.Location = new Point(1, 0);
            panel50.Name = "panel50";
            panel50.Size = new Size(106, 1);
            panel50.TabIndex = 1;
            // 
            // panel51
            // 
            panel51.BackColor = Color.FromArgb(93, 173, 226);
            panel51.Dock = DockStyle.Left;
            panel51.Location = new Point(0, 0);
            panel51.Name = "panel51";
            panel51.Size = new Size(1, 23);
            panel51.TabIndex = 0;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Dock = DockStyle.Fill;
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(0, 0);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(107, 23);
            dtpStartTime.TabIndex = 5;
            // 
            // borderEndtime
            // 
            borderEndtime.Controls.Add(button2);
            borderEndtime.Controls.Add(panel19);
            borderEndtime.Controls.Add(panel24);
            borderEndtime.Controls.Add(panel29);
            borderEndtime.Controls.Add(panel34);
            borderEndtime.Controls.Add(dtpEndtime);
            borderEndtime.Font = new Font("Tahoma", 9.75F);
            borderEndtime.Location = new Point(382, 74);
            borderEndtime.Name = "borderEndtime";
            borderEndtime.Size = new Size(107, 23);
            borderEndtime.TabIndex = 84;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(102, 204, 102);
            button2.FlatAppearance.BorderColor = Color.FromArgb(102, 204, 102);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9F);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(408, 32);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(48, 25);
            button2.TabIndex = 59;
            button2.Text = "Apply";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(93, 173, 226);
            panel19.Dock = DockStyle.Right;
            panel19.Location = new Point(106, 1);
            panel19.Name = "panel19";
            panel19.Size = new Size(1, 21);
            panel19.TabIndex = 3;
            // 
            // panel24
            // 
            panel24.BackColor = Color.FromArgb(93, 173, 226);
            panel24.Dock = DockStyle.Bottom;
            panel24.Location = new Point(1, 22);
            panel24.Name = "panel24";
            panel24.Size = new Size(106, 1);
            panel24.TabIndex = 2;
            // 
            // panel29
            // 
            panel29.BackColor = Color.FromArgb(93, 173, 226);
            panel29.Dock = DockStyle.Top;
            panel29.Location = new Point(1, 0);
            panel29.Name = "panel29";
            panel29.Size = new Size(106, 1);
            panel29.TabIndex = 1;
            // 
            // panel34
            // 
            panel34.BackColor = Color.FromArgb(93, 173, 226);
            panel34.Dock = DockStyle.Left;
            panel34.Location = new Point(0, 0);
            panel34.Name = "panel34";
            panel34.Size = new Size(1, 23);
            panel34.TabIndex = 0;
            // 
            // dtpEndtime
            // 
            dtpEndtime.Dock = DockStyle.Fill;
            dtpEndtime.Format = DateTimePickerFormat.Time;
            dtpEndtime.Location = new Point(0, 0);
            dtpEndtime.Name = "dtpEndtime";
            dtpEndtime.Size = new Size(107, 23);
            dtpEndtime.TabIndex = 5;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Tahoma", 9.75F);
            label18.ForeColor = Color.DimGray;
            label18.Location = new Point(382, 55);
            label18.Name = "label18";
            label18.Size = new Size(76, 16);
            label18.TabIndex = 83;
            label18.Text = "End of Time";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 9.75F);
            label17.ForeColor = Color.DimGray;
            label17.Location = new Point(250, 54);
            label17.Name = "label17";
            label17.Size = new Size(83, 16);
            label17.TabIndex = 82;
            label17.Text = "Start of Time";
            // 
            // borderBranch
            // 
            borderBranch.Controls.Add(panel3);
            borderBranch.Controls.Add(panel4);
            borderBranch.Controls.Add(panel5);
            borderBranch.Controls.Add(panel6);
            borderBranch.Controls.Add(txtFetchBranch);
            borderBranch.Location = new Point(593, 74);
            borderBranch.Name = "borderBranch";
            borderBranch.Size = new Size(213, 24);
            borderBranch.TabIndex = 87;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(93, 173, 226);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(212, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 22);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(93, 173, 226);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(1, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(212, 1);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(93, 173, 226);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(1, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(212, 1);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(93, 173, 226);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 24);
            panel6.TabIndex = 0;
            // 
            // txtFetchBranch
            // 
            txtFetchBranch.BackColor = SystemColors.InactiveBorder;
            txtFetchBranch.Dock = DockStyle.Fill;
            txtFetchBranch.DropDownHeight = 75;
            txtFetchBranch.Font = new Font("Tahoma", 9.75F);
            txtFetchBranch.FormattingEnabled = true;
            txtFetchBranch.IntegralHeight = false;
            txtFetchBranch.ItemHeight = 16;
            txtFetchBranch.Location = new Point(0, 0);
            txtFetchBranch.Name = "txtFetchBranch";
            txtFetchBranch.Size = new Size(213, 24);
            txtFetchBranch.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(594, 55);
            label2.Name = "label2";
            label2.Size = new Size(83, 16);
            label2.TabIndex = 86;
            label2.Text = "Branch Name";
            // 
            // btnNewAccount
            // 
            btnNewAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewAccount.BackColor = Color.Black;
            btnNewAccount.FlatAppearance.BorderColor = Color.Black;
            btnNewAccount.FlatStyle = FlatStyle.Flat;
            btnNewAccount.Font = new Font("Microsoft Sans Serif", 9F);
            btnNewAccount.ForeColor = SystemColors.ButtonFace;
            btnNewAccount.Location = new Point(974, 144);
            btnNewAccount.Margin = new Padding(0, 0, 0, 1);
            btnNewAccount.Name = "btnNewAccount";
            btnNewAccount.Size = new Size(119, 24);
            btnNewAccount.TabIndex = 88;
            btnNewAccount.Text = "Save Appointment";
            btnNewAccount.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9F);
            btnRefresh.ForeColor = SystemColors.ButtonFace;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(974, 194);
            btnRefresh.Margin = new Padding(0, 0, 0, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(119, 24);
            btnRefresh.TabIndex = 89;
            btnRefresh.TextAlign = ContentAlignment.MiddleLeft;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnView
            // 
            btnView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnView.BackColor = Color.FromArgb(52, 152, 219);
            btnView.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Microsoft Sans Serif", 9F);
            btnView.ForeColor = SystemColors.ButtonFace;
            btnView.Location = new Point(974, 169);
            btnView.Margin = new Padding(0, 0, 0, 1);
            btnView.Name = "btnView";
            btnView.Size = new Size(119, 24);
            btnView.TabIndex = 90;
            btnView.Text = "View All";
            btnView.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(830, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(134, 24);
            panel2.TabIndex = 89;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(93, 173, 226);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(133, 1);
            panel7.Name = "panel7";
            panel7.Size = new Size(1, 22);
            panel7.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(93, 173, 226);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(1, 23);
            panel8.Name = "panel8";
            panel8.Size = new Size(133, 1);
            panel8.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(93, 173, 226);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(1, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(133, 1);
            panel9.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(93, 173, 226);
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1, 24);
            panel10.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InactiveBorder;
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DropDownHeight = 75;
            comboBox1.Font = new Font("Tahoma", 9.75F);
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.ItemHeight = 16;
            comboBox1.Location = new Point(0, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 24);
            comboBox1.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(831, 55);
            label3.Name = "label3";
            label3.Size = new Size(43, 16);
            label3.TabIndex = 88;
            label3.Text = "Status";
            // 
            // panel11
            // 
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(panel13);
            panel11.Controls.Add(panel14);
            panel11.Controls.Add(panel15);
            panel11.Controls.Add(comboBox2);
            panel11.Location = new Point(120, 116);
            panel11.Name = "panel11";
            panel11.Size = new Size(213, 24);
            panel11.TabIndex = 90;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(93, 173, 226);
            panel12.Dock = DockStyle.Right;
            panel12.Location = new Point(212, 1);
            panel12.Name = "panel12";
            panel12.Size = new Size(1, 22);
            panel12.TabIndex = 3;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(93, 173, 226);
            panel13.Dock = DockStyle.Bottom;
            panel13.Location = new Point(1, 23);
            panel13.Name = "panel13";
            panel13.Size = new Size(212, 1);
            panel13.TabIndex = 2;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(93, 173, 226);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(1, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(212, 1);
            panel14.TabIndex = 1;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(93, 173, 226);
            panel15.Dock = DockStyle.Left;
            panel15.Location = new Point(0, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(1, 24);
            panel15.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.InactiveBorder;
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.DropDownHeight = 75;
            comboBox2.Font = new Font("Tahoma", 9.75F);
            comboBox2.FormattingEnabled = true;
            comboBox2.IntegralHeight = false;
            comboBox2.ItemHeight = 16;
            comboBox2.Location = new Point(0, 0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(213, 24);
            comboBox2.TabIndex = 56;
            // 
            // borderTitle
            // 
            borderTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borderTitle.Controls.Add(panel16);
            borderTitle.Controls.Add(panel17);
            borderTitle.Controls.Add(panel18);
            borderTitle.Controls.Add(panel20);
            borderTitle.Controls.Add(txtTitle);
            borderTitle.Location = new Point(830, 114);
            borderTitle.Name = "borderTitle";
            borderTitle.Size = new Size(134, 25);
            borderTitle.TabIndex = 91;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(93, 173, 226);
            panel16.Dock = DockStyle.Right;
            panel16.Location = new Point(133, 1);
            panel16.Name = "panel16";
            panel16.Size = new Size(1, 23);
            panel16.TabIndex = 3;
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(93, 173, 226);
            panel17.Dock = DockStyle.Bottom;
            panel17.Location = new Point(1, 24);
            panel17.Name = "panel17";
            panel17.Size = new Size(133, 1);
            panel17.TabIndex = 2;
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(93, 173, 226);
            panel18.Dock = DockStyle.Top;
            panel18.Location = new Point(1, 0);
            panel18.Name = "panel18";
            panel18.Size = new Size(133, 1);
            panel18.TabIndex = 1;
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(93, 173, 226);
            panel20.Dock = DockStyle.Left;
            panel20.Location = new Point(0, 0);
            panel20.Name = "panel20";
            panel20.Size = new Size(1, 25);
            panel20.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Dock = DockStyle.Fill;
            txtTitle.Font = new Font("Segoe UI", 9.75F);
            txtTitle.Location = new Point(0, 0);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(134, 25);
            txtTitle.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(750, 123);
            label4.Name = "label4";
            label4.Size = new Size(75, 16);
            label4.TabIndex = 92;
            label4.Text = "Range Price";
            // 
            // panel21
            // 
            panel21.BackColor = Color.DimGray;
            panel21.Location = new Point(13, 107);
            panel21.Name = "panel21";
            panel21.Size = new Size(951, 1);
            panel21.TabIndex = 93;
            // 
            // setupOnlineBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 660);
            Controls.Add(panel21);
            Controls.Add(label4);
            Controls.Add(borderTitle);
            Controls.Add(panel11);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(btnView);
            Controls.Add(btnNewAccount);
            Controls.Add(btnRefresh);
            Controls.Add(borderBranch);
            Controls.Add(label2);
            Controls.Add(borderStartTime);
            Controls.Add(borderEndtime);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label1);
            Controls.Add(borderFetchTitle);
            Controls.Add(label8);
            Controls.Add(viewDentalServices);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "setupOnlineBooking";
            Text = "setupOnlineBooking";
            Load += setupOnlineBooking_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewDentalServices).EndInit();
            borderFetchTitle.ResumeLayout(false);
            borderStartTime.ResumeLayout(false);
            borderEndtime.ResumeLayout(false);
            borderBranch.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel11.ResumeLayout(false);
            borderTitle.ResumeLayout(false);
            borderTitle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label40;
        private DataGridView viewDentalServices;
        private Panel borderFetchTitle;
        private Panel panel35;
        private Panel panel36;
        private Panel panel37;
        private Panel panel38;
        private ComboBox txtFetchTitle;
        private Label label8;
        private Label label1;
        private Panel borderStartTime;
        private Button button3;
        private Panel panel44;
        private Panel panel49;
        private Panel panel50;
        private Panel panel51;
        private DateTimePicker dtpStartTime;
        private Panel borderEndtime;
        private Button button2;
        private Panel panel19;
        private Panel panel24;
        private Panel panel29;
        private Panel panel34;
        private DateTimePicker dtpEndtime;
        private Label label18;
        private Label label17;
        private Panel borderBranch;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private ComboBox txtFetchBranch;
        private Label label2;
        private Button btnNewAccount;
        private Button btnRefresh;
        private Button btnView;
        private Panel panel2;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private ComboBox comboBox1;
        private Label label3;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private ComboBox comboBox2;
        private Panel borderTitle;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private Panel panel20;
        private TextBox txtTitle;
        private Label label4;
        private Panel panel21;
    }
}