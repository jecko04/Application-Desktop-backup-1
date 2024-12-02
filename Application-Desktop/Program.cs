using Application_Desktop.Admin_Sub_Views;
using Application_Desktop.Models;
using Application_Desktop.Screen;
using Application_Desktop.Views;
using Handy.DotNETCoreCompatibility.ColourTranslations;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System.Net;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Application_Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        private static WebSocketServer wssv;

        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Thread httpThread = new Thread(StartLocalHttpServer);
            httpThread.Start();

            Thread websocketThread = new Thread(StartWebSocketServer);
            websocketThread.Start();

            ApplicationConfiguration.Initialize();
            Application.Run(new loginPage());

            //Close the database

        }

        private static void StartLocalHttpServer()
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8080/"); 
            listener.Start();

            while (true)
            {
                // Wait for a request
                var context = listener.GetContext();
                var request = context.Request;
                var response = context.Response;

                if (request.Url.AbsolutePath.StartsWith("/resetpassword"))
                {
                    string token = request.QueryString["token"];

                    // Here you can open your ResetPassword form
                    if (!string.IsNullOrEmpty(token))
                    {
                        Application.Run(new Views.forgot.ResetPassword(token)); 
                    }
                }

                response.StatusCode = 200;
                response.Close();
            }
        }

        private async static void StartWebSocketServer()
        {
            // Create the WebSocket server
            wssv = new WebSocketServer("ws://localhost:8081");

            // Add a WebSocket behavior to handle messages
            wssv.AddWebSocketService<AppointmentWebSocketBehavior>("/appointments");

            // Start the WebSocket server
            try
            {
                // Start the WebSocket server
                wssv.Start();
                //MessageBox.Show("WebSocket server started on ws://localhost:8081");

                // Wait for the main form to be available
                while (Application.OpenForms.Count == 0)
                {
                    // Wait until the main form is loaded
                    await Task.Delay(100);  // Check every 100 milliseconds
                }

                // Access the first open form (main form)
                var mainForm = Application.OpenForms[0];

                await MonitorDatabaseForNewAppointments(mainForm);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to start WebSocket server: {ex.Message}");
            }
        }

        static async Task MonitorDatabaseForNewAppointments(Form mainForm)
        {
            string query = @"
                    SELECT 
                        appointments.id AS AppointmentID, 
                        appointments.*,
                        users.name AS UserName,
                        branch.BranchName,
                        categories.Title AS ServiceTitle
                    FROM 
                        appointments
                    INNER JOIN 
                        users ON appointments.user_id = users.id
                    INNER JOIN 
                        branch ON appointments.selectedBranch = branch.Branch_ID
                    INNER JOIN 
                        categories ON appointments.selectServices = categories.Categories_ID
                    WHERE 
                        (CONVERT_TZ(appointments.updated_at, '+00:00', '+08:00') > @lastCheck 
                        OR CONVERT_TZ(appointments.created_at, '+00:00', '+08:00') > @lastCheck)
                        AND (appointments.status = 'pending' OR appointments.status = 'cancelled')";

            DateTime lastCheck = DateTime.UtcNow; 
            var processedAppointments = new Dictionary<string, DateTime>(); 

            while (true)
            {
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
                            cmd.Parameters.AddWithValue("@lastCheck", lastCheck);

                            using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                            {
                                DateTime maxTimestamp = lastCheck;

                                while (await reader.ReadAsync())
                                {
                                    string appointmentId = reader["AppointmentID"].ToString();
                                    DateTime rowTimestamp = Convert.ToDateTime(reader["updated_at"]);

                                    // Skip if the appointment has already been processed and has no updates
                                    if (processedAppointments.ContainsKey(appointmentId) && processedAppointments[appointmentId] >= rowTimestamp)
                                    {
                                        continue;
                                    }

                                    processedAppointments[appointmentId] = rowTimestamp;
                                    if (rowTimestamp > maxTimestamp)
                                    {
                                        maxTimestamp = rowTimestamp;
                                    }

                                    string appointmentDetails = $"{reader["status"]} - {reader["UserName"]} - {reader["BranchName"]} - {reader["ServiceTitle"]}";

                                    // Send notification for new or updated appointment
                                    mainForm.Invoke((MethodInvoker)(() =>
                                    {
                                        NotificationHelper.ShowNotification(mainForm, appointmentDetails);
                                    }));
                                }

                                lastCheck = maxTimestamp;
                            }
                        }
                    }

                    await Task.Delay(3000); // Poll every 3 seconds
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error monitoring appointments: {ex.Message}");
                }
            }
        }





        static void BroadcastNewAppointment(string details)
        {
            wssv.WebSocketServices["/appointments"].Sessions.Broadcast("New appointment: " + details);
        }

        
    }


    public class AppointmentWebSocketBehavior : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            // Handle incoming messages from clients
            MessageBox.Show($"Message received: {e.Data}");
            Send($"Echo: {e.Data}");
        }
    }

    public static class NotificationHelper
    {
        public static void ShowNotification(Form mainForm, string message)
        {
            if (mainForm.InvokeRequired)
            {
                mainForm.Invoke(new Action(() => ShowNotification(mainForm, message)));
                return;
            }

            AlertBox(Color.LightGray, Color.DimGray, "Appointment Update", message, Properties.Resources.success);
        }

        static void AlertBox(Color backcolor, Color color, string title, string subtitle, Image icon)
        {
            alertBox alertbox = new alertBox();
            alertbox.BackColor = backcolor;
            alertbox.ColorAlertBox = color;
            alertbox.TitleAlertBox = title;
            alertbox.SubTitleAlertBox = subtitle;
            alertbox.IconAlertBox = icon;
            alertbox.Show();
        }
    }
}