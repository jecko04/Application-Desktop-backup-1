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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewCategories));
            viewCategoriesDetails = new DataGridView();
            panel1 = new Panel();
            btnClose = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)viewCategoriesDetails).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // viewCategoriesDetails
            // 
            viewCategoriesDetails.AllowUserToAddRows = false;
            viewCategoriesDetails.AllowUserToDeleteRows = false;
            viewCategoriesDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewCategoriesDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewCategoriesDetails.BackgroundColor = SystemColors.ButtonFace;
            viewCategoriesDetails.BorderStyle = BorderStyle.None;
            viewCategoriesDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            viewCategoriesDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            viewCategoriesDetails.DefaultCellStyle = dataGridViewCellStyle1;
            viewCategoriesDetails.Location = new Point(-1, -1);
            viewCategoriesDetails.Name = "viewCategoriesDetails";
            viewCategoriesDetails.ReadOnly = true;
            viewCategoriesDetails.RowTemplate.Height = 25;
            viewCategoriesDetails.Size = new Size(1000, 260);
            viewCategoriesDetails.TabIndex = 2;
            viewCategoriesDetails.CellContentClick += viewCategoriesDetails_CellContentClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(52, 152, 219);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 30);
            panel1.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(965, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(viewCategoriesDetails);
            panel2.Location = new Point(0, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 260);
            panel2.TabIndex = 4;
            // 
            // viewCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 290);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "viewCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "viewCategories";
            Load += viewCategories_Load;
            ((System.ComponentModel.ISupportInitialize)viewCategoriesDetails).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView viewCategoriesDetails;
        private Panel panel1;
        private PictureBox btnClose;
        private Panel panel2;
    }
}