using Habbitz.PoultryGuide.Application.DTOs.PaymentMethods;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.PaymentMethods.Requests.Queries
{
    public class GetPaymentMethodDetailRequest : IRequest<PaymentMethodDto>
    {
        public int Id { get; set; }
    }
}