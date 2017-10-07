namespace FamilyArchive.Data.ModelConfiguration
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Model;

    public class PhraseConfiguration : BaseConfiguration<Phrase>
    {
        protected override string TableName => nameof(Phrase);

        protected override void DetailConfiguration(EntityTypeBuilder<Phrase> entity)
        {
            entity.Property(x => x.From).HasMaxLength(100);
            entity.Property(x => x.To).HasMaxLength(100);
            entity.Property(x => x.Text).HasMaxLength(100);
        }
    }
}