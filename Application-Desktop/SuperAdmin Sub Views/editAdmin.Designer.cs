namespace Application_Desktop.Sub_sub_Views
{
    partial class editAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editAdmin));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            panel2 = new Panel();
            borderRole = new Panel();
            panel24 = new Panel();
            panel25 = new Panel();
            panel26 = new Panel();
            panel27 = new Panel();
            txtRoles = new ComboBox();
            borderEmail = new Panel();
            panel19 = new Panel();
            panel20 = new Panel();
            panel21 = new Panel();
            panel22 = new Panel();
            txtEmail = new TextBox();
            borderLast = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            txtLastName = new TextBox();
            borderFirst = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            txtfirstName = new TextBox();
            borderBranch = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            txtBranch = new ComboBox();
            txtPassword = new TextBox();
            button1 = new Button();
            btnUpdate = new Button();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            errorProvider6 = new ErrorProvider(components);
            errorProvider7 = new ErrorProvider(components);
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel2.SuspendLayout();
            borderRole.SuspendLayout();
            borderEmail.SuspendLayout();
            borderLast.SuspendLayout();
            borderFirst.SuspendLayout();
            borderBranch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(52, 152, 219);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 30);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F);
            label1.ForeColor = SystemColors.InactiveBorder;
            label1.Location = new Point(33, 12);
            label1.Name = "label1";
            label1.Size = new Size(78, 14);
            label1.TabIndex = 3;
            label1.Text = "Edit Account";
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
            btnClose.Location = new Point(398, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(borderRole);
            panel2.Controls.Add(borderEmail);
            panel2.Controls.Add(borderLast);
            panel2.Controls.Add(borderFirst);
            panel2.Controls.Add(borderBranch);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(425, 406);
            panel2.TabIndex = 2;
            // 
            // borderRole
            // 
            borderRole.Controls.Add(panel24);
            borderRole.Controls.Add(panel25);
            borderRole.Controls.Add(panel26);
            borderRole.Controls.Add(panel27);
            borderRole.Controls.Add(txtRoles);
            borderRole.Location = new Point(33, 240);
            borderRole.Name = "borderRole";
            borderRole.Size = new Size(347, 25);
            borderRole.TabIndex = 23;
            // 
            // panel24
            // 
            panel24.BackColor = Color.FromArgb(52, 152, 219);
            panel24.Dock = DockStyle.Bottom;
            panel24.Location = new Point(1, 24);
            panel24.Name = "panel24";
            panel24.Size = new Size(345, 1);
            panel24.TabIndex = 21;
            // 
            // panel25
            // 
            panel25.BackColor = Color.FromArgb(52, 152, 219);
            panel25.Dock = DockStyle.Top;
            panel25.Location = new Point(1, 0);
            panel25.Name = "panel25";
            panel25.Size = new Size(345, 1);
            panel25.TabIndex = 22;
            // 
            // panel26
            // 
            panel26.BackColor = Color.FromArgb(52, 152, 219);
            panel26.Dock = DockStyle.Right;
            panel26.Location = new Point(346, 0);
            panel26.Name = "panel26";
            panel26.Size = new Size(1, 25);
            panel26.TabIndex = 22;
            // 
            // panel27
            // 
            panel27.BackColor = Color.FromArgb(52, 152, 219);
            panel27.Dock = DockStyle.Left;
            panel27.Location = new Point(0, 0);
            panel27.Name = "panel27";
            panel27.Size = new Size(1, 25);
            panel27.TabIndex = 22;
            // 
            // txtRoles
            // 
            txtRoles.Dock = DockStyle.Fill;
            txtRoles.Font = new Font("Segoe UI", 9.75F);
            txtRoles.FormattingEnabled = true;
            txtRoles.Location = new Point(0, 0);
            txtRoles.Name = "txtRoles";
            txtRoles.Size = new Size(347, 25);
            txtRoles.TabIndex = 9;
            // 
            // borderEmail
            // 
            borderEmail.Controls.Add(panel19);
            borderEmail.Controls.Add(panel20);
            borderEmail.Controls.Add(panel21);
            borderEmail.Controls.Add(panel22);
            borderEmail.Controls.Add(txtEmail);
            borderEmail.Location = new Point(34, 137);
            borderEmail.Name = "borderEmail";
            borderEmail.Size = new Size(347, 25);
            borderEmail.TabIndex = 24;
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(52, 152, 219);
            panel19.Dock = DockStyle.Bottom;
            panel19.Location = new Point(1, 24);
            panel19.Name = "panel19";
            panel19.Size = new Size(345, 1);
            panel19.TabIndex = 21;
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(52, 152, 219);
            panel20.Dock = DockStyle.Top;
            panel20.Location = new Point(1, 0);
            panel20.Name = "panel20";
            panel20.Size = new Size(345, 1);
            panel20.TabIndex = 22;
            // 
            // panel21
            // 
            panel21.BackColor = Color.FromArgb(52, 152, 219);
            panel21.Dock = DockStyle.Right;
            panel21.Location = new Point(346, 0);
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
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 9.75F);
            txtEmail.Location = new Point(0, 0);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(347, 25);
            txtEmail.TabIndex = 5;
            // 
            // borderLast
            // 
            borderLast.Controls.Add(panel14);
            borderLast.Controls.Add(panel15);
            borderLast.Controls.Add(panel16);
            borderLast.Controls.Add(panel17);
            borderLast.Controls.Add(txtLastName);
            borderLast.Location = new Point(223, 68);
            borderLast.Name = "borderLast";
            borderLast.Size = new Size(157, 25);
            borderLast.TabIndex = 23;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(52, 152, 219);
            panel14.Dock = DockStyle.Bottom;
            panel14.Location = new Point(1, 24);
            panel14.Name = "panel14";
            panel14.Size = new Size(155, 1);
            panel14.TabIndex = 21;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(52, 152, 219);
            panel15.Dock = DockStyle.Top;
            panel15.Location = new Point(1, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(155, 1);
            panel15.TabIndex = 22;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(52, 152, 219);
            panel16.Dock = DockStyle.Right;
            panel16.Location = new Point(156, 0);
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
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Font = new Font("Segoe UI", 9.75F);
            txtLastName.Location = new Point(0, 0);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last name";
            txtLastName.Size = new Size(157, 25);
            txtLastName.TabIndex = 3;
            // 
            // borderFirst
            // 
            borderFirst.Controls.Add(panel9);
            borderFirst.Controls.Add(panel10);
            borderFirst.Controls.Add(panel11);
            borderFirst.Controls.Add(panel12);
            borderFirst.Controls.Add(txtfirstName);
            borderFirst.Location = new Point(32, 68);
            borderFirst.Name = "borderFirst";
            borderFirst.Size = new Size(157, 25);
            borderFirst.TabIndex = 23;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(52, 152, 219);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(1, 24);
            panel9.Name = "panel9";
            panel9.Size = new Size(155, 1);
            panel9.TabIndex = 21;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(52, 152, 219);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(1, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(155, 1);
            panel10.TabIndex = 22;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(52, 152, 219);
            panel11.Dock = DockStyle.Right;
            panel11.Location = new Point(156, 0);
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
            // txtfirstName
            // 
            txtfirstName.BorderStyle = BorderStyle.FixedSingle;
            txtfirstName.Dock = DockStyle.Fill;
            txtfirstName.Font = new Font("Segoe UI", 9.75F);
            txtfirstName.Location = new Point(0, 0);
            txtfirstName.Name = "txtfirstName";
            txtfirstName.PlaceholderText = "First name";
            txtfirstName.Size = new Size(157, 25);
            txtfirstName.TabIndex = 1;
            // 
            // borderBranch
            // 
            borderBranch.Controls.Add(panel4);
            borderBranch.Controls.Add(panel7);
            borderBranch.Controls.Add(panel6);
            borderBranch.Controls.Add(panel5);
            borderBranch.Controls.Add(txtBranch);
            borderBranch.Location = new Point(33, 303);
            borderBranch.Name = "borderBranch";
            borderBranch.Size = new Size(347, 25);
            borderBranch.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(52, 152, 219);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(1, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(345, 1);
            panel4.TabIndex = 21;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(52, 152, 219);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(1, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(345, 1);
            panel7.TabIndex = 22;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(52, 152, 219);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(346, 0);
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
            // txtBranch
            // 
            txtBranch.Dock = DockStyle.Fill;
            txtBranch.Font = new Font("Segoe UI", 9.75F);
            txtBranch.FormattingEnabled = true;
            txtBranch.Location = new Point(0, 0);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(347, 25);
            txtBranch.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Tahoma", 9.75F);
            txtPassword.Location = new Point(33, 168);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(347, 23);
            txtPassword.TabIndex = 19;
            txtPassword.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(231, 76, 60);
            button1.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(263, 349);
            button1.Margin = new Padding(0, 0, 1, 0);
            button1.Name = "button1";
            button1.Size = new Size(58, 24);
            button1.TabIndex = 17;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(102, 204, 102);
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(102, 204, 102);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 9F);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(322, 349);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(58, 24);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Submit";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(22, 268);
            label7.Name = "label7";
            label7.Size = new Size(101, 16);
            label7.TabIndex = 12;
            label7.Text = "Change Branch*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(22, 209);
            label6.Name = "label6";
            label6.Size = new Size(40, 16);
            label6.TabIndex = 10;
            label6.Text = "Role*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(22, 110);
            label4.Name = "label4";
            label4.Size = new Size(46, 16);
            label4.TabIndex = 4;
            label4.Text = "Email*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(212, 39);
            label3.Name = "label3";
            label3.Size = new Size(74, 16);
            label3.TabIndex = 2;
            label3.Text = "Last name*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(22, 39);
            label2.Name = "label2";
            label2.Size = new Size(76, 16);
            label2.TabIndex = 0;
            label2.Text = "First name*";
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
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = this;
            // 
            // editAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 436);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "editAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "editAdmin";
            Load += editAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            borderRole.ResumeLayout(false);
            borderEmail.ResumeLayout(false);
            borderEmail.PerformLayout();
            borderLast.ResumeLayout(false);
            borderLast.PerformLayout();
            borderFirst.ResumeLayout(false);
            borderFirst.PerformLayout();
            borderBranch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox btnClose;
        private Panel panel2;
        private Label label7;
        private ComboBox txtBranch;
        private Label label6;
        private ComboBox txtRoles;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtfirstName;
        private Label label2;
        private Button button1;
        private Button btnUpdate;
        private TextBox txtPassword;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private ErrorProvider errorProvider6;
        private ErrorProvider errorProvider7;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private Panel borderRole;
        private Panel panel24;
        private Panel panel25;
        private Panel panel26;
        private Panel panel27;
        private Panel borderEmail;
        private Panel panel19;
        private Panel panel20;
        private Panel panel21;
        private Panel panel22;
        private Panel borderLast;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel borderFirst;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel borderBranch;
        private Panel panel4;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
    }
}