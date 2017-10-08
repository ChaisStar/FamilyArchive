namespace FamilyArchive.Data.ModelConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Model;

    public abstract class BaseConfiguration<T> : IDbEntityConfiguration<T> where T : class, IDbEntity
    {
        public void Configure(EntityTypeBuilder<T> entity)
        {
            entity.ToTable(TableName);
            entity.HasKey(x => x.Guid);
            entity.Property(x => x.Guid).ValueGeneratedOnAdd();
            entity.Property(x => x.Created).IsRequired();
            entity.Property(x => x.Updated).IsRequired();
            DetailConfiguration(entity);
        }

        protected abstract string TableName { get; }

        protected abstract void DetailConfiguration(EntityTypeBuilder<T> entity);
    }
}