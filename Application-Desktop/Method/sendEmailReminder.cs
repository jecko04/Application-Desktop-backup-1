using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Application_Desktop.Models;
using System.Data;
using Application_Desktop.Model;

namespace Application_Desktop.Method
{
    public class sendEmailReminder
    {
        private async Task<bool> SendEmailReminder(string userEmail, string appointmentId)
        {

            string fromEmail = "smtc.dentalcare@gmail.com";
            string appPassword = "pskv swrc tyqh hldz";


            // Create a new MailMessage object
            MailMessage mail = new MailMessage(fromEmail, userEmail);
            mail.Subject = $"Reminder on Your Appointment";
            mail.IsBodyHtml = true;

            mail.Body = $@"<html>
                <body style=""font-family: Arial, sans-serif; color: #333; line-height: 1.6;"">
                    <div style=""max-width: 600px; margin: auto; padding: 20px; border: 1px solid #ccc; border-radius: 10px;"">
                        <h2 style=""color: #2c3e50; text-align: center;"">Upcoming Appointment Reminder</h2>
                        <p>Our valued client,</p>

                        <p>
                            This is a friendly reminder that your appointment with Appointment ID: 
                            <strong>{appointmentId}</strong> is approaching soon.
                        </p>

                        <p style=""text-align: center; font-style: italic; color: #7f8c8d;"">
                            ""Your smile is our top priority!""
                        </p>

                        <hr style=""border: 1px solid #ddd;"">

                        <footer style=""text-align: center;"">
                            <p style=""color: #2980b9; font-size: 16px; margin: 0;"">Ynares, DMJ Bldg, A. Mabini St, Rodriguez, Rizal</p>
                            <p style=""color: #2980b9; font-size: 16px; margin: 10px 0;"">0933 821 2439</p>
                            <p style=""color: #2980b9; font-size: 16px; margin: 0;"">P4JR+4J4, L.M.Santos St, Rosario, Rodriguez, 1860 Rizal</p>
                        </footer>

                        <p style=""text-align: center; color: #7f8c8d; font-size: 14px; margin-top: 20px;"">
                            Thank you for choosing our dental care. We are always here to assist you!
                        </p>
                    </div>
                </body>
            </html>";


            // Set up the SMTP client
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(fromEmail, appPassword),
                EnableSsl = true
            };



            try
            {
                await smtpClient.SendMailAsync(mail);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error sending reminder {ex.Message}");
                return false;
            }

        }

        public async Task<bool> CheckAppointmentAndSendReminder()
        {
            string query = @"
                    SELECT 
                        a.id, a.user_id, u.email, a.selectedBranch, a.selectServices, a.appointment_date, 
                        a.appointment_time, a.reschedule_date, a.reschedule_time, a.status, a.qr_code, 
                        a.check_in, a.created_at, a.updated_at
                    FROM appointments a
                    JOIN users u ON a.user_id = u.id
                    WHERE a.status = 'approved';";
            try
            {
                using (MySqlConnection conn = databaseHelper.getConnection())
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                    {
                        await conn.OpenAsync();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            bool reminderSent = false; 

                            while (await reader.ReadAsync())
                            {
                                long appointmentId = reader.GetInt64("id");
                                string userEmail = reader.GetString("email");
                                string status = reader.GetString("status");

                                if (status == "approved")
                                {
                                    await SendEmailReminder(userEmail, appointmentId.ToString());
                                    reminderSent = true; 
                                }
                            }

                            return reminderSent; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in CheckAppointmentAndSendReminder: {ex.Message}");
            }
        }



    }
}
