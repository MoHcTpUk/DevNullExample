using DevNullExample.Public.BL.Dto;
using System.Threading.Tasks;

namespace DevNullExample.Public.BL.Services.Interfaces
{
    public interface IWeatherForecastService
    {
        public Task<WeatherForecastDto> Create(WeatherForecastDto dto);
        public WeatherForecastDto Get(int id);
    }
}
