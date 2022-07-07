using AutoMapper;
using Habbitz.PoultryGuide.Application.DTOs.Currencies;
using Habbitz.PoultryGuide.Application.Features.Currencies.Requests.Queries;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Currencies.Handlers.Queries
{
    public class GetCurrencyDetailRequestHandler : IRequestHandler<GetCurrencyDetailRequest, CurrencyDto>
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IMapper _mapper;

        public GetCurrencyDetailRequestHandler(ICurrencyRepository currencyRepository, IMapper mapper)
        {
            _currencyRepository = currencyRepository;
            _mapper = mapper;
        }
        public async Task<CurrencyDto> Handle(GetCurrencyDetailRequest request, CancellationToken cancellationToken)
        {
            var currency = await _currencyRepository.Get(request.Id);
            return _mapper.Map<CurrencyDto>(currency);
        }
    }
}
