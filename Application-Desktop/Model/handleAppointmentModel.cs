using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Model
{
    public class handleAppointmentModel
    {
    }

    public class AppointmentData
    {
        public int userId { get; set; }
        public string branch_name { get; set; }
        public string services { get; set; }
        public DateTime appointment_date { get; set; }
        public string appointment_time { get; set; }
    }

    public class ReceiptDetails
    {
        public string BranchName { get; set; }
        public string UserName { get; set; }
        public string ServiceTitle { get; set; }
        public string Status { get; set; }
        public decimal Price { get; set; }
    }

    public class PatientData
    {
        // Patient Personal Information
        public string FullName { get; set; }
        public string DateOfBirth { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string EmergencyContact { get; set; }

        // Medical History
        public string MedicalConditions { get; set; }
        public string CurrentMedications { get; set; }
        public string Allergies { get; set; }
        public string PastSurgeries { get; set; }
        public string FamilyMedicalHistory { get; set; }
        public string BloodPressure { get; set; }
        public Boolean HeartDisease { get; set; }
        public Boolean Diabetes { get; set; }
        public Boolean Smoker { get; set; }

        // Dental History
        public string PastDentalTreatments { get; set; }
        public Boolean FrequentToothPain { get; set; }
        public Boolean GumDiseaseHistory { get; set; }
        public Boolean TeethGrinding { get; set; }
        public string ToothSensitivity { get; set; }
        public Boolean OrthodonticTreatment { get; set; }
        public Boolean DentalImplants { get; set; }
        public Boolean BleedingGums { get; set; }


        // Appointment Data

        public int PatientId { get; set; }
        public int AppointmentId { get; set; }
        public int UserId { get; set; }
        public string Qrcode { get; set; }
        public string Branch { get; set; }
        public string Services { get; set; }
        public string AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }
        public string RescheduleDate { get; set; }
        public string RescheduleTime { get; set; } 
        public string Status { get; set; } 
        public Boolean Check_In { get; set; }
    }
}
