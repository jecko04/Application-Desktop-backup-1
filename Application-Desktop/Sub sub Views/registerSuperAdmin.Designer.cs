namespace Application_Desktop
{
    partial class registerSuperAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerSuperAdmin));
            panel = new Panel();
            label10 = new Label();
            btnClose = new PictureBox();
            label7 = new Label();
            txtComboBox = new ComboBox();
            txtLink = new LinkLabel();
            txtCheckBox = new CheckBox();
            btnRegister = new Button();
            txtRePwd = new TextBox();
            label5 = new Label();
            txtPwd = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            errorProvider6 = new ErrorProvider(components);
            errorProvider7 = new ErrorProvider(components);
            errorProvider8 = new ErrorProvider(components);
            errorProvider9 = new ErrorProvider(components);
            errorProvider10 = new ErrorProvider(components);
            errorProvider11 = new ErrorProvider(components);
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider11).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(248, 249, 250);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(label10);
            panel.Controls.Add(btnClose);
            panel.Controls.Add(label7);
            panel.Controls.Add(txtComboBox);
            panel.Controls.Add(txtLink);
            panel.Controls.Add(txtCheckBox);
            panel.Controls.Add(btnRegister);
            panel.Controls.Add(txtRePwd);
            panel.Controls.Add(label5);
            panel.Controls.Add(txtPwd);
            panel.Controls.Add(label6);
            panel.Controls.Add(txtEmail);
            panel.Controls.Add(label4);
            panel.Controls.Add(txtLastName);
            panel.Controls.Add(label3);
            panel.Controls.Add(txtFirstName);
            panel.Controls.Add(label2);
            panel.Controls.Add(label1);
            panel.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel.Location = new Point(1, 0);
            panel.Name = "panel";
            panel.Size = new Size(426, 499);
            panel.TabIndex = 1;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(40, 291);
            label10.Name = "label10";
            label10.Size = new Size(341, 32);
            label10.TabIndex = 55;
            label10.Text = "Password must be at least 8 characters long, including an \r\nuppercase letter, a lowercase letter, and a number.\r\n";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(397, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 20;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(27, 342);
            label7.Name = "label7";
            label7.Size = new Size(32, 16);
            label7.TabIndex = 15;
            label7.Text = "Role";
            // 
            // txtComboBox
            // 
            txtComboBox.FormattingEnabled = true;
            txtComboBox.Location = new Point(40, 361);
            txtComboBox.Name = "txtComboBox";
            txtComboBox.Size = new Size(345, 24);
            txtComboBox.TabIndex = 14;
            // 
            // txtLink
            // 
            txtLink.ActiveLinkColor = Color.FromArgb(123, 44, 191);
            txtLink.AutoSize = true;
            txtLink.Location = new Point(71, 408);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(126, 16);
            txtLink.TabIndex = 13;
            txtLink.TabStop = true;
            txtLink.Text = "Terms and Condition";
            // 
            // txtCheckBox
            // 
            txtCheckBox.AutoSize = true;
            txtCheckBox.Location = new Point(40, 408);
            txtCheckBox.Name = "txtCheckBox";
            txtCheckBox.Size = new Size(15, 14);
            txtCheckBox.TabIndex = 12;
            txtCheckBox.UseVisualStyleBackColor = true;
            txtCheckBox.CheckedChanged += txtCheckBox_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(102, 204, 102);
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(102, 204, 102);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(282, 436);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(103, 33);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtRePwd
            // 
            txtRePwd.BorderStyle = BorderStyle.FixedSingle;
            txtRePwd.Location = new Point(228, 256);
            txtRePwd.Name = "txtRePwd";
            txtRePwd.PasswordChar = '*';
            txtRePwd.PlaceholderText = " Confirm Password";
            txtRePwd.Size = new Size(157, 23);
            txtRePwd.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(210, 227);
            label5.Name = "label5";
            label5.Size = new Size(111, 16);
            label5.TabIndex = 9;
            label5.Text = "Confirm Password";
            // 
            // txtPwd
            // 
            txtPwd.BorderStyle = BorderStyle.FixedSingle;
            txtPwd.Location = new Point(40, 256);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.PlaceholderText = " Password";
            txtPwd.Size = new Size(157, 23);
            txtPwd.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(27, 227);
            label6.Name = "label6";
            label6.Size = new Size(62, 16);
            label6.TabIndex = 7;
            label6.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(40, 186);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Email";
            txtEmail.Size = new Size(345, 23);
            txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(27, 157);
            label4.Name = "label4";
            label4.Size = new Size(38, 16);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(228, 122);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = " Last Name";
            txtLastName.Size = new Size(157, 23);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(210, 93);
            label3.Name = "label3";
            label3.Size = new Size(67, 16);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(40, 122);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = " First Name";
            txtFirstName.Size = new Size(157, 23);
            txtFirstName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(27, 93);
            label2.Name = "label2";
            label2.Size = new Size(69, 16);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(163, 39);
            label1.TabIndex = 0;
            label1.Text = "REGISTER";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            errorProvider2.Icon = (Icon)resources.GetObject("errorProvider2.Icon");
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            errorProvider3.Icon = (Icon)resources.GetObject("errorProvider3.Icon");
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            errorProvider4.Icon = (Icon)resources.GetObject("errorProvider4.Icon");
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            errorProvider5.Icon = (Icon)resources.GetObject("errorProvider5.Icon");
            // 
            // errorProvider6
            // 
            errorProvider6.ContainerControl = this;
            errorProvider6.Icon = (Icon)resources.GetObject("errorProvider6.Icon");
            // 
            // errorProvider7
            // 
            errorProvider7.ContainerControl = this;
            errorProvider7.Icon = (Icon)resources.GetObject("errorProvider7.Icon");
            // 
            // errorProvider8
            // 
            errorProvider8.ContainerControl = this;
            errorProvider8.Icon = (Icon)resources.GetObject("errorProvider8.Icon");
            // 
            // errorProvider9
            // 
            errorProvider9.ContainerControl = this;
            errorProvider9.Icon = (Icon)resources.GetObject("errorProvider9.Icon");
            // 
            // errorProvider10
            // 
            errorProvider10.ContainerControl = this;
            errorProvider10.Icon = (Icon)resources.GetObject("errorProvider10.Icon");
            // 
            // errorProvider11
            // 
            errorProvider11.ContainerControl = this;
            errorProvider11.Icon = (Icon)resources.GetObject("errorProvider11.Icon");
            // 
            // registerSuperAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 500);
            Controls.Add(panel);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "registerSuperAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registerSuperAdmin";
            Load += registerSuperAdmin_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider8).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider9).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider10).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider11).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel;
        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private LinkLabel txtLink;
        private CheckBox txtCheckBox;
        private Button btnRegister;
        private TextBox txtRePwd;
        private Label label5;
        private TextBox txtPwd;
        private Label label6;
        private TextBox txtEmail;
        private Label label4;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private Label label7;
        private ComboBox txtComboBox;
        private ErrorProvider errorProvider6;
        private ErrorProvider errorProvider7;
        private ErrorProvider errorProvider8;
        private ErrorProvider errorProvider9;
        private ErrorProvider errorProvider10;
        private ErrorProvider errorProvider11;
        private PictureBox btnClose;
        private Label label10;
    }
}