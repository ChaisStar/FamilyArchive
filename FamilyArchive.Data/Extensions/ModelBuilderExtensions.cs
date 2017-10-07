namespace FamilyArchive.Data.Extensions
{
    using Microsoft.EntityFrameworkCore;
    using Model;
    using ModelConfiguration;

    public static class ModelBuilderExtensions
    {
        public static void AddConfiguration<T>(this ModelBuilder modelBuilder, IDbEntityConfiguration<T> entityConfiguration)
            where T : class, IDbEntity
        {
            modelBuilder.Entity<T>(entityConfiguration.Configure);
        }
    }
}