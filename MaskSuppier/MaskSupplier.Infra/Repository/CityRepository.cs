using MaskSupplier.Domain.Interfaces;
using MaskSupplier.Domain.Models;
using MaskSupplier.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaskSupplier.Infra.Repository
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(MaskSupplierContext context) : base(context)
        {
        }

        public List<City> GetWithSupplierAndMasks()
        {
            return DbSet.Include(x => x.Suppliers).ThenInclude(x => x.Masks).ToList() ;
        }
    }
}
