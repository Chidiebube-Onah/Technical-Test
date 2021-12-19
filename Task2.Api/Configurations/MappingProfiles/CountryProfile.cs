using AutoMapper;
using Task2.Models.Dtos;
using Task2.Models.Entities;

namespace Task2.Api.Configurations.MappingProfiles
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {

            CreateMap<Country, CountryDto>();

            CreateMap<CountryDetail, CountryDetailDto>();

            CreateMap<Country, SearchResponseDto>()
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src));
        }
    }
}
