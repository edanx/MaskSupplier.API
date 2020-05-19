using AutoMapper;
using MaskSupplier.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MaskSupplier.Domain.Commands.Supplier.AddSupplier
{
    public class AddSupplierCommandHandler : IRequestHandler<AddSupplierCommand, Unit>
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMaskRepository _maskRepository;
        private readonly IMapper _mapper;

        public AddSupplierCommandHandler(ISupplierRepository supplierRepository, IMaskRepository maskRepository, IMapper mapper)
        {
            _supplierRepository = supplierRepository;
            _maskRepository = maskRepository;
            _mapper = mapper;
        }
        public Task<Unit> Handle(AddSupplierCommand request, CancellationToken cancellationToken)
        {
            var supplier = _mapper.Map<Models.Supplier>(request);
            _supplierRepository.Add(supplier);
            _supplierRepository.SaveChanges();
            foreach (var mask in request.Masks)
            {
                var result = _mapper.Map<Domain.Models.Mask>(mask);
                result.SupplierId = supplier.Id;
                _maskRepository.Add(result);
            }
            _maskRepository.SaveChanges();
            
            return Task.FromResult(Unit.Value);
        }
    }
}
