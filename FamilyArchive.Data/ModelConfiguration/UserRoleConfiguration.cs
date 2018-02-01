namespace FamilyArchive.Data.ModelConfiguration
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Model;

    public class UserRoleConfiguration : BaseConfiguration<UserRole>
    {
        protected override string TableName => nameof(UserRole);

        protected override void DetailConfiguration(EntityTypeBuilder<UserRole> entity)
        {
            entity.Property(x => x.Name).HasMaxLength(200);
            entity.Property(x => x.NormalizedName).HasMaxLength(200);
            entity.Property(x => x.ConcurrencyStamp).HasMaxLength(500);
        }
    }
}