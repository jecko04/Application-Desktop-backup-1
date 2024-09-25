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
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle34 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
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
            viewAccessAccount = new DataGridView();
            btnAccess = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)viewAdminData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewSuperAdminData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewAccessAccount).BeginInit();
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
            dataGridViewCellStyle25.BackColor = Color.FromArgb(224, 241, 255);
            dataGridViewCellStyle25.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle25.ForeColor = Color.Gray;
            dataGridViewCellStyle25.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle25.SelectionForeColor = Color.FromArgb(52, 152, 219);
            viewAdminData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            viewAdminData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewAdminData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewAdminData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewAdminData.BackgroundColor = Color.White;
            viewAdminData.BorderStyle = BorderStyle.None;
            viewAdminData.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewAdminData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle26.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle26.ForeColor = Color.White;
            dataGridViewCellStyle26.Padding = new Padding(3);
            dataGridViewCellStyle26.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle26.SelectionForeColor = Color.White;
            dataGridViewCellStyle26.WrapMode = DataGridViewTriState.True;
            viewAdminData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            viewAdminData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = SystemColors.Window;
            dataGridViewCellStyle27.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle27.ForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle27.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle27.SelectionForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle27.WrapMode = DataGridViewTriState.True;
            viewAdminData.DefaultCellStyle = dataGridViewCellStyle27;
            viewAdminData.EnableHeadersVisualStyles = false;
            viewAdminData.Location = new Point(3, 12);
            viewAdminData.Margin = new Padding(0);
            viewAdminData.Name = "viewAdminData";
            viewAdminData.ReadOnly = true;
            viewAdminData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = SystemColors.Control;
            dataGridViewCellStyle28.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle28.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = Color.FromArgb(149, 86, 203);
            dataGridViewCellStyle28.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = DataGridViewTriState.False;
            viewAdminData.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            viewAdminData.RowTemplate.Height = 25;
            viewAdminData.Size = new Size(934, 229);
            viewAdminData.TabIndex = 5;
            viewAdminData.CellContentClick += viewAdminData_CellContentClick;
            // 
            // viewSuperAdminData
            // 
            viewSuperAdminData.AllowUserToAddRows = false;
            viewSuperAdminData.AllowUserToDeleteRows = false;
            viewSuperAdminData.AllowUserToResizeColumns = false;
            viewSuperAdminData.AllowUserToResizeRows = false;
            dataGridViewCellStyle29.BackColor = Color.FromArgb(224, 241, 255);
            dataGridViewCellStyle29.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle29.ForeColor = Color.Gray;
            dataGridViewCellStyle29.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle29.SelectionForeColor = Color.FromArgb(52, 152, 219);
            viewSuperAdminData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            viewSuperAdminData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewSuperAdminData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewSuperAdminData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewSuperAdminData.BackgroundColor = Color.White;
            viewSuperAdminData.BorderStyle = BorderStyle.None;
            viewSuperAdminData.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewSuperAdminData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle30.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle30.ForeColor = Color.White;
            dataGridViewCellStyle30.Padding = new Padding(3);
            dataGridViewCellStyle30.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle30.SelectionForeColor = Color.White;
            dataGridViewCellStyle30.WrapMode = DataGridViewTriState.True;
            viewSuperAdminData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            viewSuperAdminData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle31.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = Color.White;
            dataGridViewCellStyle31.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle31.ForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle31.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle31.SelectionForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle31.WrapMode = DataGridViewTriState.True;
            viewSuperAdminData.DefaultCellStyle = dataGridViewCellStyle31;
            viewSuperAdminData.EnableHeadersVisualStyles = false;
            viewSuperAdminData.Location = new Point(3, 14);
            viewSuperAdminData.Margin = new Padding(0, 0, 0, 10);
            viewSuperAdminData.Name = "viewSuperAdminData";
            viewSuperAdminData.ReadOnly = true;
            viewSuperAdminData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = SystemColors.Control;
            dataGridViewCellStyle32.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle32.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = Color.FromArgb(149, 86, 203);
            dataGridViewCellStyle32.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = DataGridViewTriState.False;
            viewSuperAdminData.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            viewSuperAdminData.RowTemplate.Height = 25;
            viewSuperAdminData.Size = new Size(934, 229);
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
            tabPage2.Size = new Size(940, 336);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Admin Account";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(viewAccessAccount);
            tabPage3.Location = new Point(4, 28);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(940, 336);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Patient Record Access Log";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // viewAccessAccount
            // 
            viewAccessAccount.AllowUserToAddRows = false;
            viewAccessAccount.AllowUserToDeleteRows = false;
            viewAccessAccount.AllowUserToResizeColumns = false;
            viewAccessAccount.AllowUserToResizeRows = false;
            dataGridViewCellStyle33.BackColor = Color.FromArgb(224, 241, 255);
            dataGridViewCellStyle33.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle33.ForeColor = Color.Gray;
            dataGridViewCellStyle33.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle33.SelectionForeColor = Color.FromArgb(52, 152, 219);
            viewAccessAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle33;
            viewAccessAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewAccessAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewAccessAccount.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewAccessAccount.BackgroundColor = Color.White;
            viewAccessAccount.BorderStyle = BorderStyle.None;
            viewAccessAccount.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewAccessAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle34.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle34.ForeColor = Color.White;
            dataGridViewCellStyle34.Padding = new Padding(3);
            dataGridViewCellStyle34.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle34.SelectionForeColor = Color.White;
            dataGridViewCellStyle34.WrapMode = DataGridViewTriState.True;
            viewAccessAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            viewAccessAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = SystemColors.Window;
            dataGridViewCellStyle35.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle35.ForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle35.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle35.SelectionForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle35.WrapMode = DataGridViewTriState.True;
            viewAccessAccount.DefaultCellStyle = dataGridViewCellStyle35;
            viewAccessAccount.EnableHeadersVisualStyles = false;
            viewAccessAccount.Location = new Point(3, 12);
            viewAccessAccount.Margin = new Padding(0);
            viewAccessAccount.Name = "viewAccessAccount";
            viewAccessAccount.ReadOnly = true;
            viewAccessAccount.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = SystemColors.Control;
            dataGridViewCellStyle36.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle36.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = Color.FromArgb(149, 86, 203);
            dataGridViewCellStyle36.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = DataGridViewTriState.False;
            viewAccessAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            viewAccessAccount.RowTemplate.Height = 25;
            viewAccessAccount.Size = new Size(934, 229);
            viewAccessAccount.TabIndex = 6;
            viewAccessAccount.CellContentClick += viewAccessAccount_CellContentClick;
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
            ((System.ComponentModel.ISupportInitialize)viewAccessAccount).EndInit();
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
        private DataGridView viewAccessAccount;
        private Panel panel2;
    }
}