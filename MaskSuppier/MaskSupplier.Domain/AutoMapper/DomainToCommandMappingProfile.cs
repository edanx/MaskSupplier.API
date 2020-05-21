using AutoMapper;
using MaskSupplier.Domain.Commands.Supplier.AddSupplier;

namespace MaskSupplier.Domain.AutoMapper
{
    public class DomainToCommandMappingProfile : Profile
    {
        public DomainToCommandMappingProfile()
        {

            CreateMap<AddSupplierCommand, Entities.Supplier>()
                .ForMember(dest => dest.Masks, opt => opt.Ignore())
                .ForMember(dest => dest.City, opt => opt.Ignore())
                .ForMember(dest => dest.CityId, opt => opt.Ignore())
                .ForMember(dest => dest.Id, opt => opt.Ignore());

        }
    }
}