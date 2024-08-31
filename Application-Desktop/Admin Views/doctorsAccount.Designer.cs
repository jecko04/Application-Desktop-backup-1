﻿namespace Application_Desktop.Admin_Views
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctorsAccount));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDelete = new Button();
            btnNewAccount = new Button();
            btnRefresh = new Button();
            viewDentalDoctorAccount = new DataGridView();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            label40 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewDentalDoctorAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label40);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 30);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(599, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(502, 30);
            flowLayoutPanel1.TabIndex = 1;
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
            btnDelete.Location = new Point(1002, 86);
            btnDelete.Margin = new Padding(0, 0, 0, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 24);
            btnDelete.TabIndex = 13;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNewAccount
            // 
            btnNewAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewAccount.BackColor = Color.FromArgb(52, 152, 219);
            btnNewAccount.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnNewAccount.FlatStyle = FlatStyle.Flat;
            btnNewAccount.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewAccount.ForeColor = SystemColors.ButtonFace;
            btnNewAccount.Location = new Point(1002, 36);
            btnNewAccount.Margin = new Padding(0, 0, 0, 1);
            btnNewAccount.Name = "btnNewAccount";
            btnNewAccount.Size = new Size(85, 24);
            btnNewAccount.TabIndex = 15;
            btnNewAccount.Text = "Create New";
            btnNewAccount.UseVisualStyleBackColor = false;
            btnNewAccount.Click += btnNewAccount_Click;
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
            btnRefresh.Location = new Point(1002, 61);
            btnRefresh.Margin = new Padding(0, 0, 0, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(85, 24);
            btnRefresh.TabIndex = 17;
            btnRefresh.TextAlign = ContentAlignment.MiddleLeft;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // viewDentalDoctorAccount
            // 
            viewDentalDoctorAccount.AllowUserToAddRows = false;
            viewDentalDoctorAccount.AllowUserToDeleteRows = false;
            viewDentalDoctorAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewDentalDoctorAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewDentalDoctorAccount.BackgroundColor = Color.White;
            viewDentalDoctorAccount.BorderStyle = BorderStyle.None;
            viewDentalDoctorAccount.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewDentalDoctorAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            viewDentalDoctorAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            viewDentalDoctorAccount.DefaultCellStyle = dataGridViewCellStyle1;
            viewDentalDoctorAccount.Location = new Point(-1, 36);
            viewDentalDoctorAccount.Margin = new Padding(0, 0, 10, 0);
            viewDentalDoctorAccount.Name = "viewDentalDoctorAccount";
            viewDentalDoctorAccount.ReadOnly = true;
            viewDentalDoctorAccount.RowTemplate.Height = 25;
            viewDentalDoctorAccount.Size = new Size(993, 325);
            viewDentalDoctorAccount.TabIndex = 1;
            viewDentalDoctorAccount.CellContentClick += viewDentalDoctorAccount_CellContentClick;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = viewDentalDoctorAccount;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label40.Location = new Point(37, 9);
            label40.Name = "label40";
            label40.Size = new Size(201, 16);
            label40.TabIndex = 89;
            label40.Text = "Dental Doctors Account Panel";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 88;
            pictureBox1.TabStop = false;
            // 
            // doctorsAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1101, 660);
            Controls.Add(btnNewAccount);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(viewDentalDoctorAccount);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "doctorsAccount";
            Text = "doctorsAccount";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewDentalDoctorAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDelete;
        private Button btnNewAccount;
        private Button btnRefresh;
        private DataGridView viewDentalDoctorAccount;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private Label label40;
        private PictureBox pictureBox1;
    }
}