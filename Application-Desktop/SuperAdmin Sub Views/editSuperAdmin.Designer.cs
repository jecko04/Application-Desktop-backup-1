namespace Application_Desktop.Sub_sub_Views
{
    partial class editSuperAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editSuperAdmin));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtRoles = new ComboBox();
            btnUpdate = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            panel2 = new Panel();
            borderRole = new Panel();
            panel19 = new Panel();
            panel20 = new Panel();
            panel21 = new Panel();
            panel22 = new Panel();
            borderEmail = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            borderLast = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            borderFirst = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            panel2.SuspendLayout();
            borderRole.SuspendLayout();
            borderEmail.SuspendLayout();
            borderLast.SuspendLayout();
            borderFirst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(41, 56, 218);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 32);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 10);
            label1.Name = "label1";
            label1.Size = new Size(106, 16);
            label1.TabIndex = 3;
            label1.Text = "Edit Super Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(951, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(25, 31);
            label2.Name = "label2";
            label2.Size = new Size(76, 16);
            label2.TabIndex = 1;
            label2.Text = "First name*";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Dock = DockStyle.Fill;
            txtFirstName.Font = new Font("Segoe UI", 9.75F);
            txtFirstName.Location = new Point(1, 0);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = " First name";
            txtFirstName.Size = new Size(142, 25);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Font = new Font("Segoe UI", 9.75F);
            txtLastName.Location = new Point(0, 0);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = " Last name";
            txtLastName.Size = new Size(144, 25);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(204, 31);
            label3.Name = "label3";
            label3.Size = new Size(74, 16);
            label3.TabIndex = 3;
            label3.Text = "Last name*";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 9.75F);
            txtEmail.Location = new Point(0, 0);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Email";
            txtEmail.Size = new Size(323, 25);
            txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(390, 31);
            label4.Name = "label4";
            label4.Size = new Size(46, 16);
            label4.TabIndex = 5;
            label4.Text = "Email*";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(406, 93);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(323, 23);
            txtPassword.TabIndex = 7;
            txtPassword.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(754, 29);
            label5.Name = "label5";
            label5.Size = new Size(32, 16);
            label5.TabIndex = 8;
            label5.Text = "Role";
            // 
            // txtRoles
            // 
            txtRoles.Dock = DockStyle.Fill;
            txtRoles.Font = new Font("Segoe UI", 9.75F);
            txtRoles.FormattingEnabled = true;
            txtRoles.Location = new Point(0, 0);
            txtRoles.Name = "txtRoles";
            txtRoles.Size = new Size(165, 25);
            txtRoles.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(102, 204, 102);
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(102, 204, 102);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 9F);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(881, 107);
            btnUpdate.Margin = new Padding(0, 1, 0, 0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(58, 24);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Submit";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(borderRole);
            panel2.Controls.Add(borderEmail);
            panel2.Controls.Add(borderLast);
            panel2.Controls.Add(borderFirst);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtPassword);
            panel2.Location = new Point(-2, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(978, 163);
            panel2.TabIndex = 20;
            // 
            // borderRole
            // 
            borderRole.Controls.Add(panel19);
            borderRole.Controls.Add(panel20);
            borderRole.Controls.Add(panel21);
            borderRole.Controls.Add(panel22);
            borderRole.Controls.Add(txtRoles);
            borderRole.Location = new Point(774, 64);
            borderRole.Name = "borderRole";
            borderRole.Size = new Size(165, 25);
            borderRole.TabIndex = 25;
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(52, 152, 219);
            panel19.Dock = DockStyle.Bottom;
            panel19.Location = new Point(1, 24);
            panel19.Name = "panel19";
            panel19.Size = new Size(163, 1);
            panel19.TabIndex = 21;
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(52, 152, 219);
            panel20.Dock = DockStyle.Top;
            panel20.Location = new Point(1, 0);
            panel20.Name = "panel20";
            panel20.Size = new Size(163, 1);
            panel20.TabIndex = 22;
            // 
            // panel21
            // 
            panel21.BackColor = Color.FromArgb(52, 152, 219);
            panel21.Dock = DockStyle.Right;
            panel21.Location = new Point(164, 0);
            panel21.Name = "panel21";
            panel21.Size = new Size(1, 25);
            panel21.TabIndex = 22;
            // 
            // panel22
            // 
            panel22.BackColor = Color.FromArgb(52, 152, 219);
            panel22.Dock = DockStyle.Left;
            panel22.Location = new Point(0, 0);
            panel22.Name = "panel22";
            panel22.Size = new Size(1, 25);
            panel22.TabIndex = 22;
            // 
            // borderEmail
            // 
            borderEmail.Controls.Add(panel14);
            borderEmail.Controls.Add(panel15);
            borderEmail.Controls.Add(panel16);
            borderEmail.Controls.Add(panel17);
            borderEmail.Controls.Add(txtEmail);
            borderEmail.Location = new Point(406, 64);
            borderEmail.Name = "borderEmail";
            borderEmail.Size = new Size(323, 25);
            borderEmail.TabIndex = 24;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(52, 152, 219);
            panel14.Dock = DockStyle.Bottom;
            panel14.Location = new Point(1, 24);
            panel14.Name = "panel14";
            panel14.Size = new Size(321, 1);
            panel14.TabIndex = 21;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(52, 152, 219);
            panel15.Dock = DockStyle.Top;
            panel15.Location = new Point(1, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(321, 1);
            panel15.TabIndex = 22;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(52, 152, 219);
            panel16.Dock = DockStyle.Right;
            panel16.Location = new Point(322, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(1, 25);
            panel16.TabIndex = 22;
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(52, 152, 219);
            panel17.Dock = DockStyle.Left;
            panel17.Location = new Point(0, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(1, 25);
            panel17.TabIndex = 22;
            // 
            // borderLast
            // 
            borderLast.Controls.Add(panel9);
            borderLast.Controls.Add(panel10);
            borderLast.Controls.Add(panel11);
            borderLast.Controls.Add(panel12);
            borderLast.Controls.Add(txtLastName);
            borderLast.Location = new Point(221, 64);
            borderLast.Name = "borderLast";
            borderLast.Size = new Size(144, 25);
            borderLast.TabIndex = 23;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(52, 152, 219);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(1, 24);
            panel9.Name = "panel9";
            panel9.Size = new Size(142, 1);
            panel9.TabIndex = 21;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(52, 152, 219);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(1, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(142, 1);
            panel10.TabIndex = 22;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(52, 152, 219);
            panel11.Dock = DockStyle.Right;
            panel11.Location = new Point(143, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(1, 25);
            panel11.TabIndex = 22;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(52, 152, 219);
            panel12.Dock = DockStyle.Left;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(1, 25);
            panel12.TabIndex = 22;
            // 
            // borderFirst
            // 
            borderFirst.Controls.Add(panel4);
            borderFirst.Controls.Add(panel7);
            borderFirst.Controls.Add(txtFirstName);
            borderFirst.Controls.Add(panel6);
            borderFirst.Controls.Add(panel5);
            borderFirst.Location = new Point(43, 64);
            borderFirst.Name = "borderFirst";
            borderFirst.Size = new Size(144, 25);
            borderFirst.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(52, 152, 219);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(1, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(142, 1);
            panel4.TabIndex = 21;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(52, 152, 219);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(1, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(142, 1);
            panel7.TabIndex = 22;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(52, 152, 219);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(143, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 25);
            panel6.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(52, 152, 219);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1, 25);
            panel5.TabIndex = 22;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = this;
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
            // editSuperAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 193);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 9.75F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "editSuperAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "editSuperAdmin";
            Load += editSuperAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            borderRole.ResumeLayout(false);
            borderEmail.ResumeLayout(false);
            borderEmail.PerformLayout();
            borderLast.ResumeLayout(false);
            borderLast.PerformLayout();
            borderFirst.ResumeLayout(false);
            borderFirst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPassword;
        private Label label5;
        private ComboBox txtRoles;
        private Button btnUpdate;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Panel panel2;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private Panel borderFirst;
        private Panel panel4;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel borderEmail;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel borderLast;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel borderRole;
        private Panel panel19;
        private Panel panel20;
        private Panel panel21;
        private Panel panel22;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
    }
}