using System.Threading;
using System.Threading.Tasks;
using DevNullCore.Bus.Interfaces;
using DevNullExample.Public.Application.Events;
using DevNullExample.Public.BL.Dto;
using DevNullExample.Public.BL.Services.Interfaces;
using MediatR;

namespace DevNullExample.Public.Application.Commands.WeatherForecast
{
    public class CreateWeatherForecastRequest : IRequest<WeatherForecastDto>
    {
        public int TemperatureC { get; set; }

        public string Summary { get; set; }
    }

    public class CreateWeatherForecastRequestHander : IRequestHandler<CreateWeatherForecastRequest, WeatherForecastDto>
    {
        private readonly IWeatherForecastService _weatherForecastService;
        private readonly IEventBus _eventBus;

        public CreateWeatherForecastRequestHander(IEventBus eventBus, IWeatherForecastService weatherForecastService)
        {
            _eventBus = eventBus;
            _weatherForecastService = weatherForecastService;
        }

        public async Task<WeatherForecastDto> Handle(CreateWeatherForecastRequest request, CancellationToken cancellationToken)
        {
            var dto = new WeatherForecastDto
            {
                TemperatureC = request.TemperatureC,
                Summary = request.Summary
            };

            dto = await _weatherForecastService.Create(dto);

            //_eventBus.Publish(new WeatherForecastCreatedEvent(dto));

            return dto;
        }
    }
}
