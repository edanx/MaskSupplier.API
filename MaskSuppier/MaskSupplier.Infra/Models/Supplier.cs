using System;
using System.Collections.Generic;
using System.Text;

namespace MaskSupplier.Infra.Models
{
    public class Supplier
    {
        public long Id { get; set; }
        public string Name{ get; set; }
        public string CNPJ { get; set; }

        public List<Mask> Masks{ get; set; }
        public City City { get; set; }
    }
}
