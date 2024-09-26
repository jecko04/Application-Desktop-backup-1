namespace Application_Desktop.Admin_Sub_Views
{
    partial class viewCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewCategories));
            viewCategoriesDetails = new DataGridView();
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            elipseControl2 = new ElipseToolDemo.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)viewCategoriesDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // viewCategoriesDetails
            // 
            viewCategoriesDetails.AllowUserToAddRows = false;
            viewCategoriesDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightYellow;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            viewCategoriesDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            viewCategoriesDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewCategoriesDetails.BackgroundColor = Color.White;
            viewCategoriesDetails.BorderStyle = BorderStyle.None;
            viewCategoriesDetails.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewCategoriesDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            viewCategoriesDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            viewCategoriesDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Gray;
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            viewCategoriesDetails.DefaultCellStyle = dataGridViewCellStyle3;
            viewCategoriesDetails.EnableHeadersVisualStyles = false;
            viewCategoriesDetails.Location = new Point(0, 32);
            viewCategoriesDetails.Name = "viewCategoriesDetails";
            viewCategoriesDetails.ReadOnly = true;
            viewCategoriesDetails.RowHeadersVisible = false;
            viewCategoriesDetails.RowTemplate.Height = 25;
            viewCategoriesDetails.Size = new Size(1000, 315);
            viewCategoriesDetails.TabIndex = 2;
            viewCategoriesDetails.CellContentClick += viewCategoriesDetails_CellContentClick;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(970, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 27);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(viewCategoriesDetails);
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 350);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 33);
            panel1.TabIndex = 3;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = this;
            // 
            // elipseControl2
            // 
            elipseControl2.CornerRadius = 15;
            elipseControl2.TargetControl = viewCategoriesDetails;
            // 
            // viewCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 346);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "viewCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "viewCategories";
            Load += viewCategories_Load;
            ((System.ComponentModel.ISupportInitialize)viewCategoriesDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView viewCategoriesDetails;
        private PictureBox btnClose;
        private Panel panel2;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private ElipseToolDemo.ElipseControl elipseControl2;
        private Panel panel1;
    }
}