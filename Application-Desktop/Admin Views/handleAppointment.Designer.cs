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
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle34 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
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
            btnPrintReceipt = new MaterialSkin.Controls.MaterialButton();
            btnApprove = new MaterialSkin.Controls.MaterialButton();
            txtSearchBoxes = new MaterialSkin.Controls.MaterialTextBox();
            btnSearcher = new MaterialSkin.Controls.MaterialButton();
            btnComplete = new MaterialSkin.Controls.MaterialButton();
            btnReschedule = new MaterialSkin.Controls.MaterialButton();
            QRCode = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btnQRCode = new MaterialSkin.Controls.MaterialButton();
            qrCodePanel = new FlowLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
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
            dataGridViewCellStyle25.BackColor = Color.LightYellow;
            dataGridViewCellStyle25.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle25.ForeColor = Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle25.SelectionForeColor = Color.Black;
            viewPendingAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            viewPendingAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewPendingAppointment.BackgroundColor = Color.White;
            viewPendingAppointment.BorderStyle = BorderStyle.None;
            viewPendingAppointment.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewPendingAppointment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle26.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle26.ForeColor = Color.Black;
            dataGridViewCellStyle26.NullValue = "N/A";
            dataGridViewCellStyle26.Padding = new Padding(3);
            dataGridViewCellStyle26.SelectionBackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle26.SelectionForeColor = Color.Black;
            dataGridViewCellStyle26.WrapMode = DataGridViewTriState.False;
            viewPendingAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            viewPendingAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = Color.White;
            dataGridViewCellStyle27.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle27.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle27.NullValue = "N/A";
            dataGridViewCellStyle27.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle27.SelectionBackColor = Color.White;
            dataGridViewCellStyle27.SelectionForeColor = Color.Black;
            dataGridViewCellStyle27.WrapMode = DataGridViewTriState.True;
            viewPendingAppointment.DefaultCellStyle = dataGridViewCellStyle27;
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
            dataGridViewCellStyle28.BackColor = Color.LightYellow;
            dataGridViewCellStyle28.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle28.ForeColor = Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle28.SelectionForeColor = Color.Black;
            viewApprovedAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            viewApprovedAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewApprovedAppointment.BackgroundColor = Color.White;
            viewApprovedAppointment.BorderStyle = BorderStyle.None;
            viewApprovedAppointment.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewApprovedAppointment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle29.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle29.ForeColor = Color.Black;
            dataGridViewCellStyle29.NullValue = "N/A";
            dataGridViewCellStyle29.Padding = new Padding(3);
            dataGridViewCellStyle29.SelectionBackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle29.SelectionForeColor = Color.Black;
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.False;
            viewApprovedAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            viewApprovedAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewApprovedAppointment.Cursor = Cursors.Default;
            dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = SystemColors.Window;
            dataGridViewCellStyle30.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle30.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle30.NullValue = "N/A";
            dataGridViewCellStyle30.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle30.SelectionBackColor = Color.White;
            dataGridViewCellStyle30.SelectionForeColor = Color.Black;
            dataGridViewCellStyle30.WrapMode = DataGridViewTriState.True;
            viewApprovedAppointment.DefaultCellStyle = dataGridViewCellStyle30;
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
            dataGridViewCellStyle31.BackColor = Color.LightYellow;
            dataGridViewCellStyle31.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle31.ForeColor = Color.Black;
            dataGridViewCellStyle31.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle31.SelectionForeColor = Color.Black;
            viewCancelledAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            viewCancelledAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewCancelledAppointment.BackgroundColor = Color.White;
            viewCancelledAppointment.BorderStyle = BorderStyle.None;
            viewCancelledAppointment.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewCancelledAppointment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle32.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle32.ForeColor = Color.Black;
            dataGridViewCellStyle32.NullValue = "N/A";
            dataGridViewCellStyle32.Padding = new Padding(3);
            dataGridViewCellStyle32.SelectionBackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle32.SelectionForeColor = Color.Black;
            dataGridViewCellStyle32.WrapMode = DataGridViewTriState.False;
            viewCancelledAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            viewCancelledAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle33.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = SystemColors.Window;
            dataGridViewCellStyle33.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle33.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle33.NullValue = "N/A";
            dataGridViewCellStyle33.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle33.SelectionBackColor = Color.White;
            dataGridViewCellStyle33.SelectionForeColor = Color.Black;
            dataGridViewCellStyle33.WrapMode = DataGridViewTriState.True;
            viewCancelledAppointment.DefaultCellStyle = dataGridViewCellStyle33;
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
            dataGridViewCellStyle34.BackColor = Color.LightYellow;
            dataGridViewCellStyle34.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle34.ForeColor = Color.Black;
            dataGridViewCellStyle34.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle34.SelectionForeColor = Color.Black;
            viewCompletedAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            viewCompletedAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewCompletedAppointment.BackgroundColor = Color.White;
            viewCompletedAppointment.BorderStyle = BorderStyle.None;
            viewCompletedAppointment.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewCompletedAppointment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle35.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle35.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle35.ForeColor = Color.Black;
            dataGridViewCellStyle35.NullValue = "N/A";
            dataGridViewCellStyle35.Padding = new Padding(3);
            dataGridViewCellStyle35.SelectionBackColor = Color.FromArgb(250, 220, 18);
            dataGridViewCellStyle35.SelectionForeColor = Color.Black;
            dataGridViewCellStyle35.WrapMode = DataGridViewTriState.False;
            viewCompletedAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            viewCompletedAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = SystemColors.Window;
            dataGridViewCellStyle36.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle36.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle36.NullValue = "N/A";
            dataGridViewCellStyle36.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle36.SelectionBackColor = Color.White;
            dataGridViewCellStyle36.SelectionForeColor = Color.Black;
            dataGridViewCellStyle36.WrapMode = DataGridViewTriState.True;
            viewCompletedAppointment.DefaultCellStyle = dataGridViewCellStyle36;
            viewCompletedAppointment.Dock = DockStyle.Fill;
            viewCompletedAppointment.EnableHeadersVisualStyles = false;
            viewCompletedAppointment.Location = new Point(3, 3);
            viewCompletedAppointment.Margin = new Padding(0);
            viewCompletedAppointment.Name = "viewCompletedAppointment";
            viewCompletedAppointment.ReadOnly = true;
            viewCompletedAppointment.RowTemplate.Height = 25;
            viewCompletedAppointment.Size = new Size(823, 549);
            viewCompletedAppointment.TabIndex = 24;
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
            // btnPrintReceipt
            // 
            btnPrintReceipt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrintReceipt.AutoSize = false;
            btnPrintReceipt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPrintReceipt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPrintReceipt.Depth = 0;
            btnPrintReceipt.HighEmphasis = true;
            btnPrintReceipt.Icon = null;
            btnPrintReceipt.Location = new Point(846, 554);
            btnPrintReceipt.Margin = new Padding(4, 6, 4, 6);
            btnPrintReceipt.MouseState = MaterialSkin.MouseState.HOVER;
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.NoAccentTextColor = Color.Empty;
            btnPrintReceipt.Size = new Size(228, 36);
            btnPrintReceipt.TabIndex = 105;
            btnPrintReceipt.Text = "Print Receipt";
            btnPrintReceipt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPrintReceipt.UseAccentColor = false;
            btnPrintReceipt.UseVisualStyleBackColor = true;
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
            // 
            // btnReschedule
            // 
            btnReschedule.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReschedule.AutoSize = false;
            btnReschedule.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReschedule.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReschedule.Depth = 0;
            btnReschedule.HighEmphasis = true;
            btnReschedule.Icon = null;
            btnReschedule.Location = new Point(850, 219);
            btnReschedule.Margin = new Padding(4, 6, 4, 6);
            btnReschedule.MouseState = MaterialSkin.MouseState.HOVER;
            btnReschedule.Name = "btnReschedule";
            btnReschedule.NoAccentTextColor = Color.Empty;
            btnReschedule.Size = new Size(221, 36);
            btnReschedule.TabIndex = 109;
            btnReschedule.TabStop = false;
            btnReschedule.Text = "Reschedule";
            btnReschedule.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnReschedule.UseAccentColor = false;
            btnReschedule.UseVisualStyleBackColor = true;
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
            // handleAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 621);
            Controls.Add(qrCodePanel);
            Controls.Add(btnReschedule);
            Controls.Add(btnComplete);
            Controls.Add(btnCancel);
            Controls.Add(btnRefresher);
            Controls.Add(btnPrintReceipt);
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
        private MaterialSkin.Controls.MaterialButton btnPrintReceipt;
        private MaterialSkin.Controls.MaterialButton btnApprove;
        private MaterialSkin.Controls.MaterialTextBox txtSearchBoxes;
        private MaterialSkin.Controls.MaterialButton btnSearcher;
        private MaterialSkin.Controls.MaterialButton btnComplete;
        private MaterialSkin.Controls.MaterialButton btnReschedule;
        private MaterialSkin.Controls.MaterialMaskedTextBox QRCode;
        private MaterialSkin.Controls.MaterialButton btnQRCode;
        private FlowLayoutPanel qrCodePanel;
        private System.Windows.Forms.Timer timer1;
    }
}