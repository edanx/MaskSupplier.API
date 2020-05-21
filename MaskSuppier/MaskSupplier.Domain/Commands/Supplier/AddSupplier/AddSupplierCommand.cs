using MaskSupplier.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Net;

namespace MaskSupplier.Domain.Commands.Supplier.AddSupplier
{
    public class AddSupplierCommand : IRequest<Unit>
    {
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public List<Mask> Masks { get; set; }
    }


}
