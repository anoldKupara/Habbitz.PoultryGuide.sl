using AutoMapper;
using Habbitz.PoultryGuide.Application.DTOs.PaymentMethods;
using Habbitz.PoultryGuide.Application.Features.PaymentMethods.Requests.Queries;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.PaymentMethods.Handlers.Queries
{
    public class GetPaymentMethodDetailRequestHandler : IRequestHandler<GetPaymentMethodDetailRequest, PaymentMethodDto>
    {
        private readonly IPaymentMethodRepository _paymentMethodRepository;
        private readonly IMapper _mapper;

        public GetPaymentMethodDetailRequestHandler(IPaymentMethodRepository paymentMethodRepository, IMapper mapper)
        {
            _paymentMethodRepository = paymentMethodRepository;
            _mapper = mapper;
        }
        public async Task<PaymentMethodDto> Handle(GetPaymentMethodDetailRequest request, CancellationToken cancellationToken)
        {
            var paymentMethod = await _paymentMethodRepository.Get(request.Id);
            return _mapper.Map<PaymentMethodDto>(paymentMethod);
        }
    }
}
