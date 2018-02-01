namespace FamilyArchive.Data
{
    using Microsoft.EntityFrameworkCore;

    public class FamilyArchiveOptionsBuilder : IFamilyArchiveOptionsBuilder
    {
        private readonly string _connectionString;

        public FamilyArchiveOptionsBuilder(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbContextOptions<FamilyArchiveContext> Build()
        {
            var optionsBuilder = new DbContextOptionsBuilder<FamilyArchiveContext>();
            optionsBuilder.UseNpgsql(_connectionString);
            return optionsBuilder.Options;
        }
    }
}