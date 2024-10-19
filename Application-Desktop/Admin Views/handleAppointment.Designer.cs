namespace Application_Desktop.Admin_Views
{
    partial class handleAppointment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(handleAppointment));
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            viewPendingAppointment = new DataGridView();
            tabPage3 = new TabPage();
            viewApprovedAppointment = new DataGridView();
            tabPage4 = new TabPage();
            viewCancelledAppointment = new DataGridView();
            tabPage1 = new TabPage();
            viewCompletedAppointment = new DataGridView();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            btnRefresher = new MaterialSkin.Controls.MaterialButton();
            btnApprove = new MaterialSkin.Controls.MaterialButton();
            txtSearchBoxes = new MaterialSkin.Controls.MaterialTextBox();
            btnSearcher = new MaterialSkin.Controls.MaterialButton();
            btnComplete = new MaterialSkin.Controls.MaterialButton();
            QRCode = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btnQRCode = new MaterialSkin.Controls.MaterialButton();
            qrCodePanel = new FlowLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            btnInqueue = new MaterialSkin.Controls.MaterialButton();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewPendingAppointment).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewApprovedAppointment).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewCancelledAppointment).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewCompletedAppointment).BeginInit();
            qrCodePanel.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.ItemSize = new Size(89, 30);
            tabControl1.Location = new Point(3, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(837, 593);
            tabControl1.TabIndex = 95;
            tabControl1.TabStop = false;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(viewPendingAppointment);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(829, 555);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "In Queue Appointment";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // viewPendingAppointment
            // 
            viewPendingAppointment.AllowUserToAddRows = false;
            viewPendingAppointment.AllowUserToDeleteRows = false;
            viewPendingAppointment.AllowUserToResizeColumns = false;
            viewPendingAppointment.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightYellow;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            viewPendingAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            viewPendingAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewPendingAppointment.BackgroundColor = Color.White;
            viewPendingAppointment.BorderStyle = BorderStyle.None;
            viewPendingAppointment.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewPendingAppointment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.NullValue = "N/A";
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            viewPendingAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            viewPendingAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "N/A";
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            viewPendingAppointment.DefaultCellStyle = dataGridViewCellStyle3;
            viewPendingAppointment.Dock = DockStyle.Fill;
            viewPendingAppointment.EnableHeadersVisualStyles = false;
            viewPendingAppointment.Location = new Point(3, 3);
            viewPendingAppointment.Margin = new Padding(0);
            viewPendingAppointment.Name = "viewPendingAppointment";
            viewPendingAppointment.ReadOnly = true;
            viewPendingAppointment.RowTemplate.Height = 25;
            viewPendingAppointment.Size = new Size(823, 549);
            viewPendingAppointment.TabIndex = 22;
            viewPendingAppointment.CellContentClick += viewPendingAppointment_CellContentClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(viewApprovedAppointment);
            tabPage3.Cursor = Cursors.IBeam;
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(829, 555);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "Approved Appointment";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // viewApprovedAppointment
            // 
            viewApprovedAppointment.AllowUserToAddRows = false;
            viewApprovedAppointment.AllowUserToDeleteRows = false;
            viewApprovedAppointment.AllowUserToResizeColumns = false;
            viewApprovedAppointment.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.LightYellow;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            viewApprovedAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            viewApprovedAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewApprovedAppointment.BackgroundColor = Color.White;
            viewApprovedAppointment.BorderStyle = BorderStyle.None;
            viewApprovedAppointment.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewApprovedAppointment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.NullValue = "N/A";
            dataGridViewCellStyle5.Padding = new Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            viewApprovedAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            viewApprovedAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.NullValue = "N/A";
            dataGridViewCellStyle6.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            viewApprovedAppointment.DefaultCellStyle = dataGridViewCellStyle6;
            viewApprovedAppointment.Dock = DockStyle.Fill;
            viewApprovedAppointment.EnableHeadersVisualStyles = false;
            viewApprovedAppointment.Location = new Point(3, 3);
            viewApprovedAppointment.Margin = new Padding(0);
            viewApprovedAppointment.Name = "viewApprovedAppointment";
            viewApprovedAppointment.ReadOnly = true;
            viewApprovedAppointment.RowTemplate.Height = 25;
            viewApprovedAppointment.Size = new Size(823, 549);
            viewApprovedAppointment.TabIndex = 23;
            viewApprovedAppointment.CellContentClick += viewApprovedAppointment_CellContentClick;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(viewCancelledAppointment);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(829, 555);
            tabPage4.TabIndex = 2;
            tabPage4.Text = "Cancelled Appointment";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // viewCancelledAppointment
            // 
            viewCancelledAppointment.AllowUserToAddRows = false;
            viewCancelledAppointment.AllowUserToDeleteRows = false;
            viewCancelledAppointment.AllowUserToResizeColumns = false;
            viewCancelledAppointment.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.LightYellow;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            viewCancelledAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            viewCancelledAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewCancelledAppointment.BackgroundColor = Color.White;
            viewCancelledAppointment.BorderStyle = BorderStyle.None;
            viewCancelledAppointment.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewCancelledAppointment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.NullValue = "N/A";
            dataGridViewCellStyle8.Padding = new Padding(3);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            viewCancelledAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            viewCancelledAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.NullValue = "N/A";
            dataGridViewCellStyle9.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle9.SelectionBackColor = Color.White;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            viewCancelledAppointment.DefaultCellStyle = dataGridViewCellStyle9;
            viewCancelledAppointment.Dock = DockStyle.Fill;
            viewCancelledAppointment.EnableHeadersVisualStyles = false;
            viewCancelledAppointment.Location = new Point(0, 0);
            viewCancelledAppointment.Margin = new Padding(0);
            viewCancelledAppointment.Name = "viewCancelledAppointment";
            viewCancelledAppointment.ReadOnly = true;
            viewCancelledAppointment.RowTemplate.Height = 25;
            viewCancelledAppointment.Size = new Size(829, 555);
            viewCancelledAppointment.TabIndex = 23;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(viewCompletedAppointment);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(829, 555);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Completed";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // viewCompletedAppointment
            // 
            viewCompletedAppointment.AllowUserToAddRows = false;
            viewCompletedAppointment.AllowUserToDeleteRows = false;
            viewCompletedAppointment.AllowUserToResizeColumns = false;
            viewCompletedAppointment.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = Color.LightYellow;
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            viewCompletedAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            viewCompletedAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewCompletedAppointment.BackgroundColor = Color.White;
            viewCompletedAppointment.BorderStyle = BorderStyle.None;
            viewCompletedAppointment.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewCompletedAppointment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.NullValue = "N/A";
            dataGridViewCellStyle11.Padding = new Padding(3);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            viewCompletedAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            viewCompletedAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.NullValue = "N/A";
            dataGridViewCellStyle12.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle12.SelectionBackColor = Color.White;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            viewCompletedAppointment.DefaultCellStyle = dataGridViewCellStyle12;
            viewCompletedAppointment.Dock = DockStyle.Fill;
            viewCompletedAppointment.EnableHeadersVisualStyles = false;
            viewCompletedAppointment.Location = new Point(3, 3);
            viewCompletedAppointment.Margin = new Padding(0);
            viewCompletedAppointment.Name = "viewCompletedAppointment";
            viewCompletedAppointment.ReadOnly = true;
            viewCompletedAppointment.RowTemplate.Height = 25;
            viewCompletedAppointment.Size = new Size(823, 549);
            viewCompletedAppointment.TabIndex = 24;
            viewCompletedAppointment.CellContentClick += viewCompletedAppointment_CellContentClick;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.AutoSize = false;
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(964, 111);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(107, 36);
            btnCancel.TabIndex = 107;
            btnCancel.Text = "Cancel";
            btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = true;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRefresher
            // 
            btnRefresher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresher.AutoSize = false;
            btnRefresher.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRefresher.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRefresher.Depth = 0;
            btnRefresher.HighEmphasis = true;
            btnRefresher.Icon = null;
            btnRefresher.Location = new Point(850, 264);
            btnRefresher.Margin = new Padding(4, 6, 4, 6);
            btnRefresher.MouseState = MaterialSkin.MouseState.HOVER;
            btnRefresher.Name = "btnRefresher";
            btnRefresher.NoAccentTextColor = Color.Empty;
            btnRefresher.Size = new Size(221, 36);
            btnRefresher.TabIndex = 106;
            btnRefresher.TabStop = false;
            btnRefresher.Text = "Reload";
            btnRefresher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRefresher.UseAccentColor = false;
            btnRefresher.UseVisualStyleBackColor = true;
            btnRefresher.Click += btnRefresher_Click;
            // 
            // btnApprove
            // 
            btnApprove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnApprove.AutoSize = false;
            btnApprove.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnApprove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnApprove.Depth = 0;
            btnApprove.HighEmphasis = true;
            btnApprove.Icon = null;
            btnApprove.Location = new Point(850, 111);
            btnApprove.Margin = new Padding(4, 6, 4, 6);
            btnApprove.MouseState = MaterialSkin.MouseState.HOVER;
            btnApprove.Name = "btnApprove";
            btnApprove.NoAccentTextColor = Color.Empty;
            btnApprove.Size = new Size(112, 36);
            btnApprove.TabIndex = 104;
            btnApprove.Text = "Approve";
            btnApprove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnApprove.UseAccentColor = false;
            btnApprove.UseVisualStyleBackColor = true;
            btnApprove.Click += btnApprove_Click;
            // 
            // txtSearchBoxes
            // 
            txtSearchBoxes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchBoxes.AnimateReadOnly = false;
            txtSearchBoxes.BorderStyle = BorderStyle.None;
            txtSearchBoxes.Depth = 0;
            txtSearchBoxes.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearchBoxes.Hint = "Search by name";
            txtSearchBoxes.LeadingIcon = null;
            txtSearchBoxes.Location = new Point(846, 35);
            txtSearchBoxes.MaxLength = 50;
            txtSearchBoxes.MouseState = MaterialSkin.MouseState.OUT;
            txtSearchBoxes.Multiline = false;
            txtSearchBoxes.Name = "txtSearchBoxes";
            txtSearchBoxes.Size = new Size(183, 36);
            txtSearchBoxes.TabIndex = 103;
            txtSearchBoxes.TabStop = false;
            txtSearchBoxes.Text = "";
            txtSearchBoxes.TrailingIcon = null;
            txtSearchBoxes.UseTallSize = false;
            // 
            // btnSearcher
            // 
            btnSearcher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearcher.AutoSize = false;
            btnSearcher.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearcher.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSearcher.Depth = 0;
            btnSearcher.HighEmphasis = true;
            btnSearcher.Icon = (Image)resources.GetObject("btnSearcher.Icon");
            btnSearcher.Location = new Point(1036, 35);
            btnSearcher.Margin = new Padding(4, 6, 4, 6);
            btnSearcher.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearcher.Name = "btnSearcher";
            btnSearcher.NoAccentTextColor = Color.Empty;
            btnSearcher.Size = new Size(39, 36);
            btnSearcher.TabIndex = 102;
            btnSearcher.TabStop = false;
            btnSearcher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearcher.UseAccentColor = false;
            btnSearcher.UseVisualStyleBackColor = true;
            // 
            // btnComplete
            // 
            btnComplete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnComplete.AutoSize = false;
            btnComplete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnComplete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnComplete.Depth = 0;
            btnComplete.HighEmphasis = true;
            btnComplete.Icon = null;
            btnComplete.Location = new Point(850, 149);
            btnComplete.Margin = new Padding(4, 6, 4, 6);
            btnComplete.MouseState = MaterialSkin.MouseState.HOVER;
            btnComplete.Name = "btnComplete";
            btnComplete.NoAccentTextColor = Color.Empty;
            btnComplete.Size = new Size(221, 36);
            btnComplete.TabIndex = 108;
            btnComplete.Text = "Complete";
            btnComplete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnComplete.UseAccentColor = false;
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // QRCode
            // 
            QRCode.AllowPromptAsInput = true;
            QRCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            QRCode.AnimateReadOnly = false;
            QRCode.AsciiOnly = false;
            QRCode.BackgroundImageLayout = ImageLayout.None;
            QRCode.BeepOnError = false;
            QRCode.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            QRCode.Depth = 0;
            QRCode.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            QRCode.HidePromptOnLeave = false;
            QRCode.HideSelection = true;
            QRCode.Hint = " Click Here! Then Scan QR";
            QRCode.InsertKeyMode = InsertKeyMode.Default;
            QRCode.LeadingIcon = null;
            QRCode.Location = new Point(3, 54);
            QRCode.Mask = "";
            QRCode.MaxLength = 32767;
            QRCode.MouseState = MaterialSkin.MouseState.OUT;
            QRCode.Name = "QRCode";
            QRCode.PasswordChar = '\0';
            QRCode.PrefixSuffixText = null;
            QRCode.PromptChar = '_';
            QRCode.ReadOnly = false;
            QRCode.RejectInputOnFirstFailure = false;
            QRCode.ResetOnPrompt = true;
            QRCode.ResetOnSpace = true;
            QRCode.RightToLeft = RightToLeft.No;
            QRCode.SelectedText = "";
            QRCode.SelectionLength = 0;
            QRCode.SelectionStart = 0;
            QRCode.ShortcutsEnabled = true;
            QRCode.Size = new Size(222, 36);
            QRCode.SkipLiterals = true;
            QRCode.TabIndex = 110;
            QRCode.TabStop = false;
            QRCode.TextAlign = HorizontalAlignment.Left;
            QRCode.TextMaskFormat = MaskFormat.IncludeLiterals;
            QRCode.TrailingIcon = null;
            QRCode.UseSystemPasswordChar = false;
            QRCode.UseTallSize = false;
            QRCode.ValidatingType = null;
            QRCode.KeyDown += QRCode_KeyDown;
            // 
            // btnQRCode
            // 
            btnQRCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnQRCode.AutoSize = false;
            btnQRCode.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnQRCode.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btnQRCode.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnQRCode.Depth = 0;
            btnQRCode.HighEmphasis = true;
            btnQRCode.Icon = null;
            btnQRCode.Location = new Point(4, 6);
            btnQRCode.Margin = new Padding(4, 6, 4, 6);
            btnQRCode.MouseState = MaterialSkin.MouseState.HOVER;
            btnQRCode.Name = "btnQRCode";
            btnQRCode.NoAccentTextColor = Color.Empty;
            btnQRCode.Size = new Size(221, 39);
            btnQRCode.TabIndex = 112;
            btnQRCode.TabStop = false;
            btnQRCode.Text = "QRCode";
            btnQRCode.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnQRCode.UseAccentColor = false;
            btnQRCode.UseVisualStyleBackColor = true;
            btnQRCode.Click += btnQRCode_Click;
            // 
            // qrCodePanel
            // 
            qrCodePanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            qrCodePanel.Controls.Add(btnQRCode);
            qrCodePanel.Controls.Add(QRCode);
            qrCodePanel.Location = new Point(847, 309);
            qrCodePanel.Name = "qrCodePanel";
            qrCodePanel.Size = new Size(227, 50);
            qrCodePanel.TabIndex = 113;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // btnInqueue
            // 
            btnInqueue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInqueue.AutoSize = false;
            btnInqueue.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInqueue.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btnInqueue.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnInqueue.Depth = 0;
            btnInqueue.HighEmphasis = true;
            btnInqueue.Icon = null;
            btnInqueue.Location = new Point(850, 551);
            btnInqueue.Margin = new Padding(4, 6, 4, 6);
            btnInqueue.MouseState = MaterialSkin.MouseState.HOVER;
            btnInqueue.Name = "btnInqueue";
            btnInqueue.NoAccentTextColor = Color.Empty;
            btnInqueue.Size = new Size(221, 36);
            btnInqueue.TabIndex = 114;
            btnInqueue.TabStop = false;
            btnInqueue.Text = "Check Receipt Inqueue";
            btnInqueue.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnInqueue.UseAccentColor = false;
            btnInqueue.UseVisualStyleBackColor = true;
            btnInqueue.Click += btnInqueue_Click;
            // 
            // handleAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 621);
            Controls.Add(btnInqueue);
            Controls.Add(qrCodePanel);
            Controls.Add(btnComplete);
            Controls.Add(btnCancel);
            Controls.Add(btnRefresher);
            Controls.Add(btnApprove);
            Controls.Add(txtSearchBoxes);
            Controls.Add(btnSearcher);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "handleAppointment";
            Text = "handleAppointment";
            Load += handleAppointment_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewPendingAppointment).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewApprovedAppointment).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewCancelledAppointment).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewCompletedAppointment).EndInit();
            qrCodePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private DataGridView viewPendingAppointment;
        private TabPage tabPage3;
        private DataGridView viewApprovedAppointment;
        private TabPage tabPage4;
        private DataGridView viewCancelledAppointment;
        private TabPage tabPage1;
        private DataGridView viewCompletedAppointment;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnRefresher;
        private MaterialSkin.Controls.MaterialButton btnApprove;
        private MaterialSkin.Controls.MaterialTextBox txtSearchBoxes;
        private MaterialSkin.Controls.MaterialButton btnSearcher;
        private MaterialSkin.Controls.MaterialButton btnComplete;
        private MaterialSkin.Controls.MaterialMaskedTextBox QRCode;
        private MaterialSkin.Controls.MaterialButton btnQRCode;
        private FlowLayoutPanel qrCodePanel;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialButton btnInqueue;
    }
}