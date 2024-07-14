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
            panel1 = new Panel();
            txtSelectedRoles = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtComboBox = new ComboBox();
            btnAddRoles = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(123, 44, 191);
            panel1.Controls.Add(txtSelectedRoles);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtComboBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 160);
            panel1.TabIndex = 0;
            // 
            // txtSelectedRoles
            // 
            txtSelectedRoles.AutoSize = true;
            txtSelectedRoles.Location = new Point(179, 43);
            txtSelectedRoles.Name = "txtSelectedRoles";
            txtSelectedRoles.Size = new Size(16, 15);
            txtSelectedRoles.TabIndex = 4;
            txtSelectedRoles.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 18);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Selected:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 90);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "Roles";
            // 
            // txtComboBox
            // 
            txtComboBox.FlatStyle = FlatStyle.Popup;
            txtComboBox.FormattingEnabled = true;
            txtComboBox.Location = new Point(163, 108);
            txtComboBox.Name = "txtComboBox";
            txtComboBox.Size = new Size(150, 23);
            txtComboBox.TabIndex = 0;
            txtComboBox.SelectedIndexChanged += txtComboBox_SelectedIndexChanged;
            // 
            // btnAddRoles
            // 
            btnAddRoles.Location = new Point(263, 189);
            btnAddRoles.Name = "btnAddRoles";
            btnAddRoles.Size = new Size(82, 23);
            btnAddRoles.TabIndex = 1;
            btnAddRoles.Text = "ADD ROLES";
            btnAddRoles.UseVisualStyleBackColor = true;
            btnAddRoles.Click += btnAddRoles_Click_1;
            // 
            // Role
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 229);
            Controls.Add(btnAddRoles);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Role";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Role";
            Load += Role_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox txtComboBox;
        private Button btnAddRoles;
        private Label txtSelectedRoles;
        private Label label2;
        private PictureBox pictureBox1;
    }
}