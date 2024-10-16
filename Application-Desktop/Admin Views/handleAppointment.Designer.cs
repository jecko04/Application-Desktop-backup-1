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
            btnDeketeRecord = new MaterialSkin.Controls.MaterialButton();
            btnRefresher = new MaterialSkin.Controls.MaterialButton();
            btnExportRecord = new MaterialSkin.Controls.MaterialButton();
            btnCreateRecord = new MaterialSkin.Controls.MaterialButton();
            txtSearchBoxes = new MaterialSkin.Controls.MaterialTextBox();
            btnSearcher = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewPendingAppointment).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewApprovedAppointment).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewCancelledAppointment).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewCompletedAppointment).BeginInit();
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
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
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
            // 
            // btnDeketeRecord
            // 
            btnDeketeRecord.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeketeRecord.AutoSize = false;
            btnDeketeRecord.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeketeRecord.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeketeRecord.Depth = 0;
            btnDeketeRecord.HighEmphasis = true;
            btnDeketeRecord.Icon = null;
            btnDeketeRecord.Location = new Point(964, 111);
            btnDeketeRecord.Margin = new Padding(4, 6, 4, 6);
            btnDeketeRecord.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeketeRecord.Name = "btnDeketeRecord";
            btnDeketeRecord.NoAccentTextColor = Color.Empty;
            btnDeketeRecord.Size = new Size(111, 36);
            btnDeketeRecord.TabIndex = 107;
            btnDeketeRecord.Text = "Cancel";
            btnDeketeRecord.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeketeRecord.UseAccentColor = true;
            btnDeketeRecord.UseVisualStyleBackColor = true;
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
            btnRefresher.Location = new Point(964, 150);
            btnRefresher.Margin = new Padding(4, 6, 4, 6);
            btnRefresher.MouseState = MaterialSkin.MouseState.HOVER;
            btnRefresher.Name = "btnRefresher";
            btnRefresher.NoAccentTextColor = Color.Empty;
            btnRefresher.Size = new Size(111, 36);
            btnRefresher.TabIndex = 106;
            btnRefresher.Text = "Refesh";
            btnRefresher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRefresher.UseAccentColor = false;
            btnRefresher.UseVisualStyleBackColor = true;
            // 
            // btnExportRecord
            // 
            btnExportRecord.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportRecord.AutoSize = false;
            btnExportRecord.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExportRecord.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExportRecord.Depth = 0;
            btnExportRecord.HighEmphasis = true;
            btnExportRecord.Icon = null;
            btnExportRecord.Location = new Point(846, 554);
            btnExportRecord.Margin = new Padding(4, 6, 4, 6);
            btnExportRecord.MouseState = MaterialSkin.MouseState.HOVER;
            btnExportRecord.Name = "btnExportRecord";
            btnExportRecord.NoAccentTextColor = Color.Empty;
            btnExportRecord.Size = new Size(228, 36);
            btnExportRecord.TabIndex = 105;
            btnExportRecord.Text = "Print Receipt";
            btnExportRecord.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExportRecord.UseAccentColor = false;
            btnExportRecord.UseVisualStyleBackColor = true;
            // 
            // btnCreateRecord
            // 
            btnCreateRecord.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateRecord.AutoSize = false;
            btnCreateRecord.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCreateRecord.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCreateRecord.Depth = 0;
            btnCreateRecord.HighEmphasis = true;
            btnCreateRecord.Icon = null;
            btnCreateRecord.Location = new Point(847, 111);
            btnCreateRecord.Margin = new Padding(4, 6, 4, 6);
            btnCreateRecord.MouseState = MaterialSkin.MouseState.HOVER;
            btnCreateRecord.Name = "btnCreateRecord";
            btnCreateRecord.NoAccentTextColor = Color.Empty;
            btnCreateRecord.Size = new Size(115, 36);
            btnCreateRecord.TabIndex = 104;
            btnCreateRecord.Text = "Approve";
            btnCreateRecord.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCreateRecord.UseAccentColor = false;
            btnCreateRecord.UseVisualStyleBackColor = true;
            // 
            // txtSearchBoxes
            // 
            txtSearchBoxes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchBoxes.AnimateReadOnly = false;
            txtSearchBoxes.BorderStyle = BorderStyle.None;
            txtSearchBoxes.Depth = 0;
            txtSearchBoxes.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearchBoxes.Hint = "Search Appointment";
            txtSearchBoxes.LeadingIcon = null;
            txtSearchBoxes.Location = new Point(846, 35);
            txtSearchBoxes.MaxLength = 50;
            txtSearchBoxes.MouseState = MaterialSkin.MouseState.OUT;
            txtSearchBoxes.Multiline = false;
            txtSearchBoxes.Name = "txtSearchBoxes";
            txtSearchBoxes.Size = new Size(183, 36);
            txtSearchBoxes.TabIndex = 103;
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
            btnSearcher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearcher.UseAccentColor = false;
            btnSearcher.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(847, 150);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(115, 36);
            materialButton1.TabIndex = 108;
            materialButton1.Text = "Complete";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // handleAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 621);
            Controls.Add(materialButton1);
            Controls.Add(btnDeketeRecord);
            Controls.Add(btnRefresher);
            Controls.Add(btnExportRecord);
            Controls.Add(btnCreateRecord);
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
        private MaterialSkin.Controls.MaterialButton btnDeketeRecord;
        private MaterialSkin.Controls.MaterialButton btnRefresher;
        private MaterialSkin.Controls.MaterialButton btnExportRecord;
        private MaterialSkin.Controls.MaterialButton btnCreateRecord;
        private MaterialSkin.Controls.MaterialTextBox txtSearchBoxes;
        private MaterialSkin.Controls.MaterialButton btnSearcher;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}