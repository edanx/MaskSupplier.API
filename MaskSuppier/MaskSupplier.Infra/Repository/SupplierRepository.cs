using MaskSupplier.Domain.Entities;
using MaskSupplier.Domain.Interfaces.Repository;
using MaskSupplier.Infra.Context;

namespace MaskSupplier.Infra.Repository
{
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(MaskSupplierContext context) : base(context)
        {
        }
    }
}
