using AutoMapper;
using Habbitz.PoultryGuide.Application.Features.PaymentMethods.Requests.Commands;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using Habbitz.PoultryGuide.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.PaymentMethods.Handlers.Commands
{
    public class CreatePaymentMethodCommandHandler : IRequestHandler<CreatePaymentMethodCommand, int>
    {
        private readonly IPaymentMethodRepository _paymentMethodRepository;
        private readonly IMapper _mapper;

        public CreatePaymentMethodCommandHandler(IPaymentMethodRepository paymentMethodRepository, IMapper mapper)
        {
            _paymentMethodRepository = paymentMethodRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreatePaymentMethodCommand request, CancellationToken cancellationToken)
        {
            var paymentMethod = _mapper.Map<PaymentMethod>(request.PaymentMethodDto);
            paymentMethod = await _paymentMethodRepository.Add(paymentMethod);
            return paymentMethod.Id;
        }
    }
}
