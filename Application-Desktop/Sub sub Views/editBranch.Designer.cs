namespace Application_Desktop.Sub_sub_Views
{
    partial class editBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editBranch));
            panel1 = new Panel();
            label7 = new Label();
            btnClose = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtBname = new TextBox();
            label2 = new Label();
            txtBnum = new TextBox();
            txtBrgy = new TextBox();
            label3 = new Label();
            txtStreet = new TextBox();
            label4 = new Label();
            txtProvince = new TextBox();
            label5 = new Label();
            txtCity = new TextBox();
            label6 = new Label();
            txtPostal = new TextBox();
            label8 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 30);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(43, 11);
            label7.Name = "label7";
            label7.Size = new Size(71, 16);
            label7.TabIndex = 18;
            label7.Text = "Edit Branch";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(443, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 18;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(91, 16);
            label1.TabIndex = 2;
            label1.Text = "Branch Name*";
            // 
            // txtBname
            // 
            txtBname.BorderStyle = BorderStyle.FixedSingle;
            txtBname.Cursor = Cursors.IBeam;
            txtBname.Location = new Point(193, 29);
            txtBname.Name = "txtBname";
            txtBname.Size = new Size(253, 23);
            txtBname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(148, 16);
            label2.TabIndex = 4;
            label2.Text = "House/Building Number*";
            // 
            // txtBnum
            // 
            txtBnum.BorderStyle = BorderStyle.FixedSingle;
            txtBnum.Cursor = Cursors.IBeam;
            txtBnum.Location = new Point(193, 79);
            txtBnum.Name = "txtBnum";
            txtBnum.Size = new Size(253, 23);
            txtBnum.TabIndex = 5;
            // 
            // txtBrgy
            // 
            txtBrgy.BorderStyle = BorderStyle.FixedSingle;
            txtBrgy.Cursor = Cursors.IBeam;
            txtBrgy.Location = new Point(193, 181);
            txtBrgy.Name = "txtBrgy";
            txtBrgy.Size = new Size(253, 23);
            txtBrgy.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 181);
            label3.Name = "label3";
            label3.Size = new Size(68, 16);
            label3.TabIndex = 8;
            label3.Text = "Barangay*";
            // 
            // txtStreet
            // 
            txtStreet.BorderStyle = BorderStyle.FixedSingle;
            txtStreet.Cursor = Cursors.IBeam;
            txtStreet.Location = new Point(193, 131);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(253, 23);
            txtStreet.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 131);
            label4.Name = "label4";
            label4.Size = new Size(50, 16);
            label4.TabIndex = 6;
            label4.Text = "Street*";
            // 
            // txtProvince
            // 
            txtProvince.BorderStyle = BorderStyle.FixedSingle;
            txtProvince.Cursor = Cursors.IBeam;
            txtProvince.Location = new Point(193, 285);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(253, 23);
            txtProvince.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 285);
            label5.Name = "label5";
            label5.Size = new Size(63, 16);
            label5.TabIndex = 12;
            label5.Text = "Province*";
            // 
            // txtCity
            // 
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Cursor = Cursors.IBeam;
            txtCity.Location = new Point(193, 235);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(253, 23);
            txtCity.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 235);
            label6.Name = "label6";
            label6.Size = new Size(36, 16);
            label6.TabIndex = 10;
            label6.Text = "City*";
            // 
            // txtPostal
            // 
            txtPostal.BorderStyle = BorderStyle.FixedSingle;
            txtPostal.Cursor = Cursors.IBeam;
            txtPostal.Location = new Point(193, 343);
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(253, 23);
            txtPostal.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(12, 343);
            label8.Name = "label8";
            label8.Size = new Size(82, 16);
            label8.TabIndex = 14;
            label8.Text = "Postal Code*";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(102, 204, 102);
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(102, 204, 102);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(378, 388);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(58, 30);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(304, 388);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(58, 30);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(txtBname);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtPostal);
            panel2.Controls.Add(txtBnum);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtProvince);
            panel2.Controls.Add(txtStreet);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtCity);
            panel2.Controls.Add(txtBrgy);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(1, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(466, 438);
            panel2.TabIndex = 18;
            // 
            // editBranch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 467);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "editBranch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "editBranch";
            Load += editBranch_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtBname;
        private Label label2;
        private TextBox txtBnum;
        private TextBox txtBrgy;
        private Label label3;
        private TextBox txtStreet;
        private Label label4;
        private TextBox txtProvince;
        private Label label5;
        private TextBox txtCity;
        private Label label6;
        private TextBox txtPostal;
        private Label label8;
        private Button btnSave;
        private Button btnCancel;
        private PictureBox pictureBox1;
        private Label label7;
        private PictureBox btnClose;
        private Panel panel2;
    }
}