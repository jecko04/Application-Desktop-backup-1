namespace Application_Desktop.Screen
{
    partial class alertBox
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
            AlertPicture = new PictureBox();
            AlertTitle = new Label();
            AlernSubTitle = new Label();
            AlertTimer = new System.Windows.Forms.Timer(components);
            AlertProgressBar = new Panel();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)AlertPicture).BeginInit();
            SuspendLayout();
            // 
            // AlertPicture
            // 
            AlertPicture.Location = new Point(21, 12);
            AlertPicture.Name = "AlertPicture";
            AlertPicture.Size = new Size(50, 50);
            AlertPicture.TabIndex = 0;
            AlertPicture.TabStop = false;
            // 
            // AlertTitle
            // 
            AlertTitle.AutoSize = true;
            AlertTitle.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AlertTitle.Location = new Point(77, 18);
            AlertTitle.Name = "AlertTitle";
            AlertTitle.Size = new Size(79, 18);
            AlertTitle.TabIndex = 1;
            AlertTitle.Text = "AlertTitle";
            // 
            // AlernSubTitle
            // 
            AlernSubTitle.AutoSize = true;
            AlernSubTitle.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AlernSubTitle.ForeColor = SystemColors.ButtonShadow;
            AlernSubTitle.Location = new Point(77, 36);
            AlernSubTitle.Name = "AlernSubTitle";
            AlernSubTitle.Size = new Size(81, 16);
            AlernSubTitle.TabIndex = 2;
            AlernSubTitle.Text = "AlertSubTitle";
            // 
            // AlertTimer
            // 
            AlertTimer.Enabled = true;
            AlertTimer.Interval = 8;
            AlertTimer.Tick += AlertTimer_Tick;
            // 
            // AlertProgressBar
            // 
            AlertProgressBar.BackColor = Color.Black;
            AlertProgressBar.Location = new Point(0, 74);
            AlertProgressBar.Name = "AlertProgressBar";
            AlertProgressBar.Size = new Size(500, 6);
            AlertProgressBar.TabIndex = 3;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = this;
            // 
            // alertBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 80);
            Controls.Add(AlertProgressBar);
            Controls.Add(AlernSubTitle);
            Controls.Add(AlertTitle);
            Controls.Add(AlertPicture);
            FormBorderStyle = FormBorderStyle.None;
            Name = "alertBox";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += alertBox_Load_1;
            ((System.ComponentModel.ISupportInitialize)AlertPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox AlertPicture;
        private Label AlertTitle;
        private Label AlernSubTitle;
        private System.Windows.Forms.Timer AlertTimer;
        private Panel AlertProgressBar;
        private ElipseToolDemo.ElipseControl elipseControl1;
    }
}