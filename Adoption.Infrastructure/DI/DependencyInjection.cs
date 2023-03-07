using Adoption.Application.Common.Interfaces.Authentication;
using Adoption.Application.Offerts.DTO;
using Adoption.Application.Offerts.Queries;
using Adoption.Domain.Users.Repositiories;
using Adoption.Infrastructure.Authentication;
using Adoption.Infrastructure.EF.DI;
using Adoption.Infrastructure.EF.Queries;
using Adoption.Infrastructure.Repositories;
using Adoption.Shared.Abstractions.Queries;
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
            services.AddScoped<IQueryHandler<GetOffert, OffertDto>, GetOffertHandler>();//do usunięcia (linijka wyżej powinno to załatwiać)
            services.AddSqlServer(configuration);
            return services;
        }
    }
}