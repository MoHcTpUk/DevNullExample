using DevNullCore.Bus;
using DevNullExample.Public.BL.Dto;

namespace DevNullExample.Public.Application.Events
{
    public class WeatherForecastCreatedEvent : Event
    {
        public WeatherForecastDto WeatherForecast { get; set; }

        public WeatherForecastCreatedEvent(WeatherForecastDto weatherForecast)
        {
            WeatherForecast = weatherForecast;
            Name = nameof(WeatherForecastCreatedEvent);
        }
    }
}
