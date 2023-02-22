using Adoption.Shared.Extensions;
using Adoption.Shared.Time;
using Microsoft.Extensions.DependencyInjection;

namespace Adoption.Shared.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddShared(this IServiceCollection services)
        {
            services.AddSingleton<IDateTimeProvider, UtcTimeProvider>();
            return services;
        }
    }
}