using MaskSupplier.Domain.Entities;
using System.Collections.Generic;

namespace MaskSupplier.Domain.Queries.City.GetCityById
{
    public class GetCityByIdQueryResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ZipCode { get; set; }
        public int Infecteds { get; set; }

        public List<Supplier> Suppliers{ get; set; }
    }
}
