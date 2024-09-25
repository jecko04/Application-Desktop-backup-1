﻿using Application_Desktop.Model;
using Application_Desktop.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Controller
{
    public class patientRecordController
    {
        private patientRecordModel _patientRecordModel;

        public patientRecordController()
        {
            _patientRecordModel = new patientRecordModel();
        }

        public async Task<DataTable> SelectAllPatientRecord(int admin)
        {
            string selectPatients = @"SELECT `id`, `fullname`, `date_of_birth`, `age`, `gender`, `phone`, `email`, `address`, `emergency_contact`, `created_at`, `updated_at` 
                              FROM `patients` 
                              WHERE Branch_ID = @admin";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    await conn.OpenAsync();

                    using (MySqlCommand cmd = new MySqlCommand(selectPatients, conn))
                    {
                        cmd.Parameters.AddWithValue("@admin", admin);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();

                            await Task.Run(() => adapter.Fill(dataTable)); 

                            return dataTable.Rows.Count > 0 ? dataTable : new DataTable();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving patient record: {ex.Message}", ex);
            }
        }

        public async Task<DataTable> SelectPatientMedicalRecord(int patientid)
        {
            string selectGenHealth = @"SELECT mh.`patient_id`, p.`fullname`, mh.`medical_conditions`, mh.`current_medications`, mh.`allergies`, mh.`past_surgeries`, mh.`family_medical_history`, mh.`blood_pressure`, mh.`heart_disease`, mh.`diabetes`, mh.`smoker` 
                               FROM `medical_history` mh
                               JOIN `patients` p ON mh.patient_id = p.id
                               WHERE patient_id = @patientid";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(selectGenHealth, conn))
                    {
                        cmd.Parameters.AddWithValue("@patientid", patientid);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable datatable = new DataTable();
                            await Task.Run(() => adapter.Fill(datatable));

                            return datatable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving patient medical record: {ex.Message}");
            }
        }

        public async Task<DataTable> SelectPatientDentalRecord(int patientid)
        {
            string selectDentHealth = @"SELECT dh.`patient_id`, p.`fullname`, dh.`last_dental_visit`, dh.`past_dental_treatments`, dh.`frequent_tooth_pain`, dh.`gum_disease_history`, dh.`teeth_grinding`, dh.`tooth_sensitivity`,
                                dh.`orthodontic_treatment`, dh.`dental_implants`, dh.`bleeding_gums` 
                                FROM `dental_history` dh
                                JOIN `patients` p ON dh.patient_id = p.id
                                WHERE patient_id = @patientid";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(selectDentHealth, conn))
                    {
                        cmd.Parameters.AddWithValue("@patientid", patientid);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable datatable = new DataTable();
                            await Task.Run(() => adapter.Fill(datatable)); 

                            return datatable; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving patient dental record: {ex.Message}");
            }
        }

        public async Task<DataTable> ExportToCsv(int patientId)
        {
            string selectPatients = @"SELECT `id`, `fullname`, `date_of_birth`, `age`, `gender`, `phone`, `email`, `address`, `emergency_contact`
                              FROM `patients` 
                              WHERE `id` = @patientid";
            string selectGenHealth = @"SELECT `medical_conditions`, `current_medications`, `allergies`, `past_surgeries`, `family_medical_history`, `blood_pressure`, `heart_disease`, `diabetes`, `smoker` 
                               FROM `medical_history` 
                               WHERE `patient_id` = @patientid";
            string selectDentHealth = @"SELECT `last_dental_visit`, `past_dental_treatments`, `frequent_tooth_pain`, `gum_disease_history`, `teeth_grinding`, `tooth_sensitivity`, `orthodontic_treatment`, `dental_implants`, `bleeding_gums` 
                                FROM `dental_history` 
                                WHERE `patient_id` = @patientid";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();

                    }

                    // Fetch patient data
                    DataTable patientData = new DataTable();
                    using (MySqlCommand patientCmd = new MySqlCommand(selectPatients, conn))
                    {
                        patientCmd.Parameters.AddWithValue("@patientid", patientId);
                        using (MySqlDataAdapter patientAdapter = new MySqlDataAdapter(patientCmd))
                        {
                            patientAdapter.Fill(patientData);
                        }
                    }

                    // Fetch general health data
                    DataTable genHealthData = new DataTable();
                    using (MySqlCommand genHealthCmd = new MySqlCommand(selectGenHealth, conn))
                    {
                        genHealthCmd.Parameters.AddWithValue("@patientid", patientId);
                        using (MySqlDataAdapter genHealthAdapter = new MySqlDataAdapter(genHealthCmd))
                        {
                            genHealthAdapter.Fill(genHealthData);
                        }
                    }

                    // Fetch dental health data
                    DataTable dentHealthData = new DataTable();
                    using (MySqlCommand dentHealthCmd = new MySqlCommand(selectDentHealth, conn))
                    {
                        dentHealthCmd.Parameters.AddWithValue("@patientid", patientId);
                        using (MySqlDataAdapter dentHealthAdapter = new MySqlDataAdapter(dentHealthCmd))
                        {
                            dentHealthAdapter.Fill(dentHealthData);
                        }
                    }

                    // Create a merged DataTable
                    DataTable mergedData = new DataTable();

                    // Add columns from all tables
                    foreach (DataColumn column in patientData.Columns)
                    {
                        mergedData.Columns.Add(column.ColumnName, column.DataType);
                    }
                    foreach (DataColumn column in genHealthData.Columns)
                    {
                        mergedData.Columns.Add(column.ColumnName, column.DataType);
                    }
                    foreach (DataColumn column in dentHealthData.Columns)
                    {
                        mergedData.Columns.Add(column.ColumnName, column.DataType);
                    }

                    // Add a new row to mergedData
                    DataRow newRow = mergedData.NewRow();

                    // Add data from patientData to the row
                    if (patientData.Rows.Count > 0)
                    {
                        for (int i = 0; i < patientData.Columns.Count; i++)
                        {
                            newRow[i] = patientData.Rows[0][i];
                        }
                    }

                    // Add data from genHealthData to the row
                    if (genHealthData.Rows.Count > 0)
                    {
                        for (int i = 0; i < genHealthData.Columns.Count; i++)
                        {
                            newRow[patientData.Columns.Count + i] = genHealthData.Rows[0][i];
                        }
                    }

                    // Add data from dentHealthData to the row
                    if (dentHealthData.Rows.Count > 0)
                    {
                        for (int i = 0; i < dentHealthData.Columns.Count; i++)
                        {
                            newRow[patientData.Columns.Count + genHealthData.Columns.Count + i] = dentHealthData.Rows[0][i];
                        }
                    }

                    // Add the row to the mergedData table
                    mergedData.Rows.Add(newRow);

                    return mergedData;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Fetching Data: {ex.Message}", ex);
            }
        }


        public async Task<int> Delete(int patientid)
        {
            string query = "Delete From patients Where id = @patientid";

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@patientid", patientid);
                        await cmd.ExecuteNonQueryAsync();
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting data: {ex.Message}");
            }
            return patientid;
        }

        public async Task<(DataTable patientData, DataTable medicalData, DataTable dentalData)> SearchPatientDataAsync(string searchTerm)
        {
            string selectPatients = @"SELECT `id`, `fullname`, `date_of_birth`, `age`, `gender`, `phone`, `email`, `address`, `emergency_contact`
                              FROM `patients` 
                              WHERE (`fullname` LIKE CONCAT('%', @searchTerm, '%') 
                                     OR `phone` LIKE CONCAT('%', @searchTerm, '%') 
                                     OR `email` LIKE CONCAT('%', @searchTerm, '%'))";

            int patientId = 0;
            DataTable patientData = new DataTable();
            DataTable medicalData = new DataTable();
            DataTable dentalData = new DataTable();

            using (MySqlConnection conn = databaseHelper.getConnection())
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                using (MySqlCommand cmd = new MySqlCommand(selectPatients, conn))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", searchTerm);
                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            patientData.Load(reader);
                            if (patientData.Rows.Count > 0)
                            {
                                patientId = Convert.ToInt32(patientData.Rows[0]["id"]);
                            }
                        }
                    }
                }

                if (patientId == 0)
                {
                    return (null, null, null);
                }

                string selectGenHealth = @"SELECT mh.`patient_id`, p.`fullname`, mh.`medical_conditions`, mh.`current_medications`, mh.`allergies`, mh.`past_surgeries`, mh.`family_medical_history`, mh.`blood_pressure`, mh.`heart_disease`, mh.`diabetes`, mh.`smoker` 
                                   FROM `medical_history` mh
                                   JOIN `patients` p ON mh.patient_id = p.id
                                   WHERE mh.patient_id = @patientid";

                using (MySqlCommand cmd = new MySqlCommand(selectGenHealth, conn))
                {
                    cmd.Parameters.AddWithValue("@patientid", patientId);
                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        medicalData.Load(reader);
                    }
                }

                string selectDentHealth = @"SELECT dh.`patient_id`, p.`fullname`, dh.`last_dental_visit`, dh.`past_dental_treatments`, dh.`frequent_tooth_pain`, dh.`gum_disease_history`, dh.`teeth_grinding`, dh.`tooth_sensitivity`,
                                    dh.`orthodontic_treatment`, dh.`dental_implants`, dh.`bleeding_gums` 
                                    FROM `dental_history` dh
                                    JOIN `patients` p ON dh.patient_id = p.id
                                    WHERE dh.patient_id = @patientid";

                using (MySqlCommand cmd = new MySqlCommand(selectDentHealth, conn))
                {
                    cmd.Parameters.AddWithValue("@patientid", patientId);
                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        dentalData.Load(reader);
                    }
                }
            }

            return (patientData, medicalData, dentalData);
        }


    }
}