namespace Application_Desktop.Views
{
    partial class loginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPage));
            panel1 = new Panel();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            checkBox1 = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            btnClose = new PictureBox();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            borderEmail = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            borderPassword = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            borderEmail.SuspendLayout();
            borderPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom;
            panel1.BackColor = Color.FromArgb(250, 220, 18);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(-17, 260);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 100);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(32, 74);
            label2.Name = "label2";
            label2.Size = new Size(38, 16);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 11.25F);
            txtEmail.Location = new Point(0, 0);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Email";
            txtEmail.Size = new Size(342, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 11.25F);
            txtPassword.Location = new Point(0, 0);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = " Password";
            txtPassword.Size = new Size(342, 27);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(32, 125);
            label3.Name = "label3";
            label3.Size = new Size(62, 16);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 66, 0);
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(255, 66, 0);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 9.75F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(64, 211);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(313, 27);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Tahoma", 8.25F);
            checkBox1.ForeColor = Color.DimGray;
            checkBox1.Location = new Point(47, 177);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 17);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
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
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(407, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 19;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = this;
            // 
            // borderEmail
            // 
            borderEmail.Controls.Add(panel6);
            borderEmail.Controls.Add(panel3);
            borderEmail.Controls.Add(panel5);
            borderEmail.Controls.Add(panel4);
            borderEmail.Controls.Add(txtEmail);
            borderEmail.Location = new Point(47, 93);
            borderEmail.Name = "borderEmail";
            borderEmail.Size = new Size(342, 27);
            borderEmail.TabIndex = 20;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(52, 152, 219);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(1, 26);
            panel6.Name = "panel6";
            panel6.Size = new Size(340, 1);
            panel6.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(52, 152, 219);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 26);
            panel3.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(52, 152, 219);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(341, 1);
            panel5.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(52, 152, 219);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(341, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 27);
            panel4.TabIndex = 22;
            // 
            // borderPassword
            // 
            borderPassword.Controls.Add(panel7);
            borderPassword.Controls.Add(panel8);
            borderPassword.Controls.Add(panel9);
            borderPassword.Controls.Add(panel10);
            borderPassword.Controls.Add(txtPassword);
            borderPassword.Location = new Point(48, 144);
            borderPassword.Name = "borderPassword";
            borderPassword.Size = new Size(342, 27);
            borderPassword.TabIndex = 23;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(52, 152, 219);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(1, 26);
            panel7.Name = "panel7";
            panel7.Size = new Size(340, 1);
            panel7.TabIndex = 22;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(52, 152, 219);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 1);
            panel8.Name = "panel8";
            panel8.Size = new Size(1, 26);
            panel8.TabIndex = 21;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(52, 152, 219);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(341, 1);
            panel9.TabIndex = 22;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(52, 152, 219);
            panel10.Dock = DockStyle.Right;
            panel10.Location = new Point(341, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1, 27);
            panel10.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 9.75F);
            label1.ForeColor = Color.FromArgb(255, 66, 0);
            label1.Location = new Point(85, 41);
            label1.Name = "label1";
            label1.Size = new Size(41, 16);
            label1.TabIndex = 25;
            label1.Text = "SMTC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(41, 56, 218);
            label4.Location = new Point(122, 41);
            label4.Name = "label4";
            label4.Size = new Size(74, 16);
            label4.TabIndex = 26;
            label4.Text = "Dental Care";
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 352);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(borderPassword);
            Controls.Add(borderEmail);
            Controls.Add(btnClose);
            Controls.Add(checkBox1);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "loginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginPage";
            Load += loginPage_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            borderEmail.ResumeLayout(false);
            borderEmail.PerformLayout();
            borderPassword.ResumeLayout(false);
            borderPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLogin;
        private CheckBox checkBox1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private PictureBox btnClose;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private Panel panel3;
        private Panel borderEmail;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel borderPassword;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label1;
    }
}