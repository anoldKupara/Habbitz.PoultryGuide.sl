using AutoMapper;
using Habbitz.PoultryGuide.Application.Features.PaymentMethods.Requests.Commands;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.PaymentMethods.Handlers.Commands
{
    public class DeletePaymentMethodCommandHandler : IRequestHandler<DeletePaymentMethodCommand>
    {
        private readonly IPaymentMethodRepository _paymentMethodRepository;
        private readonly IMapper _mapper;

        public DeletePaymentMethodCommandHandler(IPaymentMethodRepository paymentMethodRepository, IMapper mapper)
        {
            _paymentMethodRepository = paymentMethodRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeletePaymentMethodCommand request, CancellationToken cancellationToken)
        {
            var paymentMethod = await _paymentMethodRepository.Get(request.Id);
            await _paymentMethodRepository.Delete(paymentMethod);
            return Unit.Value;
        }
    }
}
