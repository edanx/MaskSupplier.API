using MaskSupplier.Domain.Entities;
using MaskSupplier.Domain.Interfaces.Repository;
using MaskSupplier.Infra.Context;

namespace MaskSupplier.Infra.Repository
{
    public class MaskRepository : Repository<Mask>, IMaskRepository
    {
        public MaskRepository(MaskSupplierContext context) : base(context)
        {
        }
    }
}
