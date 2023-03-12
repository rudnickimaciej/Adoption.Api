using Adoption.Application.Common.Services.Authentication;
using Adoption.Application.Users.Commands;
using Adoption.Auth.Services;
using Adoption.Shared.Abstractions.Command;
using Microsoft.Extensions.DependencyInjection;
using Adoption.Application.Offerts.Commands.AddOffert;
using Adoption.Application.Users.Commands.RegisterUser;

namespace Adoption.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            //services.AddCommands();
            //services.AddScoped(typeof(ICommandHandler<RegisterUserCommand>), typeof(RegisterUserCommandHandler));//to delete

            services.AddScoped<IAuthenticationService, AuthenticationService>();
            return services;
        }
    }
}