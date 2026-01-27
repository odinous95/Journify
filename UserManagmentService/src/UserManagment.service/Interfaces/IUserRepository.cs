using Journify.core.Entities;

namespace UserManagment.service.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetUserByExternalIdAsync(string externalAuthId);
        Task<User> CreateUserAsync(User user);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User?> GetUserByIdAsync(Guid id);
    }
}
