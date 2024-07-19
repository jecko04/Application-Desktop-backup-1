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
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Open the database
            databaseHelper.initializeConnection();

            Application.Run(new loginPage());

            //Close the database
            databaseHelper.closeConnection();

            //Gawa ka ng admin  panel na
            //gawan mo ng search bar yung admin
            
        }
    }
}