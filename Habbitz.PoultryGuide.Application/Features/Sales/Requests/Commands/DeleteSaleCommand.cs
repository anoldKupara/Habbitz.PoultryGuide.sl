using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Sales.Requests.Commands
{
    public class DeleteSaleCommand : IRequest
    {
        public int Id { get; set; }
    }
}
