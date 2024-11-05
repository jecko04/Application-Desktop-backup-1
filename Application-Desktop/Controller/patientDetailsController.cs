using Application_Desktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application_Desktop.Models;
using MySql.Data.MySqlClient;

namespace Application_Desktop.Controller
{
    public class patientDetailsController
    {
        private patientDetailsModel _patientModel;

        public patientDetailsController()
        {
            _patientModel = new patientDetailsModel();
        }

        public async Task CreateDentalRecord(DentalPatient patients, GenHealth genHealth, DentHealth dentHealth, int admin)
        {
            string insertPatient = @"INSERT INTO `patients` 
                             (`fullname`, `date_of_birth`, `age`, `gender`, `phone`, `email`, `address`, `emergency_contact`, `Branch_ID`, `created_at`, `updated_at`)
                             VALUES (@fullname, @dob, @age, @gender, @contact, @email, @address, @emergency, @branchid, @createdAt, @updatedAt)";

            string insertGenHealth = @"INSERT INTO `medical_history`
                               (`patient_id`, `medical_conditions`, `current_medications`, `allergies`, `past_surgeries`, `family_medical_history`, `blood_pressure`, `heart_disease`, `diabetes`, `smoker`, `created_at`, `updated_at`)
                               VALUES (@patientId, @medCondition, @currentMedication, @allergies, @pastSurgery, @familyHistory, @bloodPressure, @heartDisease, @diabetes, @smoker, @createdAt, @updatedAt)";

            string insertDentHealth = @"INSERT INTO `dental_history`
                                (`patient_id`, `past_dental_treatments`, `frequent_tooth_pain`, `gum_disease_history`, `teeth_grinding`, `tooth_sensitivity`, `orthodontic_treatment`, `dental_implants`, `bleeding_gums`, `created_at`, `updated_at`)
                                VALUES (@patientId, @pastTreatment, @toothPain, @gumDisease, @teethGrinding, @toothSensitivity, @orthodontics, @implants, @bleedingGums, @createdAt, @updatedAt)";

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

                            // Step 1: Insert the patient and get the patientId
                            int patientId;
                            using (MySqlCommand patientCmd = new MySqlCommand(insertPatient, conn, transaction))
                            {
                                patientCmd.Parameters.AddWithValue("@fullname", patients._fullname);
                                patientCmd.Parameters.AddWithValue("@dob", patients._dob);
                                patientCmd.Parameters.AddWithValue("@age", patients._age);
                                patientCmd.Parameters.AddWithValue("@gender", patients._gender);
                                patientCmd.Parameters.AddWithValue("@contact", patients._contact);
                                patientCmd.Parameters.AddWithValue("@email", patients._email);
                                patientCmd.Parameters.AddWithValue("@address", patients._address);
                                patientCmd.Parameters.AddWithValue("@emergency", patients._emergency);
                                patientCmd.Parameters.AddWithValue("@branchid", admin);
                                patientCmd.Parameters.AddWithValue("@createdAt", now);
                                patientCmd.Parameters.AddWithValue("@updatedAt", now);

                                await patientCmd.ExecuteNonQueryAsync();
                                patientId = Convert.ToInt32(await new MySqlCommand("SELECT LAST_INSERT_ID()", conn, transaction).ExecuteScalarAsync());
                            }

                            // Step 2: Insert into medical_history using patientId
                            using (MySqlCommand genHealthCmd = new MySqlCommand(insertGenHealth, conn, transaction))
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
                                genHealthCmd.Parameters.AddWithValue("@createdAt", now);
                                genHealthCmd.Parameters.AddWithValue("@updatedAt", now);

                                await genHealthCmd.ExecuteNonQueryAsync();
                            }

                            // Step 3: Insert into dental_history using patientId
                            using (MySqlCommand dentHealthCmd = new MySqlCommand(insertDentHealth, conn, transaction))
                            {
                                dentHealthCmd.Parameters.AddWithValue("@patientId", patientId);
                                dentHealthCmd.Parameters.AddWithValue("@pastTreatment", dentHealth._pastdenttreatment);
                                dentHealthCmd.Parameters.AddWithValue("@toothPain", dentHealth._toothpain);
                                dentHealthCmd.Parameters.AddWithValue("@gumDisease", dentHealth._gumdisease);
                                dentHealthCmd.Parameters.AddWithValue("@teethGrinding", dentHealth._teethgrind);
                                dentHealthCmd.Parameters.AddWithValue("@toothSensitivity", dentHealth._toothsens);
                                dentHealthCmd.Parameters.AddWithValue("@orthodontics", dentHealth._ortho);
                                dentHealthCmd.Parameters.AddWithValue("@implants", dentHealth._dentimps);
                                dentHealthCmd.Parameters.AddWithValue("@bleedingGums", dentHealth._bleedinggums);
                                dentHealthCmd.Parameters.AddWithValue("@createdAt", now);
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
                    throw new Exception($"Error creating dental record: {ex.Message}", ex);
                }
            }
        }

    }

}

