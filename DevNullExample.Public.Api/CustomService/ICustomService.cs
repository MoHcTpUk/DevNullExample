using System.Collections.Generic;

namespace DevNullExample.Public.Api.CustomService
{
    public interface ICustomService
    {
        public IEnumerable<WeatherForecast> Get();
    }
}
