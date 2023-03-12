using AAdoption.Infrastructure.Offerts;
using Adoption.Application.Common.Interfaces.Authentication;
using Adoption.Application.Offerts.Queries.GetOffert;
using Adoption.Application.Offerts.Services;
using Adoption.Auth;
using Adoption.Auth.EF.Contexts;
using Adoption.Auth.Repositiories;
using Adoption.Domain.Offerts.Repositiories;
using Adoption.Domain.Pets.Repositiories;
using Adoption.Infrastructure.Authentication;
using Adoption.Infrastructure.Database;
using Adoption.Infrastructure.Domain.Offerts;
using Adoption.Infrastructure.Domain.Pets;
using Adoption.Infrastructure.Domain.Users;
using Adoption.Shared.Abstractions.Queries;
using Adoption.Shared.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Adoption.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            ConfigurationManager configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.Name));
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

            //REPOSITORIES
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IOffertRepository, OffertRepository>();
            services.AddScoped<IPetRepository, PetRepository>();

            //SERVICES
            services.AddScoped<IOffertService, OffertService>();

            var options = configuration.GetOptions<SqlServerOptions>("SqlServer");

            services.AddDbContext<AppDbContext>(
                ctx => ctx.UseSqlServer(options.ConnectionString));

            services.AddDbContext<UserDbContext>(
             ctx => ctx.UseSqlServer(options.ConnectionString));

            return services;
        }
    }
}