namespace Application_Desktop.Admin_Views
{
    partial class setupOnlineBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setupOnlineBooking));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label40 = new Label();
            pictureBox1 = new PictureBox();
            view = new DataGridView();
            borderFetchTitle = new Panel();
            panel35 = new Panel();
            panel36 = new Panel();
            panel37 = new Panel();
            panel38 = new Panel();
            txtFetchTitle = new ComboBox();
            label8 = new Label();
            label1 = new Label();
            borderStartTime = new Panel();
            button3 = new Button();
            panel44 = new Panel();
            panel49 = new Panel();
            panel50 = new Panel();
            panel51 = new Panel();
            dtpStartTime = new DateTimePicker();
            borderEndtime = new Panel();
            button2 = new Button();
            panel19 = new Panel();
            panel24 = new Panel();
            panel29 = new Panel();
            panel34 = new Panel();
            dtpEndtime = new DateTimePicker();
            label18 = new Label();
            label17 = new Label();
            borderBranch = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            txtFetchBranch = new ComboBox();
            label2 = new Label();
            btnNewAccount = new Button();
            btnRefresh = new Button();
            btnView = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)view).BeginInit();
            borderFetchTitle.SuspendLayout();
            borderStartTime.SuspendLayout();
            borderEndtime.SuspendLayout();
            borderBranch.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label40);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1106, 30);
            panel1.TabIndex = 0;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label40.Location = new Point(33, 11);
            label40.Name = "label40";
            label40.Size = new Size(194, 16);
            label40.TabIndex = 90;
            label40.Text = "Dental Doctor Account Panel";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 89;
            pictureBox1.TabStop = false;
            // 
            // view
            // 
            view.AllowUserToAddRows = false;
            view.AllowUserToDeleteRows = false;
            view.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            view.BackgroundColor = Color.White;
            view.BorderStyle = BorderStyle.None;
            view.CellBorderStyle = DataGridViewCellBorderStyle.None;
            view.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            view.DefaultCellStyle = dataGridViewCellStyle3;
            view.Location = new Point(12, 134);
            view.Margin = new Padding(0, 0, 10, 0);
            view.Name = "view";
            view.ReadOnly = true;
            view.RowTemplate.Height = 25;
            view.Size = new Size(951, 325);
            view.TabIndex = 2;
            // 
            // borderFetchTitle
            // 
            borderFetchTitle.Controls.Add(panel35);
            borderFetchTitle.Controls.Add(panel36);
            borderFetchTitle.Controls.Add(panel37);
            borderFetchTitle.Controls.Add(panel38);
            borderFetchTitle.Controls.Add(txtFetchTitle);
            borderFetchTitle.Location = new Point(13, 74);
            borderFetchTitle.Name = "borderFetchTitle";
            borderFetchTitle.Size = new Size(213, 24);
            borderFetchTitle.TabIndex = 80;
            // 
            // panel35
            // 
            panel35.BackColor = Color.FromArgb(93, 173, 226);
            panel35.Dock = DockStyle.Right;
            panel35.Location = new Point(212, 1);
            panel35.Name = "panel35";
            panel35.Size = new Size(1, 22);
            panel35.TabIndex = 3;
            // 
            // panel36
            // 
            panel36.BackColor = Color.FromArgb(93, 173, 226);
            panel36.Dock = DockStyle.Bottom;
            panel36.Location = new Point(1, 23);
            panel36.Name = "panel36";
            panel36.Size = new Size(212, 1);
            panel36.TabIndex = 2;
            // 
            // panel37
            // 
            panel37.BackColor = Color.FromArgb(93, 173, 226);
            panel37.Dock = DockStyle.Top;
            panel37.Location = new Point(1, 0);
            panel37.Name = "panel37";
            panel37.Size = new Size(212, 1);
            panel37.TabIndex = 1;
            // 
            // panel38
            // 
            panel38.BackColor = Color.FromArgb(93, 173, 226);
            panel38.Dock = DockStyle.Left;
            panel38.Location = new Point(0, 0);
            panel38.Name = "panel38";
            panel38.Size = new Size(1, 24);
            panel38.TabIndex = 0;
            // 
            // txtFetchTitle
            // 
            txtFetchTitle.BackColor = SystemColors.InactiveBorder;
            txtFetchTitle.Dock = DockStyle.Fill;
            txtFetchTitle.DropDownHeight = 75;
            txtFetchTitle.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFetchTitle.FormattingEnabled = true;
            txtFetchTitle.IntegralHeight = false;
            txtFetchTitle.ItemHeight = 16;
            txtFetchTitle.Location = new Point(0, 0);
            txtFetchTitle.Name = "txtFetchTitle";
            txtFetchTitle.Size = new Size(213, 24);
            txtFetchTitle.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(14, 55);
            label8.Name = "label8";
            label8.Size = new Size(77, 16);
            label8.TabIndex = 79;
            label8.Text = "Day of week";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(13, 112);
            label1.Name = "label1";
            label1.Size = new Size(95, 16);
            label1.TabIndex = 81;
            label1.Text = "Dental Services";
            // 
            // borderStartTime
            // 
            borderStartTime.Controls.Add(button3);
            borderStartTime.Controls.Add(panel44);
            borderStartTime.Controls.Add(panel49);
            borderStartTime.Controls.Add(panel50);
            borderStartTime.Controls.Add(panel51);
            borderStartTime.Controls.Add(dtpStartTime);
            borderStartTime.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            borderStartTime.Location = new Point(250, 75);
            borderStartTime.Name = "borderStartTime";
            borderStartTime.Size = new Size(107, 23);
            borderStartTime.TabIndex = 85;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(102, 204, 102);
            button3.FlatAppearance.BorderColor = Color.FromArgb(102, 204, 102);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(315, 32);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(48, 25);
            button3.TabIndex = 59;
            button3.Text = "Apply";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel44
            // 
            panel44.BackColor = Color.FromArgb(93, 173, 226);
            panel44.Dock = DockStyle.Right;
            panel44.Location = new Point(106, 1);
            panel44.Name = "panel44";
            panel44.Size = new Size(1, 21);
            panel44.TabIndex = 3;
            // 
            // panel49
            // 
            panel49.BackColor = Color.FromArgb(93, 173, 226);
            panel49.Dock = DockStyle.Bottom;
            panel49.Location = new Point(1, 22);
            panel49.Name = "panel49";
            panel49.Size = new Size(106, 1);
            panel49.TabIndex = 2;
            // 
            // panel50
            // 
            panel50.BackColor = Color.FromArgb(93, 173, 226);
            panel50.Dock = DockStyle.Top;
            panel50.Location = new Point(1, 0);
            panel50.Name = "panel50";
            panel50.Size = new Size(106, 1);
            panel50.TabIndex = 1;
            // 
            // panel51
            // 
            panel51.BackColor = Color.FromArgb(93, 173, 226);
            panel51.Dock = DockStyle.Left;
            panel51.Location = new Point(0, 0);
            panel51.Name = "panel51";
            panel51.Size = new Size(1, 23);
            panel51.TabIndex = 0;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Dock = DockStyle.Fill;
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(0, 0);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(107, 23);
            dtpStartTime.TabIndex = 5;
            // 
            // borderEndtime
            // 
            borderEndtime.Controls.Add(button2);
            borderEndtime.Controls.Add(panel19);
            borderEndtime.Controls.Add(panel24);
            borderEndtime.Controls.Add(panel29);
            borderEndtime.Controls.Add(panel34);
            borderEndtime.Controls.Add(dtpEndtime);
            borderEndtime.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            borderEndtime.Location = new Point(382, 74);
            borderEndtime.Name = "borderEndtime";
            borderEndtime.Size = new Size(107, 23);
            borderEndtime.TabIndex = 84;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(102, 204, 102);
            button2.FlatAppearance.BorderColor = Color.FromArgb(102, 204, 102);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(408, 32);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(48, 25);
            button2.TabIndex = 59;
            button2.Text = "Apply";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(93, 173, 226);
            panel19.Dock = DockStyle.Right;
            panel19.Location = new Point(106, 1);
            panel19.Name = "panel19";
            panel19.Size = new Size(1, 21);
            panel19.TabIndex = 3;
            // 
            // panel24
            // 
            panel24.BackColor = Color.FromArgb(93, 173, 226);
            panel24.Dock = DockStyle.Bottom;
            panel24.Location = new Point(1, 22);
            panel24.Name = "panel24";
            panel24.Size = new Size(106, 1);
            panel24.TabIndex = 2;
            // 
            // panel29
            // 
            panel29.BackColor = Color.FromArgb(93, 173, 226);
            panel29.Dock = DockStyle.Top;
            panel29.Location = new Point(1, 0);
            panel29.Name = "panel29";
            panel29.Size = new Size(106, 1);
            panel29.TabIndex = 1;
            // 
            // panel34
            // 
            panel34.BackColor = Color.FromArgb(93, 173, 226);
            panel34.Dock = DockStyle.Left;
            panel34.Location = new Point(0, 0);
            panel34.Name = "panel34";
            panel34.Size = new Size(1, 23);
            panel34.TabIndex = 0;
            // 
            // dtpEndtime
            // 
            dtpEndtime.Dock = DockStyle.Fill;
            dtpEndtime.Format = DateTimePickerFormat.Time;
            dtpEndtime.Location = new Point(0, 0);
            dtpEndtime.Name = "dtpEndtime";
            dtpEndtime.Size = new Size(107, 23);
            dtpEndtime.TabIndex = 5;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.DimGray;
            label18.Location = new Point(382, 55);
            label18.Name = "label18";
            label18.Size = new Size(76, 16);
            label18.TabIndex = 83;
            label18.Text = "End of Time";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.DimGray;
            label17.Location = new Point(250, 54);
            label17.Name = "label17";
            label17.Size = new Size(83, 16);
            label17.TabIndex = 82;
            label17.Text = "Start of Time";
            // 
            // borderBranch
            // 
            borderBranch.Controls.Add(panel3);
            borderBranch.Controls.Add(panel4);
            borderBranch.Controls.Add(panel5);
            borderBranch.Controls.Add(panel6);
            borderBranch.Controls.Add(txtFetchBranch);
            borderBranch.Location = new Point(514, 73);
            borderBranch.Name = "borderBranch";
            borderBranch.Size = new Size(213, 24);
            borderBranch.TabIndex = 87;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(93, 173, 226);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(212, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 22);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(93, 173, 226);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(1, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(212, 1);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(93, 173, 226);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(1, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(212, 1);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(93, 173, 226);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 24);
            panel6.TabIndex = 0;
            // 
            // txtFetchBranch
            // 
            txtFetchBranch.BackColor = SystemColors.InactiveBorder;
            txtFetchBranch.Dock = DockStyle.Fill;
            txtFetchBranch.DropDownHeight = 75;
            txtFetchBranch.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFetchBranch.FormattingEnabled = true;
            txtFetchBranch.IntegralHeight = false;
            txtFetchBranch.ItemHeight = 16;
            txtFetchBranch.Location = new Point(0, 0);
            txtFetchBranch.Name = "txtFetchBranch";
            txtFetchBranch.Size = new Size(213, 24);
            txtFetchBranch.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(515, 54);
            label2.Name = "label2";
            label2.Size = new Size(83, 16);
            label2.TabIndex = 86;
            label2.Text = "Branch Name";
            // 
            // btnNewAccount
            // 
            btnNewAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewAccount.BackColor = Color.FromArgb(102, 204, 102);
            btnNewAccount.FlatAppearance.BorderColor = Color.FromArgb(102, 204, 102);
            btnNewAccount.FlatStyle = FlatStyle.Flat;
            btnNewAccount.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewAccount.ForeColor = SystemColors.ButtonFace;
            btnNewAccount.Location = new Point(973, 134);
            btnNewAccount.Margin = new Padding(0, 0, 0, 1);
            btnNewAccount.Name = "btnNewAccount";
            btnNewAccount.Size = new Size(119, 24);
            btnNewAccount.TabIndex = 88;
            btnNewAccount.Text = "Save Appointment";
            btnNewAccount.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = SystemColors.ButtonFace;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(973, 193);
            btnRefresh.Margin = new Padding(0, 0, 0, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(119, 24);
            btnRefresh.TabIndex = 89;
            btnRefresh.TextAlign = ContentAlignment.MiddleLeft;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnView
            // 
            btnView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnView.BackColor = Color.FromArgb(52, 152, 219);
            btnView.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnView.ForeColor = SystemColors.ButtonFace;
            btnView.Location = new Point(973, 159);
            btnView.Margin = new Padding(0, 0, 0, 1);
            btnView.Name = "btnView";
            btnView.Size = new Size(119, 24);
            btnView.TabIndex = 90;
            btnView.Text = "View Appointment";
            btnView.UseVisualStyleBackColor = false;
            // 
            // setupOnlineBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 660);
            Controls.Add(btnView);
            Controls.Add(btnNewAccount);
            Controls.Add(btnRefresh);
            Controls.Add(borderBranch);
            Controls.Add(label2);
            Controls.Add(borderStartTime);
            Controls.Add(borderEndtime);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label1);
            Controls.Add(borderFetchTitle);
            Controls.Add(label8);
            Controls.Add(view);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "setupOnlineBooking";
            Text = "setupOnlineBooking";
            Load += setupOnlineBooking_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)view).EndInit();
            borderFetchTitle.ResumeLayout(false);
            borderStartTime.ResumeLayout(false);
            borderEndtime.ResumeLayout(false);
            borderBranch.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label40;
        private DataGridView view;
        private Panel borderFetchTitle;
        private Panel panel35;
        private Panel panel36;
        private Panel panel37;
        private Panel panel38;
        private ComboBox txtFetchTitle;
        private Label label8;
        private Label label1;
        private Panel borderStartTime;
        private Button button3;
        private Panel panel44;
        private Panel panel49;
        private Panel panel50;
        private Panel panel51;
        private DateTimePicker dtpStartTime;
        private Panel borderEndtime;
        private Button button2;
        private Panel panel19;
        private Panel panel24;
        private Panel panel29;
        private Panel panel34;
        private DateTimePicker dtpEndtime;
        private Label label18;
        private Label label17;
        private Panel borderBranch;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private ComboBox txtFetchBranch;
        private Label label2;
        private Button btnNewAccount;
        private Button btnRefresh;
        private Button btnView;
    }
}