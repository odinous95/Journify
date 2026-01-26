using Journify.core.Entities;
using Microsoft.EntityFrameworkCore;

namespace UserManagment.infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
