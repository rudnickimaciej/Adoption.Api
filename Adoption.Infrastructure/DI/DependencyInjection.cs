using Adoption.Application.Common.Interfaces.Authentication;
using Adoption.Domain.Repositiories;
using Adoption.Infrastructure.Authentication;
using Adoption.Infrastructure.EF.DI;
using Adoption.Infrastructure.Repositories;
using Adoption.Shared.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Adoption.Infrastructure.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            ConfigurationManager configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.Name));
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddQueries();
            services.AddSqlServer(configuration);
            return services;
        }
    }
}