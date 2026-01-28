using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ShareLib.SharedExtension;

public static class JwtExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddJwtAuthentication()
        {
            var config = services.BuildServiceProvider().GetRequiredService<IConfiguration>();
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.Authority = "https://dev-i3fy5nyaqj55t6uh.us.auth0.com/";
                options.Audience = "http://localhost:5295";
            });

            return services;
        }
    }
}
