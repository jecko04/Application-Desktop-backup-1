namespace Application_Desktop
{
    partial class Role
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Role));
            AddRolePanel = new Panel();
            btnViewRole = new Label();
            label4 = new Label();
            label3 = new Label();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            txtComboBox = new ComboBox();
            btnAddRoles = new Button();
            txtSelectedRoles = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label40 = new Label();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            AddRolePanel.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // AddRolePanel
            // 
            AddRolePanel.BackColor = Color.White;
            AddRolePanel.Controls.Add(btnViewRole);
            AddRolePanel.Controls.Add(label4);
            AddRolePanel.Controls.Add(label3);
            AddRolePanel.Controls.Add(panel8);
            AddRolePanel.Controls.Add(btnAddRoles);
            AddRolePanel.Controls.Add(txtSelectedRoles);
            AddRolePanel.Controls.Add(label2);
            AddRolePanel.Controls.Add(label1);
            AddRolePanel.Location = new Point(-1, 55);
            AddRolePanel.Name = "AddRolePanel";
            AddRolePanel.Size = new Size(952, 221);
            AddRolePanel.TabIndex = 0;
            // 
            // btnViewRole
            // 
            btnViewRole.AutoSize = true;
            btnViewRole.Cursor = Cursors.Hand;
            btnViewRole.FlatStyle = FlatStyle.Flat;
            btnViewRole.Font = new Font("Tahoma", 9F, FontStyle.Underline);
            btnViewRole.ForeColor = Color.DimGray;
            btnViewRole.Location = new Point(116, 190);
            btnViewRole.Name = "btnViewRole";
            btnViewRole.Size = new Size(106, 14);
            btnViewRole.TabIndex = 11;
            btnViewRole.Text = "View Existing Role";
            btnViewRole.Click += btnViewRole_Click;
            btnViewRole.MouseEnter += btnViewRole_MouseEnter;
            btnViewRole.MouseLeave += btnViewRole_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(28, 31);
            label4.Name = "label4";
            label4.Size = new Size(332, 14);
            label4.TabIndex = 10;
            label4.Text = "Ensure you have role before creating an account for Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(28, 13);
            label3.Name = "label3";
            label3.Size = new Size(56, 14);
            label3.TabIndex = 9;
            label3.Text = "Add Role";
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(panel11);
            panel8.Controls.Add(panel12);
            panel8.Controls.Add(txtComboBox);
            panel8.Location = new Point(28, 133);
            panel8.Name = "panel8";
            panel8.Size = new Size(334, 23);
            panel8.TabIndex = 8;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(52, 152, 219);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new Point(333, 1);
            panel9.Name = "panel9";
            panel9.Size = new Size(1, 21);
            panel9.TabIndex = 6;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(52, 152, 219);
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(0, 1);
            panel10.Name = "panel10";
            panel10.Size = new Size(1, 21);
            panel10.TabIndex = 7;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(52, 152, 219);
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(0, 22);
            panel11.Name = "panel11";
            panel11.Size = new Size(334, 1);
            panel11.TabIndex = 7;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(52, 152, 219);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(334, 1);
            panel12.TabIndex = 7;
            // 
            // txtComboBox
            // 
            txtComboBox.Dock = DockStyle.Fill;
            txtComboBox.FormattingEnabled = true;
            txtComboBox.Location = new Point(0, 0);
            txtComboBox.Name = "txtComboBox";
            txtComboBox.Size = new Size(334, 23);
            txtComboBox.TabIndex = 0;
            txtComboBox.SelectedIndexChanged += txtComboBox_SelectedIndexChanged;
            // 
            // btnAddRoles
            // 
            btnAddRoles.BackColor = Color.FromArgb(52, 152, 219);
            btnAddRoles.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnAddRoles.FlatStyle = FlatStyle.Flat;
            btnAddRoles.ForeColor = Color.White;
            btnAddRoles.Location = new Point(28, 181);
            btnAddRoles.Name = "btnAddRoles";
            btnAddRoles.Size = new Size(82, 23);
            btnAddRoles.TabIndex = 1;
            btnAddRoles.Text = "ADD ROLES";
            btnAddRoles.UseVisualStyleBackColor = false;
            btnAddRoles.Click += btnAddRoles_Click_1;
            // 
            // txtSelectedRoles
            // 
            txtSelectedRoles.AutoSize = true;
            txtSelectedRoles.Font = new Font("Tahoma", 9F);
            txtSelectedRoles.ForeColor = Color.DimGray;
            txtSelectedRoles.Location = new Point(47, 82);
            txtSelectedRoles.Name = "txtSelectedRoles";
            txtSelectedRoles.Size = new Size(19, 14);
            txtSelectedRoles.TabIndex = 4;
            txtSelectedRoles.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(28, 57);
            label2.Name = "label2";
            label2.Size = new Size(59, 14);
            label2.TabIndex = 3;
            label2.Text = "Selected:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(28, 105);
            label1.Name = "label1";
            label1.Size = new Size(35, 14);
            label1.TabIndex = 1;
            label1.Text = "Roles";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label40);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1099, 30);
            panel2.TabIndex = 2;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label40.Location = new Point(33, 6);
            label40.Name = "label40";
            label40.Size = new Size(77, 16);
            label40.TabIndex = 88;
            label40.Text = "Setup Role";
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = AddRolePanel;
            // 
            // Role
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 660);
            Controls.Add(panel2);
            Controls.Add(AddRolePanel);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Role";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Role";
            Load += Role_Load;
            AddRolePanel.ResumeLayout(false);
            AddRolePanel.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AddRolePanel;
        private Label label1;
        private ComboBox txtComboBox;
        private Button btnAddRoles;
        private Label txtSelectedRoles;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label40;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Label label3;
        private Label label4;
        private Label btnViewRole;
        private ElipseToolDemo.ElipseControl elipseControl1;
    }
}