namespace FamilyArchive.Data
{
    using Microsoft.EntityFrameworkCore;
    using Model;

    public class FamilyArchiveContext : DbContext
    {
        public FamilyArchiveContext(DbContextOptions<FamilyArchiveContext> options)
            : base(options)
        {

        }

        public DbSet<Phrase> Phrases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}