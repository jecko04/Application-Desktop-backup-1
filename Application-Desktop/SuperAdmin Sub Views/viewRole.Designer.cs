namespace Application_Desktop.SuperAdmin_Sub_Views
{
    partial class viewRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewRole));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnClose = new PictureBox();
            viewExistingRole = new DataGridView();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewExistingRole).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(52, 152, 219);
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(368, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 27);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // viewExistingRole
            // 
            viewExistingRole.AllowUserToAddRows = false;
            viewExistingRole.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(132, 202, 239);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(52, 152, 219);
            viewExistingRole.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            viewExistingRole.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewExistingRole.BackgroundColor = Color.White;
            viewExistingRole.BorderStyle = BorderStyle.None;
            viewExistingRole.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewExistingRole.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            viewExistingRole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            viewExistingRole.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            viewExistingRole.DefaultCellStyle = dataGridViewCellStyle3;
            viewExistingRole.Dock = DockStyle.Fill;
            viewExistingRole.EnableHeadersVisualStyles = false;
            viewExistingRole.Location = new Point(0, 0);
            viewExistingRole.Name = "viewExistingRole";
            viewExistingRole.ReadOnly = true;
            viewExistingRole.RowTemplate.Height = 25;
            viewExistingRole.Size = new Size(395, 206);
            viewExistingRole.TabIndex = 3;
            viewExistingRole.CellContentClick += viewExistingRole_CellContentClick;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = this;
            // 
            // viewRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 206);
            Controls.Add(btnClose);
            Controls.Add(viewExistingRole);
            FormBorderStyle = FormBorderStyle.None;
            Name = "viewRole";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "viewRole";
            Load += viewRole_Load;
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewExistingRole).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView viewExistingRole;
        private PictureBox btnClose;
        private ElipseToolDemo.ElipseControl elipseControl1;
    }
}