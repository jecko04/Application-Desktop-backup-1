namespace Application_Desktop.Admin_Sub_Views
{
    partial class scanQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scanQRCode));
            btnStartScan = new MaterialSkin.Controls.MaterialButton();
            btnClose = new PictureBox();
            textBox1 = new TextBox();
            LoadingState = new PictureBox();
            panel1 = new Panel();
            lblScanning = new Label();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            lvlScanQRC = new Label();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LoadingState).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStartScan
            // 
            btnStartScan.AutoSize = false;
            btnStartScan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStartScan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnStartScan.Depth = 0;
            btnStartScan.HighEmphasis = true;
            btnStartScan.Icon = null;
            btnStartScan.Location = new Point(149, 138);
            btnStartScan.Margin = new Padding(4, 6, 4, 6);
            btnStartScan.MouseState = MaterialSkin.MouseState.HOVER;
            btnStartScan.Name = "btnStartScan";
            btnStartScan.NoAccentTextColor = Color.Empty;
            btnStartScan.Size = new Size(183, 36);
            btnStartScan.TabIndex = 0;
            btnStartScan.Text = "Start Scanning";
            btnStartScan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnStartScan.UseAccentColor = true;
            btnStartScan.UseVisualStyleBackColor = true;
            btnStartScan.Click += btnStartScan_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(458, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 27);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 19;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 112;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // LoadingState
            // 
            LoadingState.BackColor = Color.WhiteSmoke;
            LoadingState.Image = (Image)resources.GetObject("LoadingState.Image");
            LoadingState.Location = new Point(140, 12);
            LoadingState.Name = "LoadingState";
            LoadingState.Size = new Size(204, 133);
            LoadingState.SizeMode = PictureBoxSizeMode.CenterImage;
            LoadingState.TabIndex = 113;
            LoadingState.TabStop = false;
            LoadingState.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(458, 171);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 114;
            // 
            // lblScanning
            // 
            lblScanning.AutoSize = true;
            lblScanning.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScanning.Location = new Point(195, 120);
            lblScanning.Name = "lblScanning";
            lblScanning.Size = new Size(98, 25);
            lblScanning.TabIndex = 115;
            lblScanning.Text = "Scanning...";
            lblScanning.TextAlign = ContentAlignment.MiddleCenter;
            lblScanning.Visible = false;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = this;
            // 
            // lvlScanQRC
            // 
            lvlScanQRC.AutoSize = true;
            lvlScanQRC.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvlScanQRC.Location = new Point(180, 81);
            lvlScanQRC.Name = "lvlScanQRC";
            lvlScanQRC.Size = new Size(125, 25);
            lvlScanQRC.TabIndex = 116;
            lvlScanQRC.Text = "Scan QRCode";
            lvlScanQRC.TextAlign = ContentAlignment.MiddleCenter;
            lvlScanQRC.Visible = false;
            // 
            // scanQRCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(487, 189);
            Controls.Add(lvlScanQRC);
            Controls.Add(lblScanning);
            Controls.Add(panel1);
            Controls.Add(LoadingState);
            Controls.Add(btnClose);
            Controls.Add(btnStartScan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "scanQRCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "scanQRCode";
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)LoadingState).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnStartScan;
        private PictureBox btnClose;
        private TextBox textBox1;
        private PictureBox LoadingState;
        private Panel panel1;
        private Label lblScanning;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private Label lvlScanQRC;
    }
}