using Application_Desktop.Admin_Sub_Views;
using Application_Desktop.Models;
using Application_Desktop.Screen;
using Application_Desktop.Views;
using Handy.DotNETCoreCompatibility.ColourTranslations;
using Microsoft.Win32;
using System.Net;

namespace Application_Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Thread httpThread = new Thread(StartLocalHttpServer);
            httpThread.Start();

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
    }
}