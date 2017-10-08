namespace FamilyArchive.Data.Repository
{
    using System.Threading.Tasks;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly FamilyArchiveContext _context;

        public UnitOfWork(IDbFactory dbFactory)
        {
            _context = dbFactory.Init();
        }

        public Task SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}