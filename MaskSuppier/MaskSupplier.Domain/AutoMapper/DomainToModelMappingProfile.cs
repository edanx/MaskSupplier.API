using AutoMapper;
using MaskSupplier.Domain.Models;
using MaskSupplier.Domain.Queries.City.GetCity;
using MaskSupplier.Domain.Queries.City.GetCityById;
using System.Linq;

namespace MaskSupplier.Domain.AutoMapper
{
    public class DomainToModelMappingProfile : Profile
    {
        public DomainToModelMappingProfile()
        {
            CreateMap<Entities.City, GetCityQueryResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Infecteds, opt => opt.MapFrom(src => src.Infecteds))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ZipCode, opt => opt.MapFrom(src => src.ZipCode));

            CreateMap<Entities.City, GetCityByIdQueryResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Infecteds, opt => opt.MapFrom(src => src.Infecteds))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ZipCode, opt => opt.MapFrom(src => src.ZipCode))
                .ForMember(dest => dest.Suppliers, opt => opt.MapFrom(src => src.Suppliers));


        }
    }
}