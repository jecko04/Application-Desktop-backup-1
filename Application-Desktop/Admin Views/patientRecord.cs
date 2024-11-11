using Application_Desktop.Admin_Sub_Views;
using Application_Desktop.Controller;
using Application_Desktop.Method;
using Application_Desktop.Screen;
using Application_Desktop.Sub_Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using static Application_Desktop.Models.EllipseManager;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Application_Desktop.Admin_Views
{
    public partial class patientRecord : Form
    {
        private patientRecordController _patientRecordController;
        public patientRecord()
        {
            _patientRecordController = new patientRecordController();
            InitializeComponent();
            ElipseManager elipseManager = new ElipseManager(5);
            elipseManager.ApplyElipseToAllButtons(this);


        }

        void AlertBox(Color backcolor, Color color, string title, string subtitle, Image icon)
        {
            alertBox alertbox = new alertBox();
            alertbox.BackColor = backcolor;
            alertbox.ColorAlertBox = color;
            alertbox.TitleAlertBox = title;
            alertbox.SubTitleAlertBox = subtitle;
            alertbox.IconAlertBox = icon;
            alertbox.Show();
        }

        private async void patientRecord_Load(object sender, EventArgs e)
        {
            await LoadRecord();

            //btnDeketeRecord.BackColor = ColorTranslator.FromHtml("#ff4200");
        }

        private async Task LoadRecord()
        {
            try
            {
                getBranchIdByUserId branchId = new getBranchIdByUserId();
                BranchID adminId = await branchId.GetUserBranchId();
                DataTable patientData = await _patientRecordController.SelectAllPatientRecord(adminId._id);
                viewPatientRecord.DataSource = null;
                viewPatientRecord.Rows.Clear();
                viewPatientRecord.Columns.Clear();

                viewPatientRecord.AutoGenerateColumns = false;
                AddColumnPatients(viewPatientRecord);

                viewPatientRecord.DataSource = patientData;

                LoadAllPatientRecords(patientData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load patient records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadAllPatientRecords(DataTable patientData)
        {
            try
            {
                DataTable allMedicalRecords = new DataTable();
                DataTable allDentalRecords = new DataTable();

                foreach (DataRow row in patientData.Rows)
                {
                    int patientId = Convert.ToInt32(row["id"]);

                    DataTable medicalRecords = await _patientRecordController.SelectPatientMedicalRecord(patientId);
                    DataTable dentalRecords = await _patientRecordController.SelectPatientDentalRecord(patientId);

                    viewGenHealth.DataSource = null;
                    viewGenHealth.Rows.Clear();
                    viewGenHealth.Columns.Clear();

                    viewGenHealth.AutoGenerateColumns = false;
                    AddColumnMedicalHistory(viewGenHealth);
                    viewGenHealth.DataSource = medicalRecords;

                    viewDentHealth.DataSource = null;
                    viewDentHealth.Rows.Clear();
                    viewDentHealth.Columns.Clear();

                    viewDentHealth.AutoGenerateColumns = false;
                    AddColumnDentalHistory(viewDentHealth);
                    viewDentHealth.DataSource = dentalRecords;

                    // Merge the records into the respective DataTables
                    allMedicalRecords.Merge(medicalRecords);
                    allDentalRecords.Merge(dentalRecords);
                }

                viewGenHealth.DataSource = allMedicalRecords;
                viewDentHealth.DataSource = allDentalRecords;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading all patient records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isProcessingClick = false;
        private editPatientDetails EditPatintInstance;
        private void viewPatientRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit patient details
            if (viewPatientRecord.Columns["edit"] != null &&
                e.ColumnIndex == viewPatientRecord.Columns["edit"].Index && e.RowIndex >= 0)
            {
                // Retrieve the patient ID from the clicked row
                int id = Convert.ToInt32(viewPatientRecord.Rows[e.RowIndex].Cells["id"].Value);

                if (EditPatintInstance == null || EditPatintInstance.IsDisposed)
                {
                    EditPatintInstance = new editPatientDetails(id);
                    EditPatintInstance.Show();
                }
                else
                {
                    if (EditPatintInstance.Visible)
                    {
                        EditPatintInstance.BringToFront();
                    }
                    else
                    {
                        EditPatintInstance.Show();
                    }
                }
            }

            //Select
            if (isProcessingClick) return; // Prevent re-entrance
            isProcessingClick = true;

            try
            {
                // Check if the clicked cell is the checkbox column
                if (e.ColumnIndex == viewPatientRecord.Columns["SelectPatient"].Index)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)viewPatientRecord.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    bool isChecked = cell.Value != null && (bool)cell.Value;
                    cell.Value = !isChecked;

                    viewPatientRecord.Rows[e.RowIndex].Selected = (cell.Value != null && (bool)cell.Value);

                    viewPatientRecord.EndEdit();
                }
            }
            finally
            {
                // Allow clicks again after processing
                isProcessingClick = false;
            }
        }

        private patientDetails PatientDetailsInstance;


        private void AddColumnPatients(DataGridView viewPatients)
        {
            viewPatients.RowHeadersVisible = false;
            viewPatients.ColumnHeadersHeight = 40;


            DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn();
            editButtonColumn.HeaderText = "";
            editButtonColumn.Name = "edit";
            editButtonColumn.Image = Properties.Resources.edit_img;
            editButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editButtonColumn.Width = 50;
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            viewPatients.Columns.Add(editButtonColumn);

            DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
            selectColumn.HeaderText = "";
            selectColumn.Name = "SelectPatient";
            selectColumn.Width = 30;
            selectColumn.ReadOnly = false;
            viewPatients.Columns.Add(selectColumn);

            DataGridViewTextBoxColumn Id = new DataGridViewTextBoxColumn();
            Id.HeaderText = "ID";
            Id.Name = "ID";
            Id.DataPropertyName = "id";
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewPatients.Columns.Add(Id);

            DataGridViewTextBoxColumn Fullname = new DataGridViewTextBoxColumn();
            Fullname.HeaderText = "Full Name";
            Fullname.Name = "Fullname";
            Fullname.DataPropertyName = "fullname";
            Fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewPatients.Columns.Add(Fullname);

            DataGridViewTextBoxColumn DateOfBirth = new DataGridViewTextBoxColumn();
            DateOfBirth.HeaderText = "Date of Birth";
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.DataPropertyName = "date_of_birth";
            DateOfBirth.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewPatients.Columns.Add(DateOfBirth);

            DataGridViewTextBoxColumn Age = new DataGridViewTextBoxColumn();
            Age.HeaderText = "Age";
            Age.Name = "Age";
            Age.DataPropertyName = "age";
            Age.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewPatients.Columns.Add(Age);

            DataGridViewTextBoxColumn Gender = new DataGridViewTextBoxColumn();
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            Gender.DataPropertyName = "gender";
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewPatients.Columns.Add(Gender);

            DataGridViewTextBoxColumn Phone = new DataGridViewTextBoxColumn();
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
            Phone.DataPropertyName = "phone";
            Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewPatients.Columns.Add(Phone);

            DataGridViewTextBoxColumn Email = new DataGridViewTextBoxColumn();
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.DataPropertyName = "email";
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewPatients.Columns.Add(Email);

            DataGridViewTextBoxColumn Address = new DataGridViewTextBoxColumn();
            Address.HeaderText = "Address";
            Address.Name = "Address";
            Address.DataPropertyName = "address";
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewPatients.Columns.Add(Address);

            DataGridViewTextBoxColumn EmergencyContact = new DataGridViewTextBoxColumn();
            EmergencyContact.HeaderText = "Emergency Contact";
            EmergencyContact.Name = "EmergencyContact";
            EmergencyContact.DataPropertyName = "emergency_contact";
            EmergencyContact.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewPatients.Columns.Add(EmergencyContact);

            DataGridViewTextBoxColumn CreatedAt = new DataGridViewTextBoxColumn();
            CreatedAt.HeaderText = "Created At";
            CreatedAt.Name = "CreatedAt";
            CreatedAt.DataPropertyName = "created_at";
            CreatedAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewPatients.Columns.Add(CreatedAt);

            DataGridViewTextBoxColumn UpdatedAt = new DataGridViewTextBoxColumn();
            UpdatedAt.HeaderText = "Updated At";
            UpdatedAt.Name = "UpdatedAt";
            UpdatedAt.DataPropertyName = "updated_at";
            UpdatedAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewPatients.Columns.Add(UpdatedAt);
        }

        private void AddColumnMedicalHistory(DataGridView viewMedicalHistory)
        {
            viewMedicalHistory.RowHeadersVisible = false;
            viewMedicalHistory.ColumnHeadersHeight = 40;

            DataGridViewTextBoxColumn PatientId = new DataGridViewTextBoxColumn();
            PatientId.HeaderText = "ID";
            PatientId.Name = "patient_id";
            PatientId.DataPropertyName = "patient_id";
            PatientId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewMedicalHistory.Columns.Add(PatientId);

            DataGridViewTextBoxColumn Fullname = new DataGridViewTextBoxColumn();
            Fullname.HeaderText = "Full Name";
            Fullname.Name = "Fullname";
            Fullname.DataPropertyName = "fullname";
            Fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewMedicalHistory.Columns.Add(Fullname);

            DataGridViewTextBoxColumn MedicalConditions = new DataGridViewTextBoxColumn();
            MedicalConditions.HeaderText = "Medical Conditions";
            MedicalConditions.Name = "MedicalConditions";
            MedicalConditions.DataPropertyName = "medical_conditions";
            MedicalConditions.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewMedicalHistory.Columns.Add(MedicalConditions);

            DataGridViewTextBoxColumn CurrentMedications = new DataGridViewTextBoxColumn();
            CurrentMedications.HeaderText = "Current Medications";
            CurrentMedications.Name = "CurrentMedications";
            CurrentMedications.DataPropertyName = "current_medications";
            CurrentMedications.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewMedicalHistory.Columns.Add(CurrentMedications);

            DataGridViewTextBoxColumn Allergies = new DataGridViewTextBoxColumn();
            Allergies.HeaderText = "Allergies";
            Allergies.Name = "Allergies";
            Allergies.DataPropertyName = "allergies";
            Allergies.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewMedicalHistory.Columns.Add(Allergies);

            DataGridViewTextBoxColumn PastSurgeries = new DataGridViewTextBoxColumn();
            PastSurgeries.HeaderText = "Past Surgeries";
            PastSurgeries.Name = "PastSurgeries";
            PastSurgeries.DataPropertyName = "past_surgeries";
            PastSurgeries.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewMedicalHistory.Columns.Add(PastSurgeries);

            DataGridViewTextBoxColumn FamilyMedicalHistory = new DataGridViewTextBoxColumn();
            FamilyMedicalHistory.HeaderText = "Family Medical History";
            FamilyMedicalHistory.Name = "FamilyMedicalHistory";
            FamilyMedicalHistory.DataPropertyName = "family_medical_history";
            FamilyMedicalHistory.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewMedicalHistory.Columns.Add(FamilyMedicalHistory);

            DataGridViewTextBoxColumn BloodPressure = new DataGridViewTextBoxColumn();
            BloodPressure.HeaderText = "Blood Pressure";
            BloodPressure.Name = "BloodPressure";
            BloodPressure.DataPropertyName = "blood_pressure";
            BloodPressure.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewMedicalHistory.Columns.Add(BloodPressure);

            DataGridViewTextBoxColumn HeartDisease = new DataGridViewTextBoxColumn();
            HeartDisease.HeaderText = "Heart Disease";
            HeartDisease.Name = "HeartDisease";
            HeartDisease.DataPropertyName = "heart_disease";
            HeartDisease.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewMedicalHistory.Columns.Add(HeartDisease);

            DataGridViewTextBoxColumn Diabetes = new DataGridViewTextBoxColumn();
            Diabetes.HeaderText = "Diabetes";
            Diabetes.Name = "Diabetes";
            Diabetes.DataPropertyName = "diabetes";
            Diabetes.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewMedicalHistory.Columns.Add(Diabetes);

            DataGridViewTextBoxColumn Smoker = new DataGridViewTextBoxColumn();
            Smoker.HeaderText = "Smoker";
            Smoker.Name = "Smoker";
            Smoker.DataPropertyName = "smoker";
            Smoker.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewMedicalHistory.Columns.Add(Smoker);
        }

        private void AddColumnDentalHistory(DataGridView viewDentalHistory)

        {
            viewDentalHistory.RowHeadersVisible = false;
            viewDentalHistory.ColumnHeadersHeight = 40;

            DataGridViewTextBoxColumn PatientId = new DataGridViewTextBoxColumn();
            PatientId.HeaderText = "ID";
            PatientId.Name = "patient_id";
            PatientId.DataPropertyName = "patient_id";
            PatientId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewDentalHistory.Columns.Add(PatientId);

            DataGridViewTextBoxColumn Fullname = new DataGridViewTextBoxColumn();
            Fullname.HeaderText = "Full Name";
            Fullname.Name = "Fullname";
            Fullname.DataPropertyName = "fullname";
            Fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewDentalHistory.Columns.Add(Fullname);

            /* DataGridViewTextBoxColumn LastDentalVisit = new DataGridViewTextBoxColumn();
             LastDentalVisit.HeaderText = "Last Dental Visit";
             LastDentalVisit.Name = "LastDentalVisit";
             LastDentalVisit.DataPropertyName = "last_dental_visit";
             LastDentalVisit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
             viewDentalHistory.Columns.Add(LastDentalVisit);*/

            DataGridViewTextBoxColumn PastDentalTreatments = new DataGridViewTextBoxColumn();
            PastDentalTreatments.HeaderText = "Past Dental Treatments";
            PastDentalTreatments.Name = "PastDentalTreatments";
            PastDentalTreatments.DataPropertyName = "past_dental_treatments";
            PastDentalTreatments.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewDentalHistory.Columns.Add(PastDentalTreatments);

            DataGridViewTextBoxColumn FrequentToothPain = new DataGridViewTextBoxColumn();
            FrequentToothPain.HeaderText = "Frequent Tooth Pain";
            FrequentToothPain.Name = "FrequentToothPain";
            FrequentToothPain.DataPropertyName = "frequent_tooth_pain";
            FrequentToothPain.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewDentalHistory.Columns.Add(FrequentToothPain);

            DataGridViewTextBoxColumn GumDisease = new DataGridViewTextBoxColumn();
            GumDisease.HeaderText = "Gum Disease";
            GumDisease.Name = "GumDisease";
            GumDisease.DataPropertyName = "gum_disease_history";
            GumDisease.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewDentalHistory.Columns.Add(GumDisease);

            DataGridViewTextBoxColumn GrindingTeeth = new DataGridViewTextBoxColumn();
            GrindingTeeth.HeaderText = "Grinding Teeth";
            GrindingTeeth.Name = "GrindingTeeth";
            GrindingTeeth.DataPropertyName = "teeth_grinding";
            GrindingTeeth.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewDentalHistory.Columns.Add(GrindingTeeth);

            DataGridViewTextBoxColumn Sensitivity = new DataGridViewTextBoxColumn();
            Sensitivity.HeaderText = "Sensitivity";
            Sensitivity.Name = "Sensitivity";
            Sensitivity.DataPropertyName = "tooth_sensitivity";
            Sensitivity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewDentalHistory.Columns.Add(Sensitivity);

            DataGridViewTextBoxColumn Ortho = new DataGridViewTextBoxColumn();
            Ortho.HeaderText = "Orthodontic";
            Ortho.Name = "Orthodontic";
            Ortho.DataPropertyName = "orthodontic_treatment";
            Ortho.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewDentalHistory.Columns.Add(Ortho);

            DataGridViewTextBoxColumn DentalImplant = new DataGridViewTextBoxColumn();
            DentalImplant.HeaderText = "Dental Implant";
            DentalImplant.Name = "DentalImplant";
            DentalImplant.DataPropertyName = "dental_implants";
            DentalImplant.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewDentalHistory.Columns.Add(DentalImplant);

            DataGridViewTextBoxColumn GumBleeding = new DataGridViewTextBoxColumn();
            GumBleeding.HeaderText = "Gum Bleeding";
            GumBleeding.Name = "GumBleeding";
            GumBleeding.DataPropertyName = "bleeding_gums";
            GumBleeding.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewDentalHistory.Columns.Add(GumBleeding);



        }
        //Add column end

        //refresh

        public void ExportDataTableToCsv(DataTable dataTable, string filePath)
        {
            StringBuilder csvBuilder = new StringBuilder();

            // Add column headers
            var columnNames = dataTable.Columns.Cast<DataColumn>().Select(column => $"\"{column.ColumnName}\"");
            csvBuilder.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dataTable.Rows)
            {
                var fields = row.ItemArray.Select((field, index) =>
                {
                    // Get the DataColumn for the current index
                    DataColumn column = dataTable.Columns[index];

                    // Handle DateTime fields
                    if (field is DateTime dateTime)
                    {
                        return $"\"{dateTime:MM/dd/yyyy}\"";
                    }

                    // Handle boolean fields (smoker column)
                    if (field is bool booleanValue)
                    {
                        return $"\"{booleanValue.ToString()}\"";  // true/false
                    }
                    else if (field == DBNull.Value || field.ToString() == "")
                    {
                        // Handle DBNull or empty string for boolean columns
                        if (column.DataType == typeof(bool))
                        {
                            return "\"false\"";  // Default to false for boolean columns
                        }
                        return "\"\"";  // For non-bool columns, empty string for DBNull
                    }

                    // For other fields, escape quotes correctly
                    return $"\"{field.ToString().Replace("\"", "\"\"")}\"";
                });

                csvBuilder.AppendLine(string.Join(",", fields));
            }

            try
            {
                File.WriteAllText(filePath, csvBuilder.ToString(), Encoding.UTF8);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error writing to CSV file: {ex.Message}", ex);
            }
        }


        public void ExportDataTablesToExcel(Dictionary<string, DataTable> tables, string filePath)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    foreach (var tableEntry in tables)
                    {
                        var sheetName = tableEntry.Key;
                        var dataTable = tableEntry.Value;

                        var worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);
                        worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);

                        foreach (DataColumn column in dataTable.Columns)
                        {
                            if (column.DataType == typeof(DateTime))
                            {
                                int startRow = 2;
                                int endRow = dataTable.Rows.Count + 1;
                                worksheet.Cells[startRow, column.Ordinal + 1, endRow, column.Ordinal + 1].Style.Numberformat.Format = "MM/dd/yyyy";
                            }

                            // Format boolean fields as true/false
                            if (column.DataType == typeof(bool))
                            {
                                for (int row = 2; row <= dataTable.Rows.Count + 1; row++)
                                {
                                    var cell = worksheet.Cells[row, column.Ordinal + 1];
                                    cell.Value = (bool)cell.Value ? "TRUE" : "FALSE"; // Use TRUE/FALSE as string in Excel
                                }
                            }
                        }

                        // Adjust column widths
                        for (int i = 1; i <= dataTable.Columns.Count; i++)
                        {
                            worksheet.Column(i).AutoFit();
                        }
                    }

                    FileInfo file = new FileInfo(filePath);
                    excelPackage.SaveAs(file);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error exporting data to Excel: {ex.Message}", ex);
            }
        }


        private void viewGenHealth_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnSearcher_Click(object sender, EventArgs e)
        {
            try
            {
                getBranchIdByUserId branchId = new getBranchIdByUserId();
                BranchID adminId = await branchId.GetUserBranchId();

                var (patientData, medicalData, dentalData) = await _patientRecordController.SearchPatientDataAsync(txtSearchBoxes.Text, adminId._id);

                if (patientData != null && patientData.Rows.Count > 0)
                {
                    viewPatientRecord.DataSource = patientData;
                    viewGenHealth.DataSource = medicalData;
                    viewDentHealth.DataSource = dentalData;

                }
                else
                {
                    AlertBox(Color.LightSteelBlue, Color.DodgerBlue, "No results", "No patient found with the given search term", Properties.Resources.information);
                }
            }
            catch (Exception ex)
            {
                AlertBox(Color.LightCoral, Color.Red, "Error", "An error occurred while searching for patient data", Properties.Resources.error);
            }
        }



        private void btnCreateRecord_Click(object sender, EventArgs e)
        {
            if (PatientDetailsInstance == null || PatientDetailsInstance.IsDisposed)
            {
                PatientDetailsInstance = new patientDetails();
                PatientDetailsInstance.Show();
            }
            else
            {
                if (PatientDetailsInstance.Visible)
                {
                    PatientDetailsInstance.BringToFront();
                }
                else
                {
                    PatientDetailsInstance.Show();
                }
            }
        }

        private async void btnExportRecord_Click(object sender, EventArgs e)
        {
            DataTable patientData = null;
            DataTable genHealthData = null;
            DataTable dentHealthData = null;

            try
            {
                // Loop through all rows in the DataGridView to check for selected checkboxes
                foreach (DataGridViewRow row in viewPatientRecord.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["SelectPatient"];
                    if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                    {
                        int patientId = Convert.ToInt32(row.Cells["id"].Value);

                        // Fetch the data for patient, medical history, and dental history
                        DataTable tempPatientData = await _patientRecordController.ExportPatientCsv(patientId);
                        DataTable tempGenHealthData = await _patientRecordController.ExportGeneralHealthCsv(patientId);
                        DataTable tempDentHealthData = await _patientRecordController.ExportDentalHealthCsv(patientId);

                        // Initialize DataTables for each category if they are null
                        if (patientData == null)
                            patientData = tempPatientData.Clone();

                        if (genHealthData == null)
                            genHealthData = tempGenHealthData.Clone();

                        if (dentHealthData == null)
                            dentHealthData = tempDentHealthData.Clone();

                        // Add data to respective DataTables
                        if (tempPatientData.Rows.Count > 0)
                            patientData.ImportRow(tempPatientData.Rows[0]);

                        if (tempGenHealthData.Rows.Count > 0)
                            genHealthData.ImportRow(tempGenHealthData.Rows[0]);

                        if (tempDentHealthData.Rows.Count > 0)
                            dentHealthData.ImportRow(tempDentHealthData.Rows[0]);
                    }
                }

                if (patientData == null || genHealthData == null || dentHealthData == null)
                {
                    AlertBox(Color.LightSteelBlue, Color.DodgerBlue, "No Selected Data", "No data available to export.", Properties.Resources.information);
                    return;
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Save Exported Patient Data";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFilePath = saveFileDialog.FileName;

                        // Create a dictionary with sheet names and corresponding data tables
                        var dataTables = new Dictionary<string, DataTable>
                {
                    { "Patient Data", patientData },
                    { "Medical History", genHealthData },
                    { "Dental History", dentHealthData }
                };

                        // Export to Excel
                        ExportDataTablesToExcel(dataTables, selectedFilePath);

                        AlertBox(Color.LightGreen, Color.SeaGreen, "Export Complete", "Data exported successfully!", Properties.Resources.success);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while exporting data: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRefresher_Click(object sender, EventArgs e)
        {
            await LoadRecord();
        }

        private async void btnDeketeRecord_Click(object sender, EventArgs e)
        {
            bool hasSelectedRows = false;

            for (int i = 0; i < viewPatientRecord.Rows.Count; i++)
            {
                DataGridViewRow row = viewPatientRecord.Rows[i];
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["SelectPatient"] as DataGridViewCheckBoxCell;

                if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                {
                    hasSelectedRows = true;
                    break;
                }
            }

            if (!hasSelectedRows)
            {
                AlertBox(Color.LightSteelBlue, Color.DodgerBlue, "No rows selected", "No rows were selected for deletion", Properties.Resources.information);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                for (int i = viewPatientRecord.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = viewPatientRecord.Rows[i];
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["SelectPatient"] as DataGridViewCheckBoxCell;

                    // Check if the checkbox is checked
                    if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                    {
                        int patientid = Convert.ToInt32(row.Cells["id"].Value);
                        viewPatientRecord.Rows.RemoveAt(i);

                        await _patientRecordController.Delete(patientid);
                    }
                }

                AlertBox(Color.LightGreen, Color.SeaGreen, "Success", "The selected patient records have been deleted successfully", Properties.Resources.success);
            }
        }

        private void btnSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            bool selectAllChecked = btnSelectAll.Checked;

            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in viewPatientRecord.Rows)
            {
                // Find the checkbox cell and set its value to the same state as "Select All"
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["SelectPatient"];
                checkBoxCell.Value = selectAllChecked;
            }

            // Commit the changes made to the DataGridView
            viewPatientRecord.EndEdit();
        }
    }
}
