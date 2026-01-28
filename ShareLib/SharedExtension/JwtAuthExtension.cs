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
                options.Authority = config["Auth0:Domain"];
                options.Audience = config["Auth0:Audience"];
            });

            return services;
        }
    }
}
