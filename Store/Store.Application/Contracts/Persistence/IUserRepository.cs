using Microsoft.AspNetCore.Identity;
using Store.Domain;

namespace Store.Application.Contracts.Persistence
{
    public interface IUserRepository : IGenericRepository<ApplicationUser>
    {
        Task<bool> IsUniqueUser(string username);

        Task<ApplicationUser> GetByUserName(string username);

        Task<ApplicationUser> Login(string username, string password);

        Task<IList<string>> GetRolesAsync(ApplicationUser user);

        Task<IdentityResult> Register(ApplicationUser user, string password);

        Task<bool> RoleExistsAsync(string roleName);

        Task CreateRolesAsync(List<IdentityRole> roles);

        Task AddToRoleAsync(ApplicationUser user, string role);

    }
}
