using System;
using AutoMapper;
using MaskSupplier.Domain.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace MaskSupplier.API.Configurations
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DomainToModelMappingProfile), typeof(ModelToDomainMappingProfile));
        }
    }
}
