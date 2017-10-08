namespace FamilyArchive.Data
{
    public class DbFactory : IDbFactory
    {
        private readonly FamilyArchiveContext _context;

        public DbFactory(FamilyArchiveContext context)
        {
            _context = context;
        }

        public FamilyArchiveContext Init()
        {
            return _context;
        }
    }
}