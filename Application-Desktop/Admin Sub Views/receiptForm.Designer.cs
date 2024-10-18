namespace Application_Desktop.Admin_Sub_Views
{
    partial class receiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receiptForm));
            btnPrintReceipt = new MaterialSkin.Controls.MaterialButton();
            txtFullname = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            txtBranch = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            txtServices = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            txtStatus = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            txtPrice = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            txtExtraFee = new MaterialSkin.Controls.MaterialTextBox2();
            txtTotal = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            btnClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // btnPrintReceipt
            // 
            btnPrintReceipt.AutoSize = false;
            btnPrintReceipt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPrintReceipt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPrintReceipt.Depth = 0;
            btnPrintReceipt.HighEmphasis = true;
            btnPrintReceipt.Icon = null;
            btnPrintReceipt.Location = new Point(127, 449);
            btnPrintReceipt.Margin = new Padding(4, 6, 4, 6);
            btnPrintReceipt.MouseState = MaterialSkin.MouseState.HOVER;
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.NoAccentTextColor = Color.Empty;
            btnPrintReceipt.Size = new Size(183, 36);
            btnPrintReceipt.TabIndex = 0;
            btnPrintReceipt.Text = "Print Receipt";
            btnPrintReceipt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPrintReceipt.UseAccentColor = false;
            btnPrintReceipt.UseVisualStyleBackColor = true;
            btnPrintReceipt.Click += btnPrintReceipt_Click;
            // 
            // txtFullname
            // 
            txtFullname.AnimateReadOnly = false;
            txtFullname.BackgroundImageLayout = ImageLayout.None;
            txtFullname.CharacterCasing = CharacterCasing.Normal;
            txtFullname.Depth = 0;
            txtFullname.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFullname.HideSelection = true;
            txtFullname.LeadingIcon = null;
            txtFullname.Location = new Point(41, 95);
            txtFullname.MaxLength = 32767;
            txtFullname.MouseState = MaterialSkin.MouseState.OUT;
            txtFullname.Name = "txtFullname";
            txtFullname.PasswordChar = '\0';
            txtFullname.PrefixSuffixText = null;
            txtFullname.ReadOnly = false;
            txtFullname.RightToLeft = RightToLeft.No;
            txtFullname.SelectedText = "";
            txtFullname.SelectionLength = 0;
            txtFullname.SelectionStart = 0;
            txtFullname.ShortcutsEnabled = true;
            txtFullname.Size = new Size(355, 36);
            txtFullname.TabIndex = 1;
            txtFullname.TabStop = false;
            txtFullname.TextAlign = HorizontalAlignment.Left;
            txtFullname.TrailingIcon = null;
            txtFullname.UseSystemPasswordChar = false;
            txtFullname.UseTallSize = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(169, 39);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(106, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Receipt Details";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(41, 73);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(67, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Fullname";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(41, 136);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(51, 19);
            materialLabel3.TabIndex = 5;
            materialLabel3.Text = "Branch";
            // 
            // txtBranch
            // 
            txtBranch.AnimateReadOnly = false;
            txtBranch.BackgroundImageLayout = ImageLayout.None;
            txtBranch.CharacterCasing = CharacterCasing.Normal;
            txtBranch.Depth = 0;
            txtBranch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBranch.HideSelection = true;
            txtBranch.LeadingIcon = null;
            txtBranch.Location = new Point(41, 158);
            txtBranch.MaxLength = 32767;
            txtBranch.MouseState = MaterialSkin.MouseState.OUT;
            txtBranch.Name = "txtBranch";
            txtBranch.PasswordChar = '\0';
            txtBranch.PrefixSuffixText = null;
            txtBranch.ReadOnly = false;
            txtBranch.RightToLeft = RightToLeft.No;
            txtBranch.SelectedText = "";
            txtBranch.SelectionLength = 0;
            txtBranch.SelectionStart = 0;
            txtBranch.ShortcutsEnabled = true;
            txtBranch.Size = new Size(355, 36);
            txtBranch.TabIndex = 4;
            txtBranch.TabStop = false;
            txtBranch.TextAlign = HorizontalAlignment.Left;
            txtBranch.TrailingIcon = null;
            txtBranch.UseSystemPasswordChar = false;
            txtBranch.UseTallSize = false;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(41, 201);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(60, 19);
            materialLabel4.TabIndex = 7;
            materialLabel4.Text = "Services";
            materialLabel4.Click += materialLabel4_Click;
            // 
            // txtServices
            // 
            txtServices.AnimateReadOnly = false;
            txtServices.BackgroundImageLayout = ImageLayout.None;
            txtServices.CharacterCasing = CharacterCasing.Normal;
            txtServices.Depth = 0;
            txtServices.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtServices.HideSelection = true;
            txtServices.LeadingIcon = null;
            txtServices.Location = new Point(41, 223);
            txtServices.MaxLength = 32767;
            txtServices.MouseState = MaterialSkin.MouseState.OUT;
            txtServices.Name = "txtServices";
            txtServices.PasswordChar = '\0';
            txtServices.PrefixSuffixText = null;
            txtServices.ReadOnly = false;
            txtServices.RightToLeft = RightToLeft.No;
            txtServices.SelectedText = "";
            txtServices.SelectionLength = 0;
            txtServices.SelectionStart = 0;
            txtServices.ShortcutsEnabled = true;
            txtServices.Size = new Size(355, 36);
            txtServices.TabIndex = 6;
            txtServices.TabStop = false;
            txtServices.TextAlign = HorizontalAlignment.Left;
            txtServices.TrailingIcon = null;
            txtServices.UseSystemPasswordChar = false;
            txtServices.UseTallSize = false;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(41, 292);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(47, 19);
            materialLabel5.TabIndex = 9;
            materialLabel5.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.AnimateReadOnly = false;
            txtStatus.BackgroundImageLayout = ImageLayout.None;
            txtStatus.CharacterCasing = CharacterCasing.Normal;
            txtStatus.Depth = 0;
            txtStatus.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStatus.HideSelection = true;
            txtStatus.LeadingIcon = null;
            txtStatus.Location = new Point(41, 314);
            txtStatus.MaxLength = 32767;
            txtStatus.MouseState = MaterialSkin.MouseState.OUT;
            txtStatus.Name = "txtStatus";
            txtStatus.PasswordChar = '\0';
            txtStatus.PrefixSuffixText = null;
            txtStatus.ReadOnly = false;
            txtStatus.RightToLeft = RightToLeft.No;
            txtStatus.SelectedText = "";
            txtStatus.SelectionLength = 0;
            txtStatus.SelectionStart = 0;
            txtStatus.ShortcutsEnabled = true;
            txtStatus.Size = new Size(355, 36);
            txtStatus.TabIndex = 8;
            txtStatus.TabStop = false;
            txtStatus.TextAlign = HorizontalAlignment.Left;
            txtStatus.TrailingIcon = null;
            txtStatus.UseSystemPasswordChar = false;
            txtStatus.UseTallSize = false;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(41, 364);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(36, 19);
            materialLabel6.TabIndex = 11;
            materialLabel6.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.AnimateReadOnly = false;
            txtPrice.BackgroundImageLayout = ImageLayout.None;
            txtPrice.CharacterCasing = CharacterCasing.Normal;
            txtPrice.Depth = 0;
            txtPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrice.HideSelection = true;
            txtPrice.LeadingIcon = null;
            txtPrice.Location = new Point(41, 386);
            txtPrice.MaxLength = 32767;
            txtPrice.MouseState = MaterialSkin.MouseState.OUT;
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PrefixSuffixText = null;
            txtPrice.ReadOnly = false;
            txtPrice.RightToLeft = RightToLeft.No;
            txtPrice.SelectedText = "";
            txtPrice.SelectionLength = 0;
            txtPrice.SelectionStart = 0;
            txtPrice.ShortcutsEnabled = true;
            txtPrice.Size = new Size(105, 36);
            txtPrice.TabIndex = 10;
            txtPrice.TabStop = false;
            txtPrice.TextAlign = HorizontalAlignment.Left;
            txtPrice.TrailingIcon = null;
            txtPrice.UseSystemPasswordChar = false;
            txtPrice.UseTallSize = false;
            txtPrice.KeyPress += txtPrice_KeyPress;
            txtPrice.Leave += txtPrice_Leave;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(152, 364);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(66, 19);
            materialLabel7.TabIndex = 13;
            materialLabel7.Text = "Extra Fee";
            // 
            // txtExtraFee
            // 
            txtExtraFee.AnimateReadOnly = false;
            txtExtraFee.BackgroundImageLayout = ImageLayout.None;
            txtExtraFee.CharacterCasing = CharacterCasing.Normal;
            txtExtraFee.Depth = 0;
            txtExtraFee.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtExtraFee.HideSelection = true;
            txtExtraFee.LeadingIcon = null;
            txtExtraFee.Location = new Point(152, 386);
            txtExtraFee.MaxLength = 32767;
            txtExtraFee.MouseState = MaterialSkin.MouseState.OUT;
            txtExtraFee.Name = "txtExtraFee";
            txtExtraFee.PasswordChar = '\0';
            txtExtraFee.PrefixSuffixText = null;
            txtExtraFee.ReadOnly = false;
            txtExtraFee.RightToLeft = RightToLeft.No;
            txtExtraFee.SelectedText = "";
            txtExtraFee.SelectionLength = 0;
            txtExtraFee.SelectionStart = 0;
            txtExtraFee.ShortcutsEnabled = true;
            txtExtraFee.Size = new Size(105, 36);
            txtExtraFee.TabIndex = 12;
            txtExtraFee.TabStop = false;
            txtExtraFee.TextAlign = HorizontalAlignment.Left;
            txtExtraFee.TrailingIcon = null;
            txtExtraFee.UseSystemPasswordChar = false;
            txtExtraFee.UseTallSize = false;
            txtExtraFee.KeyPress += txtExtraFee_KeyPress;
            txtExtraFee.Leave += txtExtraFee_Leave;
            txtExtraFee.TextChanged += txtExtraFee_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.AnimateReadOnly = false;
            txtTotal.BackgroundImageLayout = ImageLayout.None;
            txtTotal.CharacterCasing = CharacterCasing.Normal;
            txtTotal.Depth = 0;
            txtTotal.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTotal.HideSelection = true;
            txtTotal.LeadingIcon = null;
            txtTotal.Location = new Point(263, 386);
            txtTotal.MaxLength = 32767;
            txtTotal.MouseState = MaterialSkin.MouseState.OUT;
            txtTotal.Name = "txtTotal";
            txtTotal.PasswordChar = '\0';
            txtTotal.PrefixSuffixText = null;
            txtTotal.ReadOnly = false;
            txtTotal.RightToLeft = RightToLeft.No;
            txtTotal.SelectedText = "";
            txtTotal.SelectionLength = 0;
            txtTotal.SelectionStart = 0;
            txtTotal.ShortcutsEnabled = true;
            txtTotal.Size = new Size(133, 36);
            txtTotal.TabIndex = 14;
            txtTotal.TabStop = false;
            txtTotal.TextAlign = HorizontalAlignment.Left;
            txtTotal.TrailingIcon = null;
            txtTotal.UseSystemPasswordChar = false;
            txtTotal.UseTallSize = false;
            txtTotal.KeyPress += txtTotal_KeyPress;
            txtTotal.Leave += txtTotal_Leave;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(263, 364);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(38, 19);
            materialLabel9.TabIndex = 17;
            materialLabel9.Text = "Total";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(395, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 27);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 18;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // receiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 521);
            Controls.Add(btnClose);
            Controls.Add(materialLabel9);
            Controls.Add(txtTotal);
            Controls.Add(materialLabel7);
            Controls.Add(txtExtraFee);
            Controls.Add(materialLabel6);
            Controls.Add(txtPrice);
            Controls.Add(materialLabel5);
            Controls.Add(txtStatus);
            Controls.Add(materialLabel4);
            Controls.Add(txtServices);
            Controls.Add(materialLabel3);
            Controls.Add(txtBranch);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(txtFullname);
            Controls.Add(btnPrintReceipt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "receiptForm";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "receiptForm";
            Load += receiptForm_Load;
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnPrintReceipt;
        private MaterialSkin.Controls.MaterialTextBox2 txtFullname;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtBranch;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 txtServices;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox2 txtExtraFee;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private PictureBox btnClose;
    }
}