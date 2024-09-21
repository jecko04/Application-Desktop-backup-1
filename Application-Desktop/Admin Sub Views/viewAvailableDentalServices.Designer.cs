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
            panel1 = new Panel();
            btnClose = new PictureBox();
            elipseControl2 = new ElipseToolDemo.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)viewDentalServices).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // viewDentalServices
            // 
            viewDentalServices.AllowUserToAddRows = false;
            viewDentalServices.AllowUserToDeleteRows = false;
            viewDentalServices.AllowUserToResizeColumns = false;
            viewDentalServices.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 241, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(52, 152, 219);
            viewDentalServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            viewDentalServices.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewDentalServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewDentalServices.BackgroundColor = Color.White;
            viewDentalServices.BorderStyle = BorderStyle.None;
            viewDentalServices.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewDentalServices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            viewDentalServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            viewDentalServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            viewDentalServices.DefaultCellStyle = dataGridViewCellStyle3;
            viewDentalServices.EnableHeadersVisualStyles = false;
            viewDentalServices.Location = new Point(0, 30);
            viewDentalServices.Margin = new Padding(0, 0, 10, 0);
            viewDentalServices.Name = "viewDentalServices";
            viewDentalServices.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            viewDentalServices.Size = new Size(1106, 373);
            viewDentalServices.TabIndex = 95;
            viewDentalServices.CellContentClick += viewDentalServices_CellContentClick;
            viewDentalServices.CellFormatting += viewDentalServices_CellFormatting;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 30);
            panel1.TabIndex = 96;
            panel1.Paint += panel1_Paint;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1079, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 27);
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
            // viewAvailableDentalServices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 403);
            Controls.Add(panel1);
            Controls.Add(viewDentalServices);
            FormBorderStyle = FormBorderStyle.None;
            Name = "viewAvailableDentalServices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "viewAvailableDentalServices";
            Load += viewAvailableDentalServices_Load;
            ((System.ComponentModel.ISupportInitialize)viewDentalServices).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView viewDentalServices;
        private Panel panel1;
        private PictureBox btnClose;
        private ElipseToolDemo.ElipseControl elipseControl2;
    }
}