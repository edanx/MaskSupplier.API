using AutoMapper;
using MaskSupplier.Domain.Interfaces;
using MaskSupplier.Service.Interface;
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
        private readonly ICityRiskService _cityRiskService;
        public GetCityQueryHandler(ICityRepository cityRepository, IMapper mapper, ICityRiskService cityRiskService)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
            _cityRiskService = cityRiskService;
        }

        public Task<List<GetCityQueryResponse>> Handle(GetCityQuery request, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<List<GetCityQueryResponse>>(_cityRepository.GetAll().ToList());
            foreach (var item in result)
            {
                item.Risk = _cityRiskService.CalculateRisk(item.Infecteds);
            }
            return Task.FromResult(result);
        }
    }
}
