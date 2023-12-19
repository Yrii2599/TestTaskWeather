using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Providers.Absctractions;
using Providers.Providers;

namespace Providers
{
    public static class ProvidersDependencyInjection
    {
        public static IServiceCollection InjectProviders(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IWeatherProvider, WeatherProvider>();
            return services;
        }

    }
}
