using MaskSupplier.Domain.Queries.City.GetCity;
using MaskSupplier.Domain.Queries.City.GetCityById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MaskSupplier.API.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class CityController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<List<GetCityQueryResponse>> Get()
        {
            return _mediator.Send(new GetCityQuery());
        }
        
        [HttpGet("{id}")]
        public Task<GetCityByIdQueryResponse> Get(long id)
        {
            return _mediator.Send(new GetCityByIdQuery(id));
        }
    }
}
