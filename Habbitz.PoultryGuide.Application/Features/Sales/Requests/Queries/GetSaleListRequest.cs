using Habbitz.PoultryGuide.Application.DTOs.Sales;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Sales.Requests.Queries
{
    public class GetSaleListRequest : IRequest<List<SaleDto>>
    {
    }
}
