using AutoMapper;
using MaskSupplier.Domain.Commands.Supplier.AddSupplier;

namespace MaskSupplier.Domain.AutoMapper
{
    public class ModelToDomainMappingProfile : Profile
    {
        public ModelToDomainMappingProfile()
        {

            CreateMap<AddSupplierCommand, Models.Supplier>()
                .ForMember(dest => dest.Masks, opt => opt.Ignore())
                .ForMember(dest => dest.City, opt => opt.Ignore())
                .ForMember(dest => dest.CityId, opt => opt.Ignore())
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<Commands.Supplier.AddSupplier.Mask, Models.Mask>()
                .ForMember(dest => dest.Supplier, opt => opt.Ignore())
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}