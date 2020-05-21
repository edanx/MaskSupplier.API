using MaskSupplier.Domain.Interfaces.Repository;
using MaskSupplier.Infra.Repository;
using MaskSupplier.Service;
using MaskSupplier.Service.Interface.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MaskSupplier.CrossCutting
{
    public class NativeInjectorBootstrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<IMaskRepository, MaskRepository>();
            services.AddScoped<ICityRiskService, CityRiskService>();
            
        }

    }
}
