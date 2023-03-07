﻿using Adoption.Auth.EF.Contexts;
using Adoption.Domain.Offerts.Repositiories;
using Adoption.Infrastructure.EF.Contexts.Read;
using Adoption.Infrastructure.EF.Contexts.Write;
using Adoption.Infrastructure.EF.Options;
using Adoption.Infrastructure.EF.Repositories;
using Adoption.Shared.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Adoption.Infrastructure.EF.DI
{
    internal static class SqlServer
    {
        public static IServiceCollection AddSqlServer(this IServiceCollection services, ConfigurationManager configuration)
        {
            var options = configuration.GetOptions<SqlServerOptions>("SqlServer");

            services.AddDbContext<ReadDbContext>(
                ctx => ctx.UseSqlServer(options.ConnectionString));

            services.AddDbContext<WriteDbContext>(
              ctx => ctx.UseSqlServer(options.ConnectionString));

            services.AddDbContext<UserDbContext>(
             ctx => ctx.UseSqlServer(options.ConnectionString));


            services.AddScoped<IOffertRepository, OffertRepository>();

            return services;
        }
    }
}
