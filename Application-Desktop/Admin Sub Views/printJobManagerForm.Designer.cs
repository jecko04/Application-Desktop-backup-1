namespace Application_Desktop.Admin_Sub_Views
{
    partial class printJobManagerForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printJobManagerForm));
            viewPrintJob = new DataGridView();
            btnCancelJob = new MaterialSkin.Controls.MaterialButton();
            btnRefresh = new MaterialSkin.Controls.MaterialButton();
            btnClose = new PictureBox();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)viewPrintJob).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // viewPrintJob
            // 
            viewPrintJob.AllowUserToAddRows = false;
            viewPrintJob.AllowUserToDeleteRows = false;
            viewPrintJob.AllowUserToResizeColumns = false;
            viewPrintJob.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightYellow;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            viewPrintJob.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            viewPrintJob.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewPrintJob.BackgroundColor = Color.WhiteSmoke;
            viewPrintJob.BorderStyle = BorderStyle.None;
            viewPrintJob.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewPrintJob.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.NullValue = "N/A";
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            viewPrintJob.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            viewPrintJob.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "N/A";
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            viewPrintJob.DefaultCellStyle = dataGridViewCellStyle3;
            viewPrintJob.EnableHeadersVisualStyles = false;
            viewPrintJob.Location = new Point(-1, 0);
            viewPrintJob.Margin = new Padding(0);
            viewPrintJob.Name = "viewPrintJob";
            viewPrintJob.ReadOnly = true;
            viewPrintJob.RowTemplate.Height = 25;
            viewPrintJob.Size = new Size(553, 291);
            viewPrintJob.TabIndex = 25;
            viewPrintJob.CellContentClick += viewPrintJob_CellContentClick;
            // 
            // btnCancelJob
            // 
            btnCancelJob.AutoSize = false;
            btnCancelJob.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelJob.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelJob.Depth = 0;
            btnCancelJob.HighEmphasis = true;
            btnCancelJob.Icon = null;
            btnCancelJob.Location = new Point(556, 217);
            btnCancelJob.Margin = new Padding(4, 6, 4, 6);
            btnCancelJob.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelJob.Name = "btnCancelJob";
            btnCancelJob.NoAccentTextColor = Color.Empty;
            btnCancelJob.Size = new Size(156, 36);
            btnCancelJob.TabIndex = 26;
            btnCancelJob.Text = "Cancel";
            btnCancelJob.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelJob.UseAccentColor = false;
            btnCancelJob.UseVisualStyleBackColor = true;
            btnCancelJob.Click += btnCancelJob_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.AutoSize = false;
            btnRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRefresh.Depth = 0;
            btnRefresh.HighEmphasis = true;
            btnRefresh.Icon = null;
            btnRefresh.Location = new Point(556, 255);
            btnRefresh.Margin = new Padding(4, 6, 4, 6);
            btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.NoAccentTextColor = Color.Empty;
            btnRefresh.Size = new Size(156, 36);
            btnRefresh.TabIndex = 27;
            btnRefresh.Text = "Reload";
            btnRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRefresh.UseAccentColor = false;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(685, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 27);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 28;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = this;
            // 
            // printJobManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 294);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(btnCancelJob);
            Controls.Add(viewPrintJob);
            FormBorderStyle = FormBorderStyle.None;
            Name = "printJobManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "printJobManagerForm";
            Load += printJobManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)viewPrintJob).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView viewPrintJob;
        private MaterialSkin.Controls.MaterialButton btnCancelJob;
        private MaterialSkin.Controls.MaterialButton btnRefresh;
        private PictureBox btnClose;
        private ElipseToolDemo.ElipseControl elipseControl1;
    }
}