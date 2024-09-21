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
            btnSearchSuperAdmin = new Button();
            pictureBox3 = new PictureBox();
            txtSearchBox = new TextBox();
            label40 = new Label();
            btnDelete = new Button();
            btnRefresh = new Button();
            viewDentalAccount = new DataGridView();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewDentalAccount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnSearchSuperAdmin);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(txtSearchBox);
            panel1.Controls.Add(label40);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 30);
            panel1.TabIndex = 0;
            // 
            // btnSearchSuperAdmin
            // 
            btnSearchSuperAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchSuperAdmin.BackColor = Color.FromArgb(52, 152, 219);
            btnSearchSuperAdmin.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnSearchSuperAdmin.FlatStyle = FlatStyle.Flat;
            btnSearchSuperAdmin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchSuperAdmin.ForeColor = SystemColors.ButtonFace;
            btnSearchSuperAdmin.Image = (Image)resources.GetObject("btnSearchSuperAdmin.Image");
            btnSearchSuperAdmin.Location = new Point(952, 4);
            btnSearchSuperAdmin.Margin = new Padding(0, 0, 0, 3);
            btnSearchSuperAdmin.Name = "btnSearchSuperAdmin";
            btnSearchSuperAdmin.Size = new Size(38, 24);
            btnSearchSuperAdmin.TabIndex = 19;
            btnSearchSuperAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnSearchSuperAdmin.UseVisualStyleBackColor = false;
            btnSearchSuperAdmin.Click += btnSearchSuperAdmin_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchBox.BorderStyle = BorderStyle.FixedSingle;
            txtSearchBox.Cursor = Cursors.IBeam;
            txtSearchBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchBox.Location = new Point(755, 3);
            txtSearchBox.Margin = new Padding(0, 0, 3, 3);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.PlaceholderText = " Search";
            txtSearchBox.Size = new Size(194, 25);
            txtSearchBox.TabIndex = 18;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label40.Location = new Point(33, 8);
            label40.Name = "label40";
            label40.Size = new Size(201, 16);
            label40.TabIndex = 90;
            label40.Text = "Dental Doctors Account Panel";
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
            btnDelete.Location = new Point(1002, 59);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 24);
            btnDelete.TabIndex = 13;
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = SystemColors.ButtonFace;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(1002, 34);
            btnRefresh.Margin = new Padding(0, 0, 0, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(85, 24);
            btnRefresh.TabIndex = 17;
            btnRefresh.TextAlign = ContentAlignment.MiddleLeft;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // viewDentalAccount
            // 
            viewDentalAccount.AllowUserToAddRows = false;
            viewDentalAccount.AllowUserToDeleteRows = false;
            viewDentalAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewDentalAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewDentalAccount.BackgroundColor = Color.White;
            viewDentalAccount.BorderStyle = BorderStyle.None;
            viewDentalAccount.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewDentalAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            viewDentalAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            viewDentalAccount.DefaultCellStyle = dataGridViewCellStyle1;
            viewDentalAccount.Location = new Point(0, 34);
            viewDentalAccount.Name = "viewDentalAccount";
            viewDentalAccount.ReadOnly = true;
            viewDentalAccount.RowTemplate.Height = 25;
            viewDentalAccount.Size = new Size(990, 325);
            viewDentalAccount.TabIndex = 1;
            viewDentalAccount.CellContentClick += viewDentalAccount_CellContentClick;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = viewDentalAccount;
            // 
            // dentaldoctorUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 660);
            Controls.Add(btnDelete);
            Controls.Add(viewDentalAccount);
            Controls.Add(btnRefresh);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dentaldoctorUsers";
            Text = "dentaldoctorUsers";
            Load += dentaldoctorUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewDentalAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private DataGridView viewDentalAccount;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnSearchSuperAdmin;
        private TextBox txtSearchBox;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private Label label40;
    }
}