namespace Application_Desktop.Admin_Views
{
    partial class employeeProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeProfile));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label40 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            viewEmployeeDetails = new DataGridView();
            btnCreate = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewEmployeeDetails).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label40);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 30);
            panel1.TabIndex = 1;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label40.Location = new Point(37, 9);
            label40.Name = "label40";
            label40.Size = new Size(107, 16);
            label40.TabIndex = 89;
            label40.Text = "Employee Panel";
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
            flowLayoutPanel1.Location = new Point(1487, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(502, 30);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // viewEmployeeDetails
            // 
            viewEmployeeDetails.AllowUserToAddRows = false;
            viewEmployeeDetails.AllowUserToDeleteRows = false;
            viewEmployeeDetails.AllowUserToResizeColumns = false;
            viewEmployeeDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 241, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(52, 152, 219);
            viewEmployeeDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            viewEmployeeDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewEmployeeDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewEmployeeDetails.BackgroundColor = Color.White;
            viewEmployeeDetails.BorderStyle = BorderStyle.None;
            viewEmployeeDetails.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewEmployeeDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.NullValue = "N/A";
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            viewEmployeeDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            viewEmployeeDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle3.NullValue = "N/A";
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            viewEmployeeDetails.DefaultCellStyle = dataGridViewCellStyle3;
            viewEmployeeDetails.EnableHeadersVisualStyles = false;
            viewEmployeeDetails.Location = new Point(11, 42);
            viewEmployeeDetails.Margin = new Padding(0, 0, 10, 0);
            viewEmployeeDetails.Name = "viewEmployeeDetails";
            viewEmployeeDetails.RowTemplate.Height = 25;
            viewEmployeeDetails.Size = new Size(970, 310);
            viewEmployeeDetails.TabIndex = 2;
            viewEmployeeDetails.CellContentClick += viewEmployeeDetails_CellContentClick;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreate.BackColor = Color.FromArgb(52, 152, 219);
            btnCreate.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Microsoft Sans Serif", 9F);
            btnCreate.ForeColor = SystemColors.ButtonFace;
            btnCreate.Location = new Point(991, 42);
            btnCreate.Margin = new Padding(0, 0, 0, 1);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(85, 24);
            btnCreate.TabIndex = 19;
            btnCreate.Text = "Create New";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
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
            btnRefresh.Location = new Point(991, 67);
            btnRefresh.Margin = new Padding(0, 0, 0, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(85, 24);
            btnRefresh.TabIndex = 20;
            btnRefresh.TextAlign = ContentAlignment.MiddleLeft;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
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
            btnDelete.Location = new Point(991, 92);
            btnDelete.Margin = new Padding(0, 0, 0, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 24);
            btnDelete.TabIndex = 18;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = viewEmployeeDetails;
            // 
            // employeeProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 621);
            Controls.Add(viewEmployeeDetails);
            Controls.Add(btnCreate);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "employeeProfile";
            Text = "Employees";
            Load += employeeProfile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewEmployeeDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label40;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView viewEmployeeDetails;
        private Button btnCreate;
        private Button btnRefresh;
        private Button btnDelete;
        private ElipseToolDemo.ElipseControl elipseControl1;
    }
}