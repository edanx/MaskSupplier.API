
using MaskSupplier.Domain.Commands.Supplier.AddSupplier;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MaskSupplier.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SupplierController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SupplierController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public Task Post([FromBody] AddSupplierCommand command)
        {
            return _mediator.Send(command);
        }
    }
}
