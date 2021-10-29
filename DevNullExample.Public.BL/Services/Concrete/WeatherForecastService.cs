using AutoMapper;
using DevNullCore.Domain.Repository;
using DevNullExample.Public.BL.Dto;
using DevNullExample.Public.BL.Services.Interfaces;
using DevNullExample.Public.Domain.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DevNullExample.Public.BL.Services.Concrete
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<WeatherForecast> _weatherForecastRepository;

        public WeatherForecastService(
            IMapper mapper,
            IRepository<WeatherForecast> weatherForecastRepository)
        {
            _mapper = mapper;
            _weatherForecastRepository = weatherForecastRepository;
        }

        public async Task<WeatherForecastDto> Create(WeatherForecastDto dto)
        {
            var entity = _mapper.Map<WeatherForecast>(dto);
            entity = await _weatherForecastRepository.Create(entity);

            return _mapper.Map<WeatherForecastDto>(entity);
        }

        public WeatherForecastDto Get(int id)
        {
            var entity = _weatherForecastRepository.Find(_ => _.Id == 1).FirstOrDefault();

            if (entity == null)
                throw new Exception("Not found!");

            var dto = _mapper.Map<WeatherForecastDto>(entity);

            return dto;
        }
    }
}
