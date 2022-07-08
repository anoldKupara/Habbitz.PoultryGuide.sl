using Habbitz.PoultryGuide.Application.DTOs.Sales;
using Habbitz.PoultryGuide.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Sales.Requests.Commands
{
    public class CreateSaleCommand : IRequest<BaseCommandResponse>
    {
        public SaleDto SaleDto { get; set; }
    }
}
