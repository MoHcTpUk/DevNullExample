using AutoMapper;
using DevNullExample.Public.BL.Dto;
using DevNullExample.Public.Domain.Models;

namespace DevNullExample.Public.BL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<WeatherForecast, WeatherForecastDto>().ReverseMap();
        }
    }
}