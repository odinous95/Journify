using Journify.core.Entities;
using Microsoft.EntityFrameworkCore;
using UserManagment.infrastructure.Data;
using UserManagment.service.Interfaces;

namespace UserManagment.infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbcontext;
        public UserRepository(AppDbContext appDbContext)
        {
            _appDbcontext = appDbContext;
        }
        public async Task CreateUserAsync(User user)
        {
            _appDbcontext.Users.Add(user);
            await _appDbcontext.SaveChangesAsync();
        }
        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _appDbcontext.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _appDbcontext.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await _appDbcontext.Users.FindAsync(id);
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            _appDbcontext.Users.Update(user);
            await _appDbcontext.SaveChangesAsync();
            return user;
        }

        public Task<bool> DeleteUserAsync(Guid id)
        {
            _appDbcontext.Users.Remove(new User { Id = id });
            return _appDbcontext.SaveChangesAsync().ContinueWith(task => task.Result > 0);
        }


    }
}
