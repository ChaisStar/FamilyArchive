using System.Threading.Tasks;
using FamilyArchive.Model;
using Microsoft.AspNetCore.Identity;

namespace FamilyArchive.Application.Infrustructure
{
    public interface IUserManager
    {
        Task<IdentityResult> CreateAsync(User user, string password);
        Task<User> LoginAsync(string username, string password);
    }
}