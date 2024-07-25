namespace Application_Desktop.Sub_Views
{
    partial class dentaldoctorUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dentaldoctorUsers));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnSearchSuperAdmin = new Button();
            txtSearchBox = new TextBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            viewDentalAccount = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewDentalAccount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 30);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(btnRefresh);
            flowLayoutPanel1.Controls.Add(btnSearchSuperAdmin);
            flowLayoutPanel1.Controls.Add(txtSearchBox);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(302, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(497, 30);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(459, 0);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(38, 30);
            btnDelete.TabIndex = 13;
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            btnRefresh.Location = new Point(422, 0);
            btnRefresh.Margin = new Padding(5, 0, 5, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(32, 30);
            btnRefresh.TabIndex = 17;
            btnRefresh.TextAlign = ContentAlignment.MiddleLeft;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
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
            btnSearchSuperAdmin.Location = new Point(385, 0);
            btnSearchSuperAdmin.Margin = new Padding(0);
            btnSearchSuperAdmin.Name = "btnSearchSuperAdmin";
            btnSearchSuperAdmin.Size = new Size(32, 30);
            btnSearchSuperAdmin.TabIndex = 19;
            btnSearchSuperAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnSearchSuperAdmin.UseVisualStyleBackColor = false;
            btnSearchSuperAdmin.Click += btnSearchSuperAdmin_Click;
            // 
            // txtSearchBox
            // 
            txtSearchBox.BorderStyle = BorderStyle.FixedSingle;
            txtSearchBox.Cursor = Cursors.IBeam;
            txtSearchBox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchBox.Location = new Point(186, 3);
            txtSearchBox.Margin = new Padding(3, 3, 5, 3);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.PlaceholderText = " Search";
            txtSearchBox.Size = new Size(194, 23);
            txtSearchBox.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 16);
            label1.TabIndex = 6;
            label1.Text = "Mobile Account\r\n";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // viewDentalAccount
            // 
            viewDentalAccount.AllowUserToAddRows = false;
            viewDentalAccount.AllowUserToDeleteRows = false;
            viewDentalAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            viewDentalAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewDentalAccount.BackgroundColor = SystemColors.ButtonFace;
            viewDentalAccount.BorderStyle = BorderStyle.None;
            viewDentalAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            viewDentalAccount.DefaultCellStyle = dataGridViewCellStyle1;
            viewDentalAccount.Location = new Point(0, 28);
            viewDentalAccount.Name = "viewDentalAccount";
            viewDentalAccount.ReadOnly = true;
            viewDentalAccount.RowTemplate.Height = 25;
            viewDentalAccount.Size = new Size(799, 424);
            viewDentalAccount.TabIndex = 1;
            viewDentalAccount.CellContentClick += viewDentalAccount_CellContentClick;
            // 
            // dentaldoctorUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewDentalAccount);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dentaldoctorUsers";
            Text = "dentaldoctorUsers";
            Load += dentaldoctorUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewDentalAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox3;
        private DataGridView viewDentalAccount;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnSearchSuperAdmin;
        private TextBox txtSearchBox;
    }
}