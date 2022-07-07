using Habbitz.PoultryGuide.Application.DTOs.Currencies;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Currencies.Requests.Commands
{
    public class UpdateCurrencyCommand : IRequest<Unit>
    {
        public UpdateCurrencyDto CurrencyDto { get; set; }
    }
}
