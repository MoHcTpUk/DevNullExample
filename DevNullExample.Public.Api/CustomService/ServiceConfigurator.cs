using DevNullCore.Ioc.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DevNullExample.Public.Api.CustomService
{
    public class ServiceConfigurator : IServicesConfigurator
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ICustomService, CustomService>();
        }
    }
}