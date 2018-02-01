namespace FamilyArchive.Data.ModelConfiguration
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Model;

    public class UserConfiguration : BaseConfiguration<User>
    {
        protected override string TableName => nameof(User);

        protected override void DetailConfiguration(EntityTypeBuilder<User> entity)
        {
            entity.Property(x => x.ConcurrencyStamp).HasMaxLength(500);
            entity.Property(x => x.Email).HasMaxLength(200);
            entity.Property(x => x.NormalizedEmail).HasMaxLength(200);
            entity.Property(x => x.NormalizedUserName).HasMaxLength(200);
            entity.Property(x => x.PasswordHash).HasMaxLength(500);
            entity.Property(x => x.PhoneNumber).HasMaxLength(50);
            entity.Property(x => x.SecurityStamp).HasMaxLength(500);
            entity.Property(x => x.UserName).HasMaxLength(200);
        }
    }
}