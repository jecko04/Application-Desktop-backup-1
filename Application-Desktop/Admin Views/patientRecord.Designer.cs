namespace Application_Desktop.Admin_Views
{
    partial class patientRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patientRecord));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtSearchBox = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            label40 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCreate = new Button();
            tabControl1 = new TabControl();
            tabPage4 = new TabPage();
            viewPatientRecord = new DataGridView();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            viewGenHealth = new DataGridView();
            viewDentHealth = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewPatientRecord).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewGenHealth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewDentHealth).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(txtSearchBox);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(label40);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 30);
            panel1.TabIndex = 2;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchBox.BorderStyle = BorderStyle.FixedSingle;
            txtSearchBox.Cursor = Cursors.IBeam;
            txtSearchBox.Font = new Font("Tahoma", 9.75F);
            txtSearchBox.Location = new Point(683, 2);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.PlaceholderText = " Search";
            txtSearchBox.Size = new Size(194, 23);
            txtSearchBox.TabIndex = 90;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(52, 152, 219);
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Microsoft Sans Serif", 9F);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(880, 1);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(32, 24);
            btnSearch.TabIndex = 91;
            btnSearch.TextAlign = ContentAlignment.MiddleLeft;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9F);
            btnRefresh.ForeColor = SystemColors.ButtonFace;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(913, 1);
            btnRefresh.Margin = new Padding(1, 0, 0, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(32, 24);
            btnRefresh.TabIndex = 92;
            btnRefresh.TextAlign = ContentAlignment.MiddleLeft;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 9F);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(946, 1);
            btnDelete.Margin = new Padding(1, 0, 0, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(38, 24);
            btnDelete.TabIndex = 22;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label40.Location = new Point(37, 9);
            label40.Name = "label40";
            label40.Size = new Size(189, 16);
            label40.TabIndex = 89;
            label40.Text = "Dental Patient Record Panel";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 88;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(2375, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(502, 30);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreate.BackColor = Color.FromArgb(52, 152, 219);
            btnCreate.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Microsoft Sans Serif", 9F);
            btnCreate.ForeColor = SystemColors.ButtonFace;
            btnCreate.Location = new Point(991, 73);
            btnCreate.Margin = new Padding(0, 0, 0, 1);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(85, 24);
            btnCreate.TabIndex = 23;
            btnCreate.Text = "Create New";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.ItemSize = new Size(89, 24);
            tabControl1.Location = new Point(5, 45);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(15, 3);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(981, 488);
            tabControl1.TabIndex = 24;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(viewPatientRecord);
            tabPage4.ForeColor = Color.Gray;
            tabPage4.Location = new Point(4, 28);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(973, 456);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Patient Record";
            tabPage4.UseVisualStyleBackColor = true;
            tabPage4.Click += tabPage4_Click;
            // 
            // viewPatientRecord
            // 
            viewPatientRecord.AllowUserToAddRows = false;
            viewPatientRecord.AllowUserToDeleteRows = false;
            viewPatientRecord.AllowUserToResizeColumns = false;
            viewPatientRecord.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 241, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(52, 152, 219);
            viewPatientRecord.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            viewPatientRecord.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewPatientRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewPatientRecord.BackgroundColor = Color.White;
            viewPatientRecord.BorderStyle = BorderStyle.None;
            viewPatientRecord.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewPatientRecord.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.NullValue = "N/A";
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            viewPatientRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            viewPatientRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Gray;
            dataGridViewCellStyle3.NullValue = "N/A";
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            viewPatientRecord.DefaultCellStyle = dataGridViewCellStyle3;
            viewPatientRecord.EnableHeadersVisualStyles = false;
            viewPatientRecord.Location = new Point(7, 13);
            viewPatientRecord.Margin = new Padding(0, 0, 10, 0);
            viewPatientRecord.Name = "viewPatientRecord";
            viewPatientRecord.RowTemplate.Height = 25;
            viewPatientRecord.Size = new Size(959, 310);
            viewPatientRecord.TabIndex = 22;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(viewGenHealth);
            tabPage2.ForeColor = Color.Gray;
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(973, 456);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "General Health Information";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(viewDentHealth);
            tabPage3.ForeColor = Color.Gray;
            tabPage3.Location = new Point(4, 28);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(973, 456);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Dental Health Information";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = viewPatientRecord;
            // 
            // viewGenHealth
            // 
            viewGenHealth.AllowUserToAddRows = false;
            viewGenHealth.AllowUserToDeleteRows = false;
            viewGenHealth.AllowUserToResizeColumns = false;
            viewGenHealth.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 241, 255);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(52, 152, 219);
            viewGenHealth.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            viewGenHealth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewGenHealth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewGenHealth.BackgroundColor = Color.White;
            viewGenHealth.BorderStyle = BorderStyle.None;
            viewGenHealth.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewGenHealth.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.NullValue = "N/A";
            dataGridViewCellStyle5.Padding = new Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            viewGenHealth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            viewGenHealth.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Gray;
            dataGridViewCellStyle6.NullValue = "N/A";
            dataGridViewCellStyle6.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            viewGenHealth.DefaultCellStyle = dataGridViewCellStyle6;
            viewGenHealth.EnableHeadersVisualStyles = false;
            viewGenHealth.Location = new Point(7, 13);
            viewGenHealth.Margin = new Padding(0, 0, 10, 0);
            viewGenHealth.Name = "viewGenHealth";
            viewGenHealth.RowTemplate.Height = 25;
            viewGenHealth.Size = new Size(959, 310);
            viewGenHealth.TabIndex = 23;
            // 
            // viewDentHealth
            // 
            viewDentHealth.AllowUserToAddRows = false;
            viewDentHealth.AllowUserToDeleteRows = false;
            viewDentHealth.AllowUserToResizeColumns = false;
            viewDentHealth.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(224, 241, 255);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Gray;
            dataGridViewCellStyle7.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(52, 152, 219);
            viewDentHealth.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            viewDentHealth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewDentHealth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewDentHealth.BackgroundColor = Color.White;
            viewDentHealth.BorderStyle = BorderStyle.None;
            viewDentHealth.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewDentHealth.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle8.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.NullValue = "N/A";
            dataGridViewCellStyle8.Padding = new Padding(3);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            viewDentHealth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            viewDentHealth.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.Gray;
            dataGridViewCellStyle9.NullValue = "N/A";
            dataGridViewCellStyle9.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            viewDentHealth.DefaultCellStyle = dataGridViewCellStyle9;
            viewDentHealth.EnableHeadersVisualStyles = false;
            viewDentHealth.Location = new Point(7, 13);
            viewDentHealth.Margin = new Padding(0, 0, 10, 0);
            viewDentHealth.Name = "viewDentHealth";
            viewDentHealth.RowTemplate.Height = 25;
            viewDentHealth.Size = new Size(959, 310);
            viewDentHealth.TabIndex = 23;
            // 
            // patientRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 621);
            Controls.Add(tabControl1);
            Controls.Add(btnCreate);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "patientRecord";
            Text = "patientRecord";
            Load += patientRecord_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewPatientRecord).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewGenHealth).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewDentHealth).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label40;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCreate;
        private Button btnDelete;
        private TextBox txtSearchBox;
        private Button btnSearch;
        private Button btnRefresh;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView viewPatientRecord;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private DataGridView viewGenHealth;
        private DataGridView viewDentHealth;
    }
}