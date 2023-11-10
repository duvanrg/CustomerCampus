using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles
{
    public class MappinProfiles : Profile
    {
        public MappinProfiles()
        {
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<State, StateDto>().ReverseMap();
            CreateMap<State, StateLstCitiesDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }

    }
}