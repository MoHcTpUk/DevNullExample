using DevNullCore.Domain.Repository;
using DevNullCore.Ioc.Interfaces;
using DevNullExample.Public.Domain.Models;
using DevNullExample.Public.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DevNullExample.Public.Infrastructure
{
    public class ServiceConfigurator : IServicesConfigurator
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IRepository<WeatherForecast>, WeatherForecastRepository>();
        }
    }
}