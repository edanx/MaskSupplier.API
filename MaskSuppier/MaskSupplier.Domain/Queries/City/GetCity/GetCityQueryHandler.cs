using AutoMapper;
using MaskSupplier.Domain.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MaskSupplier.Domain.Queries.City.GetCity
{
    public class GetCityQueryHandler : IRequestHandler<GetCityQuery, List<GetCityQueryResponse>>
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;
        public GetCityQueryHandler(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }

        public Task<List<GetCityQueryResponse>> Handle(GetCityQuery request, CancellationToken cancellationToken)
        {
            var teste = _cityRepository.GetWithSupplierAndMasks();
            var result = _mapper.Map<List<GetCityQueryResponse>>(_cityRepository.GetWithSupplierAndMasks().ToList());
            return Task.FromResult(result);
        }
    }
}
