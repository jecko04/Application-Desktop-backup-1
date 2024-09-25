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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            btnNewAdmin = new Button();
            btnRefresh = new Button();
            viewAdminData = new DataGridView();
            viewSuperAdminData = new DataGridView();
            btnDelete = new Button();
            btnNewSuperAdmin = new Button();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            label40 = new Label();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            elipseControl2 = new ElipseToolDemo.ElipseControl();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            viewAccessLogs = new DataGridView();
            btnAccess = new Button();
            panel2 = new Panel();
            elipseControl3 = new ElipseToolDemo.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)viewAdminData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewSuperAdminData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewAccessLogs).BeginInit();
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
            btnNewAdmin.Location = new Point(966, 100);
            btnNewAdmin.Margin = new Padding(0, 0, 2, 0);
            btnNewAdmin.Name = "btnNewAdmin";
            btnNewAdmin.Size = new Size(126, 24);
            btnNewAdmin.TabIndex = 10;
            btnNewAdmin.Text = "Create Admin";
            btnNewAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnNewAdmin.UseVisualStyleBackColor = false;
            btnNewAdmin.Click += btnNewAdmin_Click_1;
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
            btnRefresh.Location = new Point(966, 175);
            btnRefresh.Margin = new Padding(0, 0, 3, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(62, 24);
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
            dataGridViewCellStyle13.BackColor = Color.FromArgb(224, 241, 255);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = Color.Gray;
            dataGridViewCellStyle13.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(52, 152, 219);
            viewAdminData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            viewAdminData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewAdminData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewAdminData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewAdminData.BackgroundColor = Color.White;
            viewAdminData.BorderStyle = BorderStyle.None;
            viewAdminData.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewAdminData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle14.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.Padding = new Padding(3);
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            viewAdminData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            viewAdminData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = SystemColors.Window;
            dataGridViewCellStyle15.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle15.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            viewAdminData.DefaultCellStyle = dataGridViewCellStyle15;
            viewAdminData.EnableHeadersVisualStyles = false;
            viewAdminData.Location = new Point(3, 12);
            viewAdminData.Margin = new Padding(0);
            viewAdminData.Name = "viewAdminData";
            viewAdminData.ReadOnly = true;
            viewAdminData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Control;
            dataGridViewCellStyle16.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(149, 86, 203);
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            viewAdminData.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            viewAdminData.RowTemplate.Height = 25;
            viewAdminData.Size = new Size(934, 310);
            viewAdminData.TabIndex = 5;
            viewAdminData.CellContentClick += viewAdminData_CellContentClick;
            // 
            // viewSuperAdminData
            // 
            viewSuperAdminData.AllowUserToAddRows = false;
            viewSuperAdminData.AllowUserToDeleteRows = false;
            viewSuperAdminData.AllowUserToResizeColumns = false;
            viewSuperAdminData.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(224, 241, 255);
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle17.ForeColor = Color.Gray;
            dataGridViewCellStyle17.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle17.SelectionForeColor = Color.FromArgb(52, 152, 219);
            viewSuperAdminData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            viewSuperAdminData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewSuperAdminData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewSuperAdminData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewSuperAdminData.BackgroundColor = Color.White;
            viewSuperAdminData.BorderStyle = BorderStyle.None;
            viewSuperAdminData.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewSuperAdminData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle18.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle18.ForeColor = Color.White;
            dataGridViewCellStyle18.Padding = new Padding(3);
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle18.SelectionForeColor = Color.White;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            viewSuperAdminData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            viewSuperAdminData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = Color.White;
            dataGridViewCellStyle19.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle19.ForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle19.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle19.SelectionForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            viewSuperAdminData.DefaultCellStyle = dataGridViewCellStyle19;
            viewSuperAdminData.EnableHeadersVisualStyles = false;
            viewSuperAdminData.Location = new Point(3, 14);
            viewSuperAdminData.Margin = new Padding(0, 0, 0, 10);
            viewSuperAdminData.Name = "viewSuperAdminData";
            viewSuperAdminData.ReadOnly = true;
            viewSuperAdminData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = SystemColors.Control;
            dataGridViewCellStyle20.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle20.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(149, 86, 203);
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            viewSuperAdminData.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            viewSuperAdminData.RowTemplate.Height = 25;
            viewSuperAdminData.Size = new Size(934, 312);
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
            btnDelete.Location = new Point(1030, 175);
            btnDelete.Margin = new Padding(0, 0, 3, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(62, 24);
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
            btnNewSuperAdmin.Location = new Point(966, 75);
            btnNewSuperAdmin.Margin = new Padding(0, 0, 0, 1);
            btnNewSuperAdmin.Name = "btnNewSuperAdmin";
            btnNewSuperAdmin.Size = new Size(126, 24);
            btnNewSuperAdmin.TabIndex = 4;
            btnNewSuperAdmin.Text = "Create SuperAdmin";
            btnNewSuperAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnNewSuperAdmin.UseVisualStyleBackColor = false;
            btnNewSuperAdmin.Click += btnNewSuperAdmin_Click;
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
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 30);
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
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.ItemSize = new Size(84, 24);
            tabControl1.Location = new Point(12, 47);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(10, 5);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(948, 368);
            tabControl1.TabIndex = 9;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(viewSuperAdminData);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(940, 336);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Super Admin Account";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(viewAdminData);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(940, 326);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Admin Account";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(viewAccessLogs);
            tabPage3.Location = new Point(4, 28);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(940, 336);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Patient Record Access Log";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // viewAccessLogs
            // 
            viewAccessLogs.AllowUserToAddRows = false;
            viewAccessLogs.AllowUserToDeleteRows = false;
            viewAccessLogs.AllowUserToResizeColumns = false;
            viewAccessLogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = Color.FromArgb(224, 241, 255);
            dataGridViewCellStyle21.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle21.ForeColor = Color.Gray;
            dataGridViewCellStyle21.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle21.SelectionForeColor = Color.FromArgb(52, 152, 219);
            viewAccessLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            viewAccessLogs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewAccessLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewAccessLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewAccessLogs.BackgroundColor = Color.White;
            viewAccessLogs.BorderStyle = BorderStyle.None;
            viewAccessLogs.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewAccessLogs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle22.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle22.ForeColor = Color.White;
            dataGridViewCellStyle22.Padding = new Padding(3);
            dataGridViewCellStyle22.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle22.SelectionForeColor = Color.White;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            viewAccessLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            viewAccessLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = SystemColors.Window;
            dataGridViewCellStyle23.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle23.ForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle23.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle23.SelectionForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            viewAccessLogs.DefaultCellStyle = dataGridViewCellStyle23;
            viewAccessLogs.EnableHeadersVisualStyles = false;
            viewAccessLogs.Location = new Point(3, 12);
            viewAccessLogs.Margin = new Padding(0);
            viewAccessLogs.Name = "viewAccessLogs";
            viewAccessLogs.ReadOnly = true;
            viewAccessLogs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = SystemColors.Control;
            dataGridViewCellStyle24.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle24.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(149, 86, 203);
            dataGridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.False;
            viewAccessLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            viewAccessLogs.RowTemplate.Height = 25;
            viewAccessLogs.Size = new Size(934, 310);
            viewAccessLogs.TabIndex = 6;
            viewAccessLogs.CellContentClick += viewAccessAccount_CellContentClick;
            // 
            // btnAccess
            // 
            btnAccess.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAccess.BackColor = Color.FromArgb(52, 152, 219);
            btnAccess.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnAccess.FlatStyle = FlatStyle.Flat;
            btnAccess.Font = new Font("Microsoft Sans Serif", 9F);
            btnAccess.ForeColor = SystemColors.ButtonFace;
            btnAccess.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccess.Location = new Point(966, 125);
            btnAccess.Margin = new Padding(0, 1, 2, 1);
            btnAccess.Name = "btnAccess";
            btnAccess.Size = new Size(126, 24);
            btnAccess.TabIndex = 10;
            btnAccess.Text = "Create Access Acc.";
            btnAccess.TextAlign = ContentAlignment.MiddleLeft;
            btnAccess.UseVisualStyleBackColor = false;
            btnAccess.Click += btnAccess_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(966, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(126, 1);
            panel2.TabIndex = 13;
            // 
            // elipseControl3
            // 
            elipseControl3.CornerRadius = 15;
            elipseControl3.TargetControl = viewAccessLogs;
            // 
            // admin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1101, 660);
            Controls.Add(panel2);
            Controls.Add(btnDelete);
            Controls.Add(btnAccess);
            Controls.Add(btnRefresh);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(btnNewAdmin);
            Controls.Add(btnNewSuperAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin";
            Text = "registerAdmin";
            Load += registerAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)viewAdminData).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewSuperAdminData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewAccessLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnNewAdmin;
        private Button btnRefresh;
        private DataGridView viewAdminData;
        private DataGridView viewSuperAdminData;
        private Button btnNewSuperAdmin;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Button btnDelete;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private ElipseToolDemo.ElipseControl elipseControl2;
        private Label label40;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnAccess;
        private DataGridView viewAccessLogs;
        private Panel panel2;
        private ElipseToolDemo.ElipseControl elipseControl3;
    }
}