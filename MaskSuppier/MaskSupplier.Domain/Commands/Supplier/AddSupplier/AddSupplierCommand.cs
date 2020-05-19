using MaskSupplier.Domain.Dto;
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

    public class Mask
    {
        public string Model { get; set; }
        public float Price { get; set; }
        public long SupplierId { get; set; }
    }
}
