using DevNullCore.Ioc.Interfaces;
using DevNullExample.Public.Application.Services.Concrete;
using DevNullExample.Public.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DevNullExample.Public.Application
{
    public class ServiceConfigurator : IServicesConfigurator
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();
        }
    }
}