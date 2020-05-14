using AutoMapper;
using MaskSupplier.Domain.Models;
using MaskSupplier.Domain.Queries.City.GetCity;
using System.Linq;

namespace MaskSupplier.Domain.AutoMapper
{
    public class DomainToModelMappingProfile : Profile
    {
        public DomainToModelMappingProfile()
        {

            CreateMap<Models.Mask, Dto.Mask>()
                .ForMember(dest => dest.Supplier, opt => opt.Ignore());

            CreateMap<Models.Supplier, Dto.Supplier>()
                .ForMember(dest => dest.Masks, opt => opt.Ignore())
                .ForMember(dest => dest.City, opt => opt.Ignore());

            CreateMap<Models.City, GetCityQueryResponse>()
                .ForMember(dest => dest.Suppliers, opt => opt.MapFrom(src => src.Suppliers));
        }
    }
}