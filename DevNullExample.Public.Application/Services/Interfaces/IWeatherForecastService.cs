using DevNullExample.Public.Application.Dto;

namespace DevNullExample.Public.Application.Services.Interfaces
{
    public interface IWeatherForecastService
    {
        public WeatherForecastDto GetForecast(int id);
    }
}
