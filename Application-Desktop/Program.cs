using Application_Desktop.Models;
using Application_Desktop.Screen;
using Application_Desktop.Views;

namespace Application_Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Open the database
            await databaseHelper.initializeConnection();

            Application.Run(new loginPage());

            //Close the database
            await databaseHelper.closeConnection();

            //wag kalimutan yung email sa login
            //wag kalimutan yung forgot password sa login

            //gumawa ka ng polling the database para every 5 second ma fetch lagi yung data

            //latest
            //gawa na ng para sa staff information
            

            //use transaction to all form to avoid error out of sync with server
        }
    }
}