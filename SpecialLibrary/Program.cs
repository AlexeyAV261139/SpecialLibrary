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
            ApplicationConfiguration.Initialize();
            SpecialLibraryDbContext.Shared.Database.Migrate();
            Application.Run(new MainForm());
        }
    }
}