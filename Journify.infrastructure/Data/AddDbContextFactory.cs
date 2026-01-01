using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace Journify.infrastructure.Data
{
    public static class AddDbContextFactory
    {
        public static void AddInMemoryDb(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseInMemoryDatabase("JournifyInMemoryDb"));
        }
    }
}
