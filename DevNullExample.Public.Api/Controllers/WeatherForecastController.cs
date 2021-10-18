using System.Linq;
using System.Threading.Tasks;
using DevNullExample.Public.Domain.Models;
using DevNullExample.Public.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevNullExample.Public.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly WeatherForecastRepository _weatherForecastRepository;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherForecastRepository weatherForecastRepository)
        {
            _logger = logger;
            _weatherForecastRepository = weatherForecastRepository;
        }

        [HttpGet]
        public WeatherForecast Get()
        {
            return _weatherForecastRepository.Find(_=>_.Id == 1).FirstOrDefault();
        }
    }
}
