﻿namespace Application_Desktop.Sub_sub_Views
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
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtShowPassword
            // 
            txtShowPassword.AutoSize = true;
            txtShowPassword.Location = new Point(21, 251);
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
            label5.Location = new Point(21, 37);
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
            btnChangePass.Location = new Point(32, 292);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(230, 33);
            btnChangePass.TabIndex = 14;
            btnChangePass.Text = "Change Password";
            btnChangePass.UseVisualStyleBackColor = false;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // txtCurrentPass
            // 
            txtCurrentPass.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentPass.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCurrentPass.Location = new Point(32, 66);
            txtCurrentPass.Name = "txtCurrentPass";
            txtCurrentPass.PasswordChar = '*';
            txtCurrentPass.PlaceholderText = "Current Password";
            txtCurrentPass.Size = new Size(230, 23);
            txtCurrentPass.TabIndex = 9;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPass.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPass.Location = new Point(32, 213);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.PlaceholderText = "Confirm New Password";
            txtConfirmPass.Size = new Size(230, 23);
            txtConfirmPass.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(21, 120);
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
            label3.Location = new Point(21, 184);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(140, 16);
            label3.TabIndex = 12;
            label3.Text = "Confirm New Password";
            // 
            // txtNewPass
            // 
            txtNewPass.BorderStyle = BorderStyle.FixedSingle;
            txtNewPass.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPass.Location = new Point(32, 149);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.PlaceholderText = "New Password";
            txtNewPass.Size = new Size(230, 23);
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
            btnClose.Location = new Point(272, 2);
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
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 30);
            panel1.TabIndex = 16;
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            errorProvider5.Icon = (Icon)resources.GetObject("errorProvider5.Icon");
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtShowPassword);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnChangePass);
            panel2.Controls.Add(txtCurrentPass);
            panel2.Controls.Add(txtConfirmPass);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtNewPass);
            panel2.Location = new Point(1, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 352);
            panel2.TabIndex = 17;
            // 
            // superadminChangePass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 383);
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
    }
}