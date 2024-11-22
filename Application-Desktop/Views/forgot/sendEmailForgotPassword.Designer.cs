namespace Application_Desktop.Views.forgot
{
    partial class sendEmailForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendEmailForgotPassword));
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            btnLogins = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            btnClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(35, 84);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(41, 19);
            materialLabel1.TabIndex = 34;
            materialLabel1.Text = "Email";
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
            txtEmail.Location = new Point(35, 106);
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
            txtEmail.TabIndex = 33;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            txtEmail.UseTallSize = false;
            // 
            // btnLogins
            // 
            btnLogins.AutoSize = false;
            btnLogins.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogins.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogins.Depth = 0;
            btnLogins.HighEmphasis = true;
            btnLogins.Icon = null;
            btnLogins.Location = new Point(35, 151);
            btnLogins.Margin = new Padding(4, 6, 4, 6);
            btnLogins.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogins.Name = "btnLogins";
            btnLogins.NoAccentTextColor = Color.Empty;
            btnLogins.Size = new Size(500, 36);
            btnLogins.TabIndex = 35;
            btnLogins.Text = "Send Forgot Password Link";
            btnLogins.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogins.UseAccentColor = false;
            btnLogins.UseVisualStyleBackColor = true;
            btnLogins.Click += btnLogins_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            materialLabel2.Location = new Point(35, 28);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(511, 46);
            materialLabel2.TabIndex = 36;
            materialLabel2.Text = "Forgot Password?\nIf you've forgotten your password, click the \"Forgot Password\" link to reset it. You’ll receive an email with instructions to create a new password.";
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = this;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(552, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 27);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 37;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // sendEmailForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 222);
            Controls.Add(btnClose);
            Controls.Add(materialLabel2);
            Controls.Add(btnLogins);
            Controls.Add(materialLabel1);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sendEmailForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += sendEmailForgotPassword_FormClosed;
            Load += sendEmailForgotPassword_Load;
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialButton btnLogins;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private PictureBox btnClose;
    }
}