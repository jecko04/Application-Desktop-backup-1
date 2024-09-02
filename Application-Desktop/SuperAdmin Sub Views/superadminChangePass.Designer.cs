namespace Application_Desktop.Sub_sub_Views
{
    partial class superadminChangePass
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(superadminChangePass));
            txtShowPassword = new CheckBox();
            errorProvider4 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider1 = new ErrorProvider(components);
            label5 = new Label();
            btnChangePass = new Button();
            txtCurrentPass = new TextBox();
            txtConfirmPass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtNewPass = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            panel1 = new Panel();
            errorProvider5 = new ErrorProvider(components);
            panel2 = new Panel();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            borderRepass = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            borderCurrent = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            borderNew = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            panel2.SuspendLayout();
            borderRepass.SuspendLayout();
            borderCurrent.SuspendLayout();
            borderNew.SuspendLayout();
            SuspendLayout();
            // 
            // txtShowPassword
            // 
            txtShowPassword.AutoSize = true;
            txtShowPassword.ForeColor = Color.DimGray;
            txtShowPassword.Location = new Point(33, 100);
            txtShowPassword.Name = "txtShowPassword";
            txtShowPassword.Size = new Size(108, 19);
            txtShowPassword.TabIndex = 15;
            txtShowPassword.Text = "Show Password";
            txtShowPassword.UseVisualStyleBackColor = true;
            txtShowPassword.CheckedChanged += txtShowPassword_CheckedChanged;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            errorProvider4.Icon = (Icon)resources.GetObject("errorProvider4.Icon");
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            errorProvider3.Icon = (Icon)resources.GetObject("errorProvider3.Icon");
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            errorProvider2.Icon = (Icon)resources.GetObject("errorProvider2.Icon");
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(22, 26);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(109, 16);
            label5.TabIndex = 8;
            label5.Text = "Current Password";
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = Color.FromArgb(102, 204, 102);
            btnChangePass.FlatAppearance.BorderColor = Color.FromArgb(102, 204, 102);
            btnChangePass.FlatStyle = FlatStyle.Flat;
            btnChangePass.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangePass.ForeColor = Color.White;
            btnChangePass.Location = new Point(733, 95);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(63, 24);
            btnChangePass.TabIndex = 14;
            btnChangePass.Text = "Save";
            btnChangePass.UseVisualStyleBackColor = false;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // txtCurrentPass
            // 
            txtCurrentPass.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentPass.Dock = DockStyle.Fill;
            txtCurrentPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCurrentPass.Location = new Point(0, 0);
            txtCurrentPass.Name = "txtCurrentPass";
            txtCurrentPass.PasswordChar = '*';
            txtCurrentPass.PlaceholderText = "Current Password";
            txtCurrentPass.Size = new Size(230, 25);
            txtCurrentPass.TabIndex = 9;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPass.Dock = DockStyle.Fill;
            txtConfirmPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPass.Location = new Point(0, 0);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.PlaceholderText = "Confirm New Password";
            txtConfirmPass.Size = new Size(230, 25);
            txtConfirmPass.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(287, 26);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(91, 16);
            label2.TabIndex = 10;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(555, 26);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(140, 16);
            label3.TabIndex = 12;
            label3.Text = "Confirm New Password";
            // 
            // txtNewPass
            // 
            txtNewPass.BorderStyle = BorderStyle.FixedSingle;
            txtNewPass.Dock = DockStyle.Fill;
            txtNewPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPass.Location = new Point(0, 0);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.PlaceholderText = "New Password";
            txtNewPass.Size = new Size(230, 25);
            txtNewPass.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InactiveBorder;
            label1.Location = new Point(33, 12);
            label1.Name = "label1";
            label1.Size = new Size(103, 14);
            label1.TabIndex = 3;
            label1.Text = "Change Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(820, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 152, 219);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 30);
            panel1.TabIndex = 16;
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            errorProvider5.Icon = (Icon)resources.GetObject("errorProvider5.Icon");
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(borderNew);
            panel2.Controls.Add(borderCurrent);
            panel2.Controls.Add(borderRepass);
            panel2.Controls.Add(txtShowPassword);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnChangePass);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(847, 148);
            panel2.TabIndex = 17;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = this;
            // 
            // borderRepass
            // 
            borderRepass.Controls.Add(panel4);
            borderRepass.Controls.Add(panel7);
            borderRepass.Controls.Add(panel6);
            borderRepass.Controls.Add(panel5);
            borderRepass.Controls.Add(txtConfirmPass);
            borderRepass.Location = new Point(566, 55);
            borderRepass.Name = "borderRepass";
            borderRepass.Size = new Size(230, 25);
            borderRepass.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(52, 152, 219);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(1, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(228, 1);
            panel4.TabIndex = 17;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(52, 152, 219);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1, 25);
            panel5.TabIndex = 18;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(52, 152, 219);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(229, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 25);
            panel6.TabIndex = 18;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(52, 152, 219);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(1, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(228, 1);
            panel7.TabIndex = 18;
            // 
            // borderCurrent
            // 
            borderCurrent.Controls.Add(panel9);
            borderCurrent.Controls.Add(panel10);
            borderCurrent.Controls.Add(panel11);
            borderCurrent.Controls.Add(panel12);
            borderCurrent.Controls.Add(txtCurrentPass);
            borderCurrent.Location = new Point(33, 55);
            borderCurrent.Name = "borderCurrent";
            borderCurrent.Size = new Size(230, 25);
            borderCurrent.TabIndex = 19;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(52, 152, 219);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(1, 24);
            panel9.Name = "panel9";
            panel9.Size = new Size(228, 1);
            panel9.TabIndex = 17;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(52, 152, 219);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(1, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(228, 1);
            panel10.TabIndex = 18;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(52, 152, 219);
            panel11.Dock = DockStyle.Right;
            panel11.Location = new Point(229, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(1, 25);
            panel11.TabIndex = 18;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(52, 152, 219);
            panel12.Dock = DockStyle.Left;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(1, 25);
            panel12.TabIndex = 18;
            // 
            // borderNew
            // 
            borderNew.Controls.Add(panel13);
            borderNew.Controls.Add(panel14);
            borderNew.Controls.Add(panel15);
            borderNew.Controls.Add(panel16);
            borderNew.Controls.Add(txtNewPass);
            borderNew.Location = new Point(299, 55);
            borderNew.Name = "borderNew";
            borderNew.Size = new Size(230, 25);
            borderNew.TabIndex = 20;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(52, 152, 219);
            panel13.Dock = DockStyle.Bottom;
            panel13.Location = new Point(1, 24);
            panel13.Name = "panel13";
            panel13.Size = new Size(228, 1);
            panel13.TabIndex = 17;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(52, 152, 219);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(1, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(228, 1);
            panel14.TabIndex = 18;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(52, 152, 219);
            panel15.Dock = DockStyle.Right;
            panel15.Location = new Point(229, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(1, 25);
            panel15.TabIndex = 18;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(52, 152, 219);
            panel16.Dock = DockStyle.Left;
            panel16.Location = new Point(0, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(1, 25);
            panel16.TabIndex = 18;
            // 
            // superadminChangePass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 177);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "superadminChangePass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "superadminChangePass";
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            borderRepass.ResumeLayout(false);
            borderRepass.PerformLayout();
            borderCurrent.ResumeLayout(false);
            borderCurrent.PerformLayout();
            borderNew.ResumeLayout(false);
            borderNew.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox txtShowPassword;
        private ErrorProvider errorProvider4;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox btnClose;
        private Panel panel2;
        private Label label5;
        private Button btnChangePass;
        private TextBox txtCurrentPass;
        private TextBox txtConfirmPass;
        private Label label2;
        private Label label3;
        private TextBox txtNewPass;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider5;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private Panel borderRepass;
        private Panel panel4;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel borderNew;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel borderCurrent;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
    }
}