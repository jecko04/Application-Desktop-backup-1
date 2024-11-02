namespace Application_Desktop.Views
{
    partial class otp
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
            txtOtpCode = new MaterialSkin.Controls.MaterialTextBox2();
            btnVerify = new MaterialSkin.Controls.MaterialButton();
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // txtOtpCode
            // 
            txtOtpCode.AnimateReadOnly = false;
            txtOtpCode.BackgroundImageLayout = ImageLayout.None;
            txtOtpCode.CharacterCasing = CharacterCasing.Normal;
            txtOtpCode.Depth = 0;
            txtOtpCode.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtOtpCode.HideSelection = true;
            txtOtpCode.Hint = "Enter OTP";
            txtOtpCode.LeadingIcon = null;
            txtOtpCode.Location = new Point(42, 64);
            txtOtpCode.MaxLength = 32767;
            txtOtpCode.MouseState = MaterialSkin.MouseState.OUT;
            txtOtpCode.Name = "txtOtpCode";
            txtOtpCode.PasswordChar = '\0';
            txtOtpCode.PrefixSuffixText = null;
            txtOtpCode.ReadOnly = false;
            txtOtpCode.RightToLeft = RightToLeft.No;
            txtOtpCode.SelectedText = "";
            txtOtpCode.SelectionLength = 0;
            txtOtpCode.SelectionStart = 0;
            txtOtpCode.ShortcutsEnabled = true;
            txtOtpCode.Size = new Size(365, 36);
            txtOtpCode.TabIndex = 0;
            txtOtpCode.TabStop = false;
            txtOtpCode.TextAlign = HorizontalAlignment.Left;
            txtOtpCode.TrailingIcon = null;
            txtOtpCode.UseSystemPasswordChar = false;
            txtOtpCode.UseTallSize = false;
            // 
            // btnVerify
            // 
            btnVerify.AutoSize = false;
            btnVerify.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVerify.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVerify.Depth = 0;
            btnVerify.HighEmphasis = true;
            btnVerify.Icon = null;
            btnVerify.Location = new Point(42, 109);
            btnVerify.Margin = new Padding(4, 6, 4, 6);
            btnVerify.MouseState = MaterialSkin.MouseState.HOVER;
            btnVerify.Name = "btnVerify";
            btnVerify.NoAccentTextColor = Color.Empty;
            btnVerify.Size = new Size(365, 36);
            btnVerify.TabIndex = 1;
            btnVerify.Text = "Submit";
            btnVerify.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVerify.UseAccentColor = false;
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // btnLogout
            // 
            btnLogout.AutoSize = false;
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogout.Depth = 0;
            btnLogout.HighEmphasis = true;
            btnLogout.Icon = null;
            btnLogout.Location = new Point(42, 157);
            btnLogout.Margin = new Padding(4, 6, 4, 6);
            btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogout.Name = "btnLogout";
            btnLogout.NoAccentTextColor = Color.Empty;
            btnLogout.Size = new Size(365, 36);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnLogout.UseAccentColor = false;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = this;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(42, 32);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(149, 19);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "Enter Your OTP Code";
            // 
            // otp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 224);
            Controls.Add(materialLabel1);
            Controls.Add(btnLogout);
            Controls.Add(btnVerify);
            Controls.Add(txtOtpCode);
            FormBorderStyle = FormBorderStyle.None;
            Name = "otp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "otp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtOtpCode;
        private MaterialSkin.Controls.MaterialButton btnVerify;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}