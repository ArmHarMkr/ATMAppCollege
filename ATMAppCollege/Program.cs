using ATMAppCollege.Data;
using System;
using System.Windows.Forms;

namespace ATMAppCollege
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

            // Create an instance of AppDbContext
            using (var dbContext = new AppDbContext())
            {
                ApplicationConfiguration.Initialize();
                // Pass the dbContext to the Form1 constructor
                Application.Run(new Form1(dbContext));
            }
        }
    }
}