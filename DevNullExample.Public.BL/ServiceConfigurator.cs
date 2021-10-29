using DevNullCore.Ioc.Interfaces;
using DevNullExample.Public.BL.Services.Concrete;
using DevNullExample.Public.BL.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DevNullExample.Public.BL
{
    public class ServiceConfigurator : IServicesConfigurator
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();
        }
    }
}