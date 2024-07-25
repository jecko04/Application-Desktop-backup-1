namespace Application_Desktop.Admin_Views
{
    partial class doctorsAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctorsAccount));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDelete = new Button();
            btnNewAccount = new Button();
            btnRefresh = new Button();
            pictureBox3 = new PictureBox();
            viewDentalDoctorAccount = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewDentalDoctorAccount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 30);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(btnNewAccount);
            flowLayoutPanel1.Controls.Add(btnRefresh);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(298, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(502, 30);
            flowLayoutPanel1.TabIndex = 1;
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
            btnDelete.Location = new Point(464, 0);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(38, 30);
            btnDelete.TabIndex = 13;
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNewAccount
            // 
            btnNewAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewAccount.BackColor = Color.FromArgb(231, 76, 60);
            btnNewAccount.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnNewAccount.FlatStyle = FlatStyle.Flat;
            btnNewAccount.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewAccount.ForeColor = SystemColors.ButtonFace;
            btnNewAccount.Image = (Image)resources.GetObject("btnNewAccount.Image");
            btnNewAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewAccount.Location = new Point(323, 0);
            btnNewAccount.Margin = new Padding(0, 0, 2, 0);
            btnNewAccount.Name = "btnNewAccount";
            btnNewAccount.Size = new Size(139, 30);
            btnNewAccount.TabIndex = 15;
            btnNewAccount.Text = "              New Account";
            btnNewAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnNewAccount.UseVisualStyleBackColor = false;
            btnNewAccount.Click += btnNewAccount_Click;
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
            btnRefresh.Location = new Point(286, 0);
            btnRefresh.Margin = new Padding(5, 0, 5, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(32, 30);
            btnRefresh.TabIndex = 17;
            btnRefresh.TextAlign = ContentAlignment.MiddleLeft;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // viewDentalDoctorAccount
            // 
            viewDentalDoctorAccount.AllowUserToAddRows = false;
            viewDentalDoctorAccount.AllowUserToDeleteRows = false;
            viewDentalDoctorAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewDentalDoctorAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewDentalDoctorAccount.BackgroundColor = SystemColors.ButtonFace;
            viewDentalDoctorAccount.BorderStyle = BorderStyle.None;
            viewDentalDoctorAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            viewDentalDoctorAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            viewDentalDoctorAccount.DefaultCellStyle = dataGridViewCellStyle1;
            viewDentalDoctorAccount.Location = new Point(-1, 32);
            viewDentalDoctorAccount.Name = "viewDentalDoctorAccount";
            viewDentalDoctorAccount.ReadOnly = true;
            viewDentalDoctorAccount.RowTemplate.Height = 25;
            viewDentalDoctorAccount.Size = new Size(800, 419);
            viewDentalDoctorAccount.TabIndex = 1;
            viewDentalDoctorAccount.CellContentClick += viewDentalDoctorAccount_CellContentClick;
            // 
            // doctorsAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewDentalDoctorAccount);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "doctorsAccount";
            Text = "doctorsAccount";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewDentalDoctorAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDelete;
        private Button btnNewAccount;
        private Button btnRefresh;
        private DataGridView viewDentalDoctorAccount;
    }
}