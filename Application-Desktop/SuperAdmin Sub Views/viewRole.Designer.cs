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
            panel1 = new Panel();
            btnClose = new PictureBox();
            viewExistingRole = new DataGridView();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewExistingRole).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 152, 219);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 30);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(528, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // viewExistingRole
            // 
            viewExistingRole.AllowUserToAddRows = false;
            viewExistingRole.AllowUserToDeleteRows = false;
            viewExistingRole.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewExistingRole.BackgroundColor = Color.White;
            viewExistingRole.BorderStyle = BorderStyle.None;
            viewExistingRole.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewExistingRole.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            viewExistingRole.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            viewExistingRole.DefaultCellStyle = dataGridViewCellStyle1;
            viewExistingRole.Dock = DockStyle.Fill;
            viewExistingRole.Location = new Point(0, 30);
            viewExistingRole.Name = "viewExistingRole";
            viewExistingRole.ReadOnly = true;
            viewExistingRole.RowTemplate.Height = 25;
            viewExistingRole.Size = new Size(561, 176);
            viewExistingRole.TabIndex = 3;
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
            ClientSize = new Size(561, 206);
            Controls.Add(viewExistingRole);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "viewRole";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "viewRole";
            Load += viewRole_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewExistingRole).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView viewExistingRole;
        private PictureBox btnClose;
        private ElipseToolDemo.ElipseControl elipseControl1;
    }
}