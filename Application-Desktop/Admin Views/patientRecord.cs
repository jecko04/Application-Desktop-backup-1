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
        private void btnCreate_Click(object sender, EventArgs e)
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
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        //Add Column start
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
            viewPatients.Columns["SelectPatient"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

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

            DataGridViewTextBoxColumn LastDentalVisit = new DataGridViewTextBoxColumn();
            LastDentalVisit.HeaderText = "Last Dental Visit";
            LastDentalVisit.Name = "LastDentalVisit";
            LastDentalVisit.DataPropertyName = "last_dental_visit";
            LastDentalVisit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewDentalHistory.Columns.Add(LastDentalVisit);

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
            GrindingTeeth.DataPropertyName = "grinding_teeth";
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
            GumBleeding.DataPropertyName = "gum_bleeding";
            GumBleeding.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            viewDentalHistory.Columns.Add(GumBleeding);



        }
        //Add column end

        //refresh
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadRecord();
        }
        private async void btnDelete_Click(object sender, EventArgs e)
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


        private async void btnExport_Click(object sender, EventArgs e)
        {
            DataTable patientData = new DataTable();

            try
            {
                // Loop through all rows in the DataGridView to check for selected checkboxes
                foreach (DataGridViewRow row in viewPatientRecord.Rows)
                {
                    // Check if the checkbox is checked
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["SelectPatient"];
                    if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                    {
                        // Get the patient ID from the checked row
                        int patientId = Convert.ToInt32(row.Cells["id"].Value);
                        DataTable tempData = await _patientRecordController.ExportToCsv(patientId);

                        // If patientData is empty, initialize it with the structure of tempData
                        if (patientData.Rows.Count == 0)
                        {
                            patientData = tempData.Clone(); // Clone the structure
                        }

                        // Import the rows from tempData into patientData
                        foreach (DataRow dataRow in tempData.Rows)
                        {
                            patientData.ImportRow(dataRow);
                        }
                    }
                }

                // Check if any rows have been added to patientData
                if (patientData.Rows.Count == 0)
                {
                    AlertBox(Color.LightSteelBlue, Color.DodgerBlue, "No Selected Data", "No data available to export.", Properties.Resources.information);
                    return;
                }

                // Open SaveFileDialog to let the user choose the file location and name
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Save Exported Patient Data";

                    // If the user selects a path and clicks "Save"
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFilePath = saveFileDialog.FileName;

                        // Check the file extension to determine whether to export as CSV or Excel
                        if (Path.GetExtension(selectedFilePath).ToLower() == ".csv")
                        {
                            // Export to CSV
                            ExportDataTableToCsv(patientData, selectedFilePath);
                        }
                        else if (Path.GetExtension(selectedFilePath).ToLower() == ".xlsx")
                        {
                            // Export to Excel
                            ExportDataTableToExcel(patientData, selectedFilePath);
                        }

                        AlertBox(Color.LightGreen, Color.SeaGreen, "Export Complete", "Data exported successfully!", Properties.Resources.success);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while exporting data: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportDataTableToCsv(DataTable dataTable, string filePath)
        {
            StringBuilder csvBuilder = new StringBuilder();
            var columnNames = dataTable.Columns.Cast<DataColumn>().Select(column => $"\"{column.ColumnName}\"");
            csvBuilder.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dataTable.Rows)
            {
                var fields = row.ItemArray.Select(field =>
                {
                    // Check if the field is a DateTime
                    if (field is DateTime dateTime)
                    {
                        // Format the date as a string, e.g., "MM/dd/yyyy"
                        return $"\"{dateTime.ToString("MM/dd/yyyy")}\"";
                    }
                    return $"\"{field.ToString().Replace("\"", "\"\"")}\"";
                });

                csvBuilder.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText(filePath, csvBuilder.ToString());
        }

        public void ExportDataTableToExcel(DataTable dataTable, string filePath)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                var worksheet = excelPackage.Workbook.Worksheets.Add("Patient Data");

                // Load the DataTable into the worksheet, starting from cell A1
                worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);

                // Format DateTime columns (example: assuming the date columns are known)
                foreach (DataColumn column in dataTable.Columns)
                {
                    if (column.DataType == typeof(DateTime))
                    {
                        // Assuming dates start from the second row (first is the header)
                        var startRow = 2;
                        var endRow = dataTable.Rows.Count + 1; // +1 for header
                        worksheet.Cells[startRow, column.Ordinal + 1, endRow, column.Ordinal + 1].Style.Numberformat.Format = "MM/dd/yyyy"; // or another desired format
                    }
                }

                // Optional: Adjust column widths
                for (int i = 1; i <= dataTable.Columns.Count; i++)
                {
                    worksheet.Column(i).AutoFit();
                }

                // Save to file
                FileInfo file = new FileInfo(filePath);
                excelPackage.SaveAs(file);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var (patientData, medicalData, dentalData) = await _patientRecordController.SearchPatientDataAsync(txtSearchBox.Text);

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

        private void viewGenHealth_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
