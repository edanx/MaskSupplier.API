using MaskSupplier.Domain.Entities;

namespace MaskSupplier.Domain.Interfaces.Repository
{
    public interface ICityRepository : IRepository<City>
    {
        City GetByIdWithSupplierAndMasks(long id);
    }
}
