namespace Application_Desktop.Admin_Views
{
    partial class adminProfileSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminProfileSettings));
            panel2 = new Panel();
            deleteAccountPanel = new Panel();
            btnDeleteAcc = new MaterialSkin.Controls.MaterialButton();
            panel31 = new Panel();
            updatePasswordPanel = new Panel();
            btnSavePassword = new MaterialSkin.Controls.MaterialButton();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            txtConfirm = new MaterialSkin.Controls.MaterialTextBox2();
            txtNew = new MaterialSkin.Controls.MaterialTextBox2();
            txtCurrent = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            profileInfoPanel = new Panel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btnProfileSaves = new MaterialSkin.Controls.MaterialButton();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            txtLastNames = new MaterialSkin.Controls.MaterialTextBox2();
            txtFirstNames = new MaterialSkin.Controls.MaterialTextBox2();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            panel1 = new Panel();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            panel2.SuspendLayout();
            deleteAccountPanel.SuspendLayout();
            updatePasswordPanel.SuspendLayout();
            profileInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoScroll = true;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(deleteAccountPanel);
            panel2.Controls.Add(panel31);
            panel2.Controls.Add(updatePasswordPanel);
            panel2.Controls.Add(profileInfoPanel);
            panel2.Location = new Point(0, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1101, 689);
            panel2.TabIndex = 22;
            panel2.Paint += panel2_Paint;
            // 
            // deleteAccountPanel
            // 
            deleteAccountPanel.BackColor = Color.White;
            deleteAccountPanel.Controls.Add(materialLabel11);
            deleteAccountPanel.Controls.Add(materialLabel12);
            deleteAccountPanel.Controls.Add(btnDeleteAcc);
            deleteAccountPanel.Location = new Point(12, 756);
            deleteAccountPanel.Name = "deleteAccountPanel";
            deleteAccountPanel.Size = new Size(899, 148);
            deleteAccountPanel.TabIndex = 78;
            // 
            // btnDeleteAcc
            // 
            btnDeleteAcc.AutoSize = false;
            btnDeleteAcc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteAcc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeleteAcc.Depth = 0;
            btnDeleteAcc.HighEmphasis = true;
            btnDeleteAcc.Icon = null;
            btnDeleteAcc.Location = new Point(27, 87);
            btnDeleteAcc.Margin = new Padding(4, 6, 4, 6);
            btnDeleteAcc.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeleteAcc.Name = "btnDeleteAcc";
            btnDeleteAcc.NoAccentTextColor = Color.Empty;
            btnDeleteAcc.Size = new Size(146, 36);
            btnDeleteAcc.TabIndex = 58;
            btnDeleteAcc.Text = "Delete Account";
            btnDeleteAcc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeleteAcc.UseAccentColor = false;
            btnDeleteAcc.UseVisualStyleBackColor = true;
            btnDeleteAcc.Click += btnDeleteAcc_Click;
            // 
            // panel31
            // 
            panel31.Location = new Point(1152, 550);
            panel31.Name = "panel31";
            panel31.Size = new Size(16, 309);
            panel31.TabIndex = 23;
            // 
            // updatePasswordPanel
            // 
            updatePasswordPanel.BackColor = Color.White;
            updatePasswordPanel.Controls.Add(btnSavePassword);
            updatePasswordPanel.Controls.Add(materialLabel10);
            updatePasswordPanel.Controls.Add(materialLabel9);
            updatePasswordPanel.Controls.Add(materialLabel8);
            updatePasswordPanel.Controls.Add(txtConfirm);
            updatePasswordPanel.Controls.Add(txtNew);
            updatePasswordPanel.Controls.Add(txtCurrent);
            updatePasswordPanel.Controls.Add(materialLabel6);
            updatePasswordPanel.Controls.Add(materialLabel7);
            updatePasswordPanel.Location = new Point(12, 351);
            updatePasswordPanel.Name = "updatePasswordPanel";
            updatePasswordPanel.Size = new Size(899, 383);
            updatePasswordPanel.TabIndex = 22;
            // 
            // btnSavePassword
            // 
            btnSavePassword.AutoSize = false;
            btnSavePassword.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSavePassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSavePassword.Depth = 0;
            btnSavePassword.HighEmphasis = true;
            btnSavePassword.Icon = null;
            btnSavePassword.Location = new Point(27, 311);
            btnSavePassword.Margin = new Padding(4, 6, 4, 6);
            btnSavePassword.MouseState = MaterialSkin.MouseState.HOVER;
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.NoAccentTextColor = Color.Empty;
            btnSavePassword.Size = new Size(116, 36);
            btnSavePassword.TabIndex = 92;
            btnSavePassword.Text = "Save";
            btnSavePassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSavePassword.UseAccentColor = false;
            btnSavePassword.UseVisualStyleBackColor = true;
            btnSavePassword.Click += btnSavePassword_Click;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(29, 230);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(132, 19);
            materialLabel10.TabIndex = 91;
            materialLabel10.Text = "Confirm Password";
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(28, 159);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(106, 19);
            materialLabel9.TabIndex = 90;
            materialLabel9.Text = "New Password";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(29, 90);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(126, 19);
            materialLabel8.TabIndex = 89;
            materialLabel8.Text = "Current Password";
            // 
            // txtConfirm
            // 
            txtConfirm.AnimateReadOnly = false;
            txtConfirm.BackgroundImageLayout = ImageLayout.None;
            txtConfirm.CharacterCasing = CharacterCasing.Normal;
            txtConfirm.Depth = 0;
            txtConfirm.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtConfirm.HideSelection = true;
            txtConfirm.LeadingIcon = null;
            txtConfirm.Location = new Point(27, 252);
            txtConfirm.MaxLength = 32767;
            txtConfirm.MouseState = MaterialSkin.MouseState.OUT;
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.PrefixSuffixText = null;
            txtConfirm.ReadOnly = false;
            txtConfirm.RightToLeft = RightToLeft.No;
            txtConfirm.SelectedText = "";
            txtConfirm.SelectionLength = 0;
            txtConfirm.SelectionStart = 0;
            txtConfirm.ShortcutsEnabled = true;
            txtConfirm.Size = new Size(626, 36);
            txtConfirm.TabIndex = 88;
            txtConfirm.TabStop = false;
            txtConfirm.TextAlign = HorizontalAlignment.Left;
            txtConfirm.TrailingIcon = null;
            txtConfirm.UseSystemPasswordChar = false;
            txtConfirm.UseTallSize = false;
            // 
            // txtNew
            // 
            txtNew.AnimateReadOnly = false;
            txtNew.BackgroundImageLayout = ImageLayout.None;
            txtNew.CharacterCasing = CharacterCasing.Normal;
            txtNew.Depth = 0;
            txtNew.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNew.HideSelection = true;
            txtNew.LeadingIcon = null;
            txtNew.Location = new Point(27, 181);
            txtNew.MaxLength = 32767;
            txtNew.MouseState = MaterialSkin.MouseState.OUT;
            txtNew.Name = "txtNew";
            txtNew.PasswordChar = '*';
            txtNew.PrefixSuffixText = null;
            txtNew.ReadOnly = false;
            txtNew.RightToLeft = RightToLeft.No;
            txtNew.SelectedText = "";
            txtNew.SelectionLength = 0;
            txtNew.SelectionStart = 0;
            txtNew.ShortcutsEnabled = true;
            txtNew.Size = new Size(626, 36);
            txtNew.TabIndex = 87;
            txtNew.TabStop = false;
            txtNew.TextAlign = HorizontalAlignment.Left;
            txtNew.TrailingIcon = null;
            txtNew.UseSystemPasswordChar = false;
            txtNew.UseTallSize = false;
            // 
            // txtCurrent
            // 
            txtCurrent.AnimateReadOnly = false;
            txtCurrent.BackgroundImageLayout = ImageLayout.None;
            txtCurrent.CharacterCasing = CharacterCasing.Normal;
            txtCurrent.Depth = 0;
            txtCurrent.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCurrent.HideSelection = true;
            txtCurrent.LeadingIcon = null;
            txtCurrent.Location = new Point(27, 112);
            txtCurrent.MaxLength = 32767;
            txtCurrent.MouseState = MaterialSkin.MouseState.OUT;
            txtCurrent.Name = "txtCurrent";
            txtCurrent.PasswordChar = '*';
            txtCurrent.PrefixSuffixText = null;
            txtCurrent.ReadOnly = false;
            txtCurrent.RightToLeft = RightToLeft.No;
            txtCurrent.SelectedText = "";
            txtCurrent.SelectionLength = 0;
            txtCurrent.SelectionStart = 0;
            txtCurrent.ShortcutsEnabled = true;
            txtCurrent.Size = new Size(626, 36);
            txtCurrent.TabIndex = 86;
            txtCurrent.TabStop = false;
            txtCurrent.TextAlign = HorizontalAlignment.Left;
            txtCurrent.TrailingIcon = null;
            txtCurrent.UseSystemPasswordChar = false;
            txtCurrent.UseTallSize = false;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel6.Location = new Point(29, 48);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(425, 17);
            materialLabel6.TabIndex = 85;
            materialLabel6.Text = "Ensure our account is using a long random password to stay secure";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(29, 19);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(125, 19);
            materialLabel7.TabIndex = 84;
            materialLabel7.Text = "Update Password";
            // 
            // profileInfoPanel
            // 
            profileInfoPanel.BackColor = Color.White;
            profileInfoPanel.Controls.Add(materialLabel5);
            profileInfoPanel.Controls.Add(materialLabel4);
            profileInfoPanel.Controls.Add(materialLabel3);
            profileInfoPanel.Controls.Add(materialLabel2);
            profileInfoPanel.Controls.Add(materialLabel1);
            profileInfoPanel.Controls.Add(btnProfileSaves);
            profileInfoPanel.Controls.Add(txtEmail);
            profileInfoPanel.Controls.Add(txtLastNames);
            profileInfoPanel.Controls.Add(txtFirstNames);
            profileInfoPanel.Location = new Point(12, 20);
            profileInfoPanel.Name = "profileInfoPanel";
            profileInfoPanel.Size = new Size(899, 308);
            profileInfoPanel.TabIndex = 21;
            profileInfoPanel.Paint += profileInfoPanel_Paint;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(27, 160);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(41, 19);
            materialLabel5.TabIndex = 86;
            materialLabel5.Text = "Email";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(361, 89);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(76, 19);
            materialLabel4.TabIndex = 85;
            materialLabel4.Text = "Last name";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(29, 92);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(76, 19);
            materialLabel3.TabIndex = 84;
            materialLabel3.Text = "First name";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel2.Location = new Point(29, 55);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(385, 17);
            materialLabel2.TabIndex = 83;
            materialLabel2.Text = "Update your account’s profile information and email address";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(29, 26);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(134, 19);
            materialLabel1.TabIndex = 82;
            materialLabel1.Text = "Profile Information";
            // 
            // btnProfileSaves
            // 
            btnProfileSaves.AutoSize = false;
            btnProfileSaves.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProfileSaves.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnProfileSaves.Depth = 0;
            btnProfileSaves.HighEmphasis = true;
            btnProfileSaves.Icon = null;
            btnProfileSaves.Location = new Point(27, 244);
            btnProfileSaves.Margin = new Padding(4, 6, 4, 6);
            btnProfileSaves.MouseState = MaterialSkin.MouseState.HOVER;
            btnProfileSaves.Name = "btnProfileSaves";
            btnProfileSaves.NoAccentTextColor = Color.Empty;
            btnProfileSaves.Size = new Size(116, 36);
            btnProfileSaves.TabIndex = 81;
            btnProfileSaves.Text = "Save";
            btnProfileSaves.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnProfileSaves.UseAccentColor = false;
            btnProfileSaves.UseVisualStyleBackColor = true;
            btnProfileSaves.Click += btnProfileSaves_Click;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(27, 182);
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
            txtEmail.Size = new Size(626, 36);
            txtEmail.TabIndex = 80;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            txtEmail.UseTallSize = false;
            // 
            // txtLastNames
            // 
            txtLastNames.AnimateReadOnly = false;
            txtLastNames.BackgroundImageLayout = ImageLayout.None;
            txtLastNames.CharacterCasing = CharacterCasing.Normal;
            txtLastNames.Depth = 0;
            txtLastNames.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLastNames.HideSelection = true;
            txtLastNames.LeadingIcon = null;
            txtLastNames.Location = new Point(361, 111);
            txtLastNames.MaxLength = 32767;
            txtLastNames.MouseState = MaterialSkin.MouseState.OUT;
            txtLastNames.Name = "txtLastNames";
            txtLastNames.PasswordChar = '\0';
            txtLastNames.PrefixSuffixText = null;
            txtLastNames.ReadOnly = false;
            txtLastNames.RightToLeft = RightToLeft.No;
            txtLastNames.SelectedText = "";
            txtLastNames.SelectionLength = 0;
            txtLastNames.SelectionStart = 0;
            txtLastNames.ShortcutsEnabled = true;
            txtLastNames.Size = new Size(292, 36);
            txtLastNames.TabIndex = 79;
            txtLastNames.TabStop = false;
            txtLastNames.TextAlign = HorizontalAlignment.Left;
            txtLastNames.TrailingIcon = null;
            txtLastNames.UseSystemPasswordChar = false;
            txtLastNames.UseTallSize = false;
            // 
            // txtFirstNames
            // 
            txtFirstNames.AnimateReadOnly = false;
            txtFirstNames.BackgroundImageLayout = ImageLayout.None;
            txtFirstNames.CharacterCasing = CharacterCasing.Normal;
            txtFirstNames.Depth = 0;
            txtFirstNames.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFirstNames.HideSelection = true;
            txtFirstNames.LeadingIcon = null;
            txtFirstNames.Location = new Point(27, 111);
            txtFirstNames.MaxLength = 32767;
            txtFirstNames.MouseState = MaterialSkin.MouseState.OUT;
            txtFirstNames.Name = "txtFirstNames";
            txtFirstNames.PasswordChar = '\0';
            txtFirstNames.PrefixSuffixText = null;
            txtFirstNames.ReadOnly = false;
            txtFirstNames.RightToLeft = RightToLeft.No;
            txtFirstNames.SelectedText = "";
            txtFirstNames.SelectionLength = 0;
            txtFirstNames.SelectionStart = 0;
            txtFirstNames.ShortcutsEnabled = true;
            txtFirstNames.Size = new Size(292, 36);
            txtFirstNames.TabIndex = 78;
            txtFirstNames.TabStop = false;
            txtFirstNames.TextAlign = HorizontalAlignment.Left;
            txtFirstNames.TrailingIcon = null;
            txtFirstNames.UseSystemPasswordChar = false;
            txtFirstNames.UseTallSize = false;
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
            // panel1
            // 
            panel1.Location = new Point(949, 829);
            panel1.Name = "panel1";
            panel1.Size = new Size(108, 122);
            panel1.TabIndex = 79;
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel11.Location = new Point(27, 54);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(548, 17);
            materialLabel11.TabIndex = 87;
            materialLabel11.Text = "Once your account is deleted all of its resources and data will be permanently deleted.";
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(27, 25);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(107, 19);
            materialLabel12.TabIndex = 86;
            materialLabel12.Text = "Delete Account";
            // 
            // adminProfileSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 660);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminProfileSettings";
            Text = "adminProfileSettings";
            Load += adminProfileSettings_Load;
            panel2.ResumeLayout(false);
            deleteAccountPanel.ResumeLayout(false);
            deleteAccountPanel.PerformLayout();
            updatePasswordPanel.ResumeLayout(false);
            updatePasswordPanel.PerformLayout();
            profileInfoPanel.ResumeLayout(false);
            profileInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel profileInfoPanel;
        private Panel borderFirst;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private TextBox txtFirstname;
        private Panel borderLast;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private TextBox txtLastname;
        private Panel updatePasswordPanel;
        private Panel panel31;
        private Panel deleteAccountPanel;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private MaterialSkin.Controls.MaterialTextBox2 txtFirstNames;
        private MaterialSkin.Controls.MaterialTextBox2 txtLastNames;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialButton btnProfileSaves;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtCurrent;
        private MaterialSkin.Controls.MaterialTextBox2 txtConfirm;
        private MaterialSkin.Controls.MaterialTextBox2 txtNew;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialButton btnSavePassword;
        private MaterialSkin.Controls.MaterialButton btnDeleteAcc;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
    }
}