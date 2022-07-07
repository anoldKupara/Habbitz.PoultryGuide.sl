using AutoMapper;
using Habbitz.PoultryGuide.Application.Features.Currencies.Requests.Commands;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Currencies.Handlers.Commands
{
    public class UpdateCurrencyCommandHandler : IRequestHandler<UpdateCurrencyCommand, Unit>
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IMapper _mapper;

        public UpdateCurrencyCommandHandler(ICurrencyRepository currencyRepository, IMapper mapper)
        {
            _currencyRepository = currencyRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateCurrencyCommand request, CancellationToken cancellationToken)
        {
            var currency = await _currencyRepository.Get(request.CurrencyDto.Id);
            _mapper.Map(request.CurrencyDto, currency);
            await _currencyRepository.Update(currency);
            return Unit.Value;
        }
    }
}
