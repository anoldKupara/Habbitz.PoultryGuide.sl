using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Currencies.Requests.Commands
{
    public class DeleteCurrencyCommand : IRequest
    {
        public int Id { get; set; }
    }
}
