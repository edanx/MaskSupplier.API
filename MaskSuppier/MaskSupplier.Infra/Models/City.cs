using System.Collections.Generic;

namespace MaskSupplier.Infra.Models
{
    public class City
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ZipCode { get; set; }
        public int Infecteds { get; set; }
       // public List<Supplier> Suppliers { get; set; }
    }
}
