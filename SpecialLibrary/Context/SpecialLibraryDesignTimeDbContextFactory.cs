using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SpecialLibrary.Context
{
    internal class SpecialLibraryDesignTimeDbContextFactory : IDesignTimeDbContextFactory<SpecialLibraryDbContext>
    {
        public SpecialLibraryDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SpecialLibraryDbContext>();

            var dbFilePath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "Context",
                "DesignTimeFiles",
                "SpecialLibrary.db");

            optionsBuilder.UseSqlite($@"Data Source={dbFilePath};");

            return new SpecialLibraryDbContext(optionsBuilder.Options);
        }
    }
}
