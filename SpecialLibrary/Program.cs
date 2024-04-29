using Microsoft.EntityFrameworkCore;
using SpecialLibrary.Context;
using SpecialLibrary.Views;

namespace SpecialLibrary
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
            //SpecialLibraryDbContext.Shared.Database.Migrate();
            Application.Run(new MainForm());
        }
    }
}