using Microsoft.EntityFrameworkCore;

namespace SpecialLibrary.Context
{
    internal static class SpecialLibraryDbContextFactory
    {
        public static SpecialLibraryDbContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<SpecialLibraryDbContext>();

            var dbFilePath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "SpecialLibrary.db");

            optionsBuilder.UseSqlite($@"Data Source={dbFilePath};");

            return new SpecialLibraryDbContext(optionsBuilder.Options);
        }
    }
}
