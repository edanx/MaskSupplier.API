using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaskSupplier.Domain.Queries.City.GetCity
{
    public class GetCityQuery : IRequest<List<GetCityQueryResponse>>
    {
    }
}
