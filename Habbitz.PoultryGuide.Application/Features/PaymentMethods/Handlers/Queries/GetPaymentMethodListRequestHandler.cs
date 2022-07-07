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
    public class GetPaymentMethodListRequestHandler : IRequestHandler<GetPaymentMethodListRequest, List<PaymentMethodDto>>
    {
        private readonly IPaymentMethodRepository _paymentMethodRepository;
        private readonly IMapper _mapper;

        public GetPaymentMethodListRequestHandler(IPaymentMethodRepository paymentMethodRepository, IMapper mapper)
        {
            _paymentMethodRepository = paymentMethodRepository;
            _mapper = mapper;
        }
        public async Task<List<PaymentMethodDto>> Handle(GetPaymentMethodListRequest request, CancellationToken cancellationToken)
        {
            var paymentMethods = await _paymentMethodRepository.GetAll();
            return _mapper.Map<List<PaymentMethodDto>>(paymentMethods);
        }
    }
}
