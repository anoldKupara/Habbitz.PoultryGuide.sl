using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.PaymentMethods.Requests.Commands
{
    public class DeletePaymentMethodCommand : IRequest
    {
        public int Id { get; set; }
    }
}
