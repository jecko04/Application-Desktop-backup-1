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
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            btnClose = new PictureBox();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            btnLogins = new MaterialSkin.Controls.MaterialButton();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            checkBox1 = new MaterialSkin.Controls.MaterialCheckbox();
            txtPass = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom;
            panel1.BackColor = Color.FromArgb(250, 220, 18);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(-17, 274);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 86);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(32, 67);
            label2.Name = "label2";
            label2.Size = new Size(38, 16);
            label2.TabIndex = 2;
            label2.Text = "Email";
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
            // btnLogins
            // 
            btnLogins.AutoSize = false;
            btnLogins.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogins.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogins.Depth = 0;
            btnLogins.HighEmphasis = true;
            btnLogins.Icon = null;
            btnLogins.Location = new Point(72, 229);
            btnLogins.Margin = new Padding(4, 6, 4, 6);
            btnLogins.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogins.Name = "btnLogins";
            btnLogins.NoAccentTextColor = Color.Empty;
            btnLogins.Size = new Size(295, 36);
            btnLogins.TabIndex = 27;
            btnLogins.Text = "Login";
            btnLogins.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogins.UseAccentColor = false;
            btnLogins.UseVisualStyleBackColor = true;
            btnLogins.Click += btnLogins_Click;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(49, 86);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(341, 36);
            txtEmail.TabIndex = 28;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            txtEmail.UseTallSize = false;
            // 
            // checkBox1
            // 
            checkBox1.Depth = 0;
            checkBox1.Location = new Point(49, 183);
            checkBox1.Margin = new Padding(0);
            checkBox1.MouseLocation = new Point(-1, -1);
            checkBox1.MouseState = MaterialSkin.MouseState.HOVER;
            checkBox1.Name = "checkBox1";
            checkBox1.ReadOnly = false;
            checkBox1.Ripple = true;
            checkBox1.Size = new Size(180, 33);
            checkBox1.TabIndex = 30;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // txtPass
            // 
            txtPass.AnimateReadOnly = false;
            txtPass.BackgroundImageLayout = ImageLayout.None;
            txtPass.CharacterCasing = CharacterCasing.Normal;
            txtPass.Depth = 0;
            txtPass.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPass.HideSelection = true;
            txtPass.Hint = "Password";
            txtPass.LeadingIcon = null;
            txtPass.Location = new Point(49, 144);
            txtPass.MaxLength = 32767;
            txtPass.MouseState = MaterialSkin.MouseState.OUT;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PrefixSuffixText = null;
            txtPass.ReadOnly = false;
            txtPass.RightToLeft = RightToLeft.No;
            txtPass.SelectedText = "";
            txtPass.SelectionLength = 0;
            txtPass.SelectionStart = 0;
            txtPass.ShortcutsEnabled = true;
            txtPass.Size = new Size(341, 36);
            txtPass.TabIndex = 31;
            txtPass.TabStop = false;
            txtPass.TextAlign = HorizontalAlignment.Left;
            txtPass.TrailingIcon = null;
            txtPass.UseSystemPasswordChar = false;
            txtPass.UseTallSize = false;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 352);
            Controls.Add(txtPass);
            Controls.Add(checkBox1);
            Controls.Add(txtEmail);
            Controls.Add(btnLogins);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private PictureBox btnClose;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private Panel borderPassword;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton btnLogins;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialCheckbox checkBox1;
        private MaterialSkin.Controls.MaterialTextBox2 txtPass;
    }
}