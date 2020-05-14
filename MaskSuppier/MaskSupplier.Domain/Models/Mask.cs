using System;
using System.Collections.Generic;
using System.Text;

namespace MaskSupplier.Domain.Models
{
    public class Mask
    {
        public long Id { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public long SupplierId { get; set; }

        public Supplier Supplier { get; set; }
    }
}
