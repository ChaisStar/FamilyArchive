namespace FamilyArchive.Application.Infrustructure
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Model;
    
    public class UserManager : IUserManager
    {
        private readonly UserManager<User> _userManager;

        public UserManager(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public Task<IdentityResult> CreateAsync(User user, string password) => _userManager.CreateAsync(user, password);

        public async Task<User> LoginAsync(string username, string password)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
                return null;
            if (await _userManager.CheckPasswordAsync(user, password))
                return user;
            return null;
        }
    }
}
