using MaskSupplier.Domain.Interfaces;
using MaskSupplier.Domain.Models;
using MaskSupplier.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaskSupplier.Infra.Repository
{
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(MaskSupplierContext context) : base(context)
        {
        }
    }
}
