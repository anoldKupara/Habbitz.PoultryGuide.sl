using Habbitz.PoultryGuide.Application.DTOs.Budgets;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Budgets.Requests.Queries
{
    public class GetBudgetDetailRequest : IRequest<BudgetDto>
    {
        public int Id { get; set; }
    }
}
