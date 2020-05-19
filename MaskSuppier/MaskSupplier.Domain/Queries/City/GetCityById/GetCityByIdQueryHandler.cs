using AutoMapper;
using MaskSupplier.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MaskSupplier.Domain.Queries.City.GetCityById
{
    class GetCityByIdQueryHandler : IRequestHandler<GetCityByIdQuery, GetCityByIdQueryResponse>
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;
        public GetCityByIdQueryHandler(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }

        public Task<GetCityByIdQueryResponse> Handle(GetCityByIdQuery request, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<GetCityByIdQueryResponse> (_cityRepository.GetByIdWithSupplierAndMasks(request.Id));
            return Task.FromResult(result);
        }
    }
}
