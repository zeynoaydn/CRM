using AutoMapper;
using Business.Dtos;
using Entities.Concrete;

namespace Business.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Products, ProductsDto>().ReverseMap();

            CreateMap<Cities, CitiesDto>().ReverseMap();

            CreateMap<Countries, CountriesDto>().ReverseMap();

        }
    }
}
