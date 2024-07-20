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
            btnNewAdmin = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label2 = new Label();
            btnRefresh = new Button();
            viewAdminData = new DataGridView();
            viewSuperAdminData = new DataGridView();
            flowLayoutPanel4 = new FlowLayoutPanel();
            btnDelete = new Button();
            btnNewSuperAdmin = new Button();
            btnSearchSuperAdmin = new Button();
            txtSearchBox = new TextBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewAdminData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewSuperAdminData).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNewAdmin
            // 
            btnNewAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewAdmin.BackColor = Color.FromArgb(231, 76, 60);
            btnNewAdmin.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnNewAdmin.FlatStyle = FlatStyle.Flat;
            btnNewAdmin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewAdmin.ForeColor = SystemColors.ButtonFace;
            btnNewAdmin.Image = (Image)resources.GetObject("btnNewAdmin.Image");
            btnNewAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewAdmin.Location = new Point(382, 0);
            btnNewAdmin.Margin = new Padding(0, 0, 2, 0);
            btnNewAdmin.Name = "btnNewAdmin";
            btnNewAdmin.Size = new Size(126, 30);
            btnNewAdmin.TabIndex = 4;
            btnNewAdmin.Text = "              New Admin";
            btnNewAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnNewAdmin.UseVisualStyleBackColor = false;
            btnNewAdmin.Click += btnNewAdmin_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(flowLayoutPanel3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(894, 30);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel3.BackColor = Color.White;
            flowLayoutPanel3.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel3.Location = new Point(276, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(618, 30);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 8);
            label2.Name = "label2";
            label2.Size = new Size(79, 16);
            label2.TabIndex = 5;
            label2.Text = "Admin Table";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = SystemColors.ButtonFace;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(345, 0);
            btnRefresh.Margin = new Padding(5, 0, 5, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(32, 30);
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
            viewAdminData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewAdminData.BackgroundColor = SystemColors.ButtonFace;
            viewAdminData.BorderStyle = BorderStyle.None;
            viewAdminData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(123, 44, 191);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(149, 86, 203);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            viewAdminData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            viewAdminData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            viewAdminData.DefaultCellStyle = dataGridViewCellStyle2;
            viewAdminData.Dock = DockStyle.Bottom;
            viewAdminData.Location = new Point(0, 137);
            viewAdminData.Margin = new Padding(0);
            viewAdminData.Name = "viewAdminData";
            viewAdminData.ReadOnly = true;
            viewAdminData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(149, 86, 203);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            viewAdminData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            viewAdminData.RowTemplate.Height = 25;
            viewAdminData.Size = new Size(894, 313);
            viewAdminData.TabIndex = 5;
            viewAdminData.CellContentClick += viewAdminData_CellContentClick;
            // 
            // viewSuperAdminData
            // 
            viewSuperAdminData.AllowUserToAddRows = false;
            viewSuperAdminData.AllowUserToDeleteRows = false;
            viewSuperAdminData.AllowUserToResizeColumns = false;
            viewSuperAdminData.AllowUserToResizeRows = false;
            viewSuperAdminData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewSuperAdminData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewSuperAdminData.BackgroundColor = SystemColors.ButtonFace;
            viewSuperAdminData.BorderStyle = BorderStyle.None;
            viewSuperAdminData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(123, 44, 191);
            dataGridViewCellStyle4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(149, 86, 203);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            viewSuperAdminData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            viewSuperAdminData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            viewSuperAdminData.DefaultCellStyle = dataGridViewCellStyle5;
            viewSuperAdminData.Location = new Point(0, 29);
            viewSuperAdminData.Margin = new Padding(0, 0, 0, 10);
            viewSuperAdminData.Name = "viewSuperAdminData";
            viewSuperAdminData.ReadOnly = true;
            viewSuperAdminData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(149, 86, 203);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            viewSuperAdminData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            viewSuperAdminData.RowTemplate.Height = 25;
            viewSuperAdminData.Size = new Size(894, 282);
            viewSuperAdminData.TabIndex = 8;
            viewSuperAdminData.CellContentClick += viewSuperAdminData_CellContentClick_1;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel4.BackColor = Color.White;
            flowLayoutPanel4.Controls.Add(btnDelete);
            flowLayoutPanel4.Controls.Add(btnNewSuperAdmin);
            flowLayoutPanel4.Controls.Add(btnNewAdmin);
            flowLayoutPanel4.Controls.Add(btnRefresh);
            flowLayoutPanel4.Controls.Add(btnSearchSuperAdmin);
            flowLayoutPanel4.Controls.Add(txtSearchBox);
            flowLayoutPanel4.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel4.Location = new Point(183, 0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(711, 30);
            flowLayoutPanel4.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(52, 152, 219);
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(673, 0);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(38, 30);
            btnDelete.TabIndex = 12;
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNewSuperAdmin
            // 
            btnNewSuperAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewSuperAdmin.BackColor = Color.FromArgb(231, 76, 60);
            btnNewSuperAdmin.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnNewSuperAdmin.FlatStyle = FlatStyle.Flat;
            btnNewSuperAdmin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewSuperAdmin.ForeColor = SystemColors.ButtonFace;
            btnNewSuperAdmin.Image = (Image)resources.GetObject("btnNewSuperAdmin.Image");
            btnNewSuperAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewSuperAdmin.Location = new Point(510, 0);
            btnNewSuperAdmin.Margin = new Padding(0, 0, 2, 0);
            btnNewSuperAdmin.Name = "btnNewSuperAdmin";
            btnNewSuperAdmin.Size = new Size(161, 30);
            btnNewSuperAdmin.TabIndex = 4;
            btnNewSuperAdmin.Text = "              New Super Admin\r\n";
            btnNewSuperAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnNewSuperAdmin.UseVisualStyleBackColor = false;
            btnNewSuperAdmin.Click += btnNewSuperAdmin_Click;
            // 
            // btnSearchSuperAdmin
            // 
            btnSearchSuperAdmin.BackColor = Color.FromArgb(52, 152, 219);
            btnSearchSuperAdmin.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnSearchSuperAdmin.FlatStyle = FlatStyle.Flat;
            btnSearchSuperAdmin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchSuperAdmin.ForeColor = SystemColors.ButtonFace;
            btnSearchSuperAdmin.Image = (Image)resources.GetObject("btnSearchSuperAdmin.Image");
            btnSearchSuperAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchSuperAdmin.Location = new Point(308, 0);
            btnSearchSuperAdmin.Margin = new Padding(0);
            btnSearchSuperAdmin.Name = "btnSearchSuperAdmin";
            btnSearchSuperAdmin.Size = new Size(32, 30);
            btnSearchSuperAdmin.TabIndex = 11;
            btnSearchSuperAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnSearchSuperAdmin.UseVisualStyleBackColor = false;
            btnSearchSuperAdmin.Click += btnSearchSuperAdmin_Click;
            // 
            // txtSearchBox
            // 
            txtSearchBox.BorderStyle = BorderStyle.FixedSingle;
            txtSearchBox.Cursor = Cursors.IBeam;
            txtSearchBox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchBox.Location = new Point(109, 3);
            txtSearchBox.Margin = new Padding(3, 3, 5, 3);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.PlaceholderText = " Search";
            txtSearchBox.Size = new Size(194, 23);
            txtSearchBox.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 8);
            label1.Name = "label1";
            label1.Size = new Size(117, 16);
            label1.TabIndex = 4;
            label1.Text = "Super Admin Table";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(flowLayoutPanel4);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 30);
            panel1.TabIndex = 7;
            // 
            // admin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(894, 450);
            Controls.Add(panel1);
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
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnNewAdmin;
        private Panel panel2;
        private Button btnRefresh;
        private FlowLayoutPanel flowLayoutPanel3;
        private DataGridView viewAdminData;
        private DataGridView viewSuperAdminData;
        private Label label2;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button btnNewSuperAdmin;
        private PictureBox pictureBox3;
        private Label label1;
        private Panel panel1;
        private TextBox txtSearchBox;
        private Button btnSearchSuperAdmin;
        private Button btnDelete;
    }
}