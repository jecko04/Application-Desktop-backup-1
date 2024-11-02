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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            timeVcode = new System.Windows.Forms.Timer(components);
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
            panel1.Location = new Point(-4, 360);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 86);
            panel1.TabIndex = 1;
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
            btnClose.Location = new Point(570, 12);
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
            pictureBox1.Location = new Point(46, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 66, 0);
            label1.Location = new Point(132, 47);
            label1.Name = "label1";
            label1.Size = new Size(74, 32);
            label1.TabIndex = 25;
            label1.Text = "SMTC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(41, 56, 218);
            label4.Location = new Point(202, 47);
            label4.Name = "label4";
            label4.Size = new Size(125, 32);
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
            btnLogins.Location = new Point(46, 303);
            btnLogins.Margin = new Padding(4, 6, 4, 6);
            btnLogins.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogins.Name = "btnLogins";
            btnLogins.NoAccentTextColor = Color.Empty;
            btnLogins.Size = new Size(500, 36);
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
            txtEmail.Location = new Point(46, 134);
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
            txtEmail.Size = new Size(500, 36);
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
            checkBox1.Location = new Point(46, 252);
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
            txtPass.Location = new Point(46, 206);
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
            txtPass.Size = new Size(500, 36);
            txtPass.TabIndex = 31;
            txtPass.TabStop = false;
            txtPass.TextAlign = HorizontalAlignment.Left;
            txtPass.TrailingIcon = null;
            txtPass.UseSystemPasswordChar = false;
            txtPass.UseTallSize = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(46, 112);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(41, 19);
            materialLabel1.TabIndex = 32;
            materialLabel1.Text = "Email";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(46, 184);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(71, 19);
            materialLabel2.TabIndex = 33;
            materialLabel2.Text = "Password";
            // 
            // timeVcode
            // 
            timeVcode.Interval = 1000;
            timeVcode.Tick += timeVcode_Tick;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 438);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(txtPass);
            Controls.Add(checkBox1);
            Controls.Add(txtEmail);
            Controls.Add(btnLogins);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
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
        private TextBox txtPassword;
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
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Timer timeVcode;
    }
}