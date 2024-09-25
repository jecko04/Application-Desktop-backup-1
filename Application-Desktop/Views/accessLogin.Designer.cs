namespace Application_Desktop.Views
{
    partial class accessLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accessLogin));
            panel1 = new Panel();
            btnClose = new PictureBox();
            borderPassword = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            txtPassword = new TextBox();
            borderUsername = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            txtUsername = new TextBox();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            borderPassword.SuspendLayout();
            borderUsername.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(52, 152, 219);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 30);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(387, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 2;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // borderPassword
            // 
            borderPassword.Controls.Add(panel7);
            borderPassword.Controls.Add(panel8);
            borderPassword.Controls.Add(panel9);
            borderPassword.Controls.Add(panel10);
            borderPassword.Controls.Add(txtPassword);
            borderPassword.Location = new Point(28, 109);
            borderPassword.Name = "borderPassword";
            borderPassword.Size = new Size(342, 25);
            borderPassword.TabIndex = 29;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(52, 152, 219);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(1, 24);
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
            panel8.Size = new Size(1, 24);
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
            panel10.Size = new Size(1, 25);
            panel10.TabIndex = 22;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(0, 0);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = " Password";
            txtPassword.Size = new Size(342, 25);
            txtPassword.TabIndex = 5;
            // 
            // borderUsername
            // 
            borderUsername.Controls.Add(panel6);
            borderUsername.Controls.Add(panel3);
            borderUsername.Controls.Add(panel5);
            borderUsername.Controls.Add(panel4);
            borderUsername.Controls.Add(txtUsername);
            borderUsername.Location = new Point(27, 60);
            borderUsername.Name = "borderUsername";
            borderUsername.Size = new Size(342, 25);
            borderUsername.TabIndex = 28;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(52, 152, 219);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(1, 24);
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
            panel3.Size = new Size(1, 24);
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
            panel4.Size = new Size(1, 25);
            panel4.TabIndex = 22;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(0, 0);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = " Email";
            txtUsername.Size = new Size(342, 25);
            txtUsername.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.FlatAppearance.BorderColor = Color.Black;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 9.75F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(44, 151);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(313, 27);
            btnLogin.TabIndex = 26;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(62, 16);
            label3.TabIndex = 25;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(65, 16);
            label2.TabIndex = 24;
            label2.Text = "Username";
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(98, 16);
            label1.TabIndex = 30;
            label1.Text = "Login to access.";
            label1.Click += label1_Click;
            // 
            // accessLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(409, 213);
            Controls.Add(borderPassword);
            Controls.Add(borderUsername);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "accessLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "accessLogin";
            Load += accessLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            borderPassword.ResumeLayout(false);
            borderPassword.PerformLayout();
            borderUsername.ResumeLayout(false);
            borderUsername.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox btnClose;
        private Panel borderPassword;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private TextBox txtPassword;
        private Panel borderUsername;
        private Panel panel6;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private TextBox txtUsername;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private Label label1;
    }
}