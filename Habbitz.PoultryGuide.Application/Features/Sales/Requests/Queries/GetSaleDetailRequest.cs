using Habbitz.PoultryGuide.Application.DTOs.Sales;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Sales.Requests.Queries
{
    public class GetSaleDetailRequest : IRequest<SaleDto>
    {
        public int Id { get; set; }
    }
}