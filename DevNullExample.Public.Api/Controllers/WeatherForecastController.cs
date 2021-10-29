using System.Threading.Tasks;
using DevNullExample.Public.Application.Commands.WeatherForecast;
using DevNullExample.Public.BL.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevNullExample.Public.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _mediator;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        //[HttpGet]
        //public WeatherForecastDto Get(int id)
        //{
        //    return _weatherForecastService.Get(id);
        //}

        [HttpPost]
        public async Task<WeatherForecastDto> Create(CreateWeatherForecastRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}