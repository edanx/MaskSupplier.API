using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MaskSupplier.Domain.Enums
{
    public enum CityRiskEnum
    {
        [Description("Sem risco")]
        NULL = 1,
        [Description("Baixo")]
        LOW = 2,
        [Description("Médio")]
        MEDIUM = 3,
        [Description("Alto")]
        HIGH = 4

    }
}
