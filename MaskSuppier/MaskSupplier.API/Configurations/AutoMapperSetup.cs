using System;
using System.Reflection;
using AutoMapper;
using MaskSupplier.Domain.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace MaskSupplier.API.Configurations
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services, params Assembly[] assemblies)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(assemblies);
        }
    }
}
