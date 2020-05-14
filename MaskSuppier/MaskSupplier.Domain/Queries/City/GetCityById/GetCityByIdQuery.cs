using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaskSupplier.Domain.Queries.City.GetCityById
{
    public class GetCityByIdQuery : IRequest<GetCityByIdQueryResponse>
    {
        public GetCityByIdQuery(long id)
        {
            Id = id;
        }

        public long Id { get; set; }
    }
}
