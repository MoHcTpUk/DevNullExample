using System;
using System.Linq;
using AutoMapper;
using DevNullCore.Domain.Repository;
using DevNullExample.Public.Application.Dto;
using DevNullExample.Public.Application.Services.Interfaces;
using DevNullExample.Public.Domain.Models;

namespace DevNullExample.Public.Application.Services.Concrete
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

        public WeatherForecastDto GetForecast(int id)
        {
            var entity = _weatherForecastRepository.Find(_ => _.Id == 1).FirstOrDefault();

            if (entity == null)
                throw new Exception("Not found!");

            var dto = _mapper.Map<WeatherForecastDto>(entity);

            return dto;
        }
    }
}
