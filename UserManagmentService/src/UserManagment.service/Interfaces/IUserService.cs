using Journify.core.Entities;
using UserManagment.service.commands;

namespace UserManagment.service.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserProfileOrCreateAsync(UserCommand command);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(Guid id);
    }
}
