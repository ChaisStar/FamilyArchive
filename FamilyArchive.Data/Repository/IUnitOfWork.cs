namespace FamilyArchive.Data.Repository
{
    using System.Threading.Tasks;

    public interface IUnitOfWork
    {
        Task SaveAsync();
    }
}