namespace FamilyArchive.Data.ModelConfiguration
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Model;

    public abstract class BaseConfiguration<T> : IDbEntityConfiguration<T> where T : class, IDbEntity
    {
        public void Configure(EntityTypeBuilder<T> entity)
        {
            entity.ToTable(TableName);
            entity.HasKey(x => Key(x));
            entity.Property(x => x.Guid).ValueGeneratedOnAdd();
            entity.Property(x => x.Created).IsRequired().HasDefaultValueSql("GETUTCDATE()").ValueGeneratedOnAdd();
            entity.Property(x => x.Updated).IsRequired().HasDefaultValueSql("GETUTCDATE()").ValueGeneratedOnAddOrUpdate();
            DetailConfiguration(entity);
        }

        protected abstract string TableName { get; }

        protected abstract void DetailConfiguration(EntityTypeBuilder<T> entity);

        protected virtual Func<T, object> Key => x => x.Guid;
    }
}