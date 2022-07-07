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
    public class GetCurrencyListRequestHandler : IRequestHandler<GetCurrencyListRequest, List<CurrencyDto>>
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IMapper _mapper;

        public GetCurrencyListRequestHandler(ICurrencyRepository currencyRepository, IMapper mapper)
        {
            _currencyRepository = currencyRepository;
            _mapper = mapper;
        }
        public  async Task<List<CurrencyDto>> Handle(GetCurrencyListRequest request, CancellationToken cancellationToken)
        {
            var currencies = await _currencyRepository.GetAll();
            return _mapper.Map<List<CurrencyDto>>(currencies);
        }
    }
}
