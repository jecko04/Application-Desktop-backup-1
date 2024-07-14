namespace Application_Desktop.Sub_sub_Views
{
    partial class editSuperAdmin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editSuperAdmin));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtRoles = new ComboBox();
            button1 = new Button();
            btnUpdate = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(52, 152, 219);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 32);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 10);
            label1.Name = "label1";
            label1.Size = new Size(106, 16);
            label1.TabIndex = 3;
            label1.Text = "Edit Super Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(390, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 53);
            label2.Name = "label2";
            label2.Size = new Size(76, 16);
            label2.TabIndex = 1;
            label2.Text = "First name*";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(38, 85);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = " First name";
            txtFirstName.Size = new Size(144, 23);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(217, 85);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = " Last name";
            txtLastName.Size = new Size(144, 23);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(201, 53);
            label3.Name = "label3";
            label3.Size = new Size(74, 16);
            label3.TabIndex = 3;
            label3.Text = "Last name*";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(38, 166);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Email";
            txtEmail.Size = new Size(323, 23);
            txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 134);
            label4.Name = "label4";
            label4.Size = new Size(46, 16);
            label4.TabIndex = 5;
            label4.Text = "Email*";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(38, 196);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(323, 23);
            txtPassword.TabIndex = 7;
            txtPassword.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 249);
            label5.Name = "label5";
            label5.Size = new Size(32, 16);
            label5.TabIndex = 8;
            label5.Text = "Role";
            // 
            // txtRoles
            // 
            txtRoles.FormattingEnabled = true;
            txtRoles.Location = new Point(38, 282);
            txtRoles.Name = "txtRoles";
            txtRoles.Size = new Size(323, 24);
            txtRoles.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(231, 76, 60);
            button1.FlatAppearance.BorderColor = Color.FromArgb(231, 76, 60);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(234, 337);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(58, 30);
            button1.TabIndex = 19;
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
            btnUpdate.Location = new Point(303, 337);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(58, 30);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Submit";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            errorProvider2.Icon = (Icon)resources.GetObject("errorProvider2.Icon");
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtRoles);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtEmail);
            panel2.Location = new Point(2, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 407);
            panel2.TabIndex = 20;
            // 
            // editSuperAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 437);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "editSuperAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "editSuperAdmin";
            Load += editSuperAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPassword;
        private Label label5;
        private ComboBox txtRoles;
        private Button button1;
        private Button btnUpdate;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Panel panel2;
    }
}