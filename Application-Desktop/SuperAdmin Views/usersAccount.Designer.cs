namespace Application_Desktop.SuperAdmin_Views
{
    partial class usersAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usersAccount));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label40 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnRefresh = new Button();
            btnDelete = new Button();
            viewUsersAccount = new DataGridView();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewUsersAccount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label40);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 30);
            panel1.TabIndex = 1;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label40.Location = new Point(37, 9);
            label40.Name = "label40";
            label40.Size = new Size(82, 16);
            label40.TabIndex = 89;
            label40.Text = "Users Panel\r\n";
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(1496, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(502, 30);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(41, 56, 218);
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(41, 56, 218);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9F);
            btnRefresh.ForeColor = SystemColors.ButtonFace;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(999, 43);
            btnRefresh.Margin = new Padding(0, 0, 0, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(85, 24);
            btnRefresh.TabIndex = 21;
            btnRefresh.TextAlign = ContentAlignment.MiddleLeft;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(41, 56, 218);
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(41, 56, 218);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 9F);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(999, 68);
            btnDelete.Margin = new Padding(0, 0, 0, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 24);
            btnDelete.TabIndex = 19;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // viewUsersAccount
            // 
            viewUsersAccount.AllowUserToAddRows = false;
            viewUsersAccount.AllowUserToDeleteRows = false;
            viewUsersAccount.AllowUserToResizeColumns = false;
            viewUsersAccount.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightYellow;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            viewUsersAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            viewUsersAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            viewUsersAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewUsersAccount.BackgroundColor = Color.White;
            viewUsersAccount.BorderStyle = BorderStyle.None;
            viewUsersAccount.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewUsersAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.NullValue = "N/A";
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            viewUsersAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            viewUsersAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Gray;
            dataGridViewCellStyle3.NullValue = "N/A";
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            viewUsersAccount.DefaultCellStyle = dataGridViewCellStyle3;
            viewUsersAccount.EnableHeadersVisualStyles = false;
            viewUsersAccount.Location = new Point(-2, 43);
            viewUsersAccount.Margin = new Padding(0, 0, 10, 0);
            viewUsersAccount.Name = "viewUsersAccount";
            viewUsersAccount.ReadOnly = true;
            viewUsersAccount.RowTemplate.Height = 25;
            viewUsersAccount.Size = new Size(991, 325);
            viewUsersAccount.TabIndex = 18;
            viewUsersAccount.CellContentClick += viewUsersAccount_CellContentClick;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = viewUsersAccount;
            // 
            // usersAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 621);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(viewUsersAccount);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "usersAccount";
            Text = "usersAccount";
            Load += usersAccount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewUsersAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label40;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnRefresh;
        private Button btnDelete;
        private DataGridView viewUsersAccount;
        private ElipseToolDemo.ElipseControl elipseControl1;
    }
}