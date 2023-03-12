using Adoption.Auth.EF.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Adoption.Auth.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAuth(this IServiceCollection services)
        {
            services.AddIdentity<IdentityUser, IdentityRole>(
                options =>
                {
                    options.Password.RequiredLength = 8;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase= false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireDigit = false;
                    options.Lockout.MaxFailedAccessAttempts = 5;
                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMilliseconds(15);
                    options.User.RequireUniqueEmail = true;

                })
                .AddEntityFrameworkStores<UserDbContext>();


            return services;
        }
    }
}