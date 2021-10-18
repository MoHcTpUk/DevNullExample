using DevNullCore.EF.Infrastructure.Repository;
using DevNullExample.Public.Domain.Models;
using DevNullExample.Public.Infrastructure.EF;

namespace DevNullExample.Public.Infrastructure.Repositories
{
    public class WeatherForecastRepository : AbstractRepository<WeatherForecast>
    {
        public WeatherForecastRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}