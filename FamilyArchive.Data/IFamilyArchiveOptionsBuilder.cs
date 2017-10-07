using Microsoft.EntityFrameworkCore;

namespace FamilyArchive.Data
{
    public interface IFamilyArchiveOptionsBuilder
    {
        DbContextOptions<FamilyArchiveContext> Build(string connectionString);
    }
}