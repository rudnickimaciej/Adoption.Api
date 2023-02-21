using Adoption.Application.Services.Authentication;
using Adoption.Shared.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Adoption.Application.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddCommands();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            return services;
        }
    }
}