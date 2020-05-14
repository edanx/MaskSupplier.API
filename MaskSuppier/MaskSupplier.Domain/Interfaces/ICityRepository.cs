using MaskSupplier.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaskSupplier.Domain.Interfaces
{
    public interface ICityRepository : IRepository<City>
    {
        List<City> GetWithSupplierAndMasks();
    }
}
