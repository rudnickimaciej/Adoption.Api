using Adoption.Shared.Abstractions.Command;
using Adoption.Shared.Abstractions.Queries;
using Adoption.Shared.Commands;
using Adoption.Shared.Queries;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Adoption.Shared.Extensions
{
    public static class Extensions
    {
        public static IServiceCollection AddCommands(this IServiceCollection service)
        {
            var assembly = Assembly.GetExecutingAssembly();
            service.AddSingleton<ICommandDispatcher, InMemoryCommandDispatcher>();

            service.Scan(s => s.FromAssemblies(assembly)
            .AddClasses(c => c.AssignableTo(typeof(ICommandHandler<>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());

            return service;
        }

        public static IServiceCollection AddQueries(this IServiceCollection service)
        {
            var assembly = Assembly.GetExecutingAssembly();
            service.AddSingleton<IQueryDispatcher, InMemoryQueryDispatcher>();

            service.Scan(s => s.FromAssemblies(assembly)
            .AddClasses(c => c.AssignableTo(typeof(IQueryHandler<,>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());

            return service;
        }
    }
}
