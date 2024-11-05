using Application_Desktop.Model;
using Application_Desktop.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Application_Desktop.Controller
{
    
    public class editPatientDetailsController
    {
        private editPatientDetailsModel _editPatientModel;

        public editPatientDetailsController()
        {
            _editPatientModel = new editPatientDetailsModel();
        }

        public async Task<(EditPatientData, EditGenHealth, EditDentHealth)> EditPatient(int patientid, int admin)
        {
            string selectPatients = @"SELECT `id`, `fullname`, `date_of_birth`, `age`, `gender`, `phone`, `email`, `address`, `emergency_contact`
                              FROM `patients` 
                              WHERE `id` = @patientid AND Branch_ID = @admin";
            string selectGenHealth = @"SELECT `patient_id`, `medical_conditions`, `current_medications`, `allergies`, `past_surgeries`, `family_medical_history`, `blood_pressure`, `heart_disease`, `diabetes`, `smoker` 
                               FROM `medical_history` 
                               WHERE `patient_id` = @patientid";
            string selectDentHealth = @"SELECT `patient_id`, `past_dental_treatments`, `frequent_tooth_pain`, `gum_disease_history`, `teeth_grinding`, `tooth_sensitivity`,
                                `orthodontic_treatment`, `dental_implants`, `bleeding_gums` 
                                FROM `dental_history` 
                                WHERE `patient_id` = @patientid";

            EditPatientData patientData = null;
            EditGenHealth genHealthData = null;
            EditDentHealth dentHealthData = null;

            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }

                    // Fetch patient data
                    using (MySqlCommand patientCmd = new MySqlCommand(selectPatients, conn))
                    {
                        patientCmd.Parameters.AddWithValue("@patientid", patientid);
                        patientCmd.Parameters.AddWithValue("@admin", admin);
                        using (MySqlDataReader reader = (MySqlDataReader)await patientCmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                patientData = new EditPatientData
                                {
                                    _fullname = reader["fullname"].ToString(),
                                    _dob = DateTime.Parse(reader["date_of_birth"].ToString()),
                                    _age = int.Parse(reader["age"].ToString()),
                                    _gender = reader["gender"].ToString(),
                                    _contact = reader["phone"].ToString(),
                                    _email = reader["email"].ToString(),
                                    _address = reader["address"].ToString(),
                                    _emergency = reader["emergency_contact"].ToString()
                                };
                            }
                        }
                    }

                    // Fetch general health data
                    using (MySqlCommand genHealthCmd = new MySqlCommand(selectGenHealth, conn))
                    {
                        genHealthCmd.Parameters.AddWithValue("@patientid", patientid);
                        using (MySqlDataReader reader = (MySqlDataReader)await genHealthCmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                genHealthData = new EditGenHealth
                                {
                                    _medcondition = reader["medical_conditions"].ToString(),
                                    _currmedication = reader["current_medications"].ToString(),
                                    _allergies = reader["allergies"].ToString(),
                                    _pastsurg = reader["past_surgeries"].ToString(),
                                    _fammedhistory = reader["family_medical_history"].ToString(),
                                    _bloodpressure = reader["blood_pressure"].ToString(),
                                    _heartdisease = reader.GetBoolean(reader.GetOrdinal("heart_disease")), 
                                    _diabetes = reader.GetBoolean(reader.GetOrdinal("diabetes")),
                                    _smoker = reader.GetBoolean(reader.GetOrdinal("smoker"))
                                };
                            }
                        }
                    }

                    // Fetch dental health data
                    using (MySqlCommand dentHealthCmd = new MySqlCommand(selectDentHealth, conn))
                    {
                        dentHealthCmd.Parameters.AddWithValue("@patientid", patientid);
                        using (MySqlDataReader reader = (MySqlDataReader)await dentHealthCmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                dentHealthData = new EditDentHealth
                                {
                                    //_lastvisit = DateTime.Parse(reader["last_dental_visit"].ToString()),
                                    _pastdenttreatment = reader["past_dental_treatments"].ToString(),
                                    _toothpain = reader.GetBoolean(reader.GetOrdinal("frequent_tooth_pain")),
                                    _gumdisease = reader.GetBoolean(reader.GetOrdinal("gum_disease_history")),
                                    _teethgrind = reader.GetBoolean(reader.GetOrdinal("teeth_grinding")),
                                    _toothsens = reader["tooth_sensitivity"].ToString(),
                                    _ortho = reader.GetBoolean(reader.GetOrdinal("orthodontic_treatment")),
                                    _dentimps = reader.GetBoolean(reader.GetOrdinal("dental_implants")),
                                    _bleedinggums = reader.GetBoolean(reader.GetOrdinal("bleeding_gums"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Selecting Patient Record: {ex.Message}");
            }

            // Return the fetched data as a tuple
            return (patientData, genHealthData, dentHealthData);
        }

        public async Task UpdateDentalRecord(DentalPatient patients, GenHealth genHealth, DentHealth dentHealth, int patientId)
        {
            string updatePatient = @"UPDATE `patients` 
                             SET `fullname` = @fullname, 
                                 `date_of_birth` = @dob, 
                                 `age` = @age, 
                                 `gender` = @gender, 
                                 `phone` = @contact, 
                                 `email` = @email, 
                                 `address` = @address, 
                                 `emergency_contact` = @emergency, 
                                 `updated_at` = @updatedAt
                             WHERE `id` = @patientId";

            string updateGenHealth = @"UPDATE `medical_history`
                               SET `medical_conditions` = @medCondition, 
                                   `current_medications` = @currentMedication, 
                                   `allergies` = @allergies, 
                                   `past_surgeries` = @pastSurgery, 
                                   `family_medical_history` = @familyHistory, 
                                   `blood_pressure` = @bloodPressure, 
                                   `heart_disease` = @heartDisease, 
                                   `diabetes` = @diabetes, 
                                   `smoker` = @smoker, 
                                   `updated_at` = @updatedAt
                               WHERE `patient_id` = @patientId"; 

            string updateDentHealth = @"UPDATE `dental_history`
                                SET `past_dental_treatments` = @pastTreatment, 
                                    `frequent_tooth_pain` = @toothPain, 
                                    `gum_disease_history` = @gumDisease, 
                                    `teeth_grinding` = @teethGrinding, 
                                    `tooth_sensitivity` = @toothSensitivity, 
                                    `orthodontic_treatment` = @orthodontics, 
                                    `dental_implants` = @implants, 
                                    `bleeding_gums` = @bleedingGums, 
                                    `updated_at` = @updatedAt
                                WHERE `patient_id` = @patientId"; 

            using (MySqlConnection conn = databaseHelper.getConnection())
            {
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }

                    using (MySqlTransaction transaction = await conn.BeginTransactionAsync())
                    {
                        try
                        {
                            DateTime now = DateTime.Now;

                            // Step 1: Update the patient record
                            using (MySqlCommand patientCmd = new MySqlCommand(updatePatient, conn, transaction))
                            {
                                patientCmd.Parameters.AddWithValue("@fullname", patients._fullname);
                                patientCmd.Parameters.AddWithValue("@dob", patients._dob);
                                patientCmd.Parameters.AddWithValue("@age", patients._age);
                                patientCmd.Parameters.AddWithValue("@gender", patients._gender);
                                patientCmd.Parameters.AddWithValue("@contact", patients._contact);
                                patientCmd.Parameters.AddWithValue("@email", patients._email);
                                patientCmd.Parameters.AddWithValue("@address", patients._address);
                                patientCmd.Parameters.AddWithValue("@emergency", patients._emergency);
                                patientCmd.Parameters.AddWithValue("@updatedAt", now);
                                patientCmd.Parameters.AddWithValue("@patientId", patientId); 

                                await patientCmd.ExecuteNonQueryAsync();
                            }

                            // Step 2: Update the medical history
                            using (MySqlCommand genHealthCmd = new MySqlCommand(updateGenHealth, conn, transaction))
                            {
                                genHealthCmd.Parameters.AddWithValue("@patientId", patientId); 
                                genHealthCmd.Parameters.AddWithValue("@medCondition", genHealth._medcondition);
                                genHealthCmd.Parameters.AddWithValue("@currentMedication", genHealth._currmedication);
                                genHealthCmd.Parameters.AddWithValue("@allergies", genHealth._allergies);
                                genHealthCmd.Parameters.AddWithValue("@pastSurgery", genHealth._pastsurg);
                                genHealthCmd.Parameters.AddWithValue("@familyHistory", genHealth._fammedhistory);
                                genHealthCmd.Parameters.AddWithValue("@bloodPressure", genHealth._bloodpressure);
                                genHealthCmd.Parameters.AddWithValue("@heartDisease", genHealth._heartdisease);
                                genHealthCmd.Parameters.AddWithValue("@diabetes", genHealth._diabetes);
                                genHealthCmd.Parameters.AddWithValue("@smoker", genHealth._smoker);
                                genHealthCmd.Parameters.AddWithValue("@updatedAt", now);

                                await genHealthCmd.ExecuteNonQueryAsync();
                            }

                            // Step 3: Update the dental history
                            using (MySqlCommand dentHealthCmd = new MySqlCommand(updateDentHealth, conn, transaction))
                            {
                                dentHealthCmd.Parameters.AddWithValue("@patientId", patientId); 
                                //dentHealthCmd.Parameters.AddWithValue("@lastVisit", dentHealth._lastvisit);
                                dentHealthCmd.Parameters.AddWithValue("@pastTreatment", dentHealth._pastdenttreatment);
                                dentHealthCmd.Parameters.AddWithValue("@toothPain", dentHealth._toothpain);
                                dentHealthCmd.Parameters.AddWithValue("@gumDisease", dentHealth._gumdisease);
                                dentHealthCmd.Parameters.AddWithValue("@teethGrinding", dentHealth._teethgrind);
                                dentHealthCmd.Parameters.AddWithValue("@toothSensitivity", dentHealth._toothsens);
                                dentHealthCmd.Parameters.AddWithValue("@orthodontics", dentHealth._ortho);
                                dentHealthCmd.Parameters.AddWithValue("@implants", dentHealth._dentimps);
                                dentHealthCmd.Parameters.AddWithValue("@bleedingGums", dentHealth._bleedinggums);
                                dentHealthCmd.Parameters.AddWithValue("@updatedAt", now);

                                await dentHealthCmd.ExecuteNonQueryAsync();
                            }

                            await transaction.CommitAsync();
                        }
                        catch (Exception ex)
                        {
                            await transaction.RollbackAsync();
                            throw new Exception($"Transaction failed: {ex.Message}", ex);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error updating dental record: {ex.Message}", ex);
                }
            }
        }
    }
}
