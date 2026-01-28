using Journify.core.Entities;
using UserManagment.service.commands;
using UserManagment.service.Interfaces;

namespace UserManagment.service.usecases
{
    public class UserServices(IUserRepository userRepository) : IUserService
    {
        private readonly IUserRepository _userRepository = userRepository;

        public async Task<Guid> CreateUser(ProvisionUserCommand command)
        {
            if (string.IsNullOrWhiteSpace(command.AuthSub))
                throw new ArgumentException("AuthSub is required");
            if (string.IsNullOrWhiteSpace(command.Email))
                throw new ArgumentException("Email is required");
            if (string.IsNullOrWhiteSpace(command.Username))
                throw new ArgumentException("Username is required");
            User user = User.Create(command.AuthSub, command.Username, command.Email, command.EmailVerified);
            return await _userRepository.CreateUserAsync(user);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }
        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await _userRepository.GetUserByIdAsync(id)
                ?? throw new KeyNotFoundException($"User with id {id} not found.");
        }
    }
}
