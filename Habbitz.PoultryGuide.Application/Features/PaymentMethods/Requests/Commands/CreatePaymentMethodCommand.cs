using Habbitz.PoultryGuide.Application.DTOs.PaymentMethods;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.PaymentMethods.Requests.Commands
{
    public class CreatePaymentMethodCommand : IRequest<int>
    {
        public PaymentMethodDto PaymentMethodDto { get; set; }
    }
}
