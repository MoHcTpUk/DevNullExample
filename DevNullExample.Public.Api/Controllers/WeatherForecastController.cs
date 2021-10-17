using DevNullExample.Public.Api.CustomService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace DevNullExample.Public.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICustomService _customService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICustomService customService)
        {
            _logger = logger;
            _customService = customService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _customService.Get();
        }
    }
}
