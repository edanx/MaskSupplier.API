using MaskSupplier.Service.Enums;
using MaskSupplier.Service.Helpers;
using MaskSupplier.Service.Interface;
using System;

namespace MaskSupplier.Service
{
    public class CityRiskService : ICityRiskService
    {
        public CityRiskService()
        {

        }

        public string CalculateRisk(int infected)
        {
            if (infected == 0) return EnumHelper.GetDescription(CityRiskEnum.NULL);
            if (infected > 0 && infected < 50) return EnumHelper.GetDescription(CityRiskEnum.LOW);
            else if (infected >= 50 && infected <= 100) return EnumHelper.GetDescription(CityRiskEnum.MEDIUM);
            else return EnumHelper.GetDescription(CityRiskEnum.HIGH);
        }
    }
}
