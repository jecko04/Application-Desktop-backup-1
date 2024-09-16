namespace Application_Desktop.Sub_sub_Views
{
    partial class viewBranches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewBranches));
            viewBranchData = new DataGridView();
            btnAddBranch = new Button();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            txtSearchBox = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)viewBranchData).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // viewBranchData
            // 
            viewBranchData.AllowUserToAddRows = false;
            viewBranchData.AllowUserToDeleteRows = false;
            viewBranchData.AllowUserToResizeColumns = false;
            viewBranchData.AllowUserToResizeRows = false;
            viewBranchData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewBranchData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewBranchData.BackgroundColor = Color.White;
            viewBranchData.BorderStyle = BorderStyle.None;
            viewBranchData.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewBranchData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(123, 44, 191);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(149, 86, 203);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            viewBranchData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            viewBranchData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            viewBranchData.DefaultCellStyle = dataGridViewCellStyle2;
            viewBranchData.Location = new Point(-1, 41);
            viewBranchData.Margin = new Padding(0);
            viewBranchData.Name = "viewBranchData";
            viewBranchData.ReadOnly = true;
            viewBranchData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(149, 86, 203);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            viewBranchData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            viewBranchData.RowTemplate.Height = 25;
            viewBranchData.Size = new Size(995, 355);
            viewBranchData.TabIndex = 8;
            viewBranchData.CellContentClick += viewBranchData_CellContentClick;
            // 
            // btnAddBranch
            // 
            btnAddBranch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddBranch.BackColor = Color.FromArgb(52, 152, 219);
            btnAddBranch.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnAddBranch.FlatStyle = FlatStyle.Flat;
            btnAddBranch.Font = new Font("Microsoft Sans Serif", 9F);
            btnAddBranch.ForeColor = SystemColors.ButtonFace;
            btnAddBranch.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddBranch.Location = new Point(1007, 41);
            btnAddBranch.Margin = new Padding(0);
            btnAddBranch.Name = "btnAddBranch";
            btnAddBranch.Size = new Size(85, 24);
            btnAddBranch.TabIndex = 9;
            btnAddBranch.Text = "Create New";
            btnAddBranch.TextAlign = ContentAlignment.MiddleLeft;
            btnAddBranch.UseVisualStyleBackColor = false;
            btnAddBranch.Click += btnAddBranch_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(txtSearchBox);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnRefresh);
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1102, 30);
            panel2.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // txtSearchBox
            // 
            txtSearchBox.BorderStyle = BorderStyle.FixedSingle;
            txtSearchBox.Cursor = Cursors.IBeam;
            txtSearchBox.Font = new Font("Tahoma", 9.75F);
            txtSearchBox.Location = new Point(733, 4);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.PlaceholderText = " Search";
            txtSearchBox.Size = new Size(194, 23);
            txtSearchBox.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(52, 152, 219);
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Microsoft Sans Serif", 9F);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(930, 4);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(32, 24);
            btnSearch.TabIndex = 10;
            btnSearch.TextAlign = ContentAlignment.MiddleLeft;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9F);
            btnRefresh.ForeColor = SystemColors.ButtonFace;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(963, 4);
            btnRefresh.Margin = new Padding(1, 0, 0, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(32, 24);
            btnRefresh.TabIndex = 11;
            btnRefresh.TextAlign = ContentAlignment.MiddleLeft;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = viewBranchData;
            // 
            // viewBranches
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 660);
            Controls.Add(panel2);
            Controls.Add(btnAddBranch);
            Controls.Add(viewBranchData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "viewBranches";
            Text = "viewBranches";
            Load += viewBranches_Load;
            ((System.ComponentModel.ISupportInitialize)viewBranchData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView viewBranchData;
        private TextBox txtSearchBox;
        private Button btnAddBranch;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button btnSearch;
        private Button btnRefresh;
        private ElipseToolDemo.ElipseControl elipseControl1;
    }
}