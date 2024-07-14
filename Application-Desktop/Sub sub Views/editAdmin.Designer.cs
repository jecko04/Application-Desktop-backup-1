namespace Application_Desktop.Sub_sub_Views
{
    partial class editAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editAdmin));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            panel2 = new Panel();
            txtPassword = new TextBox();
            button1 = new Button();
            btnUpdate = new Button();
            label7 = new Label();
            txtBranch = new ComboBox();
            label6 = new Label();
            txtRoles = new ComboBox();
            txtEmail = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtfirstName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(52, 152, 219);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 30);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InactiveBorder;
            label1.Location = new Point(33, 12);
            label1.Name = "label1";
            label1.Size = new Size(78, 14);
            label1.TabIndex = 3;
            label1.Text = "Edit Account";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(383, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtBranch);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtRoles);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtfirstName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(2, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 406);
            panel2.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(33, 168);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(347, 23);
            txtPassword.TabIndex = 19;
            txtPassword.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(231, 76, 60);
            button1.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(253, 349);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(58, 30);
            button1.TabIndex = 17;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(102, 204, 102);
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(102, 204, 102);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(322, 349);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(58, 30);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Submit";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(22, 268);
            label7.Name = "label7";
            label7.Size = new Size(101, 16);
            label7.TabIndex = 12;
            label7.Text = "Change Branch*";
            // 
            // txtBranch
            // 
            txtBranch.FormattingEnabled = true;
            txtBranch.Location = new Point(33, 296);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(347, 23);
            txtBranch.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 205);
            label6.Name = "label6";
            label6.Size = new Size(40, 16);
            label6.TabIndex = 10;
            label6.Text = "Role*";
            // 
            // txtRoles
            // 
            txtRoles.FormattingEnabled = true;
            txtRoles.Location = new Point(33, 233);
            txtRoles.Name = "txtRoles";
            txtRoles.Size = new Size(347, 23);
            txtRoles.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(33, 139);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(347, 23);
            txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 110);
            label4.Name = "label4";
            label4.Size = new Size(46, 16);
            label4.TabIndex = 4;
            label4.Text = "Email*";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(223, 68);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last name";
            txtLastName.Size = new Size(157, 23);
            txtLastName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(212, 39);
            label3.Name = "label3";
            label3.Size = new Size(74, 16);
            label3.TabIndex = 2;
            label3.Text = "Last name*";
            // 
            // txtfirstName
            // 
            txtfirstName.BorderStyle = BorderStyle.FixedSingle;
            txtfirstName.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtfirstName.Location = new Point(33, 68);
            txtfirstName.Name = "txtfirstName";
            txtfirstName.PlaceholderText = "First name";
            txtfirstName.Size = new Size(157, 23);
            txtfirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 39);
            label2.Name = "label2";
            label2.Size = new Size(76, 16);
            label2.TabIndex = 0;
            label2.Text = "First name*";
            // 
            // editAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 436);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "editAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "editAdmin";
            Load += editAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox btnClose;
        private Panel panel2;
        private Label label7;
        private ComboBox txtBranch;
        private Label label6;
        private ComboBox txtRoles;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtfirstName;
        private Label label2;
        private Button button1;
        private Button btnUpdate;
        private TextBox txtPassword;
    }
}