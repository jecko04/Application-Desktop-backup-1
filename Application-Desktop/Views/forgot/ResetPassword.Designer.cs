namespace Application_Desktop.Views.forgot
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtNewPassword = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            txtConfirmPassword = new MaterialSkin.Controls.MaterialTextBox2();
            btnSubmit = new MaterialSkin.Controls.MaterialButton();
            errorProvider1 = new ErrorProvider(components);
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(25, 46);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(106, 19);
            materialLabel1.TabIndex = 36;
            materialLabel1.Text = "New Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.AnimateReadOnly = false;
            txtNewPassword.BackgroundImageLayout = ImageLayout.None;
            txtNewPassword.CharacterCasing = CharacterCasing.Normal;
            txtNewPassword.Depth = 0;
            txtNewPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNewPassword.HideSelection = true;
            txtNewPassword.LeadingIcon = null;
            txtNewPassword.Location = new Point(25, 68);
            txtNewPassword.MaxLength = 32767;
            txtNewPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.PrefixSuffixText = null;
            txtNewPassword.ReadOnly = false;
            txtNewPassword.RightToLeft = RightToLeft.No;
            txtNewPassword.SelectedText = "";
            txtNewPassword.SelectionLength = 0;
            txtNewPassword.SelectionStart = 0;
            txtNewPassword.ShortcutsEnabled = true;
            txtNewPassword.Size = new Size(403, 36);
            txtNewPassword.TabIndex = 35;
            txtNewPassword.TabStop = false;
            txtNewPassword.TextAlign = HorizontalAlignment.Left;
            txtNewPassword.TrailingIcon = null;
            txtNewPassword.UseSystemPasswordChar = false;
            txtNewPassword.UseTallSize = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(25, 114);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(132, 19);
            materialLabel2.TabIndex = 38;
            materialLabel2.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.AnimateReadOnly = false;
            txtConfirmPassword.BackgroundImageLayout = ImageLayout.None;
            txtConfirmPassword.CharacterCasing = CharacterCasing.Normal;
            txtConfirmPassword.Depth = 0;
            txtConfirmPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtConfirmPassword.HideSelection = true;
            txtConfirmPassword.LeadingIcon = null;
            txtConfirmPassword.Location = new Point(25, 136);
            txtConfirmPassword.MaxLength = 32767;
            txtConfirmPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PrefixSuffixText = null;
            txtConfirmPassword.ReadOnly = false;
            txtConfirmPassword.RightToLeft = RightToLeft.No;
            txtConfirmPassword.SelectedText = "";
            txtConfirmPassword.SelectionLength = 0;
            txtConfirmPassword.SelectionStart = 0;
            txtConfirmPassword.ShortcutsEnabled = true;
            txtConfirmPassword.Size = new Size(403, 36);
            txtConfirmPassword.TabIndex = 37;
            txtConfirmPassword.TabStop = false;
            txtConfirmPassword.TextAlign = HorizontalAlignment.Left;
            txtConfirmPassword.TrailingIcon = null;
            txtConfirmPassword.UseSystemPasswordChar = false;
            txtConfirmPassword.UseTallSize = false;
            // 
            // btnSubmit
            // 
            btnSubmit.AutoSize = false;
            btnSubmit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSubmit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSubmit.Depth = 0;
            btnSubmit.HighEmphasis = true;
            btnSubmit.Icon = null;
            btnSubmit.Location = new Point(25, 181);
            btnSubmit.Margin = new Padding(4, 6, 4, 6);
            btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            btnSubmit.Name = "btnSubmit";
            btnSubmit.NoAccentTextColor = Color.Empty;
            btnSubmit.Size = new Size(403, 36);
            btnSubmit.TabIndex = 39;
            btnSubmit.Text = "Submit New Password";
            btnSubmit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSubmit.UseAccentColor = false;
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = this;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 254);
            Controls.Add(btnSubmit);
            Controls.Add(materialLabel2);
            Controls.Add(txtConfirmPassword);
            Controls.Add(materialLabel1);
            Controls.Add(txtNewPassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPassword";
            Load += ResetPassword_Load_1;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtNewPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtConfirmPassword;
        private MaterialSkin.Controls.MaterialButton btnSubmit;
        private ErrorProvider errorProvider1;
        private ElipseToolDemo.ElipseControl elipseControl1;
    }
}