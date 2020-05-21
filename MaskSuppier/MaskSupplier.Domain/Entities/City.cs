using System;
using System.Collections.Generic;
using System.Text;

namespace MaskSupplier.Domain.Entities
{

    public class City
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ZipCode { get; set; }
        public int Infecteds { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public object Risk { get; internal set; }

        public City()
        {

        }
    }
}
