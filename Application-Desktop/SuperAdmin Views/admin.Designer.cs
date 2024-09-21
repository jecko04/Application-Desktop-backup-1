namespace Application_Desktop.Sub_Views
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            btnNewAdmin = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnRefresh = new Button();
            viewAdminData = new DataGridView();
            viewSuperAdminData = new DataGridView();
            btnDelete = new Button();
            btnNewSuperAdmin = new Button();
            btnSearchSuperAdmin = new Button();
            txtSearchBox = new TextBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            label40 = new Label();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            elipseControl2 = new ElipseToolDemo.ElipseControl();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewAdminData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewSuperAdminData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // btnNewAdmin
            // 
            btnNewAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewAdmin.BackColor = Color.FromArgb(52, 152, 219);
            btnNewAdmin.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnNewAdmin.FlatStyle = FlatStyle.Flat;
            btnNewAdmin.Font = new Font("Microsoft Sans Serif", 9F);
            btnNewAdmin.ForeColor = SystemColors.ButtonFace;
            btnNewAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewAdmin.Location = new Point(1009, 329);
            btnNewAdmin.Margin = new Padding(0, 0, 2, 0);
            btnNewAdmin.Name = "btnNewAdmin";
            btnNewAdmin.Size = new Size(84, 24);
            btnNewAdmin.TabIndex = 4;
            btnNewAdmin.Text = "Create New";
            btnNewAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnNewAdmin.UseVisualStyleBackColor = false;
            btnNewAdmin.Click += btnNewAdmin_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 296);
            panel2.Name = "panel2";
            panel2.Size = new Size(999, 30);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label1.Location = new Point(33, 8);
            label1.Name = "label1";
            label1.Size = new Size(86, 16);
            label1.TabIndex = 89;
            label1.Text = "Admin Panel";
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
            btnRefresh.Location = new Point(920, 3);
            btnRefresh.Margin = new Padding(0, 0, 3, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(38, 24);
            btnRefresh.TabIndex = 11;
            btnRefresh.TextAlign = ContentAlignment.MiddleLeft;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // viewAdminData
            // 
            viewAdminData.AllowUserToAddRows = false;
            viewAdminData.AllowUserToDeleteRows = false;
            viewAdminData.AllowUserToResizeColumns = false;
            viewAdminData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 241, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(52, 152, 219);
            viewAdminData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            viewAdminData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewAdminData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewAdminData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewAdminData.BackgroundColor = Color.White;
            viewAdminData.BorderStyle = BorderStyle.None;
            viewAdminData.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewAdminData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            viewAdminData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            viewAdminData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            viewAdminData.DefaultCellStyle = dataGridViewCellStyle3;
            viewAdminData.EnableHeadersVisualStyles = false;
            viewAdminData.Location = new Point(3, 329);
            viewAdminData.Margin = new Padding(0);
            viewAdminData.Name = "viewAdminData";
            viewAdminData.ReadOnly = true;
            viewAdminData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(149, 86, 203);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            viewAdminData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            viewAdminData.RowTemplate.Height = 25;
            viewAdminData.Size = new Size(996, 229);
            viewAdminData.TabIndex = 5;
            viewAdminData.CellContentClick += viewAdminData_CellContentClick;
            // 
            // viewSuperAdminData
            // 
            viewSuperAdminData.AllowUserToAddRows = false;
            viewSuperAdminData.AllowUserToDeleteRows = false;
            viewSuperAdminData.AllowUserToResizeColumns = false;
            viewSuperAdminData.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 241, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Gray;
            dataGridViewCellStyle5.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(52, 152, 219);
            viewSuperAdminData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            viewSuperAdminData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewSuperAdminData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewSuperAdminData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewSuperAdminData.BackgroundColor = Color.White;
            viewSuperAdminData.BorderStyle = BorderStyle.None;
            viewSuperAdminData.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewSuperAdminData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.Padding = new Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            viewSuperAdminData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            viewSuperAdminData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle7.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            viewSuperAdminData.DefaultCellStyle = dataGridViewCellStyle7;
            viewSuperAdminData.EnableHeadersVisualStyles = false;
            viewSuperAdminData.Location = new Point(3, 32);
            viewSuperAdminData.Margin = new Padding(0, 0, 0, 10);
            viewSuperAdminData.Name = "viewSuperAdminData";
            viewSuperAdminData.ReadOnly = true;
            viewSuperAdminData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(149, 86, 203);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            viewSuperAdminData.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            viewSuperAdminData.RowTemplate.Height = 25;
            viewSuperAdminData.Size = new Size(996, 229);
            viewSuperAdminData.TabIndex = 8;
            viewSuperAdminData.CellContentClick += viewSuperAdminData_CellContentClick_1;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 9F);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(961, 3);
            btnDelete.Margin = new Padding(0, 0, 3, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(38, 24);
            btnDelete.TabIndex = 12;
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNewSuperAdmin
            // 
            btnNewSuperAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewSuperAdmin.BackColor = Color.FromArgb(52, 152, 219);
            btnNewSuperAdmin.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnNewSuperAdmin.FlatStyle = FlatStyle.Flat;
            btnNewSuperAdmin.Font = new Font("Microsoft Sans Serif", 9F);
            btnNewSuperAdmin.ForeColor = SystemColors.ButtonFace;
            btnNewSuperAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewSuperAdmin.Location = new Point(1009, 32);
            btnNewSuperAdmin.Margin = new Padding(0, 0, 0, 1);
            btnNewSuperAdmin.Name = "btnNewSuperAdmin";
            btnNewSuperAdmin.Size = new Size(84, 24);
            btnNewSuperAdmin.TabIndex = 4;
            btnNewSuperAdmin.Text = "Create New";
            btnNewSuperAdmin.UseVisualStyleBackColor = false;
            btnNewSuperAdmin.Click += btnNewSuperAdmin_Click;
            // 
            // btnSearchSuperAdmin
            // 
            btnSearchSuperAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchSuperAdmin.BackColor = Color.FromArgb(52, 152, 219);
            btnSearchSuperAdmin.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnSearchSuperAdmin.FlatStyle = FlatStyle.Flat;
            btnSearchSuperAdmin.Font = new Font("Microsoft Sans Serif", 9F);
            btnSearchSuperAdmin.ForeColor = SystemColors.ButtonFace;
            btnSearchSuperAdmin.Image = (Image)resources.GetObject("btnSearchSuperAdmin.Image");
            btnSearchSuperAdmin.Location = new Point(879, 3);
            btnSearchSuperAdmin.Margin = new Padding(0, 0, 3, 3);
            btnSearchSuperAdmin.Name = "btnSearchSuperAdmin";
            btnSearchSuperAdmin.Size = new Size(38, 24);
            btnSearchSuperAdmin.TabIndex = 11;
            btnSearchSuperAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnSearchSuperAdmin.UseVisualStyleBackColor = false;
            btnSearchSuperAdmin.Click += btnSearchSuperAdmin_Click;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Cursor = Cursors.IBeam;
            txtSearchBox.Dock = DockStyle.Fill;
            txtSearchBox.Font = new Font("Segoe UI", 9F);
            txtSearchBox.Location = new Point(1, 1);
            txtSearchBox.Margin = new Padding(0, 0, 3, 3);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.PlaceholderText = " Search";
            txtSearchBox.Size = new Size(190, 23);
            txtSearchBox.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label40);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(btnSearchSuperAdmin);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnRefresh);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 30);
            panel1.TabIndex = 7;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label40.Location = new Point(33, 8);
            label40.Name = "label40";
            label40.Size = new Size(128, 16);
            label40.TabIndex = 88;
            label40.Text = "Super Admin Panel";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(txtSearchBox);
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(panel11);
            panel8.Controls.Add(panel12);
            panel8.Cursor = Cursors.IBeam;
            panel8.Location = new Point(682, 3);
            panel8.Margin = new Padding(0, 0, 3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(194, 24);
            panel8.TabIndex = 16;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(52, 152, 219);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(1, 21);
            panel9.Name = "panel9";
            panel9.Size = new Size(190, 1);
            panel9.TabIndex = 14;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(52, 152, 219);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(1, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(190, 1);
            panel10.TabIndex = 15;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(52, 152, 219);
            panel11.Dock = DockStyle.Left;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(1, 22);
            panel11.TabIndex = 15;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(52, 152, 219);
            panel12.Dock = DockStyle.Right;
            panel12.Location = new Point(191, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(1, 22);
            panel12.TabIndex = 15;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = viewSuperAdminData;
            // 
            // elipseControl2
            // 
            elipseControl2.CornerRadius = 15;
            elipseControl2.TargetControl = viewAdminData;
            // 
            // admin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1101, 660);
            Controls.Add(panel1);
            Controls.Add(btnNewAdmin);
            Controls.Add(btnNewSuperAdmin);
            Controls.Add(viewSuperAdminData);
            Controls.Add(panel2);
            Controls.Add(viewAdminData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin";
            Text = "registerAdmin";
            Load += registerAdmin_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewAdminData).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewSuperAdminData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnNewAdmin;
        private Panel panel2;
        private Button btnRefresh;
        private DataGridView viewAdminData;
        private DataGridView viewSuperAdminData;
        private PictureBox pictureBox1;
        private Button btnNewSuperAdmin;
        private PictureBox pictureBox3;
        private Panel panel1;
        private TextBox txtSearchBox;
        private Button btnSearchSuperAdmin;
        private Button btnDelete;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private ElipseToolDemo.ElipseControl elipseControl2;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Label label1;
        private Label label40;
    }
}