using Application_Desktop.Model;
using System;
using System.Collections.Generic;
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

        public async Task SelectAllPatientRecord(PatientRecord patients, int admin)
        {
            string selectPatients = @"SELECT `fullname`, `date_of_birth`, `age`, `gender`, `phone`, `email`, `address`, `emergency_contact`, `created_at`, `updated_at` FROM `patients` 
                                WHERE Branch_ID = @admin";

            

            
        }

        public async Task SelectPatientMedicalRecord(PatientGenHealth genhealth, int admin)
        {
            string selectGenHealth = @"SELECT `patient_id`, `medical_conditions`, `current_medications`, `allergies`, `past_surgeries`, `family_medical_history`, `blood_pressure`, `heart_disease`, `diabetes`, `smoker`, `created_at`, `updated_at` FROM `medical_history` 
                                WHERE ";
        }

        public async Task SelectPatientMedicalRecord(PatientDentHealth denthealth, int admin)
        {
            string selectDentHealth = @"SELECT `patient_id`, `last_dental_visit`, `past_dental_treatments`, `frequent_tooth_pain`, `gum_disease_history`, `teeth_grinding`, `tooth_sensitivity`, `orthodontic_treatment`, `dental_implants`, `bleeding_gums`, `created_at`, `updated_at` FROM `dental_history` 
                                WHERE ";
        }

    }
}
