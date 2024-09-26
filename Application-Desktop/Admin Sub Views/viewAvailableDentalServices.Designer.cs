namespace Application_Desktop.Admin_Sub_Views
{
    partial class viewAvailableDentalServices
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewAvailableDentalServices));
            viewDentalServices = new DataGridView();
            btnClose = new PictureBox();
            elipseControl2 = new ElipseToolDemo.ElipseControl();
            btnAvailable = new RadioButton();
            label1 = new Label();
            btnUnavailable = new RadioButton();
            borderServices = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            txtServices = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)viewDentalServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            borderServices.SuspendLayout();
            SuspendLayout();
            // 
            // viewDentalServices
            // 
            viewDentalServices.AllowUserToAddRows = false;
            viewDentalServices.AllowUserToDeleteRows = false;
            viewDentalServices.AllowUserToResizeColumns = false;
            viewDentalServices.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightYellow;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            viewDentalServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            viewDentalServices.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewDentalServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewDentalServices.BackgroundColor = Color.WhiteSmoke;
            viewDentalServices.BorderStyle = BorderStyle.None;
            viewDentalServices.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewDentalServices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            viewDentalServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            viewDentalServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Gray;
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            viewDentalServices.DefaultCellStyle = dataGridViewCellStyle3;
            viewDentalServices.EnableHeadersVisualStyles = false;
            viewDentalServices.Location = new Point(-2, -1);
            viewDentalServices.Margin = new Padding(0, 0, 10, 0);
            viewDentalServices.Name = "viewDentalServices";
            viewDentalServices.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            viewDentalServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            viewDentalServices.RowsDefaultCellStyle = dataGridViewCellStyle5;
            viewDentalServices.RowTemplate.Height = 25;
            viewDentalServices.Size = new Size(904, 530);
            viewDentalServices.TabIndex = 95;
            viewDentalServices.CellContentClick += viewDentalServices_CellContentClick;
            viewDentalServices.CellFormatting += viewDentalServices_CellFormatting;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1081, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 27);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // elipseControl2
            // 
            elipseControl2.CornerRadius = 15;
            elipseControl2.TargetControl = this;
            // 
            // btnAvailable
            // 
            btnAvailable.AutoSize = true;
            btnAvailable.ForeColor = Color.Black;
            btnAvailable.Location = new Point(917, 236);
            btnAvailable.Name = "btnAvailable";
            btnAvailable.Size = new Size(73, 19);
            btnAvailable.TabIndex = 99;
            btnAvailable.TabStop = true;
            btnAvailable.Text = "Available";
            btnAvailable.UseVisualStyleBackColor = true;
            btnAvailable.CheckedChanged += btnAvailable_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(915, 208);
            label1.Name = "label1";
            label1.Size = new Size(111, 16);
            label1.TabIndex = 100;
            label1.Text = "Sort by availability";
            // 
            // btnUnavailable
            // 
            btnUnavailable.AutoSize = true;
            btnUnavailable.ForeColor = Color.Black;
            btnUnavailable.Location = new Point(1005, 236);
            btnUnavailable.Name = "btnUnavailable";
            btnUnavailable.Size = new Size(86, 19);
            btnUnavailable.TabIndex = 101;
            btnUnavailable.TabStop = true;
            btnUnavailable.Text = "Unavailable";
            btnUnavailable.UseVisualStyleBackColor = true;
            // 
            // borderServices
            // 
            borderServices.Controls.Add(panel3);
            borderServices.Controls.Add(panel4);
            borderServices.Controls.Add(panel5);
            borderServices.Controls.Add(panel6);
            borderServices.Controls.Add(txtServices);
            borderServices.Location = new Point(916, 167);
            borderServices.Name = "borderServices";
            borderServices.Size = new Size(176, 24);
            borderServices.TabIndex = 100;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(93, 173, 226);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(175, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 22);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(93, 173, 226);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(1, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(175, 1);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(93, 173, 226);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(1, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(175, 1);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(93, 173, 226);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 24);
            panel6.TabIndex = 0;
            // 
            // txtServices
            // 
            txtServices.BackColor = SystemColors.InactiveBorder;
            txtServices.Dock = DockStyle.Fill;
            txtServices.DropDownHeight = 75;
            txtServices.Font = new Font("Tahoma", 9.75F);
            txtServices.FormattingEnabled = true;
            txtServices.IntegralHeight = false;
            txtServices.ItemHeight = 16;
            txtServices.Items.AddRange(new object[] { "5 minutes", "10 minutes", "15 minutes", "20 minutes", "25 minutes", "30 minutes", "35 minutes", "40 minutes", "45 minutes", "50 minutes", "55 minutes", "1 hour", "1 hour 5 minutes ", "1 hour 10 minutes", "1 hour 15 minutes", "1 hour 20 minutes", "1 hour 25 minutes", "1 hour 30 minutes", "1 hour 35 minutes", "1 hour 40 minutes", "1 hour 45 minutes", "1 hour 50 minutes", "1 hour 55 minutes", "2 hours" });
            txtServices.Location = new Point(0, 0);
            txtServices.Name = "txtServices";
            txtServices.Size = new Size(176, 24);
            txtServices.TabIndex = 55;
            txtServices.SelectedIndexChanged += txtServices_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(916, 148);
            label2.Name = "label2";
            label2.Size = new Size(98, 16);
            label2.TabIndex = 99;
            label2.Text = "Sort by services";
            // 
            // viewAvailableDentalServices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 220, 18);
            ClientSize = new Size(1108, 527);
            Controls.Add(btnClose);
            Controls.Add(borderServices);
            Controls.Add(label2);
            Controls.Add(btnUnavailable);
            Controls.Add(label1);
            Controls.Add(btnAvailable);
            Controls.Add(viewDentalServices);
            FormBorderStyle = FormBorderStyle.None;
            Name = "viewAvailableDentalServices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "viewAvailableDentalServices";
            Load += viewAvailableDentalServices_Load;
            ((System.ComponentModel.ISupportInitialize)viewDentalServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            borderServices.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView viewDentalServices;
        private PictureBox btnClose;
        private ElipseToolDemo.ElipseControl elipseControl2;
        private Label label1;
        private RadioButton btnAvailable;
        private RadioButton btnUnavailable;
        private Panel borderServices;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private ComboBox txtServices;
        private Label label2;
    }
}