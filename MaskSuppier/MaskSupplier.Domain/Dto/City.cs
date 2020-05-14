using System;
using System.Collections.Generic;
using System.Text;

namespace MaskSupplier.Domain.Dto
{
    public class City
    {
        public string Name { get; set; }
        public string ZipCode { get; set; }
        public int Infecteds { get; set; }

        public List<Supplier> Suppliers { get; set; }
    }
}
