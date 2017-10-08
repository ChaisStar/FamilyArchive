namespace FamilyArchive.Data
{
    using Extensions;
    using Microsoft.EntityFrameworkCore;
    using Model;
    using ModelConfiguration;

    public class FamilyArchiveContext : DbContext
    {
        public FamilyArchiveContext(DbContextOptions<FamilyArchiveContext> options)
            : base(options)
        {

        }

        public DbSet<Phrase> Phrases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration<Phrase, PhraseConfiguration>();
            base.OnModelCreating(modelBuilder);
        }
    }
}