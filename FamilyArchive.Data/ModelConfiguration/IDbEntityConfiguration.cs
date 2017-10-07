namespace FamilyArchive.Data.ModelConfiguration
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Model;

    public interface IDbEntityConfiguration<T> where T : class, IDbEntity
    {
        void Configure(EntityTypeBuilder<T> entity);
    }
}