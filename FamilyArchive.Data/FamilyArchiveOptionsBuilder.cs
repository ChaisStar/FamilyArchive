namespace FamilyArchive.Data
{
    using Microsoft.EntityFrameworkCore;

    public class FamilyArchiveOptionsBuilder : IFamilyArchiveOptionsBuilder
    {
        public DbContextOptions<FamilyArchiveContext> Build(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FamilyArchiveContext>();
            optionsBuilder.UseNpgsql(connectionString);
            return optionsBuilder.Options;
        }
    }
}