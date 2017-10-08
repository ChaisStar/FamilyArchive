namespace FamilyArchive.Data.Extensions
{
    using Microsoft.EntityFrameworkCore;
    using Model;
    using ModelConfiguration;

    public static class ModelBuilderExtensions
    {
        public static ModelBuilder AddConfiguration<T>(this ModelBuilder modelBuilder, IDbEntityConfiguration<T> entityConfiguration)
            where T : class, IDbEntity
        {
            modelBuilder.Entity<T>(entityConfiguration.Configure);
            return modelBuilder;
        }

        public static ModelBuilder AddConfiguration<TEntity, TEntityConfiguration>(this ModelBuilder modelBuilder)
            where TEntity : class, IDbEntity
            where TEntityConfiguration : class, IDbEntityConfiguration<TEntity>, new()
        {
            new TEntityConfiguration().Configure(modelBuilder.Entity<TEntity>());
            return modelBuilder;
        }
    }
}