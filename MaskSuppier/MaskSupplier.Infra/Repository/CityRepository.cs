using MaskSupplier.Domain.Entities;
using MaskSupplier.Domain.Interfaces.Repository;
using MaskSupplier.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MaskSupplier.Infra.Repository
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(MaskSupplierContext context) : base(context)
        {
        }

        public City GetByIdWithSupplierAndMasks(long id)
        {
            return DbSet.Where(x => x.Id == id).Include(x => x.Suppliers).ThenInclude(x => x.Masks).FirstOrDefault() ;
        }
    }
}
