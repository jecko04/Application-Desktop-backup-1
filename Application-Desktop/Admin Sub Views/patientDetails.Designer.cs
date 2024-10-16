namespace Application_Desktop.Admin_Sub_Views
{
    partial class patientDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patientDetails));
            dentHealthTab = new TabControl();
            dentalPatientTab = new TabPage();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            txtgenter = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtEmergContact = new MaterialSkin.Controls.MaterialTextBox();
            txtEmergFullname = new MaterialSkin.Controls.MaterialTextBox();
            txtAge = new MaterialSkin.Controls.MaterialTextBox();
            txtAddress = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            txtFemale = new MaterialSkin.Controls.MaterialRadioButton();
            txtMale = new MaterialSkin.Controls.MaterialRadioButton();
            txtContact = new MaterialSkin.Controls.MaterialTextBox();
            txtFullnames = new MaterialSkin.Controls.MaterialTextBox();
            txtDOB = new DateTimePicker();
            genHealthTab = new TabPage();
            tapPage3 = new TabPage();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            btnClose = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            btnSaveRecord = new MaterialSkin.Controls.MaterialButton();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            txtMedCondition = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            txtCurrentMed = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            txtAllergies = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            txtPastSurg = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            txtFamilyMed = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            txtBloodPres = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            chkHeartDisease = new MaterialSkin.Controls.MaterialCheckbox();
            chkDiabetes = new MaterialSkin.Controls.MaterialCheckbox();
            chkSmoker = new MaterialSkin.Controls.MaterialCheckbox();
            materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            txtPastDent = new MaterialSkin.Controls.MaterialTextBox();
            txtLastVisit = new DateTimePicker();
            chkToothPain = new MaterialSkin.Controls.MaterialCheckbox();
            materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            chkBleedGum = new MaterialSkin.Controls.MaterialCheckbox();
            chkTeethGrin = new MaterialSkin.Controls.MaterialCheckbox();
            chkGumDisease = new MaterialSkin.Controls.MaterialCheckbox();
            chkOrtho = new MaterialSkin.Controls.MaterialCheckbox();
            chkDentImp = new MaterialSkin.Controls.MaterialCheckbox();
            txtToothSens = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            dentHealthTab.SuspendLayout();
            dentalPatientTab.SuspendLayout();
            genHealthTab.SuspendLayout();
            tapPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dentHealthTab
            // 
            dentHealthTab.Controls.Add(dentalPatientTab);
            dentHealthTab.Controls.Add(genHealthTab);
            dentHealthTab.Controls.Add(tapPage3);
            dentHealthTab.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dentHealthTab.ItemSize = new Size(87, 24);
            dentHealthTab.Location = new Point(3, 5);
            dentHealthTab.Multiline = true;
            dentHealthTab.Name = "dentHealthTab";
            dentHealthTab.Padding = new Point(10, 4);
            dentHealthTab.RightToLeft = RightToLeft.No;
            dentHealthTab.SelectedIndex = 0;
            dentHealthTab.Size = new Size(976, 419);
            dentHealthTab.TabIndex = 25;
            // 
            // dentalPatientTab
            // 
            dentalPatientTab.BackColor = Color.White;
            dentalPatientTab.Controls.Add(materialLabel9);
            dentalPatientTab.Controls.Add(materialLabel8);
            dentalPatientTab.Controls.Add(materialLabel7);
            dentalPatientTab.Controls.Add(txtgenter);
            dentalPatientTab.Controls.Add(materialLabel6);
            dentalPatientTab.Controls.Add(materialLabel5);
            dentalPatientTab.Controls.Add(materialLabel4);
            dentalPatientTab.Controls.Add(materialLabel3);
            dentalPatientTab.Controls.Add(materialLabel2);
            dentalPatientTab.Controls.Add(materialLabel1);
            dentalPatientTab.Controls.Add(txtEmergContact);
            dentalPatientTab.Controls.Add(txtEmergFullname);
            dentalPatientTab.Controls.Add(txtAge);
            dentalPatientTab.Controls.Add(txtAddress);
            dentalPatientTab.Controls.Add(txtEmail);
            dentalPatientTab.Controls.Add(txtFemale);
            dentalPatientTab.Controls.Add(txtMale);
            dentalPatientTab.Controls.Add(txtContact);
            dentalPatientTab.Controls.Add(txtFullnames);
            dentalPatientTab.Controls.Add(txtDOB);
            dentalPatientTab.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dentalPatientTab.ForeColor = Color.DimGray;
            dentalPatientTab.Location = new Point(4, 28);
            dentalPatientTab.Name = "dentalPatientTab";
            dentalPatientTab.Padding = new Padding(3);
            dentalPatientTab.Size = new Size(968, 387);
            dentalPatientTab.TabIndex = 0;
            dentalPatientTab.Text = "Dental Patient Details";
            dentalPatientTab.Click += dentalPatientTab_Click;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(659, 243);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(70, 19);
            materialLabel9.TabIndex = 141;
            materialLabel9.Text = "Contact #";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(659, 174);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(67, 19);
            materialLabel8.TabIndex = 140;
            materialLabel8.Text = "Fullname";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(659, 143);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(136, 19);
            materialLabel7.TabIndex = 139;
            materialLabel7.Text = "Emergency contact";
            // 
            // txtgenter
            // 
            txtgenter.AutoSize = true;
            txtgenter.Depth = 0;
            txtgenter.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtgenter.Location = new Point(442, 104);
            txtgenter.MouseState = MaterialSkin.MouseState.HOVER;
            txtgenter.Name = "txtgenter";
            txtgenter.Size = new Size(51, 19);
            txtgenter.TabIndex = 138;
            txtgenter.Text = "Gender";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(659, 33);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(28, 19);
            materialLabel6.TabIndex = 137;
            materialLabel6.Text = "Age";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(443, 33);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(89, 19);
            materialLabel5.TabIndex = 136;
            materialLabel5.Text = "Date of birth";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(27, 243);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(58, 19);
            materialLabel4.TabIndex = 135;
            materialLabel4.Text = "Address";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(27, 174);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(41, 19);
            materialLabel3.TabIndex = 134;
            materialLabel3.Text = "Email";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(27, 104);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(70, 19);
            materialLabel2.TabIndex = 133;
            materialLabel2.Text = "Contact #";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(27, 36);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(67, 19);
            materialLabel1.TabIndex = 132;
            materialLabel1.Text = "Fullname";
            // 
            // txtEmergContact
            // 
            txtEmergContact.AnimateReadOnly = false;
            txtEmergContact.BorderStyle = BorderStyle.None;
            txtEmergContact.Depth = 0;
            txtEmergContact.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmergContact.LeadingIcon = null;
            txtEmergContact.Location = new Point(659, 265);
            txtEmergContact.MaxLength = 50;
            txtEmergContact.MouseState = MaterialSkin.MouseState.OUT;
            txtEmergContact.Multiline = false;
            txtEmergContact.Name = "txtEmergContact";
            txtEmergContact.Size = new Size(269, 36);
            txtEmergContact.TabIndex = 131;
            txtEmergContact.Text = "";
            txtEmergContact.TrailingIcon = null;
            txtEmergContact.UseTallSize = false;
            // 
            // txtEmergFullname
            // 
            txtEmergFullname.AnimateReadOnly = false;
            txtEmergFullname.BorderStyle = BorderStyle.None;
            txtEmergFullname.Depth = 0;
            txtEmergFullname.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmergFullname.LeadingIcon = null;
            txtEmergFullname.Location = new Point(659, 196);
            txtEmergFullname.MaxLength = 50;
            txtEmergFullname.MouseState = MaterialSkin.MouseState.OUT;
            txtEmergFullname.Multiline = false;
            txtEmergFullname.Name = "txtEmergFullname";
            txtEmergFullname.Size = new Size(269, 36);
            txtEmergFullname.TabIndex = 130;
            txtEmergFullname.Text = "";
            txtEmergFullname.TrailingIcon = null;
            txtEmergFullname.UseTallSize = false;
            // 
            // txtAge
            // 
            txtAge.AnimateReadOnly = false;
            txtAge.BorderStyle = BorderStyle.None;
            txtAge.Depth = 0;
            txtAge.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAge.LeadingIcon = null;
            txtAge.Location = new Point(659, 55);
            txtAge.MaxLength = 50;
            txtAge.MouseState = MaterialSkin.MouseState.OUT;
            txtAge.Multiline = false;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(79, 36);
            txtAge.TabIndex = 129;
            txtAge.Text = "";
            txtAge.TrailingIcon = null;
            txtAge.UseTallSize = false;
            // 
            // txtAddress
            // 
            txtAddress.AnimateReadOnly = false;
            txtAddress.BackgroundImageLayout = ImageLayout.None;
            txtAddress.CharacterCasing = CharacterCasing.Normal;
            txtAddress.Depth = 0;
            txtAddress.HideSelection = true;
            txtAddress.Location = new Point(24, 265);
            txtAddress.MaxLength = 32767;
            txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtAddress.Name = "txtAddress";
            txtAddress.PasswordChar = '\0';
            txtAddress.ReadOnly = false;
            txtAddress.ScrollBars = ScrollBars.None;
            txtAddress.SelectedText = "";
            txtAddress.SelectionLength = 0;
            txtAddress.SelectionStart = 0;
            txtAddress.ShortcutsEnabled = true;
            txtAddress.Size = new Size(581, 62);
            txtAddress.TabIndex = 128;
            txtAddress.TabStop = false;
            txtAddress.TextAlign = HorizontalAlignment.Left;
            txtAddress.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(27, 196);
            txtEmail.MaxLength = 50;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(578, 36);
            txtEmail.TabIndex = 126;
            txtEmail.Text = "";
            txtEmail.TrailingIcon = null;
            txtEmail.UseTallSize = false;
            // 
            // txtFemale
            // 
            txtFemale.AutoSize = true;
            txtFemale.Depth = 0;
            txtFemale.Location = new Point(518, 126);
            txtFemale.Margin = new Padding(0);
            txtFemale.MouseLocation = new Point(-1, -1);
            txtFemale.MouseState = MaterialSkin.MouseState.HOVER;
            txtFemale.Name = "txtFemale";
            txtFemale.Ripple = true;
            txtFemale.Size = new Size(87, 37);
            txtFemale.TabIndex = 125;
            txtFemale.TabStop = true;
            txtFemale.Text = "Female";
            txtFemale.UseVisualStyleBackColor = true;
            // 
            // txtMale
            // 
            txtMale.AutoSize = true;
            txtMale.Depth = 0;
            txtMale.Location = new Point(438, 126);
            txtMale.Margin = new Padding(0);
            txtMale.MouseLocation = new Point(-1, -1);
            txtMale.MouseState = MaterialSkin.MouseState.HOVER;
            txtMale.Name = "txtMale";
            txtMale.Ripple = true;
            txtMale.Size = new Size(81, 37);
            txtMale.TabIndex = 124;
            txtMale.TabStop = true;
            txtMale.Text = "Male\r\n";
            txtMale.UseVisualStyleBackColor = true;
            // 
            // txtContact
            // 
            txtContact.AnimateReadOnly = false;
            txtContact.BorderStyle = BorderStyle.None;
            txtContact.Depth = 0;
            txtContact.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtContact.LeadingIcon = null;
            txtContact.Location = new Point(25, 126);
            txtContact.MaxLength = 50;
            txtContact.MouseState = MaterialSkin.MouseState.OUT;
            txtContact.Multiline = false;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(368, 36);
            txtContact.TabIndex = 123;
            txtContact.Text = "";
            txtContact.TrailingIcon = null;
            txtContact.UseTallSize = false;
            // 
            // txtFullnames
            // 
            txtFullnames.AnimateReadOnly = false;
            txtFullnames.BorderStyle = BorderStyle.None;
            txtFullnames.Depth = 0;
            txtFullnames.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFullnames.LeadingIcon = null;
            txtFullnames.Location = new Point(26, 55);
            txtFullnames.MaxLength = 50;
            txtFullnames.MouseState = MaterialSkin.MouseState.OUT;
            txtFullnames.Multiline = false;
            txtFullnames.Name = "txtFullnames";
            txtFullnames.Size = new Size(367, 36);
            txtFullnames.TabIndex = 122;
            txtFullnames.Text = "";
            txtFullnames.TrailingIcon = null;
            txtFullnames.UseTallSize = false;
            // 
            // txtDOB
            // 
            txtDOB.Font = new Font("Tahoma", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDOB.Format = DateTimePickerFormat.Short;
            txtDOB.Location = new Point(442, 57);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(163, 28);
            txtDOB.TabIndex = 5;
            // 
            // genHealthTab
            // 
            genHealthTab.BackColor = Color.White;
            genHealthTab.Controls.Add(chkSmoker);
            genHealthTab.Controls.Add(chkDiabetes);
            genHealthTab.Controls.Add(chkHeartDisease);
            genHealthTab.Controls.Add(materialLabel16);
            genHealthTab.Controls.Add(materialLabel15);
            genHealthTab.Controls.Add(txtBloodPres);
            genHealthTab.Controls.Add(materialLabel14);
            genHealthTab.Controls.Add(txtFamilyMed);
            genHealthTab.Controls.Add(materialLabel13);
            genHealthTab.Controls.Add(txtPastSurg);
            genHealthTab.Controls.Add(materialLabel12);
            genHealthTab.Controls.Add(txtAllergies);
            genHealthTab.Controls.Add(materialLabel11);
            genHealthTab.Controls.Add(txtCurrentMed);
            genHealthTab.Controls.Add(materialLabel10);
            genHealthTab.Controls.Add(txtMedCondition);
            genHealthTab.Location = new Point(4, 28);
            genHealthTab.Name = "genHealthTab";
            genHealthTab.Padding = new Padding(3);
            genHealthTab.Size = new Size(968, 387);
            genHealthTab.TabIndex = 1;
            genHealthTab.Text = "General Health Information";
            // 
            // tapPage3
            // 
            tapPage3.BackColor = Color.White;
            tapPage3.Controls.Add(materialLabel20);
            tapPage3.Controls.Add(txtToothSens);
            tapPage3.Controls.Add(chkDentImp);
            tapPage3.Controls.Add(chkOrtho);
            tapPage3.Controls.Add(chkGumDisease);
            tapPage3.Controls.Add(chkTeethGrin);
            tapPage3.Controls.Add(chkBleedGum);
            tapPage3.Controls.Add(chkToothPain);
            tapPage3.Controls.Add(materialLabel19);
            tapPage3.Controls.Add(materialLabel17);
            tapPage3.Controls.Add(materialLabel18);
            tapPage3.Controls.Add(txtPastDent);
            tapPage3.Controls.Add(txtLastVisit);
            tapPage3.Location = new Point(4, 28);
            tapPage3.Name = "tapPage3";
            tapPage3.Padding = new Padding(3);
            tapPage3.Size = new Size(968, 387);
            tapPage3.TabIndex = 2;
            tapPage3.Text = "Dental Health Information";
            tapPage3.Click += tapPage3_Click;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 15;
            elipseControl1.TargetControl = this;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(948, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 122;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.AutoSize = false;
            btnSaveRecord.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaveRecord.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSaveRecord.Depth = 0;
            btnSaveRecord.HighEmphasis = true;
            btnSaveRecord.Icon = null;
            btnSaveRecord.Location = new Point(853, 425);
            btnSaveRecord.Margin = new Padding(4, 6, 4, 6);
            btnSaveRecord.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.NoAccentTextColor = Color.Empty;
            btnSaveRecord.Size = new Size(122, 36);
            btnSaveRecord.TabIndex = 123;
            btnSaveRecord.Text = "Save";
            btnSaveRecord.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSaveRecord.UseAccentColor = false;
            btnSaveRecord.UseVisualStyleBackColor = true;
            btnSaveRecord.Click += btnSaveRecord_Click;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(32, 41);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(129, 19);
            materialLabel10.TabIndex = 143;
            materialLabel10.Text = "Medical Condition";
            // 
            // txtMedCondition
            // 
            txtMedCondition.AnimateReadOnly = false;
            txtMedCondition.BorderStyle = BorderStyle.None;
            txtMedCondition.Depth = 0;
            txtMedCondition.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMedCondition.LeadingIcon = null;
            txtMedCondition.Location = new Point(31, 60);
            txtMedCondition.MaxLength = 50;
            txtMedCondition.MouseState = MaterialSkin.MouseState.OUT;
            txtMedCondition.Multiline = false;
            txtMedCondition.Name = "txtMedCondition";
            txtMedCondition.Size = new Size(422, 36);
            txtMedCondition.TabIndex = 142;
            txtMedCondition.Text = "";
            txtMedCondition.TrailingIcon = null;
            txtMedCondition.UseTallSize = false;
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(32, 109);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(135, 19);
            materialLabel11.TabIndex = 145;
            materialLabel11.Text = "Current Medication";
            // 
            // txtCurrentMed
            // 
            txtCurrentMed.AnimateReadOnly = false;
            txtCurrentMed.BackgroundImageLayout = ImageLayout.None;
            txtCurrentMed.CharacterCasing = CharacterCasing.Normal;
            txtCurrentMed.Depth = 0;
            txtCurrentMed.HideSelection = true;
            txtCurrentMed.Location = new Point(29, 131);
            txtCurrentMed.MaxLength = 32767;
            txtCurrentMed.MouseState = MaterialSkin.MouseState.OUT;
            txtCurrentMed.Name = "txtCurrentMed";
            txtCurrentMed.PasswordChar = '\0';
            txtCurrentMed.ReadOnly = false;
            txtCurrentMed.ScrollBars = ScrollBars.None;
            txtCurrentMed.SelectedText = "";
            txtCurrentMed.SelectionLength = 0;
            txtCurrentMed.SelectionStart = 0;
            txtCurrentMed.ShortcutsEnabled = true;
            txtCurrentMed.Size = new Size(424, 62);
            txtCurrentMed.TabIndex = 144;
            txtCurrentMed.TabStop = false;
            txtCurrentMed.TextAlign = HorizontalAlignment.Left;
            txtCurrentMed.UseSystemPasswordChar = false;
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(32, 207);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(61, 19);
            materialLabel12.TabIndex = 147;
            materialLabel12.Text = "Allergies";
            // 
            // txtAllergies
            // 
            txtAllergies.AnimateReadOnly = false;
            txtAllergies.BorderStyle = BorderStyle.None;
            txtAllergies.Depth = 0;
            txtAllergies.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAllergies.LeadingIcon = null;
            txtAllergies.Location = new Point(31, 226);
            txtAllergies.MaxLength = 50;
            txtAllergies.MouseState = MaterialSkin.MouseState.OUT;
            txtAllergies.Multiline = false;
            txtAllergies.Name = "txtAllergies";
            txtAllergies.Size = new Size(422, 36);
            txtAllergies.TabIndex = 146;
            txtAllergies.Text = "";
            txtAllergies.TrailingIcon = null;
            txtAllergies.UseTallSize = false;
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.Location = new Point(31, 276);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(187, 19);
            materialLabel13.TabIndex = 149;
            materialLabel13.Text = "Past Surgeries / Operation";
            // 
            // txtPastSurg
            // 
            txtPastSurg.AnimateReadOnly = false;
            txtPastSurg.BorderStyle = BorderStyle.None;
            txtPastSurg.Depth = 0;
            txtPastSurg.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPastSurg.LeadingIcon = null;
            txtPastSurg.Location = new Point(30, 295);
            txtPastSurg.MaxLength = 50;
            txtPastSurg.MouseState = MaterialSkin.MouseState.OUT;
            txtPastSurg.Multiline = false;
            txtPastSurg.Name = "txtPastSurg";
            txtPastSurg.Size = new Size(422, 36);
            txtPastSurg.TabIndex = 148;
            txtPastSurg.Text = "";
            txtPastSurg.TrailingIcon = null;
            txtPastSurg.UseTallSize = false;
            // 
            // materialLabel14
            // 
            materialLabel14.AutoSize = true;
            materialLabel14.Depth = 0;
            materialLabel14.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel14.Location = new Point(492, 41);
            materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel14.Name = "materialLabel14";
            materialLabel14.Size = new Size(163, 19);
            materialLabel14.TabIndex = 151;
            materialLabel14.Text = "Family Medical History";
            materialLabel14.Click += materialLabel14_Click;
            // 
            // txtFamilyMed
            // 
            txtFamilyMed.AnimateReadOnly = false;
            txtFamilyMed.BorderStyle = BorderStyle.None;
            txtFamilyMed.Depth = 0;
            txtFamilyMed.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFamilyMed.LeadingIcon = null;
            txtFamilyMed.Location = new Point(491, 60);
            txtFamilyMed.MaxLength = 50;
            txtFamilyMed.MouseState = MaterialSkin.MouseState.OUT;
            txtFamilyMed.Multiline = false;
            txtFamilyMed.Name = "txtFamilyMed";
            txtFamilyMed.Size = new Size(422, 36);
            txtFamilyMed.TabIndex = 150;
            txtFamilyMed.Text = "";
            txtFamilyMed.TrailingIcon = null;
            txtFamilyMed.UseTallSize = false;
            // 
            // materialLabel15
            // 
            materialLabel15.AutoSize = true;
            materialLabel15.Depth = 0;
            materialLabel15.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel15.Location = new Point(492, 109);
            materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel15.Name = "materialLabel15";
            materialLabel15.Size = new Size(107, 19);
            materialLabel15.TabIndex = 153;
            materialLabel15.Text = "Blood Pressure";
            // 
            // txtBloodPres
            // 
            txtBloodPres.AnimateReadOnly = false;
            txtBloodPres.BorderStyle = BorderStyle.None;
            txtBloodPres.Depth = 0;
            txtBloodPres.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBloodPres.LeadingIcon = null;
            txtBloodPres.Location = new Point(491, 128);
            txtBloodPres.MaxLength = 50;
            txtBloodPres.MouseState = MaterialSkin.MouseState.OUT;
            txtBloodPres.Multiline = false;
            txtBloodPres.Name = "txtBloodPres";
            txtBloodPres.Size = new Size(422, 36);
            txtBloodPres.TabIndex = 152;
            txtBloodPres.Text = "";
            txtBloodPres.TrailingIcon = null;
            txtBloodPres.UseTallSize = false;
            // 
            // materialLabel16
            // 
            materialLabel16.AutoSize = true;
            materialLabel16.Depth = 0;
            materialLabel16.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel16.Location = new Point(491, 207);
            materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel16.Name = "materialLabel16";
            materialLabel16.Size = new Size(251, 19);
            materialLabel16.TabIndex = 154;
            materialLabel16.Text = "Check if 'Yes', Leave Uncheck if 'No'";
            // 
            // chkHeartDisease
            // 
            chkHeartDisease.AutoSize = true;
            chkHeartDisease.Depth = 0;
            chkHeartDisease.Location = new Point(492, 238);
            chkHeartDisease.Margin = new Padding(0);
            chkHeartDisease.MouseLocation = new Point(-1, -1);
            chkHeartDisease.MouseState = MaterialSkin.MouseState.HOVER;
            chkHeartDisease.Name = "chkHeartDisease";
            chkHeartDisease.ReadOnly = false;
            chkHeartDisease.Ripple = true;
            chkHeartDisease.Size = new Size(141, 37);
            chkHeartDisease.TabIndex = 155;
            chkHeartDisease.Text = "Heart Disease?";
            chkHeartDisease.UseVisualStyleBackColor = true;
            // 
            // chkDiabetes
            // 
            chkDiabetes.AutoSize = true;
            chkDiabetes.Depth = 0;
            chkDiabetes.Location = new Point(662, 238);
            chkDiabetes.Margin = new Padding(0);
            chkDiabetes.MouseLocation = new Point(-1, -1);
            chkDiabetes.MouseState = MaterialSkin.MouseState.HOVER;
            chkDiabetes.Name = "chkDiabetes";
            chkDiabetes.ReadOnly = false;
            chkDiabetes.Ripple = true;
            chkDiabetes.Size = new Size(105, 37);
            chkDiabetes.TabIndex = 156;
            chkDiabetes.Text = "Diabetes?";
            chkDiabetes.UseVisualStyleBackColor = true;
            // 
            // chkSmoker
            // 
            chkSmoker.AutoSize = true;
            chkSmoker.Depth = 0;
            chkSmoker.Location = new Point(808, 238);
            chkSmoker.Margin = new Padding(0);
            chkSmoker.MouseLocation = new Point(-1, -1);
            chkSmoker.MouseState = MaterialSkin.MouseState.HOVER;
            chkSmoker.Name = "chkSmoker";
            chkSmoker.ReadOnly = false;
            chkSmoker.Ripple = true;
            chkSmoker.Size = new Size(97, 37);
            chkSmoker.TabIndex = 157;
            chkSmoker.Text = "Smoker?";
            chkSmoker.UseVisualStyleBackColor = true;
            // 
            // materialLabel17
            // 
            materialLabel17.AutoSize = true;
            materialLabel17.Depth = 0;
            materialLabel17.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel17.Location = new Point(111, 39);
            materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel17.Name = "materialLabel17";
            materialLabel17.Size = new Size(121, 19);
            materialLabel17.TabIndex = 156;
            materialLabel17.Text = "Last dental visits";
            // 
            // materialLabel18
            // 
            materialLabel18.AutoSize = true;
            materialLabel18.Depth = 0;
            materialLabel18.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel18.Location = new Point(335, 39);
            materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel18.Name = "materialLabel18";
            materialLabel18.Size = new Size(161, 19);
            materialLabel18.TabIndex = 155;
            materialLabel18.Text = "Past dental treatments";
            // 
            // txtPastDent
            // 
            txtPastDent.AnimateReadOnly = false;
            txtPastDent.BorderStyle = BorderStyle.None;
            txtPastDent.Depth = 0;
            txtPastDent.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPastDent.LeadingIcon = null;
            txtPastDent.Location = new Point(334, 58);
            txtPastDent.MaxLength = 50;
            txtPastDent.MouseState = MaterialSkin.MouseState.OUT;
            txtPastDent.Multiline = false;
            txtPastDent.Name = "txtPastDent";
            txtPastDent.Size = new Size(525, 36);
            txtPastDent.TabIndex = 154;
            txtPastDent.Text = "";
            txtPastDent.TrailingIcon = null;
            txtPastDent.UseTallSize = false;
            // 
            // txtLastVisit
            // 
            txtLastVisit.Font = new Font("Tahoma", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastVisit.Format = DateTimePickerFormat.Short;
            txtLastVisit.Location = new Point(110, 63);
            txtLastVisit.Name = "txtLastVisit";
            txtLastVisit.Size = new Size(163, 28);
            txtLastVisit.TabIndex = 153;
            // 
            // chkToothPain
            // 
            chkToothPain.AutoSize = true;
            chkToothPain.Depth = 0;
            chkToothPain.Location = new Point(111, 168);
            chkToothPain.Margin = new Padding(0);
            chkToothPain.MouseLocation = new Point(-1, -1);
            chkToothPain.MouseState = MaterialSkin.MouseState.HOVER;
            chkToothPain.Name = "chkToothPain";
            chkToothPain.ReadOnly = false;
            chkToothPain.Ripple = true;
            chkToothPain.Size = new Size(187, 37);
            chkToothPain.TabIndex = 158;
            chkToothPain.Text = "Frequent Tooth Pain?";
            chkToothPain.UseVisualStyleBackColor = true;
            // 
            // materialLabel19
            // 
            materialLabel19.AutoSize = true;
            materialLabel19.Depth = 0;
            materialLabel19.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel19.Location = new Point(110, 134);
            materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel19.Name = "materialLabel19";
            materialLabel19.Size = new Size(251, 19);
            materialLabel19.TabIndex = 157;
            materialLabel19.Text = "Check if 'Yes', Leave Uncheck if 'No'";
            // 
            // chkBleedGum
            // 
            chkBleedGum.AutoSize = true;
            chkBleedGum.Depth = 0;
            chkBleedGum.Location = new Point(346, 168);
            chkBleedGum.Margin = new Padding(0);
            chkBleedGum.MouseLocation = new Point(-1, -1);
            chkBleedGum.MouseState = MaterialSkin.MouseState.HOVER;
            chkBleedGum.Name = "chkBleedGum";
            chkBleedGum.ReadOnly = false;
            chkBleedGum.Ripple = true;
            chkBleedGum.Size = new Size(150, 37);
            chkBleedGum.TabIndex = 159;
            chkBleedGum.Text = "Bleeding Gums?";
            chkBleedGum.UseVisualStyleBackColor = true;
            // 
            // chkTeethGrin
            // 
            chkTeethGrin.AutoSize = true;
            chkTeethGrin.Depth = 0;
            chkTeethGrin.Location = new Point(574, 168);
            chkTeethGrin.Margin = new Padding(0);
            chkTeethGrin.MouseLocation = new Point(-1, -1);
            chkTeethGrin.MouseState = MaterialSkin.MouseState.HOVER;
            chkTeethGrin.Name = "chkTeethGrin";
            chkTeethGrin.ReadOnly = false;
            chkTeethGrin.Ripple = true;
            chkTeethGrin.Size = new Size(147, 37);
            chkTeethGrin.TabIndex = 160;
            chkTeethGrin.Text = "Teeth Grinding?";
            chkTeethGrin.UseVisualStyleBackColor = true;
            // 
            // chkGumDisease
            // 
            chkGumDisease.AutoSize = true;
            chkGumDisease.Depth = 0;
            chkGumDisease.Location = new Point(111, 215);
            chkGumDisease.Margin = new Padding(0);
            chkGumDisease.MouseLocation = new Point(-1, -1);
            chkGumDisease.MouseState = MaterialSkin.MouseState.HOVER;
            chkGumDisease.Name = "chkGumDisease";
            chkGumDisease.ReadOnly = false;
            chkGumDisease.Ripple = true;
            chkGumDisease.Size = new Size(191, 37);
            chkGumDisease.TabIndex = 161;
            chkGumDisease.Text = "Gum Disease History?";
            chkGumDisease.UseVisualStyleBackColor = true;
            // 
            // chkOrtho
            // 
            chkOrtho.AutoSize = true;
            chkOrtho.Depth = 0;
            chkOrtho.Location = new Point(346, 212);
            chkOrtho.Margin = new Padding(0);
            chkOrtho.MouseLocation = new Point(-1, -1);
            chkOrtho.MouseState = MaterialSkin.MouseState.HOVER;
            chkOrtho.Name = "chkOrtho";
            chkOrtho.ReadOnly = false;
            chkOrtho.Ripple = true;
            chkOrtho.Size = new Size(195, 37);
            chkOrtho.TabIndex = 162;
            chkOrtho.Text = "Orthodontic Treatment";
            chkOrtho.UseVisualStyleBackColor = true;
            // 
            // chkDentImp
            // 
            chkDentImp.AutoSize = true;
            chkDentImp.Depth = 0;
            chkDentImp.Location = new Point(574, 212);
            chkDentImp.Margin = new Padding(0);
            chkDentImp.MouseLocation = new Point(-1, -1);
            chkDentImp.MouseState = MaterialSkin.MouseState.HOVER;
            chkDentImp.Name = "chkDentImp";
            chkDentImp.ReadOnly = false;
            chkDentImp.Ripple = true;
            chkDentImp.Size = new Size(147, 37);
            chkDentImp.TabIndex = 163;
            chkDentImp.Text = "Dental Implants";
            chkDentImp.UseVisualStyleBackColor = true;
            // 
            // txtToothSens
            // 
            txtToothSens.AutoResize = false;
            txtToothSens.BackColor = Color.FromArgb(255, 255, 255);
            txtToothSens.Depth = 0;
            txtToothSens.DrawMode = DrawMode.OwnerDrawVariable;
            txtToothSens.DropDownHeight = 118;
            txtToothSens.DropDownStyle = ComboBoxStyle.DropDownList;
            txtToothSens.DropDownWidth = 121;
            txtToothSens.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtToothSens.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtToothSens.FormattingEnabled = true;
            txtToothSens.Hint = "Choose tooth sensitivity if there's any";
            txtToothSens.IntegralHeight = false;
            txtToothSens.ItemHeight = 29;
            txtToothSens.Location = new Point(111, 302);
            txtToothSens.MaxDropDownItems = 4;
            txtToothSens.MouseState = MaterialSkin.MouseState.OUT;
            txtToothSens.Name = "txtToothSens";
            txtToothSens.Size = new Size(748, 35);
            txtToothSens.StartIndex = 0;
            txtToothSens.TabIndex = 164;
            txtToothSens.UseTallSize = false;
            // 
            // materialLabel20
            // 
            materialLabel20.AutoSize = true;
            materialLabel20.Depth = 0;
            materialLabel20.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel20.Location = new Point(111, 280);
            materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel20.Name = "materialLabel20";
            materialLabel20.Size = new Size(128, 19);
            materialLabel20.TabIndex = 165;
            materialLabel20.Text = "Tooth Sensitivity?";
            // 
            // patientDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(984, 476);
            Controls.Add(btnSaveRecord);
            Controls.Add(btnClose);
            Controls.Add(dentHealthTab);
            FormBorderStyle = FormBorderStyle.None;
            Name = "patientDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "patientDetails";
            Load += patientDetails_Load;
            dentHealthTab.ResumeLayout(false);
            dentalPatientTab.ResumeLayout(false);
            dentalPatientTab.PerformLayout();
            genHealthTab.ResumeLayout(false);
            genHealthTab.PerformLayout();
            tapPage3.ResumeLayout(false);
            tapPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl dentHealthTab;
        private TabPage dentalPatientTab;
        private Panel borderFullname;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private TextBox txtFullname;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private DateTimePicker txtDOB;
        private TabPage tapPage3;
        private PictureBox btnClose;
        private TabPage genHealthTab;
        private ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialTextBox txtFullnames;
        private MaterialSkin.Controls.MaterialTextBox txtContact;
        private MaterialSkin.Controls.MaterialRadioButton txtFemale;
        private MaterialSkin.Controls.MaterialRadioButton txtMale;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtAddress;
        private MaterialSkin.Controls.MaterialTextBox txtAge;
        private MaterialSkin.Controls.MaterialTextBox txtEmergFullname;
        private MaterialSkin.Controls.MaterialTextBox txtEmergContact;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel txtgenter;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnSaveRecord;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTextBox txtMedCondition;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialTextBox txtFamilyMed;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialTextBox txtPastSurg;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialTextBox txtAllergies;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtCurrentMed;
        private MaterialSkin.Controls.MaterialCheckbox chkSmoker;
        private MaterialSkin.Controls.MaterialCheckbox chkDiabetes;
        private MaterialSkin.Controls.MaterialCheckbox chkHeartDisease;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialTextBox txtBloodPres;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialComboBox txtToothSens;
        private MaterialSkin.Controls.MaterialCheckbox chkDentImp;
        private MaterialSkin.Controls.MaterialCheckbox chkOrtho;
        private MaterialSkin.Controls.MaterialCheckbox chkGumDisease;
        private MaterialSkin.Controls.MaterialCheckbox chkTeethGrin;
        private MaterialSkin.Controls.MaterialCheckbox chkBleedGum;
        private MaterialSkin.Controls.MaterialCheckbox chkToothPain;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialTextBox txtPastDent;
        private DateTimePicker txtLastVisit;
    }
}