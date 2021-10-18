using DevNullCore.Domain.Entitity;
using System;

namespace DevNullExample.Public.Domain.Models
{
    public class WeatherForecast: BaseEntity<int>
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}