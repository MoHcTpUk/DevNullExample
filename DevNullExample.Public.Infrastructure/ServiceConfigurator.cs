using DevNullCore.Ioc.Interfaces;
using DevNullExample.Public.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DevNullExample.Public.Infrastructure
{
    public class ServiceConfigurator : IServicesConfigurator
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<WeatherForecastRepository>();
        }
    }
}