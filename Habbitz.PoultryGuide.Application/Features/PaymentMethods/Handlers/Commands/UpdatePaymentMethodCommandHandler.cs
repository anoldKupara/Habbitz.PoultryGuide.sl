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
    public class UpdatePaymentMethodCommandHandler : IRequestHandler<UpdatePaymentMethodCommand, Unit>
    {
        private readonly IPaymentMethodRepository _paymentMethodRepository;
        private readonly IMapper _mapper;

        public UpdatePaymentMethodCommandHandler(IPaymentMethodRepository paymentMethodRepository, IMapper mapper)
        {
            _paymentMethodRepository = paymentMethodRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdatePaymentMethodCommand request, CancellationToken cancellationToken)
        {
            var paymentMethod = await _paymentMethodRepository.Get(request.PaymentMethodDto.Id);
            _mapper.Map(request.PaymentMethodDto, paymentMethod);
            await _paymentMethodRepository.Update(paymentMethod);
            return Unit.Value;
        }
    }
}
