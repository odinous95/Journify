using Journify.core.Entities;

namespace UserManagment.service.Interfaces
{
    public interface IUserRepository
    {
        Task AddUserAsync(User user);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(Guid id);
        Task<User> UpdateUserAsync(User user);
        Task<bool> DeleteUserAsync(Guid id);
    }
}
