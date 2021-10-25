using AutoMapper;
using DevNullExample.Public.Application.Dto;
using DevNullExample.Public.Domain.Models;

namespace DevNullExample.Public.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<WeatherForecast, WeatherForecastDto>().ReverseMap();
        }
    }
}