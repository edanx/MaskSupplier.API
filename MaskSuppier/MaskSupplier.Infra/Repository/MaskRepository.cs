using MaskSupplier.Domain.Interfaces;
using MaskSupplier.Domain.Models;
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
