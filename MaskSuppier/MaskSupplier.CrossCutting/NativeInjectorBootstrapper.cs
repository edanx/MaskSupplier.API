﻿using MaskSupplier.Domain.Interfaces;
using MaskSupplier.Domain.Queries.City.GetCity;
using MaskSupplier.Infra.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace MaskSupplier.CrossCutting
{
    public class NativeInjectorBootstrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICityRepository, CityRepository>();
            
        }

    }
}