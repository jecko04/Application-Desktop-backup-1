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

            //gawa ka ng view sa superadmin para sa dental doctors account next time
            //wag kalimutan yung email sa login
            //wag kalimutan yung forgot password sa login

            //dagdag ka ng if nothing selected sa check box, it messagebox the delete button no selected item/data

            //gawa ka ng staff attendance monitory at register ng staff like dental doctor at iba pa

            //paki fix ng delete sa admin
            //gumawa ka ng polling the database para every 5 second ma fetch lagi yung data

            //latest
            //gawa na ng para sa staff information
            

            //use async await on all form
        }
    }
}