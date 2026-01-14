using Journify.core.Entities;
using Microsoft.AspNetCore.Identity;
using UserManagment.service.commands;
using UserManagment.service.Interfaces;


namespace UserManagment.service.usecases
{
    public class UserServices : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<Guid> AddUserAsync(CreateUserCommand command)
        {
            if (string.IsNullOrWhiteSpace(command.Email))
                throw new ArgumentException("Email is required");

            if (string.IsNullOrWhiteSpace(command.Password))
                throw new ArgumentException("Password is required");
            User user = new();

            var hashedPassword = new PasswordHasher<User>().HashPassword(user, command.Password);

            user.Email = command.Email;
            user.PasswordHash = hashedPassword;

            await _userRepository.AddUserAsync(user);
            return user.Id;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }
        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await _userRepository.GetUserByIdAsync(id);
        }
        public async Task<User> UpdateUserAsync(User user)
        {
            return await _userRepository.UpdateUserAsync(user);
        }
        public async Task<bool> DeleteUserAsync(Guid id)
        {
            return await _userRepository.DeleteUserAsync(id);
        }
    }
}
