using System;
using System.Collections.Generic;
using System.Text;

namespace MaskSupplier.Service.Interface
{
    public interface ICityRiskService
    {
        string CalculateRisk(int infected);
    }
}
