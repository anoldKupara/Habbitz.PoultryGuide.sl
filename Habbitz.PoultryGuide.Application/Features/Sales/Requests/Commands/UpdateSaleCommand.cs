using Habbitz.PoultryGuide.Application.DTOs.Sales;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Sales.Requests.Commands
{
    public class UpdateSaleCommand : IRequest<Unit>
    {
        public UpdateSaleDto SaleDto { get; set; }
    }
}